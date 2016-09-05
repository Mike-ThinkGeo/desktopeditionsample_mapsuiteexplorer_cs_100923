namespace MapSuiteExplorer
{
    partial class FormStyleEditor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAreaStyle = new System.Windows.Forms.TabPage();
            this.tabPageLineStyle = new System.Windows.Forms.TabPage();
            this.tabPagePointStyle = new System.Windows.Forms.TabPage();
            this.tabPageTextStyle = new System.Windows.Forms.TabPage();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAreaStyle);
            this.tabControl1.Controls.Add(this.tabPageLineStyle);
            this.tabControl1.Controls.Add(this.tabPagePointStyle);
            this.tabControl1.Controls.Add(this.tabPageTextStyle);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAreaStyle
            // 
            this.tabPageAreaStyle.Location = new System.Drawing.Point(4, 22);
            this.tabPageAreaStyle.Name = "tabPageAreaStyle";
            this.tabPageAreaStyle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAreaStyle.Size = new System.Drawing.Size(500, 260);
            this.tabPageAreaStyle.TabIndex = 0;
            this.tabPageAreaStyle.Text = "AreaStyle";
            this.tabPageAreaStyle.UseVisualStyleBackColor = true;
            this.tabPageAreaStyle.Enter += new System.EventHandler(this.tabPageAreaStyle_Enter);
            // 
            // tabPageLineStyle
            // 
            this.tabPageLineStyle.Location = new System.Drawing.Point(4, 22);
            this.tabPageLineStyle.Name = "tabPageLineStyle";
            this.tabPageLineStyle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLineStyle.Size = new System.Drawing.Size(500, 260);
            this.tabPageLineStyle.TabIndex = 1;
            this.tabPageLineStyle.Text = "LineStyle";
            this.tabPageLineStyle.UseVisualStyleBackColor = true;
            this.tabPageLineStyle.Enter += new System.EventHandler(this.tabPageLineStyle_Enter);
            // 
            // tabPagePointStyle
            // 
            this.tabPagePointStyle.Location = new System.Drawing.Point(4, 22);
            this.tabPagePointStyle.Name = "tabPagePointStyle";
            this.tabPagePointStyle.Size = new System.Drawing.Size(500, 260);
            this.tabPagePointStyle.TabIndex = 2;
            this.tabPagePointStyle.Text = "PointStyle";
            this.tabPagePointStyle.UseVisualStyleBackColor = true;
            this.tabPagePointStyle.Enter += new System.EventHandler(this.tabPagePointStyle_Enter);
            // 
            // tabPageTextStyle
            // 
            this.tabPageTextStyle.Location = new System.Drawing.Point(4, 22);
            this.tabPageTextStyle.Name = "tabPageTextStyle";
            this.tabPageTextStyle.Size = new System.Drawing.Size(500, 260);
            this.tabPageTextStyle.TabIndex = 3;
            this.tabPageTextStyle.Text = "TextStyle";
            this.tabPageTextStyle.UseVisualStyleBackColor = true;
            this.tabPageTextStyle.Enter += new System.EventHandler(this.tabPageTextStyle_Enter);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(351, 291);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(432, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormStyleEditor
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(512, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStyleEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Style Editor";
            this.Load += new System.EventHandler(this.frmStyleEditor_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAreaStyle;
        private System.Windows.Forms.TabPage tabPageLineStyle;
        private System.Windows.Forms.TabPage tabPagePointStyle;
        private System.Windows.Forms.TabPage tabPageTextStyle;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}