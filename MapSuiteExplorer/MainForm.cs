using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using ThinkGeo.MapSuite.Core;
using System.Collections.Generic;
using System.Diagnostics;
using ThinkGeo.MapSuite.DesktopEdition;
using System.Threading;

namespace MapSuiteExplorer
{
    internal partial class MainForm : Form
    {
        private const int splitterDistance = 142;
        private const int widthOfThemeView = 140;

        private FormFeatures frmFeatures;
        // set selected themeItem which will move up/down
        private int selectedOrder = -1;
        private Collection<string> filesWithoutIndex;
        private Collection<string> addedFiles;
        private Int32 id = 100;// HotKey id
        private const int WM_HOTKEY = 0x0312;// HotKey message

        internal MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            filesWithoutIndex = new Collection<string>();
            addedFiles = new Collection<string>();

            winformsMap1.MapUnit = GeographyUnit.DecimalDegree;
            winformsMap1.CurrentExtent = new RectangleShape(-90, 45, 90, -45);
            winformsMap1.MouseMove += new MouseEventHandler(winformsMap1_MouseMove);
            winformsMap1.MapClick += new EventHandler<MapClickWinformsMapEventArgs>(winformsMap1_MapClick);
            this.themeView.ThemeViewDragDrop += new EventHandler<DragDropItemEventArgs>(themeView_ThemeViewDragDrop);
            this.themeView.VScrollVisible += new EventHandler<EventArgs>(themeView_VScrollVisible);

            RegHotkey();

            SetupContextMenu();

            winformsMap1.BackgroundOverlay.BackgroundBrush = new GeoSolidBrush(GeoColor.StandardColors.White);

            SetScaleLineAdornment();

            winformsMap1.Overlays.Add(new LayerOverlay());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnRegHotKey();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? e.Effect = DragDropEffects.All : DragDropEffects.None;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] draggedPaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            if ((draggedPaths != null) && (draggedPaths.Length > 0))
            {
                filesWithoutIndex.Clear();
                addedFiles.Clear();

                foreach (string draggedPath in draggedPaths)
                {
                    if (draggedPath.EndsWith(".shp", StringComparison.OrdinalIgnoreCase) && File.Exists(draggedPath))
                    {
                        AddShapeFileFeatureLayers(new string[] { draggedPath });
                    }
                    else if (ExplorerHelper.IsRasterLayerFile(draggedPath) && File.Exists(draggedPath))
                    {
                        AddRasterLayers(new string[] { draggedPath });
                    }
                    else if (Directory.Exists(draggedPath))
                    {
                        AddLayersByFolder(draggedPath);
                    }
                }

                if (filesWithoutIndex.Count > 0)
                {
                    CancelAddingLayer();
                }

                SetCurrentExtent();

                themeView.SetupItems();
                DrawImage();
            }
        }

        private void winformsMap1_MouseMove(object sender, MouseEventArgs e)
        {
            if (((LayerOverlay)winformsMap1.Overlays[0]).Layers.Count > 0)
            {
                ShowCoordinate(e);
            }
        }

        private void winformsMap1_MapClick(object sender, MapClickWinformsMapEventArgs e)
        {
            if (tbnInformation.Checked)
            {
                SelectInformation(e.WorldLocation);
            }
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            FormAbout frmAbout = new FormAbout();
            frmAbout.ShowDialog();
        }

        private void mnuHelpDiscussionForums_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.DiscussionForum);
        }

        private void themeItem_ThemeItemClick(object sender, LayerOrderEventArgs e)
        {
            for (int i = 0; i < themeView.Items.Count; i++)
            {
                if (e.Name == themeView.Items[i].ShapeName)
                {
                    selectedOrder = i;
                    themeView.Items[i].BorderStyle = BorderStyle.Fixed3D;
                    themeView.Items[i].BackColor = Color.FromArgb(100, 74, 142, 207);
                }
                else
                {
                    themeView.Items[i].BorderStyle = BorderStyle.FixedSingle;
                    themeView.Items[i].BackColor = Color.White;
                }
            }
        }

        private void themeItem_ItemLinkClicked(object sender, ShapeLinkClickedEventArgs e)
        {
            switch (e.LinkType)
            {
                case LinkType.Edit:
                    if (((LayerOverlay)winformsMap1.Overlays[0]).Layers.Contains(e.ShapeName))
                    {
                        EditLayerStyle(((LayerOverlay)winformsMap1.Overlays[0]).Layers[e.ShapeName] as FeatureLayer);
                    }
                    break;
                case LinkType.Features:
                    if (((LayerOverlay)winformsMap1.Overlays[0]).Layers.Contains(e.ShapeName))
                    {
                        ShowAllFeatures(((LayerOverlay)winformsMap1.Overlays[0]).Layers[e.ShapeName] as FeatureLayer);
                    }
                    break;
                case LinkType.Remove:
                    if (MessageBox.Show(string.Format(CultureInfo.InvariantCulture, Properties.Resources.RemoveLayerPrompt, e.ShapeName), "Remove Layer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0) == DialogResult.Yes)
                    {
                        RemoveShapefile(e.ShapeName);
                    }
                    break;
                case LinkType.ZoomToExtent:
                    if (((LayerOverlay)winformsMap1.Overlays[0]).Layers.Contains(e.ShapeName))
                    {
                        TrackToExtent(((LayerOverlay)winformsMap1.Overlays[0]).Layers[e.ShapeName]);
                    }
                    break;
                default:
                    break;
            }
        }

        private void themeItem_ItemCheckedChanged(object sender, ShapeEventArgs e)
        {
            if (((LayerOverlay)winformsMap1.Overlays[0]).Layers.Contains(e.ShapeName))
            {
                winformsMap1.Overlays[0].Lock.EnterWriteLock();
                try
                {
                    ((LayerOverlay)winformsMap1.Overlays[0]).Layers[e.ShapeName].IsVisible = e.IsShow;
                }
                finally
                {
                    winformsMap1.Overlays[0].Lock.ExitWriteLock();
                }
                try
                {
                    DrawImage();
                }
                catch
                {
                }
            }
        }

        private void mnuFileAddNewLayer_Click(object sender, EventArgs e)
        {
            AddLayersByOpenFileDialog();
        }

        private void mnuRemoveAll_Click(object sender, EventArgs e)
        {
            RemoveAllShapefiles();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;

            if (toolStripMenuItem != null)
            {
                Action(toolStripMenuItem.Tag.ToString());
            }
        }

        private void ToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripButton button = e.ClickedItem as ToolStripButton;
            if (button != null)
            {
                Action(button.Tag.ToString());
            }
        }

        private void themeView_ThemeViewDragDrop(object sender, DragDropItemEventArgs e)
        {
            winformsMap1.Overlays[0].Lock.EnterWriteLock();
            try
            {
                ((LayerOverlay)winformsMap1.Overlays[0]).Layers.MoveTo(e.FromOrder, e.ToOrder);
            }
            finally
            {
                winformsMap1.Overlays[0].Lock.ExitWriteLock();
            }
            winformsMap1.Refresh();

            selectedOrder = e.ToOrder;
        }

        private void themeView_VScrollVisible(object sender, EventArgs e)
        {
            if (themeView.VerticalScroll.Visible)
            {
                splitContainer.SplitterDistance = splitterDistance + 16;
                themeView.Width = widthOfThemeView + 16;
            }
            else
            {
                splitContainer.SplitterDistance = splitterDistance;
                themeView.Width = widthOfThemeView;
            }
        }

        private void themeItem_ThemeItemRightClick(object sender, RightClickEventArgs e)
        {
            contextMenuStrip.Show(e.Point);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                DoHotkey(m);
            }
            base.WndProc(ref m);
        }

        private void DoHotkey(Message m)
        {
            IntPtr i = m.WParam;
            if (i.ToInt32() == id)
            {
                GeographyUnitTool geographyUnitTool = new GeographyUnitTool();
                geographyUnitTool.CurrentUnit = winformsMap1.MapUnit;
                geographyUnitTool.ShowDialog();
                if (winformsMap1.MapUnit != geographyUnitTool.CurrentUnit)
                {
                    winformsMap1.Refresh();
                }
            }
        }

        private RectangleShape GetFullExtent(float screenWidth, float screenHeight)
        {
            RectangleShape boundingBox = null;

            foreach (Layer layer in ((LayerOverlay)winformsMap1.Overlays[0]).Layers)
            {
                if (layer.HasBoundingBox)
                {
                    if (!layer.IsOpen) { layer.Open(); }
                    if (boundingBox == null)
                    {
                        boundingBox = layer.GetBoundingBox();
                    }
                    else
                    {
                        boundingBox.ExpandToInclude(layer.GetBoundingBox());
                    }
                }
            }

            if (boundingBox != null)
            {
                boundingBox = MapEngine.GetDrawingExtent(boundingBox, screenWidth, screenHeight);
            }

            return boundingBox;
        }

        private void RegHotkey()
        {
            id = this.GetType().GetHashCode();

            //0 is none,1 is Alt,2 is Control,4 is Shift,8 is Windows
            NativeMethods.RegisterHotKey(this.Handle, id, 7, Keys.D8);//Ctrl+Shift+Alt+8
        }

        private void UnRegHotKey()
        {
            NativeMethods.UnregisterHotKey(this.Handle, id);
        }

        private void ShowCoordinate(MouseEventArgs e)
        {
            PointShape WorldPointR = ExtentHelper.ToWorldCoordinate(winformsMap1.CurrentExtent, e.X, e.Y, winformsMap1.Width, winformsMap1.Height);
            statusStrip.Items[1].Text = string.Format(CultureInfo.InvariantCulture, "X: {0:F4} Y: {1:F4}", WorldPointR.X, WorldPointR.Y);
            statusStrip.Items[2].Text = string.Format(CultureInfo.InvariantCulture, "X: {0} Y: {1}", e.X, e.Y);

            if (winformsMap1.MapUnit == GeographyUnit.DecimalDegree && ((WorldPointR.X > -180 && WorldPointR.X < 180 && WorldPointR.Y > -90 && WorldPointR.Y < 90)))
            {
                statusStrip.Items[0].Text = DecimalDegreesHelper.GetDegreesMinutesSecondsStringFromDecimalDegreePoint(WorldPointR);
                return;
            }

            statusStrip.Items[0].Text = "";
        }

        private void SetBackgroudColor()
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                GeoColor geocolor = new GeoColor(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                winformsMap1.BackgroundOverlay.Lock.EnterWriteLock();
                try
                {
                    winformsMap1.BackgroundOverlay.BackgroundBrush = new GeoSolidBrush(geocolor);
                }
                finally
                {
                    winformsMap1.BackgroundOverlay.Lock.ExitWriteLock();
                }
                winformsMap1.Refresh();
            }
        }

        private void SetCurrentExtent()
        {
            if (((LayerOverlay)winformsMap1.Overlays[0]).Layers.Count == 1)
            {
                RectangleShape currentBoundingBox = GetFullExtent(winformsMap1.Width, winformsMap1.Height);
                if (currentBoundingBox != null)
                {
                    winformsMap1.CurrentExtent = currentBoundingBox;
                }
            }
        }

        private void SetScaleLineAdornment()
        {
            ScaleLineAdornmentLayer scaleLine = new ScaleLineAdornmentLayer(AdornmentLocation.LowerLeft);
            scaleLine.XOffsetInPixel = 5;
            scaleLine.YOffsetInPixel = -5;

            winformsMap1.AdornmentOverlay.Layers.Add("ScaleLine", scaleLine);
        }

        private void SetupContextMenu()
        {
            foreach (ToolStripItem item in mnuCurrentLayer.DropDownItems)
            {
                if (item is ToolStripSeparator)
                {
                    contextMenuStrip.Items.Add(new ToolStripSeparator());
                }
                else
                {
                    ToolStripItem contextItem = new ToolStripMenuItem(item.Text, item.Image);
                    contextItem.Tag = item.Tag;
                    contextItem.Click += new EventHandler(MenuItem_Click);
                    contextMenuStrip.Items.Add(contextItem);
                }
            }
        }

        /// <summary>
        /// Cancel Adding Layer or not
        /// </summary>
        /// <returns>
        /// true: Cancel
        /// false: Yes,No
        /// </returns>
        private void CancelAddingLayer()
        {
            string buildIndexMessage = string.Format(Properties.Resources.BuildIndexFilePrompt, filesWithoutIndex[0]);
            DialogResult result = MessageBox.Show(buildIndexMessage, "Build Index File", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
            Application.DoEvents();
            switch (result)
            {
                case DialogResult.Cancel:
                    foreach (string fileName in addedFiles)
                    {
                        string shapeName = new FileInfo(fileName).Name;
                        winformsMap1.Overlays[0].Lock.EnterWriteLock();
                        try
                        {
                            ((LayerOverlay)winformsMap1.Overlays[0]).Layers.Remove(shapeName);
                        }
                        finally
                        {
                            winformsMap1.Overlays[0].Lock.ExitWriteLock();
                        }
                        if (themeView.Items.Contains(shapeName))
                        {
                            themeView.Items.Remove(shapeName);
                        }
                    }
                    themeView.SetupItems();
                    break;
                case DialogResult.Yes:
                case DialogResult.OK:
                    BuildIndexTool buildIndexTool = new BuildIndexTool(filesWithoutIndex);
                    buildIndexTool.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void SetupThemeItem(Layer layer)
        {
            ThemeItem themeItem = new ThemeItem();

            themeItem.ShapeName = layer.Name;

            themeItem.ItemCheckedChanged += new EventHandler<ShapeEventArgs>(themeItem_ItemCheckedChanged);
            themeItem.ItemLinkClicked += new EventHandler<ShapeLinkClickedEventArgs>(themeItem_ItemLinkClicked);
            themeItem.ThemeItemClick += new EventHandler<LayerOrderEventArgs>(themeItem_ThemeItemClick);
            themeItem.ThemeItemRightClick += new EventHandler<RightClickEventArgs>(themeItem_ThemeItemRightClick);

            themeView.Items.Add(layer.Name, themeItem);
        }

        private void TrackToExtent(Layer layer)
        {
            layer.Open();
            RectangleShape extent = layer.GetBoundingBox();
            layer.Close();

            winformsMap1.CurrentExtent = ExtentHelper.GetDrawingExtent(extent, winformsMap1.Width, winformsMap1.Height);

            winformsMap1.Refresh();
        }

        private void EditLayerStyle(FeatureLayer layer)
        {
            if (layer != null)
            {
                FormStyleEditor frmStyleEditor = new FormStyleEditor();

                frmStyleEditor.CurrentStyleType = themeView.Items[selectedOrder].StyleType;
                frmStyleEditor.ColumnNames = ExplorerHelper.GetColumnNames(layer);

                frmStyleEditor.BaseLayer = layer;

                // store layer status and will recover it after serialize/deserialize
                bool isOpened = layer.IsOpen;
                // close layer to avoid serialize exception
                layer.Close();

                //  clone layer
                Layer clonedLayer = layer.CloneDeep();

                DialogResult isStyleChanged;
                winformsMap1.Overlays[0].Lock.EnterWriteLock();
                try
                {
                    isStyleChanged = frmStyleEditor.ShowDialog();
                }
                finally
                {
                    winformsMap1.Overlays[0].Lock.ExitWriteLock();
                }
                if (isStyleChanged == DialogResult.OK)
                {
                    themeView.Items[selectedOrder].StyleType = frmStyleEditor.CurrentStyleType;
                    winformsMap1.Refresh();
                }
                else
                {
                    // because user cancel modify style, so restore layer
                    ((LayerOverlay)winformsMap1.Overlays[0]).Layers[selectedOrder] = clonedLayer;
                }

                // recover layer status
                if (isOpened) { layer.Open(); }
            }
        }

        private void ShowAllFeatures(FeatureLayer layer)
        {
            if (layer != null)
            {
                if (frmFeatures == null)
                {
                    frmFeatures = new FormFeatures();
                }

                frmFeatures.TableName = Path.GetFileNameWithoutExtension(layer.Name);
                frmFeatures.ShapeFileLayer = layer;
                frmFeatures.ShowDialog();
            }
        }

        private void RemoveShapefile(string shapeName)
        {
            for (int i = 0; i < themeView.Items.Count; i++)
            {
                if (shapeName == themeView.Items[i].ShapeName)
                {
                    if (selectedOrder == i)
                    {
                        selectedOrder = -1;
                    }
                    break;
                }
            }

            winformsMap1.Overlays[0].Lock.EnterWriteLock();
            try
            {
                ((LayerOverlay)winformsMap1.Overlays[0]).Layers.Remove(shapeName);
            }
            finally
            {
                winformsMap1.Overlays[0].Lock.ExitWriteLock();
            }

            if (themeView.Items.Contains(shapeName))
            {
                themeView.Items.Remove(shapeName);
                themeView.SetupItems();
            }

            winformsMap1.Refresh();
        }

        private void RemoveAllShapefiles()
        {
            if (MessageBox.Show(Properties.Resources.RemoveAllLayerPrompt, "Remove All Layers", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0) == DialogResult.Yes)
            {
                selectedOrder = -1;
                winformsMap1.Overlays[0].Lock.EnterWriteLock();
                try
                {
                    ((LayerOverlay)winformsMap1.Overlays[0]).Layers.Clear();
                }
                finally
                {
                    winformsMap1.Overlays[0].Lock.ExitWriteLock();
                }
                themeView.Items.Clear();
                themeView.SetupItems();

                winformsMap1.Refresh();
            }
        }

        private void RemoveShapefile(FileNotFoundException ex)
        {
            MessageBox.Show(ex.Message + "\r\n" + ex.FileName, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
            string shapeName = new FileInfo(Path.ChangeExtension(ex.FileName, ".shp")).Name;
            winformsMap1.Overlays[0].Lock.EnterWriteLock();
            try
            {
                ((LayerOverlay)winformsMap1.Overlays[0]).Layers.Remove(shapeName);
            }
            finally
            {
                winformsMap1.Overlays[0].Lock.ExitWriteLock();
            }
            if (themeView.Items.Contains(shapeName))
            {
                themeView.Items.Remove(shapeName);
                themeView.SetupItems();
            }
        }

        private void SelectInformation(PointShape worldPoint)
        {
            try
            {
                Collection<Feature> selectedFeatures = new Collection<Feature>();

                foreach (Layer layer in ((LayerOverlay)winformsMap1.Overlays[0]).Layers)
                {
                    FeatureLayer featureLayer = layer as FeatureLayer;
                    if (featureLayer != null)
                    {
                        featureLayer.Open();
                        Collection<Feature> nearestFeatures = featureLayer.QueryTools.GetFeaturesNearestTo(worldPoint, winformsMap1.MapUnit, 1, ReturningColumnsType.AllColumns);
                        double radius = 10.0 / winformsMap1.Width * winformsMap1.CurrentExtent.Width;
                        EllipseShape searchingEllipse = new EllipseShape(worldPoint, radius, radius);

                        foreach (Feature feature in nearestFeatures)
                        {
                            Feature selectedFeature = feature;
                            selectedFeature.Tag = featureLayer.Name;

                            BaseShape currentShape = feature.GetShape();

                            if (currentShape is AreaBaseShape)
                            {
                                if (currentShape.Contains(worldPoint))
                                {
                                    selectedFeatures.Add(selectedFeature);
                                }
                            }
                            else if (currentShape is LineBaseShape)
                            {
                                if (currentShape.Intersects(searchingEllipse))
                                {
                                    selectedFeatures.Add(selectedFeature);
                                }
                            }
                            else if (currentShape is PointBaseShape)
                            {
                                if (searchingEllipse.Contains(currentShape))
                                {
                                    selectedFeatures.Add(selectedFeature);
                                }
                            }
                        }
                        featureLayer.Close();
                    }
                }

                if (selectedFeatures.Count > 0)
                {
                    FormInformation frmInformation = new FormInformation(selectedFeatures);
                    frmInformation.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
            }
        }

        private void Action(string tag)
        {
            switch (tag)
            {
                case "Add New Layer":
                    AddLayersByOpenFileDialog();
                    break;
                case "Add Folder":
                    AddLayersByFolderBrowserDialog();
                    break;
                case "Backgroud Color":
                    SetBackgroudColor();
                    break;
                case "Information":
                    tbnInformation.Checked = !tbnInformation.Checked;
                    mnuToolsInformation.Checked = tbnInformation.Checked;
                    break;
                default:
                    OperateMap(tag);
                    break;
            }
        }

        private void OperateMap(string tag)
        {
            if (((LayerOverlay)winformsMap1.Overlays[0]).Layers.Count > 0)
            {
                bool needRefresh = true;
                switch (tag)
                {
                    case "Zoom In":
                        winformsMap1.ZoomIn(50);
                        break;
                    case "Zoom Out":
                        winformsMap1.ZoomOut(50);
                        break;
                    case "Full Extent":
                        winformsMap1.CurrentExtent = GetFullExtent(winformsMap1.Width, winformsMap1.Height);
                        break;
                    case "Toggle Extent":
                        winformsMap1.ToggleMapExtents();
                        break;
                    case "Previous Extent":
                        winformsMap1.ZoomToPreviousExtent();
                        break;
                    case "Pan Left":
                        winformsMap1.Pan(PanDirection.Left, 20);
                        break;
                    case "Pan Right":
                        winformsMap1.Pan(PanDirection.Right, 20);
                        break;
                    case "Pan Up":
                        winformsMap1.Pan(PanDirection.Up, 20);
                        break;
                    case "Pan Down":
                        winformsMap1.Pan(PanDirection.Down, 20);
                        break;
                    default:
                        needRefresh = false;
                        OperateLayer(tag);
                        break;
                }

                if (needRefresh)
                {
                    winformsMap1.Refresh();
                }
            }
        }

        private void OperateLayer(string tag)
        {
            if (selectedOrder == -1)
            {
                MessageBox.Show(Properties.Resources.NoLayerSelected, "No Layer Selected", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                return;
            }

            switch (tag)
            {
                case "Move Up":
                    MoveUpDown(MoveType.MoveUp);
                    break;
                case "Move Down":
                    MoveUpDown(MoveType.MoveDown);
                    break;
                case "Move To Top":
                    MoveUpDown(MoveType.MoveToTop);
                    break;
                case "Move To Bottom":
                    MoveUpDown(MoveType.MoveToBottom);
                    break;
                case "Track To Extent":
                    TrackToExtent(((LayerOverlay)winformsMap1.Overlays[0]).Layers[selectedOrder]);
                    break;
                case "Change The Style":
                    EditLayerStyle(((LayerOverlay)winformsMap1.Overlays[0]).Layers[selectedOrder] as FeatureLayer);
                    break;
                case "Show Features":
                    ShowAllFeatures(((LayerOverlay)winformsMap1.Overlays[0]).Layers[selectedOrder] as FeatureLayer);
                    break;
                default:
                    break;
            }
        }

        // use OpenFileDialog
        private void AddLayersByOpenFileDialog()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filesWithoutIndex.Clear();
                addedFiles.Clear();

                Collection<string> rasterFilenames = new Collection<string>();
                Collection<string> featureFilenames = new Collection<string>();

                foreach (string filename in openFileDialog.FileNames)
                {
                    if (ExplorerHelper.IsRasterLayerFile(filename))
                    {
                        rasterFilenames.Add(filename);
                    }
                    else
                    {
                        featureFilenames.Add(filename);
                    }
                }

                AddShapeFileFeatureLayers(featureFilenames);
                AddRasterLayers(rasterFilenames);

                if (filesWithoutIndex.Count > 0)
                {
                    CancelAddingLayer();
                }

                SetCurrentExtent();

                themeView.SetupItems();

                DrawImage();
            }
        }

        private void AddLayersByFolderBrowserDialog()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(folderBrowserDialog.SelectedPath))
                {
                    filesWithoutIndex.Clear();
                    addedFiles.Clear();

                    AddLayersByFolder(folderBrowserDialog.SelectedPath);
                }

                if (filesWithoutIndex.Count > 0)
                {
                    CancelAddingLayer();
                }

                SetCurrentExtent();

                themeView.SetupItems();

                DrawImage();
            }
        }

        private void AddShapeFileFeatureLayers(IEnumerable<string> fileNames)
        {
            foreach (string fileName in fileNames)
            {
                try
                {
                    string layerName = new FileInfo(fileName).Name;
                    if (!((LayerOverlay)winformsMap1.Overlays[0]).Layers.Contains(layerName))
                    {
                        ShapeFileFeatureLayer layer = new ShapeFileFeatureLayer(fileName);
                        layer.Name = layerName;
                        ExplorerHelper.SetStyleByWellKnownType(layer);
                        layer.ZoomLevelSet.ZoomLevel01.ApplyUntilZoomLevel = ApplyUntilZoomLevel.Level20;
                        winformsMap1.Overlays[0].Lock.EnterWriteLock();
                        try
                        {
                            ((LayerOverlay)winformsMap1.Overlays[0]).Layers.Add(layerName, layer);
                        }
                        finally
                        {
                            winformsMap1.Overlays[0].Lock.ExitWriteLock();
                        }

                        SetupThemeItem(layer);

                        if ((!File.Exists(layer.IndexPathFileName)) || (!File.Exists(layer.IndexPathFileName.ToUpper().Replace(".IDX", ".IDS"))))
                        {
                            filesWithoutIndex.Add(fileName);
                        }
                        addedFiles.Add(fileName);
                    }
                }
                catch (FileLoadException fle)
                {
                    RemoveShapefile((FileNotFoundException)fle.InnerException);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                }
            }
        }

        private void AddRasterLayers(IEnumerable<string> fileNames)
        {
            foreach (string fileName in fileNames)
            {
                try
                {
                    string layerName = new FileInfo(fileName).Name;

                    if (!((LayerOverlay)winformsMap1.Overlays[0]).Layers.Contains(layerName))
                    {
                        RasterLayer rasterLayer = null;
                        switch (Path.GetExtension(fileName).ToUpperInvariant())
                        {
                            case ".SID":
                                rasterLayer = new MrSidRasterLayer(fileName);
                                break;
                            case ".ECW":
                                rasterLayer = new EcwRasterLayer(fileName);
                                break;
                            case ".JP2":
                                rasterLayer = new Jpeg2000RasterLayer(fileName);
                                break;
                            case ".BMP":
                            case ".JPG":
                            case ".JPEG":
                            case ".GIF":
                            case ".TIFF":
                            case ".TIF":
                                rasterLayer = new GdiPlusRasterLayer(fileName);
                                break;
                            default:
                                break;
                        }

                        if (rasterLayer != null && ExplorerHelper.ValidateRasterLayer(rasterLayer))
                        {
                            rasterLayer.Name = layerName;
                            winformsMap1.Overlays[0].Lock.EnterWriteLock();
                            try
                            {
                                ((LayerOverlay)winformsMap1.Overlays[0]).Layers.Add(layerName, rasterLayer);
                            }
                            finally
                            {
                                winformsMap1.Overlays[0].Lock.ExitWriteLock();
                            }
                            SetupThemeItem(rasterLayer);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                }
            }
        }

        private void MoveUpDown(MoveType moveType)
        {
            switch (moveType)
            {
                case MoveType.MoveUp:
                    if (selectedOrder != themeView.Items.Count - 1)
                    {
                        themeView.Items.MoveUp(selectedOrder);
                        winformsMap1.Overlays[0].Lock.EnterWriteLock();
                        try
                        {
                            ((LayerOverlay)winformsMap1.Overlays[0]).Layers.MoveUp(selectedOrder);
                        }
                        finally
                        {
                            winformsMap1.Overlays[0].Lock.ExitWriteLock();
                        }
                        selectedOrder++;
                    }
                    break;
                case MoveType.MoveDown:
                    if (selectedOrder != 0)
                    {
                        themeView.Items.MoveDown(selectedOrder);
                        winformsMap1.Overlays[0].Lock.EnterWriteLock();
                        try
                        {
                            ((LayerOverlay)winformsMap1.Overlays[0]).Layers.MoveDown(selectedOrder);
                        }
                        finally
                        {
                            winformsMap1.Overlays[0].Lock.ExitWriteLock();
                        }
                        selectedOrder--;
                    }
                    break;
                case MoveType.MoveToTop:
                    if (selectedOrder != themeView.Items.Count - 1)
                    {
                        themeView.Items.MoveToTop(selectedOrder);
                        winformsMap1.Overlays[0].Lock.EnterWriteLock();
                        try
                        {
                            ((LayerOverlay)winformsMap1.Overlays[0]).Layers.MoveToTop(selectedOrder);
                        }
                        finally
                        {
                            winformsMap1.Overlays[0].Lock.ExitWriteLock();
                        }
                        selectedOrder = themeView.Items.Count - 1;
                    }
                    break;
                case MoveType.MoveToBottom:
                    if (selectedOrder != 0)
                    {
                        themeView.Items.MoveToBottom(selectedOrder);
                        winformsMap1.Overlays[0].Lock.EnterWriteLock();
                        try
                        {
                            ((LayerOverlay)winformsMap1.Overlays[0]).Layers.MoveToBottom(selectedOrder);
                        }
                        finally
                        {
                            winformsMap1.Overlays[0].Lock.ExitWriteLock();
                        }
                        selectedOrder = 0;
                    }
                    break;
                default:
                    break;
            }

            themeView.SetupItems();

            winformsMap1.Refresh();
        }

        private void DrawImage()
        {
            try
            {
                winformsMap1.Refresh();
            }
            catch (FileLoadException fileLoadException)
            {
                RemoveShapefile((FileNotFoundException)fileLoadException.InnerException);
            }
            catch (Exception ex)
            {
                foreach (ThemeItem themeItem in themeView.Items)
                {
                    themeItem.IsShow = false;
                }
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                return;
            }
        }

        private void AddLayersByFolder(string folderName)
        {
            string[] fileNames = Directory.GetFiles(folderName, "*.*", SearchOption.AllDirectories);

            Collection<string> rasterFilenames = new Collection<string>();
            Collection<string> featureFilenames = new Collection<string>();

            foreach (string filename in fileNames)
            {
                if (ExplorerHelper.IsRasterLayerFile(filename))
                {
                    rasterFilenames.Add(filename);
                }
                else if (filename.ToUpperInvariant().Contains(".SHP"))
                {
                    featureFilenames.Add(filename);
                }
            }

            AddShapeFileFeatureLayers(featureFilenames);
            AddRasterLayers(rasterFilenames);
        }
    }
}
