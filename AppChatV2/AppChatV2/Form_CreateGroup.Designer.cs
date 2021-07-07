namespace AppChatV2
{
    partial class Form_CreateGroup
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
            this.TextBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_Confirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_Browse = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Name.BorderColor = System.Drawing.Color.DimGray;
            this.TextBox_Name.BorderRadius = 17;
            this.TextBox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Name.DefaultText = "";
            this.TextBox_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Name.DisabledState.Parent = this.TextBox_Name;
            this.TextBox_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Name.FocusedState.Parent = this.TextBox_Name;
            this.TextBox_Name.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.TextBox_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Name.HoverState.Parent = this.TextBox_Name;
            this.TextBox_Name.Location = new System.Drawing.Point(141, 196);
            this.TextBox_Name.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.PasswordChar = '\0';
            this.TextBox_Name.PlaceholderText = "";
            this.TextBox_Name.SelectedText = "";
            this.TextBox_Name.ShadowDecoration.Parent = this.TextBox_Name;
            this.TextBox_Name.Size = new System.Drawing.Size(304, 46);
            this.TextBox_Name.TabIndex = 51;
            this.TextBox_Name.TextOffset = new System.Drawing.Point(10, -2);
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Button_Confirm.BorderColor = System.Drawing.Color.DimGray;
            this.Button_Confirm.BorderRadius = 17;
            this.Button_Confirm.BorderThickness = 1;
            this.Button_Confirm.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_Confirm.CheckedState.Parent = this.Button_Confirm;
            this.Button_Confirm.CustomImages.Parent = this.Button_Confirm;
            this.Button_Confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Confirm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Confirm.DisabledState.Parent = this.Button_Confirm;
            this.Button_Confirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button_Confirm.FillColor2 = System.Drawing.Color.Blue;
            this.Button_Confirm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Button_Confirm.ForeColor = System.Drawing.Color.White;
            this.Button_Confirm.HoverState.Parent = this.Button_Confirm;
            this.Button_Confirm.Location = new System.Drawing.Point(141, 277);
            this.Button_Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.ShadowDecoration.Parent = this.Button_Confirm;
            this.Button_Confirm.Size = new System.Drawing.Size(188, 37);
            this.Button_Confirm.TabIndex = 49;
            this.Button_Confirm.Text = "Xác nhận";
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // Button_Browse
            // 
            this.Button_Browse.BackColor = System.Drawing.Color.Transparent;
            this.Button_Browse.BorderColor = System.Drawing.Color.DimGray;
            this.Button_Browse.BorderRadius = 17;
            this.Button_Browse.BorderThickness = 1;
            this.Button_Browse.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_Browse.CheckedState.Parent = this.Button_Browse;
            this.Button_Browse.CustomImages.Parent = this.Button_Browse;
            this.Button_Browse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Browse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Browse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Browse.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Browse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Browse.DisabledState.Parent = this.Button_Browse;
            this.Button_Browse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button_Browse.FillColor2 = System.Drawing.Color.Blue;
            this.Button_Browse.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Button_Browse.ForeColor = System.Drawing.Color.White;
            this.Button_Browse.HoverState.Parent = this.Button_Browse;
            this.Button_Browse.Location = new System.Drawing.Point(334, 21);
            this.Button_Browse.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Browse.Name = "Button_Browse";
            this.Button_Browse.ShadowDecoration.Parent = this.Button_Browse;
            this.Button_Browse.Size = new System.Drawing.Size(113, 37);
            this.Button_Browse.TabIndex = 48;
            this.Button_Browse.Text = "Browse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Avatar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox1.Location = new System.Drawing.Point(141, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 154);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Name";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.BackColor = System.Drawing.Color.Transparent;
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.Red;
            this.Label_Name.Location = new System.Drawing.Point(148, 248);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(0, 16);
            this.Label_Name.TabIndex = 52;
            // 
            // Form_CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppChatV2.Properties.Resources._40cee2e941086f4a5f251317699ddd85;
            this.ClientSize = new System.Drawing.Size(458, 344);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.Button_Browse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_CreateGroup";
            this.Text = "Form_CreateGroup";
            this.Load += new System.EventHandler(this.Form_CreateGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TextBox_Name;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Confirm;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Name;
    }
}