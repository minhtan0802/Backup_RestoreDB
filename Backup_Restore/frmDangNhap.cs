using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Restore
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (tbTaiKhoan.Text.Trim() == "" || tbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản và mật khẩu không được để trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = tbTaiKhoan.Text;
            Program.password = tbMatKhau.Text;
            Program.servername = tbServer.Text;
            if (Program.KetNoi() == 0) return;
            Program.frmChinh = new frmMain();
            Program.frmChinh.Activate();
            Program.frmChinh.Show();
            this.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát hoàn toàn chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}