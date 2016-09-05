using System;
using System.Drawing;
using System.Windows.Forms;

using ThinkGeo.MapSuite.Core;
using PropertyGridEx;

namespace MapSuiteExplorer
{
    public partial class StyleEditor : UserControl
    {
        private StyleType styleType;
        private AreaStyle areaStyle;
        private LineStyle lineStyle;
        private PointStyle pointStyle;
        private TextStyle textStyle;

        public string[] ColumnNames
        {
            get;
            set;
        }

        public StyleType StyleType
        {
            get { return styleType; }
            set { styleType = value; }
        }

        public AreaStyle AreaStyle
        {
            get { return areaStyle; }
            set { areaStyle = value; }
        }

        public LineStyle LineStyle
        {
            get { return lineStyle; }
            set { lineStyle = value; }
        }

        public PointStyle PointStyle
        {
            get { return pointStyle; }
            set { pointStyle = value; }
        }

        public TextStyle TextStyle
        {
            get { return textStyle; }
            set { textStyle = value; }
        }

        public StyleEditor()
        {
            InitializeComponent();

            ColumnNames = new string[] { string.Empty };
            pbxPreview.Image = new Bitmap(pbxPreview.Width, pbxPreview.Height);
        }

        private void gridStyle_PropertyValueChanged(object sender, PropertyValueChangedEventArgs e)
        {
            if (styleType == StyleType.Text)
            {
                SetTextStyleValue(e.ChangedItem.PropertyDescriptor as CustomProperty.CustomPropertyDescriptor);
            }
            DrawPreviewImage();
        }

        private void SetTextStyleValue(CustomProperty.CustomPropertyDescriptor cpd)
        {
            if (cpd == null)
            {
                return;
            }
            CustomProperty cp = cpd.CustomProperty as CustomProperty;
            if (cp.Name == "Font")
            {
                Font font = cp.Value as Font;
                DrawingFontStyles tStyle = DrawingFontStyles.Regular;
                if (font.Style == FontStyle.Bold)
                {
                    tStyle = DrawingFontStyles.Bold;
                }
                if (font.Style == FontStyle.Italic)
                {
                    tStyle = DrawingFontStyles.Italic;
                }
                if (font.Style == FontStyle.Strikeout)
                {
                    tStyle = DrawingFontStyles.Strikeout;
                }
                if (font.Style == FontStyle.Underline)
                {
                    tStyle = DrawingFontStyles.Underline;
                }
                textStyle.Font = new GeoFont(font.FontFamily.Name,
                                            font.Size,
                                            tStyle);
            }
            if (cp.Name == "TextColor")
            {
                Color fillColor = (Color)cp.Value;
                textStyle.TextSolidBrush = new GeoSolidBrush(new GeoColor(fillColor.R,
                                                                            fillColor.G,
                                                                            fillColor.B));
            }
            if (cp.Name == "TextColumnName")
            {
                string textColumnName = cp.Value.ToString();
                textStyle.TextColumnName = textColumnName;
            }
        }

        private void DrawPreviewImage()
        {
            switch (styleType)
            {
                case StyleType.Text:
                    pbxPreview.Image = DrawSampleImage(pbxPreview.Image, textStyle);
                    break;
                case StyleType.Line:
                    pbxPreview.Image = DrawSampleImage(pbxPreview.Image, lineStyle);
                    break;
                case StyleType.Point:
                    pbxPreview.Image = DrawSampleImage(pbxPreview.Image, pointStyle);
                    break;
                case StyleType.Area:
                    pbxPreview.Image = DrawSampleImage(pbxPreview.Image, areaStyle);
                    break;
                default:
                    break;
            }
            pbxPreview.Invalidate();
        }

        private static Image DrawSampleImage(Image image, Style style)
        {
            Image newImage = new Bitmap(image.Width, image.Height);
            image.Dispose();
            GdiPlusGeoCanvas canvas = new GdiPlusGeoCanvas();
            canvas.BeginDrawing(newImage, new RectangleShape(0, newImage.Width, newImage.Height, 0), GeographyUnit.DecimalDegree);
            style.DrawSample(canvas);

            if (canvas.IsDrawing)
            {
                canvas.EndDrawing();
            }

            return newImage;
        }

        private void StyleEditor_ParentChanged(object sender, EventArgs e)
        {
            DrawPreviewImage();
            object style = null;
            switch (styleType)
            {
                case StyleType.Text:
                    SetTextStyle();
                    break;
                case StyleType.Line:
                    style = new MyLineStyle(lineStyle);
                    break;
                case StyleType.Point:
                    style = new MyPointStyle(pointStyle);
                    break;
                case StyleType.Area:
                    style = new MyAreaStyle(areaStyle);
                    break;
                default:
                    break;
            }
            if (style != null)
            {
                gridStyle.SelectedObject = style;
            }
        }

        private void SetTextStyle()
        {
            object grid = gridStyle;
            gridStyle.ShowCustomProperties = true;
            gridStyle.Item.Add("Font", new Font("Areial", 9), false, string.Empty, "The font of text", true);

            gridStyle.Item.Add("TextColor", Color.Black, false, string.Empty, "the color of text solid bursh", true);
            gridStyle.Item.Add("TextColumnName", string.Empty, false, string.Empty, string.Empty, true);

            gridStyle.Item[gridStyle.Item.Count - 1].Choices = new PropertyGridEx.CustomChoices(ColumnNames, true);
            if (textStyle.TextColumnName != string.Empty)
            {
                gridStyle.Item[gridStyle.Item.Count - 1].Value = textStyle.TextColumnName;
            }

            gridStyle.Item[0].Value = new Font(textStyle.Font.FontName, textStyle.Font.Size);
            if ((int)textStyle.TextSolidBrush.Color.RedComponent == 255 &&
                (int)textStyle.TextSolidBrush.Color.GreenComponent == 255 &&
                (int)textStyle.TextSolidBrush.Color.BlueComponent == 255)
            {

            }
            else
            {
                gridStyle.Item[1].Value = Color.FromArgb((int)textStyle.TextSolidBrush.Color.RedComponent,
                                            (int)textStyle.TextSolidBrush.Color.GreenComponent,
                                            (int)textStyle.TextSolidBrush.Color.BlueComponent);
            }
        }
    }
}
