namespace DVLD_Project.User.Controls
{
    partial class ctrlPersonInfoWithFilter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonInfoWithFilter));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.pbAdd = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbSearch = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtFindBy = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dropFindBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ctrlPersonInformation1 = new DVLD_Project.Person.ctrlPersonInformation();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.pbAdd);
            this.bunifuGroupBox1.Controls.Add(this.pbSearch);
            this.bunifuGroupBox1.Controls.Add(this.txtFindBy);
            this.bunifuGroupBox1.Controls.Add(this.dropFindBy);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel1);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Kelson Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(16, 12);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(804, 107);
            this.bunifuGroupBox1.TabIndex = 0;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Filter";
            this.bunifuToolTip1.SetToolTip(this.bunifuGroupBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuGroupBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuGroupBox1, "");
            // 
            // pbAdd
            // 
            this.pbAdd.AccessibleDescription = "";
            this.pbAdd.AllowFocused = false;
            this.pbAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAdd.AutoSizeHeight = true;
            this.pbAdd.BorderRadius = 0;
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::DVLD_Project.Properties.Resources.Add_User_Male1;
            this.pbAdd.IsCircle = true;
            this.pbAdd.Location = new System.Drawing.Point(560, 36);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(42, 42);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 4;
            this.pbAdd.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pbAdd, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pbAdd, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pbAdd, "");
            this.pbAdd.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.AllowFocused = false;
            this.pbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSearch.AutoSizeHeight = true;
            this.pbSearch.BorderRadius = 0;
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::DVLD_Project.Properties.Resources.Find_User_Male;
            this.pbSearch.IsCircle = true;
            this.pbSearch.Location = new System.Drawing.Point(498, 36);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(42, 42);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 3;
            this.pbSearch.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pbSearch, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pbSearch, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pbSearch, "");
            this.pbSearch.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // txtFindBy
            // 
            this.txtFindBy.AcceptsReturn = false;
            this.txtFindBy.AcceptsTab = false;
            this.txtFindBy.AnimationSpeed = 200;
            this.txtFindBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFindBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFindBy.BackColor = System.Drawing.Color.White;
            this.txtFindBy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFindBy.BackgroundImage")));
            this.txtFindBy.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFindBy.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFindBy.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFindBy.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFindBy.BorderRadius = 1;
            this.txtFindBy.BorderThickness = 1;
            this.txtFindBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFindBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindBy.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFindBy.DefaultText = "";
            this.txtFindBy.FillColor = System.Drawing.Color.White;
            this.txtFindBy.HideSelection = true;
            this.txtFindBy.IconLeft = null;
            this.txtFindBy.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindBy.IconPadding = 10;
            this.txtFindBy.IconRight = null;
            this.txtFindBy.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindBy.Lines = new string[0];
            this.txtFindBy.Location = new System.Drawing.Point(281, 43);
            this.txtFindBy.MaxLength = 32767;
            this.txtFindBy.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFindBy.Modified = false;
            this.txtFindBy.Multiline = false;
            this.txtFindBy.Name = "txtFindBy";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFindBy.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFindBy.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFindBy.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFindBy.OnIdleState = stateProperties4;
            this.txtFindBy.Padding = new System.Windows.Forms.Padding(3);
            this.txtFindBy.PasswordChar = '\0';
            this.txtFindBy.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFindBy.PlaceholderText = "Enter text";
            this.txtFindBy.ReadOnly = false;
            this.txtFindBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFindBy.SelectedText = "";
            this.txtFindBy.SelectionLength = 0;
            this.txtFindBy.SelectionStart = 0;
            this.txtFindBy.ShortcutsEnabled = true;
            this.txtFindBy.Size = new System.Drawing.Size(194, 32);
            this.txtFindBy.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFindBy.TabIndex = 2;
            this.txtFindBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFindBy.TextMarginBottom = 0;
            this.txtFindBy.TextMarginLeft = 3;
            this.txtFindBy.TextMarginTop = 0;
            this.txtFindBy.TextPlaceholder = "Enter text";
            this.bunifuToolTip1.SetToolTip(this.txtFindBy, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtFindBy, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtFindBy, "");
            this.txtFindBy.UseSystemPasswordChar = false;
            this.txtFindBy.WordWrap = true;
            // 
            // dropFindBy
            // 
            this.dropFindBy.BackColor = System.Drawing.Color.Transparent;
            this.dropFindBy.BackgroundColor = System.Drawing.Color.White;
            this.dropFindBy.BorderColor = System.Drawing.Color.Silver;
            this.dropFindBy.BorderRadius = 1;
            this.dropFindBy.Color = System.Drawing.Color.Silver;
            this.dropFindBy.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropFindBy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropFindBy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropFindBy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropFindBy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropFindBy.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropFindBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropFindBy.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropFindBy.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropFindBy.FillDropDown = true;
            this.dropFindBy.FillIndicator = false;
            this.dropFindBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropFindBy.ForeColor = System.Drawing.Color.Black;
            this.dropFindBy.FormattingEnabled = true;
            this.dropFindBy.Icon = null;
            this.dropFindBy.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropFindBy.IndicatorColor = System.Drawing.Color.Gray;
            this.dropFindBy.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropFindBy.IntegralHeight = false;
            this.dropFindBy.ItemBackColor = System.Drawing.Color.White;
            this.dropFindBy.ItemBorderColor = System.Drawing.Color.White;
            this.dropFindBy.ItemForeColor = System.Drawing.Color.Black;
            this.dropFindBy.ItemHeight = 26;
            this.dropFindBy.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropFindBy.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropFindBy.Items.AddRange(new object[] {
            "none",
            "Person ID",
            "National Number"});
            this.dropFindBy.ItemTopMargin = 3;
            this.dropFindBy.Location = new System.Drawing.Point(137, 43);
            this.dropFindBy.Name = "dropFindBy";
            this.dropFindBy.Size = new System.Drawing.Size(133, 32);
            this.dropFindBy.TabIndex = 1;
            this.dropFindBy.Text = null;
            this.dropFindBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropFindBy.TextLeftMargin = 5;
            this.bunifuToolTip1.SetToolTip(this.dropFindBy, "");
            this.bunifuToolTip1.SetToolTipIcon(this.dropFindBy, null);
            this.bunifuToolTip1.SetToolTipTitle(this.dropFindBy, "");
            this.dropFindBy.SelectedIndexChanged += new System.EventHandler(this.dropFindBy_SelectedIndexChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(41, 43);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(81, 29);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Find By: ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel1, "");
            // 
            // ctrlPersonInformation1
            // 
            this.ctrlPersonInformation1.Location = new System.Drawing.Point(-1, 121);
            this.ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            this.ctrlPersonInformation1.Size = new System.Drawing.Size(844, 364);
            this.ctrlPersonInformation1.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.ctrlPersonInformation1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.ctrlPersonInformation1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ctrlPersonInformation1, "");
            this.ctrlPersonInformation1.Load += new System.EventHandler(this.ctrlPersonInformation1_Load);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // ctrlPersonInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonInformation1);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Name = "ctrlPersonInfoWithFilter";
            this.Size = new System.Drawing.Size(836, 475);
            this.bunifuToolTip1.SetToolTip(this, "");
            this.bunifuToolTip1.SetToolTipIcon(this, null);
            this.bunifuToolTip1.SetToolTipTitle(this, "");
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtFindBy;
        private Bunifu.UI.WinForms.BunifuDropdown dropFindBy;
        private Bunifu.UI.WinForms.BunifuPictureBox pbSearch;
        private Bunifu.UI.WinForms.BunifuPictureBox pbAdd;
        private Person.ctrlPersonInformation ctrlPersonInformation1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
    }
}
