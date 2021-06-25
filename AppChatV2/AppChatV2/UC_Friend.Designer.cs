﻿namespace AppChatV2
{
    partial class UC_Friend
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
            this.components = new System.ComponentModel.Container();
            this.Label_Name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Button_Option = new Bunifu.Framework.UI.BunifuImageButton();
            this.PictureBox_Avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label_Name.Location = new System.Drawing.Point(80, 33);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(155, 21);
            this.Label_Name.TabIndex = 2;
            this.Label_Name.Text = "bunifuCustomLabel1";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10000;
            this.bunifuElipse1.TargetControl = this.Button_Option;
            // 
            // Button_Option
            // 
            this.Button_Option.BackColor = System.Drawing.Color.White;
            this.Button_Option.Image = global::AppChatV2.Properties.Resources.outline_more_horiz_black_2;
            this.Button_Option.ImageActive = null;
            this.Button_Option.Location = new System.Drawing.Point(268, 25);
            this.Button_Option.Name = "Button_Option";
            this.Button_Option.Size = new System.Drawing.Size(40, 40);
            this.Button_Option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Option.TabIndex = 3;
            this.Button_Option.TabStop = false;
            this.Button_Option.Zoom = 10;
            // 
            // PictureBox_Avatar
            // 
            this.PictureBox_Avatar.InitialImage = null;
            this.PictureBox_Avatar.Location = new System.Drawing.Point(24, 15);
            this.PictureBox_Avatar.Name = "PictureBox_Avatar";
            this.PictureBox_Avatar.Size = new System.Drawing.Size(50, 50);
            this.PictureBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Avatar.TabIndex = 0;
            this.PictureBox_Avatar.TabStop = false;
            // 
            // UC_Friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Button_Option);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PictureBox_Avatar);
            this.Name = "UC_Friend";
            this.Size = new System.Drawing.Size(325, 100);
            this.Load += new System.EventHandler(this.Form_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Button_Option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Avatar;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Name;
        private Bunifu.Framework.UI.BunifuImageButton Button_Option;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}