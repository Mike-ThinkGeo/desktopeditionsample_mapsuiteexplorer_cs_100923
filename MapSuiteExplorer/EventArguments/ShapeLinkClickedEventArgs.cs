using System;

namespace MapSuiteExplorer
{
    public class ShapeLinkClickedEventArgs : EventArgs
    {
        private string shapeName;
        private LinkType linkType;

        public string ShapeName
        {
            get { return shapeName; }
            set { shapeName = value; }
        }

        public LinkType LinkType
        {
            get { return linkType; }
            set { linkType = value; }
        }

        public ShapeLinkClickedEventArgs(string shapeName, LinkType linkType)
        {
            this.linkType = linkType;
            this.shapeName = shapeName;
        }
    }
}