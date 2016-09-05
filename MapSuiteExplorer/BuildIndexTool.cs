using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using ThinkGeo.MapSuite.Core;

namespace MapSuiteExplorer
{
    public partial class BuildIndexTool : Form
    {
        private Collection<string> files;

        public Collection<string> Files
        {
            get { return files; }
        }

        public BuildIndexTool()
            : this(new Collection<string>())
        {
        }

        internal BuildIndexTool(Collection<string> buildIndexFiles)
        {
            files = buildIndexFiles;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 50);

            progressBar1.Minimum = 1;
            progressBar1.Maximum = files.Count;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
        }

        private void BuildIndexTool_Shown(object sender, EventArgs e)
        {
            BuildIndex();
            Close();
        }

        private void BuildIndex()
        {
            if (files != null)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    ShapeFileFeatureLayer.BuildIndexFile(files[i], BuildIndexMode.Rebuild);
                    progressBar1.PerformStep();
                }
            }
        }
    }
}
