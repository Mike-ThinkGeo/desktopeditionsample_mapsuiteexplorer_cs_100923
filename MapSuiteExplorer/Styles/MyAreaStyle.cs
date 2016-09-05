using System.ComponentModel;
using System.Drawing;

using ThinkGeo.MapSuite.Core;

namespace MapSuiteExplorer
{
    public class MyAreaStyle
    {
        private AreaStyle style;

        [Category("AreaStyle")]
        [Description("The color of outline pen.")]
        public Color OutlineColor
        {
            get
            {
                return Color.FromArgb(style.OutlinePen.Color.RedComponent, style.OutlinePen.Color.GreenComponent, style.OutlinePen.Color.BlueComponent);
            }
            set
            {
                style.OutlinePen.Color = new GeoColor(value.R, value.G, value.B);
            }
        }

        [Category("AreaStyle")]
        [Description("The width of outline pen.")]
        public float OutlineThickness
        {
            get
            {
                return style.OutlinePen.Width;
            }
            set
            {
                style.OutlinePen.Width = value;
            }
        }

        [Category("AreaStyle")]
        [Description("The color of fill solid brush.")]
        public Color FillColor
        {
            get
            {
                return Color.FromArgb(style.FillSolidBrush.Color.RedComponent, style.FillSolidBrush.Color.GreenComponent, style.FillSolidBrush.Color.BlueComponent);
            }
            set
            {
                style.FillSolidBrush.Color = new GeoColor(value.R, value.G, value.B);
            }
        }

        [Category("AreaStyle")]
        [Description("The alpha component of fill solid brush.")]
        public byte Transparency
        {
            get
            {
                return style.FillSolidBrush.Color.AlphaComponent;
            }
            set
            {
                style.FillSolidBrush.Color = GeoColor.FromArgb(value, style.FillSolidBrush.Color);
            }
        }

        [Category("AreaStyle")]
        [Description("If you don't need fill pattern, please select 'None' at the end of drop-down list")]
        public GeoCustomStyle FillPattern
        {
            get
            {
                GeoHatchBrush brush = null;
                if (style.Advanced.FillCustomBrush != null)
                {
                    brush = (GeoHatchBrush)style.Advanced.FillCustomBrush;
                    return GetGeoCustomStyle(brush);
                }

                return GeoCustomStyle.None;
            }
            set
            {
                style.Advanced.FillCustomBrush = value == GeoCustomStyle.None ? null : new GeoHatchBrush((GeoHatchStyle)value, style.FillSolidBrush.Color);
            }
        }

        public MyAreaStyle(AreaStyle style)
        {
            this.style = style;
        }

        private static GeoCustomStyle GetGeoCustomStyle(GeoHatchBrush geoHatchBrush)
        {
            GeoCustomStyle geoCustomStyle = GeoCustomStyle.None;
            switch (geoHatchBrush.HatchStyle)
            {
                case GeoHatchStyle.BackwardDiagonal:
                    geoCustomStyle = GeoCustomStyle.BackwardDiagonal;
                    break;
                case GeoHatchStyle.Cross:
                    geoCustomStyle = GeoCustomStyle.Cross;
                    break;
                case GeoHatchStyle.DarkDownwardDiagonal:
                    geoCustomStyle = GeoCustomStyle.DarkDownwardDiagonal;
                    break;
                case GeoHatchStyle.DarkHorizontal:
                    geoCustomStyle = GeoCustomStyle.DarkHorizontal;
                    break;
                case GeoHatchStyle.DarkUpwardDiagonal:
                    geoCustomStyle = GeoCustomStyle.DarkUpwardDiagonal;
                    break;
                case GeoHatchStyle.DarkVertical:
                    geoCustomStyle = GeoCustomStyle.DarkVertical;
                    break;
                case GeoHatchStyle.DashedDownwardDiagonal:
                    geoCustomStyle = GeoCustomStyle.DashedDownwardDiagonal;
                    break;
                case GeoHatchStyle.DashedHorizontal:
                    geoCustomStyle = GeoCustomStyle.DashedHorizontal;
                    break;
                case GeoHatchStyle.DashedUpwardDiagonal:
                    geoCustomStyle = GeoCustomStyle.DashedUpwardDiagonal;
                    break;
                case GeoHatchStyle.DashedVertical:
                    geoCustomStyle = GeoCustomStyle.DashedVertical;
                    break;
                case GeoHatchStyle.DiagonalBrick:
                    geoCustomStyle = GeoCustomStyle.DiagonalBrick;
                    break;
                case GeoHatchStyle.DiagonalCross:
                    geoCustomStyle = GeoCustomStyle.DiagonalCross;
                    break;
                case GeoHatchStyle.Divot:
                    geoCustomStyle = GeoCustomStyle.Divot;
                    break;
                case GeoHatchStyle.DottedDiamond:
                    geoCustomStyle = GeoCustomStyle.DottedDiamond;
                    break;
                case GeoHatchStyle.DottedGrid:
                    geoCustomStyle = GeoCustomStyle.DottedGrid;
                    break;
                case GeoHatchStyle.ForwardDiagonal:
                    geoCustomStyle = GeoCustomStyle.ForwardDiagonal;
                    break;
                case GeoHatchStyle.Horizontal:
                    geoCustomStyle = GeoCustomStyle.Horizontal;
                    break;
                case GeoHatchStyle.HorizontalBrick:
                    geoCustomStyle = GeoCustomStyle.HorizontalBrick;
                    break;
                case GeoHatchStyle.LargeCheckerBoard:
                    geoCustomStyle = GeoCustomStyle.LargeCheckerBoard;
                    break;
                case GeoHatchStyle.LargeConfetti:
                    geoCustomStyle = GeoCustomStyle.LargeConfetti;
                    break;
                case GeoHatchStyle.LargeGrid:
                    geoCustomStyle = GeoCustomStyle.LargeGrid;
                    break;
                case GeoHatchStyle.LightDownwardDiagonal:
                    geoCustomStyle = GeoCustomStyle.LightDownwardDiagonal;
                    break;
                case GeoHatchStyle.LightHorizontal:
                    geoCustomStyle = GeoCustomStyle.LightHorizontal;
                    break;
                case GeoHatchStyle.LightUpwardDiagonal:
                    geoCustomStyle = GeoCustomStyle.LightUpwardDiagonal;
                    break;
                case GeoHatchStyle.LightVertical:
                    geoCustomStyle = GeoCustomStyle.LightVertical;
                    break;
                case GeoHatchStyle.Max:
                    geoCustomStyle = GeoCustomStyle.Max;
                    break;
                case GeoHatchStyle.Min:
                    geoCustomStyle = GeoCustomStyle.Min;
                    break;
                case GeoHatchStyle.NarrowHorizontal:
                    geoCustomStyle = GeoCustomStyle.NarrowHorizontal;
                    break;
                case GeoHatchStyle.NarrowVertical:
                    geoCustomStyle = GeoCustomStyle.NarrowVertical;
                    break;
                case GeoHatchStyle.OutlinedDiamond:
                    geoCustomStyle = GeoCustomStyle.OutlinedDiamond;
                    break;
                case GeoHatchStyle.Percent05:
                    geoCustomStyle = GeoCustomStyle.Percent05;
                    break;
                case GeoHatchStyle.Percent10:
                    geoCustomStyle = GeoCustomStyle.Percent10;
                    break;
                case GeoHatchStyle.Percent20:
                    geoCustomStyle = GeoCustomStyle.Percent20;
                    break;
                case GeoHatchStyle.Percent25:
                    geoCustomStyle = GeoCustomStyle.Percent25;
                    break;
                case GeoHatchStyle.Percent30:
                    geoCustomStyle = GeoCustomStyle.Percent30;
                    break;
                case GeoHatchStyle.Percent40:
                    geoCustomStyle = GeoCustomStyle.Percent40;
                    break;
                case GeoHatchStyle.Percent50:
                    geoCustomStyle = GeoCustomStyle.Percent50;
                    break;
                case GeoHatchStyle.Percent60:
                    geoCustomStyle = GeoCustomStyle.Percent60;
                    break;
                case GeoHatchStyle.Percent70:
                    geoCustomStyle = GeoCustomStyle.Percent70;
                    break;
                case GeoHatchStyle.Percent75:
                    geoCustomStyle = GeoCustomStyle.Percent75;
                    break;
                case GeoHatchStyle.Percent80:
                    geoCustomStyle = GeoCustomStyle.Percent80;
                    break;
                case GeoHatchStyle.Percent90:
                    geoCustomStyle = GeoCustomStyle.Percent90;
                    break;
                case GeoHatchStyle.Plaid:
                    geoCustomStyle = GeoCustomStyle.Plaid;
                    break;
                case GeoHatchStyle.Shingle:
                    geoCustomStyle = GeoCustomStyle.Shingle;
                    break;
                case GeoHatchStyle.SmallCheckerBoard:
                    geoCustomStyle = GeoCustomStyle.SmallCheckerBoard;
                    break;
                case GeoHatchStyle.SmallConfetti:
                    geoCustomStyle = GeoCustomStyle.SmallConfetti;
                    break;
                case GeoHatchStyle.SmallGrid:
                    geoCustomStyle = GeoCustomStyle.SmallGrid;
                    break;
                case GeoHatchStyle.SolidDiamond:
                    geoCustomStyle = GeoCustomStyle.SolidDiamond;
                    break;
                case GeoHatchStyle.Sphere:
                    geoCustomStyle = GeoCustomStyle.Sphere;
                    break;
                case GeoHatchStyle.Trellis:
                    geoCustomStyle = GeoCustomStyle.Trellis;
                    break;
                case GeoHatchStyle.Vertical:
                    geoCustomStyle = GeoCustomStyle.Vertical;
                    break;
                case GeoHatchStyle.Wave:
                    geoCustomStyle = GeoCustomStyle.Wave;
                    break;
                case GeoHatchStyle.Weave:
                    geoCustomStyle = GeoCustomStyle.Weave;
                    break;
                case GeoHatchStyle.WideDownwardDiagonal:
                    geoCustomStyle = GeoCustomStyle.WideDownwardDiagonal;
                    break;
                case GeoHatchStyle.WideUpwardDiagonal:
                    geoCustomStyle = GeoCustomStyle.WideUpwardDiagonal;
                    break;
                case GeoHatchStyle.ZigZag:
                    geoCustomStyle = GeoCustomStyle.ZigZag;
                    break;
                default:
                    geoCustomStyle = GeoCustomStyle.None;
                    break;
            }
            return geoCustomStyle;
        }
    }
}
