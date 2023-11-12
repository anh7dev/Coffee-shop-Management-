namespace QuanLyQuanCaPhe
{
    partial class fAdmin
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.quanLyQuanCaPheNTNDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel23 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txbNameTable = new System.Windows.Forms.TextBox();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txbTableID = new System.Windows.Forms.TextBox();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tbFoodCategory = new System.Windows.Forms.TabPage();
            this.panel18 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txbNameCategory = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tbFood = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.txbPageView = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevioursPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel29 = new System.Windows.Forms.Panel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.nmAccountType = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quanLyQuanCaPheNTNDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanCaPheNTNDataSet = new QuanLyQuanCaPhe.QuanLyQuanCaPheNTNDataSet();
            this.quanLyQuanCaPheNTNDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.uSPGetListBillByDateForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_GetListBillByDateForReportTableAdapter = new QuanLyQuanCaPhe.QuanLyQuanCaPheNTNDataSetTableAdapters.USP_GetListBillByDateForReportTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.USP_GetListBillByDateForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheNTNDataSetBindingSource1)).BeginInit();
            this.tpTable.SuspendLayout();
            this.panel23.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.tbFoodCategory.SuspendLayout();
            this.panel18.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.tbFood.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.tpBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tcAdmin.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel29.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheNTNDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheNTNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheNTNDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateForReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel23);
            this.tpTable.Location = new System.Drawing.Point(4, 25);
            this.tpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTable.Size = new System.Drawing.Size(890, 771);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.groupBox9);
            this.panel23.Controls.Add(this.groupBox8);
            this.panel23.Controls.Add(this.btnShowTable);
            this.panel23.Controls.Add(this.groupBox7);
            this.panel23.Controls.Add(this.btnEditTable);
            this.panel23.Controls.Add(this.dtgvTable);
            this.panel23.Controls.Add(this.btnDeleteTable);
            this.panel23.Controls.Add(this.btnAddTable);
            this.panel23.Location = new System.Drawing.Point(5, 4);
            this.panel23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(882, 752);
            this.panel23.TabIndex = 4;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txbStatus);
            this.groupBox9.Location = new System.Drawing.Point(545, 60);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(145, 48);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Trạng thái";
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(6, 20);
            this.txbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(129, 22);
            this.txbStatus.TabIndex = 3;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txbNameTable);
            this.groupBox8.Location = new System.Drawing.Point(379, 60);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(160, 46);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tên bàn";
            // 
            // txbNameTable
            // 
            this.txbNameTable.Location = new System.Drawing.Point(6, 20);
            this.txbNameTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNameTable.Name = "txbNameTable";
            this.txbNameTable.Size = new System.Drawing.Size(148, 22);
            this.txbNameTable.TabIndex = 3;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(590, 15);
            this.btnShowTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(100, 40);
            this.btnShowTable.TabIndex = 6;
            this.btnShowTable.Text = "Xem";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txbTableID);
            this.groupBox7.Location = new System.Drawing.Point(240, 60);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(122, 46);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ID";
            // 
            // txbTableID
            // 
            this.txbTableID.Location = new System.Drawing.Point(6, 20);
            this.txbTableID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTableID.Name = "txbTableID";
            this.txbTableID.ReadOnly = true;
            this.txbTableID.Size = new System.Drawing.Size(110, 22);
            this.txbTableID.TabIndex = 3;
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(475, 15);
            this.btnEditTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(100, 40);
            this.btnEditTable.TabIndex = 5;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(240, 110);
            this.dtgvTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(450, 590);
            this.dtgvTable.TabIndex = 0;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(358, 15);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteTable.TabIndex = 4;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(239, 15);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(100, 40);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // tbFoodCategory
            // 
            this.tbFoodCategory.Controls.Add(this.panel18);
            this.tbFoodCategory.Location = new System.Drawing.Point(4, 25);
            this.tbFoodCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFoodCategory.Name = "tbFoodCategory";
            this.tbFoodCategory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFoodCategory.Size = new System.Drawing.Size(890, 771);
            this.tbFoodCategory.TabIndex = 2;
            this.tbFoodCategory.Text = "Danh mục";
            this.tbFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.groupBox6);
            this.panel18.Controls.Add(this.groupBox5);
            this.panel18.Controls.Add(this.btnShowCategory);
            this.panel18.Controls.Add(this.dtgvCategory);
            this.panel18.Controls.Add(this.btnEditCategory);
            this.panel18.Controls.Add(this.btnDeleteCategory);
            this.panel18.Controls.Add(this.btnAddCategory);
            this.panel18.Location = new System.Drawing.Point(5, 4);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(879, 752);
            this.panel18.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txbNameCategory);
            this.groupBox6.Location = new System.Drawing.Point(475, 59);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 51);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tên danh mục";
            // 
            // txbNameCategory
            // 
            this.txbNameCategory.Location = new System.Drawing.Point(6, 20);
            this.txbNameCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNameCategory.Name = "txbNameCategory";
            this.txbNameCategory.Size = new System.Drawing.Size(203, 22);
            this.txbNameCategory.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txbCategoryID);
            this.groupBox5.Location = new System.Drawing.Point(240, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 50);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ID của danh mục sản phẩm";
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.Location = new System.Drawing.Point(6, 20);
            this.txbCategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.Size = new System.Drawing.Size(212, 22);
            this.txbCategoryID.TabIndex = 3;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Location = new System.Drawing.Point(590, 15);
            this.btnShowCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(100, 40);
            this.btnShowCategory.TabIndex = 6;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(240, 110);
            this.dtgvCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.RowTemplate.Height = 24;
            this.dtgvCategory.Size = new System.Drawing.Size(450, 590);
            this.dtgvCategory.TabIndex = 0;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(475, 15);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(100, 40);
            this.btnEditCategory.TabIndex = 5;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(358, 15);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(239, 15);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(100, 40);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tbFood
            // 
            this.tbFood.Controls.Add(this.panel3);
            this.tbFood.Location = new System.Drawing.Point(4, 25);
            this.tbFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFood.Name = "tbFood";
            this.tbFood.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFood.Size = new System.Drawing.Size(890, 771);
            this.tbFood.TabIndex = 1;
            this.tbFood.Text = "Thức ăn";
            this.tbFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowFood);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnSearchFood);
            this.panel3.Controls.Add(this.btnEditFood);
            this.panel3.Controls.Add(this.txbSearchFoodName);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 699);
            this.panel3.TabIndex = 0;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(394, 9);
            this.btnShowFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(100, 40);
            this.btnShowFood.TabIndex = 6;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nmFoodPrice);
            this.groupBox4.Location = new System.Drawing.Point(637, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 55);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giá bán";
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(6, 20);
            this.nmFoodPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(151, 22);
            this.nmFoodPrice.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbFoodCategory);
            this.groupBox3.Location = new System.Drawing.Point(439, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 53);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh mục";
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(6, 20);
            this.cbFoodCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(180, 24);
            this.cbFoodCategory.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbFoodName);
            this.groupBox2.Location = new System.Drawing.Point(213, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên món";
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(6, 20);
            this.txbFoodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(188, 22);
            this.txbFoodName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbFoodID);
            this.groupBox1.Location = new System.Drawing.Point(78, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID ";
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(6, 20);
            this.txbFoodID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(117, 22);
            this.txbFoodID.TabIndex = 3;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(700, 9);
            this.btnSearchFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(100, 40);
            this.btnSearchFood.TabIndex = 7;
            this.btnSearchFood.Text = "TÌm kiếm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(288, 9);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(100, 40);
            this.btnEditFood.TabIndex = 5;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Location = new System.Drawing.Point(500, 18);
            this.txbSearchFoodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(194, 22);
            this.txbSearchFoodName.TabIndex = 8;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(182, 9);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteFood.TabIndex = 4;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(76, 119);
            this.dtgvFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(724, 565);
            this.dtgvFood.TabIndex = 0;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(76, 9);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(100, 40);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.txbPageView);
            this.tpBill.Controls.Add(this.btnNextPage);
            this.tpBill.Controls.Add(this.btnPrevioursPage);
            this.tpBill.Controls.Add(this.btnLastPage);
            this.tpBill.Controls.Add(this.btnFirstPage);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Location = new System.Drawing.Point(4, 25);
            this.tpBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBill.Size = new System.Drawing.Size(890, 771);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // txbPageView
            // 
            this.txbPageView.Location = new System.Drawing.Point(415, 660);
            this.txbPageView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPageView.Name = "txbPageView";
            this.txbPageView.Size = new System.Drawing.Size(100, 22);
            this.txbPageView.TabIndex = 8;
            this.txbPageView.Text = "1";
            this.txbPageView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPageView.TextChanged += new System.EventHandler(this.txbPageView_TextChanged);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(550, 650);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(100, 40);
            this.btnNextPage.TabIndex = 7;
            this.btnNextPage.Text = "Trang kế tiếp";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevioursPage
            // 
            this.btnPrevioursPage.Location = new System.Drawing.Point(280, 650);
            this.btnPrevioursPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevioursPage.Name = "btnPrevioursPage";
            this.btnPrevioursPage.Size = new System.Drawing.Size(100, 40);
            this.btnPrevioursPage.TabIndex = 6;
            this.btnPrevioursPage.Text = "Trang trước";
            this.btnPrevioursPage.UseVisualStyleBackColor = true;
            this.btnPrevioursPage.Click += new System.EventHandler(this.btnPrevioursPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(685, 650);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(100, 40);
            this.btnLastPage.TabIndex = 5;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(145, 650);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(100, 40);
            this.btnFirstPage.TabIndex = 4;
            this.btnFirstPage.Text = "Trang đầu";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewBill);
            this.panel1.Controls.Add(this.dtpkToDate);
            this.panel1.Controls.Add(this.dtpkFromDate);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 52);
            this.panel1.TabIndex = 2;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(410, 6);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(100, 40);
            this.btnViewBill.TabIndex = 6;
            this.btnViewBill.Text = "Thông kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(536, 16);
            this.dtpkToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(200, 22);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(176, 16);
            this.dtpkFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(200, 22);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvBill);
            this.panel2.Location = new System.Drawing.Point(5, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 559);
            this.panel2.TabIndex = 3;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(4, 4);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(875, 553);
            this.dtgvBill.TabIndex = 0;
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tbFood);
            this.tcAdmin.Controls.Add(this.tbFoodCategory);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Controls.Add(this.tabPage1);
            this.tcAdmin.Location = new System.Drawing.Point(13, 14);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(898, 800);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel29);
            this.tpAccount.Location = new System.Drawing.Point(4, 25);
            this.tpAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAccount.Size = new System.Drawing.Size(890, 771);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.groupBox12);
            this.panel29.Controls.Add(this.groupBox11);
            this.panel29.Controls.Add(this.groupBox10);
            this.panel29.Controls.Add(this.btnShowAccount);
            this.panel29.Controls.Add(this.dtgvAccount);
            this.panel29.Controls.Add(this.btnEditAccount);
            this.panel29.Controls.Add(this.btnAddAccount);
            this.panel29.Controls.Add(this.btnDeleteAccount);
            this.panel29.Location = new System.Drawing.Point(5, 4);
            this.panel29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(882, 752);
            this.panel29.TabIndex = 4;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.nmAccountType);
            this.groupBox12.Location = new System.Drawing.Point(561, 60);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(129, 51);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Loại tài khoản";
            // 
            // nmAccountType
            // 
            this.nmAccountType.Location = new System.Drawing.Point(6, 22);
            this.nmAccountType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(117, 22);
            this.nmAccountType.TabIndex = 3;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txbDisplayName);
            this.groupBox11.Location = new System.Drawing.Point(375, 60);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(180, 50);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Tên hiển thị";
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(6, 20);
            this.txbDisplayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(162, 22);
            this.txbDisplayName.TabIndex = 3;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txbUserName);
            this.groupBox10.Location = new System.Drawing.Point(239, 60);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(127, 50);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tên đăng nhập";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(6, 20);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(115, 22);
            this.txbUserName.TabIndex = 3;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(590, 15);
            this.btnShowAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(100, 40);
            this.btnShowAccount.TabIndex = 6;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(240, 110);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(450, 590);
            this.dtgvAccount.TabIndex = 0;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(475, 15);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(100, 40);
            this.btnEditAccount.TabIndex = 5;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(239, 15);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(100, 40);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(358, 15);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteAccount.TabIndex = 4;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePickerTo);
            this.tabPage1.Controls.Add(this.dateTimePickerFrom);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(890, 771);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Báo cáo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetListBillByDateForReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCaPhe.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 55);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(880, 577);
            this.reportViewer1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // quanLyQuanCaPheNTNDataSet
            // 
            this.quanLyQuanCaPheNTNDataSet.DataSetName = "QuanLyQuanCaPheNTNDataSet";
            this.quanLyQuanCaPheNTNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyQuanCaPheNTNDataSetBindingSource2
            // 
            this.quanLyQuanCaPheNTNDataSetBindingSource2.DataSource = this.quanLyQuanCaPheNTNDataSet;
            this.quanLyQuanCaPheNTNDataSetBindingSource2.Position = 0;
            // 
            // uSPGetListBillByDateForReportBindingSource
            // 
            this.uSPGetListBillByDateForReportBindingSource.DataMember = "USP_GetListBillByDateForReport";
            this.uSPGetListBillByDateForReportBindingSource.DataSource = this.quanLyQuanCaPheNTNDataSetBindingSource2;
            // 
            // uSP_GetListBillByDateForReportTableAdapter
            // 
            this.uSP_GetListBillByDateForReportTableAdapter.ClearBeforeFill = true;
            // 
            // USP_GetListBillByDateForReportBindingSource
            // 
            this.USP_GetListBillByDateForReportBindingSource.DataMember = "USP_GetListBillByDateForReport";
            this.USP_GetListBillByDateForReportBindingSource.DataSource = this.quanLyQuanCaPheNTNDataSet;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(QuanLyQuanCaPhe.DTO.Bill);
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataSource = typeof(QuanLyQuanCaPhe.DTO.Food);
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataSource = typeof(QuanLyQuanCaPhe.DTO.Menu);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(153, 19);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 7;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(513, 19);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 8;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 753);
            this.Controls.Add(this.tcAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện người dùng quản lý";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheNTNDataSetBindingSource1)).EndInit();
            this.tpTable.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.tbFoodCategory.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.tbFood.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.tpBill.ResumeLayout(false);
            this.tpBill.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tcAdmin.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheNTNDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheNTNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheNTNDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateForReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tbFoodCategory;
        private System.Windows.Forms.TabPage tbFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.TextBox txbSearchFoodName;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.TextBox txbNameTable;
        private System.Windows.Forms.TextBox txbTableID;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.TextBox txbNameCategory;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.NumericUpDown nmAccountType;
        private System.Windows.Forms.TextBox txbPageView;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevioursPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        //private QuanLyQuanCaPheNTNDataSet1 quanLyQuanCaPheNTNDataSet;
        private System.Windows.Forms.BindingSource quanLyQuanCaPheNTNDataSetBindingSource;
        private System.Windows.Forms.BindingSource quanLyQuanCaPheNTNDataSetBindingSource1;
        private System.Windows.Forms.BindingSource uSPGetListBillByDateForReportBindingSource;
        private System.Windows.Forms.BindingSource quanLyQuanCaPheNTNDataSetBindingSource2;
        private QuanLyQuanCaPheNTNDataSet quanLyQuanCaPheNTNDataSet;
        private QuanLyQuanCaPheNTNDataSetTableAdapters.USP_GetListBillByDateForReportTableAdapter uSP_GetListBillByDateForReportTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource billBindingSource;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateForReportBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
    }
}