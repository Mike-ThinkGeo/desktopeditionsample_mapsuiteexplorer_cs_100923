using System.ComponentModel;
using System.Drawing;

using ThinkGeo.MapSuite.Core;

namespace MapSuiteExplorer
{
    public class MyLineStyle
    {
        private LineStyle style;

        [Category("LineStyle")]
        [Description("The color of outer pen.")]
        public Color LineColor
        {
            get { return Color.FromArgb(style.OuterPen.Color.RedComponent, style.OuterPen.Color.GreenComponent, style.OuterPen.Color.BlueComponent); }
            set { style.OuterPen.Color = new GeoColor(value.R, value.G, value.B); }
        }

        [Category("LineStyle")]
        [Description("The width of outer pen.")]
        public float LineThickness
        {
            get { return style.OuterPen.Width; }
            set { style.OuterPen.Width = value; }
        }

        public MyLineStyle(LineStyle style)
        {
            this.style = style;
        }
    }
}
