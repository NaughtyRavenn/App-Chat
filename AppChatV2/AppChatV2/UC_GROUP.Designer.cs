namespace AppChatV2
{
    partial class UC_Group
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Name = new System.Windows.Forms.Label();
            this.PictureBox_Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Notice_Message = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.Black;
            this.Label_Name.Location = new System.Drawing.Point(99, 31);
            this.Label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(119, 25);
            this.Label_Name.TabIndex = 28;
            this.Label_Name.Text = "Groupname";
            // 
            // PictureBox_Avatar
            // 
            this.PictureBox_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Avatar.ImageRotate = 0F;
            this.PictureBox_Avatar.InitialImage = null;
            this.PictureBox_Avatar.Location = new System.Drawing.Point(14, 17);
            this.PictureBox_Avatar.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox_Avatar.Name = "PictureBox_Avatar";
            this.PictureBox_Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBox_Avatar.ShadowDecoration.Parent = this.PictureBox_Avatar;
            this.PictureBox_Avatar.Size = new System.Drawing.Size(70, 70);
            this.PictureBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Avatar.TabIndex = 29;
            this.PictureBox_Avatar.TabStop = false;
            // 
            // Notice_Message
            // 
            this.Notice_Message.CheckedState.Parent = this.Notice_Message;
            this.Notice_Message.CustomImages.Parent = this.Notice_Message;
            this.Notice_Message.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Notice_Message.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Notice_Message.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Notice_Message.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Notice_Message.DisabledState.Parent = this.Notice_Message;
            this.Notice_Message.FillColor = System.Drawing.Color.Red;
            this.Notice_Message.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Notice_Message.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Notice_Message.ForeColor = System.Drawing.Color.White;
            this.Notice_Message.HoverState.Parent = this.Notice_Message;
            this.Notice_Message.Location = new System.Drawing.Point(240, 66);
            this.Notice_Message.Name = "Notice_Message";
            this.Notice_Message.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Notice_Message.ShadowDecoration.Parent = this.Notice_Message;
            this.Notice_Message.Size = new System.Drawing.Size(20, 20);
            this.Notice_Message.TabIndex = 31;
            this.Notice_Message.Visible = false;
            // 
            // UC_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Notice_Message);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PictureBox_Avatar);
            this.Name = "UC_Group";
            this.Size = new System.Drawing.Size(328, 104);
            this.Load += new System.EventHandler(this.UC_Group_Load);
            this.Click += new System.EventHandler(this.UC_Group_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Name;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBox_Avatar;
        private Guna.UI2.WinForms.Guna2CircleButton Notice_Message;
    }
}
