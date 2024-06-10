namespace WinformsDUCCompany3a.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TCMain = new MaterialSkin.Controls.MaterialTabControl();
            this.TPHome = new System.Windows.Forms.TabPage();
            this.btnExportToPDF = new MaterialSkin.Controls.MaterialButton();
            this.btnExportToExcel = new MaterialSkin.Controls.MaterialButton();
            this.btnPrint = new MaterialSkin.Controls.MaterialButton();
            this.btnShowAll = new MaterialSkin.Controls.MaterialButton();
            this.btnFilter = new MaterialSkin.Controls.MaterialButton();
            this.txtSearchEmpByName = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbHomeDepartment = new MaterialSkin.Controls.MaterialComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPCRUD = new System.Windows.Forms.TabPage();
            this.btnResetEmp = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteEmp = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveEmp = new MaterialSkin.Controls.MaterialButton();
            this.btnClearEmpPhoto = new MaterialSkin.Controls.MaterialButton();
            this.btnUploadEmpPhoto = new MaterialSkin.Controls.MaterialButton();
            this.txtEmpAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtEmpName = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbEmpPosition = new MaterialSkin.Controls.MaterialComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEmpDepartment = new MaterialSkin.Controls.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpGender = new MaterialSkin.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEmpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pbEmpPhoto = new System.Windows.Forms.PictureBox();
            this.TPProfile = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LabelProRole = new System.Windows.Forms.Label();
            this.LabelProEmail = new System.Windows.Forms.Label();
            this.LabelProUsername = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TPSalary = new System.Windows.Forms.TabPage();
            this.btnSaExportToPDF = new MaterialSkin.Controls.MaterialButton();
            this.btnSaExportToExcel = new MaterialSkin.Controls.MaterialButton();
            this.btnSaPrint = new MaterialSkin.Controls.MaterialButton();
            this.btnSaShowMoSalary = new MaterialSkin.Controls.MaterialButton();
            this.btnSaSearchById = new MaterialSkin.Controls.MaterialButton();
            this.txtSaSearchEmpById = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvSaEmployees = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TPDepartment = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.DeDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnResetDe = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteDe = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveDe = new MaterialSkin.Controls.MaterialButton();
            this.txtDeDepartmentName = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TPPosition = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.PoPositionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoPositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoDailySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPoDailySalary = new MaterialSkin.Controls.MaterialTextBox();
            this.btnResetPo = new MaterialSkin.Controls.MaterialButton();
            this.btnDeletePo = new MaterialSkin.Controls.MaterialButton();
            this.btnSavePo = new MaterialSkin.Controls.MaterialButton();
            this.txtPoPositionName = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbPoDepartment = new MaterialSkin.Controls.MaterialComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TPChart = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.TPCrystalReport = new System.Windows.Forms.TabPage();
            this.CRViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TCMain.SuspendLayout();
            this.TPHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.TPCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpPhoto)).BeginInit();
            this.TPProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TPSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TPDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.TPPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            this.TPChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.TPCrystalReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCMain
            // 
            this.TCMain.Controls.Add(this.TPHome);
            this.TCMain.Controls.Add(this.TPCRUD);
            this.TCMain.Controls.Add(this.TPProfile);
            this.TCMain.Controls.Add(this.TPSalary);
            this.TCMain.Controls.Add(this.TPDepartment);
            this.TCMain.Controls.Add(this.TPPosition);
            this.TCMain.Controls.Add(this.TPChart);
            this.TCMain.Controls.Add(this.TPCrystalReport);
            this.TCMain.Depth = 0;
            this.TCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCMain.ImageList = this.imageList1;
            this.TCMain.Location = new System.Drawing.Point(3, 64);
            this.TCMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCMain.Multiline = true;
            this.TCMain.Name = "TCMain";
            this.TCMain.SelectedIndex = 0;
            this.TCMain.Size = new System.Drawing.Size(994, 543);
            this.TCMain.TabIndex = 0;
            // 
            // TPHome
            // 
            this.TPHome.Controls.Add(this.btnExportToPDF);
            this.TPHome.Controls.Add(this.btnExportToExcel);
            this.TPHome.Controls.Add(this.btnPrint);
            this.TPHome.Controls.Add(this.btnShowAll);
            this.TPHome.Controls.Add(this.btnFilter);
            this.TPHome.Controls.Add(this.txtSearchEmpByName);
            this.TPHome.Controls.Add(this.cmbHomeDepartment);
            this.TPHome.Controls.Add(this.label13);
            this.TPHome.Controls.Add(this.label11);
            this.TPHome.Controls.Add(this.materialLabel2);
            this.TPHome.Controls.Add(this.dgvEmployees);
            this.TPHome.ImageKey = "home256.png";
            this.TPHome.Location = new System.Drawing.Point(4, 31);
            this.TPHome.Name = "TPHome";
            this.TPHome.Padding = new System.Windows.Forms.Padding(3);
            this.TPHome.Size = new System.Drawing.Size(986, 508);
            this.TPHome.TabIndex = 0;
            this.TPHome.Text = "Home";
            this.TPHome.UseVisualStyleBackColor = true;
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportToPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportToPDF.Depth = 0;
            this.btnExportToPDF.HighEmphasis = true;
            this.btnExportToPDF.Icon = null;
            this.btnExportToPDF.Location = new System.Drawing.Point(210, 419);
            this.btnExportToPDF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportToPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportToPDF.Size = new System.Drawing.Size(130, 36);
            this.btnExportToPDF.TabIndex = 64;
            this.btnExportToPDF.Text = "Export To PDF";
            this.btnExportToPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportToPDF.UseAccentColor = false;
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportToExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportToExcel.Depth = 0;
            this.btnExportToExcel.HighEmphasis = true;
            this.btnExportToExcel.Icon = null;
            this.btnExportToExcel.Location = new System.Drawing.Point(41, 419);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportToExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportToExcel.Size = new System.Drawing.Size(147, 36);
            this.btnExportToExcel.TabIndex = 63;
            this.btnExportToExcel.Text = "Export To Excel";
            this.btnExportToExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportToExcel.UseAccentColor = false;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrint.Depth = 0;
            this.btnPrint.HighEmphasis = true;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(367, 419);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrint.Size = new System.Drawing.Size(64, 36);
            this.btnPrint.TabIndex = 62;
            this.btnPrint.Text = "Print";
            this.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrint.UseAccentColor = false;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShowAll.Depth = 0;
            this.btnShowAll.HighEmphasis = true;
            this.btnShowAll.Icon = null;
            this.btnShowAll.Location = new System.Drawing.Point(826, 81);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShowAll.Size = new System.Drawing.Size(93, 36);
            this.btnShowAll.TabIndex = 61;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowAll.UseAccentColor = false;
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFilter.Depth = 0;
            this.btnFilter.HighEmphasis = true;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(744, 81);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFilter.Size = new System.Drawing.Size(68, 36);
            this.btnFilter.TabIndex = 60;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFilter.UseAccentColor = false;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtSearchEmpByName
            // 
            this.txtSearchEmpByName.AnimateReadOnly = false;
            this.txtSearchEmpByName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchEmpByName.Depth = 0;
            this.txtSearchEmpByName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchEmpByName.LeadingIcon = null;
            this.txtSearchEmpByName.Location = new System.Drawing.Point(165, 81);
            this.txtSearchEmpByName.MaxLength = 50;
            this.txtSearchEmpByName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchEmpByName.Multiline = false;
            this.txtSearchEmpByName.Name = "txtSearchEmpByName";
            this.txtSearchEmpByName.Size = new System.Drawing.Size(175, 50);
            this.txtSearchEmpByName.TabIndex = 56;
            this.txtSearchEmpByName.Text = "";
            this.txtSearchEmpByName.TrailingIcon = null;
            this.txtSearchEmpByName.TextChanged += new System.EventHandler(this.txtSearchEmpByName_TextChanged);
            this.txtSearchEmpByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchEmpByName_KeyPress);
            // 
            // cmbHomeDepartment
            // 
            this.cmbHomeDepartment.AutoResize = false;
            this.cmbHomeDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbHomeDepartment.Depth = 0;
            this.cmbHomeDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbHomeDepartment.DropDownHeight = 174;
            this.cmbHomeDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeDepartment.DropDownWidth = 121;
            this.cmbHomeDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbHomeDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbHomeDepartment.FormattingEnabled = true;
            this.cmbHomeDepartment.IntegralHeight = false;
            this.cmbHomeDepartment.ItemHeight = 43;
            this.cmbHomeDepartment.Location = new System.Drawing.Point(516, 81);
            this.cmbHomeDepartment.MaxDropDownItems = 4;
            this.cmbHomeDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbHomeDepartment.Name = "cmbHomeDepartment";
            this.cmbHomeDepartment.Size = new System.Drawing.Size(221, 49);
            this.cmbHomeDepartment.StartIndex = 0;
            this.cmbHomeDepartment.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Filter  by department";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Search  by name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(371, 12);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(147, 41);
            this.materialLabel2.TabIndex = 55;
            this.materialLabel2.Text = "Emloyees";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.EmpName,
            this.EmpDOB,
            this.EmpGender,
            this.EmpAddress,
            this.DepartmentName,
            this.PositionName,
            this.DailySalary,
            this.DepartmentId,
            this.PositionId,
            this.EmpImagePath});
            this.dgvEmployees.Location = new System.Drawing.Point(41, 136);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(878, 274);
            this.dgvEmployees.TabIndex = 54;
            this.dgvEmployees.DoubleClick += new System.EventHandler(this.dgvEmployees_DoubleClick);
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "Id ";
            this.EmpId.Name = "EmpId";
            this.EmpId.Width = 30;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Name ";
            this.EmpName.Name = "EmpName";
            // 
            // EmpDOB
            // 
            this.EmpDOB.DataPropertyName = "EmpDOB";
            this.EmpDOB.HeaderText = "Date of birth";
            this.EmpDOB.Name = "EmpDOB";
            this.EmpDOB.Width = 90;
            // 
            // EmpGender
            // 
            this.EmpGender.DataPropertyName = "EmpGender";
            this.EmpGender.HeaderText = "Gender ";
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.Width = 80;
            // 
            // EmpAddress
            // 
            this.EmpAddress.DataPropertyName = "EmpAddress";
            this.EmpAddress.HeaderText = "Address ";
            this.EmpAddress.Name = "EmpAddress";
            this.EmpAddress.Width = 200;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "Department Name ";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Width = 120;
            // 
            // PositionName
            // 
            this.PositionName.DataPropertyName = "PositionName";
            this.PositionName.HeaderText = "Position Name ";
            this.PositionName.Name = "PositionName";
            this.PositionName.Width = 150;
            // 
            // DailySalary
            // 
            this.DailySalary.DataPropertyName = "DailySalary";
            this.DailySalary.HeaderText = "Daily Salary ($)";
            this.DailySalary.Name = "DailySalary";
            this.DailySalary.Width = 50;
            // 
            // DepartmentId
            // 
            this.DepartmentId.DataPropertyName = "DepartmentId";
            this.DepartmentId.HeaderText = "Department Id";
            this.DepartmentId.Name = "DepartmentId";
            this.DepartmentId.Visible = false;
            this.DepartmentId.Width = 20;
            // 
            // PositionId
            // 
            this.PositionId.DataPropertyName = "PositionId";
            this.PositionId.HeaderText = "Position Id ";
            this.PositionId.Name = "PositionId";
            this.PositionId.Visible = false;
            this.PositionId.Width = 20;
            // 
            // EmpImagePath
            // 
            this.EmpImagePath.DataPropertyName = "EmpImagePath";
            this.EmpImagePath.HeaderText = "EmpImagePath ";
            this.EmpImagePath.Name = "EmpImagePath";
            this.EmpImagePath.Visible = false;
            this.EmpImagePath.Width = 20;
            // 
            // TPCRUD
            // 
            this.TPCRUD.Controls.Add(this.btnResetEmp);
            this.TPCRUD.Controls.Add(this.btnDeleteEmp);
            this.TPCRUD.Controls.Add(this.btnSaveEmp);
            this.TPCRUD.Controls.Add(this.btnClearEmpPhoto);
            this.TPCRUD.Controls.Add(this.btnUploadEmpPhoto);
            this.TPCRUD.Controls.Add(this.txtEmpAddress);
            this.TPCRUD.Controls.Add(this.txtEmpName);
            this.TPCRUD.Controls.Add(this.cmbEmpPosition);
            this.TPCRUD.Controls.Add(this.label6);
            this.TPCRUD.Controls.Add(this.cmbEmpDepartment);
            this.TPCRUD.Controls.Add(this.label5);
            this.TPCRUD.Controls.Add(this.label4);
            this.TPCRUD.Controls.Add(this.cmbEmpGender);
            this.TPCRUD.Controls.Add(this.label3);
            this.TPCRUD.Controls.Add(this.label2);
            this.TPCRUD.Controls.Add(this.dtpEmpDOB);
            this.TPCRUD.Controls.Add(this.label1);
            this.TPCRUD.Controls.Add(this.materialLabel1);
            this.TPCRUD.Controls.Add(this.pbEmpPhoto);
            this.TPCRUD.ImageKey = "group_people256.png";
            this.TPCRUD.Location = new System.Drawing.Point(4, 31);
            this.TPCRUD.Name = "TPCRUD";
            this.TPCRUD.Padding = new System.Windows.Forms.Padding(3);
            this.TPCRUD.Size = new System.Drawing.Size(986, 508);
            this.TPCRUD.TabIndex = 1;
            this.TPCRUD.Text = "CRUD";
            this.TPCRUD.UseVisualStyleBackColor = true;
            // 
            // btnResetEmp
            // 
            this.btnResetEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetEmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResetEmp.Depth = 0;
            this.btnResetEmp.HighEmphasis = true;
            this.btnResetEmp.Icon = null;
            this.btnResetEmp.Location = new System.Drawing.Point(214, 396);
            this.btnResetEmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResetEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResetEmp.Name = "btnResetEmp";
            this.btnResetEmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResetEmp.Size = new System.Drawing.Size(65, 36);
            this.btnResetEmp.TabIndex = 61;
            this.btnResetEmp.Text = "Reset";
            this.btnResetEmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResetEmp.UseAccentColor = false;
            this.btnResetEmp.UseVisualStyleBackColor = true;
            this.btnResetEmp.Click += new System.EventHandler(this.btnResetEmp_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteEmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteEmp.Depth = 0;
            this.btnDeleteEmp.HighEmphasis = true;
            this.btnDeleteEmp.Icon = null;
            this.btnDeleteEmp.Location = new System.Drawing.Point(114, 396);
            this.btnDeleteEmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteEmp.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteEmp.TabIndex = 60;
            this.btnDeleteEmp.Text = "Delete";
            this.btnDeleteEmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteEmp.UseAccentColor = false;
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnSaveEmp
            // 
            this.btnSaveEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveEmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveEmp.Depth = 0;
            this.btnSaveEmp.HighEmphasis = true;
            this.btnSaveEmp.Icon = null;
            this.btnSaveEmp.Location = new System.Drawing.Point(25, 396);
            this.btnSaveEmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveEmp.Name = "btnSaveEmp";
            this.btnSaveEmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveEmp.Size = new System.Drawing.Size(64, 36);
            this.btnSaveEmp.TabIndex = 59;
            this.btnSaveEmp.Text = "Save";
            this.btnSaveEmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveEmp.UseAccentColor = false;
            this.btnSaveEmp.UseVisualStyleBackColor = true;
            this.btnSaveEmp.Click += new System.EventHandler(this.btnSaveEmp_Click);
            // 
            // btnClearEmpPhoto
            // 
            this.btnClearEmpPhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearEmpPhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearEmpPhoto.Depth = 0;
            this.btnClearEmpPhoto.HighEmphasis = true;
            this.btnClearEmpPhoto.Icon = null;
            this.btnClearEmpPhoto.Location = new System.Drawing.Point(500, 249);
            this.btnClearEmpPhoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearEmpPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearEmpPhoto.Name = "btnClearEmpPhoto";
            this.btnClearEmpPhoto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearEmpPhoto.Size = new System.Drawing.Size(66, 36);
            this.btnClearEmpPhoto.TabIndex = 58;
            this.btnClearEmpPhoto.Text = "Clear";
            this.btnClearEmpPhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearEmpPhoto.UseAccentColor = false;
            this.btnClearEmpPhoto.UseVisualStyleBackColor = true;
            this.btnClearEmpPhoto.Click += new System.EventHandler(this.btnClearEmpPhoto_Click);
            // 
            // btnUploadEmpPhoto
            // 
            this.btnUploadEmpPhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUploadEmpPhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUploadEmpPhoto.Depth = 0;
            this.btnUploadEmpPhoto.HighEmphasis = true;
            this.btnUploadEmpPhoto.Icon = null;
            this.btnUploadEmpPhoto.Location = new System.Drawing.Point(414, 249);
            this.btnUploadEmpPhoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUploadEmpPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUploadEmpPhoto.Name = "btnUploadEmpPhoto";
            this.btnUploadEmpPhoto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUploadEmpPhoto.Size = new System.Drawing.Size(78, 36);
            this.btnUploadEmpPhoto.TabIndex = 57;
            this.btnUploadEmpPhoto.Text = "Upload";
            this.btnUploadEmpPhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUploadEmpPhoto.UseAccentColor = false;
            this.btnUploadEmpPhoto.UseVisualStyleBackColor = true;
            this.btnUploadEmpPhoto.Click += new System.EventHandler(this.btnUploadEmpPhoto_Click);
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEmpAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpAddress.Depth = 0;
            this.txtEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEmpAddress.Location = new System.Drawing.Point(145, 210);
            this.txtEmpAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(221, 50);
            this.txtEmpAddress.TabIndex = 51;
            this.txtEmpAddress.Text = "";
            // 
            // txtEmpName
            // 
            this.txtEmpName.AnimateReadOnly = false;
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpName.Depth = 0;
            this.txtEmpName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpName.LeadingIcon = null;
            this.txtEmpName.Location = new System.Drawing.Point(145, 73);
            this.txtEmpName.MaxLength = 50;
            this.txtEmpName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmpName.Multiline = false;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(221, 50);
            this.txtEmpName.TabIndex = 44;
            this.txtEmpName.Text = "";
            this.txtEmpName.TrailingIcon = null;
            // 
            // cmbEmpPosition
            // 
            this.cmbEmpPosition.AutoResize = false;
            this.cmbEmpPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmpPosition.Depth = 0;
            this.cmbEmpPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmpPosition.DropDownHeight = 174;
            this.cmbEmpPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpPosition.DropDownWidth = 121;
            this.cmbEmpPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmpPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmpPosition.FormattingEnabled = true;
            this.cmbEmpPosition.IntegralHeight = false;
            this.cmbEmpPosition.ItemHeight = 43;
            this.cmbEmpPosition.Location = new System.Drawing.Point(145, 327);
            this.cmbEmpPosition.MaxDropDownItems = 4;
            this.cmbEmpPosition.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmpPosition.Name = "cmbEmpPosition";
            this.cmbEmpPosition.Size = new System.Drawing.Size(221, 49);
            this.cmbEmpPosition.StartIndex = 0;
            this.cmbEmpPosition.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Position";
            // 
            // cmbEmpDepartment
            // 
            this.cmbEmpDepartment.AutoResize = false;
            this.cmbEmpDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmpDepartment.Depth = 0;
            this.cmbEmpDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmpDepartment.DropDownHeight = 174;
            this.cmbEmpDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpDepartment.DropDownWidth = 121;
            this.cmbEmpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmpDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmpDepartment.FormattingEnabled = true;
            this.cmbEmpDepartment.IntegralHeight = false;
            this.cmbEmpDepartment.ItemHeight = 43;
            this.cmbEmpDepartment.Location = new System.Drawing.Point(145, 272);
            this.cmbEmpDepartment.MaxDropDownItems = 4;
            this.cmbEmpDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmpDepartment.Name = "cmbEmpDepartment";
            this.cmbEmpDepartment.Size = new System.Drawing.Size(221, 49);
            this.cmbEmpDepartment.StartIndex = 0;
            this.cmbEmpDepartment.TabIndex = 53;
            this.cmbEmpDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbEmpDepartment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Address";
            // 
            // cmbEmpGender
            // 
            this.cmbEmpGender.AutoResize = false;
            this.cmbEmpGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmpGender.Depth = 0;
            this.cmbEmpGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmpGender.DropDownHeight = 174;
            this.cmbEmpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpGender.DropDownWidth = 121;
            this.cmbEmpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmpGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmpGender.FormattingEnabled = true;
            this.cmbEmpGender.IntegralHeight = false;
            this.cmbEmpGender.ItemHeight = 43;
            this.cmbEmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbEmpGender.Location = new System.Drawing.Point(145, 155);
            this.cmbEmpGender.MaxDropDownItems = 4;
            this.cmbEmpGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmpGender.Name = "cmbEmpGender";
            this.cmbEmpGender.Size = new System.Drawing.Size(221, 49);
            this.cmbEmpGender.StartIndex = 0;
            this.cmbEmpGender.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Date of birth";
            // 
            // dtpEmpDOB
            // 
            this.dtpEmpDOB.Location = new System.Drawing.Point(145, 129);
            this.dtpEmpDOB.Name = "dtpEmpDOB";
            this.dtpEmpDOB.Size = new System.Drawing.Size(221, 20);
            this.dtpEmpDOB.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Name";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(339, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(242, 41);
            this.materialLabel1.TabIndex = 43;
            this.materialLabel1.Text = "CRUD Emloyees";
            // 
            // pbEmpPhoto
            // 
            this.pbEmpPhoto.Location = new System.Drawing.Point(414, 73);
            this.pbEmpPhoto.Name = "pbEmpPhoto";
            this.pbEmpPhoto.Size = new System.Drawing.Size(150, 150);
            this.pbEmpPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmpPhoto.TabIndex = 56;
            this.pbEmpPhoto.TabStop = false;
            // 
            // TPProfile
            // 
            this.TPProfile.Controls.Add(this.pictureBox2);
            this.TPProfile.Controls.Add(this.LabelProRole);
            this.TPProfile.Controls.Add(this.LabelProEmail);
            this.TPProfile.Controls.Add(this.LabelProUsername);
            this.TPProfile.Controls.Add(this.materialLabel3);
            this.TPProfile.ImageKey = "user256.png";
            this.TPProfile.Location = new System.Drawing.Point(4, 31);
            this.TPProfile.Name = "TPProfile";
            this.TPProfile.Padding = new System.Windows.Forms.Padding(3);
            this.TPProfile.Size = new System.Drawing.Size(986, 508);
            this.TPProfile.TabIndex = 2;
            this.TPProfile.Text = "Profile";
            this.TPProfile.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinformsDUCCompany3a.Properties.Resources.user2561;
            this.pictureBox2.Location = new System.Drawing.Point(452, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // LabelProRole
            // 
            this.LabelProRole.AutoSize = true;
            this.LabelProRole.Location = new System.Drawing.Point(30, 210);
            this.LabelProRole.Name = "LabelProRole";
            this.LabelProRole.Size = new System.Drawing.Size(38, 13);
            this.LabelProRole.TabIndex = 34;
            this.LabelProRole.Text = "Role : ";
            // 
            // LabelProEmail
            // 
            this.LabelProEmail.AutoSize = true;
            this.LabelProEmail.Location = new System.Drawing.Point(30, 178);
            this.LabelProEmail.Name = "LabelProEmail";
            this.LabelProEmail.Size = new System.Drawing.Size(41, 13);
            this.LabelProEmail.TabIndex = 33;
            this.LabelProEmail.Text = "Email : ";
            // 
            // LabelProUsername
            // 
            this.LabelProUsername.AutoSize = true;
            this.LabelProUsername.Location = new System.Drawing.Point(30, 149);
            this.LabelProUsername.Name = "LabelProUsername";
            this.LabelProUsername.Size = new System.Drawing.Size(64, 13);
            this.LabelProUsername.TabIndex = 32;
            this.LabelProUsername.Text = "Username : ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(429, 15);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(99, 41);
            this.materialLabel3.TabIndex = 31;
            this.materialLabel3.Text = "Profile";
            // 
            // TPSalary
            // 
            this.TPSalary.Controls.Add(this.btnSaExportToPDF);
            this.TPSalary.Controls.Add(this.btnSaExportToExcel);
            this.TPSalary.Controls.Add(this.btnSaPrint);
            this.TPSalary.Controls.Add(this.btnSaShowMoSalary);
            this.TPSalary.Controls.Add(this.btnSaSearchById);
            this.TPSalary.Controls.Add(this.txtSaSearchEmpById);
            this.TPSalary.Controls.Add(this.dgvSaEmployees);
            this.TPSalary.Controls.Add(this.label12);
            this.TPSalary.Controls.Add(this.materialLabel6);
            this.TPSalary.Controls.Add(this.pictureBox1);
            this.TPSalary.ImageKey = "salary256.png";
            this.TPSalary.Location = new System.Drawing.Point(4, 31);
            this.TPSalary.Name = "TPSalary";
            this.TPSalary.Padding = new System.Windows.Forms.Padding(3);
            this.TPSalary.Size = new System.Drawing.Size(986, 508);
            this.TPSalary.TabIndex = 3;
            this.TPSalary.Text = "Salary";
            this.TPSalary.UseVisualStyleBackColor = true;
            // 
            // btnSaExportToPDF
            // 
            this.btnSaExportToPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaExportToPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaExportToPDF.Depth = 0;
            this.btnSaExportToPDF.HighEmphasis = true;
            this.btnSaExportToPDF.Icon = null;
            this.btnSaExportToPDF.Location = new System.Drawing.Point(196, 348);
            this.btnSaExportToPDF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaExportToPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaExportToPDF.Name = "btnSaExportToPDF";
            this.btnSaExportToPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaExportToPDF.Size = new System.Drawing.Size(130, 36);
            this.btnSaExportToPDF.TabIndex = 60;
            this.btnSaExportToPDF.Text = "Export To PDF";
            this.btnSaExportToPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaExportToPDF.UseAccentColor = false;
            this.btnSaExportToPDF.UseVisualStyleBackColor = true;
            this.btnSaExportToPDF.Click += new System.EventHandler(this.btnSaExportToPDF_Click);
            // 
            // btnSaExportToExcel
            // 
            this.btnSaExportToExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaExportToExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaExportToExcel.Depth = 0;
            this.btnSaExportToExcel.HighEmphasis = true;
            this.btnSaExportToExcel.Icon = null;
            this.btnSaExportToExcel.Location = new System.Drawing.Point(23, 348);
            this.btnSaExportToExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaExportToExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaExportToExcel.Name = "btnSaExportToExcel";
            this.btnSaExportToExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaExportToExcel.Size = new System.Drawing.Size(147, 36);
            this.btnSaExportToExcel.TabIndex = 58;
            this.btnSaExportToExcel.Text = "Export To Excel";
            this.btnSaExportToExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaExportToExcel.UseAccentColor = false;
            this.btnSaExportToExcel.UseVisualStyleBackColor = true;
            this.btnSaExportToExcel.Click += new System.EventHandler(this.btnSaExportToExcel_Click);
            // 
            // btnSaPrint
            // 
            this.btnSaPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaPrint.Depth = 0;
            this.btnSaPrint.HighEmphasis = true;
            this.btnSaPrint.Icon = null;
            this.btnSaPrint.Location = new System.Drawing.Point(348, 348);
            this.btnSaPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaPrint.Name = "btnSaPrint";
            this.btnSaPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaPrint.Size = new System.Drawing.Size(64, 36);
            this.btnSaPrint.TabIndex = 57;
            this.btnSaPrint.Text = "Print";
            this.btnSaPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaPrint.UseAccentColor = false;
            this.btnSaPrint.UseVisualStyleBackColor = true;
            this.btnSaPrint.Click += new System.EventHandler(this.btnSaPrint_Click);
            // 
            // btnSaShowMoSalary
            // 
            this.btnSaShowMoSalary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaShowMoSalary.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaShowMoSalary.Depth = 0;
            this.btnSaShowMoSalary.HighEmphasis = true;
            this.btnSaShowMoSalary.Icon = null;
            this.btnSaShowMoSalary.Location = new System.Drawing.Point(465, 147);
            this.btnSaShowMoSalary.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaShowMoSalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaShowMoSalary.Name = "btnSaShowMoSalary";
            this.btnSaShowMoSalary.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaShowMoSalary.Size = new System.Drawing.Size(195, 36);
            this.btnSaShowMoSalary.TabIndex = 56;
            this.btnSaShowMoSalary.Text = "Show Monthly Salary";
            this.btnSaShowMoSalary.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaShowMoSalary.UseAccentColor = false;
            this.btnSaShowMoSalary.UseVisualStyleBackColor = true;
            this.btnSaShowMoSalary.Click += new System.EventHandler(this.btnSaShowMoSalary_Click);
            // 
            // btnSaSearchById
            // 
            this.btnSaSearchById.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaSearchById.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaSearchById.Depth = 0;
            this.btnSaSearchById.HighEmphasis = true;
            this.btnSaSearchById.Icon = null;
            this.btnSaSearchById.Location = new System.Drawing.Point(367, 147);
            this.btnSaSearchById.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaSearchById.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaSearchById.Name = "btnSaSearchById";
            this.btnSaSearchById.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaSearchById.Size = new System.Drawing.Size(78, 36);
            this.btnSaSearchById.TabIndex = 55;
            this.btnSaSearchById.Text = "Search";
            this.btnSaSearchById.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaSearchById.UseAccentColor = false;
            this.btnSaSearchById.UseVisualStyleBackColor = true;
            this.btnSaSearchById.Click += new System.EventHandler(this.btnSaSearchById_Click);
            // 
            // txtSaSearchEmpById
            // 
            this.txtSaSearchEmpById.AnimateReadOnly = false;
            this.txtSaSearchEmpById.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaSearchEmpById.Depth = 0;
            this.txtSaSearchEmpById.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSaSearchEmpById.LeadingIcon = null;
            this.txtSaSearchEmpById.Location = new System.Drawing.Point(117, 147);
            this.txtSaSearchEmpById.MaxLength = 50;
            this.txtSaSearchEmpById.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSaSearchEmpById.Multiline = false;
            this.txtSaSearchEmpById.Name = "txtSaSearchEmpById";
            this.txtSaSearchEmpById.Size = new System.Drawing.Size(221, 50);
            this.txtSaSearchEmpById.TabIndex = 52;
            this.txtSaSearchEmpById.Text = "";
            this.txtSaSearchEmpById.TrailingIcon = null;
            this.txtSaSearchEmpById.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaSearchEmpById_KeyPress);
            // 
            // dgvSaEmployees
            // 
            this.dgvSaEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.LateTimes,
            this.WorkingDays,
            this.Month,
            this.MonthlySalary});
            this.dgvSaEmployees.Location = new System.Drawing.Point(23, 215);
            this.dgvSaEmployees.Name = "dgvSaEmployees";
            this.dgvSaEmployees.Size = new System.Drawing.Size(878, 110);
            this.dgvSaEmployees.TabIndex = 54;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmpId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Department Name ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PositionName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Position Name ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DailySalary";
            this.dataGridViewTextBoxColumn8.HeaderText = "Daily Salary ($)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // LateTimes
            // 
            this.LateTimes.HeaderText = "Late Times";
            this.LateTimes.Name = "LateTimes";
            this.LateTimes.Width = 80;
            // 
            // WorkingDays
            // 
            this.WorkingDays.HeaderText = "Working Days";
            this.WorkingDays.Name = "WorkingDays";
            this.WorkingDays.Width = 80;
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.Width = 60;
            // 
            // MonthlySalary
            // 
            this.MonthlySalary.HeaderText = "Monthly Salary ($)";
            this.MonthlySalary.Name = "MonthlySalary";
            this.MonthlySalary.Width = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Employee Id";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel6.Location = new System.Drawing.Point(401, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(95, 41);
            this.materialLabel6.TabIndex = 51;
            this.materialLabel6.Text = "Salary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformsDUCCompany3a.Properties.Resources.salary256;
            this.pictureBox1.Location = new System.Drawing.Point(425, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // TPDepartment
            // 
            this.TPDepartment.Controls.Add(this.pictureBox3);
            this.TPDepartment.Controls.Add(this.dgvDepartments);
            this.TPDepartment.Controls.Add(this.btnResetDe);
            this.TPDepartment.Controls.Add(this.btnDeleteDe);
            this.TPDepartment.Controls.Add(this.btnSaveDe);
            this.TPDepartment.Controls.Add(this.txtDeDepartmentName);
            this.TPDepartment.Controls.Add(this.label7);
            this.TPDepartment.Controls.Add(this.materialLabel4);
            this.TPDepartment.ImageKey = "people256.png";
            this.TPDepartment.Location = new System.Drawing.Point(4, 31);
            this.TPDepartment.Name = "TPDepartment";
            this.TPDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.TPDepartment.Size = new System.Drawing.Size(986, 508);
            this.TPDepartment.TabIndex = 4;
            this.TPDepartment.Text = "Department";
            this.TPDepartment.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinformsDUCCompany3a.Properties.Resources.people256;
            this.pictureBox3.Location = new System.Drawing.Point(463, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeDepartmentId,
            this.DeDepartmentName,
            this.Update,
            this.Delete});
            this.dgvDepartments.Location = new System.Drawing.Point(394, 171);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.Size = new System.Drawing.Size(467, 150);
            this.dgvDepartments.TabIndex = 61;
            this.dgvDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartments_CellContentClick);
            this.dgvDepartments.DoubleClick += new System.EventHandler(this.dgvDepartments_DoubleClick);
            // 
            // DeDepartmentId
            // 
            this.DeDepartmentId.DataPropertyName = "DepartmentId";
            this.DeDepartmentId.HeaderText = "Id ";
            this.DeDepartmentId.Name = "DeDepartmentId";
            this.DeDepartmentId.ReadOnly = true;
            this.DeDepartmentId.Width = 40;
            // 
            // DeDepartmentName
            // 
            this.DeDepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeDepartmentName.DataPropertyName = "DepartmentName";
            this.DeDepartmentName.HeaderText = "Name ";
            this.DeDepartmentName.Name = "DeDepartmentName";
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Image = global::WinformsDUCCompany3a.Properties.Resources.edit16;
            this.Update.Name = "Update";
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.Width = 60;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::WinformsDUCCompany3a.Properties.Resources.bin16;
            this.Delete.Name = "Delete";
            this.Delete.Width = 60;
            // 
            // btnResetDe
            // 
            this.btnResetDe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetDe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResetDe.Depth = 0;
            this.btnResetDe.HighEmphasis = true;
            this.btnResetDe.Icon = null;
            this.btnResetDe.Location = new System.Drawing.Point(213, 245);
            this.btnResetDe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResetDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResetDe.Name = "btnResetDe";
            this.btnResetDe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResetDe.Size = new System.Drawing.Size(65, 36);
            this.btnResetDe.TabIndex = 60;
            this.btnResetDe.Text = "Reset";
            this.btnResetDe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResetDe.UseAccentColor = false;
            this.btnResetDe.UseVisualStyleBackColor = true;
            this.btnResetDe.Click += new System.EventHandler(this.btnResetDe_Click);
            // 
            // btnDeleteDe
            // 
            this.btnDeleteDe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteDe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteDe.Depth = 0;
            this.btnDeleteDe.HighEmphasis = true;
            this.btnDeleteDe.Icon = null;
            this.btnDeleteDe.Location = new System.Drawing.Point(113, 245);
            this.btnDeleteDe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteDe.Name = "btnDeleteDe";
            this.btnDeleteDe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteDe.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteDe.TabIndex = 59;
            this.btnDeleteDe.Text = "Delete";
            this.btnDeleteDe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteDe.UseAccentColor = false;
            this.btnDeleteDe.UseVisualStyleBackColor = true;
            this.btnDeleteDe.Click += new System.EventHandler(this.btnDeleteDe_Click);
            // 
            // btnSaveDe
            // 
            this.btnSaveDe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveDe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveDe.Depth = 0;
            this.btnSaveDe.HighEmphasis = true;
            this.btnSaveDe.Icon = null;
            this.btnSaveDe.Location = new System.Drawing.Point(21, 245);
            this.btnSaveDe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveDe.Name = "btnSaveDe";
            this.btnSaveDe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveDe.Size = new System.Drawing.Size(64, 36);
            this.btnSaveDe.TabIndex = 58;
            this.btnSaveDe.Text = "Save";
            this.btnSaveDe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveDe.UseAccentColor = false;
            this.btnSaveDe.UseVisualStyleBackColor = true;
            this.btnSaveDe.Click += new System.EventHandler(this.btnSaveDe_Click);
            // 
            // txtDeDepartmentName
            // 
            this.txtDeDepartmentName.AnimateReadOnly = false;
            this.txtDeDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeDepartmentName.Depth = 0;
            this.txtDeDepartmentName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeDepartmentName.LeadingIcon = null;
            this.txtDeDepartmentName.Location = new System.Drawing.Point(141, 171);
            this.txtDeDepartmentName.MaxLength = 50;
            this.txtDeDepartmentName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDeDepartmentName.Multiline = false;
            this.txtDeDepartmentName.Name = "txtDeDepartmentName";
            this.txtDeDepartmentName.Size = new System.Drawing.Size(221, 50);
            this.txtDeDepartmentName.TabIndex = 56;
            this.txtDeDepartmentName.Text = "";
            this.txtDeDepartmentName.TrailingIcon = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Name";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(336, 13);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(293, 41);
            this.materialLabel4.TabIndex = 55;
            this.materialLabel4.Text = "CRUD Departments";
            // 
            // TPPosition
            // 
            this.TPPosition.Controls.Add(this.pictureBox4);
            this.TPPosition.Controls.Add(this.dgvPositions);
            this.TPPosition.Controls.Add(this.label10);
            this.TPPosition.Controls.Add(this.txtPoDailySalary);
            this.TPPosition.Controls.Add(this.btnResetPo);
            this.TPPosition.Controls.Add(this.btnDeletePo);
            this.TPPosition.Controls.Add(this.btnSavePo);
            this.TPPosition.Controls.Add(this.txtPoPositionName);
            this.TPPosition.Controls.Add(this.cmbPoDepartment);
            this.TPPosition.Controls.Add(this.label9);
            this.TPPosition.Controls.Add(this.label8);
            this.TPPosition.Controls.Add(this.materialLabel5);
            this.TPPosition.ImageKey = "work256.png";
            this.TPPosition.Location = new System.Drawing.Point(4, 31);
            this.TPPosition.Name = "TPPosition";
            this.TPPosition.Padding = new System.Windows.Forms.Padding(3);
            this.TPPosition.Size = new System.Drawing.Size(986, 508);
            this.TPPosition.TabIndex = 5;
            this.TPPosition.Text = "Position";
            this.TPPosition.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinformsDUCCompany3a.Properties.Resources.work256;
            this.pictureBox4.Location = new System.Drawing.Point(438, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 80;
            this.pictureBox4.TabStop = false;
            // 
            // dgvPositions
            // 
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoPositionId,
            this.PoPositionName,
            this.PoDepartmentName,
            this.PoDailySalary,
            this.PoDepartmentId});
            this.dgvPositions.Location = new System.Drawing.Point(393, 154);
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.Size = new System.Drawing.Size(509, 150);
            this.dgvPositions.TabIndex = 79;
            this.dgvPositions.DoubleClick += new System.EventHandler(this.dgvPositions_DoubleClick);
            // 
            // PoPositionId
            // 
            this.PoPositionId.DataPropertyName = "PositionId";
            this.PoPositionId.HeaderText = "Id ";
            this.PoPositionId.Name = "PoPositionId";
            this.PoPositionId.Width = 40;
            // 
            // PoPositionName
            // 
            this.PoPositionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PoPositionName.DataPropertyName = "PositionName";
            this.PoPositionName.HeaderText = "Name ";
            this.PoPositionName.Name = "PoPositionName";
            // 
            // PoDepartmentName
            // 
            this.PoDepartmentName.DataPropertyName = "DepartmentName";
            this.PoDepartmentName.HeaderText = "Department Name ";
            this.PoDepartmentName.Name = "PoDepartmentName";
            this.PoDepartmentName.Width = 150;
            // 
            // PoDailySalary
            // 
            this.PoDailySalary.DataPropertyName = "DailySalary";
            this.PoDailySalary.HeaderText = "Daily Salary ";
            this.PoDailySalary.Name = "PoDailySalary";
            // 
            // PoDepartmentId
            // 
            this.PoDepartmentId.DataPropertyName = "DepartmentId";
            this.PoDepartmentId.HeaderText = "Department Id ";
            this.PoDepartmentId.Name = "PoDepartmentId";
            this.PoDepartmentId.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Daily Salary ";
            // 
            // txtPoDailySalary
            // 
            this.txtPoDailySalary.AnimateReadOnly = false;
            this.txtPoDailySalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoDailySalary.Depth = 0;
            this.txtPoDailySalary.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPoDailySalary.LeadingIcon = null;
            this.txtPoDailySalary.Location = new System.Drawing.Point(143, 284);
            this.txtPoDailySalary.MaxLength = 50;
            this.txtPoDailySalary.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPoDailySalary.Multiline = false;
            this.txtPoDailySalary.Name = "txtPoDailySalary";
            this.txtPoDailySalary.Size = new System.Drawing.Size(221, 50);
            this.txtPoDailySalary.TabIndex = 77;
            this.txtPoDailySalary.Text = "";
            this.txtPoDailySalary.TrailingIcon = null;
            // 
            // btnResetPo
            // 
            this.btnResetPo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetPo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResetPo.Depth = 0;
            this.btnResetPo.HighEmphasis = true;
            this.btnResetPo.Icon = null;
            this.btnResetPo.Location = new System.Drawing.Point(219, 359);
            this.btnResetPo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResetPo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResetPo.Name = "btnResetPo";
            this.btnResetPo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResetPo.Size = new System.Drawing.Size(65, 36);
            this.btnResetPo.TabIndex = 74;
            this.btnResetPo.Text = "Reset";
            this.btnResetPo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResetPo.UseAccentColor = false;
            this.btnResetPo.UseVisualStyleBackColor = true;
            this.btnResetPo.Click += new System.EventHandler(this.btnResetPo_Click);
            // 
            // btnDeletePo
            // 
            this.btnDeletePo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeletePo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeletePo.Depth = 0;
            this.btnDeletePo.HighEmphasis = true;
            this.btnDeletePo.Icon = null;
            this.btnDeletePo.Location = new System.Drawing.Point(119, 359);
            this.btnDeletePo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeletePo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletePo.Name = "btnDeletePo";
            this.btnDeletePo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeletePo.Size = new System.Drawing.Size(73, 36);
            this.btnDeletePo.TabIndex = 73;
            this.btnDeletePo.Text = "Delete";
            this.btnDeletePo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeletePo.UseAccentColor = false;
            this.btnDeletePo.UseVisualStyleBackColor = true;
            this.btnDeletePo.Click += new System.EventHandler(this.btnDeletePo_Click);
            // 
            // btnSavePo
            // 
            this.btnSavePo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSavePo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSavePo.Depth = 0;
            this.btnSavePo.HighEmphasis = true;
            this.btnSavePo.Icon = null;
            this.btnSavePo.Location = new System.Drawing.Point(24, 359);
            this.btnSavePo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSavePo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSavePo.Name = "btnSavePo";
            this.btnSavePo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSavePo.Size = new System.Drawing.Size(64, 36);
            this.btnSavePo.TabIndex = 72;
            this.btnSavePo.Text = "Save";
            this.btnSavePo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSavePo.UseAccentColor = false;
            this.btnSavePo.UseVisualStyleBackColor = true;
            this.btnSavePo.Click += new System.EventHandler(this.btnSavePo_Click);
            // 
            // txtPoPositionName
            // 
            this.txtPoPositionName.AnimateReadOnly = false;
            this.txtPoPositionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoPositionName.Depth = 0;
            this.txtPoPositionName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPoPositionName.LeadingIcon = null;
            this.txtPoPositionName.Location = new System.Drawing.Point(143, 154);
            this.txtPoPositionName.MaxLength = 50;
            this.txtPoPositionName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPoPositionName.Multiline = false;
            this.txtPoPositionName.Name = "txtPoPositionName";
            this.txtPoPositionName.Size = new System.Drawing.Size(221, 50);
            this.txtPoPositionName.TabIndex = 70;
            this.txtPoPositionName.Text = "";
            this.txtPoPositionName.TrailingIcon = null;
            // 
            // cmbPoDepartment
            // 
            this.cmbPoDepartment.AutoResize = false;
            this.cmbPoDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPoDepartment.Depth = 0;
            this.cmbPoDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPoDepartment.DropDownHeight = 174;
            this.cmbPoDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoDepartment.DropDownWidth = 121;
            this.cmbPoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPoDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPoDepartment.FormattingEnabled = true;
            this.cmbPoDepartment.IntegralHeight = false;
            this.cmbPoDepartment.ItemHeight = 43;
            this.cmbPoDepartment.Location = new System.Drawing.Point(143, 219);
            this.cmbPoDepartment.MaxDropDownItems = 4;
            this.cmbPoDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPoDepartment.Name = "cmbPoDepartment";
            this.cmbPoDepartment.Size = new System.Drawing.Size(221, 49);
            this.cmbPoDepartment.StartIndex = 0;
            this.cmbPoDepartment.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Name";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(340, 13);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(237, 41);
            this.materialLabel5.TabIndex = 69;
            this.materialLabel5.Text = "CRUD Positions";
            // 
            // TPChart
            // 
            this.TPChart.Controls.Add(this.chart1);
            this.TPChart.Controls.Add(this.materialLabel7);
            this.TPChart.ImageKey = "chart256.png";
            this.TPChart.Location = new System.Drawing.Point(4, 31);
            this.TPChart.Name = "TPChart";
            this.TPChart.Padding = new System.Windows.Forms.Padding(3);
            this.TPChart.Size = new System.Drawing.Size(986, 508);
            this.TPChart.TabIndex = 6;
            this.TPChart.Text = "Chart";
            this.TPChart.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 82);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Profit_In_2023";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(935, 430);
            this.chart1.TabIndex = 53;
            this.chart1.Text = "chart1";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel7.Location = new System.Drawing.Point(450, 15);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(84, 41);
            this.materialLabel7.TabIndex = 52;
            this.materialLabel7.Text = "Chart";
            // 
            // TPCrystalReport
            // 
            this.TPCrystalReport.Controls.Add(this.CRViewer1);
            this.TPCrystalReport.ImageKey = "report256.png";
            this.TPCrystalReport.Location = new System.Drawing.Point(4, 31);
            this.TPCrystalReport.Name = "TPCrystalReport";
            this.TPCrystalReport.Padding = new System.Windows.Forms.Padding(3);
            this.TPCrystalReport.Size = new System.Drawing.Size(986, 508);
            this.TPCrystalReport.TabIndex = 7;
            this.TPCrystalReport.Text = "Crystal Report";
            this.TPCrystalReport.UseVisualStyleBackColor = true;
            // 
            // CRViewer1
            // 
            this.CRViewer1.ActiveViewIndex = -1;
            this.CRViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewer1.Location = new System.Drawing.Point(3, 3);
            this.CRViewer1.Name = "CRViewer1";
            this.CRViewer1.Size = new System.Drawing.Size(980, 502);
            this.CRViewer1.TabIndex = 0;
            this.CRViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home256.png");
            this.imageList1.Images.SetKeyName(1, "group_people256.png");
            this.imageList1.Images.SetKeyName(2, "user256.png");
            this.imageList1.Images.SetKeyName(3, "people256.png");
            this.imageList1.Images.SetKeyName(4, "work256.png");
            this.imageList1.Images.SetKeyName(5, "chart256.png");
            this.imageList1.Images.SetKeyName(6, "salary256.png");
            this.imageList1.Images.SetKeyName(7, "report256.png");
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Update";
            this.dataGridViewImageColumn1.Image = global::WinformsDUCCompany3a.Properties.Resources.edit16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::WinformsDUCCompany3a.Properties.Resources.bin16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 610);
            this.Controls.Add(this.TCMain);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TCMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUC COMPANY";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TCMain.ResumeLayout(false);
            this.TPHome.ResumeLayout(false);
            this.TPHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.TPCRUD.ResumeLayout(false);
            this.TPCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpPhoto)).EndInit();
            this.TPProfile.ResumeLayout(false);
            this.TPProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TPSalary.ResumeLayout(false);
            this.TPSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TPDepartment.ResumeLayout(false);
            this.TPDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.TPPosition.ResumeLayout(false);
            this.TPPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            this.TPChart.ResumeLayout(false);
            this.TPChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.TPCrystalReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TCMain;
        private System.Windows.Forms.TabPage TPHome;
        private System.Windows.Forms.TabPage TPCRUD;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage TPProfile;
        private System.Windows.Forms.TabPage TPSalary;
        private System.Windows.Forms.TabPage TPDepartment;
        private System.Windows.Forms.TabPage TPPosition;
        private System.Windows.Forms.TabPage TPChart;
        private MaterialSkin.Controls.MaterialButton btnExportToPDF;
        private MaterialSkin.Controls.MaterialButton btnExportToExcel;
        private MaterialSkin.Controls.MaterialButton btnPrint;
        private MaterialSkin.Controls.MaterialButton btnShowAll;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private MaterialSkin.Controls.MaterialTextBox txtSearchEmpByName;
        private MaterialSkin.Controls.MaterialComboBox cmbHomeDepartment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private MaterialSkin.Controls.MaterialButton btnResetEmp;
        private MaterialSkin.Controls.MaterialButton btnDeleteEmp;
        private MaterialSkin.Controls.MaterialButton btnSaveEmp;
        private MaterialSkin.Controls.MaterialButton btnClearEmpPhoto;
        private MaterialSkin.Controls.MaterialButton btnUploadEmpPhoto;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtEmpAddress;
        private MaterialSkin.Controls.MaterialTextBox txtEmpName;
        private MaterialSkin.Controls.MaterialComboBox cmbEmpPosition;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialComboBox cmbEmpDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialComboBox cmbEmpGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEmpDOB;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pbEmpPhoto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LabelProRole;
        private System.Windows.Forms.Label LabelProEmail;
        private System.Windows.Forms.Label LabelProUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnSaExportToPDF;
        private MaterialSkin.Controls.MaterialButton btnSaExportToExcel;
        private MaterialSkin.Controls.MaterialButton btnSaPrint;
        private MaterialSkin.Controls.MaterialButton btnSaShowMoSalary;
        private MaterialSkin.Controls.MaterialButton btnSaSearchById;
        private MaterialSkin.Controls.MaterialTextBox txtSaSearchEmpById;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSaEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlySalary;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private MaterialSkin.Controls.MaterialButton btnResetDe;
        private MaterialSkin.Controls.MaterialButton btnDeleteDe;
        private MaterialSkin.Controls.MaterialButton btnSaveDe;
        private MaterialSkin.Controls.MaterialTextBox txtDeDepartmentName;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialTextBox txtPoDailySalary;
        private MaterialSkin.Controls.MaterialButton btnResetPo;
        private MaterialSkin.Controls.MaterialButton btnDeletePo;
        private MaterialSkin.Controls.MaterialButton btnSavePo;
        private MaterialSkin.Controls.MaterialTextBox txtPoPositionName;
        private MaterialSkin.Controls.MaterialComboBox cmbPoDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailySalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpImagePath;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeDepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeDepartmentName;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoPositionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoPositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoDailySalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoDepartmentId;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage TPCrystalReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewer1;
    }
}