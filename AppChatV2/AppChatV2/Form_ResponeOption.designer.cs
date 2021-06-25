namespace AppChatV2
{
    partial class Form_ResponeOption
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
            this.Button_Accept = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_Decline = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you agree to be friends?";
            // 
            // Button_Accept
            // 
            this.Button_Accept.BorderColor = System.Drawing.Color.DimGray;
            this.Button_Accept.BorderRadius = 17;
            this.Button_Accept.BorderThickness = 1;
            this.Button_Accept.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_Accept.CheckedState.Parent = this.Button_Accept;
            this.Button_Accept.CustomImages.Parent = this.Button_Accept;
            this.Button_Accept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Accept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Accept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Accept.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Accept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Accept.DisabledState.Parent = this.Button_Accept;
            this.Button_Accept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button_Accept.FillColor2 = System.Drawing.Color.Blue;
            this.Button_Accept.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Button_Accept.ForeColor = System.Drawing.Color.White;
            this.Button_Accept.HoverState.Parent = this.Button_Accept;
            this.Button_Accept.Location = new System.Drawing.Point(29, 60);
            this.Button_Accept.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.ShadowDecoration.Parent = this.Button_Accept;
            this.Button_Accept.Size = new System.Drawing.Size(108, 37);
            this.Button_Accept.TabIndex = 89;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // Button_Decline
            // 
            this.Button_Decline.BorderColor = System.Drawing.Color.DimGray;
            this.Button_Decline.BorderRadius = 17;
            this.Button_Decline.BorderThickness = 1;
            this.Button_Decline.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_Decline.CheckedState.Parent = this.Button_Decline;
            this.Button_Decline.CustomImages.Parent = this.Button_Decline;
            this.Button_Decline.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Decline.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Decline.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Decline.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Decline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Decline.DisabledState.Parent = this.Button_Decline;
            this.Button_Decline.FillColor = System.Drawing.Color.Red;
            this.Button_Decline.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Decline.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Button_Decline.ForeColor = System.Drawing.Color.White;
            this.Button_Decline.HoverState.Parent = this.Button_Decline;
            this.Button_Decline.Location = new System.Drawing.Point(165, 60);
            this.Button_Decline.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Decline.Name = "Button_Decline";
            this.Button_Decline.ShadowDecoration.Parent = this.Button_Decline;
            this.Button_Decline.Size = new System.Drawing.Size(110, 37);
            this.Button_Decline.TabIndex = 88;
            this.Button_Decline.Text = "Decline";
            this.Button_Decline.Click += new System.EventHandler(this.Button_Decline_Click);
            // 
            // Form_ResponeOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(302, 115);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.Button_Decline);
            this.Controls.Add(this.label1);
            this.Name = "Form_ResponeOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn kết bạn";
            this.Load += new System.EventHandler(this.Form_ResponeOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Accept;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Decline;
    }
}