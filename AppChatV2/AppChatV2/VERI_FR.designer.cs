namespace AppChatV2
{
    partial class frmVerifriend
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
            this.xuiButton2 = new XanderUI.XUIButton();
            this.btnYes = new XanderUI.XUIButton();
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
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.Crimson;
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "No";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(152, 55);
            this.xuiButton2.Margin = new System.Windows.Forms.Padding(2);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(100, 32);
            this.xuiButton2.TabIndex = 23;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnYes
            // 
            this.btnYes.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnYes.ButtonImage = null;
            this.btnYes.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnYes.ButtonText = "Yes";
            this.btnYes.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnYes.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnYes.CornerRadius = 5;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnYes.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnYes.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnYes.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnYes.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnYes.Location = new System.Drawing.Point(29, 55);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 32);
            this.btnYes.TabIndex = 22;
            this.btnYes.TextColor = System.Drawing.Color.White;
            this.btnYes.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // frmVerifriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 112);
            this.Controls.Add(this.xuiButton2);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.Name = "frmVerifriend";
            this.Text = "VERI_FR";
            this.Load += new System.EventHandler(this.frmVerifriend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton btnYes;
    }
}