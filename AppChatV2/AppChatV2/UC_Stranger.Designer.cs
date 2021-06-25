namespace AppChatV2
{
    partial class UC_Stranger
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
            this.Button_AddFriend = new Bunifu.Framework.UI.BunifuImageButton();
            this.PictureBox_Avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label_Name.Location = new System.Drawing.Point(64, 15);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(155, 21);
            this.Label_Name.TabIndex = 6;
            this.Label_Name.Text = "bunifuCustomLabel1";
            // 
            // Button_AddFriend
            // 
            this.Button_AddFriend.BackColor = System.Drawing.Color.Transparent;
            this.Button_AddFriend.Image = global::AppChatV2.Properties.Resources.outline_add_circle_outline_black_2;
            this.Button_AddFriend.ImageActive = null;
            this.Button_AddFriend.Location = new System.Drawing.Point(239, 15);
            this.Button_AddFriend.Name = "Button_AddFriend";
            this.Button_AddFriend.Size = new System.Drawing.Size(29, 29);
            this.Button_AddFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_AddFriend.TabIndex = 7;
            this.Button_AddFriend.TabStop = false;
            this.Button_AddFriend.Zoom = 10;
            this.Button_AddFriend.Click += new System.EventHandler(this.Button_AddFriend_Click);
            // 
            // PictureBox_Avatar
            // 
            this.PictureBox_Avatar.InitialImage = null;
            this.PictureBox_Avatar.Location = new System.Drawing.Point(8, 4);
            this.PictureBox_Avatar.Name = "PictureBox_Avatar";
            this.PictureBox_Avatar.Size = new System.Drawing.Size(50, 50);
            this.PictureBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Avatar.TabIndex = 4;
            this.PictureBox_Avatar.TabStop = false;
            // 
            // UC_Stranger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_AddFriend);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PictureBox_Avatar);
            this.Name = "UC_Stranger";
            this.Size = new System.Drawing.Size(280, 61);
            this.Load += new System.EventHandler(this.UC_Stranger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton Button_AddFriend;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Name;
        private System.Windows.Forms.PictureBox PictureBox_Avatar;
    }
}
