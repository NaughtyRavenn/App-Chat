namespace AppChatV2
{
    partial class Form_VerifyFriend
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
            this.label1 = new System.Windows.Forms.Label();
            this.Button_No = new XanderUI.XUIButton();
            this.Button_Yes = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn có đồng ý kết bạn không?";
            // 
            // Button_No
            // 
            this.Button_No.BackgroundColor = System.Drawing.Color.Crimson;
            this.Button_No.ButtonImage = null;
            this.Button_No.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.Button_No.ButtonText = "No";
            this.Button_No.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.Button_No.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.Button_No.CornerRadius = 5;
            this.Button_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Button_No.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Button_No.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Button_No.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.Button_No.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.Button_No.Location = new System.Drawing.Point(152, 55);
            this.Button_No.Margin = new System.Windows.Forms.Padding(2);
            this.Button_No.Name = "Button_No";
            this.Button_No.Size = new System.Drawing.Size(100, 32);
            this.Button_No.TabIndex = 23;
            this.Button_No.TextColor = System.Drawing.Color.White;
            this.Button_No.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // Button_Yes
            // 
            this.Button_Yes.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.Button_Yes.ButtonImage = null;
            this.Button_Yes.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.Button_Yes.ButtonText = "Yes";
            this.Button_Yes.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.Button_Yes.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.Button_Yes.CornerRadius = 5;
            this.Button_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Button_Yes.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Button_Yes.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Button_Yes.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.Button_Yes.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.Button_Yes.Location = new System.Drawing.Point(29, 55);
            this.Button_Yes.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Yes.Name = "Button_Yes";
            this.Button_Yes.Size = new System.Drawing.Size(100, 32);
            this.Button_Yes.TabIndex = 22;
            this.Button_Yes.TextColor = System.Drawing.Color.White;
            this.Button_Yes.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.Button_Yes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // Form_VerifyFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 112);
            this.Controls.Add(this.Button_No);
            this.Controls.Add(this.Button_Yes);
            this.Controls.Add(this.label1);
            this.Name = "Form_VerifyFriend";
            this.Text = "VERI_FR";
            this.Load += new System.EventHandler(this.frmVerifriend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton Button_No;
        private XanderUI.XUIButton Button_Yes;
    }
}