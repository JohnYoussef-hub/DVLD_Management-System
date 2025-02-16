namespace DVLD_Project.Application
{
    partial class frmAddNewApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewApplication));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSaveUser = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tabLoginInfo = new System.Windows.Forms.TabPage();
            this.lblCreatedBy = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAppFees = new Bunifu.UI.WinForms.BunifuLabel();
            this.drbLicenseClass = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblAppDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAppID = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblMainTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.ctrlPersonInfoWithFilter1 = new DVLD_Project.User.Controls.ctrlPersonInfoWithFilter();
            this.TabControl1.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowMouseEffects = true;
            this.btnClose.AllowToggling = false;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = false;
            this.btnClose.AutoRoundBorders = false;
            this.btnClose.AutoSizeLeftIcon = true;
            this.btnClose.AutoSizeRightIcon = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.IndianRed;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.ButtonText = "Close";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClose.Font = new System.Drawing.Font("Kelson Sans Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 10;
            this.btnClose.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClose.IconSize = 25;
            this.btnClose.IdleBorderColor = System.Drawing.Color.IndianRed;
            this.btnClose.IdleBorderRadius = 1;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleFillColor = System.Drawing.Color.IndianRed;
            this.btnClose.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.Cancel;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(585, 650);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 1;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 1;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.onHoverState.BorderRadius = 1;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.IndianRed;
            this.btnClose.OnIdleState.BorderRadius = 1;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 1;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.IndianRed;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.Cancel;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.IndianRed;
            this.btnClose.OnPressedState.BorderRadius = 1;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.IndianRed;
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(112, 43);
            this.btnClose.TabIndex = 9;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.AllowAnimations = true;
            this.btnSaveUser.AllowMouseEffects = true;
            this.btnSaveUser.AllowToggling = false;
            this.btnSaveUser.AnimationSpeed = 200;
            this.btnSaveUser.AutoGenerateColors = false;
            this.btnSaveUser.AutoRoundBorders = false;
            this.btnSaveUser.AutoSizeLeftIcon = true;
            this.btnSaveUser.AutoSizeRightIcon = true;
            this.btnSaveUser.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveUser.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSaveUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.BackgroundImage")));
            this.btnSaveUser.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUser.ButtonText = "Save";
            this.btnSaveUser.ButtonTextMarginLeft = 0;
            this.btnSaveUser.ColorContrastOnClick = 45;
            this.btnSaveUser.ColorContrastOnHover = 45;
            this.btnSaveUser.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSaveUser.CustomizableEdges = borderEdges2;
            this.btnSaveUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveUser.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveUser.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveUser.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveUser.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveUser.Font = new System.Drawing.Font("Kelson Sans Normal", 18F);
            this.btnSaveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveUser.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUser.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveUser.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSaveUser.IconMarginLeft = 11;
            this.btnSaveUser.IconPadding = 10;
            this.btnSaveUser.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUser.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveUser.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSaveUser.IconSize = 25;
            this.btnSaveUser.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSaveUser.IdleBorderRadius = 1;
            this.btnSaveUser.IdleBorderThickness = 1;
            this.btnSaveUser.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSaveUser.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.Save;
            this.btnSaveUser.IdleIconRightImage = null;
            this.btnSaveUser.IndicateFocus = false;
            this.btnSaveUser.Location = new System.Drawing.Point(724, 650);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveUser.OnDisabledState.BorderRadius = 1;
            this.btnSaveUser.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUser.OnDisabledState.BorderThickness = 1;
            this.btnSaveUser.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveUser.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveUser.OnDisabledState.IconLeftImage = null;
            this.btnSaveUser.OnDisabledState.IconRightImage = null;
            this.btnSaveUser.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSaveUser.onHoverState.BorderRadius = 1;
            this.btnSaveUser.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUser.onHoverState.BorderThickness = 1;
            this.btnSaveUser.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSaveUser.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.onHoverState.IconLeftImage = null;
            this.btnSaveUser.onHoverState.IconRightImage = null;
            this.btnSaveUser.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSaveUser.OnIdleState.BorderRadius = 1;
            this.btnSaveUser.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUser.OnIdleState.BorderThickness = 1;
            this.btnSaveUser.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSaveUser.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveUser.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.Save;
            this.btnSaveUser.OnIdleState.IconRightImage = null;
            this.btnSaveUser.OnPressedState.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnSaveUser.OnPressedState.BorderRadius = 1;
            this.btnSaveUser.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveUser.OnPressedState.BorderThickness = 1;
            this.btnSaveUser.OnPressedState.FillColor = System.Drawing.Color.DarkTurquoise;
            this.btnSaveUser.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.OnPressedState.IconLeftImage = null;
            this.btnSaveUser.OnPressedState.IconRightImage = null;
            this.btnSaveUser.Size = new System.Drawing.Size(118, 41);
            this.btnSaveUser.TabIndex = 8;
            this.btnSaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveUser.TextMarginLeft = 0;
            this.btnSaveUser.TextPadding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSaveUser.UseDefaultRadiusAndThickness = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPersonalInfo);
            this.TabControl1.Controls.Add(this.tabLoginInfo);
            this.TabControl1.Location = new System.Drawing.Point(11, 69);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(854, 563);
            this.TabControl1.TabIndex = 6;
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.tabPersonalInfo.Controls.Add(this.btnNext);
            this.tabPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalInfo.Size = new System.Drawing.Size(846, 537);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "Personal Info";
            this.tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.AllowAnimations = true;
            this.btnNext.AllowMouseEffects = true;
            this.btnNext.AllowToggling = false;
            this.btnNext.AnimationSpeed = 200;
            this.btnNext.AutoGenerateColors = false;
            this.btnNext.AutoRoundBorders = false;
            this.btnNext.AutoSizeLeftIcon = true;
            this.btnNext.AutoSizeRightIcon = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackColor1 = System.Drawing.Color.CornflowerBlue;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNext.ButtonText = "Next";
            this.btnNext.ButtonTextMarginLeft = 0;
            this.btnNext.ColorContrastOnClick = 45;
            this.btnNext.ColorContrastOnHover = 45;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnNext.CustomizableEdges = borderEdges3;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNext.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNext.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNext.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNext.IconMarginLeft = 11;
            this.btnNext.IconPadding = 10;
            this.btnNext.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNext.IconSize = 25;
            this.btnNext.IdleBorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnNext.IdleBorderRadius = 1;
            this.btnNext.IdleBorderThickness = 1;
            this.btnNext.IdleFillColor = System.Drawing.Color.CornflowerBlue;
            this.btnNext.IdleIconLeftImage = null;
            this.btnNext.IdleIconRightImage = global::DVLD_Project.Properties.Resources.Forward_Button;
            this.btnNext.IndicateFocus = false;
            this.btnNext.Location = new System.Drawing.Point(695, 482);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNext.OnDisabledState.BorderRadius = 1;
            this.btnNext.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNext.OnDisabledState.BorderThickness = 1;
            this.btnNext.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNext.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNext.OnDisabledState.IconLeftImage = null;
            this.btnNext.OnDisabledState.IconRightImage = null;
            this.btnNext.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNext.onHoverState.BorderRadius = 1;
            this.btnNext.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNext.onHoverState.BorderThickness = 1;
            this.btnNext.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNext.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNext.onHoverState.IconLeftImage = null;
            this.btnNext.onHoverState.IconRightImage = null;
            this.btnNext.OnIdleState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnNext.OnIdleState.BorderRadius = 1;
            this.btnNext.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNext.OnIdleState.BorderThickness = 1;
            this.btnNext.OnIdleState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnNext.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNext.OnIdleState.IconLeftImage = null;
            this.btnNext.OnIdleState.IconRightImage = global::DVLD_Project.Properties.Resources.Forward_Button;
            this.btnNext.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNext.OnPressedState.BorderRadius = 1;
            this.btnNext.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNext.OnPressedState.BorderThickness = 1;
            this.btnNext.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNext.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNext.OnPressedState.IconLeftImage = null;
            this.btnNext.OnPressedState.IconRightImage = null;
            this.btnNext.Size = new System.Drawing.Size(91, 41);
            this.btnNext.TabIndex = 1;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNext.TextMarginLeft = 0;
            this.btnNext.TextPadding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNext.UseDefaultRadiusAndThickness = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabLoginInfo
            // 
            this.tabLoginInfo.Controls.Add(this.lblCreatedBy);
            this.tabLoginInfo.Controls.Add(this.lblAppFees);
            this.tabLoginInfo.Controls.Add(this.drbLicenseClass);
            this.tabLoginInfo.Controls.Add(this.lblAppDate);
            this.tabLoginInfo.Controls.Add(this.bunifuLabel6);
            this.tabLoginInfo.Controls.Add(this.bunifuLabel5);
            this.tabLoginInfo.Controls.Add(this.bunifuLabel4);
            this.tabLoginInfo.Controls.Add(this.bunifuLabel3);
            this.tabLoginInfo.Controls.Add(this.lblAppID);
            this.tabLoginInfo.Controls.Add(this.bunifuLabel2);
            this.tabLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tabLoginInfo.Name = "tabLoginInfo";
            this.tabLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginInfo.Size = new System.Drawing.Size(846, 537);
            this.tabLoginInfo.TabIndex = 1;
            this.tabLoginInfo.Text = "Application Info";
            this.tabLoginInfo.UseVisualStyleBackColor = true;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AllowParentOverrides = false;
            this.lblCreatedBy.AutoEllipsis = false;
            this.lblCreatedBy.CursorType = null;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.Location = new System.Drawing.Point(339, 289);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCreatedBy.Size = new System.Drawing.Size(41, 24);
            this.lblCreatedBy.TabIndex = 20;
            this.lblCreatedBy.Text = "[???]";
            this.lblCreatedBy.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCreatedBy.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblAppFees
            // 
            this.lblAppFees.AllowParentOverrides = false;
            this.lblAppFees.AutoEllipsis = false;
            this.lblAppFees.CursorType = null;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAppFees.Location = new System.Drawing.Point(339, 245);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppFees.Size = new System.Drawing.Size(22, 24);
            this.lblAppFees.TabIndex = 19;
            this.lblAppFees.Text = "15";
            this.lblAppFees.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppFees.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // drbLicenseClass
            // 
            this.drbLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.drbLicenseClass.BackgroundColor = System.Drawing.Color.White;
            this.drbLicenseClass.BorderColor = System.Drawing.Color.Silver;
            this.drbLicenseClass.BorderRadius = 1;
            this.drbLicenseClass.Color = System.Drawing.Color.Silver;
            this.drbLicenseClass.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drbLicenseClass.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drbLicenseClass.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drbLicenseClass.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drbLicenseClass.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drbLicenseClass.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drbLicenseClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drbLicenseClass.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drbLicenseClass.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drbLicenseClass.FillDropDown = true;
            this.drbLicenseClass.FillIndicator = false;
            this.drbLicenseClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drbLicenseClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.drbLicenseClass.ForeColor = System.Drawing.Color.Black;
            this.drbLicenseClass.FormattingEnabled = true;
            this.drbLicenseClass.Icon = null;
            this.drbLicenseClass.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drbLicenseClass.IndicatorColor = System.Drawing.Color.Gray;
            this.drbLicenseClass.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drbLicenseClass.ItemBackColor = System.Drawing.Color.White;
            this.drbLicenseClass.ItemBorderColor = System.Drawing.Color.White;
            this.drbLicenseClass.ItemForeColor = System.Drawing.Color.Black;
            this.drbLicenseClass.ItemHeight = 21;
            this.drbLicenseClass.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.drbLicenseClass.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drbLicenseClass.Items.AddRange(new object[] {
            "Class 1 - Small Motorcycle",
            "Class 2 - Heavy Motorcycle License",
            "Class 3 - Ordinary driving license",
            "Class 4 - Commercial",
            "Class 5 - Agricultural",
            "Class 6 - Small and medium bus",
            "Class 7 - Truck and heavy vehicle"});
            this.drbLicenseClass.ItemTopMargin = 3;
            this.drbLicenseClass.Location = new System.Drawing.Point(339, 201);
            this.drbLicenseClass.Name = "drbLicenseClass";
            this.drbLicenseClass.Size = new System.Drawing.Size(233, 27);
            this.drbLicenseClass.TabIndex = 18;
            this.drbLicenseClass.Text = null;
            this.drbLicenseClass.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drbLicenseClass.TextLeftMargin = 5;
            // 
            // lblAppDate
            // 
            this.lblAppDate.AllowParentOverrides = false;
            this.lblAppDate.AutoEllipsis = false;
            this.lblAppDate.CursorType = null;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAppDate.Location = new System.Drawing.Point(339, 157);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppDate.Size = new System.Drawing.Size(41, 24);
            this.lblAppDate.TabIndex = 17;
            this.lblAppDate.Text = "[???]";
            this.lblAppDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel6.Location = new System.Drawing.Point(215, 289);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(105, 24);
            this.bunifuLabel6.TabIndex = 15;
            this.bunifuLabel6.Text = "Created By:";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.Location = new System.Drawing.Point(164, 245);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(156, 24);
            this.bunifuLabel5.TabIndex = 14;
            this.bunifuLabel5.Text = "Application Fees:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.Location = new System.Drawing.Point(195, 201);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(125, 24);
            this.bunifuLabel4.TabIndex = 13;
            this.bunifuLabel4.Text = "License Class:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.Location = new System.Drawing.Point(161, 157);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(159, 24);
            this.bunifuLabel3.TabIndex = 12;
            this.bunifuLabel3.Text = "Application Date:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblAppID
            // 
            this.lblAppID.AllowParentOverrides = false;
            this.lblAppID.AutoEllipsis = false;
            this.lblAppID.CursorType = null;
            this.lblAppID.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppID.ForeColor = System.Drawing.Color.Red;
            this.lblAppID.Location = new System.Drawing.Point(481, 40);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppID.Size = new System.Drawing.Size(51, 39);
            this.lblAppID.TabIndex = 7;
            this.lblAppID.Text = "N/A";
            this.lblAppID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(273, 42);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(200, 37);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "ApplicationID: ";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AllowParentOverrides = false;
            this.lblMainTitle.AutoEllipsis = false;
            this.lblMainTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMainTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblMainTitle.Font = new System.Drawing.Font("Univers 57 Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(176, 24);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMainTitle.Size = new System.Drawing.Size(509, 39);
            this.lblMainTitle.TabIndex = 7;
            this.lblMainTitle.Text = "New Local Driving License Application";
            this.lblMainTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblMainTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ctrlPersonInfoWithFilter1
            // 
            this.ctrlPersonInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(843, 473);
            this.ctrlPersonInfoWithFilter1.TabIndex = 2;
            // 
            // frmAddNewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 712);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "frmAddNewApplication";
            this.Text = "clsAddNewApplication";
            this.Load += new System.EventHandler(this.frmAddNewApplication_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabLoginInfo.ResumeLayout(false);
            this.tabLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveUser;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private User.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNext;
        private System.Windows.Forms.TabPage tabLoginInfo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lblMainTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblCreatedBy;
        private Bunifu.UI.WinForms.BunifuLabel lblAppFees;
        private Bunifu.UI.WinForms.BunifuDropdown drbLicenseClass;
        private Bunifu.UI.WinForms.BunifuLabel lblAppDate;
        private Bunifu.UI.WinForms.BunifuLabel lblAppID;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}