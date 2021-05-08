
namespace RockplanetsEditor
{
    partial class editorWindow
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
            Krypton.Toolkit.KryptonSplitContainer BlueprintPropertiesDivide;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editorWindow));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Base", 4, 4);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("World", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Lighting", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Basic Bomb", 5, 5);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Backpack", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Game", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode5});
            this.propertiesGroup = new Krypton.Toolkit.KryptonHeaderGroup();
            this.blueprintsGroup = new Krypton.Toolkit.KryptonHeaderGroup();
            this.ribbonContext1 = new System.Windows.Forms.RibbonContext();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldButton = new System.Windows.Forms.ToolStripButton();
            this.openWorldButton = new System.Windows.Forms.ToolStripButton();
            this.saveWorldButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.newPartButton = new System.Windows.Forms.ToolStripButton();
            this.newOtherButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.positionButton = new System.Windows.Forms.ToolStripButton();
            this.rotationButton = new System.Windows.Forms.ToolStripButton();
            this.scaleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.colorButton = new BlackBeltCoder.ColorToolStripDropDownButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.worldGoButton = new System.Windows.Forms.ToolStripButton();
            this.worldStopButton = new System.Windows.Forms.ToolStripButton();
            this.worldUploadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kryptonDockingManager1 = new Krypton.Docking.KryptonDockingManager();
            this.kryptonWorkspaceCell2 = new Krypton.Workspace.KryptonWorkspaceCell();
            this.kryptonPage3 = new Krypton.Navigator.KryptonPage();
            this.kryptonPage4 = new Krypton.Navigator.KryptonPage();
            this.splitGameProperties = new Krypton.Toolkit.KryptonSplitContainer();
            this.splitPropertiesBlueprintStuff = new Krypton.Toolkit.KryptonSplitContainer();
            this.explorerGroup = new Krypton.Toolkit.KryptonHeaderGroup();
            this.explorerTV = new System.Windows.Forms.TreeView();
            this.commonImagesList = new System.Windows.Forms.ImageList(this.components);
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.selectButton = new System.Windows.Forms.ToolStripButton();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gameViewPanel = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            BlueprintPropertiesDivide = new Krypton.Toolkit.KryptonSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(BlueprintPropertiesDivide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(BlueprintPropertiesDivide.Panel1)).BeginInit();
            BlueprintPropertiesDivide.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(BlueprintPropertiesDivide.Panel2)).BeginInit();
            BlueprintPropertiesDivide.Panel2.SuspendLayout();
            BlueprintPropertiesDivide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGroup.Panel)).BeginInit();
            this.propertiesGroup.Panel.SuspendLayout();
            this.propertiesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintsGroup.Panel)).BeginInit();
            this.blueprintsGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonWorkspaceCell2)).BeginInit();
            this.kryptonWorkspaceCell2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGameProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGameProperties.Panel1)).BeginInit();
            this.splitGameProperties.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitGameProperties.Panel2)).BeginInit();
            this.splitGameProperties.Panel2.SuspendLayout();
            this.splitGameProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPropertiesBlueprintStuff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPropertiesBlueprintStuff.Panel1)).BeginInit();
            this.splitPropertiesBlueprintStuff.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPropertiesBlueprintStuff.Panel2)).BeginInit();
            this.splitPropertiesBlueprintStuff.Panel2.SuspendLayout();
            this.splitPropertiesBlueprintStuff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explorerGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerGroup.Panel)).BeginInit();
            this.explorerGroup.Panel.SuspendLayout();
            this.explorerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // BlueprintPropertiesDivide
            // 
            BlueprintPropertiesDivide.Cursor = System.Windows.Forms.Cursors.Default;
            BlueprintPropertiesDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            BlueprintPropertiesDivide.Location = new System.Drawing.Point(0, 0);
            BlueprintPropertiesDivide.Name = "BlueprintPropertiesDivide";
            BlueprintPropertiesDivide.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BlueprintPropertiesDivide.Panel1
            // 
            BlueprintPropertiesDivide.Panel1.Controls.Add(this.propertiesGroup);
            // 
            // BlueprintPropertiesDivide.Panel2
            // 
            BlueprintPropertiesDivide.Panel2.Controls.Add(this.blueprintsGroup);
            BlueprintPropertiesDivide.Size = new System.Drawing.Size(319, 405);
            BlueprintPropertiesDivide.SplitterDistance = 183;
            BlueprintPropertiesDivide.TabIndex = 0;
            // 
            // propertiesGroup
            // 
            this.propertiesGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesGroup.Location = new System.Drawing.Point(0, 0);
            this.propertiesGroup.Name = "propertiesGroup";
            // 
            // propertiesGroup.Panel
            // 
            this.propertiesGroup.Panel.Controls.Add(this.propertyGrid1);
            this.propertiesGroup.Size = new System.Drawing.Size(319, 183);
            this.propertiesGroup.TabIndex = 0;
            this.propertiesGroup.ValuesPrimary.Heading = "Properties";
            this.propertiesGroup.ValuesPrimary.Image = null;
            this.propertiesGroup.ValuesSecondary.Heading = "Configurable parameters of a instance.";
            // 
            // blueprintsGroup
            // 
            this.blueprintsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueprintsGroup.Location = new System.Drawing.Point(0, 0);
            this.blueprintsGroup.Name = "blueprintsGroup";
            this.blueprintsGroup.Size = new System.Drawing.Size(319, 217);
            this.blueprintsGroup.TabIndex = 0;
            this.blueprintsGroup.ValuesPrimary.Heading = "Blueprints";
            this.blueprintsGroup.ValuesPrimary.Image = null;
            this.blueprintsGroup.ValuesSecondary.Heading = "User-made models that you can use in your game!";
            // 
            // ribbonContext1
            // 
            this.ribbonContext1.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(159)))), ((int)(((byte)(185)))));
            this.ribbonContext1.Text = "ribbonContext1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // newWorldButton
            // 
            this.newWorldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newWorldButton.Image = ((System.Drawing.Image)(resources.GetObject("newWorldButton.Image")));
            this.newWorldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newWorldButton.Name = "newWorldButton";
            this.newWorldButton.Size = new System.Drawing.Size(23, 22);
            this.newWorldButton.Text = "newButton";
            // 
            // openWorldButton
            // 
            this.openWorldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openWorldButton.Image = ((System.Drawing.Image)(resources.GetObject("openWorldButton.Image")));
            this.openWorldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openWorldButton.Name = "openWorldButton";
            this.openWorldButton.Size = new System.Drawing.Size(23, 22);
            this.openWorldButton.Text = "openWorldButton";
            // 
            // saveWorldButton
            // 
            this.saveWorldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveWorldButton.Image = ((System.Drawing.Image)(resources.GetObject("saveWorldButton.Image")));
            this.saveWorldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveWorldButton.Name = "saveWorldButton";
            this.saveWorldButton.Size = new System.Drawing.Size(23, 22);
            this.saveWorldButton.Text = "saveWorldButton";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // newPartButton
            // 
            this.newPartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newPartButton.Image = ((System.Drawing.Image)(resources.GetObject("newPartButton.Image")));
            this.newPartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newPartButton.Name = "newPartButton";
            this.newPartButton.Size = new System.Drawing.Size(23, 22);
            this.newPartButton.Text = "toolStripButton4";
            // 
            // newOtherButton
            // 
            this.newOtherButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newOtherButton.Image = ((System.Drawing.Image)(resources.GetObject("newOtherButton.Image")));
            this.newOtherButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newOtherButton.Name = "newOtherButton";
            this.newOtherButton.Size = new System.Drawing.Size(23, 22);
            this.newOtherButton.Text = "toolStripButton5";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // positionButton
            // 
            this.positionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.positionButton.Image = ((System.Drawing.Image)(resources.GetObject("positionButton.Image")));
            this.positionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.positionButton.Name = "positionButton";
            this.positionButton.Size = new System.Drawing.Size(23, 22);
            this.positionButton.Text = "toolStripButton6";
            // 
            // rotationButton
            // 
            this.rotationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotationButton.Image = ((System.Drawing.Image)(resources.GetObject("rotationButton.Image")));
            this.rotationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotationButton.Name = "rotationButton";
            this.rotationButton.Size = new System.Drawing.Size(23, 22);
            this.rotationButton.Text = "toolStripButton7";
            this.rotationButton.Click += new System.EventHandler(this.rotationButton_Click);
            // 
            // scaleButton
            // 
            this.scaleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scaleButton.Image = ((System.Drawing.Image)(resources.GetObject("scaleButton.Image")));
            this.scaleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(23, 22);
            this.scaleButton.Text = "toolStripButton8";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // colorButton
            // 
            this.colorButton.BoxHeight = 29;
            this.colorButton.BoxWidth = 26;
            this.colorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorButton.Image = ((System.Drawing.Image)(resources.GetObject("colorButton.Image")));
            this.colorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(29, 22);
            this.colorButton.Text = "colorToolStripDropDownButton1";
            this.colorButton.Value = System.Drawing.Color.Silver;
            this.colorButton.Click += new BlackBeltCoder.ColorToolStripDropDownButton.ColorPaletteEventHandler(this.colorButton_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // worldGoButton
            // 
            this.worldGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.worldGoButton.Image = ((System.Drawing.Image)(resources.GetObject("worldGoButton.Image")));
            this.worldGoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.worldGoButton.Name = "worldGoButton";
            this.worldGoButton.Size = new System.Drawing.Size(23, 22);
            this.worldGoButton.Text = "toolStripButton9";
            // 
            // worldStopButton
            // 
            this.worldStopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.worldStopButton.Image = ((System.Drawing.Image)(resources.GetObject("worldStopButton.Image")));
            this.worldStopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.worldStopButton.Name = "worldStopButton";
            this.worldStopButton.Size = new System.Drawing.Size(23, 22);
            this.worldStopButton.Text = "toolStripButton10";
            // 
            // worldUploadButton
            // 
            this.worldUploadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.worldUploadButton.Image = ((System.Drawing.Image)(resources.GetObject("worldUploadButton.Image")));
            this.worldUploadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.worldUploadButton.Name = "worldUploadButton";
            this.worldUploadButton.Size = new System.Drawing.Size(23, 22);
            this.worldUploadButton.Text = "toolStripButton11";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldButton,
            this.openWorldButton,
            this.saveWorldButton,
            this.toolStripSeparator6,
            this.newPartButton,
            this.newOtherButton,
            this.toolStripSeparator7,
            this.cutButton,
            this.copyButton,
            this.pasteButton,
            this.toolStripSeparator11,
            this.selectButton,
            this.positionButton,
            this.rotationButton,
            this.scaleButton,
            this.toolStripSeparator8,
            this.colorButton,
            this.toolStripButton1,
            this.toolStripSeparator9,
            this.worldGoButton,
            this.worldStopButton,
            this.worldUploadButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1076, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kryptonWorkspaceCell2
            // 
            this.kryptonWorkspaceCell2.AllowPageDrag = true;
            this.kryptonWorkspaceCell2.AllowTabFocus = false;
            this.kryptonWorkspaceCell2.Name = "kryptonWorkspaceCell2";
            this.kryptonWorkspaceCell2.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.kryptonPage3,
            this.kryptonPage4});
            this.kryptonWorkspaceCell2.SelectedIndex = 0;
            this.kryptonWorkspaceCell2.UniqueName = "1fef820387d24bd4a091aab0c8127e7e";
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage3.Flags = 65534;
            this.kryptonPage3.LastVisibleSet = true;
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.Size = new System.Drawing.Size(248, 123);
            this.kryptonPage3.Text = "kryptonPage3";
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "4c625f1ebb0f4aeb88d20563d4e4f43c";
            // 
            // kryptonPage4
            // 
            this.kryptonPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage4.Flags = 65534;
            this.kryptonPage4.LastVisibleSet = true;
            this.kryptonPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage4.Name = "kryptonPage4";
            this.kryptonPage4.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage4.Text = "kryptonPage4";
            this.kryptonPage4.ToolTipTitle = "Page ToolTip";
            this.kryptonPage4.UniqueName = "fdd304a7edc64cef87fa4f82bba859c1";
            // 
            // splitGameProperties
            // 
            this.splitGameProperties.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitGameProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGameProperties.Location = new System.Drawing.Point(0, 49);
            this.splitGameProperties.Name = "splitGameProperties";
            // 
            // splitGameProperties.Panel1
            // 
            this.splitGameProperties.Panel1.Controls.Add(this.gameViewPanel);
            // 
            // splitGameProperties.Panel2
            // 
            this.splitGameProperties.Panel2.Controls.Add(this.splitPropertiesBlueprintStuff);
            this.splitGameProperties.Size = new System.Drawing.Size(1076, 682);
            this.splitGameProperties.SplitterDistance = 752;
            this.splitGameProperties.TabIndex = 2;
            // 
            // splitPropertiesBlueprintStuff
            // 
            this.splitPropertiesBlueprintStuff.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitPropertiesBlueprintStuff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPropertiesBlueprintStuff.Location = new System.Drawing.Point(0, 0);
            this.splitPropertiesBlueprintStuff.Name = "splitPropertiesBlueprintStuff";
            this.splitPropertiesBlueprintStuff.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPropertiesBlueprintStuff.Panel1
            // 
            this.splitPropertiesBlueprintStuff.Panel1.Controls.Add(this.explorerGroup);
            // 
            // splitPropertiesBlueprintStuff.Panel2
            // 
            this.splitPropertiesBlueprintStuff.Panel2.Controls.Add(BlueprintPropertiesDivide);
            this.splitPropertiesBlueprintStuff.Size = new System.Drawing.Size(319, 682);
            this.splitPropertiesBlueprintStuff.SplitterDistance = 272;
            this.splitPropertiesBlueprintStuff.TabIndex = 0;
            // 
            // explorerGroup
            // 
            this.explorerGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerGroup.Location = new System.Drawing.Point(0, 0);
            this.explorerGroup.Name = "explorerGroup";
            // 
            // explorerGroup.Panel
            // 
            this.explorerGroup.Panel.Controls.Add(this.explorerTV);
            this.explorerGroup.Size = new System.Drawing.Size(319, 272);
            this.explorerGroup.TabIndex = 0;
            this.explorerGroup.ValuesPrimary.Heading = "Explorer";
            this.explorerGroup.ValuesPrimary.Image = null;
            this.explorerGroup.ValuesSecondary.Heading = "Shows all the instances in the game.";
            // 
            // explorerTV
            // 
            this.explorerTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerTV.ImageIndex = 0;
            this.explorerTV.ImageList = this.commonImagesList;
            this.explorerTV.Location = new System.Drawing.Point(0, 0);
            this.explorerTV.Name = "explorerTV";
            treeNode1.ImageIndex = 4;
            treeNode1.Name = "base";
            treeNode1.SelectedImageIndex = 4;
            treeNode1.Text = "Base";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "worldNode";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "World";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "lightingNode";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Lighting";
            treeNode4.ImageIndex = 5;
            treeNode4.Name = "basicBomb";
            treeNode4.SelectedImageIndex = 5;
            treeNode4.Text = "Basic Bomb";
            treeNode5.ImageKey = "bin.png";
            treeNode5.Name = "backpackNode";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "Backpack";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "gameNode";
            treeNode6.SelectedImageIndex = 0;
            treeNode6.Text = "Game";
            this.explorerTV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.explorerTV.SelectedImageIndex = 0;
            this.explorerTV.Size = new System.Drawing.Size(317, 219);
            this.explorerTV.TabIndex = 0;
            // 
            // commonImagesList
            // 
            this.commonImagesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("commonImagesList.ImageStream")));
            this.commonImagesList.TransparentColor = System.Drawing.Color.Transparent;
            this.commonImagesList.Images.SetKeyName(0, "database.png");
            this.commonImagesList.Images.SetKeyName(1, "world.png");
            this.commonImagesList.Images.SetKeyName(2, "lightbulb.png");
            this.commonImagesList.Images.SetKeyName(3, "bin.png");
            this.commonImagesList.Images.SetKeyName(4, "brick.png");
            this.commonImagesList.Images.SetKeyName(5, "wrench_orange.png");
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office365Blue;
            // 
            // selectButton
            // 
            this.selectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectButton.Image = ((System.Drawing.Image)(resources.GetObject("selectButton.Image")));
            this.selectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(23, 22);
            this.selectButton.Text = "toolStripButton1";
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = ((System.Drawing.Image)(resources.GetObject("cutButton.Image")));
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(23, 22);
            this.cutButton.Text = "toolStripButton2";
            // 
            // copyButton
            // 
            this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(23, 22);
            this.copyButton.Text = "toolStripButton3";
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteButton.Image")));
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(23, 22);
            this.pasteButton.Text = "toolStripButton4";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // gameViewPanel
            // 
            this.gameViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameViewPanel.Location = new System.Drawing.Point(0, 0);
            this.gameViewPanel.Name = "gameViewPanel";
            this.gameViewPanel.Size = new System.Drawing.Size(752, 682);
            this.gameViewPanel.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(317, 130);
            this.propertyGrid1.TabIndex = 0;
            // 
            // editorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 731);
            this.Controls.Add(this.splitGameProperties);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "editorWindow";
            this.Text = "RockME";
            ((System.ComponentModel.ISupportInitialize)(BlueprintPropertiesDivide.Panel1)).EndInit();
            BlueprintPropertiesDivide.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(BlueprintPropertiesDivide.Panel2)).EndInit();
            BlueprintPropertiesDivide.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(BlueprintPropertiesDivide)).EndInit();
            BlueprintPropertiesDivide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGroup.Panel)).EndInit();
            this.propertiesGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGroup)).EndInit();
            this.propertiesGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blueprintsGroup.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintsGroup)).EndInit();
            this.blueprintsGroup.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonWorkspaceCell2)).EndInit();
            this.kryptonWorkspaceCell2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGameProperties.Panel1)).EndInit();
            this.splitGameProperties.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGameProperties.Panel2)).EndInit();
            this.splitGameProperties.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGameProperties)).EndInit();
            this.splitGameProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPropertiesBlueprintStuff.Panel1)).EndInit();
            this.splitPropertiesBlueprintStuff.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPropertiesBlueprintStuff.Panel2)).EndInit();
            this.splitPropertiesBlueprintStuff.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPropertiesBlueprintStuff)).EndInit();
            this.splitPropertiesBlueprintStuff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.explorerGroup.Panel)).EndInit();
            this.explorerGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.explorerGroup)).EndInit();
            this.explorerGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RibbonContext ribbonContext1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newWorldButton;
        private System.Windows.Forms.ToolStripButton openWorldButton;
        private System.Windows.Forms.ToolStripButton saveWorldButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton newPartButton;
        private System.Windows.Forms.ToolStripButton newOtherButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton positionButton;
        private System.Windows.Forms.ToolStripButton rotationButton;
        private System.Windows.Forms.ToolStripButton scaleButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private BlackBeltCoder.ColorToolStripDropDownButton colorButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton worldGoButton;
        private System.Windows.Forms.ToolStripButton worldStopButton;
        private System.Windows.Forms.ToolStripButton worldUploadButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private Krypton.Workspace.KryptonWorkspaceCell kryptonWorkspaceCell2;
        private Krypton.Navigator.KryptonPage kryptonPage3;
        private Krypton.Navigator.KryptonPage kryptonPage4;
        private Krypton.Toolkit.KryptonSplitContainer splitGameProperties;
        private Krypton.Toolkit.KryptonSplitContainer splitPropertiesBlueprintStuff;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonHeaderGroup explorerGroup;
        private Krypton.Toolkit.KryptonHeaderGroup propertiesGroup;
        private Krypton.Toolkit.KryptonHeaderGroup blueprintsGroup;
        private System.Windows.Forms.TreeView explorerTV;
        private System.Windows.Forms.ImageList commonImagesList;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton selectButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Panel gameViewPanel;
    }
}

