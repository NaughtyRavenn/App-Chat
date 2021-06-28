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
            this.Label_Message = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bubble_MessageSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bubble_MessageSend
            // 
            this.Bubble_MessageSend.BackColor = System.Drawing.Color.Transparent;
            this.Bubble_MessageSend.BorderRadius = 30;
            this.Bubble_MessageSend.Controls.Add(this.Label_Message);
            this.Bubble_MessageSend.Controls.Add(this.panel1);
            this.Bubble_MessageSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bubble_MessageSend.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bubble_MessageSend.Location = new System.Drawing.Point(250, 0);
            this.Bubble_MessageSend.Margin = new System.Windows.Forms.Padding(2);
            this.Bubble_MessageSend.Name = "Bubble_MessageSend";
            this.Bubble_MessageSend.ShadowDecoration.Parent = this.Bubble_MessageSend;
            this.Bubble_MessageSend.Size = new System.Drawing.Size(297, 67);
            this.Bubble_MessageSend.TabIndex = 0;
            // 
            // Label_Message
            // 
            this.Label_Message.AutoSize = true;
            this.Label_Message.BackColor = System.Drawing.Color.Transparent;
            this.Label_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label_Message.ForeColor = System.Drawing.Color.White;
            this.Label_Message.Location = new System.Drawing.Point(36, 25);
            this.Label_Message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Message.Name = "Label_Message";
            this.Label_Message.Size = new System.Drawing.Size(133, 20);
            this.Label_Message.TabIndex = 0;
            this.Label_Message.Text = "Này là chat cho ib";
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
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Bubble_MessageSend);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CHAT_Send";
            this.Size = new System.Drawing.Size(548, 67);

            this.Bubble_MessageSend.ResumeLayout(false);
            this.Bubble_MessageSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel Bubble_MessageSend;
        private System.Windows.Forms.Label Label_Message;
        private System.Windows.Forms.Panel panel1;
    }
}
