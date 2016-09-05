using System;
using System.Data;
using System.Windows.Forms;

using ThinkGeo.MapSuite.Core;

namespace MapSuiteExplorer
{
    public partial class FormFeatures : Form
    {
        private string tableName;
        private FeatureLayer shapeFileLayer;

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        public FeatureLayer ShapeFileLayer
        {
            get { return shapeFileLayer; }
            set { shapeFileLayer = value; }
        }

        public FormFeatures()
        {
            InitializeComponent();
        }

        private void frmFeatures_Load(object sender, EventArgs e)
        {
            this.Text = "Features - " + shapeFileLayer.Name;

            dgridFeatures.DataSource = null;
            this.txtSql.Text = "Select TOP 100 * From " + TableName;
            ExecuteSql();
        }

        private void btnExecuteSql_Click(object sender, EventArgs e)
        {
            ExecuteSql();
        }

        private void ExecuteSql()
        {
            try
            {
                shapeFileLayer.Open();
                DataTable dataTable = shapeFileLayer.QueryTools.ExecuteQuery(txtSql.Text);

                dgridFeatures.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
            }
            finally
            {
                if (shapeFileLayer.IsOpen)
                {
                    shapeFileLayer.Close();
                }
            }
        }
    }
}
