namespace WindowsFormsApp1
{
    partial class frmVerilogout
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
            this.btnNo = new XanderUI.XUIButton();
            this.btnYes = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(1, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn có muốn đăng xuất không ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnNo.ButtonImage = null;
            this.btnNo.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnNo.ButtonText = "No";
            this.btnNo.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnNo.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnNo.CornerRadius = 5;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnNo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnNo.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnNo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNo.Location = new System.Drawing.Point(152, 55);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 32);
            this.btnNo.TabIndex = 25;
            this.btnNo.TextColor = System.Drawing.Color.White;
            this.btnNo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
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
            this.btnYes.TabIndex = 24;
            this.btnYes.TextColor = System.Drawing.Color.White;
            this.btnYes.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // frmVerilogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(286, 112);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVerilogout";
            this.Text = "VERIFY_LOGOUT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnNo;
        private XanderUI.XUIButton btnYes;
    }
}