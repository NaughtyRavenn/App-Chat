namespace AppChatV2
{
    partial class Form_VerifySignout
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
            this.Button_Yes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_No = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Yes
            // 
            this.Button_Yes.BorderColor = System.Drawing.Color.DimGray;
            this.Button_Yes.BorderRadius = 17;
            this.Button_Yes.BorderThickness = 1;
            this.Button_Yes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_Yes.CheckedState.Parent = this.Button_Yes;
            this.Button_Yes.CustomImages.Parent = this.Button_Yes;
            this.Button_Yes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Yes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Yes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Yes.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Yes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Yes.DisabledState.Parent = this.Button_Yes;
            this.Button_Yes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button_Yes.FillColor2 = System.Drawing.Color.Blue;
            this.Button_Yes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Button_Yes.ForeColor = System.Drawing.Color.White;
            this.Button_Yes.HoverState.Parent = this.Button_Yes;
            this.Button_Yes.Location = new System.Drawing.Point(29, 60);
            this.Button_Yes.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Yes.Name = "Button_Yes";
            this.Button_Yes.ShadowDecoration.Parent = this.Button_Yes;
            this.Button_Yes.Size = new System.Drawing.Size(108, 37);
            this.Button_Yes.TabIndex = 92;
            this.Button_Yes.Text = "Yes";
            this.Button_Yes.Click += new System.EventHandler(this.Button_Yes_Click);
            // 
            // Button_No
            // 
            this.Button_No.BorderColor = System.Drawing.Color.DimGray;
            this.Button_No.BorderRadius = 17;
            this.Button_No.BorderThickness = 1;
            this.Button_No.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_No.CheckedState.Parent = this.Button_No;
            this.Button_No.CustomImages.Parent = this.Button_No;
            this.Button_No.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_No.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_No.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_No.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_No.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_No.DisabledState.Parent = this.Button_No;
            this.Button_No.FillColor = System.Drawing.Color.Red;
            this.Button_No.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_No.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Button_No.ForeColor = System.Drawing.Color.White;
            this.Button_No.HoverState.Parent = this.Button_No;
            this.Button_No.Location = new System.Drawing.Point(165, 60);
            this.Button_No.Margin = new System.Windows.Forms.Padding(2);
            this.Button_No.Name = "Button_No";
            this.Button_No.ShadowDecoration.Parent = this.Button_No;
            this.Button_No.Size = new System.Drawing.Size(110, 37);
            this.Button_No.TabIndex = 91;
            this.Button_No.Text = "No";
            this.Button_No.Click += new System.EventHandler(this.Button_No_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 90;
            this.label1.Text = "Do you want to sign out?";
            // 
            // Form_VerifySignout
            // 
            this.AcceptButton = this.Button_Yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(302, 115);
            this.Controls.Add(this.Button_Yes);
            this.Controls.Add(this.Button_No);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_VerifySignout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng xuất";
            this.Load += new System.EventHandler(this.frmVerilogout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton Button_Yes;
        private Guna.UI2.WinForms.Guna2GradientButton Button_No;
        private System.Windows.Forms.Label label1;
    }
}