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
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.TextBox_IP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RichTextBox_Message
            // 
            this.RichTextBox_Message.Location = new System.Drawing.Point(226, 12);
            this.RichTextBox_Message.Name = "RichTextBox_Message";
            this.RichTextBox_Message.Size = new System.Drawing.Size(562, 426);
            this.RichTextBox_Message.TabIndex = 1;
            this.RichTextBox_Message.Text = "";
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
            // TextBox_Port
            // 
            this.TextBox_Port.Location = new System.Drawing.Point(12, 74);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Port.TabIndex = 3;
            // 
            // TextBox_IP
            // 
            this.TextBox_IP.Location = new System.Drawing.Point(12, 100);
            this.TextBox_IP.Name = "TextBox_IP";
            this.TextBox_IP.Size = new System.Drawing.Size(208, 20);
            this.TextBox_IP.TabIndex = 4;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox_IP);
            this.Controls.Add(this.TextBox_Port);
            this.Controls.Add(this.Button_Listen);
            this.Controls.Add(this.RichTextBox_Message);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RichTextBox_Message;
        private System.Windows.Forms.Button Button_Listen;
        private System.Windows.Forms.TextBox TextBox_Port;
        private System.Windows.Forms.TextBox TextBox_IP;
    }
}

