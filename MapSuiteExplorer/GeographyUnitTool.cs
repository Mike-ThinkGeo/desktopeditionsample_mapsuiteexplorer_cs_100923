using System;
using System.Windows.Forms;

using ThinkGeo.MapSuite.Core;

namespace MapSuiteExplorer
{
    public partial class GeographyUnitTool : Form
    {
        private GeographyUnit currentUnit;

        public GeographyUnit CurrentUnit
        {
            get { return currentUnit; }
            set { currentUnit = value; }
        }

        public GeographyUnitTool()
        {
            InitializeComponent();
        }

        private void GeographyUnitTool_Load(object sender, EventArgs e)
        {
            comboBox1.Text = currentUnit.ToString();
        }

        private void btnSetUnit_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Unknown":
                    currentUnit = GeographyUnit.Unknown;
                    break;
                case "DecimalDegree":
                    currentUnit = GeographyUnit.DecimalDegree;
                    break;
                case "Feet":
                    currentUnit = GeographyUnit.Feet;
                    break;
                case "Meter":
                    currentUnit = GeographyUnit.Meter;
                    break;
                default:
                    break;
            }
            Close();
        }
    }
}
