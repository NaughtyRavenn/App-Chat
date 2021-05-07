namespace WindowsFormsApp1
{
    partial class frmInteractgroup
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnMessagegroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(141, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Rời nhóm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMessagegroup
            // 
            this.btnMessagegroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessagegroup.Location = new System.Drawing.Point(11, 28);
            this.btnMessagegroup.Margin = new System.Windows.Forms.Padding(2);
            this.btnMessagegroup.Name = "btnMessagegroup";
            this.btnMessagegroup.Size = new System.Drawing.Size(97, 34);
            this.btnMessagegroup.TabIndex = 3;
            this.btnMessagegroup.Text = "Nhắn tin";
            this.btnMessagegroup.UseVisualStyleBackColor = true;
            this.btnMessagegroup.Click += new System.EventHandler(this.btnMessagegroup_Click);
            // 
            // frmInteractgroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 101);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMessagegroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInteractgroup";
            this.Text = "INTERACT_GRP";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMessagegroup;
    }
}