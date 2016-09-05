using System.Windows.Forms;

namespace MapSuiteExplorer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            //if (bitmap != null) { bitmap.Dispose(); }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tbtnAddLayer = new System.Windows.Forms.ToolStripButton();
            this.tSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbnMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tbnMoveDown = new System.Windows.Forms.ToolStripButton();
            this.tbnMoveToTop = new System.Windows.Forms.ToolStripButton();
            this.tbnMoveToBottom = new System.Windows.Forms.ToolStripButton();
            this.tSep14 = new System.Windows.Forms.ToolStripSeparator();
            this.tbnTrackToExtent = new System.Windows.Forms.ToolStripButton();
            this.tbnChangeTheStyle = new System.Windows.Forms.ToolStripButton();
            this.tbnShowFeatures = new System.Windows.Forms.ToolStripButton();
            this.tSep18 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tbtnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tbtnFullExtent = new System.Windows.Forms.ToolStripButton();
            this.tbtnToggleExtent = new System.Windows.Forms.ToolStripButton();
            this.tbtnPreviousExtent = new System.Windows.Forms.ToolStripButton();
            this.tSep8 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnPanLeft = new System.Windows.Forms.ToolStripButton();
            this.tbtnPanRight = new System.Windows.Forms.ToolStripButton();
            this.tbtnPanUp = new System.Windows.Forms.ToolStripButton();
            this.tbtnPanDown = new System.Windows.Forms.ToolStripButton();
            this.tSep11 = new System.Windows.Forms.ToolStripSeparator();
            this.tbnInformation = new System.Windows.Forms.ToolStripButton();
            this.tSep12 = new System.Windows.Forms.ToolStripSeparator();
            this.tbnBackgroudColor = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.themeView = new MapSuiteExplorer.ThemeView();
            this.winformsMap1 = new ThinkGeo.MapSuite.DesktopEdition.WinformsMap();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.PanelDMS = new System.Windows.Forms.ToolStripStatusLabel();
            this.PanelDecimalDegrees = new System.Windows.Forms.ToolStripStatusLabel();
            this.PanelScreen = new System.Windows.Forms.ToolStripStatusLabel();
            this.Index = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.mnuFileAddNewLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToolsZoomingZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsZoomingZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsZoomingFullExtent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsZoomingToggleExtent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsZoomingPreviousExtent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsZooming = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToolsPanningPanLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsPanningPanRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsPanningPanUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsPanningPanDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsPanning = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackgroudColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrentLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoveToTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoveToBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.trackToExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTheStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpDiscussionForums = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.imageListToolStrip = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAddLayer,
            this.tSep3,
            this.tbnMoveUp,
            this.tbnMoveDown,
            this.tbnMoveToTop,
            this.tbnMoveToBottom,
            this.tSep14,
            this.tbnTrackToExtent,
            this.tbnChangeTheStyle,
            this.tbnShowFeatures,
            this.tSep18,
            this.tbtnZoomIn,
            this.tbtnZoomOut,
            this.tbtnFullExtent,
            this.tbtnToggleExtent,
            this.tbtnPreviousExtent,
            this.tSep8,
            this.tbtnPanLeft,
            this.tbtnPanRight,
            this.tbtnPanUp,
            this.tbtnPanDown,
            this.tSep11,
            this.tbnInformation,
            this.tSep12,
            this.tbnBackgroudColor});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(792, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolBar_ItemClicked);
            // 
            // tbtnAddLayer
            // 
            this.tbtnAddLayer.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_addnew;
            this.tbtnAddLayer.Name = "tbtnAddLayer";
            this.tbtnAddLayer.Size = new System.Drawing.Size(23, 22);
            this.tbtnAddLayer.Tag = "Add New Layer";
            this.tbtnAddLayer.ToolTipText = "Add New Layer";
            // 
            // tSep3
            // 
            this.tSep3.Name = "tSep3";
            this.tSep3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbnMoveUp
            // 
            this.tbnMoveUp.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_up;
            this.tbnMoveUp.Name = "tbnMoveUp";
            this.tbnMoveUp.Size = new System.Drawing.Size(23, 22);
            this.tbnMoveUp.Tag = "Move Up";
            this.tbnMoveUp.ToolTipText = "Move Up";
            // 
            // tbnMoveDown
            // 
            this.tbnMoveDown.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_down;
            this.tbnMoveDown.Name = "tbnMoveDown";
            this.tbnMoveDown.Size = new System.Drawing.Size(23, 22);
            this.tbnMoveDown.Tag = "Move Down";
            this.tbnMoveDown.ToolTipText = "Move Down";
            // 
            // tbnMoveToTop
            // 
            this.tbnMoveToTop.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_up1;
            this.tbnMoveToTop.Name = "tbnMoveToTop";
            this.tbnMoveToTop.Size = new System.Drawing.Size(23, 22);
            this.tbnMoveToTop.Tag = "Move To Top";
            this.tbnMoveToTop.ToolTipText = "Move To Top";
            // 
            // tbnMoveToBottom
            // 
            this.tbnMoveToBottom.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_down1;
            this.tbnMoveToBottom.Name = "tbnMoveToBottom";
            this.tbnMoveToBottom.Size = new System.Drawing.Size(23, 22);
            this.tbnMoveToBottom.Tag = "Move To Bottom";
            this.tbnMoveToBottom.ToolTipText = "Move To Bottom";
            // 
            // tSep14
            // 
            this.tSep14.Name = "tSep14";
            this.tSep14.Size = new System.Drawing.Size(6, 25);
            // 
            // tbnTrackToExtent
            // 
            this.tbnTrackToExtent.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_zoomto1;
            this.tbnTrackToExtent.Name = "tbnTrackToExtent";
            this.tbnTrackToExtent.Size = new System.Drawing.Size(23, 22);
            this.tbnTrackToExtent.Tag = "Track To Extent";
            this.tbnTrackToExtent.ToolTipText = "Track To Extent";
            // 
            // tbnChangeTheStyle
            // 
            this.tbnChangeTheStyle.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_edit1;
            this.tbnChangeTheStyle.Name = "tbnChangeTheStyle";
            this.tbnChangeTheStyle.Size = new System.Drawing.Size(23, 22);
            this.tbnChangeTheStyle.Tag = "Change The Style";
            this.tbnChangeTheStyle.ToolTipText = "Change The Style";
            // 
            // tbnShowFeatures
            // 
            this.tbnShowFeatures.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_features1;
            this.tbnShowFeatures.Name = "tbnShowFeatures";
            this.tbnShowFeatures.Size = new System.Drawing.Size(23, 22);
            this.tbnShowFeatures.Tag = "Show Features";
            this.tbnShowFeatures.ToolTipText = "Show Features";
            // 
            // tSep18
            // 
            this.tSep18.Name = "tSep18";
            this.tSep18.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnZoomIn
            // 
            this.tbtnZoomIn.Image = global::MapSuiteExplorer.Properties.Resources.ZoomIn;
            this.tbtnZoomIn.Name = "tbtnZoomIn";
            this.tbtnZoomIn.Size = new System.Drawing.Size(23, 22);
            this.tbtnZoomIn.Tag = "Zoom In";
            this.tbtnZoomIn.ToolTipText = "Zoom In";
            // 
            // tbtnZoomOut
            // 
            this.tbtnZoomOut.Image = global::MapSuiteExplorer.Properties.Resources.ZoomOut;
            this.tbtnZoomOut.Name = "tbtnZoomOut";
            this.tbtnZoomOut.Size = new System.Drawing.Size(23, 22);
            this.tbtnZoomOut.Tag = "Zoom Out";
            this.tbtnZoomOut.ToolTipText = "Zoom Out";
            // 
            // tbtnFullExtent
            // 
            this.tbtnFullExtent.Image = global::MapSuiteExplorer.Properties.Resources.FullExtent;
            this.tbtnFullExtent.Name = "tbtnFullExtent";
            this.tbtnFullExtent.Size = new System.Drawing.Size(23, 22);
            this.tbtnFullExtent.Tag = "Full Extent";
            this.tbtnFullExtent.ToolTipText = "Full Extent";
            // 
            // tbtnToggleExtent
            // 
            this.tbtnToggleExtent.Image = global::MapSuiteExplorer.Properties.Resources.ToggleExtent;
            this.tbtnToggleExtent.Name = "tbtnToggleExtent";
            this.tbtnToggleExtent.Size = new System.Drawing.Size(23, 22);
            this.tbtnToggleExtent.Tag = "Toggle Extent";
            this.tbtnToggleExtent.ToolTipText = "Toggle Extent";
            // 
            // tbtnPreviousExtent
            // 
            this.tbtnPreviousExtent.Image = global::MapSuiteExplorer.Properties.Resources.PreviousExtent;
            this.tbtnPreviousExtent.Name = "tbtnPreviousExtent";
            this.tbtnPreviousExtent.Size = new System.Drawing.Size(23, 22);
            this.tbtnPreviousExtent.Tag = "Previous Extent";
            this.tbtnPreviousExtent.ToolTipText = "Previous Extent";
            // 
            // tSep8
            // 
            this.tSep8.Name = "tSep8";
            this.tSep8.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnPanLeft
            // 
            this.tbtnPanLeft.Image = global::MapSuiteExplorer.Properties.Resources.btn_pan_w;
            this.tbtnPanLeft.Name = "tbtnPanLeft";
            this.tbtnPanLeft.Size = new System.Drawing.Size(23, 22);
            this.tbtnPanLeft.Tag = "Pan Left";
            this.tbtnPanLeft.ToolTipText = "Pan Left";
            // 
            // tbtnPanRight
            // 
            this.tbtnPanRight.Image = global::MapSuiteExplorer.Properties.Resources.btn_pan_e;
            this.tbtnPanRight.Name = "tbtnPanRight";
            this.tbtnPanRight.Size = new System.Drawing.Size(23, 22);
            this.tbtnPanRight.Tag = "Pan Right";
            this.tbtnPanRight.ToolTipText = "Pan Right";
            // 
            // tbtnPanUp
            // 
            this.tbtnPanUp.Image = global::MapSuiteExplorer.Properties.Resources.btn_pan_n;
            this.tbtnPanUp.Name = "tbtnPanUp";
            this.tbtnPanUp.Size = new System.Drawing.Size(23, 22);
            this.tbtnPanUp.Tag = "Pan Up";
            this.tbtnPanUp.ToolTipText = "Pan Up";
            // 
            // tbtnPanDown
            // 
            this.tbtnPanDown.Image = global::MapSuiteExplorer.Properties.Resources.btn_pan_s;
            this.tbtnPanDown.Name = "tbtnPanDown";
            this.tbtnPanDown.Size = new System.Drawing.Size(23, 22);
            this.tbtnPanDown.Tag = "Pan Down";
            this.tbtnPanDown.ToolTipText = "Pan Down";
            // 
            // tSep11
            // 
            this.tSep11.Name = "tSep11";
            this.tSep11.Size = new System.Drawing.Size(6, 25);
            // 
            // tbnInformation
            // 
            this.tbnInformation.Image = global::MapSuiteExplorer.Properties.Resources.Information;
            this.tbnInformation.Name = "tbnInformation";
            this.tbnInformation.Size = new System.Drawing.Size(23, 22);
            this.tbnInformation.Tag = "Information";
            this.tbnInformation.ToolTipText = "Information";
            // 
            // tSep12
            // 
            this.tSep12.Name = "tSep12";
            this.tSep12.Size = new System.Drawing.Size(6, 25);
            // 
            // tbnBackgroudColor
            // 
            this.tbnBackgroudColor.Image = global::MapSuiteExplorer.Properties.Resources.tool_icon_color_picker;
            this.tbnBackgroudColor.Name = "tbnBackgroudColor";
            this.tbnBackgroudColor.Size = new System.Drawing.Size(23, 22);
            this.tbnBackgroudColor.Tag = "Backgroud Color";
            this.tbnBackgroudColor.ToolTipText = "Backgroud Color";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
            this.openFileDialog.Multiselect = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 52);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.themeView);
            this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.winformsMap1);
            this.splitContainer.Size = new System.Drawing.Size(792, 497);
            this.splitContainer.SplitterDistance = 142;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 5;
            // 
            // themeView
            // 
            this.themeView.AllowDrop = true;
            this.themeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.themeView.AutoScroll = true;
            this.themeView.Location = new System.Drawing.Point(0, 0);
            this.themeView.Margin = new System.Windows.Forms.Padding(0);
            this.themeView.Name = "themeView";
            this.themeView.Padding = new System.Windows.Forms.Padding(3);
            this.themeView.Size = new System.Drawing.Size(140, 495);
            this.themeView.TabIndex = 0;
            // 
            // winformsMap1
            // 
            this.winformsMap1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.winformsMap1.BackColor = System.Drawing.Color.White;
            this.winformsMap1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;
            this.winformsMap1.CurrentScale = 590591790;
            this.winformsMap1.DrawingQuality = ThinkGeo.MapSuite.Core.DrawingQuality.Default;
            this.winformsMap1.Location = new System.Drawing.Point(3, 4);
            this.winformsMap1.MapFocusMode = ThinkGeo.MapSuite.DesktopEdition.MapFocusMode.Default;
            this.winformsMap1.MapResizeMode = ThinkGeo.MapSuite.Core.MapResizeMode.PreserveScale;
            this.winformsMap1.MapUnit = ThinkGeo.MapSuite.Core.GeographyUnit.DecimalDegree;
            this.winformsMap1.MaximumScale = 80000000000000;
            this.winformsMap1.MinimumScale = 200;
            this.winformsMap1.Name = "winformsMap1";
            this.winformsMap1.Size = new System.Drawing.Size(641, 486);
            this.winformsMap1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.winformsMap1.TabIndex = 0;
            this.winformsMap1.Text = "winformsMap1";
            this.winformsMap1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.winformsMap1.ThreadingMode = ThinkGeo.MapSuite.DesktopEdition.MapThreadingMode.Default;
            this.winformsMap1.ZoomLevelSnapping = ThinkGeo.MapSuite.DesktopEdition.ZoomLevelSnappingMode.Default;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PanelDMS,
            this.PanelDecimalDegrees,
            this.PanelScreen,
            this.Index});
            this.statusStrip.Location = new System.Drawing.Point(0, 551);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(792, 22);
            this.statusStrip.Stretch = false;
            this.statusStrip.TabIndex = 6;
            // 
            // PanelDMS
            // 
            this.PanelDMS.Name = "PanelDMS";
            this.PanelDMS.Size = new System.Drawing.Size(0, 17);
            // 
            // PanelDecimalDegrees
            // 
            this.PanelDecimalDegrees.Name = "PanelDecimalDegrees";
            this.PanelDecimalDegrees.Size = new System.Drawing.Size(0, 17);
            // 
            // PanelScreen
            // 
            this.PanelScreen.Name = "PanelScreen";
            this.PanelScreen.Size = new System.Drawing.Size(0, 17);
            // 
            // Index
            // 
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(0, 17);
            // 
            // mnuFileAddNewLayer
            // 
            this.mnuFileAddNewLayer.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_addnew;
            this.mnuFileAddNewLayer.Name = "mnuFileAddNewLayer";
            this.mnuFileAddNewLayer.Size = new System.Drawing.Size(163, 22);
            this.mnuFileAddNewLayer.Tag = "Add New Layer";
            this.mnuFileAddNewLayer.Text = "&Add New Layer...";
            this.mnuFileAddNewLayer.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Image = global::MapSuiteExplorer.Properties.Resources.menu_icon_exit;
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(163, 22);
            this.mnuFileExit.Tag = "Exit";
            this.mnuFileExit.Text = "&Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileAddNewLayer,
            this.addFolderToolStripMenuItem,
            this.toolStripMenuItem12,
            this.mnuRemoveAll,
            this.toolStripMenuItem2,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Image = global::MapSuiteExplorer.Properties.Resources.menu_icon_add_folder;
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addFolderToolStripMenuItem.Tag = "Add Folder";
            this.addFolderToolStripMenuItem.Text = "Add Folder...";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(160, 6);
            // 
            // mnuRemoveAll
            // 
            this.mnuRemoveAll.Image = global::MapSuiteExplorer.Properties.Resources.menu_icon_remove_all;
            this.mnuRemoveAll.Name = "mnuRemoveAll";
            this.mnuRemoveAll.Size = new System.Drawing.Size(163, 22);
            this.mnuRemoveAll.Tag = "Remove All";
            this.mnuRemoveAll.Text = "&Remove All";
            this.mnuRemoveAll.Click += new System.EventHandler(this.mnuRemoveAll_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 6);
            // 
            // mnuToolsZoomingZoomIn
            // 
            this.mnuToolsZoomingZoomIn.Image = global::MapSuiteExplorer.Properties.Resources.ZoomIn;
            this.mnuToolsZoomingZoomIn.Name = "mnuToolsZoomingZoomIn";
            this.mnuToolsZoomingZoomIn.Size = new System.Drawing.Size(154, 22);
            this.mnuToolsZoomingZoomIn.Tag = "Zoom In";
            this.mnuToolsZoomingZoomIn.Text = "Zoom &In";
            this.mnuToolsZoomingZoomIn.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuToolsZoomingZoomOut
            // 
            this.mnuToolsZoomingZoomOut.Image = global::MapSuiteExplorer.Properties.Resources.ZoomOut;
            this.mnuToolsZoomingZoomOut.Name = "mnuToolsZoomingZoomOut";
            this.mnuToolsZoomingZoomOut.Size = new System.Drawing.Size(154, 22);
            this.mnuToolsZoomingZoomOut.Tag = "Zoom Out";
            this.mnuToolsZoomingZoomOut.Text = "Zoom &Out";
            this.mnuToolsZoomingZoomOut.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuToolsZoomingFullExtent
            // 
            this.mnuToolsZoomingFullExtent.Image = global::MapSuiteExplorer.Properties.Resources.FullExtent;
            this.mnuToolsZoomingFullExtent.Name = "mnuToolsZoomingFullExtent";
            this.mnuToolsZoomingFullExtent.Size = new System.Drawing.Size(154, 22);
            this.mnuToolsZoomingFullExtent.Tag = "Full Extent";
            this.mnuToolsZoomingFullExtent.Text = "&Full Extent";
            this.mnuToolsZoomingFullExtent.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuToolsZoomingToggleExtent
            // 
            this.mnuToolsZoomingToggleExtent.Image = global::MapSuiteExplorer.Properties.Resources.ToggleExtent;
            this.mnuToolsZoomingToggleExtent.Name = "mnuToolsZoomingToggleExtent";
            this.mnuToolsZoomingToggleExtent.Size = new System.Drawing.Size(154, 22);
            this.mnuToolsZoomingToggleExtent.Tag = "Toggle Extent";
            this.mnuToolsZoomingToggleExtent.Text = "T&oggle Extent";
            this.mnuToolsZoomingToggleExtent.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuToolsZoomingPreviousExtent
            // 
            this.mnuToolsZoomingPreviousExtent.Image = global::MapSuiteExplorer.Properties.Resources.PreviousExtent;
            this.mnuToolsZoomingPreviousExtent.Name = "mnuToolsZoomingPreviousExtent";
            this.mnuToolsZoomingPreviousExtent.Size = new System.Drawing.Size(154, 22);
            this.mnuToolsZoomingPreviousExtent.Tag = "Previous Extent";
            this.mnuToolsZoomingPreviousExtent.Text = "&Previous Extent";
            this.mnuToolsZoomingPreviousExtent.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuToolsZooming
            // 
            this.mnuToolsZooming.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsZoomingZoomIn,
            this.mnuToolsZoomingZoomOut,
            this.toolStripMenuItem7,
            this.mnuToolsZoomingFullExtent,
            this.mnuToolsZoomingToggleExtent,
            this.mnuToolsZoomingPreviousExtent});
            this.mnuToolsZooming.Name = "mnuToolsZooming";
            this.mnuToolsZooming.Size = new System.Drawing.Size(172, 22);
            this.mnuToolsZooming.Text = "&Zooming";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(151, 6);
            // 
            // mnuToolsPanningPanLeft
            // 
            this.mnuToolsPanningPanLeft.Image = global::MapSuiteExplorer.Properties.Resources.btn_pan_w;
            this.mnuToolsPanningPanLeft.Name = "mnuToolsPanningPanLeft";
            this.mnuToolsPanningPanLeft.Size = new System.Drawing.Size(152, 22);
            this.mnuToolsPanningPanLeft.Tag = "Pan Left";
            this.mnuToolsPanningPanLeft.Text = "Pan &Left";
            this.mnuToolsPanningPanLeft.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuToolsPanningPanRight
            // 
            this.mnuToolsPanningPanRight.Image = global::MapSuiteExplorer.Properties.Resources.btn_pan_e;
            this.mnuToolsPanningPanRight.Name = "mnuToolsPanningPanRight";
            this.mnuToolsPanningPanRight.Size = new System.Drawing.Size(152, 22);
            this.mnuToolsPanningPanRight.Tag = "Pan Right";
            this.mnuToolsPanningPanRight.Text = "Pan &Right";
            this.mnuToolsPanningPanRight.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuToolsPanningPanUp
            // 
            this.mnuToolsPanningPanUp.Image = global::MapSuiteExplorer.Properties.Resources.btn_pan_n;
            this.mnuToolsPanningPanUp.Name = "mnuToolsPanningPanUp";
            this.mnuToolsPanningPanUp.Size = new System.Drawing.Size(152, 22);
            this.mnuToolsPanningPanUp.Tag = "Pan Up";
            this.mnuToolsPanningPanUp.Text = "Pan &Up";
            this.mnuToolsPanningPanUp.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuToolsPanningPanDown
            // 
            this.mnuToolsPanningPanDown.Image = global::MapSuiteExplorer.Properties.Resources.btn_pan_s;
            this.mnuToolsPanningPanDown.Name = "mnuToolsPanningPanDown";
            this.mnuToolsPanningPanDown.Size = new System.Drawing.Size(152, 22);
            this.mnuToolsPanningPanDown.Tag = "Pan Down";
            this.mnuToolsPanningPanDown.Text = "Pan &Down";
            this.mnuToolsPanningPanDown.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuToolsPanning
            // 
            this.mnuToolsPanning.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsPanningPanLeft,
            this.mnuToolsPanningPanRight,
            this.mnuToolsPanningPanUp,
            this.mnuToolsPanningPanDown});
            this.mnuToolsPanning.Name = "mnuToolsPanning";
            this.mnuToolsPanning.Size = new System.Drawing.Size(172, 22);
            this.mnuToolsPanning.Text = "&Panning";
            // 
            // mnuToolsInformation
            // 
            this.mnuToolsInformation.Image = global::MapSuiteExplorer.Properties.Resources.Information;
            this.mnuToolsInformation.Name = "mnuToolsInformation";
            this.mnuToolsInformation.Size = new System.Drawing.Size(172, 22);
            this.mnuToolsInformation.Tag = "Information";
            this.mnuToolsInformation.Text = "&Information";
            this.mnuToolsInformation.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuBackgroudColor
            // 
            this.mnuBackgroudColor.Image = global::MapSuiteExplorer.Properties.Resources.tool_icon_color_picker;
            this.mnuBackgroudColor.Name = "mnuBackgroudColor";
            this.mnuBackgroudColor.Size = new System.Drawing.Size(172, 22);
            this.mnuBackgroudColor.Tag = "Backgroud Color";
            this.mnuBackgroudColor.Text = "&Backgroud Color...";
            this.mnuBackgroudColor.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCurrentLayer,
            this.toolStripMenuItem1,
            this.mnuToolsZooming,
            this.toolStripMenuItem3,
            this.mnuToolsPanning,
            this.toolStripMenuItem4,
            this.mnuToolsInformation,
            this.mnuBackgroudColor});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuCurrentLayer
            // 
            this.mnuCurrentLayer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMoveUp,
            this.mnuMoveDown,
            this.mnuMoveToTop,
            this.mnuMoveToBottom,
            this.toolStripMenuItem9,
            this.trackToExtentToolStripMenuItem,
            this.changeTheStyleToolStripMenuItem,
            this.showFeaturesToolStripMenuItem});
            this.mnuCurrentLayer.Name = "mnuCurrentLayer";
            this.mnuCurrentLayer.Size = new System.Drawing.Size(172, 22);
            this.mnuCurrentLayer.Text = "Current Layer";
            // 
            // mnuMoveUp
            // 
            this.mnuMoveUp.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_up;
            this.mnuMoveUp.Name = "mnuMoveUp";
            this.mnuMoveUp.Size = new System.Drawing.Size(166, 22);
            this.mnuMoveUp.Tag = "Move Up";
            this.mnuMoveUp.Text = "Move &Up";
            this.mnuMoveUp.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuMoveDown
            // 
            this.mnuMoveDown.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_down;
            this.mnuMoveDown.Name = "mnuMoveDown";
            this.mnuMoveDown.Size = new System.Drawing.Size(166, 22);
            this.mnuMoveDown.Tag = "Move Down";
            this.mnuMoveDown.Text = "Move &Down";
            this.mnuMoveDown.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuMoveToTop
            // 
            this.mnuMoveToTop.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_up1;
            this.mnuMoveToTop.Name = "mnuMoveToTop";
            this.mnuMoveToTop.Size = new System.Drawing.Size(166, 22);
            this.mnuMoveToTop.Tag = "Move To Top";
            this.mnuMoveToTop.Text = "Move To Top";
            this.mnuMoveToTop.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mnuMoveToBottom
            // 
            this.mnuMoveToBottom.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_down1;
            this.mnuMoveToBottom.Name = "mnuMoveToBottom";
            this.mnuMoveToBottom.Size = new System.Drawing.Size(166, 22);
            this.mnuMoveToBottom.Tag = "Move To Bottom";
            this.mnuMoveToBottom.Text = "Move To Bottom";
            this.mnuMoveToBottom.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(163, 6);
            // 
            // trackToExtentToolStripMenuItem
            // 
            this.trackToExtentToolStripMenuItem.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_zoomto1;
            this.trackToExtentToolStripMenuItem.Name = "trackToExtentToolStripMenuItem";
            this.trackToExtentToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.trackToExtentToolStripMenuItem.Tag = "Track To Extent";
            this.trackToExtentToolStripMenuItem.Text = "Track To Extent";
            this.trackToExtentToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // changeTheStyleToolStripMenuItem
            // 
            this.changeTheStyleToolStripMenuItem.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_edit1;
            this.changeTheStyleToolStripMenuItem.Name = "changeTheStyleToolStripMenuItem";
            this.changeTheStyleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.changeTheStyleToolStripMenuItem.Tag = "Change The Style";
            this.changeTheStyleToolStripMenuItem.Text = "Change The Style";
            this.changeTheStyleToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // showFeaturesToolStripMenuItem
            // 
            this.showFeaturesToolStripMenuItem.Image = global::MapSuiteExplorer.Properties.Resources.btn_layer_features1;
            this.showFeaturesToolStripMenuItem.Name = "showFeaturesToolStripMenuItem";
            this.showFeaturesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.showFeaturesToolStripMenuItem.Tag = "Show Features";
            this.showFeaturesToolStripMenuItem.Text = "Show Features";
            this.showFeaturesToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(169, 6);
            // 
            // mnuHelpDiscussionForums
            // 
            this.mnuHelpDiscussionForums.Image = global::MapSuiteExplorer.Properties.Resources.menu_icon_discussion_forums;
            this.mnuHelpDiscussionForums.Name = "mnuHelpDiscussionForums";
            this.mnuHelpDiscussionForums.Size = new System.Drawing.Size(173, 22);
            this.mnuHelpDiscussionForums.Text = "&Discussion Forums";
            this.mnuHelpDiscussionForums.Click += new System.EventHandler(this.mnuHelpDiscussionForums_Click);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(173, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpDiscussionForums,
            this.toolStripMenuItem5,
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(170, 6);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools,
            this.mnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(792, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // imageListToolStrip
            // 
            this.imageListToolStrip.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListToolStrip.ImageStream")));
            this.imageListToolStrip.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListToolStrip.Images.SetKeyName(0, "");
            this.imageListToolStrip.Images.SetKeyName(1, "");
            this.imageListToolStrip.Images.SetKeyName(2, "");
            this.imageListToolStrip.Images.SetKeyName(3, "");
            this.imageListToolStrip.Images.SetKeyName(4, "");
            this.imageListToolStrip.Images.SetKeyName(5, "");
            this.imageListToolStrip.Images.SetKeyName(6, "");
            this.imageListToolStrip.Images.SetKeyName(7, "");
            this.imageListToolStrip.Images.SetKeyName(8, "");
            this.imageListToolStrip.Images.SetKeyName(9, "");
            this.imageListToolStrip.Images.SetKeyName(10, "");
            this.imageListToolStrip.Images.SetKeyName(11, "");
            this.imageListToolStrip.Images.SetKeyName(12, "");
            this.imageListToolStrip.Images.SetKeyName(13, "");
            this.imageListToolStrip.Images.SetKeyName(14, "");
            this.imageListToolStrip.Images.SetKeyName(15, "");
            this.imageListToolStrip.Images.SetKeyName(16, "Folder.ico");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem10.Text = "toolStripMenuItem10";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem11.Text = "toolStripMenuItem11";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map Suite Explorer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStrip;
        internal System.Windows.Forms.ToolStripButton tbtnAddLayer;
        internal System.Windows.Forms.ToolStripSeparator tSep3;
        internal System.Windows.Forms.ToolStripButton tbtnZoomIn;
        internal System.Windows.Forms.ToolStripButton tbtnZoomOut;
        internal System.Windows.Forms.ToolStripButton tbtnFullExtent;
        internal System.Windows.Forms.ToolStripButton tbtnToggleExtent;
        internal System.Windows.Forms.ToolStripButton tbtnPreviousExtent;
        internal System.Windows.Forms.ToolStripSeparator tSep8;
        internal System.Windows.Forms.ToolStripButton tbtnPanLeft;
        internal System.Windows.Forms.ToolStripButton tbtnPanRight;
        internal System.Windows.Forms.ToolStripButton tbtnPanUp;
        internal System.Windows.Forms.ToolStripButton tbtnPanDown;
        internal System.Windows.Forms.ToolStripSeparator tSep11;
        internal System.Windows.Forms.ToolStripSeparator tSep12;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer;
        internal System.Windows.Forms.ToolStripButton tbnInformation;
        internal System.Windows.Forms.StatusStrip statusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel PanelDMS;
        internal System.Windows.Forms.ToolStripStatusLabel PanelDecimalDegrees;
        internal System.Windows.Forms.ToolStripStatusLabel PanelScreen;
        internal System.Windows.Forms.ToolStripStatusLabel Index;
        private ThemeView themeView;
        private System.Windows.Forms.ColorDialog colorDialog;
        internal System.Windows.Forms.ToolStripButton tbnBackgroudColor;
        internal System.Windows.Forms.ToolStripMenuItem mnuFileAddNewLayer;
        internal System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        internal System.Windows.Forms.ToolStripMenuItem mnuFile;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsZoomingZoomIn;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsZoomingZoomOut;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsZoomingFullExtent;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsZoomingToggleExtent;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsZoomingPreviousExtent;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsZooming;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsPanningPanLeft;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsPanningPanRight;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsPanningPanUp;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsPanningPanDown;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsPanning;
        internal System.Windows.Forms.ToolStripMenuItem mnuToolsInformation;
        internal System.Windows.Forms.ToolStripMenuItem mnuBackgroudColor;
        internal System.Windows.Forms.ToolStripMenuItem mnuTools;
        internal System.Windows.Forms.ToolStripMenuItem mnuHelpDiscussionForums;
        internal System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        internal System.Windows.Forms.ToolStripMenuItem mnuHelp;
        internal System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator tSep14;
        private System.Windows.Forms.ToolStripButton tbnMoveUp;
        private System.Windows.Forms.ToolStripButton tbnMoveDown;
        private System.Windows.Forms.ToolStripMenuItem mnuCurrentLayer;
        internal System.Windows.Forms.ToolStripMenuItem mnuMoveUp;
        internal System.Windows.Forms.ToolStripMenuItem mnuMoveDown;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveAll;
        private System.Windows.Forms.ToolStripButton tbnMoveToTop;
        private System.Windows.Forms.ToolStripButton tbnMoveToBottom;
        private System.Windows.Forms.ToolStripSeparator tSep18;
        private System.Windows.Forms.ToolStripButton tbnTrackToExtent;
        private System.Windows.Forms.ToolStripButton tbnChangeTheStyle;
        private System.Windows.Forms.ToolStripButton tbnShowFeatures;
        internal System.Windows.Forms.ImageList imageListToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveToTop;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveToBottom;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem trackToExtentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTheStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFeaturesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem addFolderToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem12;
        private FolderBrowserDialog folderBrowserDialog;
        private ThinkGeo.MapSuite.DesktopEdition.WinformsMap winformsMap1;
    }
}

