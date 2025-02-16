namespace DVLD_Project.Test_Appointments
{
    partial class frmTestAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblMainTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvTestAppointments = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAppo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pbMain = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ctrlTestAppointmentsInfo1 = new DVLD_Project.Test_Appointments.controls.ctrlTestAppointmentsInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AllowParentOverrides = false;
            this.lblMainTitle.AutoEllipsis = false;
            this.lblMainTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMainTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblMainTitle.Font = new System.Drawing.Font("Trebuchet MS", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(213, 33);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMainTitle.Size = new System.Drawing.Size(486, 54);
            this.lblMainTitle.TabIndex = 5;
            this.lblMainTitle.Text = "????? Test Appointments";
            this.lblMainTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblMainTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(33, 517);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(142, 27);
            this.bunifuLabel2.TabIndex = 7;
            this.bunifuLabel2.Text = "Appointments:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvTestAppointments
            // 
            this.dgvTestAppointments.AllowCustomTheming = false;
            this.dgvTestAppointments.AllowUserToAddRows = false;
            this.dgvTestAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTestAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTestAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTestAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestAppointments.ColumnHeadersHeight = 40;
            this.dgvTestAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestAppointments.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvTestAppointments.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTestAppointments.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTestAppointments.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTestAppointments.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTestAppointments.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvTestAppointments.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTestAppointments.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTestAppointments.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTestAppointments.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTestAppointments.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvTestAppointments.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTestAppointments.CurrentTheme.Name = null;
            this.dgvTestAppointments.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTestAppointments.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTestAppointments.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTestAppointments.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTestAppointments.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestAppointments.EnableHeadersVisualStyles = false;
            this.dgvTestAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTestAppointments.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTestAppointments.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTestAppointments.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTestAppointments.Location = new System.Drawing.Point(33, 560);
            this.dgvTestAppointments.Name = "dgvTestAppointments";
            this.dgvTestAppointments.ReadOnly = true;
            this.dgvTestAppointments.RowHeadersVisible = false;
            this.dgvTestAppointments.RowTemplate.Height = 40;
            this.dgvTestAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestAppointments.Size = new System.Drawing.Size(794, 278);
            this.dgvTestAppointments.TabIndex = 8;
            this.dgvTestAppointments.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 56);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.takeTest1;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // btnAddAppo
            // 
            this.btnAddAppo.AllowAnimations = true;
            this.btnAddAppo.AllowMouseEffects = true;
            this.btnAddAppo.AllowToggling = false;
            this.btnAddAppo.AnimationSpeed = 200;
            this.btnAddAppo.AutoGenerateColors = false;
            this.btnAddAppo.AutoRoundBorders = false;
            this.btnAddAppo.AutoSizeLeftIcon = true;
            this.btnAddAppo.AutoSizeRightIcon = true;
            this.btnAddAppo.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAppo.BackColor1 = System.Drawing.Color.MediumPurple;
            this.btnAddAppo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAppo.BackgroundImage")));
            this.btnAddAppo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddAppo.ButtonText = "      Add new appointment";
            this.btnAddAppo.ButtonTextMarginLeft = 0;
            this.btnAddAppo.ColorContrastOnClick = 45;
            this.btnAddAppo.ColorContrastOnHover = 45;
            this.btnAddAppo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddAppo.CustomizableEdges = borderEdges1;
            this.btnAddAppo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddAppo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddAppo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddAppo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddAppo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddAppo.Font = new System.Drawing.Font("Kelson Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppo.ForeColor = System.Drawing.Color.White;
            this.btnAddAppo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAppo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddAppo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddAppo.IconMarginLeft = 11;
            this.btnAddAppo.IconPadding = 10;
            this.btnAddAppo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAppo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddAppo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddAppo.IconSize = 25;
            this.btnAddAppo.IdleBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddAppo.IdleBorderRadius = 1;
            this.btnAddAppo.IdleBorderThickness = 1;
            this.btnAddAppo.IdleFillColor = System.Drawing.Color.MediumPurple;
            this.btnAddAppo.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.manageLicenses;
            this.btnAddAppo.IdleIconRightImage = null;
            this.btnAddAppo.IndicateFocus = false;
            this.btnAddAppo.Location = new System.Drawing.Point(612, 499);
            this.btnAddAppo.Name = "btnAddAppo";
            this.btnAddAppo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddAppo.OnDisabledState.BorderRadius = 1;
            this.btnAddAppo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddAppo.OnDisabledState.BorderThickness = 1;
            this.btnAddAppo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddAppo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddAppo.OnDisabledState.IconLeftImage = null;
            this.btnAddAppo.OnDisabledState.IconRightImage = null;
            this.btnAddAppo.onHoverState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnAddAppo.onHoverState.BorderRadius = 1;
            this.btnAddAppo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddAppo.onHoverState.BorderThickness = 1;
            this.btnAddAppo.onHoverState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnAddAppo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddAppo.onHoverState.IconLeftImage = null;
            this.btnAddAppo.onHoverState.IconRightImage = null;
            this.btnAddAppo.OnIdleState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddAppo.OnIdleState.BorderRadius = 1;
            this.btnAddAppo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddAppo.OnIdleState.BorderThickness = 1;
            this.btnAddAppo.OnIdleState.FillColor = System.Drawing.Color.MediumPurple;
            this.btnAddAppo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddAppo.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.manageLicenses;
            this.btnAddAppo.OnIdleState.IconRightImage = null;
            this.btnAddAppo.OnPressedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnAddAppo.OnPressedState.BorderRadius = 1;
            this.btnAddAppo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddAppo.OnPressedState.BorderThickness = 1;
            this.btnAddAppo.OnPressedState.FillColor = System.Drawing.Color.MediumPurple;
            this.btnAddAppo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddAppo.OnPressedState.IconLeftImage = null;
            this.btnAddAppo.OnPressedState.IconRightImage = null;
            this.btnAddAppo.Size = new System.Drawing.Size(215, 45);
            this.btnAddAppo.TabIndex = 14;
            this.btnAddAppo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAppo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddAppo.TextMarginLeft = 0;
            this.btnAddAppo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddAppo.UseDefaultRadiusAndThickness = true;
            this.btnAddAppo.Click += new System.EventHandler(this.btnAddAppo_Click);
            // 
            // pbMain
            // 
            this.pbMain.AllowFocused = false;
            this.pbMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbMain.AutoSizeHeight = true;
            this.pbMain.BorderRadius = 0;
            this.pbMain.Image = global::DVLD_Project.Properties.Resources.manageAppTypes;
            this.pbMain.IsCircle = true;
            this.pbMain.Location = new System.Drawing.Point(121, 18);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(69, 69);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 6;
            this.pbMain.TabStop = false;
            this.pbMain.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // ctrlTestAppointmentsInfo1
            // 
            this.ctrlTestAppointmentsInfo1.Location = new System.Drawing.Point(22, 143);
            this.ctrlTestAppointmentsInfo1.Name = "ctrlTestAppointmentsInfo1";
            this.ctrlTestAppointmentsInfo1.Size = new System.Drawing.Size(838, 411);
            this.ctrlTestAppointmentsInfo1.TabIndex = 0;
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 888);
            this.Controls.Add(this.btnAddAppo);
            this.Controls.Add(this.dgvTestAppointments);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.ctrlTestAppointmentsInfo1);
            this.Name = "frmTestAppointments";
            this.Text = "frmTestAppointments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ctrlTestAppointmentsInfo ctrlTestAppointmentsInfo1;
        private Bunifu.UI.WinForms.BunifuLabel lblMainTitle;
        private Bunifu.UI.WinForms.BunifuPictureBox pbMain;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTestAppointments;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddAppo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}