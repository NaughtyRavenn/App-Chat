namespace WindowsFormsApp1
{
    partial class frmInteractsingle
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
            this.btnMessagesingle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessagesingle
            // 
            this.btnMessagesingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessagesingle.Location = new System.Drawing.Point(11, 28);
            this.btnMessagesingle.Margin = new System.Windows.Forms.Padding(2);
            this.btnMessagesingle.Name = "btnMessagesingle";
            this.btnMessagesingle.Size = new System.Drawing.Size(97, 34);
            this.btnMessagesingle.TabIndex = 0;
            this.btnMessagesingle.Text = "Nhắn tin";
            this.btnMessagesingle.UseVisualStyleBackColor = true;
            this.btnMessagesingle.Click += new System.EventHandler(this.btnMessagesingle_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(141, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa bạn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmInteractsingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 95);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMessagesingle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInteractsingle";
            this.Text = "INTERACT_SINGLE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessagesingle;
        private System.Windows.Forms.Button button2;
    }
}