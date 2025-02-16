namespace DVLD_Project.User
{
    partial class frmUserInfo
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
            this.ctrlPersonInformation1 = new DVLD_Project.Person.ctrlPersonInformation();
            this.ctrlLoginInfo1 = new DVLD_Project.User.Controls.ctrlLoginInfo();
            this.SuspendLayout();
            // 
            // ctrlPersonInformation1
            // 
            this.ctrlPersonInformation1.Location = new System.Drawing.Point(1, -2);
            this.ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            this.ctrlPersonInformation1.Size = new System.Drawing.Size(844, 364);
            this.ctrlPersonInformation1.TabIndex = 0;
            this.ctrlPersonInformation1.Load += new System.EventHandler(this.ctrlPersonInformation1_Load);
            // 
            // ctrlLoginInfo1
            // 
            this.ctrlLoginInfo1.Location = new System.Drawing.Point(5, 351);
            this.ctrlLoginInfo1.Name = "ctrlLoginInfo1";
            this.ctrlLoginInfo1.Size = new System.Drawing.Size(836, 139);
            this.ctrlLoginInfo1.TabIndex = 1;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 501);
            this.Controls.Add(this.ctrlLoginInfo1);
            this.Controls.Add(this.ctrlPersonInformation1);
            this.Name = "frmUserInfo";
            this.Text = "frmUserInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private Person.ctrlPersonInformation ctrlPersonInformation1;
        private Controls.ctrlLoginInfo ctrlLoginInfo1;
    }
}