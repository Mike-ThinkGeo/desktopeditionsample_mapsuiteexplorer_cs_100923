using System;
using System.Drawing;

namespace MapSuiteExplorer
{
    public class RightClickEventArgs : EventArgs
    {
        private Point point;

        public Point Point
        {
            get { return point; }
            set { point = value; }
        }

        public RightClickEventArgs(Point point)
        {
            this.point = point;
        }
    }
}
