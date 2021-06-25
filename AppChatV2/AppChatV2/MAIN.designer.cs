namespace AppChatV2
{
    partial class Form_Main
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
            this.btnEditprofile = new XanderUI.XUIButton();
            this.btnLogout = new XanderUI.XUIButton();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.btnAddfriend = new XanderUI.XUIButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.xuiFlatTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditprofile
            // 
            this.btnEditprofile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditprofile.ButtonImage = null;
            this.btnEditprofile.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEditprofile.ButtonText = "Chỉnh sửa";
            this.btnEditprofile.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnEditprofile.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEditprofile.CornerRadius = 5;
            this.btnEditprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnEditprofile.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEditprofile.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEditprofile.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEditprofile.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEditprofile.Location = new System.Drawing.Point(175, 83);
            this.btnEditprofile.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditprofile.Name = "btnEditprofile";
            this.btnEditprofile.Size = new System.Drawing.Size(112, 27);
            this.btnEditprofile.TabIndex = 32;
            this.btnEditprofile.TextColor = System.Drawing.Color.White;
            this.btnEditprofile.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEditprofile.Click += new System.EventHandler(this.btnEditprofile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogout.ButtonImage = null;
            this.btnLogout.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLogout.ButtonText = "Đăng xuất";
            this.btnLogout.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLogout.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.CornerRadius = 5;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogout.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnLogout.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLogout.Location = new System.Drawing.Point(175, 114);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 27);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(170, 11);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 26);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "User Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.xuiButton1);
            this.tabPage2.Controls.Add(this.vScrollBar2);
            this.tabPage2.Controls.Add(this.btnAddfriend);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(483, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách bạn";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Thêm bạn mới";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(80, 50);
            this.xuiButton1.Margin = new System.Windows.Forms.Padding(2);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(154, 33);
            this.xuiButton1.TabIndex = 53;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.btnAddfriend_Click);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(437, 3);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(24, 400);
            this.vScrollBar2.TabIndex = 37;
            // 
            // btnAddfriend
            // 
            this.btnAddfriend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddfriend.ButtonImage = null;
            this.btnAddfriend.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAddfriend.ButtonText = "Tìm";
            this.btnAddfriend.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAddfriend.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddfriend.CornerRadius = 5;
            this.btnAddfriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddfriend.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddfriend.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAddfriend.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddfriend.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddfriend.Location = new System.Drawing.Point(260, 3);
            this.btnAddfriend.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddfriend.Name = "btnAddfriend";
            this.btnAddfriend.Size = new System.Drawing.Size(46, 28);
            this.btnAddfriend.TabIndex = 38;
            this.btnAddfriend.TextColor = System.Drawing.Color.White;
            this.btnAddfriend.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox3.Location = new System.Drawing.Point(4, 3);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 29);
            this.textBox3.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.xuiButton3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 8);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(483, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "";
            this.tabPage1.Text = "Gần đây";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(437, 448);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.xuiButton3.ButtonImage = null;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "Tìm";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(319, 5);
            this.xuiButton3.Margin = new System.Windows.Forms.Padding(2);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(46, 28);
            this.xuiButton3.TabIndex = 21;
            this.xuiButton3.TextColor = System.Drawing.Color.White;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 29);
            this.textBox1.TabIndex = 0;
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.Blue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.Blue;
            this.xuiFlatTab1.Controls.Add(this.tabPage1);
            this.xuiFlatTab1.Controls.Add(this.tabPage2);
            this.xuiFlatTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.xuiFlatTab1.HeaderBackgroundColor = System.Drawing.Color.AliceBlue;
            this.xuiFlatTab1.InActiveHeaderColor = System.Drawing.Color.Blue;
            this.xuiFlatTab1.InActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.ItemSize = new System.Drawing.Size(20, 20);
            this.xuiFlatTab1.Location = new System.Drawing.Point(0, 145);
            this.xuiFlatTab1.Margin = new System.Windows.Forms.Padding(2);
            this.xuiFlatTab1.Name = "xuiFlatTab1";
            this.xuiFlatTab1.Padding = new System.Drawing.Point(40, 60);
            this.xuiFlatTab1.PageColor = System.Drawing.Color.AliceBlue;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.ShowBorder = true;
            this.xuiFlatTab1.Size = new System.Drawing.Size(491, 535);
            this.xuiFlatTab1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 1200000;
            this.bunifuElipse1.TargetControl = this.pictureBox1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox1.Image = global::AppChatV2.Properties.Resources._3162e85a2ff1d1af88e0;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 691);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.xuiFlatTab1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditprofile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Main";
            this.Text = "TRANG CHỦ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.xuiFlatTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIButton btnEditprofile;
        private XanderUI.XUIButton btnLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabPage2;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private XanderUI.XUIButton btnAddfriend;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tabPage1;
        private XanderUI.XUIButton xuiButton3;
        private System.Windows.Forms.TextBox textBox1;
        private XanderUI.XUIFlatTab xuiFlatTab1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}