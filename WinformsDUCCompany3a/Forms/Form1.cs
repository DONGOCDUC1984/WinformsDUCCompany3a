using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsDUCCompany3a.Forms;
using WinformsDUCCompany3a.Tools;

namespace WinformsDUCCompany3a
{
    public partial class LoginRegisterForm : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        public LoginRegisterForm()
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
        SqlConnection conn;
        SqlCommand cmd;
        private void LoginRegisterForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(CommonServices.conString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            Clear();
        }

        private void Clear()
        {
            // For Login
            txtUserNameLo.Clear();
            txtUserPasswordLo.Clear();
            // For Register
            txtUserNameRe.Clear();
            txtUserEmailRe.Clear();
            txtUserPasswordRe.Clear();
            txtConfirmUserPasswordRe.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "Select * from Users where UserName ='" + txtUserNameLo.Text.Trim() +
                "' and UserPassword ='" + CommonServices.GetHashedPassword(txtUserPasswordLo.Text.Trim()) + "'";
            var dtbl = new DataTable();
            var sqlDa = new SqlDataAdapter(query, conn);
            sqlDa.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                // The following lines are used to send data from this form to MainForm
                MainForm mainForm = new MainForm();
                mainForm.UserName = dtbl.Rows[0]["UserName"].ToString();
                mainForm.UserEmail = dtbl.Rows[0]["UserEmail"].ToString();
                mainForm.UserRole = dtbl.Rows[0]["UserRole"].ToString();
                this.Hide();
                mainForm.Show();
                CommonServices.ShowPopUpNoti("Successfully logged in");
            }
            else
            {
                MessageBox.Show("Wrong username or wrong password",
                        "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserNameRe.Text == "" || txtUserEmailRe.Text == "" ||
               txtUserPasswordRe.Text == "" || txtConfirmUserPasswordRe.Text == "")
            {
                MessageBox.Show("Please fill all fields",
                    "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtUserPasswordRe.Text != txtConfirmUserPasswordRe.Text)
                {
                    MessageBox.Show("Passwords do not match",
                   "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // For Admin
                    // string Role = "Admin";

                    // For User
                    string UserRole = "User";

                    conn.Open();
                    var cmd = new SqlCommand("UserCreate", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("UserName", txtUserNameRe.Text.Trim());
                    cmd.Parameters.AddWithValue("UserEmail", txtUserEmailRe.Text.Trim());
                    cmd.Parameters.AddWithValue("UserPassword", CommonServices
                        .GetHashedPassword(txtUserPasswordRe.Text.Trim()));
                    cmd.Parameters.AddWithValue("UserRole", UserRole);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    // The following lines are used to send data from this form to MainForm
                    MainForm mainForm = new MainForm();
                    mainForm.UserName = txtUserNameRe.Text.Trim();
                    mainForm.UserEmail = txtUserEmailRe.Text.Trim();
                    mainForm.UserRole = UserRole;
                    this.Hide();
                    mainForm.Show();
                    CommonServices.ShowPopUpNoti("Successfully registered");
                    Clear();
                }
            }
        }
    }
}
