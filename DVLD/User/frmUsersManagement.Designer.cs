namespace DVLD_Project.User
{
    partial class frmUsersManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.UsersDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.drdFilterBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtFilterBy = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAddMngUsers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Kelson Sans", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel1.Location = new System.Drawing.Point(362, 145);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(410, 77);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Manage Users";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UsersDataGridView1
            // 
            this.UsersDataGridView1.AllowCustomTheming = false;
            this.UsersDataGridView1.AllowUserToAddRows = false;
            this.UsersDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.UsersDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersDataGridView1.ColumnHeadersHeight = 40;
            this.UsersDataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.UsersDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.UsersDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.UsersDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.UsersDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.UsersDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UsersDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.UsersDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.UsersDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.UsersDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.UsersDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.UsersDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.UsersDataGridView1.CurrentTheme.Name = null;
            this.UsersDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.UsersDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.UsersDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.UsersDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersDataGridView1.EnableHeadersVisualStyles = false;
            this.UsersDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.UsersDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.UsersDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.UsersDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.UsersDataGridView1.Location = new System.Drawing.Point(32, 341);
            this.UsersDataGridView1.Name = "UsersDataGridView1";
            this.UsersDataGridView1.ReadOnly = true;
            this.UsersDataGridView1.RowHeadersVisible = false;
            this.UsersDataGridView1.RowTemplate.Height = 40;
            this.UsersDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGridView1.Size = new System.Drawing.Size(1076, 314);
            this.UsersDataGridView1.TabIndex = 6;
            this.UsersDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.UsersDataGridView1.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.UsersDataGridView1_ColumnRemoved);
            this.UsersDataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.UsersDataGridView1_RowsAdded);
            this.UsersDataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.UsersDataGridView1_RowsRemoved);
            this.UsersDataGridView1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.UsersDataGridView1_ControlAdded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.ChangePassToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 98);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.details;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.editing;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.delete1;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ChangePassToolStripMenuItem
            // 
            this.ChangePassToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.editPass;
            this.ChangePassToolStripMenuItem.Name = "ChangePassToolStripMenuItem";
            this.ChangePassToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ChangePassToolStripMenuItem.Text = "Change Password";
            this.ChangePassToolStripMenuItem.Click += new System.EventHandler(this.ChangePassToolStripMenuItem_Click);
            // 
            // lblCount
            // 
            this.lblCount.AllowParentOverrides = false;
            this.lblCount.AutoEllipsis = false;
            this.lblCount.CursorType = null;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(155, 681);
            this.lblCount.Name = "lblCount";
            this.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCount.Size = new System.Drawing.Size(12, 30);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "0";
            this.lblCount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(47, 681);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(102, 30);
            this.bunifuLabel2.TabIndex = 8;
            this.bunifuLabel2.Text = "# Records: ";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(47, 294);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(140, 32);
            this.bunifuLabel3.TabIndex = 11;
            this.bunifuLabel3.Text = "Filter By:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            "User ID",
            "Person ID",
            "Full Name",
            "User Name",
            "Is Active"});
            this.drdFilterBy.ItemTopMargin = 3;
            this.drdFilterBy.Location = new System.Drawing.Point(197, 297);
            this.drdFilterBy.Name = "drdFilterBy";
            this.drdFilterBy.Size = new System.Drawing.Size(101, 32);
            this.drdFilterBy.TabIndex = 10;
            this.drdFilterBy.Text = null;
            this.drdFilterBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drdFilterBy.TextLeftMargin = 5;
            this.drdFilterBy.SelectedIndexChanged += new System.EventHandler(this.drdFilterBy_SelectedIndexChanged);
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
            this.txtFilterBy.Location = new System.Drawing.Point(318, 297);
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
            this.txtFilterBy.TabIndex = 12;
            this.txtFilterBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterBy.TextMarginBottom = 0;
            this.txtFilterBy.TextMarginLeft = 3;
            this.txtFilterBy.TextMarginTop = 0;
            this.txtFilterBy.TextPlaceholder = "Write something to filter";
            this.txtFilterBy.UseSystemPasswordChar = false;
            this.txtFilterBy.WordWrap = true;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
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
            this.btnClose.Location = new System.Drawing.Point(974, 690);
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
            this.btnClose.TabIndex = 7;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddMngUsers
            // 
            this.btnAddMngUsers.AllowAnimations = true;
            this.btnAddMngUsers.AllowMouseEffects = true;
            this.btnAddMngUsers.AllowToggling = false;
            this.btnAddMngUsers.AnimationSpeed = 200;
            this.btnAddMngUsers.AutoGenerateColors = false;
            this.btnAddMngUsers.AutoRoundBorders = false;
            this.btnAddMngUsers.AutoSizeLeftIcon = true;
            this.btnAddMngUsers.AutoSizeRightIcon = true;
            this.btnAddMngUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMngUsers.BackColor1 = System.Drawing.Color.MediumPurple;
            this.btnAddMngUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMngUsers.BackgroundImage")));
            this.btnAddMngUsers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMngUsers.ButtonText = "      Add";
            this.btnAddMngUsers.ButtonTextMarginLeft = 0;
            this.btnAddMngUsers.ColorContrastOnClick = 45;
            this.btnAddMngUsers.ColorContrastOnHover = 45;
            this.btnAddMngUsers.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddMngUsers.CustomizableEdges = borderEdges2;
            this.btnAddMngUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddMngUsers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddMngUsers.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddMngUsers.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddMngUsers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddMngUsers.Font = new System.Drawing.Font("Kelson Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMngUsers.ForeColor = System.Drawing.Color.White;
            this.btnAddMngUsers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMngUsers.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddMngUsers.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddMngUsers.IconMarginLeft = 11;
            this.btnAddMngUsers.IconPadding = 10;
            this.btnAddMngUsers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMngUsers.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddMngUsers.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddMngUsers.IconSize = 25;
            this.btnAddMngUsers.IdleBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddMngUsers.IdleBorderRadius = 1;
            this.btnAddMngUsers.IdleBorderThickness = 1;
            this.btnAddMngUsers.IdleFillColor = System.Drawing.Color.MediumPurple;
            this.btnAddMngUsers.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.Add_User_Male;
            this.btnAddMngUsers.IdleIconRightImage = null;
            this.btnAddMngUsers.IndicateFocus = false;
            this.btnAddMngUsers.Location = new System.Drawing.Point(991, 284);
            this.btnAddMngUsers.Name = "btnAddMngUsers";
            this.btnAddMngUsers.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddMngUsers.OnDisabledState.BorderRadius = 1;
            this.btnAddMngUsers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMngUsers.OnDisabledState.BorderThickness = 1;
            this.btnAddMngUsers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddMngUsers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddMngUsers.OnDisabledState.IconLeftImage = null;
            this.btnAddMngUsers.OnDisabledState.IconRightImage = null;
            this.btnAddMngUsers.onHoverState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnAddMngUsers.onHoverState.BorderRadius = 1;
            this.btnAddMngUsers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMngUsers.onHoverState.BorderThickness = 1;
            this.btnAddMngUsers.onHoverState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnAddMngUsers.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddMngUsers.onHoverState.IconLeftImage = null;
            this.btnAddMngUsers.onHoverState.IconRightImage = null;
            this.btnAddMngUsers.OnIdleState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddMngUsers.OnIdleState.BorderRadius = 1;
            this.btnAddMngUsers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMngUsers.OnIdleState.BorderThickness = 1;
            this.btnAddMngUsers.OnIdleState.FillColor = System.Drawing.Color.MediumPurple;
            this.btnAddMngUsers.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddMngUsers.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.Add_User_Male;
            this.btnAddMngUsers.OnIdleState.IconRightImage = null;
            this.btnAddMngUsers.OnPressedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnAddMngUsers.OnPressedState.BorderRadius = 1;
            this.btnAddMngUsers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMngUsers.OnPressedState.BorderThickness = 1;
            this.btnAddMngUsers.OnPressedState.FillColor = System.Drawing.Color.MediumPurple;
            this.btnAddMngUsers.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddMngUsers.OnPressedState.IconLeftImage = null;
            this.btnAddMngUsers.OnPressedState.IconRightImage = null;
            this.btnAddMngUsers.Size = new System.Drawing.Size(96, 42);
            this.btnAddMngUsers.TabIndex = 5;
            this.btnAddMngUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddMngUsers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddMngUsers.TextMarginLeft = 0;
            this.btnAddMngUsers.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddMngUsers.UseDefaultRadiusAndThickness = true;
            this.btnAddMngUsers.Click += new System.EventHandler(this.btnAddMngUsers_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 80;
            this.bunifuPictureBox1.Image = global::DVLD_Project.Properties.Resources.Group;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(484, 1);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(161, 161);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 755);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.drdFilterBy);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.UsersDataGridView1);
            this.Controls.Add(this.btnAddMngUsers);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Name = "frmUsersManagement";
            this.Text = "frmUsersManagement";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddMngUsers;
        private Bunifu.UI.WinForms.BunifuDataGridView UsersDataGridView1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private Bunifu.UI.WinForms.BunifuLabel lblCount;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuTextBox txtFilterBy;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuDropdown drdFilterBy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePassToolStripMenuItem;
    }
}