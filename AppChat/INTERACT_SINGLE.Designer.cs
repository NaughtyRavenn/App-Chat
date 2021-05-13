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
            this.xuiButton2 = new XanderUI.XUIButton();
            this.btnMessagesingle = new XanderUI.XUIButton();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lstvMessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.Crimson;
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "Xóa bạn";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(136, 32);
            this.xuiButton2.Margin = new System.Windows.Forms.Padding(2);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(100, 29);
            this.xuiButton2.TabIndex = 23;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnMessagesingle.Location = new System.Drawing.Point(13, 32);
            this.btnMessagesingle.Margin = new System.Windows.Forms.Padding(2);
            this.btnMessagesingle.Name = "btnMessagesingle";
            this.btnMessagesingle.Size = new System.Drawing.Size(100, 29);
            this.btnMessagesingle.TabIndex = 22;
            this.btnMessagesingle.TextColor = System.Drawing.Color.White;
            this.btnMessagesingle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMessagesingle.Click += new System.EventHandler(this.btnMessagesingle_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(66, 175);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 20);
            this.txtMessage.TabIndex = 24;
            // 
            // lstvMessage
            // 
            this.lstvMessage.HideSelection = false;
            this.lstvMessage.Location = new System.Drawing.Point(45, 242);
            this.lstvMessage.Name = "lstvMessage";
            this.lstvMessage.Size = new System.Drawing.Size(121, 97);
            this.lstvMessage.TabIndex = 25;
            this.lstvMessage.UseCompatibleStateImageBehavior = false;
            // 
            // frmInteractsingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 494);
            this.Controls.Add(this.lstvMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.xuiButton2);
            this.Controls.Add(this.btnMessagesingle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInteractsingle";
            this.Text = "INTERACT_SINGLE";
            this.Load += new System.EventHandler(this.frmInteractsingle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton btnMessagesingle;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListView lstvMessage;
    }
}