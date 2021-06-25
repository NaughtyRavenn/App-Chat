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
            this.Textbox_Username = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.Linklabel_SignUp = new System.Windows.Forms.LinkLabel();
            this.Button_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Textbox_Password = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Textbox_Username
            // 
            this.Textbox_Username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Textbox_Username.BorderColor = System.Drawing.Color.White;
            this.Textbox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Textbox_Username, "Textbox_Username");
            this.Textbox_Username.ForeColor = System.Drawing.Color.DarkGray;
            this.Textbox_Username.HideSelection = false;
            this.Textbox_Username.Name = "Textbox_Username";
            this.Textbox_Username.Enter += new System.EventHandler(this.Textbox_Username_Enter);
            this.Textbox_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            this.Textbox_Username.Leave += new System.EventHandler(this.Textbox_Username_Leave);
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppChatV2.Properties.Resources.AppImage;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 70;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.Linklabel_SignUp);
            this.bunifuCards1.Controls.Add(this.Button_Login);
            this.bunifuCards1.Controls.Add(this.bunifuCards3);
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.LeftSahddow = false;
            resources.ApplyResources(this.bunifuCards1, "bunifuCards1");
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            // 
            // Linklabel_SignUp
            // 
            resources.ApplyResources(this.Linklabel_SignUp, "Linklabel_SignUp");
            this.Linklabel_SignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Linklabel_SignUp.Name = "Linklabel_SignUp";
            this.Linklabel_SignUp.TabStop = true;
            this.Linklabel_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linklabel_SignUp_LinkClicked);
            // 
            // Button_Login
            // 
            this.Button_Login.Active = false;
            this.Button_Login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Button_Login.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Button_Login.BackColor = System.Drawing.Color.Chartreuse;
            resources.ApplyResources(this.Button_Login, "Button_Login");
            this.Button_Login.BorderRadius = 5;
            this.Button_Login.ButtonText = "LOGIN";
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Login.Iconimage = null;
            this.Button_Login.Iconimage_right = null;
            this.Button_Login.Iconimage_right_Selected = null;
            this.Button_Login.Iconimage_Selected = null;
            this.Button_Login.IconMarginLeft = 0;
            this.Button_Login.IconMarginRight = 0;
            this.Button_Login.IconRightVisible = true;
            this.Button_Login.IconRightZoom = 0D;
            this.Button_Login.IconVisible = true;
            this.Button_Login.IconZoom = 90D;
            this.Button_Login.IsTab = false;
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Normalcolor = System.Drawing.Color.Blue;
            this.Button_Login.OnHovercolor = System.Drawing.Color.Navy;
            this.Button_Login.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Login.selected = false;
            this.Button_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Login.Textcolor = System.Drawing.Color.White;
            this.Button_Login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards3.BorderRadius = 60;
            this.bunifuCards3.BottomSahddow = false;
            this.bunifuCards3.color = System.Drawing.Color.Transparent;
            this.bunifuCards3.Controls.Add(this.pictureBox3);
            this.bunifuCards3.Controls.Add(this.Textbox_Password);
            this.bunifuCards3.LeftSahddow = false;
            resources.ApplyResources(this.bunifuCards3, "bunifuCards3");
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppChatV2.Properties.Resources.Lock;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // Textbox_Password
            // 
            this.Textbox_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Textbox_Password.BorderColor = System.Drawing.Color.White;
            this.Textbox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Textbox_Password, "Textbox_Password");
            this.Textbox_Password.ForeColor = System.Drawing.Color.DarkGray;
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.Tag = "";
            this.Textbox_Password.Enter += new System.EventHandler(this.Textbox_Password_Enter);
            this.Textbox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            this.Textbox_Password.Leave += new System.EventHandler(this.Textbox_Password_Leave);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards2.BorderRadius = 60;
            this.bunifuCards2.BottomSahddow = false;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(this.pictureBox2);
            this.bunifuCards2.Controls.Add(this.Textbox_Username);
            this.bunifuCards2.LeftSahddow = false;
            resources.ApplyResources(this.bunifuCards2, "bunifuCards2");
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppChatV2.Properties.Resources.outline_account_circle_black_24dp1;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 60;
            this.bunifuElipse1.TargetControl = this.Button_Login;
            // 
            // Form_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::AppChatV2.Properties.Resources._40cee2e941086f4a5f251317699ddd85;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Form_Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Login_FormClosed);
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Textbox_Username;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Textbox_Password;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Login;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.LinkLabel Linklabel_SignUp;
    }
}

