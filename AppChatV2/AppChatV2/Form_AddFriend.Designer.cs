namespace AppChatV2
{
    partial class Form_AddFriend
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddFriend));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.Page_AddFriend = new Bunifu.UI.WinForms.BunifuPages();
            this.TabPage_Recent = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_Stranger = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TabPage_ListFriend = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_ListRequest = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Notice_Request = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Notice1 = new System.Windows.Forms.PictureBox();
            this.Notice2 = new System.Windows.Forms.PictureBox();
            this.Button_Request = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Button_Stranger = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Page_AddFriend.SuspendLayout();
            this.TabPage_Recent.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TabPage_ListFriend.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notice2)).BeginInit();
            this.SuspendLayout();
            // 
            // Page_AddFriend
            // 
            this.Page_AddFriend.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Page_AddFriend.AllowTransitions = true;
            this.Page_AddFriend.Controls.Add(this.TabPage_Recent);
            this.Page_AddFriend.Controls.Add(this.TabPage_ListFriend);
            this.Page_AddFriend.Location = new System.Drawing.Point(218, -11);
            this.Page_AddFriend.Multiline = true;
            this.Page_AddFriend.Name = "Page_AddFriend";
            this.Page_AddFriend.Padding = new System.Drawing.Point(7, 3);
            this.Page_AddFriend.Page = this.TabPage_ListFriend;
            this.Page_AddFriend.PageIndex = 1;
            this.Page_AddFriend.PageName = "TabPage_ListFriend";
            this.Page_AddFriend.PageTitle = "tabPage4";
            this.Page_AddFriend.SelectedIndex = 0;
            this.Page_AddFriend.Size = new System.Drawing.Size(491, 583);
            this.Page_AddFriend.TabIndex = 31;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Page_AddFriend.Transition = animation1;
            this.Page_AddFriend.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Transparent;
            // 
            // TabPage_Recent
            // 
            this.TabPage_Recent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabPage_Recent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabPage_Recent.Controls.Add(this.panel3);
            this.TabPage_Recent.Controls.Add(this.Button_Search);
            this.TabPage_Recent.Controls.Add(this.guna2ComboBox1);
            this.TabPage_Recent.Location = new System.Drawing.Point(4, 4);
            this.TabPage_Recent.Name = "TabPage_Recent";
            this.TabPage_Recent.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Recent.Size = new System.Drawing.Size(483, 557);
            this.TabPage_Recent.TabIndex = 0;
            this.TabPage_Recent.Text = "tabPage3";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.FlowLayoutPanel_Stranger);
            this.panel3.Location = new System.Drawing.Point(6, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 450);
            this.panel3.TabIndex = 35;
            // 
            // FlowLayoutPanel_Stranger
            // 
            this.FlowLayoutPanel_Stranger.AutoScroll = true;
            this.FlowLayoutPanel_Stranger.Location = new System.Drawing.Point(7, 3);
            this.FlowLayoutPanel_Stranger.Name = "FlowLayoutPanel_Stranger";
            this.FlowLayoutPanel_Stranger.Size = new System.Drawing.Size(388, 442);
            this.FlowLayoutPanel_Stranger.TabIndex = 29;
            // 
            // Button_Search
            // 
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
            this.Button_Search.Location = new System.Drawing.Point(314, 19);
            this.Button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.ShadowDecoration.Parent = this.Button_Search;
            this.Button_Search.Size = new System.Drawing.Size(98, 36);
            this.Button_Search.TabIndex = 28;
            this.Button_Search.Text = "Search";
            this.Button_Search.Visible = false;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "abc"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(6, 19);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(303, 36);
            this.guna2ComboBox1.TabIndex = 0;
            this.guna2ComboBox1.Visible = false;
            // 
            // TabPage_ListFriend
            // 
            this.TabPage_ListFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TabPage_ListFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabPage_ListFriend.Controls.Add(this.panel2);
            this.TabPage_ListFriend.Controls.Add(this.label4);
            this.TabPage_ListFriend.Controls.Add(this.Label_Count);
            this.TabPage_ListFriend.Controls.Add(this.label2);
            this.TabPage_ListFriend.Location = new System.Drawing.Point(4, 4);
            this.TabPage_ListFriend.Name = "TabPage_ListFriend";
            this.TabPage_ListFriend.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_ListFriend.Size = new System.Drawing.Size(483, 557);
            this.TabPage_ListFriend.TabIndex = 1;
            this.TabPage_ListFriend.Text = "tabPage4";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FlowLayoutPanel_ListRequest);
            this.panel2.Location = new System.Drawing.Point(6, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 450);
            this.panel2.TabIndex = 35;
            // 
            // FlowLayoutPanel_ListRequest
            // 
            this.FlowLayoutPanel_ListRequest.AutoScroll = true;
            this.FlowLayoutPanel_ListRequest.Location = new System.Drawing.Point(7, 3);
            this.FlowLayoutPanel_ListRequest.Name = "FlowLayoutPanel_ListRequest";
            this.FlowLayoutPanel_ListRequest.Size = new System.Drawing.Size(388, 442);
            this.FlowLayoutPanel_ListRequest.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(205, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "lời mời kết bạn";
            // 
            // Label_Count
            // 
            this.Label_Count.AutoSize = true;
            this.Label_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label_Count.ForeColor = System.Drawing.Color.Red;
            this.Label_Count.Location = new System.Drawing.Point(187, 31);
            this.Label_Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Count.Name = "Label_Count";
            this.Label_Count.Size = new System.Drawing.Size(45, 20);
            this.Label_Count.TabIndex = 32;
            this.Label_Count.Text = "Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(132, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Bạn có";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.Notice_Request);
            this.guna2Panel1.Controls.Add(this.Notice1);
            this.guna2Panel1.Controls.Add(this.Notice2);
            this.guna2Panel1.Controls.Add(this.Button_Request);
            this.guna2Panel1.Controls.Add(this.Button_Stranger);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Location = new System.Drawing.Point(-6, -11);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(222, 583);
            this.guna2Panel1.TabIndex = 32;
            // 
            // Notice_Request
            // 
            this.Notice_Request.BackColor = System.Drawing.Color.White;
            this.Notice_Request.CheckedState.Parent = this.Notice_Request;
            this.Notice_Request.CustomImages.Parent = this.Notice_Request;
            this.Notice_Request.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Notice_Request.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Notice_Request.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Notice_Request.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Notice_Request.DisabledState.Parent = this.Notice_Request;
            this.Notice_Request.FillColor = System.Drawing.Color.Red;
            this.Notice_Request.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Notice_Request.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Notice_Request.ForeColor = System.Drawing.Color.White;
            this.Notice_Request.HoverState.Parent = this.Notice_Request;
            this.Notice_Request.Location = new System.Drawing.Point(198, 242);
            this.Notice_Request.Name = "Notice_Request";
            this.Notice_Request.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Notice_Request.ShadowDecoration.Parent = this.Notice_Request;
            this.Notice_Request.Size = new System.Drawing.Size(15, 15);
            this.Notice_Request.TabIndex = 28;
            this.Notice_Request.Visible = false;
            // 
            // Notice1
            // 
            this.Notice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(50)))), ((int)(((byte)(207)))));
            this.Notice1.Location = new System.Drawing.Point(1, 140);
            this.Notice1.Name = "Notice1";
            this.Notice1.Size = new System.Drawing.Size(10, 62);
            this.Notice1.TabIndex = 2;
            this.Notice1.TabStop = false;
            // 
            // Notice2
            // 
            this.Notice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(50)))), ((int)(((byte)(207)))));
            this.Notice2.Location = new System.Drawing.Point(1, 200);
            this.Notice2.Name = "Notice2";
            this.Notice2.Size = new System.Drawing.Size(10, 62);
            this.Notice2.TabIndex = 4;
            this.Notice2.TabStop = false;
            this.Notice2.Visible = false;
            // 
            // Button_Request
            // 
            this.Button_Request.AllowToggling = true;
            this.Button_Request.AnimationSpeed = 200;
            this.Button_Request.AutoGenerateColors = false;
            this.Button_Request.BackColor = System.Drawing.Color.Transparent;
            this.Button_Request.BackColor1 = System.Drawing.Color.White;
            this.Button_Request.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Request.BackgroundImage")));
            this.Button_Request.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Request.ButtonText = "Friend request";
            this.Button_Request.ButtonTextMarginLeft = 20;
            this.Button_Request.ColorContrastOnClick = 45;
            this.Button_Request.ColorContrastOnHover = 45;
            this.Button_Request.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Button_Request.CustomizableEdges = borderEdges1;
            this.Button_Request.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Request.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Request.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Request.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Request.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Request.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_Request.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Button_Request.ForeColor = System.Drawing.Color.DimGray;
            this.Button_Request.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Request.IconMarginLeft = 20;
            this.Button_Request.IconPadding = 15;
            this.Button_Request.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Request.IdleBorderColor = System.Drawing.Color.White;
            this.Button_Request.IdleBorderRadius = 3;
            this.Button_Request.IdleBorderThickness = 1;
            this.Button_Request.IdleFillColor = System.Drawing.Color.White;
            this.Button_Request.IdleIconLeftImage = global::AppChatV2.Properties.Resources.outline_pending_actions_black_2;
            this.Button_Request.IdleIconRightImage = null;
            this.Button_Request.IndicateFocus = true;
            this.Button_Request.Location = new System.Drawing.Point(0, 201);
            this.Button_Request.Name = "Button_Request";
            stateProperties1.BorderColor = System.Drawing.Color.White;
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.White;
            stateProperties1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(50)))), ((int)(((byte)(207)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.Button_Request.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.White;
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(50)))), ((int)(((byte)(207)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.Button_Request.OnPressedState = stateProperties2;
            this.Button_Request.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Request.Size = new System.Drawing.Size(222, 62);
            this.Button_Request.TabIndex = 3;
            this.Button_Request.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Request.TextMarginLeft = 20;
            this.Button_Request.UseDefaultRadiusAndThickness = true;
            this.Button_Request.Click += new System.EventHandler(this.Button_Request_Click);
            // 
            // Button_Stranger
            // 
            this.Button_Stranger.AllowToggling = true;
            this.Button_Stranger.AnimationSpeed = 200;
            this.Button_Stranger.AutoGenerateColors = false;
            this.Button_Stranger.BackColor = System.Drawing.Color.Transparent;
            this.Button_Stranger.BackColor1 = System.Drawing.Color.White;
            this.Button_Stranger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Stranger.BackgroundImage")));
            this.Button_Stranger.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Stranger.ButtonText = "Add friend";
            this.Button_Stranger.ButtonTextMarginLeft = 8;
            this.Button_Stranger.ColorContrastOnClick = 45;
            this.Button_Stranger.ColorContrastOnHover = 45;
            this.Button_Stranger.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Button_Stranger.CustomizableEdges = borderEdges2;
            this.Button_Stranger.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Stranger.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Stranger.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Stranger.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Stranger.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Stranger.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_Stranger.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Button_Stranger.ForeColor = System.Drawing.Color.DimGray;
            this.Button_Stranger.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Stranger.IconMarginLeft = 20;
            this.Button_Stranger.IconPadding = 15;
            this.Button_Stranger.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Stranger.IdleBorderColor = System.Drawing.Color.White;
            this.Button_Stranger.IdleBorderRadius = 3;
            this.Button_Stranger.IdleBorderThickness = 1;
            this.Button_Stranger.IdleFillColor = System.Drawing.Color.White;
            this.Button_Stranger.IdleIconLeftImage = global::AppChatV2.Properties.Resources.outline_person_search_black_2;
            this.Button_Stranger.IdleIconRightImage = null;
            this.Button_Stranger.IndicateFocus = true;
            this.Button_Stranger.Location = new System.Drawing.Point(0, 139);
            this.Button_Stranger.Name = "Button_Stranger";
            stateProperties3.BorderColor = System.Drawing.Color.White;
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.White;
            stateProperties3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(50)))), ((int)(((byte)(207)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.Button_Stranger.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(50)))), ((int)(((byte)(207)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.Button_Stranger.OnPressedState = stateProperties4;
            this.Button_Stranger.Size = new System.Drawing.Size(222, 62);
            this.Button_Stranger.TabIndex = 1;
            this.Button_Stranger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Stranger.TextMarginLeft = 8;
            this.Button_Stranger.UseDefaultRadiusAndThickness = true;
            this.Button_Stranger.Click += new System.EventHandler(this.Button_ListStranger_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 139);
            this.panel1.TabIndex = 0;
            // 
            // Form_AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppChatV2.Properties.Resources._40cee2e941086f4a5f251317699ddd85;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 561);
            this.Controls.Add(this.Page_AddFriend);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_AddFriend";
            this.Text = "Add Friend";
            this.Load += new System.EventHandler(this.Form_AddFriend_Load);
            this.Page_AddFriend.ResumeLayout(false);
            this.TabPage_Recent.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.TabPage_ListFriend.ResumeLayout(false);
            this.TabPage_ListFriend.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Notice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notice2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPages Page_AddFriend;
        private System.Windows.Forms.TabPage TabPage_Recent;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.TabPage TabPage_ListFriend;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox Notice1;
        private System.Windows.Forms.PictureBox Notice2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_Request;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_Stranger;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Search;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Stranger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_ListRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CircleButton Notice_Request;
    }
}