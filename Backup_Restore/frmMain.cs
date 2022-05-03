using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backup_Restore
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.backup_devices' table. You can move, or remove it, as needed.
            this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.backup_devicesTableAdapter.Fill(this.DS.backup_devices);
            // TODO: This line of code loads data into the 'dataSet1.databases' table. You can move, or remove it, as needed.
            this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.databasesTableAdapter.Fill(this.DS.databases);
            Program.dbName = ((DataRowView)bdsDB[bdsDB.Position])["name"].ToString();
            this.STT_BACKUPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.STT_BACKUPTableAdapter.Fill(this.DS.SP_STT_BACKUP, Program.dbName);
            lable_ThongBao.Visible = false;
            panelPhucHoi.Visible=false;
            progressBar.Visible = false;
            hienThi();
        }
        void hienThi()
        {
            if (this.bdsDevice.Find("name", Program.nameDEV) == -1)
            {
                lable_ThongBao.Visible = btnTaoDV.Enabled = true;
                btnSaoLuu.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = btnThamSoPhucHoi.Enabled = false;
            }
            else
            {
                if (bdsSTTBackup.Count > 0)
                {
                    btnXoa.Enabled = true;
                }
                else
                {
                    btnXoa.Enabled = false;
                }    

                btnSaoLuu.Enabled = true;
                btnTaoDV.Enabled = btnPhucHoi.Enabled = btnThamSoPhucHoi.Enabled = lable_ThongBao.Visible = false;
                if (this.bdsSTTBackup.Count > 0)
                {
                    btnPhucHoi.Enabled = btnThamSoPhucHoi.Enabled = btnXoa.Enabled = true;
                }
            }
        }
        private void gridView_DB_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            tbDBName.Text = ((DataRowView)bdsDB[bdsDB.Position])["name"].ToString();
            Program.dbName = ((DataRowView)bdsDB[bdsDB.Position])["name"].ToString();
            this.STT_BACKUPTableAdapter.Fill(this.DS.SP_STT_BACKUP, Program.dbName);
            Program.nameDEV = "DEV_" + ((DataRowView)bdsDB[bdsDB.Position])["name"].ToString();
            gridViewSTTBackup.Focus();
            if (bdsSTTBackup.Count > 0)
            {
                Program.banSaoLuu = 0;
            }
            hienThi();

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] selectRowsArr = gridViewSTTBackup.GetSelectedRows();
            string selectRows = "";
            String text = "";
            DialogResult dialogResult= new DialogResult();
            if (selectRowsArr.Length != 0 || checkBoxSTTBackup.Checked)
            {
                if (!checkBoxSTTBackup.Checked)
                {
                    text= "Bạn muốn xóa tất cả các bản sao lưu cũ đã chọn trước khi sao lưu?";
                }
                else
                {
                    text = "Bạn muốn xóa tất cả các bản sao lưu trên file trước khi sao lưu bản mới?";
                }
                dialogResult = MessageBox.Show(text, "THÔNG BÁO", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    {
                        if(!checkBoxSTTBackup.Checked)
                        {
                            foreach (int i in selectRowsArr)
                            {
                                selectRows += ((DataRowView)bdsSTTBackup[i])["position"].ToString() + ",";
                            }
                        }    
                        else
                        {
                            for(int i = 0; i < bdsSTTBackup.Count; i++)
                            {
                                selectRows += ((DataRowView)bdsSTTBackup[i])["position"].ToString() + ",";
                            }
                        }    
                        selectRows = selectRows.TrimEnd(',');
                        try
                        {
                            int i = Program.ExecSqlNonQuery("EXEC msdb.dbo.sp_delete_all_database_backuphistory '" + Program.dbName + "', '" + selectRows + "'", Program.connstr, "");
                            if (i != 0)
                            {
                                MessageBox.Show("Lỗi xóa các bản sao lưu đã chọn\n", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa các bản sao lưu đã chọn\n" + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            try
            {
                this.progressBar.Visible = true;
                string cmd = "";
                cmd = "BACKUP DATABASE " + Program.dbName + " TO DEV_" + Program.dbName + " with name='" + Program.dbName + "-Full Database Backup'";
                if (checkBoxSTTBackup.Checked && dialogResult == DialogResult.OK)
                {
                    cmd += ",INIT";
                }

                int ret = Program.ExecSqlNonQuery(cmd, Program.connstr, "");
                this.progressBar.Value = 100;
                checkBoxSTTBackup.Checked = false;
                if (ret == 0)
                {
                    MessageBox.Show("Đã backup thành công!", "THÔNG BÁO");
                }
                this.progressBar.Visible = false;
                this.STT_BACKUPTableAdapter.Fill(this.DS.SP_STT_BACKUP, Program.dbName);
                hienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sao lưu\n" + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cmd = "exec sp_addumpdevice 'disk', 'DEV_" + Program.dbName + "', '"+Program.strDefaultPath+"\\DEV_" + Program.dbName + ".bak'";
            try
            {
                progressBar.Visible = true;
                progressBar.Value = 0;
                int ret = Program.ExecSqlNonQuery(cmd, Program.connstr, "");
                progressBar.Value = 100;
                if (ret == 0)
                {
                    MessageBox.Show("Tạo Device Thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.backup_devicesTableAdapter.Fill(this.DS.backup_devices);
                    hienThi();
                }
                progressBar.Visible = false;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo device thất bại\n" + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Program.frmChinh.Visible = false;
                Program.frmDN.Visible = true;
                Program.frmDN.Show();
            }

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxSTTBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSTTBackup.Checked)
            {
                for (int i = 0; i < bdsSTTBackup.Count; i++)
                {
                    gridViewSTTBackup.SelectRow(i);
                   
                }
            }
            else
            {
                for (int i = 0; i < bdsSTTBackup.Count; i++)
                {
                    gridViewSTTBackup.UnselectRow(i);
                }

            }
        }

        private void btnThamSoPhucHoi_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThamSoPhucHoi.Checked)
            {
                panelPhucHoi.Visible = true;
            }
            else
            {
                panelPhucHoi.Visible = false;
            }
        }

   
        private void gridViewSTTBackup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] selectRowsArr = gridViewSTTBackup.GetSelectedRows();
            string selectRows = "";
            if (selectRowsArr.Length != 0)
            
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa tất cả các bản sao lưu cũ đã chọn?", "THÔNG BÁO", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    {
                        foreach (int i in selectRowsArr)
                        {
                            selectRows += ((DataRowView)bdsSTTBackup[i])["position"].ToString() + ",";
                        }
                        selectRows = selectRows.TrimEnd(',');
                        try
                        {
                            int i = Program.ExecSqlNonQuery("EXEC msdb.dbo.sp_delete_all_database_backuphistory '" + Program.dbName + "', '" + selectRows + "'", Program.connstr, "");
                            if (i == 0)
                            {
                                this.STT_BACKUPTableAdapter.Fill(this.DS.SP_STT_BACKUP, Program.dbName);
                                MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                                hienThi();
                               
                            }
                            else
                            {
                                MessageBox.Show("Lỗi xóa các bản sao lưu đã chọn\n", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }    
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa các bản sao lưu đã chọn\n" + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn các bản sao lưu cần xóa!", "", MessageBoxButtons.OK);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // gridViewSTTBackup.OptionsSelection.MultiSelect = false;
            int err;
            if (gridViewSTTBackup.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Chưa chọn bản sao lưu để phục hồi!", "", MessageBoxButtons.OK);
                return;
            }
            if (gridViewSTTBackup.GetSelectedRows().Length > 1)
            {
                MessageBox.Show("Chỉ được chọn một bản sao lưu để phục hồi!", "", MessageBoxButtons.OK);
                return;
            }
            Program.banSaoLuu = Int32.Parse(((DataRowView)bdsSTTBackup[gridViewSTTBackup.GetSelectedRows()[0]])["position"].ToString());

            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            int ii;
            progressBar.Visible = true;
            for (ii = progressBar.Minimum; ii <= progressBar.Maximum / 4; ii++)
            {
                progressBar.Value = ii;
            }
            string strRestore;
            strRestore = "ALTER DATABASE " + Program.dbName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + "USE tempdb ";
            if (!btnThamSoPhucHoi.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn phục hồi về", "THÔNG BÁO", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    strRestore += "RESTORE DATABASE " + Program.dbName + " FROM " + Program.nameDEV + " WITH FILE= " + Program.banSaoLuu + ", REPLACE " + " ALTER DATABASE " + Program.dbName + " SET MULTI_USER";
                    err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi CSDL.");
                    if (err == 0)
                    {
                        for (; ii <= progressBar.Maximum; ii++)
                        {
                            progressBar.Value = ii;
                        }
                        MessageBox.Show("Phục hồi thành công!", "", MessageBoxButtons.OK);
                        strRestore = "ALTER DATABASE " + Program.dbName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + "USE tempdb ";
                        progressBar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi phục hồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        strRestore = "ALTER DATABASE " + Program.dbName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + "USE tempdb ";
                        progressBar.Visible = false;
                        return;
                    }
                }
                else
                {
                    progressBar.Visible = false;
                }
            }
            else
            {
                DateTime ngaygioBK = DateTime.Parse(((DataRowView)bdsSTTBackup[gridViewSTTBackup.GetSelectedRows()[0]])["backup_start_date"].ToString());
                DateTime dateStopAt = dateStop.DateTime;
                DateTime timeStopAt = timeStop.Time;
                string strNgayGioRestore = dateStopAt.Day + "/" + dateStopAt.Month + "/" + dateStopAt.Year + " " + timeStop.Time.Hour + ":" + timeStop.Time.Minute + ":" + timeStop.Time.Second;
                DateTime ngayGioRestore = DateTime.Parse(strNgayGioRestore);
                if (ngaygioBK < ngayGioRestore && ngayGioRestore.AddMinutes(1) < DateTime.Now)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn phục hồi database " + Program.dbName + " từ thời điểm " + ngaygioBK + " đến thời điểm " + timeStopAt + "?", "CẢNH BÁO", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        try
                        {
                            strRestore += "BACKUP LOG " + Program.dbName + " TO DISK = '" + Program.strDefaultPath + Program.dbName + "_LOG.trn' WITH INIT, NORECOVERY " +
                            " USE master      " +
                            " RESTORE DATABASE " + Program.dbName + " FROM " + Program.nameDEV + " WITH FILE=" + Program.banSaoLuu + ",  NORECOVERY ";
                            err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi Phục hồi CSDL với NORECOVERY . Bạn thực hiện lại lệnh.  ");
                            if (err == 0)
                                for (; ii <= progressBar.Maximum * 3 / 4; ii++)
                                    progressBar.Value = ii;
                            else
                            {
                                progressBar.Visible = false;
                                strRestore = "   RESTORE DATABASE " + Program.dbName + " FROM " + Program.nameDEV + " WITH FILE=" + Program.banSaoLuu +
                                             " ALTER DATABASE " + Program.dbName + "  SET MULTI_USER ";
                                Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                                return;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi\n" + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        strRestore = " USE TEMPDB SET DATEFORMAT DMY  " +
                            "    RESTORE DATABASE " + Program.dbName + " FROM DISK = '" + Program.strDefaultPath + Program.dbName + "_LOG.trn'" +
                                         " WITH STOPAT=N'" + dateStop.Text + " " + timeStop.Text + "' , RECOVERY    ";
                        try
                        {
                            err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi Phục hồi CSDL TỪ FILE LOG.");
                            if (err == 0)
                            {
                                for (; ii <= progressBar.Maximum; ii++)
                                {
                                    progressBar.Value = ii;
                                }
                                MessageBox.Show("Phục hồi thành công!", "", MessageBoxButtons.OK);
                                strRestore = "ALTER DATABASE " + Program.dbName + "  SET MULTI_USER ";
                                Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                                progressBar.Visible = false;

                            }
                            else
                            {
                                progressBar.Visible = false;
                                strRestore = "   RESTORE DATABASE " + Program.dbName + " FROM " + Program.nameDEV + " WITH FILE=" + Program.banSaoLuu +
                                              " ALTER DATABASE " + Program.dbName + "  SET MULTI_USER ";
                                Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi\n" + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Thời gian không hợp lệ");
                    return;
                }

            }
        }

        private void btnPhucHoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // gridViewSTTBackup.OptionsSelection.MultiSelect = false;
            int err;
            if (gridViewSTTBackup.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Chưa chọn bản sao lưu để phục hồi!", "", MessageBoxButtons.OK);
                return;
            }
            if (gridViewSTTBackup.GetSelectedRows().Length > 1)
            {
                MessageBox.Show("Chỉ được chọn một bản sao lưu để phục hồi!", "", MessageBoxButtons.OK);
                return;
            }
            Program.banSaoLuu = Int32.Parse(((DataRowView)bdsSTTBackup[gridViewSTTBackup.GetSelectedRows()[0]])["position"].ToString());

            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            int ii;
            progressBar.Visible = true;
            for (ii = progressBar.Minimum; ii <= progressBar.Maximum / 4; ii++)
            {
                progressBar.Value = ii;
            }
            string strRestore;
            strRestore = "ALTER DATABASE " + Program.dbName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + "USE tempdb ";//ngat ket noi
            if (!btnThamSoPhucHoi.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn phục hồi?", "THÔNG BÁO", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    strRestore += "RESTORE DATABASE " + Program.dbName + " FROM " + Program.nameDEV + " WITH FILE= " + Program.banSaoLuu + ", REPLACE " + " ALTER DATABASE " + Program.dbName + " SET MULTI_USER";
                    err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi CSDL.");
                    if (err == 0)
                    {
                        for (; ii <= progressBar.Maximum; ii++)
                        {
                            progressBar.Value = ii;
                        }
                        MessageBox.Show("Phục hồi thành công!", "", MessageBoxButtons.OK);
                        strRestore = "ALTER DATABASE " + Program.dbName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + "USE tempdb ";
                        progressBar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi phục hồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        strRestore = "ALTER DATABASE " + Program.dbName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + "USE tempdb ";
                        progressBar.Visible = false;
                        return;
                    }
                }
                else
                {
                    progressBar.Visible = false;
                }
            }
            else
            {
                DateTime ngaygioBK = DateTime.Parse(((DataRowView)bdsSTTBackup[gridViewSTTBackup.GetSelectedRows()[0]])["backup_start_date"].ToString());
                DateTime dateStopAt = dateStop.DateTime;
                DateTime timeStopAt = timeStop.Time;
                string strNgayGioRestore = dateStopAt.Day + "/" + dateStopAt.Month + "/" + dateStopAt.Year + " " + timeStop.Time.Hour + ":" + timeStop.Time.Minute + ":" + timeStop.Time.Second;
                DateTime ngayGioRestore = DateTime.Parse(strNgayGioRestore);
                if (ngaygioBK < ngayGioRestore && ngayGioRestore.AddMinutes(1) < DateTime.Now)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn phục hồi database " + Program.dbName + " từ thời điểm " + ngaygioBK + " đến thời điểm " + ngayGioRestore + "?", "CẢNH BÁO", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        try
                        {
                            strRestore += "BACKUP LOG " + Program.dbName + " TO DISK = '" + Program.strDefaultPath + Program.dbName + "_LOG.trn' WITH INIT, NORECOVERY " +
                            " USE TEMPDB      " +
                            " RESTORE DATABASE " + Program.dbName + " FROM " + Program.nameDEV + " WITH FILE=" + Program.banSaoLuu + ",  NORECOVERY ";
                            err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi Phục hồi CSDL với NORECOVERY . Bạn thực hiện lại lệnh.  ");
                            if (err == 0)
                                for (; ii <= progressBar.Maximum * 3 / 4; ii++)
                                    progressBar.Value = ii;
                            else
                            {
                                progressBar.Visible = false;
                                strRestore = "   RESTORE DATABASE " + Program.dbName + " FROM " + Program.nameDEV + " WITH FILE=" + Program.banSaoLuu +
                                             " ALTER DATABASE " + Program.dbName + "  SET MULTI_USER ";
                                Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                                return;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi\n" + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        strRestore = " USE TEMPDB SET DATEFORMAT DMY  " +
                            "    RESTORE DATABASE " + Program.dbName + " FROM DISK = '" + Program.strDefaultPath + Program.dbName + "_LOG.trn'" +
                                         " WITH STOPAT=N'" + dateStop.Text + " " + timeStop.Text + "' , RECOVERY    ";
                        try
                        {
                            err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi Phục hồi CSDL TỪ FILE LOG.");
                            if (err == 0)
                            {
                                for (; ii <= progressBar.Maximum; ii++)
                                {
                                    progressBar.Value = ii;
                                }
                                MessageBox.Show("Phục hồi thành công!", "", MessageBoxButtons.OK);
                                strRestore = "ALTER DATABASE " + Program.dbName + "  SET MULTI_USER ";
                                Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                                progressBar.Visible = false;

                            }
                            else
                            {
                                progressBar.Visible = false;
                                strRestore = "   RESTORE DATABASE " + Program.dbName + " FROM " + Program.nameDEV + " WITH FILE=" + Program.banSaoLuu +
                                              " ALTER DATABASE " + Program.dbName + "  SET MULTI_USER ";
                                Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi\n" + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        progressBar.Visible = false;
                    }    
                }
                else
                {
                    MessageBox.Show("Thời gian không hợp lệ");
                    return;
                }

            }
        }
    }
}
