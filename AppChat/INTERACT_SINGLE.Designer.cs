namespace WindowsFormsApp1
{
    partial class frmInteractsingle
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
            this.btnDeletefriend = new XanderUI.XUIButton();
            this.btnMessagesingle = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // btnDeletefriend
            // 
            this.btnDeletefriend.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnDeletefriend.ButtonImage = null;
            this.btnDeletefriend.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDeletefriend.ButtonText = "Xóa bạn";
            this.btnDeletefriend.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnDeletefriend.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDeletefriend.CornerRadius = 5;
            this.btnDeletefriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeletefriend.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeletefriend.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDeletefriend.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDeletefriend.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDeletefriend.Location = new System.Drawing.Point(176, 29);
            this.btnDeletefriend.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletefriend.Name = "btnDeletefriend";
            this.btnDeletefriend.Size = new System.Drawing.Size(122, 28);
            this.btnDeletefriend.TabIndex = 23;
            this.btnDeletefriend.TextColor = System.Drawing.Color.White;
            this.btnDeletefriend.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeletefriend.Click += new System.EventHandler(this.btnDeletefriend_Click);
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
            this.btnMessagesingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnMessagesingle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMessagesingle.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnMessagesingle.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMessagesingle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnMessagesingle.Location = new System.Drawing.Point(16, 29);
            this.btnMessagesingle.Margin = new System.Windows.Forms.Padding(2);
            this.btnMessagesingle.Name = "btnMessagesingle";
            this.btnMessagesingle.Size = new System.Drawing.Size(122, 28);
            this.btnMessagesingle.TabIndex = 22;
            this.btnMessagesingle.TextColor = System.Drawing.Color.White;
            this.btnMessagesingle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMessagesingle.Click += new System.EventHandler(this.btnMessagesingle_Click);
            // 
            // frmInteractsingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 103);
            this.Controls.Add(this.btnDeletefriend);
            this.Controls.Add(this.btnMessagesingle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInteractsingle";
            this.Text = "INTERACT_SINGLE";
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton btnDeletefriend;
        private XanderUI.XUIButton btnMessagesingle;
    }
}