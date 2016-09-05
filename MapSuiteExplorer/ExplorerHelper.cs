using System;
using System.Collections.Generic;
using System.Text;
using ThinkGeo.MapSuite.Core;
using System.Collections.ObjectModel;

namespace MapSuiteExplorer
{
    internal static class ExplorerHelper
    {
        public static void SetStyleByWellKnownType(FeatureLayer layer)
        {
            if (layer.Name.IndexOf("thinkgeo", StringComparison.OrdinalIgnoreCase) != -1)
            {
                layer.ZoomLevelSet.ZoomLevel01.DefaultLineStyle = new LineStyle(new GeoPen(GetRandomColor(ColorType.Bright), 1));
                layer.ZoomLevelSet.ZoomLevel01.DefaultPointStyle = new PointStyle(PointSymbolType.Circle, new GeoSolidBrush(GeoColor.FromArgb(190, GetRandomColor(ColorType.All))), new GeoPen(GeoColor.StandardColors.Black), 9);
                layer.ZoomLevelSet.ZoomLevel01.DefaultAreaStyle = new AreaStyle(new GeoPen(GeoColor.StandardColors.Black, 1), new GeoSolidBrush(new GeoColor(65, GetRandomColor(ColorType.All))));
                return;
            }

            layer.ZoomLevelSet.ZoomLevel01.DefaultLineStyle.OuterPen = new GeoPen(GeoColor.SimpleColors.Black, 1);
            layer.ZoomLevelSet.ZoomLevel01.DefaultPointStyle = new PointStyle(PointSymbolType.Circle, new GeoSolidBrush(GeoColor.SimpleColors.Black), 9);
            layer.ZoomLevelSet.ZoomLevel01.DefaultAreaStyle.OutlinePen = new GeoPen(GeoColor.SimpleColors.Black, 1);
        }

        public static GeoColor GetRandomColor(ColorType ColorType)
        {
            GeoColor randomColor = new GeoColor();
            Random random = new Random();
            int Number = random.Next(0, 10);

            switch (ColorType)
            {
                case ColorType.All:
                    {
                        int R = random.Next(0, 255);
                        int G = random.Next(0, 255);
                        int B = random.Next(0, 255);
                        randomColor = GeoColor.FromArgb(255, R, G, B);
                    }
                    break;
                case ColorType.Bright:
                    {
                        GeoColor[] Colors = new GeoColor[10];
                        Colors[0] = GeoColor.StandardColors.Blue;
                        Colors[1] = GeoColor.StandardColors.Green;
                        Colors[2] = GeoColor.StandardColors.Red;
                        Colors[3] = GeoColor.StandardColors.Orange;
                        Colors[4] = GeoColor.StandardColors.Magenta;
                        Colors[5] = GeoColor.StandardColors.LimeGreen;
                        Colors[6] = GeoColor.StandardColors.Brown;
                        Colors[7] = GeoColor.StandardColors.Yellow;
                        Colors[8] = GeoColor.StandardColors.Purple;
                        Colors[9] = GeoColor.StandardColors.Maroon;

                        randomColor = Colors[Number];
                    }
                    break;
                case ColorType.Pastel:
                    {
                        GeoColor[] Colors = new GeoColor[10];
                        Colors[0] = GeoColor.StandardColors.LightBlue;
                        Colors[1] = GeoColor.StandardColors.LightCoral;
                        Colors[2] = GeoColor.StandardColors.LightCyan;
                        Colors[3] = GeoColor.StandardColors.LightGreen;
                        Colors[4] = GeoColor.StandardColors.LightGoldenrodYellow;
                        Colors[5] = GeoColor.StandardColors.LightSkyBlue;
                        Colors[6] = GeoColor.StandardColors.LightSteelBlue;
                        Colors[7] = GeoColor.StandardColors.LightPink;
                        Colors[8] = GeoColor.StandardColors.LightSalmon;
                        Colors[9] = GeoColor.StandardColors.LightSeaGreen;

                        randomColor = Colors[Number];
                    }
                    break;
            }
            return randomColor;
        }

        public static string[] GetColumnNames(FeatureLayer layer)
        {
            layer.FeatureSource.Open();

            List<string> columnNameList = new List<string>();
            Collection<FeatureSourceColumn> columns = layer.FeatureSource.GetColumns();
            foreach (FeatureSourceColumn myColumn in columns)
            {
                columnNameList.Add(myColumn.ColumnName);
            }

            layer.FeatureSource.Close();

            return columnNameList.ToArray();
        }

        public static bool IsRasterLayerFile(string filename)
        {
            bool result = false;
            string upperFilename = filename.ToUpperInvariant();

            if (upperFilename.EndsWith(".SID", StringComparison.OrdinalIgnoreCase)
                || upperFilename.EndsWith(".ECW", StringComparison.OrdinalIgnoreCase)
                || upperFilename.EndsWith(".JP2", StringComparison.OrdinalIgnoreCase)
                || upperFilename.EndsWith(".JPEG", StringComparison.OrdinalIgnoreCase)
                || upperFilename.EndsWith(".JPG", StringComparison.OrdinalIgnoreCase)
                || upperFilename.EndsWith(".GIF", StringComparison.OrdinalIgnoreCase)
                || upperFilename.EndsWith(".TIF", StringComparison.OrdinalIgnoreCase)
                || upperFilename.EndsWith(".TIFF", StringComparison.OrdinalIgnoreCase)
                || upperFilename.EndsWith(".BMP", StringComparison.OrdinalIgnoreCase))
            {
                result = true;
            }

            return result;
        }

        public static bool ValidateRasterLayer(RasterLayer rasterLayer)
        {
            bool isValidate = true;

            try
            {
                rasterLayer.Open();
            }
            catch (Exception)
            {
                isValidate = false;
            }
            finally
            {
                if (rasterLayer.IsOpen)
                {
                    rasterLayer.Close();
                }
            }

            return isValidate;
        }
    }
}
