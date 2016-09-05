using System;

namespace MapSuiteExplorer
{
    public class DragDropItemEventArgs : EventArgs
    {
        private int fromOrder;
        private int toOrder;

        public int FromOrder
        {
            get { return fromOrder; }
            set { fromOrder = value; }
        }

        public int ToOrder
        {
            get { return toOrder; }
            set { toOrder = value; }
        }

        public DragDropItemEventArgs(int fromOrder, int toOrder)
        {
            this.fromOrder = fromOrder;
            this.toOrder = toOrder;
        }
    }
}