﻿namespace WindowsFormsApp1
{
    partial class frmInteractgroup
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
            this.btnMessagesingle = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // btnMessagesingle
            // 
            this.btnMessagesingle.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnMessagesingle.ButtonImage = null;
            this.btnMessagesingle.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnMessagesingle.ButtonText = "Trò chuyện";
            this.btnMessagesingle.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnMessagesingle.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMessagesingle.CornerRadius = 5;
            this.btnMessagesingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessagesingle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMessagesingle.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnMessagesingle.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMessagesingle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnMessagesingle.Location = new System.Drawing.Point(9, 28);
            this.btnMessagesingle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMessagesingle.Name = "btnMessagesingle";
            this.btnMessagesingle.Size = new System.Drawing.Size(100, 29);
            this.btnMessagesingle.TabIndex = 20;
            this.btnMessagesingle.TextColor = System.Drawing.Color.White;
            this.btnMessagesingle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMessagesingle.Click += new System.EventHandler(this.btnMessagesingle_Click);
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.Crimson;
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "Rời nhóm";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(132, 28);
            this.xuiButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(100, 29);
            this.xuiButton2.TabIndex = 21;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // frmInteractgroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 86);
            this.Controls.Add(this.xuiButton2);
            this.Controls.Add(this.btnMessagesingle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInteractgroup";
            this.Text = "INTERACT_GRP";
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton btnMessagesingle;
        private XanderUI.XUIButton xuiButton2;
    }
}