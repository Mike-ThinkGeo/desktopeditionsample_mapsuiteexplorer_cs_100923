using System;
using System.Windows.Forms;

namespace MapSuiteExplorer
{
    public partial class ThemeItem : UserControl
    {
        internal event EventHandler<ShapeEventArgs> ItemCheckedChanged;
        internal event EventHandler<ShapeLinkClickedEventArgs> ItemLinkClicked;
        internal event EventHandler<LayerOrderEventArgs> ThemeItemClick;
        internal event EventHandler<RightClickEventArgs> ThemeItemRightClick;

        private StyleType styleType;
        private bool isShow = true;

        public StyleType StyleType
        {
            get { return styleType; }
            set { styleType = value; }
        }

        public bool IsShow
        {
            get { return isShow; }
            set
            {
                isShow = value;
                cbxItem.Checked = IsShow;
            }
        }

        public string ShapeName
        {
            get { return cbxItem.Text; }
            set { cbxItem.Text = value; }
        }

        public ThemeItem()
        {
            InitializeComponent();
            ToolTip tooTip = new ToolTip();
            tooTip.SetToolTip(this.btnRemove, "Remove");
            tooTip.SetToolTip(this, Properties.Resources.ThemeItemToolTip);
            tooTip.SetToolTip(this.cbxItem, Properties.Resources.ThemeItemCheckBoxToolTip);
        }

        private void cbxItem_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxItem.Text))
            {
                throw new ArgumentException(Properties.Resources.ShapeNameCheck);
            }
            OnItemCheckedChanged(new ShapeEventArgs(cbxItem.Text, cbxItem.Checked));
        }

        private void ThemeItem_Click(object sender, EventArgs e)
        {
            OnThemeItemClick(new LayerOrderEventArgs(this.cbxItem.Text));
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            OnThemeItemClick(new LayerOrderEventArgs(this.cbxItem.Text));
            DoDragDrop(this, DragDropEffects.Move);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OnItemLinkClicked(new ShapeLinkClickedEventArgs(cbxItem.Text, LinkType.Remove));
        }

        private void ThemeItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OnItemLinkClicked(new ShapeLinkClickedEventArgs(cbxItem.Text, LinkType.Edit));
            }
        }

        private void ThemeItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                OnThemeItemRightClick(new RightClickEventArgs(PointToScreen(e.Location)));
            }
        }

        protected virtual void OnItemCheckedChanged(ShapeEventArgs e)
        {
            EventHandler<ShapeEventArgs> handler = ItemCheckedChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnThemeItemClick(LayerOrderEventArgs e)
        {
            EventHandler<LayerOrderEventArgs> handler = ThemeItemClick;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnItemLinkClicked(ShapeLinkClickedEventArgs e)
        {
            EventHandler<ShapeLinkClickedEventArgs> handler = ItemLinkClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnThemeItemRightClick(RightClickEventArgs e)
        {
            EventHandler<RightClickEventArgs> handler = ThemeItemRightClick;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
