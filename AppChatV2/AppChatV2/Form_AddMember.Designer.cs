namespace AppChatV2
{
    partial class Form_AddMember
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
            this.FlowLayoutPanel_ListFriend = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ComboBox_Friend = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FlowLayoutPanel_ListMember = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlowLayoutPanel_ListFriend
            // 
            this.FlowLayoutPanel_ListFriend.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPanel_ListFriend.Location = new System.Drawing.Point(383, 73);
            this.FlowLayoutPanel_ListFriend.Name = "FlowLayoutPanel_ListFriend";
            this.FlowLayoutPanel_ListFriend.Size = new System.Drawing.Size(460, 419);
            this.FlowLayoutPanel_ListFriend.TabIndex = 0;
            // 
            // Button_Search
            // 
            this.Button_Search.BackColor = System.Drawing.Color.Transparent;
            this.Button_Search.BorderColor = System.Drawing.Color.DimGray;
            this.Button_Search.BorderRadius = 10;
            this.Button_Search.BorderThickness = 1;
            this.Button_Search.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_Search.CheckedState.Parent = this.Button_Search;
            this.Button_Search.CustomImages.Parent = this.Button_Search;
            this.Button_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Search.DisabledState.Parent = this.Button_Search;
            this.Button_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button_Search.FillColor2 = System.Drawing.Color.Blue;
            this.Button_Search.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Button_Search.ForeColor = System.Drawing.Color.White;
            this.Button_Search.HoverState.Parent = this.Button_Search;
            this.Button_Search.Location = new System.Drawing.Point(519, 12);
            this.Button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.ShadowDecoration.Parent = this.Button_Search;
            this.Button_Search.Size = new System.Drawing.Size(98, 36);
            this.Button_Search.TabIndex = 30;
            this.Button_Search.Text = "Search";
            // 
            // ComboBox_Friend
            // 
            this.ComboBox_Friend.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Friend.BorderColor = System.Drawing.Color.DimGray;
            this.ComboBox_Friend.BorderRadius = 10;
            this.ComboBox_Friend.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Friend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Friend.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Friend.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Friend.FocusedState.Parent = this.ComboBox_Friend;
            this.ComboBox_Friend.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.ComboBox_Friend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_Friend.HoverState.Parent = this.ComboBox_Friend;
            this.ComboBox_Friend.ItemHeight = 30;
            this.ComboBox_Friend.Items.AddRange(new object[] {
            "abc"});
            this.ComboBox_Friend.ItemsAppearance.Parent = this.ComboBox_Friend;
            this.ComboBox_Friend.Location = new System.Drawing.Point(166, 12);
            this.ComboBox_Friend.Name = "ComboBox_Friend";
            this.ComboBox_Friend.ShadowDecoration.Parent = this.ComboBox_Friend;
            this.ComboBox_Friend.Size = new System.Drawing.Size(358, 36);
            this.ComboBox_Friend.TabIndex = 29;
            // 
            // FlowLayoutPanel_ListMember
            // 
            this.FlowLayoutPanel_ListMember.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPanel_ListMember.Location = new System.Drawing.Point(12, 73);
            this.FlowLayoutPanel_ListMember.Name = "FlowLayoutPanel_ListMember";
            this.FlowLayoutPanel_ListMember.Size = new System.Drawing.Size(365, 419);
            this.FlowLayoutPanel_ListMember.TabIndex = 31;
            // 
            // Form_AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppChatV2.Properties.Resources._40cee2e941086f4a5f251317699ddd85;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 504);
            this.Controls.Add(this.FlowLayoutPanel_ListMember);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.ComboBox_Friend);
            this.Controls.Add(this.FlowLayoutPanel_ListFriend);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_AddMember";
            this.Text = "Add member";
            this.Load += new System.EventHandler(this.Form_AddFriendToGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_ListFriend;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Search;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Friend;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_ListMember;
    }
}