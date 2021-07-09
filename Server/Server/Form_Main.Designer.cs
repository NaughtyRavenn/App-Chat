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
            this.RichTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.Button_Listen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTextBox_Message
            // 
            this.RichTextBox_Message.Location = new System.Drawing.Point(124, 12);
            this.RichTextBox_Message.Name = "RichTextBox_Message";
            this.RichTextBox_Message.Size = new System.Drawing.Size(664, 426);
            this.RichTextBox_Message.TabIndex = 1;
            this.RichTextBox_Message.Text = "";
            this.RichTextBox_Message.TextChanged += new System.EventHandler(this.RichTextBox_Message_TextChanged);
            // 
            // Button_Listen
            // 
            this.Button_Listen.Location = new System.Drawing.Point(12, 12);
            this.Button_Listen.Name = "Button_Listen";
            this.Button_Listen.Size = new System.Drawing.Size(106, 55);
            this.Button_Listen.TabIndex = 2;
            this.Button_Listen.Text = "Listen";
            this.Button_Listen.UseVisualStyleBackColor = true;
            this.Button_Listen.Click += new System.EventHandler(this.Button_Listen_Click);
            // 
            // Form_Main
            // 
            this.AcceptButton = this.Button_Listen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Listen);
            this.Controls.Add(this.RichTextBox_Message);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox RichTextBox_Message;
        private System.Windows.Forms.Button Button_Listen;
    }
}

