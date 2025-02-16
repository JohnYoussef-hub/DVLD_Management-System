namespace DVLD_Project.Person
{
    partial class ctrlpeopleDataTableWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlpeopleDataTableWithFilter));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.drdFilterBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ctrlPeopleDataTable1 = new DVLD_Project.Person.ctrlPeopleDataTable();
            this.txtFilterBy = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // drdFilterBy
            // 
            this.drdFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.drdFilterBy.BackgroundColor = System.Drawing.Color.White;
            this.drdFilterBy.BorderColor = System.Drawing.Color.Silver;
            this.drdFilterBy.BorderRadius = 1;
            this.drdFilterBy.Color = System.Drawing.Color.Silver;
            this.drdFilterBy.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drdFilterBy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drdFilterBy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drdFilterBy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drdFilterBy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drdFilterBy.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drdFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drdFilterBy.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drdFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drdFilterBy.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drdFilterBy.FillDropDown = true;
            this.drdFilterBy.FillIndicator = false;
            this.drdFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drdFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.drdFilterBy.ForeColor = System.Drawing.Color.Black;
            this.drdFilterBy.FormattingEnabled = true;
            this.drdFilterBy.Icon = null;
            this.drdFilterBy.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drdFilterBy.IndicatorColor = System.Drawing.Color.Gray;
            this.drdFilterBy.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drdFilterBy.ItemBackColor = System.Drawing.Color.White;
            this.drdFilterBy.ItemBorderColor = System.Drawing.Color.White;
            this.drdFilterBy.ItemForeColor = System.Drawing.Color.Black;
            this.drdFilterBy.ItemHeight = 26;
            this.drdFilterBy.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.drdFilterBy.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drdFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.drdFilterBy.ItemTopMargin = 3;
            this.drdFilterBy.Location = new System.Drawing.Point(201, 56);
            this.drdFilterBy.Name = "drdFilterBy";
            this.drdFilterBy.Size = new System.Drawing.Size(101, 32);
            this.drdFilterBy.TabIndex = 1;
            this.drdFilterBy.Text = null;
            this.drdFilterBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drdFilterBy.TextLeftMargin = 5;
            this.drdFilterBy.SelectedIndexChanged += new System.EventHandler(this.drdFilterBy_SelectedIndexChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(51, 53);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(140, 32);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Filter By:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ctrlPeopleDataTable1
            // 
            this.ctrlPeopleDataTable1.Location = new System.Drawing.Point(0, 91);
            this.ctrlPeopleDataTable1.Name = "ctrlPeopleDataTable1";
            this.ctrlPeopleDataTable1.Size = new System.Drawing.Size(1612, 385);
            this.ctrlPeopleDataTable1.TabIndex = 3;
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.AcceptsReturn = false;
            this.txtFilterBy.AcceptsTab = false;
            this.txtFilterBy.AnimationSpeed = 200;
            this.txtFilterBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFilterBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterBy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFilterBy.BackgroundImage")));
            this.txtFilterBy.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFilterBy.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFilterBy.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFilterBy.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFilterBy.BorderRadius = 1;
            this.txtFilterBy.BorderThickness = 1;
            this.txtFilterBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFilterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFilterBy.DefaultText = "";
            this.txtFilterBy.FillColor = System.Drawing.Color.White;
            this.txtFilterBy.HideSelection = true;
            this.txtFilterBy.IconLeft = null;
            this.txtFilterBy.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.IconPadding = 10;
            this.txtFilterBy.IconRight = null;
            this.txtFilterBy.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.Lines = new string[0];
            this.txtFilterBy.Location = new System.Drawing.Point(322, 56);
            this.txtFilterBy.MaxLength = 32767;
            this.txtFilterBy.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFilterBy.Modified = false;
            this.txtFilterBy.Multiline = false;
            this.txtFilterBy.Name = "txtFilterBy";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterBy.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFilterBy.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterBy.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterBy.OnIdleState = stateProperties4;
            this.txtFilterBy.Padding = new System.Windows.Forms.Padding(3);
            this.txtFilterBy.PasswordChar = '\0';
            this.txtFilterBy.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFilterBy.PlaceholderText = "Write something to filter";
            this.txtFilterBy.ReadOnly = false;
            this.txtFilterBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilterBy.SelectedText = "";
            this.txtFilterBy.SelectionLength = 0;
            this.txtFilterBy.SelectionStart = 0;
            this.txtFilterBy.ShortcutsEnabled = true;
            this.txtFilterBy.Size = new System.Drawing.Size(225, 32);
            this.txtFilterBy.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFilterBy.TabIndex = 4;
            this.txtFilterBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterBy.TextMarginBottom = 0;
            this.txtFilterBy.TextMarginLeft = 3;
            this.txtFilterBy.TextMarginTop = 0;
            this.txtFilterBy.TextPlaceholder = "Write something to filter";
            this.txtFilterBy.UseSystemPasswordChar = false;
            this.txtFilterBy.WordWrap = true;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            // 
            // ctrlpeopleDataTableWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.ctrlPeopleDataTable1);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.drdFilterBy);
            this.Name = "ctrlpeopleDataTableWithFilter";
            this.Size = new System.Drawing.Size(1612, 490);
            this.Load += new System.EventHandler(this.ctrlpeopleDataTableWithFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDropdown drdFilterBy;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private ctrlPeopleDataTable ctrlPeopleDataTable1;
        private Bunifu.UI.WinForms.BunifuTextBox txtFilterBy;
    }
}
