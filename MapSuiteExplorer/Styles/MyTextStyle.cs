using System.ComponentModel;
using System.Drawing;

using ThinkGeo.MapSuite.Core;

namespace MapSuiteExplorer
{
    public class MyTextStyle
    {
        private TextStyle style;

        [Category("TextStyle")]
        [Description("Find column name from features dialog when click show features button.")]
        public string TextColumnName
        {
            get { return style.TextColumnName; }
            set { style.TextColumnName = value; }
        }

        [Category("TextStyle")]
        [Description("The font of text.")]
        public Font Font
        {
            get { return new Font(style.Font.FontName, style.Font.Size, GetFontStyle(style.Font.Style)); }
            set { style.Font = new GeoFont(value.Name, value.Size, GetDrawingFontStyles(value.Style)); }
        }

        [Category("TextStyle")]
        [Description("The color of text solid brush.")]
        public Color TextColor
        {
            get { return Color.FromArgb(style.TextSolidBrush.Color.RedComponent, style.TextSolidBrush.Color.GreenComponent, style.TextSolidBrush.Color.BlueComponent); }
            set { style.TextSolidBrush.Color = new GeoColor(value.R, value.G, value.B); }
        }

        public MyTextStyle(TextStyle style)
        {
            this.style = style;
        }

        private static FontStyle GetFontStyle(DrawingFontStyles drawingFontStyles)
        {
            switch (drawingFontStyles)
            {
                case DrawingFontStyles.Bold:
                    return FontStyle.Bold;
                case DrawingFontStyles.Italic:
                    return FontStyle.Italic;
                case DrawingFontStyles.Regular:
                    return FontStyle.Regular;
                case DrawingFontStyles.Strikeout:
                    return FontStyle.Strikeout;
                case DrawingFontStyles.Underline:
                    return FontStyle.Underline;
                default:
                    break;
            }
            return FontStyle.Regular;
        }

        private static DrawingFontStyles GetDrawingFontStyles(FontStyle fontStyle)
        {
            switch (fontStyle)
            {
                case FontStyle.Bold:
                    return DrawingFontStyles.Bold;
                case FontStyle.Italic:
                    return DrawingFontStyles.Italic;
                case FontStyle.Regular:
                    return DrawingFontStyles.Regular;
                case FontStyle.Strikeout:
                    return DrawingFontStyles.Strikeout;
                case FontStyle.Underline:
                    return DrawingFontStyles.Underline;
                default:
                    break;
            }
            return DrawingFontStyles.Regular;
        }
    }
}
