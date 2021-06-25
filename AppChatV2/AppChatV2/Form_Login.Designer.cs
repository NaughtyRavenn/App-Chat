namespace AppChatV2
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Signup = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Login = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Button_Signup);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Button_Login);
            this.panel2.Controls.Add(this.TextBox_Password);
            this.panel2.Controls.Add(this.TextBox_Username);
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Location = new System.Drawing.Point(31, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 406);
            this.panel2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(420, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "Log in";
            // 
            // Button_Signup
            // 
            this.Button_Signup.BorderColor = System.Drawing.Color.DimGray;
            this.Button_Signup.BorderRadius = 15;
            this.Button_Signup.BorderThickness = 1;
            this.Button_Signup.CheckedState.Parent = this.Button_Signup;
            this.Button_Signup.CustomImages.Parent = this.Button_Signup;
            this.Button_Signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Signup.DisabledState.Parent = this.Button_Signup;
            this.Button_Signup.FillColor = System.Drawing.Color.Lime;
            this.Button_Signup.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Button_Signup.ForeColor = System.Drawing.Color.White;
            this.Button_Signup.HoverState.Parent = this.Button_Signup;
            this.Button_Signup.Location = new System.Drawing.Point(408, 310);
            this.Button_Signup.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Signup.Name = "Button_Signup";
            this.Button_Signup.ShadowDecoration.Parent = this.Button_Signup;
            this.Button_Signup.Size = new System.Drawing.Size(165, 29);
            this.Button_Signup.TabIndex = 4;
            this.Button_Signup.Text = "Create account";
            this.Button_Signup.Click += new System.EventHandler(this.Button_Signup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(283, 304);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 2);
            this.panel1.TabIndex = 20;
            // 
            // Button_Login
            // 
            this.Button_Login.BorderColor = System.Drawing.Color.DimGray;
            this.Button_Login.BorderRadius = 20;
            this.Button_Login.BorderThickness = 1;
            this.Button_Login.CheckedState.Parent = this.Button_Login;
            this.Button_Login.CustomImages.Parent = this.Button_Login;
            this.Button_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Login.DisabledState.Parent = this.Button_Login;
            this.Button_Login.FillColor = System.Drawing.Color.Blue;
            this.Button_Login.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.HoverState.Parent = this.Button_Login;
            this.Button_Login.Location = new System.Drawing.Point(395, 258);
            this.Button_Login.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.ShadowDecoration.Parent = this.Button_Login;
            this.Button_Login.Size = new System.Drawing.Size(195, 42);
            this.Button_Login.TabIndex = 3;
            this.Button_Login.Text = "Login";
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.White;
            this.TextBox_Password.BorderColor = System.Drawing.Color.DimGray;
            this.TextBox_Password.BorderRadius = 15;
            this.TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Password.DefaultText = "";
            this.TextBox_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Password.DisabledState.Parent = this.TextBox_Password;
            this.TextBox_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Password.FillColor = System.Drawing.Color.Gainsboro;
            this.TextBox_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Password.FocusedState.Parent = this.TextBox_Password;
            this.TextBox_Password.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.TextBox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Password.HoverState.Parent = this.TextBox_Password;
            this.TextBox_Password.Location = new System.Drawing.Point(365, 177);
            this.TextBox_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '\0';
            this.TextBox_Password.PlaceholderText = "Password";
            this.TextBox_Password.SelectedText = "";
            this.TextBox_Password.ShadowDecoration.Parent = this.TextBox_Password;
            this.TextBox_Password.Size = new System.Drawing.Size(248, 44);
            this.TextBox_Password.TabIndex = 2;
            this.TextBox_Password.TextOffset = new System.Drawing.Point(2, -2);
            this.TextBox_Password.UseSystemPasswordChar = true;
            this.TextBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.White;
            this.TextBox_Username.BorderColor = System.Drawing.Color.DimGray;
            this.TextBox_Username.BorderRadius = 15;
            this.TextBox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Username.DefaultText = "";
            this.TextBox_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Username.DisabledState.Parent = this.TextBox_Username;
            this.TextBox_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Username.FillColor = System.Drawing.Color.Gainsboro;
            this.TextBox_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Username.FocusedState.Parent = this.TextBox_Username;
            this.TextBox_Username.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.TextBox_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Username.HoverState.Parent = this.TextBox_Username;
            this.TextBox_Username.Location = new System.Drawing.Point(365, 114);
            this.TextBox_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.PasswordChar = '\0';
            this.TextBox_Username.PlaceholderText = "Username";
            this.TextBox_Username.SelectedText = "";
            this.TextBox_Username.ShadowDecoration.Parent = this.TextBox_Username;
            this.TextBox_Username.Size = new System.Drawing.Size(248, 44);
            this.TextBox_Username.TabIndex = 1;
            this.TextBox_Username.TextOffset = new System.Drawing.Point(2, -2);
            this.TextBox_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.ErrorImage")));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(40, 26);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(299, 361);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AppChatV2.Properties.Resources._40cee2e941086f4a5f251317699ddd85;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 480);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Login_FormClosed);
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Button_Signup;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Button_Login;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Password;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Username;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}