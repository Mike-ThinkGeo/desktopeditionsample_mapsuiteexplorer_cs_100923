using System;

namespace MapSuiteExplorer
{
    public class LayerOrderEventArgs : EventArgs
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public LayerOrderEventArgs(string name)
        {
            this.name = name;
        }
    }
}