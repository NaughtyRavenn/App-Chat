namespace Server
{
    partial class frmMain
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
            this.btnOpenserver = new System.Windows.Forms.Button();
            this.lstvOnline = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnOpenserver
            // 
            this.btnOpenserver.AutoSize = true;
            this.btnOpenserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOpenserver.Location = new System.Drawing.Point(60, 29);
            this.btnOpenserver.Name = "btnOpenserver";
            this.btnOpenserver.Size = new System.Drawing.Size(156, 34);
            this.btnOpenserver.TabIndex = 0;
            this.btnOpenserver.Text = "OPEN SERVER";
            this.btnOpenserver.UseVisualStyleBackColor = true;
            this.btnOpenserver.Click += new System.EventHandler(this.btnOpenserver_Click);
            // 
            // lstvOnline
            // 
            this.lstvOnline.HideSelection = false;
            this.lstvOnline.Location = new System.Drawing.Point(60, 115);
            this.lstvOnline.Name = "lstvOnline";
            this.lstvOnline.Size = new System.Drawing.Size(758, 353);
            this.lstvOnline.TabIndex = 1;
            this.lstvOnline.UseCompatibleStateImageBehavior = false;
            this.lstvOnline.View = System.Windows.Forms.View.List;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 502);
            this.Controls.Add(this.lstvOnline);
            this.Controls.Add(this.btnOpenserver);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenserver;
        private System.Windows.Forms.ListView lstvOnline;
    }
}

