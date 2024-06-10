namespace WinformsDUCCompany3a
{
    partial class LoginRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegisterForm));
            this.TCLoginRegister = new MaterialSkin.Controls.MaterialTabControl();
            this.TPLogin = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.txtUserPasswordLo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUserNameLo = new MaterialSkin.Controls.MaterialTextBox();
            this.TPRegister = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmUserPasswordRe = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserEmailRe = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.txtUserPasswordRe = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUserNameRe = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TCLoginRegister.SuspendLayout();
            this.TPLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TPRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TCLoginRegister
            // 
            this.TCLoginRegister.Controls.Add(this.TPLogin);
            this.TCLoginRegister.Controls.Add(this.TPRegister);
            this.TCLoginRegister.Depth = 0;
            this.TCLoginRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCLoginRegister.ImageList = this.imageList1;
            this.TCLoginRegister.Location = new System.Drawing.Point(3, 64);
            this.TCLoginRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCLoginRegister.Multiline = true;
            this.TCLoginRegister.Name = "TCLoginRegister";
            this.TCLoginRegister.SelectedIndex = 0;
            this.TCLoginRegister.Size = new System.Drawing.Size(454, 453);
            this.TCLoginRegister.TabIndex = 0;
            // 
            // TPLogin
            // 
            this.TPLogin.Controls.Add(this.materialLabel1);
            this.TPLogin.Controls.Add(this.pictureBox1);
            this.TPLogin.Controls.Add(this.label2);
            this.TPLogin.Controls.Add(this.label1);
            this.TPLogin.Controls.Add(this.btnLogin);
            this.TPLogin.Controls.Add(this.txtUserPasswordLo);
            this.TPLogin.Controls.Add(this.txtUserNameLo);
            this.TPLogin.ImageKey = "login256.png";
            this.TPLogin.Location = new System.Drawing.Point(4, 31);
            this.TPLogin.Name = "TPLogin";
            this.TPLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TPLogin.Size = new System.Drawing.Size(446, 418);
            this.TPLogin.TabIndex = 0;
            this.TPLogin.Text = "Login";
            this.TPLogin.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(147, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 41);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformsDUCCompany3a.Properties.Resources.login256;
            this.pictureBox1.Location = new System.Drawing.Point(154, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(14, 303);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(64, 36);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserPasswordLo
            // 
            this.txtUserPasswordLo.AnimateReadOnly = false;
            this.txtUserPasswordLo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPasswordLo.Depth = 0;
            this.txtUserPasswordLo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserPasswordLo.LeadingIcon = null;
            this.txtUserPasswordLo.Location = new System.Drawing.Point(137, 188);
            this.txtUserPasswordLo.MaxLength = 50;
            this.txtUserPasswordLo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserPasswordLo.Multiline = false;
            this.txtUserPasswordLo.Name = "txtUserPasswordLo";
            this.txtUserPasswordLo.Password = true;
            this.txtUserPasswordLo.Size = new System.Drawing.Size(221, 50);
            this.txtUserPasswordLo.TabIndex = 12;
            this.txtUserPasswordLo.Text = "";
            this.txtUserPasswordLo.TrailingIcon = null;
            // 
            // txtUserNameLo
            // 
            this.txtUserNameLo.AnimateReadOnly = false;
            this.txtUserNameLo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNameLo.Depth = 0;
            this.txtUserNameLo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserNameLo.LeadingIcon = null;
            this.txtUserNameLo.Location = new System.Drawing.Point(137, 132);
            this.txtUserNameLo.MaxLength = 50;
            this.txtUserNameLo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserNameLo.Multiline = false;
            this.txtUserNameLo.Name = "txtUserNameLo";
            this.txtUserNameLo.Size = new System.Drawing.Size(221, 50);
            this.txtUserNameLo.TabIndex = 11;
            this.txtUserNameLo.Text = "";
            this.txtUserNameLo.TrailingIcon = null;
            // 
            // TPRegister
            // 
            this.TPRegister.Controls.Add(this.materialLabel2);
            this.TPRegister.Controls.Add(this.label6);
            this.TPRegister.Controls.Add(this.txtConfirmUserPasswordRe);
            this.TPRegister.Controls.Add(this.label5);
            this.TPRegister.Controls.Add(this.txtUserEmailRe);
            this.TPRegister.Controls.Add(this.label3);
            this.TPRegister.Controls.Add(this.label4);
            this.TPRegister.Controls.Add(this.btnRegister);
            this.TPRegister.Controls.Add(this.txtUserPasswordRe);
            this.TPRegister.Controls.Add(this.txtUserNameRe);
            this.TPRegister.Controls.Add(this.pictureBox2);
            this.TPRegister.ImageKey = "user256.png";
            this.TPRegister.Location = new System.Drawing.Point(4, 31);
            this.TPRegister.Name = "TPRegister";
            this.TPRegister.Padding = new System.Windows.Forms.Padding(3);
            this.TPRegister.Size = new System.Drawing.Size(446, 418);
            this.TPRegister.TabIndex = 1;
            this.TPRegister.Text = "Register";
            this.TPRegister.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(142, 12);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(126, 41);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Register";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Confirm Password";
            // 
            // txtConfirmUserPasswordRe
            // 
            this.txtConfirmUserPasswordRe.AnimateReadOnly = false;
            this.txtConfirmUserPasswordRe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmUserPasswordRe.Depth = 0;
            this.txtConfirmUserPasswordRe.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmUserPasswordRe.LeadingIcon = null;
            this.txtConfirmUserPasswordRe.Location = new System.Drawing.Point(149, 275);
            this.txtConfirmUserPasswordRe.MaxLength = 50;
            this.txtConfirmUserPasswordRe.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirmUserPasswordRe.Multiline = false;
            this.txtConfirmUserPasswordRe.Name = "txtConfirmUserPasswordRe";
            this.txtConfirmUserPasswordRe.Password = true;
            this.txtConfirmUserPasswordRe.Size = new System.Drawing.Size(221, 50);
            this.txtConfirmUserPasswordRe.TabIndex = 29;
            this.txtConfirmUserPasswordRe.Text = "";
            this.txtConfirmUserPasswordRe.TrailingIcon = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Email";
            // 
            // txtUserEmailRe
            // 
            this.txtUserEmailRe.AnimateReadOnly = false;
            this.txtUserEmailRe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserEmailRe.Depth = 0;
            this.txtUserEmailRe.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserEmailRe.LeadingIcon = null;
            this.txtUserEmailRe.Location = new System.Drawing.Point(149, 164);
            this.txtUserEmailRe.MaxLength = 50;
            this.txtUserEmailRe.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserEmailRe.Multiline = false;
            this.txtUserEmailRe.Name = "txtUserEmailRe";
            this.txtUserEmailRe.Size = new System.Drawing.Size(221, 50);
            this.txtUserEmailRe.TabIndex = 27;
            this.txtUserEmailRe.Text = "";
            this.txtUserEmailRe.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegister.Depth = 0;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(20, 349);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(89, 36);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Register";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtUserPasswordRe
            // 
            this.txtUserPasswordRe.AnimateReadOnly = false;
            this.txtUserPasswordRe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPasswordRe.Depth = 0;
            this.txtUserPasswordRe.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserPasswordRe.LeadingIcon = null;
            this.txtUserPasswordRe.Location = new System.Drawing.Point(149, 219);
            this.txtUserPasswordRe.MaxLength = 50;
            this.txtUserPasswordRe.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserPasswordRe.Multiline = false;
            this.txtUserPasswordRe.Name = "txtUserPasswordRe";
            this.txtUserPasswordRe.Password = true;
            this.txtUserPasswordRe.Size = new System.Drawing.Size(221, 50);
            this.txtUserPasswordRe.TabIndex = 22;
            this.txtUserPasswordRe.Text = "";
            this.txtUserPasswordRe.TrailingIcon = null;
            // 
            // txtUserNameRe
            // 
            this.txtUserNameRe.AnimateReadOnly = false;
            this.txtUserNameRe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNameRe.Depth = 0;
            this.txtUserNameRe.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserNameRe.LeadingIcon = null;
            this.txtUserNameRe.Location = new System.Drawing.Point(148, 108);
            this.txtUserNameRe.MaxLength = 50;
            this.txtUserNameRe.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserNameRe.Multiline = false;
            this.txtUserNameRe.Name = "txtUserNameRe";
            this.txtUserNameRe.Size = new System.Drawing.Size(221, 50);
            this.txtUserNameRe.TabIndex = 21;
            this.txtUserNameRe.Text = "";
            this.txtUserNameRe.TrailingIcon = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinformsDUCCompany3a.Properties.Resources.user256;
            this.pictureBox2.Location = new System.Drawing.Point(166, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "login256.png");
            this.imageList1.Images.SetKeyName(1, "user256.png");
            // 
            // LoginRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 520);
            this.Controls.Add(this.TCLoginRegister);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TCLoginRegister;
            this.Name = "LoginRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUC COMPANY";
            this.Load += new System.EventHandler(this.LoginRegisterForm_Load);
            this.TCLoginRegister.ResumeLayout(false);
            this.TPLogin.ResumeLayout(false);
            this.TPLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TPRegister.ResumeLayout(false);
            this.TPRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TCLoginRegister;
        private System.Windows.Forms.TabPage TPLogin;
        private System.Windows.Forms.TabPage TPRegister;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtConfirmUserPasswordRe;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtUserEmailRe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialTextBox txtUserPasswordRe;
        private MaterialSkin.Controls.MaterialTextBox txtUserNameRe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialTextBox txtUserPasswordLo;
        private MaterialSkin.Controls.MaterialTextBox txtUserNameLo;
    }
}

