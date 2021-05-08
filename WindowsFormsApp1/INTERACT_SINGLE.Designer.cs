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
            this.xuiButton2 = new XanderUI.XUIButton();
            this.btnMessagegroup = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.Crimson;
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "Xóa bạn";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(136, 32);
            this.xuiButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(100, 29);
            this.xuiButton2.TabIndex = 23;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnMessagegroup
            // 
            this.btnMessagegroup.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnMessagegroup.ButtonImage = null;
            this.btnMessagegroup.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnMessagegroup.ButtonText = "Trò chuyện";
            this.btnMessagegroup.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnMessagegroup.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMessagegroup.CornerRadius = 5;
            this.btnMessagegroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessagegroup.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMessagegroup.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnMessagegroup.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMessagegroup.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnMessagegroup.Location = new System.Drawing.Point(13, 32);
            this.btnMessagegroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMessagegroup.Name = "btnMessagegroup";
            this.btnMessagegroup.Size = new System.Drawing.Size(100, 29);
            this.btnMessagegroup.TabIndex = 22;
            this.btnMessagegroup.TextColor = System.Drawing.Color.White;
            this.btnMessagegroup.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMessagegroup.Click += new System.EventHandler(this.btnMessagegroup_Click);
            // 
            // frmInteractsingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 95);
            this.Controls.Add(this.xuiButton2);
            this.Controls.Add(this.btnMessagegroup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInteractsingle";
            this.Text = "INTERACT_SINGLE";
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton btnMessagegroup;
    }
}