namespace AppChatV2
{
    partial class UC_FriendRequest
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
            this.Label_Name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PictureBox_Avatar = new System.Windows.Forms.PictureBox();
            this.Button_Option = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Option)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label_Name.Location = new System.Drawing.Point(68, 14);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(155, 21);
            this.Label_Name.TabIndex = 10;
            this.Label_Name.Text = "bunifuCustomLabel1";
            // 
            // PictureBox_Avatar
            // 
            this.PictureBox_Avatar.InitialImage = null;
            this.PictureBox_Avatar.Location = new System.Drawing.Point(18, 14);
            this.PictureBox_Avatar.Name = "PictureBox_Avatar";
            this.PictureBox_Avatar.Size = new System.Drawing.Size(30, 30);
            this.PictureBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Avatar.TabIndex = 8;
            this.PictureBox_Avatar.TabStop = false;
            // 
            // Button_Option
            // 
            this.Button_Option.BackColor = System.Drawing.Color.White;
            this.Button_Option.Image = global::AppChatV2.Properties.Resources.outline_more_horiz_black_2;
            this.Button_Option.ImageActive = null;
            this.Button_Option.Location = new System.Drawing.Point(245, 14);
            this.Button_Option.Name = "Button_Option";
            this.Button_Option.Size = new System.Drawing.Size(31, 32);
            this.Button_Option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Option.TabIndex = 11;
            this.Button_Option.TabStop = false;
            this.Button_Option.Zoom = 10;
            this.Button_Option.Click += new System.EventHandler(this.Button_Option_Click);
            // 
            // UC_FriendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_Option);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PictureBox_Avatar);
            this.Name = "UC_FriendRequest";
            this.Size = new System.Drawing.Size(280, 61);
            this.Load += new System.EventHandler(this.UC_FriendRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Option)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Name;
        private System.Windows.Forms.PictureBox PictureBox_Avatar;
        private Bunifu.Framework.UI.BunifuImageButton Button_Option;
    }
}
