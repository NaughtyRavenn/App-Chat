namespace WindowsFormsApp1
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.llblForgetpassword = new System.Windows.Forms.LinkLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xuiCard1 = new XanderUI.XUICard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSignup = new XanderUI.XUIButton();
            this.btnLogin = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Name = "label10";
            // 
            // llblForgetpassword
            // 
            resources.ApplyResources(this.llblForgetpassword, "llblForgetpassword");
            this.llblForgetpassword.Name = "llblForgetpassword";
            this.llblForgetpassword.TabStop = true;
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.f343cba34c364b5b95b523f776a733e2;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // xuiCard1
            // 
            this.xuiCard1.BackColor = System.Drawing.Color.Transparent;
            this.xuiCard1.Color1 = System.Drawing.Color.Azure;
            this.xuiCard1.Color2 = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.xuiCard1, "xuiCard1");
            this.xuiCard1.ForeColor = System.Drawing.Color.White;
            this.xuiCard1.Name = "xuiCard1";
            this.xuiCard1.Text1 = "";
            this.xuiCard1.Text2 = "";
            this.xuiCard1.Text3 = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnSignup
            // 
            this.btnSignup.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnSignup.ButtonImage = null;
            this.btnSignup.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSignup.ButtonText = "Tạo tài khoản mới";
            this.btnSignup.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSignup.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSignup.CornerRadius = 5;
            resources.ApplyResources(this.btnSignup, "btnSignup");
            this.btnSignup.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSignup.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSignup.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSignup.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.TextColor = System.Drawing.Color.White;
            this.btnSignup.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundColor = System.Drawing.Color.Blue;
            this.btnLogin.ButtonImage = null;
            this.btnLogin.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLogin.ButtonText = "Đăng nhập";
            this.btnLogin.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLogin.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.CornerRadius = 5;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnLogin.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.llblForgetpassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.xuiCard1);
            this.Name = "frmLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel llblForgetpassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUICard xuiCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private XanderUI.XUIButton btnSignup;
        private XanderUI.XUIButton btnLogin;
    }
}

