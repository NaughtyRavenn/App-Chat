namespace WindowsFormsApp1
{
    partial class frmSinglechat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinglechat));
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lstvMessage = new System.Windows.Forms.ListView();
            this.btnSend = new System.Windows.Forms.Button();
            this.xuiButton4 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(93, 378);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(356, 35);
            this.txtMessage.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(520, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(2, 400);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(499, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 358);
            this.vScrollBar1.TabIndex = 12;
            // 
            // lstvMessage
            // 
            this.lstvMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvMessage.HideSelection = false;
            this.lstvMessage.Location = new System.Drawing.Point(12, 12);
            this.lstvMessage.Name = "lstvMessage";
            this.lstvMessage.Size = new System.Drawing.Size(485, 359);
            this.lstvMessage.TabIndex = 22;
            this.lstvMessage.UseCompatibleStateImageBehavior = false;
            this.lstvMessage.View = System.Windows.Forms.View.List;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend.Location = new System.Drawing.Point(454, 378);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(65, 34);
            this.btnSend.TabIndex = 23;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // xuiButton4
            // 
            this.xuiButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiButton4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton4.ButtonImage")));
            this.xuiButton4.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton4.ButtonText = "";
            this.xuiButton4.ClickBackColor = System.Drawing.Color.Black;
            this.xuiButton4.ClickTextColor = System.Drawing.Color.Black;
            this.xuiButton4.CornerRadius = 5;
            this.xuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton4.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton4.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton4.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton4.Location = new System.Drawing.Point(14, 384);
            this.xuiButton4.Margin = new System.Windows.Forms.Padding(2);
            this.xuiButton4.Name = "xuiButton4";
            this.xuiButton4.Size = new System.Drawing.Size(22, 24);
            this.xuiButton4.TabIndex = 18;
            this.xuiButton4.TextColor = System.Drawing.Color.Black;
            this.xuiButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton2.ButtonImage")));
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.Black;
            this.xuiButton2.ClickTextColor = System.Drawing.Color.Black;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton2.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(68, 384);
            this.xuiButton2.Margin = new System.Windows.Forms.Padding(2);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(22, 24);
            this.xuiButton2.TabIndex = 17;
            this.xuiButton2.TextColor = System.Drawing.Color.Black;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton3.ButtonImage")));
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.Black;
            this.xuiButton3.ClickTextColor = System.Drawing.Color.Black;
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton3.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(40, 384);
            this.xuiButton3.Margin = new System.Windows.Forms.Padding(2);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(22, 24);
            this.xuiButton3.TabIndex = 16;
            this.xuiButton3.TextColor = System.Drawing.Color.Black;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox1.Location = new System.Drawing.Point(556, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 146);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Friend";
            // 
            // frmSinglechat
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lstvMessage);
            this.Controls.Add(this.xuiButton4);
            this.Controls.Add(this.xuiButton2);
            this.Controls.Add(this.xuiButton3);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSinglechat";
            this.Text = "SINGLE_CHAT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.frmSinglechat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIButton xuiButton4;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListView lstvMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}