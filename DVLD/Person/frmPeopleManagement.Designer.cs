namespace DVLD_Project.Person
{
    partial class frmPeopleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleManagement));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnAddMngPeople = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ctrlpeopleDataTableWithFilter1 = new DVLD_Project.Person.ctrlpeopleDataTableWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Kelson Sans", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(554, 108);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(444, 77);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Manage People";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.btnClose.ForeColor = System.Drawing.Color.White;
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
            this.btnClose.Location = new System.Drawing.Point(1421, 679);
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
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.Cancel;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.BorderRadius = 1;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(113, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 47;
            this.bunifuPictureBox1.Image = global::DVLD_Project.Properties.Resources.User_Group_Skin_Type_7;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(729, 7);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(95, 95);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnAddMngPeople
            // 
            this.btnAddMngPeople.AllowAnimations = true;
            this.btnAddMngPeople.AllowMouseEffects = true;
            this.btnAddMngPeople.AllowToggling = false;
            this.btnAddMngPeople.AnimationSpeed = 200;
            this.btnAddMngPeople.AutoGenerateColors = false;
            this.btnAddMngPeople.AutoRoundBorders = false;
            this.btnAddMngPeople.AutoSizeLeftIcon = true;
            this.btnAddMngPeople.AutoSizeRightIcon = true;
            this.btnAddMngPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMngPeople.BackColor1 = System.Drawing.Color.MediumPurple;
            this.btnAddMngPeople.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMngPeople.BackgroundImage")));
            this.btnAddMngPeople.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMngPeople.ButtonText = "      Add";
            this.btnAddMngPeople.ButtonTextMarginLeft = 0;
            this.btnAddMngPeople.ColorContrastOnClick = 45;
            this.btnAddMngPeople.ColorContrastOnHover = 45;
            this.btnAddMngPeople.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddMngPeople.CustomizableEdges = borderEdges2;
            this.btnAddMngPeople.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddMngPeople.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddMngPeople.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddMngPeople.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddMngPeople.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddMngPeople.Font = new System.Drawing.Font("Kelson Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMngPeople.ForeColor = System.Drawing.Color.White;
            this.btnAddMngPeople.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMngPeople.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddMngPeople.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddMngPeople.IconMarginLeft = 11;
            this.btnAddMngPeople.IconPadding = 10;
            this.btnAddMngPeople.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMngPeople.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddMngPeople.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddMngPeople.IconSize = 25;
            this.btnAddMngPeople.IdleBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddMngPeople.IdleBorderRadius = 1;
            this.btnAddMngPeople.IdleBorderThickness = 1;
            this.btnAddMngPeople.IdleFillColor = System.Drawing.Color.MediumPurple;
            this.btnAddMngPeople.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.Add_User_Male;
            this.btnAddMngPeople.IdleIconRightImage = null;
            this.btnAddMngPeople.IndicateFocus = false;
            this.btnAddMngPeople.Location = new System.Drawing.Point(1438, 249);
            this.btnAddMngPeople.Name = "btnAddMngPeople";
            this.btnAddMngPeople.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddMngPeople.OnDisabledState.BorderRadius = 1;
            this.btnAddMngPeople.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMngPeople.OnDisabledState.BorderThickness = 1;
            this.btnAddMngPeople.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddMngPeople.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddMngPeople.OnDisabledState.IconLeftImage = null;
            this.btnAddMngPeople.OnDisabledState.IconRightImage = null;
            this.btnAddMngPeople.onHoverState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnAddMngPeople.onHoverState.BorderRadius = 1;
            this.btnAddMngPeople.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMngPeople.onHoverState.BorderThickness = 1;
            this.btnAddMngPeople.onHoverState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnAddMngPeople.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddMngPeople.onHoverState.IconLeftImage = null;
            this.btnAddMngPeople.onHoverState.IconRightImage = null;
            this.btnAddMngPeople.OnIdleState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddMngPeople.OnIdleState.BorderRadius = 1;
            this.btnAddMngPeople.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMngPeople.OnIdleState.BorderThickness = 1;
            this.btnAddMngPeople.OnIdleState.FillColor = System.Drawing.Color.MediumPurple;
            this.btnAddMngPeople.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddMngPeople.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.Add_User_Male;
            this.btnAddMngPeople.OnIdleState.IconRightImage = null;
            this.btnAddMngPeople.OnPressedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnAddMngPeople.OnPressedState.BorderRadius = 1;
            this.btnAddMngPeople.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMngPeople.OnPressedState.BorderThickness = 1;
            this.btnAddMngPeople.OnPressedState.FillColor = System.Drawing.Color.MediumPurple;
            this.btnAddMngPeople.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddMngPeople.OnPressedState.IconLeftImage = null;
            this.btnAddMngPeople.OnPressedState.IconRightImage = null;
            this.btnAddMngPeople.Size = new System.Drawing.Size(96, 42);
            this.btnAddMngPeople.TabIndex = 4;
            this.btnAddMngPeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddMngPeople.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddMngPeople.TextMarginLeft = 0;
            this.btnAddMngPeople.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddMngPeople.UseDefaultRadiusAndThickness = true;
            this.btnAddMngPeople.Click += new System.EventHandler(this.btnAddMngPeople_Click);
            // 
            // ctrlpeopleDataTableWithFilter1
            // 
            this.ctrlpeopleDataTableWithFilter1.Location = new System.Drawing.Point(-9, 196);
            this.ctrlpeopleDataTableWithFilter1.Name = "ctrlpeopleDataTableWithFilter1";
            this.ctrlpeopleDataTableWithFilter1.Size = new System.Drawing.Size(1612, 482);
            this.ctrlpeopleDataTableWithFilter1.TabIndex = 2;
            // 
            // frmPeopleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 753);
            this.Controls.Add(this.btnAddMngPeople);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlpeopleDataTableWithFilter1);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Name = "frmPeopleManagement";
            this.Text = "frmPeopleManagement";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private ctrlpeopleDataTableWithFilter ctrlpeopleDataTableWithFilter1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddMngPeople;
    }
}