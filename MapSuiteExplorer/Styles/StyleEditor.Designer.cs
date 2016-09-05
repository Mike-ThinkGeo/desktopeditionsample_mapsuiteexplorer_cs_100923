namespace MapSuiteExplorer
{
    partial class StyleEditor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridStyle = new PropertyGridEx.PropertyGridEx();
            this.gbxAreaPreview = new System.Windows.Forms.GroupBox();
            this.pbxPreview = new System.Windows.Forms.PictureBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxAreaPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridStyle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbxAreaPreview);
            this.splitContainer1.Size = new System.Drawing.Size(500, 260);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridStyle
            // 
            this.gridStyle.DocCommentDescription.AutoEllipsis = true;
            this.gridStyle.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridStyle.DocCommentDescription.Location = new System.Drawing.Point(3, 18);
            this.gridStyle.DocCommentDescription.Name = "";
            this.gridStyle.DocCommentDescription.Size = new System.Drawing.Size(233, 37);
            this.gridStyle.DocCommentDescription.TabIndex = 1;
            this.gridStyle.DocCommentImage = null;
            this.gridStyle.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridStyle.DocCommentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridStyle.DocCommentTitle.Location = new System.Drawing.Point(3, 3);
            this.gridStyle.DocCommentTitle.Name = "";
            this.gridStyle.DocCommentTitle.Size = new System.Drawing.Size(233, 15);
            this.gridStyle.DocCommentTitle.TabIndex = 0;
            this.gridStyle.DocCommentTitle.UseMnemonic = false;
            this.gridStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStyle.Location = new System.Drawing.Point(0, 0);
            this.gridStyle.Name = "gridStyle";
            this.gridStyle.Size = new System.Drawing.Size(239, 260);
            this.gridStyle.TabIndex = 1;
            this.gridStyle.ToolStrip.AccessibleName = "ToolBar";
            this.gridStyle.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.gridStyle.ToolStrip.AllowMerge = false;
            this.gridStyle.ToolStrip.AutoSize = false;
            this.gridStyle.ToolStrip.CanOverflow = false;
            this.gridStyle.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.gridStyle.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.gridStyle.ToolStrip.Location = new System.Drawing.Point(0, 1);
            this.gridStyle.ToolStrip.Name = "";
            this.gridStyle.ToolStrip.Padding = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.gridStyle.ToolStrip.Size = new System.Drawing.Size(239, 25);
            this.gridStyle.ToolStrip.TabIndex = 1;
            this.gridStyle.ToolStrip.TabStop = true;
            this.gridStyle.ToolStrip.Text = "PropertyGridToolBar";
            this.gridStyle.ParentChanged += new System.EventHandler(this.StyleEditor_ParentChanged);
            this.gridStyle.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.gridStyle_PropertyValueChanged);
            // 
            // gbxAreaPreview
            // 
            this.gbxAreaPreview.BackColor = System.Drawing.SystemColors.Control;
            this.gbxAreaPreview.Controls.Add(this.pbxPreview);
            this.gbxAreaPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAreaPreview.Location = new System.Drawing.Point(0, 0);
            this.gbxAreaPreview.Name = "gbxAreaPreview";
            this.gbxAreaPreview.Size = new System.Drawing.Size(257, 260);
            this.gbxAreaPreview.TabIndex = 0;
            this.gbxAreaPreview.TabStop = false;
            this.gbxAreaPreview.Text = "Preview";
            // 
            // pbxArePreview
            // 
            this.pbxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxPreview.BackColor = System.Drawing.Color.White;
            this.pbxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPreview.Location = new System.Drawing.Point(39, 38);
            this.pbxPreview.Name = "pbxArePreview";
            this.pbxPreview.Size = new System.Drawing.Size(183, 192);
            this.pbxPreview.TabIndex = 0;
            this.pbxPreview.TabStop = false;
            // 
            // StyleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "StyleEditor";
            this.Size = new System.Drawing.Size(500, 260);
            this.ParentChanged += new System.EventHandler(this.StyleEditor_ParentChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.gbxAreaPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private PropertyGridEx.PropertyGridEx gridStyle;
        private System.Windows.Forms.GroupBox gbxAreaPreview;
        private System.Windows.Forms.PictureBox pbxPreview;
    }
}
