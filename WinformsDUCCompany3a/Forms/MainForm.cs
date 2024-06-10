using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinformsDUCCompany3a.CrystalReports;
using WinformsDUCCompany3a.Tools;

namespace WinformsDUCCompany3a.Forms
{
    public partial class MainForm :  MaterialForm
    {
        int cmbDepartmentId = 0;
        bool isDefaultImage = true;
        string previousImageString = "";
        int inEmpId = 0;
        int inDepartmentId = 0;
        int inPositionId = 0;
        string connectionString = CommonServices.conString;
        OpenFileDialog ofd = new OpenFileDialog();
        public string UserRole { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme
                (Primary.Green400, Primary.Green600, Primary.Indigo100,
                Accent.Green700, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ClearEmp();
            ClearDe();
            ClearPo();
            FillAllComboBoxes();
            ForAdmin();
            FillProfile();
            FillAllDataGridViews();
            DrawChart();
            ShowCRProfit_2023();
        }

        // Fill All ComboBoxes
        private void FillAllComboBoxes()
        {
            FillcmbHomeDepartment();
            FillcmbEmpDepartment();
            FillcmbPoDepartment();
        }
        // Fill All DataGridViews
        private void FillAllDataGridViews()
        {
            FilldgvEmployees();
            FilldgvDepartments();
            FilldgvPositions();
        }
        // Reset Employees
        private void btnResetEmp_Click(object sender, EventArgs e)
        {
            ClearEmp();
        }
        // Clear Employees
        private void ClearEmp()
        {
            txtEmpName.Clear();
            dtpEmpDOB.Value = DateTime.Now;
            if (cmbEmpGender.DataSource != null)
            {
                //cmbEmpGender.Text = "";
                cmbEmpGender.SelectedIndex = 0;
            }
            txtEmpAddress.Clear();
            if (cmbEmpDepartment.DataSource != null)
            {
                cmbEmpDepartment.SelectedIndex = 0;
            }
            if (cmbEmpPosition.DataSource != null)
            {
                cmbEmpPosition.SelectedIndex = 0;
            }

            inEmpId = 0;
            pbEmpPhoto.Image = System.Drawing.Image
                .FromFile(Application.StartupPath + "\\Images\\user256.png");
            isDefaultImage = true;
            btnSaveEmp.Text = "Save";
            // To disable Delete button
            btnDeleteEmp.Enabled = false;

        }

        // For Admin
        private void ForAdmin()
        {
            // is Admin
            if (UserRole == "Admin")
            {
                btnSaveEmp.Show();
                btnDeleteEmp.Show();
                btnUploadEmpPhoto.Show();
                btnClearEmpPhoto.Show();
                btnSaveDe.Show();
                btnDeleteDe.Show();
                dgvDepartments.Show();
                btnSavePo.Show();
                btnDeletePo.Show();
            }
            // is not Admin
            else
            {
                btnSaveEmp.Hide();
                btnDeleteEmp.Hide();
                btnUploadEmpPhoto.Hide();
                btnClearEmpPhoto.Hide();
                btnSaveDe.Hide();
                btnDeleteDe.Hide();
                dgvDepartments.Hide();
                btnSavePo.Hide();
                btnDeletePo.Hide();
            }
        }
        private void FillProfile()
        {
            LabelProUsername.Text += UserName;
            LabelProEmail.Text += UserEmail;
            LabelProRole.Text += UserRole;
        }

        private void FillcmbEmpDepartment()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "Select * from Departments";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                conn.Close();
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                // In the 2 following lines,"DepartmentId" and "DepartmentName" are from Departments table
                cmbEmpDepartment.ValueMember = "DepartmentId";
                cmbEmpDepartment.DisplayMember = "DepartmentName";
                cmbEmpDepartment.DataSource = dt;
                //conn.Close();
            }
        }

        private void FillcmbHomeDepartment()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "Select * from Departments";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                conn.Close();
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                // In the 2 following lines,"DepartmentId" and "DepartmentName" are from Departments table
                cmbHomeDepartment.ValueMember = "DepartmentId";
                cmbHomeDepartment.DisplayMember = "DepartmentName";
                cmbHomeDepartment.DataSource = dt;
                //conn.Close();
            }

        }

        // Cascading dropdown
        private void FillcmbEmpPosition(int DepartmentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"Select * from Positions where DepartmentId = {DepartmentId} ";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                conn.Close();
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                // In the 2 following lines,"PositionId" and "PositionName" are from Positions table
                cmbEmpPosition.ValueMember = "PositionId";
                cmbEmpPosition.DisplayMember = "PositionName";
                cmbEmpPosition.DataSource = dt;
            }

        }
        // Cascading dropdown
        private void cmbEmpDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpDepartment.SelectedValue != null)
            {
                cmbDepartmentId = Convert.ToInt32(cmbEmpDepartment.SelectedValue);
                FillcmbEmpPosition(cmbDepartmentId);
            }
        }

        private void btnUploadEmpPhoto_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbEmpPhoto.Image = new Bitmap(ofd.FileName);
                isDefaultImage = false;
                previousImageString = "";
            }
        }

        private void btnClearEmpPhoto_Click(object sender, EventArgs e)
        {
            pbEmpPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\user256.png");
            isDefaultImage = true;
            previousImageString = "";
        }

        // Check form of employees
        private bool checkFormEmp()
        {
            if (txtEmpName.Text == "" || txtEmpAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields",
                   "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        private string saveImage(string _imagePath)
        {
            string _fileName = Path.GetFileNameWithoutExtension(_imagePath);
            string _extension = Path.GetExtension(_imagePath);
            // shorten image Name
            _fileName = _fileName.Length <= 15 ? _fileName : _fileName.Substring(0, 15);
            _fileName = _fileName + DateTime.Now.ToString("yymmssfff") + _extension;
            pbEmpPhoto.Image.Save(Application.StartupPath + "\\Images\\" + _fileName);
            return _fileName;
        }

        private void FilldgvEmployees()
        {
            txtSearchEmpByName.Clear();
            dgvEmployees.AutoGenerateColumns = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("EmployeeList", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvEmployees.DataSource = dt;
            }
        }
        // Create or Update employee
        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            if (checkFormEmp())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // For table Employees

                    conn.Open();
                    var cmd = new SqlCommand("EmployeeCreateOrEdit", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("EmpId", inEmpId);
                    cmd.Parameters.AddWithValue("EmpName", txtEmpName.Text.Trim());
                    cmd.Parameters.AddWithValue("EmpDOB", dtpEmpDOB.Value);
                    cmd.Parameters.AddWithValue("EmpGender", cmbEmpGender.Text);
                    cmd.Parameters.AddWithValue("EmpAddress", txtEmpAddress.Text.Trim());
                    cmd.Parameters
                        .AddWithValue("DepartmentId", Convert.ToInt32(cmbEmpDepartment.SelectedValue));
                    cmd.Parameters
                            .AddWithValue("PositionId", Convert.ToInt32(cmbEmpPosition.SelectedValue));

                    // Create
                    if (inEmpId == 0)
                    {
                        if (isDefaultImage)
                        {
                            cmd.Parameters.AddWithValue("EmpImagePath", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("EmpImagePath", saveImage(ofd.FileName));
                        }
                    }
                    // Update
                    else
                    {
                        if (isDefaultImage)
                        {
                            cmd.Parameters.AddWithValue("EmpImagePath", DBNull.Value);
                        }
                        else
                        {
                            if (previousImageString != "")
                            {
                                cmd.Parameters.AddWithValue("EmpImagePath", previousImageString);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("EmpImagePath", saveImage(ofd.FileName));
                            }
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                ClearEmp();
                FilldgvEmployees();
                CommonServices.ShowPopUpNoti("Successfully saved");
            }
        }
        
        // Delete Employee
        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?",
                        "CRUD operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("EmployeeDelete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("EmpId", inEmpId);
                    cmd.ExecuteNonQuery();
                    ClearEmp();
                    FilldgvEmployees();
                    CommonServices.ShowPopUpNoti("Successfully deleted");
                }
            }
        }

        private void dgvEmployees_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow.Index != -1)
            {
                inEmpId = Convert.ToInt32(dgvEmployees
                    .CurrentRow.Cells[0].Value);
                txtEmpName.Text = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
                dtpEmpDOB.Value = Convert.ToDateTime(dgvEmployees.CurrentRow.Cells[2].Value);
                cmbEmpGender.Text = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
                txtEmpAddress.Text = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
                cmbEmpDepartment.SelectedValue = dgvEmployees.CurrentRow.Cells[8].Value;
                cmbEmpPosition.SelectedValue = dgvEmployees.CurrentRow.Cells[9].Value;

                // In the next line,"DBNull.Value" cannot be replaced by "null".
                // Otherwise, there will be an error 
                if (dgvEmployees.CurrentRow.Cells[10].Value == DBNull.Value)
                {
                    pbEmpPhoto.Image = System.Drawing.Image
                        .FromFile(Application.StartupPath + "\\Images\\user256.png");
                    // The 2 above lines are equivalent to the 2 following lines
                    //pbEmpPhoto.Image =
                    //    new Bitmap (Application.StartupPath + "\\Images\\User1.png");
                    isDefaultImage = true;
                }
                else
                {
                    pbEmpPhoto.Image = System.Drawing.Image
                        .FromFile(Application.StartupPath + "\\Images\\"
                   + dgvEmployees.CurrentRow.Cells[10].Value.ToString());
                    isDefaultImage = false;
                    previousImageString = dgvEmployees.CurrentRow.Cells[10].Value.ToString();
                }
                btnSaveEmp.Text = "Update";
                btnDeleteEmp.Enabled = true;
            }
        }
        // txtSearchEmpByName only accepts letters and space
        private void txtSearchEmpByName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z\s\b]"))
            {
                e.Handled = true;
            }
        }
        // Search employee by name
        private void txtSearchEmpByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmpByName.Text != "")
            {
                dgvEmployees.AutoGenerateColumns = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("GetEmployeeByName", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("searchStr", txtSearchEmpByName.Text.Trim());
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvEmployees.DataSource = dt;
                }
            }
            else
            {
                FilldgvEmployees();
            }
        }
        // Filter Employees
        private void btnFilter_Click(object sender, EventArgs e)
        {
            txtSearchEmpByName.Clear();
            dgvEmployees.AutoGenerateColumns = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("GetEmployeeByDepartmentId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("DepartmentId", Convert.ToInt32(cmbHomeDepartment.SelectedValue));
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvEmployees.DataSource = dt;
            }
        }
        // Show All Employees
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FilldgvEmployees();
        }
        // Export to Excel file
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application excel;
                    Microsoft.Office.Interop.Excel.Workbook workbook;
                    Microsoft.Office.Interop.Excel.Worksheet worksheet;
                    try
                    {
                        // Create a COM object
                        excel = new Microsoft.Office.Interop.Excel.Application();
                        excel.Visible = false;
                        excel.DisplayAlerts = false;
                        // Create a workbook by add()
                        workbook = excel.Workbooks.Add(Type.Missing);
                        worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook
                            .Sheets["Sheet1"];
                        worksheet.Name = "Employee Management";
                        //Export header from Datagridview."-3" because we do not need to see 3 last columns.
                        for (int i = 0; i < dgvEmployees.ColumnCount-3; i++)
                        {
                            worksheet.Cells[1, i + 1] = dgvEmployees.Columns[i].HeaderText;
                        }
                        //Export content from Datagridview
                        for (int i = 0; i < dgvEmployees.RowCount; i++)
                        {
                            // "-3" because we do not need to see 3 last columns.
                            for (int j = 0; j < dgvEmployees.ColumnCount-3; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvEmployees.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                        // Save
                        workbook.SaveAs(sfd.FileName);
                        workbook.Close();
                        excel.Quit();
                        CommonServices.ShowPopUpNoti("Exported to Excel successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        workbook = null;
                        worksheet = null;
                    }
                }
            }
        }
        // Export to PDF file
        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf"; ;
                sfd.FileName = "PDFResult.pdf";
                bool ErrorMessage = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show
                                ("Unable to save " + ex.Message, "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pdfPTable =
                                new PdfPTable(dgvEmployees.Columns.Count);
                            pdfPTable.DefaultCell.Padding = 2;
                            pdfPTable.WidthPercentage = 100;
                            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvEmployees.Columns)
                            {
                                PdfPCell pdfPCell =
                                    new PdfPCell(new Phrase(col.HeaderText));
                                pdfPTable.AddCell(pdfPCell);
                            }
                            foreach (DataGridViewRow row in dgvEmployees.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfPTable.AddCell(cell.Value?.ToString());
                                }
                            }


                            using (FileStream fileStream =
                                new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document document =
                                    new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pdfPTable);
                                document.Close();
                                fileStream.Close();
                            }
                            CommonServices.ShowPopUpNoti("Exported to PDF successfully");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show
                                ("Error while exporting: " + ex.Message, "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No record found", "Info");
            }
        }
        
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap
              (dgvEmployees.Width, dgvEmployees.Height);
            dgvEmployees.DrawToBitmap(bitmap,
                new System.Drawing.Rectangle(0, 0, dgvEmployees.Width, dgvEmployees.Height));
            e.Graphics.DrawImage(bitmap, 80, 150);
            // Print Header
            e.Graphics.DrawString("Employees",
                new System.Drawing.Font("Verdana", 25, FontStyle.Bold), Brushes.Black,
                new Point(50, 50));
        }
        // Print
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        // TapPage Salary
        // txtSaSearchEmpById only accepts numbers
        private void txtSaSearchEmpById_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Search employee by Id
        private void btnSaSearchById_Click(object sender, EventArgs e)
        {
            dgvSaEmployees.AutoGenerateColumns = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("GetEmployeeById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("EmpId", Convert.ToInt32(txtSaSearchEmpById.Text.Trim()));
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvSaEmployees.DataSource = dt;
            }
        }
        // Show Monthly Salary
        private void btnSaShowMoSalary_Click(object sender, EventArgs e)
        {
            var dailySalary
               = Convert.ToDouble(dgvSaEmployees.Rows[0].Cells[4].Value);
            var lateTimes
               = Convert.ToDouble(dgvSaEmployees.Rows[0].Cells[5].Value);
            var workingDays
               = Convert.ToDouble(dgvSaEmployees.Rows[0].Cells[6].Value);
            var monthlySalary
               = dailySalary * workingDays - lateTimes * 2;
            dgvSaEmployees.Rows[0].Cells[8].Value = monthlySalary;
        }
        // Export to Excel file
        private void btnSaExportToExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application excel;
                    Microsoft.Office.Interop.Excel.Workbook workbook;
                    Microsoft.Office.Interop.Excel.Worksheet worksheet;
                    try
                    {
                        // Create a COM object
                        excel = new Microsoft.Office.Interop.Excel.Application();
                        excel.Visible = false;
                        excel.DisplayAlerts = false;
                        // Create a workbook by add()
                        workbook = excel.Workbooks.Add(Type.Missing);
                        worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook
                            .Sheets["Sheet1"];
                        worksheet.Name = "Salary";
                        //Export header from Datagridview
                        for (int i = 0; i < dgvSaEmployees.ColumnCount; i++)
                        {
                            worksheet.Cells[1, i + 1] = dgvSaEmployees.Columns[i].HeaderText;
                        }
                        //Export content from Datagridview
                        for (int i = 0; i < dgvSaEmployees.RowCount; i++)
                        {
                            for (int j = 0; j < dgvSaEmployees.ColumnCount; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvSaEmployees.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                        // Save
                        workbook.SaveAs(sfd.FileName);
                        workbook.Close();
                        excel.Quit();
                        CommonServices.ShowPopUpNoti("Exported to Excel successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        workbook = null;
                        worksheet = null;
                    }
                }
            }
        }
        // Export to PDF file
        private void btnSaExportToPDF_Click(object sender, EventArgs e)
        {
            if (dgvSaEmployees.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf"; ;
                sfd.FileName = "PDFResult.pdf";
                bool ErrorMessage = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show
                                ("Unable to save " + ex.Message, "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pdfPTable =
                                new PdfPTable(dgvSaEmployees.Columns.Count);
                            pdfPTable.DefaultCell.Padding = 2;
                            pdfPTable.WidthPercentage = 100;
                            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvSaEmployees.Columns)
                            {
                                PdfPCell pdfPCell =
                                    new PdfPCell(new Phrase(col.HeaderText));
                                pdfPTable.AddCell(pdfPCell);
                            }
                            foreach (DataGridViewRow row in dgvSaEmployees.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfPTable.AddCell(cell.Value?.ToString());
                                }
                            }


                            using (FileStream fileStream =
                                new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document document =
                                    new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pdfPTable);
                                document.Close();
                                fileStream.Close();
                            }
                            CommonServices.ShowPopUpNoti("Exported to PDF successfully");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show
                                ("Error while exporting: " + ex.Message, "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No record found", "Info");
            }
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap
              (dgvSaEmployees.Width, dgvSaEmployees.Height);
            dgvSaEmployees.DrawToBitmap(bitmap,
                new System.Drawing.Rectangle(0, 0, dgvSaEmployees.Width, dgvSaEmployees.Height));
            e.Graphics.DrawImage(bitmap, 60, 200);
            // Print Header
            e.Graphics.DrawString("Salary",
                new System.Drawing.Font("Verdana", 25, FontStyle.Bold), Brushes.Black,
                new Point(50, 50));
        }
        // Print
        private void btnSaPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }

        // TapPage Department
        // CRUD Departments
        // Save Department
        private void btnSaveDe_Click(object sender, EventArgs e)
        {
            if (txtDeDepartmentName.Text == "")
            {
                MessageBox.Show("Please fill all fields",
                    "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Create
                    if (inDepartmentId == 0)
                    {
                        string query = $"INSERT INTO Departments (DepartmentName) VALUES " +
                            $"( '{txtDeDepartmentName.Text.Trim()}')";
                        conn.Open();
                        var cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    // Update
                    else
                    {
                        string query = $"Update Departments set DepartmentName='{txtDeDepartmentName.Text.Trim()}' " +
                            $" Where DepartmentId ='{inDepartmentId}'  " ;
                        conn.Open();
                        var cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                ClearDe();
                FillAllComboBoxes();
                FillAllDataGridViews();
                CommonServices.ShowPopUpNoti("Successfully saved");
            }
        }
        // Delete Department
        private void btnDeleteDe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?",
                "EF CRUD operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $"Delete from Departments where DepartmentId = {inDepartmentId}";
                    conn.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                ClearDe();
                FillAllComboBoxes();
                FillAllDataGridViews();
                CommonServices.ShowPopUpNoti("Successfully deleted");
            }
        }

        private void btnResetDe_Click(object sender, EventArgs e)
        {
            ClearDe();
        }

        // Clear Department
        private void ClearDe()
        {
            txtDeDepartmentName.Clear();
            inDepartmentId = 0;
            btnSaveDe.Text = "Save";
            // To disable Delete button
            btnDeleteDe.Enabled = false;
        }
        // Fill dgvDepartments
        private void FilldgvDepartments()
        {
            dgvDepartments.AutoGenerateColumns = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "Select * from Departments";
                conn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvDepartments.DataSource = dt;
                conn.Close();
            }
        }

        private void dgvDepartments_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDepartments.CurrentRow.Index != -1)
            {
                inDepartmentId = Convert.ToInt32(dgvDepartments
                    .CurrentRow.Cells[0].Value);
                txtDeDepartmentName.Text = dgvDepartments.CurrentRow.Cells[1].Value.ToString();
                btnSaveDe.Text = "Update";
                btnDeleteDe.Enabled = true;
            }
        }

        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            inDepartmentId = Convert.ToInt32(dgvDepartments
                  .CurrentRow.Cells[0].Value);
            if (dgvDepartments.Columns[e.ColumnIndex].Name == "Delete"
                && dgvDepartments.CurrentRow.Index != -1)
            {
                if (MessageBox.Show("Are you sure you want to delete this ?",
                "EF CRUD operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = $"Delete from Departments where DepartmentId = {inDepartmentId}";
                        conn.Open();
                        var cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    ClearDe();
                    FillAllComboBoxes();
                    FillAllDataGridViews();
                    CommonServices.ShowPopUpNoti("Successfully deleted");
                }
            }

            if (dgvDepartments.Columns[e.ColumnIndex].Name == "Update"
                && dgvDepartments.CurrentRow.Index != -1)
            {
                if (dgvDepartments.CurrentRow.Cells[1].Value.ToString() == "" )
                {
                    MessageBox.Show("Please fill all fields",
                        "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = $"Update Departments " +
                            $" set DepartmentName='{dgvDepartments.CurrentRow.Cells[1].Value.ToString()}' " +
                            $" Where DepartmentId ='{inDepartmentId}'  ";
                        conn.Open();
                        var cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    ClearDe();
                    FillAllComboBoxes();
                    FillAllDataGridViews();
                    CommonServices.ShowPopUpNoti("Successfully updated");
                }
            }
        }

        // TapPage Position
        // CRUD Positions
        // Save Position
        private void btnSavePo_Click(object sender, EventArgs e)
        {
            if (txtPoPositionName.Text == "" || 
                txtPoDailySalary.Text == "")
            {
                MessageBox.Show("Please fill all fields",
                    "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Create
                    if (inPositionId == 0)
                    {
                        string query = $"INSERT INTO Positions (PositionName,DepartmentId " +
                            $" , DailySalary  ) VALUES " +
                            $"( '{txtPoPositionName.Text.Trim()}'," +
                            $" '{Convert.ToInt32(cmbPoDepartment.SelectedValue)}' , " +
                            $" '{Convert.ToDouble(txtPoDailySalary.Text.Trim())}'  )";
                        conn.Open();
                        var cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = query; 
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    // Update
                    else
                    {
                        string query = $"Update Positions set PositionName='{txtPoPositionName.Text.Trim()}' , " +
                            $" DepartmentId = '{Convert.ToInt32(cmbPoDepartment.SelectedValue)}' , " +
                            $" DailySalary = '{Convert.ToDouble(txtPoDailySalary.Text.Trim())}'  " +
                            $" Where PositionId ='{inPositionId}'  ";
                        conn.Open();
                        var cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                ClearPo();
                FillAllComboBoxes();
                FillAllDataGridViews();
                CommonServices.ShowPopUpNoti("Successfully saved");
            }
        }
        // Delete Position
        private void btnDeletePo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?",
                "CRUD operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $"Delete from Positions where PositionId  = {inPositionId}";
                    conn.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                ClearPo();
                FillAllComboBoxes();
                FillAllDataGridViews();
                CommonServices.ShowPopUpNoti("Successfully deleted");
            }
        }

        private void btnResetPo_Click(object sender, EventArgs e)
        {
            ClearPo();
        }

        // Clear Position
        private void ClearPo()
        {
            txtPoPositionName.Clear();
            txtPoDailySalary.Clear();
            inPositionId = 0;
            btnSavePo.Text = "Save";
            // To disable Delete button
            btnDeletePo.Enabled = false;
        }
        // Fill dgvPositions

        private void FilldgvPositions()
        {
            dgvPositions.AutoGenerateColumns = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("PositionList", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvPositions.DataSource = dt;
            }
        }

        // Fill combobox cmbPoDepartment
        private void FillcmbPoDepartment()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "Select * from Departments";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                conn.Close();
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                // In the 2 following lines,"DepartmentId" and "DepartmentName" are from Departments table
                cmbPoDepartment.ValueMember = "DepartmentId";
                cmbPoDepartment.DisplayMember = "DepartmentName";
                cmbPoDepartment.DataSource = dt;
                //conn.Close();
            }
        }

        private void dgvPositions_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPositions.CurrentRow.Index != -1)
            {
                inPositionId = Convert.ToInt32(dgvPositions
                    .CurrentRow.Cells[0].Value);
                txtPoPositionName.Text = dgvPositions.CurrentRow.Cells[1].Value.ToString();
                cmbPoDepartment.SelectedValue = Convert.ToInt32(dgvPositions.CurrentRow.Cells[4].Value);
                txtPoDailySalary.Text = dgvPositions.CurrentRow.Cells[3].Value.ToString();
                btnSavePo.Text = "Update";
                btnDeletePo.Enabled = true;
            }
        }
        // Draw chart
        private void DrawChart()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "Select Month ,Profit  from Profit_2023  ";
                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                chart1.DataSource = dt;
                conn.Close();
                chart1.Series["Profit_In_2023"].XValueMember = "Month";
                chart1.Series["Profit_In_2023"].YValueMembers = "Profit";
                chart1.Titles.Add("Profit in 2023");

            }
        }
        // Show Crystal Report CRProfit_2023
        private void ShowCRProfit_2023()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "Select Month ,Profit  from Profit_2023  ";
                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                CRProfit_2023 cRProfit_2023 = new CRProfit_2023();
                cRProfit_2023.Database.Tables["Profit_2023"].SetDataSource(dt);
                CRViewer1.ReportSource = null;
                CRViewer1.ReportSource = cRProfit_2023;
            }
        }

    }
}
