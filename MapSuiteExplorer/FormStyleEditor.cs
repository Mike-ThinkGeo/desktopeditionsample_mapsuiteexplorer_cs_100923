using System;
using System.Windows.Forms;

using ThinkGeo.MapSuite.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MapSuiteExplorer
{
    internal partial class FormStyleEditor : Form
    {
        private StyleEditor styleEditor;
        private FeatureLayer baseLayer;
        private StyleType currentStyleType;

        internal FeatureLayer BaseLayer
        {
            get { return baseLayer; }
            set { baseLayer = value; }
        }

        internal StyleType CurrentStyleType
        {
            get { return currentStyleType; }
            set { currentStyleType = value; }
        }

        internal string[] ColumnNames
        {
            get;
            set;
        }

        internal FormStyleEditor()
        {
            InitializeComponent();
        }

        private void frmStyleEditor_Load(object sender, EventArgs e)
        {
            this.Text = "Style Editor - " + baseLayer.Name;

            styleEditor = new StyleEditor();
            styleEditor.ColumnNames = ColumnNames;
            styleEditor.AreaStyle = BaseLayer.ZoomLevelSet.ZoomLevel01.DefaultAreaStyle;
            styleEditor.LineStyle = BaseLayer.ZoomLevelSet.ZoomLevel01.DefaultLineStyle;
            styleEditor.PointStyle = BaseLayer.ZoomLevelSet.ZoomLevel01.DefaultPointStyle;
            styleEditor.TextStyle = BaseLayer.ZoomLevelSet.ZoomLevel01.DefaultTextStyle;

            switch (currentStyleType)
            {
                case StyleType.Area:
                    tabControl1.SelectedTab = tabPageAreaStyle;
                    break;
                case StyleType.Line:
                    tabControl1.SelectedTab = tabPageLineStyle;
                    break;
                case StyleType.Point:
                    tabControl1.SelectedTab = tabPagePointStyle;
                    break;
                case StyleType.Text:
                    tabControl1.SelectedTab = tabPageTextStyle;
                    break;
                case StyleType.Custom:
                    break;
                default:
                    break;
            }
        }

        private void tabPageAreaStyle_Enter(object sender, EventArgs e)
        {
            styleEditor.StyleType = StyleType.Area;
            if (!tabPageAreaStyle.Controls.Contains(styleEditor))
            {
                tabPageAreaStyle.Controls.Add(styleEditor);
            }
        }

        private void tabPageLineStyle_Enter(object sender, EventArgs e)
        {
            styleEditor.StyleType = StyleType.Line;
            if (!tabPageLineStyle.Controls.Contains(styleEditor))
            {
                tabPageLineStyle.Controls.Add(styleEditor);
            }
        }

        private void tabPagePointStyle_Enter(object sender, EventArgs e)
        {
            styleEditor.StyleType = StyleType.Point;
            if (!tabPagePointStyle.Controls.Contains(styleEditor))
            {
                tabPagePointStyle.Controls.Add(styleEditor);
            }
        }

        private void tabPageTextStyle_Enter(object sender, EventArgs e)
        {
            styleEditor.StyleType = StyleType.Text;
            if (!tabPageTextStyle.Controls.Contains(styleEditor))
            {
                tabPageTextStyle.Controls.Add(styleEditor);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            currentStyleType = styleEditor.StyleType;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetLayerStyleType(FeatureLayer layer, StyleType layerStyleType)
        {
            layer.FeatureSource.Open();
            if (layerStyleType == StyleType.Text)
            {
                List<string> columnNameList = new List<string>();
                Collection<FeatureSourceColumn> columns = layer.FeatureSource.GetColumns();
                foreach (FeatureSourceColumn myColumn in columns)
                {
                    columnNameList.Add(myColumn.ColumnName);
                }
                this.CurrentStyleType = StyleType.Text;
                this.ColumnNames = columnNameList.ToArray();
            }
            else
            {
                Feature firstFeature = layer.FeatureSource.GetFeatureById("1", ReturningColumnsType.AllColumns);
                BaseShape shape = firstFeature.GetShape();
                if (shape is LineBaseShape)
                {
                    this.CurrentStyleType = StyleType.Line;
                }
                else if (shape is PointBaseShape)
                {
                    this.CurrentStyleType = StyleType.Point;
                }
                else if (shape is AreaBaseShape)
                {
                    this.CurrentStyleType = StyleType.Area;
                }
            }
            layer.FeatureSource.Close();
        }
    }
}
