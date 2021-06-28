namespace Server
{
    partial class Form_Main
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
            this.Button_Reload = new System.Windows.Forms.Button();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Reload
            // 
            this.Button_Reload.Location = new System.Drawing.Point(29, 3);
            this.Button_Reload.Name = "Button_Reload";
            this.Button_Reload.Size = new System.Drawing.Size(316, 135);
            this.Button_Reload.TabIndex = 0;
            this.Button_Reload.Text = "button1";
            this.Button_Reload.UseVisualStyleBackColor = true;
            this.Button_Reload.Click += new System.EventHandler(this.Button_Reload_Click);
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(380, 78);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 20);
            this.txt_1.TabIndex = 1;
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(380, 159);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(100, 20);
            this.txt_3.TabIndex = 2;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(380, 118);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 20);
            this.txt_2.TabIndex = 3;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.Button_Reload);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Reload;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.TextBox txt_2;
    }
}

