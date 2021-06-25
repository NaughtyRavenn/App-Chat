namespace AppChatV2
{
    partial class CHAT_Send
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
            this.Bubble_MessageSend = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bubble_MessageSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bubble_MessageSend
            // 
            this.Bubble_MessageSend.BackColor = System.Drawing.Color.Transparent;
            this.Bubble_MessageSend.BorderRadius = 30;
            this.Bubble_MessageSend.Controls.Add(this.label1);
            this.Bubble_MessageSend.Controls.Add(this.panel1);
            this.Bubble_MessageSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bubble_MessageSend.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bubble_MessageSend.Location = new System.Drawing.Point(0, 0);
            this.Bubble_MessageSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bubble_MessageSend.Name = "Bubble_MessageSend";
            this.Bubble_MessageSend.ShadowDecoration.Parent = this.Bubble_MessageSend;
            this.Bubble_MessageSend.Size = new System.Drawing.Size(297, 67);
            this.Bubble_MessageSend.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Này là chat cho ib";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(239, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 29);
            this.panel1.TabIndex = 3;
            // 
            // CHAT_Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Bubble_MessageSend);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CHAT_Send";
            this.Size = new System.Drawing.Size(297, 67);
            this.Bubble_MessageSend.ResumeLayout(false);
            this.Bubble_MessageSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel Bubble_MessageSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
