﻿namespace AppChatV2
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
            this.Button_Option = new Bunifu.Framework.UI.BunifuImageButton();
            this.Label_Name = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox11 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Option
            // 
            this.Button_Option.Image = global::AppChatV2.Properties.Resources.outline_pending_black_2;
            this.Button_Option.ImageActive = null;
            this.Button_Option.Location = new System.Drawing.Point(318, 30);
            this.Button_Option.Name = "Button_Option";
            this.Button_Option.Size = new System.Drawing.Size(50, 50);
            this.Button_Option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Option.TabIndex = 28;
            this.Button_Option.TabStop = false;
            this.Button_Option.Zoom = 10;
            this.Button_Option.Click += new System.EventHandler(this.Button_Option_Click);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.Label_Name.ForeColor = System.Drawing.Color.Black;
            this.Label_Name.Location = new System.Drawing.Point(109, 37);
            this.Label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(149, 32);
            this.Label_Name.TabIndex = 25;
            this.Label_Name.Text = "Username";
            // 
            // guna2CirclePictureBox11
            // 
            this.guna2CirclePictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2CirclePictureBox11.ImageRotate = 0F;
            this.guna2CirclePictureBox11.Location = new System.Drawing.Point(13, 16);
            this.guna2CirclePictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox11.Name = "guna2CirclePictureBox11";
            this.guna2CirclePictureBox11.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox11.ShadowDecoration.Parent = this.guna2CirclePictureBox11;
            this.guna2CirclePictureBox11.Size = new System.Drawing.Size(80, 80);
            this.guna2CirclePictureBox11.TabIndex = 26;
            this.guna2CirclePictureBox11.TabStop = false;
            // 
            // UC_FriendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Button_Option);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.guna2CirclePictureBox11);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_FriendRequest";
            this.Size = new System.Drawing.Size(384, 111);
            this.Load += new System.EventHandler(this.UC_FriendRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Button_Option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton Button_Option;
        private System.Windows.Forms.Label Label_Name;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox11;
    }
}
