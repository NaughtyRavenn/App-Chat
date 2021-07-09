namespace AppChatV2
{
    partial class Form_InteractSingle
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
            this.Button_Unfriend = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_Profile = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // Button_Unfriend
            // 
            this.Button_Unfriend.BorderColor = System.Drawing.Color.DimGray;
            this.Button_Unfriend.BorderRadius = 17;
            this.Button_Unfriend.BorderThickness = 1;
            this.Button_Unfriend.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_Unfriend.CheckedState.Parent = this.Button_Unfriend;
            this.Button_Unfriend.CustomImages.Parent = this.Button_Unfriend;
            this.Button_Unfriend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Unfriend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Unfriend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Unfriend.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Unfriend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Unfriend.DisabledState.Parent = this.Button_Unfriend;
            this.Button_Unfriend.FillColor = System.Drawing.Color.Red;
            this.Button_Unfriend.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Unfriend.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Button_Unfriend.ForeColor = System.Drawing.Color.White;
            this.Button_Unfriend.HoverState.Parent = this.Button_Unfriend;
            this.Button_Unfriend.Location = new System.Drawing.Point(168, 28);
            this.Button_Unfriend.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Unfriend.Name = "Button_Unfriend";
            this.Button_Unfriend.ShadowDecoration.Parent = this.Button_Unfriend;
            this.Button_Unfriend.Size = new System.Drawing.Size(110, 37);
            this.Button_Unfriend.TabIndex = 88;
            this.Button_Unfriend.Text = "Unfriend";
            this.Button_Unfriend.Click += new System.EventHandler(this.Button_Unfriend_Click);
            // 
            // Button_Profile
            // 
            this.Button_Profile.BorderColor = System.Drawing.Color.DimGray;
            this.Button_Profile.BorderRadius = 17;
            this.Button_Profile.BorderThickness = 1;
            this.Button_Profile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_Profile.CheckedState.Parent = this.Button_Profile;
            this.Button_Profile.CustomImages.Parent = this.Button_Profile;
            this.Button_Profile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Profile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Profile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Profile.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Profile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Profile.DisabledState.Parent = this.Button_Profile;
            this.Button_Profile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button_Profile.FillColor2 = System.Drawing.Color.Blue;
            this.Button_Profile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Button_Profile.ForeColor = System.Drawing.Color.White;
            this.Button_Profile.HoverState.Parent = this.Button_Profile;
            this.Button_Profile.Location = new System.Drawing.Point(28, 28);
            this.Button_Profile.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Profile.Name = "Button_Profile";
            this.Button_Profile.ShadowDecoration.Parent = this.Button_Profile;
            this.Button_Profile.Size = new System.Drawing.Size(108, 37);
            this.Button_Profile.TabIndex = 90;
            this.Button_Profile.Text = "Profile";
            this.Button_Profile.Click += new System.EventHandler(this.Button_Profile_Click);
            // 
            // Form_InteractSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(302, 94);
            this.Controls.Add(this.Button_Profile);
            this.Controls.Add(this.Button_Unfriend);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_InteractSingle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Form_InteractSingle_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton Button_Unfriend;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Profile;
    }
}