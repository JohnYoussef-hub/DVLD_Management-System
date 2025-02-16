namespace DVLD_Project.License.Controls
{
    partial class ctrlLicenseInfoWithFilter
    {

        #region Component Designer generated code

        #endregion

        private ctrlLicenseInfo ctrlLicenseInfo1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDropdown drbFindBy;
        private Bunifu.UI.WinForms.BunifuTextBox txtFindBy;
        private Bunifu.UI.WinForms.BunifuPictureBox pbSearch;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlLicenseInfoWithFilter));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.drbFindBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtFindBy = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pbSearch = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.ctrlLicenseInfo1 = new DVLD_Project.License.Controls.ctrlLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.bunifuGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(66, 31);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(104, 27);
            this.bunifuLabel2.TabIndex = 6;
            this.bunifuLabel2.Text = "Search By:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // drbFindBy
            // 
            this.drbFindBy.BackColor = System.Drawing.Color.Transparent;
            this.drbFindBy.BackgroundColor = System.Drawing.Color.White;
            this.drbFindBy.BorderColor = System.Drawing.Color.Silver;
            this.drbFindBy.BorderRadius = 1;
            this.drbFindBy.Color = System.Drawing.Color.Silver;
            this.drbFindBy.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drbFindBy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drbFindBy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drbFindBy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drbFindBy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drbFindBy.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drbFindBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drbFindBy.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drbFindBy.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drbFindBy.FillDropDown = true;
            this.drbFindBy.FillIndicator = false;
            this.drbFindBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drbFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.drbFindBy.ForeColor = System.Drawing.Color.Black;
            this.drbFindBy.FormattingEnabled = true;
            this.drbFindBy.Icon = null;
            this.drbFindBy.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drbFindBy.IndicatorColor = System.Drawing.Color.Gray;
            this.drbFindBy.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drbFindBy.ItemBackColor = System.Drawing.Color.White;
            this.drbFindBy.ItemBorderColor = System.Drawing.Color.White;
            this.drbFindBy.ItemForeColor = System.Drawing.Color.Black;
            this.drbFindBy.ItemHeight = 26;
            this.drbFindBy.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.drbFindBy.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drbFindBy.Items.AddRange(new object[] {
            "None",
            "LicenseID"});
            this.drbFindBy.ItemTopMargin = 3;
            this.drbFindBy.Location = new System.Drawing.Point(189, 29);
            this.drbFindBy.Name = "drbFindBy";
            this.drbFindBy.Size = new System.Drawing.Size(126, 32);
            this.drbFindBy.TabIndex = 7;
            this.drbFindBy.Text = null;
            this.drbFindBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drbFindBy.TextLeftMargin = 5;
            this.drbFindBy.SelectedIndexChanged += new System.EventHandler(this.dropFindBy_SelectedIndexChanged);
            // 
            // txtFindBy
            // 
            this.txtFindBy.AcceptsReturn = false;
            this.txtFindBy.AcceptsTab = false;
            this.txtFindBy.AnimationSpeed = 200;
            this.txtFindBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFindBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFindBy.BackColor = System.Drawing.Color.Transparent;
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
            this.txtFindBy.Location = new System.Drawing.Point(330, 27);
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
            this.txtFindBy.Size = new System.Drawing.Size(168, 37);
            this.txtFindBy.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFindBy.TabIndex = 8;
            this.txtFindBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFindBy.TextMarginBottom = 0;
            this.txtFindBy.TextMarginLeft = 3;
            this.txtFindBy.TextMarginTop = 0;
            this.txtFindBy.TextPlaceholder = "Enter text";
            this.txtFindBy.UseSystemPasswordChar = false;
            this.txtFindBy.WordWrap = true;
            // 
            // pbSearch
            // 
            this.pbSearch.AccessibleDescription = "";
            this.pbSearch.AllowFocused = false;
            this.pbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSearch.AutoSizeHeight = true;
            this.pbSearch.BorderRadius = 0;
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::DVLD_Project.Properties.Resources.Find_User_Male;
            this.pbSearch.IsCircle = true;
            this.pbSearch.Location = new System.Drawing.Point(531, 22);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(42, 42);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 9;
            this.pbSearch.TabStop = false;
            this.pbSearch.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.pbSearch);
            this.bunifuGroupBox2.Controls.Add(this.txtFindBy);
            this.bunifuGroupBox2.Controls.Add(this.drbFindBy);
            this.bunifuGroupBox2.Controls.Add(this.bunifuLabel2);
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(14, 14);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(776, 76);
            this.bunifuGroupBox2.TabIndex = 10;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = "Search";
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(6, 110);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(800, 470);
            this.ctrlLicenseInfo1.TabIndex = 0;
            // 
            // ctrlLicenseInfoWithFilter
            // 
            this.Controls.Add(this.bunifuGroupBox2);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Name = "ctrlLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(806, 557);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
