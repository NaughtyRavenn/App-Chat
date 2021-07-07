namespace AppChatV2
{
    partial class UC_AddMember
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Name = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox11 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Button_Add = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Add)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.Label_Name.ForeColor = System.Drawing.Color.Black;
            this.Label_Name.Location = new System.Drawing.Point(100, 32);
            this.Label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(149, 32);
            this.Label_Name.TabIndex = 28;
            this.Label_Name.Text = "Username";
            // 
            // guna2CirclePictureBox11
            // 
            this.guna2CirclePictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox11.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.guna2CirclePictureBox11.ImageRotate = 0F;
            this.guna2CirclePictureBox11.InitialImage = null;
            this.guna2CirclePictureBox11.Location = new System.Drawing.Point(14, 17);
            this.guna2CirclePictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox11.Name = "guna2CirclePictureBox11";
            this.guna2CirclePictureBox11.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox11.ShadowDecoration.Parent = this.guna2CirclePictureBox11;
            this.guna2CirclePictureBox11.Size = new System.Drawing.Size(70, 70);
            this.guna2CirclePictureBox11.TabIndex = 29;
            this.guna2CirclePictureBox11.TabStop = false;
            // 
            // Button_Add
            // 
            this.Button_Add.Image = global::AppChatV2.Properties.Resources.outline_add_circle_outline_black_2;
            this.Button_Add.ImageActive = null;
            this.Button_Add.Location = new System.Drawing.Point(267, 26);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(50, 50);
            this.Button_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Add.TabIndex = 32;
            this.Button_Add.TabStop = false;
            this.Button_Add.Zoom = 10;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // UC_AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.guna2CirclePictureBox11);
            this.Name = "UC_AddMember";
            this.Size = new System.Drawing.Size(328, 104);
            this.Load += new System.EventHandler(this.UC_AddMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Name;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox11;
        private Bunifu.Framework.UI.BunifuImageButton Button_Add;
    }
}
