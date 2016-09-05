using System;

namespace MapSuiteExplorer
{
    public class ShapeEventArgs : EventArgs
    {
        private string shapeName;
        private bool isShow;

        public string ShapeName
        {
            get { return shapeName; }
            set { shapeName = value; }
        }

        public bool IsShow
        {
            get { return isShow; }
            set { isShow = value; }
        }

        public ShapeEventArgs(string shapeName, bool isShow)
        {
            this.shapeName = shapeName;
            this.isShow = isShow;
        }
    }
}