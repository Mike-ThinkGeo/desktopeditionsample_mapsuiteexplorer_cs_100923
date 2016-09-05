using System.Collections.ObjectModel;
using System.Windows.Forms;
using ThinkGeo.MapSuite.Core;

namespace MapSuiteExplorer
{
    public partial class FormInformation : Form
    {
        private Collection<Feature> featuresInfo;

        public Collection<Feature> FeaturesInfo
        {
            get { return featuresInfo; }
        }

        public FormInformation()
            : this(new Collection<Feature>())
        {
        }

        public FormInformation(Collection<Feature> featuresInfo)
        {
            this.featuresInfo = featuresInfo;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void lstSelectedItems_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            lstAssociatedData.Items.Clear();

            foreach (string key in featuresInfo[this.lstSelectedItems.SelectedIndex].ColumnValues.Keys)
            {
                lstAssociatedData.Items.Add(key + ": " + featuresInfo[lstSelectedItems.SelectedIndex].ColumnValues[key]);
            }
        }

        private void frmInformation_Load(object sender, System.EventArgs e)
        {
            lstSelectedItems.Items.Clear();

            for (int i = 0; i < featuresInfo.Count; i++)
            {
                lstSelectedItems.Items.Add(FeaturesInfo[i].Tag + " - " + FeaturesInfo[i].Id);
            }

            lstSelectedItems.SelectedIndex = 0;
        }
    }
}