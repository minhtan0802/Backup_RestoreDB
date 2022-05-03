
namespace Backup_Restore
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThamSoPhucHoi = new DevExpress.XtraBars.BarCheckItem();
            this.btnTaoDV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsDB = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new Backup_Restore.DataSet1();
            this.gridView_DB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkBoxSTTBackup = new System.Windows.Forms.CheckBox();
            this.gcSTTBackup = new DevExpress.XtraGrid.GridControl();
            this.bdsSTTBackup = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewSTTBackup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tbDBName = new System.Windows.Forms.Label();
            this.lable_ThongBao = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelPhucHoi = new System.Windows.Forms.Panel();
            this.dateStop = new DevExpress.XtraEditors.DateEdit();
            this.timeStop = new DevExpress.XtraEditors.TimeEdit();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.databasesTableAdapter = new Backup_Restore.DataSet1TableAdapters.databasesTableAdapter();
            this.bdsDevice = new System.Windows.Forms.BindingSource(this.components);
            this.backup_devicesTableAdapter = new Backup_Restore.DataSet1TableAdapters.backup_devicesTableAdapter();
            this.tableAdapterManager = new Backup_Restore.DataSet1TableAdapters.TableAdapterManager();
            this.STT_BACKUPTableAdapter = new Backup_Restore.DataSet1TableAdapters.SP_STT_BACKUPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSTTBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSTTBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSTTBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.panelPhucHoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSaoLuu,
            this.barButtonItem2,
            this.barCheckItem2,
            this.barToggleSwitchItem1,
            this.btnThamSoPhucHoi,
            this.btnTaoDV,
            this.btnXoa,
            this.btnThoat,
            this.btnPhucHoi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaoLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThamSoPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaoDV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu";
            this.btnSaoLuu.Id = 0;
            this.btnSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.Image")));
            this.btnSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.LargeImage")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 9;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick_1);
            // 
            // btnThamSoPhucHoi
            // 
            this.btnThamSoPhucHoi.Caption = "Tham số phục hồi theo thời gian";
            this.btnThamSoPhucHoi.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.btnThamSoPhucHoi.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnThamSoPhucHoi.Id = 5;
            this.btnThamSoPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThamSoPhucHoi.ImageOptions.Image")));
            this.btnThamSoPhucHoi.Name = "btnThamSoPhucHoi";
            this.btnThamSoPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThamSoPhucHoi.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThamSoPhucHoi_CheckedChanged);
            // 
            // btnTaoDV
            // 
            this.btnTaoDV.Caption = "Tạo Device Sao Lưu";
            this.btnTaoDV.Id = 6;
            this.btnTaoDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoDV.ImageOptions.Image")));
            this.btnTaoDV.Name = "btnTaoDV";
            this.btnTaoDV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaoDV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoDV_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa ";
            this.btnXoa.Id = 7;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1431, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 608);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1431, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 558);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1431, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 558);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Phục hồi";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.Caption = "Tham số phục hồi theo thời gian";
            this.barCheckItem2.Id = 3;
            this.barCheckItem2.Name = "barCheckItem2";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 4;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gridControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 558);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsDB;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView_DB;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(273, 439);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DB});
            // 
            // bdsDB
            // 
            this.bdsDB.DataMember = "databases";
            this.bdsDB.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DataSet1";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView_DB
            // 
            this.gridView_DB.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_DB.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView_DB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.gridView_DB.GridControl = this.gridControl1;
            this.gridView_DB.Name = "gridView_DB";
            this.gridView_DB.OptionsView.ShowGroupPanel = false;
            this.gridView_DB.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_DB_FocusedRowChanged);
            // 
            // colname
            // 
            this.colname.AppearanceCell.Options.UseTextOptions = true;
            this.colname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colname.AppearanceHeader.Options.UseTextOptions = true;
            this.colname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colname.Caption = "DANH SÁCH DATABASE";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 25;
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkBoxSTTBackup);
            this.panelControl1.Controls.Add(this.gcSTTBackup);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(276, 50);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1155, 284);
            this.panelControl1.TabIndex = 5;
            // 
            // checkBoxSTTBackup
            // 
            this.checkBoxSTTBackup.AutoSize = true;
            this.checkBoxSTTBackup.Location = new System.Drawing.Point(77, 243);
            this.checkBoxSTTBackup.Name = "checkBoxSTTBackup";
            this.checkBoxSTTBackup.Size = new System.Drawing.Size(403, 21);
            this.checkBoxSTTBackup.TabIndex = 2;
            this.checkBoxSTTBackup.Text = "Xóa tất cả các bản sao lưu trên File trước khi sao lưu bản mới";
            this.checkBoxSTTBackup.UseVisualStyleBackColor = true;
            this.checkBoxSTTBackup.CheckedChanged += new System.EventHandler(this.checkBoxSTTBackup_CheckedChanged);
            // 
            // gcSTTBackup
            // 
            this.gcSTTBackup.DataSource = this.bdsSTTBackup;
            this.gcSTTBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSTTBackup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcSTTBackup.Location = new System.Drawing.Point(2, 53);
            this.gcSTTBackup.MainView = this.gridViewSTTBackup;
            this.gcSTTBackup.MenuManager = this.barManager1;
            this.gcSTTBackup.Name = "gcSTTBackup";
            this.gcSTTBackup.Size = new System.Drawing.Size(1151, 172);
            this.gcSTTBackup.TabIndex = 1;
            this.gcSTTBackup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSTTBackup});
            this.gcSTTBackup.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // bdsSTTBackup
            // 
            this.bdsSTTBackup.DataMember = "SP_STT_BACKUP";
            this.bdsSTTBackup.DataSource = this.DS;
            // 
            // gridViewSTTBackup
            // 
            this.gridViewSTTBackup.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewSTTBackup.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewSTTBackup.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewSTTBackup.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewSTTBackup.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewSTTBackup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname1,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridViewSTTBackup.GridControl = this.gcSTTBackup;
            this.gridViewSTTBackup.Name = "gridViewSTTBackup";
            this.gridViewSTTBackup.OptionsBehavior.Editable = false;
            this.gridViewSTTBackup.OptionsSelection.MultiSelect = true;
            this.gridViewSTTBackup.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewSTTBackup.OptionsView.ShowGroupPanel = false;
            this.gridViewSTTBackup.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colposition, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewSTTBackup.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSTTBackup_FocusedRowChanged);
            // 
            // colposition
            // 
            this.colposition.AppearanceCell.Options.UseTextOptions = true;
            this.colposition.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposition.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colposition.AppearanceHeader.Options.UseTextOptions = true;
            this.colposition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposition.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colposition.Caption = "Bản sao lưu thứ #";
            this.colposition.FieldName = "position";
            this.colposition.MinWidth = 25;
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.AllowEdit = false;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 1;
            this.colposition.Width = 190;
            // 
            // colname1
            // 
            this.colname1.AppearanceCell.Options.UseTextOptions = true;
            this.colname1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colname1.AppearanceHeader.Options.UseTextOptions = true;
            this.colname1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colname1.Caption = "Mô tả";
            this.colname1.FieldName = "name";
            this.colname1.MinWidth = 25;
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 2;
            this.colname1.Width = 190;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.AppearanceCell.Options.UseTextOptions = true;
            this.colbackup_start_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbackup_start_date.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbackup_start_date.AppearanceHeader.Options.UseTextOptions = true;
            this.colbackup_start_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbackup_start_date.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbackup_start_date.Caption = "Ngày giờ sao lưu";
            this.colbackup_start_date.DisplayFormat.FormatString = "d/M/yyyy HH:mm:ss";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.MinWidth = 25;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 3;
            this.colbackup_start_date.Width = 190;
            // 
            // coluser_name
            // 
            this.coluser_name.AppearanceCell.Options.UseTextOptions = true;
            this.coluser_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_name.AppearanceHeader.Options.UseTextOptions = true;
            this.coluser_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_name.Caption = "User sao lưu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 25;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 4;
            this.coluser_name.Width = 198;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tbDBName);
            this.panelControl2.Controls.Add(this.lable_ThongBao);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1151, 51);
            this.panelControl2.TabIndex = 0;
            // 
            // tbDBName
            // 
            this.tbDBName.AutoSize = true;
            this.tbDBName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDBName.Location = new System.Drawing.Point(137, 13);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(62, 21);
            this.tbDBName.TabIndex = 16;
            this.tbDBName.Text = "label1";
            // 
            // lable_ThongBao
            // 
            this.lable_ThongBao.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_ThongBao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lable_ThongBao.Appearance.Options.UseFont = true;
            this.lable_ThongBao.Appearance.Options.UseForeColor = true;
            this.lable_ThongBao.Location = new System.Drawing.Point(546, 12);
            this.lable_ThongBao.Name = "lable_ThongBao";
            this.lable_ThongBao.Size = new System.Drawing.Size(465, 17);
            this.lable_ThongBao.TabIndex = 15;
            this.lable_ThongBao.Text = "* Database chưa có Device, bạn hãy tạo Device để tiến hành sao lưu";
            this.lable_ThongBao.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên cơ sở dữ liệu:";
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.DS;
            this.dataSet1BindingSource.Position = 0;
            // 
            // panelPhucHoi
            // 
            this.panelPhucHoi.Controls.Add(this.dateStop);
            this.panelPhucHoi.Controls.Add(this.timeStop);
            this.panelPhucHoi.Controls.Add(this.progressBar);
            this.panelPhucHoi.Controls.Add(this.richTextBox1);
            this.panelPhucHoi.Controls.Add(this.labelControl2);
            this.panelPhucHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhucHoi.Location = new System.Drawing.Point(276, 334);
            this.panelPhucHoi.Name = "panelPhucHoi";
            this.panelPhucHoi.Size = new System.Drawing.Size(1155, 274);
            this.panelPhucHoi.TabIndex = 10;
            // 
            // dateStop
            // 
            this.dateStop.EditValue = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            this.dateStop.Location = new System.Drawing.Point(417, 38);
            this.dateStop.MenuManager = this.barManager1;
            this.dateStop.Name = "dateStop";
            this.dateStop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStop.Properties.Appearance.Options.UseFont = true;
            this.dateStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Properties.MaxValue = new System.DateTime(2022, 4, 26, 0, 0, 0, 0);
            this.dateStop.Size = new System.Drawing.Size(178, 30);
            this.dateStop.TabIndex = 19;
            // 
            // timeStop
            // 
            this.timeStop.EditValue = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            this.timeStop.Location = new System.Drawing.Point(622, 38);
            this.timeStop.MenuManager = this.barManager1;
            this.timeStop.Name = "timeStop";
            this.timeStop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStop.Properties.Appearance.Options.UseFont = true;
            this.timeStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeStop.Size = new System.Drawing.Size(176, 30);
            this.timeStop.TabIndex = 18;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(46, 226);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1061, 23);
            this.progressBar.TabIndex = 17;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(46, 91);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(816, 128);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(46, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(341, 24);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ngày giờ để phục hồi tới thời điểm đó:";
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDevice
            // 
            this.bdsDevice.DataMember = "backup_devices";
            this.bdsDevice.DataSource = this.DS;
            // 
            // backup_devicesTableAdapter
            // 
            this.backup_devicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Backup_Restore.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // STT_BACKUPTableAdapter
            // 
            this.STT_BACKUPTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 628);
            this.Controls.Add(this.panelPhucHoi);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAO LƯU - PHỤC HỒI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSTTBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSTTBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSTTBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.panelPhucHoi.ResumeLayout(false);
            this.panelPhucHoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarCheckItem btnThamSoPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnTaoDV;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcSTTBackup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSTTBackup;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panelPhucHoi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 DS;
        private System.Windows.Forms.BindingSource bdsDB;
        private DataSet1TableAdapters.databasesTableAdapter databasesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DataSet1TableAdapters.SP_STT_BACKUPTableAdapter SP_STT_BACKUPTableAdapter;
        private System.Windows.Forms.BindingSource bdsDevice;
        private DataSet1TableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.LabelControl lable_ThongBao;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox checkBoxSTTBackup;
        private DevExpress.XtraEditors.DateEdit dateStop;
        private DevExpress.XtraEditors.TimeEdit timeStop;
        private System.Windows.Forms.BindingSource bdsSTTBackup;
        private DataSet1TableAdapters.SP_STT_BACKUPTableAdapter STT_BACKUPTableAdapter;
        private System.Windows.Forms.Label tbDBName;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
    }
}

