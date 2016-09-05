using System.ComponentModel;
using System.Drawing;

using ThinkGeo.MapSuite.Core;

namespace MapSuiteExplorer
{
    public class MyPointStyle
    {
        private PointStyle style;

        [Category("PointStyle")]
        [Description("The point symbol type.")]
        public PointSymbolType SymbolType
        {
            get
            {
                return style.SymbolType;
            }
            set
            {
                style.SymbolType = value;
            }
        }

        [Category("PointStyle")]
        [Description("The color of symbol solid brush.")]
        public Color FillColor
        {
            get
            {
                return Color.FromArgb(style.SymbolSolidBrush.Color.RedComponent, style.SymbolSolidBrush.Color.GreenComponent, style.SymbolSolidBrush.Color.BlueComponent);
            }
            set
            {
                style.SymbolSolidBrush.Color = new GeoColor(value.R, value.G, value.B);
            }
        }

        [Category("PointStyle")]
        [Description("The color of symbol pen.")]
        public Color OutlineColor
        {
            get
            {
                return Color.FromArgb(style.SymbolPen.Color.RedComponent, style.SymbolPen.Color.GreenComponent, style.SymbolPen.Color.BlueComponent);
            }
            set
            {
                style.SymbolPen.Color = new GeoColor(value.R, value.G, value.B);
            }
        }

        [Category("PointStyle")]
        [Description("The symbol size.")]
        public float SymbolSize
        {
            get
            {
                return style.SymbolSize;
            }
            set
            {
                style.SymbolSize = value;
            }
        }

        public MyPointStyle(PointStyle style)
        {
            this.style = style;
        }
    }
}
