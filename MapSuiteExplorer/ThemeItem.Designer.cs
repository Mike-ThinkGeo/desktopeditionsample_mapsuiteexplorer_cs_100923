namespace MapSuiteExplorer
{
    partial class ThemeItem
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
            this.cbxItem = new System.Windows.Forms.CheckBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlRemove = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle.SuspendLayout();
            this.pnlRemove.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxItem
            // 
            this.cbxItem.AutoSize = true;
            this.cbxItem.Checked = true;
            this.cbxItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxItem.ForeColor = System.Drawing.Color.White;
            this.cbxItem.Location = new System.Drawing.Point(3, 3);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxItem.Size = new System.Drawing.Size(74, 17);
            this.cbxItem.TabIndex = 0;
            this.cbxItem.Text = "checkBox";
            this.cbxItem.UseVisualStyleBackColor = true;
            this.cbxItem.CheckedChanged += new System.EventHandler(this.cbxItem_CheckedChanged);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(142)))), ((int)(((byte)(207)))));
            this.pnlTitle.Controls.Add(this.pnlRemove);
            this.pnlTitle.Controls.Add(this.cbxItem);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(140, 20);
            this.pnlTitle.TabIndex = 5;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // pnlRemove
            // 
            this.pnlRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(142)))), ((int)(((byte)(207)))));
            this.pnlRemove.Controls.Add(this.btnRemove);
            this.pnlRemove.Location = new System.Drawing.Point(120, 0);
            this.pnlRemove.Name = "pnlRemove";
            this.pnlRemove.Size = new System.Drawing.Size(16, 16);
            this.pnlRemove.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_remove;
            this.btnRemove.Location = new System.Drawing.Point(0, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(16, 16);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Tag = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // ThemeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlTitle);
            this.Name = "ThemeItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(140, 60);
            this.Click += new System.EventHandler(this.ThemeItem_Click);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ThemeItem_MouseDoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ThemeItem_MouseClick);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlRemove.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxItem;
        //internal System.Windows.Forms.PictureBox wellKnownTypeImage; // size 55,22
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlRemove;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        //private System.Windows.Forms.Panel pnlFunction;
    }
}
