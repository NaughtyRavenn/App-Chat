﻿namespace WindowsFormsApp1
{
    partial class frmGroupinfo
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddtogroup = new XanderUI.XUIButton();
            this.btnConfirm = new XanderUI.XUIButton();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddtogroup);
            this.groupBox2.Controls.Add(this.btnConfirm);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(299, 281);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // btnAddtogroup
            // 
            this.btnAddtogroup.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnAddtogroup.ButtonImage = null;
            this.btnAddtogroup.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAddtogroup.ButtonText = "Thêm thành viên";
            this.btnAddtogroup.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAddtogroup.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddtogroup.CornerRadius = 5;
            this.btnAddtogroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtogroup.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddtogroup.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAddtogroup.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddtogroup.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddtogroup.Location = new System.Drawing.Point(70, 193);
            this.btnAddtogroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddtogroup.Name = "btnAddtogroup";
            this.btnAddtogroup.Size = new System.Drawing.Size(157, 29);
            this.btnAddtogroup.TabIndex = 20;
            this.btnAddtogroup.TextColor = System.Drawing.Color.White;
            this.btnAddtogroup.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddtogroup.Click += new System.EventHandler(this.btnAddtogroup_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnConfirm.ButtonImage = null;
            this.btnConfirm.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnConfirm.ButtonText = "Xác nhận";
            this.btnConfirm.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnConfirm.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirm.CornerRadius = 5;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirm.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnConfirm.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirm.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnConfirm.Location = new System.Drawing.Point(90, 236);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 29);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(214, 21);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 30);
            this.button6.TabIndex = 4;
            this.button6.Text = "Browse";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(90, 157);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 26);
            this.textBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(90, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ảnh nhóm";
            // 
            // frmGroupinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 296);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGroupinfo";
            this.Text = "GRP_INFO";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton btnAddtogroup;
        private XanderUI.XUIButton btnConfirm;
    }
}