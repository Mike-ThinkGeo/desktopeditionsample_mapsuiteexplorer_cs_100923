namespace MapSuiteExplorer
{
    partial class FormInformation
    {
        #region Windows Form Designer generated code

 
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
        internal System.Windows.Forms.ListBox lstSelectedItems;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.ListBox lstAssociatedData;
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.lstSelectedItems = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstAssociatedData = new System.Windows.Forms.ListBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxSelectedItems = new System.Windows.Forms.GroupBox();
            this.gbxAssociatedData = new System.Windows.Forms.GroupBox();
            this.pnlBottom.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxSelectedItems.SuspendLayout();
            this.gbxAssociatedData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSelectedItems
            // 
            this.lstSelectedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelectedItems.Location = new System.Drawing.Point(3, 16);
            this.lstSelectedItems.Name = "lstSelectedItems";
            this.lstSelectedItems.Size = new System.Drawing.Size(164, 238);
            this.lstSelectedItems.TabIndex = 0;
            this.lstSelectedItems.SelectedIndexChanged += new System.EventHandler(this.lstSelectedItems_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(425, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstAssociatedData
            // 
            this.lstAssociatedData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAssociatedData.Location = new System.Drawing.Point(3, 16);
            this.lstAssociatedData.Name = "lstAssociatedData";
            this.lstAssociatedData.Size = new System.Drawing.Size(332, 238);
            this.lstAssociatedData.TabIndex = 3;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 260);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(512, 43);
            this.pnlBottom.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbxSelectedItems);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbxAssociatedData);
            this.splitContainer1.Size = new System.Drawing.Size(512, 260);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 6;
            // 
            // gbxSelectedItems
            // 
            this.gbxSelectedItems.Controls.Add(this.lstSelectedItems);
            this.gbxSelectedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxSelectedItems.Location = new System.Drawing.Point(0, 0);
            this.gbxSelectedItems.Name = "gbxSelectedItems";
            this.gbxSelectedItems.Size = new System.Drawing.Size(170, 260);
            this.gbxSelectedItems.TabIndex = 0;
            this.gbxSelectedItems.TabStop = false;
            this.gbxSelectedItems.Text = "Selected Item(s)";
            // 
            // gbxAssociatedData
            // 
            this.gbxAssociatedData.Controls.Add(this.lstAssociatedData);
            this.gbxAssociatedData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAssociatedData.Location = new System.Drawing.Point(0, 0);
            this.gbxAssociatedData.Name = "gbxAssociatedData";
            this.gbxAssociatedData.Size = new System.Drawing.Size(338, 260);
            this.gbxAssociatedData.TabIndex = 0;
            this.gbxAssociatedData.TabStop = false;
            this.gbxAssociatedData.Text = "Associated Data";
            // 
            // FormInformation
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(512, 303);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 180);
            this.Name = "FormInformation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.frmInformation_Load);
            this.pnlBottom.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.gbxSelectedItems.ResumeLayout(false);
            this.gbxAssociatedData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbxSelectedItems;
        private System.Windows.Forms.GroupBox gbxAssociatedData;
    }
}