using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ThinkGeo.MapSuite.Core;

namespace MapSuiteExplorer
{
    public partial class ThemeView : UserControl
    {
        internal event EventHandler<DragDropItemEventArgs> ThemeViewDragDrop;
        internal event EventHandler<EventArgs> VScrollVisible;

        private bool isVScrollVisible;
        private bool scrollBarWidthNeedtoChange;
        private GeoCollection<ThemeItem> items;

        public GeoCollection<ThemeItem> Items
        {
            get { return items; }
        }

        public ThemeView()
        {
            items = new GeoCollection<ThemeItem>();
            InitializeComponent();
        }

        internal void SetupItems()
        {
            scrollBarWidthNeedtoChange = false;

            this.Controls.Clear();
            int height = 0;

            for (int i = items.Count - 1; i >= 0; i--)
            {
                items[i].Location = new Point(0, height);
                this.Controls.Add(items[i]);

                height += 60;
            }

            scrollBarWidthNeedtoChange = true;
        }

        private void ThemeView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ThemeItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ThemeView_DragDrop(object sender, DragEventArgs e)
        {
            // find which theme item be draged
            ThemeItem currentItem = (ThemeItem)(e.Data.GetData(typeof(ThemeItem)));

            int selectedOrder = GetSelectedOrder(currentItem.ShapeName);

            // find mainform
            Control control = this;
            while (control.Parent != null)
            {
                control = control.Parent;
            }

            // 70 is toolStrip and menu's height
            int yOffset = (e.Y - control.Location.Y - 70) - currentItem.Location.Y;

            int remainder = yOffset % currentItem.Height;
            int divider = yOffset / currentItem.Height;
            int oneThirdHeight = currentItem.Height / 3;

            if (divider < 0 || (remainder > oneThirdHeight && divider > 0))
            {
                DoDragDropItem(selectedOrder, selectedOrder - divider);
                return;
            }
            if (divider > 1 || (remainder < -oneThirdHeight && divider <= 0))
            {
                DoDragDropItem(selectedOrder, selectedOrder - divider + 1);
                return;
            }
        }

        private void DoDragDropItem(int from, int to)
        {
            items.MoveTo(from, to);
            OnThemeViewDragDrop(new DragDropItemEventArgs(from, to));
            SetupItems();
        }

        private int GetSelectedOrder(string shapeName)
        {
            int selectedOrder = -1;
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (shapeName == this.Items[i].ShapeName)
                {
                    selectedOrder = i;
                    break;
                }
            }
            return selectedOrder;
        }

        private void ThemeView_Paint(object sender, PaintEventArgs e)
        {
            if (isVScrollVisible != VerticalScroll.Visible)
            {
                isVScrollVisible = VerticalScroll.Visible;
                OnVScrollVisible(new EventArgs());
            }
        }

        protected virtual void OnThemeViewDragDrop(DragDropItemEventArgs e)
        {
            EventHandler<DragDropItemEventArgs> handler = ThemeViewDragDrop;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnVScrollVisible(EventArgs e)
        {
            EventHandler<EventArgs> handler = VScrollVisible;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (scrollBarWidthNeedtoChange)
            {
                base.OnPaint(e);
            }
        }
    }
}
