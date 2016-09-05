//<%STEMCELL:PerDirectoryNoticeText%> 
//ALL RIGHTS RESERVED: 
//==================== 
//The contents of this file, and associated files in this directory, are 
//Copyright (C) ThinkGeo,LLC , all rights reserved, 2003-2006. 
// 
//All software Source Code, Images, Database-Design and code, Graphics Design 
//and source files, and related content (collectively referred to as SOURCE) are 
//Copyright (c) ThinkGeo,LLC, 2003-2006, All Rights Reserved. 
//ThinkGeo,LLC is a USA corporation at 1617 St. Andrews Dr.Suite 201,Lawrence, 
//KS 66047. 
//http://ThinkGeo.com 
// 
//MapSuite® is a Registered Trademark of ThinkGeo,LLC. 
//</%STEMCELL:PerDirectoryNoticeText%> 
namespace MapSuiteExplorer
{
    internal class FormAbout : System.Windows.Forms.Form
    {

        #region " Windows Form Designer generated code "

        internal FormAbout()
            : base()
        {

            //This call is required by the Windows Form Designer. 
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call 

        }

        //Form overrides dispose to clean up the component list. 
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if ((components != null))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        //Required by the Windows Form Designer 
        private System.ComponentModel.IContainer components = null;

        //NOTE: The following procedure is required by the Windows Form Designer 
        //It can be modified using the Windows Form Designer. 
        //Do not modify it using the code editor. 
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Label lblCopyright;
        internal System.Windows.Forms.PictureBox pbxLogo;
        internal System.Windows.Forms.Label lblProduct;
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.btnOK = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(152, 167);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 24);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(104, 126);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(177, 13);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = Properties.Resources.CopyRight;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(112, 85);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(191, 20);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Map Suite Explorer 3.0";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(8, 8);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(392, 64);
            this.pbxLogo.TabIndex = 4;
            this.pbxLogo.TabStop = false;
            // 
            // FormAbout
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(408, 206);
            this.ControlBox = false;
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Map Suite Explorer";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}