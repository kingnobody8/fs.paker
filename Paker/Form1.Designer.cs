namespace Paker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importPAKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbut_UP = new System.Windows.Forms.ToolStripButton();
            this.tsbut_down = new System.Windows.Forms.ToolStripButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Files = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Bytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_FreeBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.split_main = new System.Windows.Forms.SplitContainer();
            this.split_Left = new System.Windows.Forms.SplitContainer();
            this.split_Sig = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Sig = new System.Windows.Forms.TextBox();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.but_AddFiles = new System.Windows.Forms.Button();
            this.but_RemFiles = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.but_ExportFiles = new System.Windows.Forms.Button();
            this.but_ImportPak = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_main)).BeginInit();
            this.split_main.Panel1.SuspendLayout();
            this.split_main.Panel2.SuspendLayout();
            this.split_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Left)).BeginInit();
            this.split_Left.Panel1.SuspendLayout();
            this.split_Left.Panel2.SuspendLayout();
            this.split_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Sig)).BeginInit();
            this.split_Sig.Panel1.SuspendLayout();
            this.split_Sig.Panel2.SuspendLayout();
            this.split_Sig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.loaderToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
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
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem,
            this.remFilesToolStripMenuItem,
            this.exportFilesToolStripMenuItem,
            this.toolStripSeparator2,
            this.importPAKToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.addFilesToolStripMenuItem.Text = "&Add Files";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // remFilesToolStripMenuItem
            // 
            this.remFilesToolStripMenuItem.Name = "remFilesToolStripMenuItem";
            this.remFilesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.remFilesToolStripMenuItem.Text = "&Rem Files";
            this.remFilesToolStripMenuItem.Click += new System.EventHandler(this.remFilesToolStripMenuItem_Click);
            // 
            // exportFilesToolStripMenuItem
            // 
            this.exportFilesToolStripMenuItem.Name = "exportFilesToolStripMenuItem";
            this.exportFilesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exportFilesToolStripMenuItem.Text = "&Export File";
            this.exportFilesToolStripMenuItem.Click += new System.EventHandler(this.exportFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // importPAKToolStripMenuItem
            // 
            this.importPAKToolStripMenuItem.Name = "importPAKToolStripMenuItem";
            this.importPAKToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.importPAKToolStripMenuItem.Text = "&Import PAK";
            this.importPAKToolStripMenuItem.Click += new System.EventHandler(this.importPAKToolStripMenuItem_Click);
            // 
            // loaderToolStripMenuItem
            // 
            this.loaderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.loaderToolStripMenuItem.Name = "loaderToolStripMenuItem";
            this.loaderToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.loaderToolStripMenuItem.Text = "&Loader";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.createToolStripMenuItem.Text = "&Create Paker.h";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator3,
            this.tsbut_UP,
            this.tsbut_down});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbut_UP
            // 
            this.tsbut_UP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbut_UP.Image = global::Paker.Properties.Resources.arrow_up;
            this.tsbut_UP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbut_UP.Name = "tsbut_UP";
            this.tsbut_UP.Size = new System.Drawing.Size(23, 22);
            this.tsbut_UP.Text = "Move File Up";
            this.tsbut_UP.Click += new System.EventHandler(this.tsbut_UP_Click);
            // 
            // tsbut_down
            // 
            this.tsbut_down.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbut_down.Image = global::Paker.Properties.Resources.arrow_down;
            this.tsbut_down.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbut_down.Name = "tsbut_down";
            this.tsbut_down.Size = new System.Drawing.Size(23, 22);
            this.tsbut_down.Text = "Move File Down";
            this.tsbut_down.Click += new System.EventHandler(this.tsbut_down_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 442);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(732, 23);
            this.progressBar.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_Files,
            this.toolStripStatusLabel2,
            this.tssl_Bytes,
            this.toolStripStatusLabel3,
            this.tssl_FreeBytes});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 25);
            this.toolStripStatusLabel1.Text = "Total Files:";
            // 
            // tssl_Files
            // 
            this.tssl_Files.Name = "tssl_Files";
            this.tssl_Files.Size = new System.Drawing.Size(19, 25);
            this.tssl_Files.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(78, 25);
            this.toolStripStatusLabel2.Text = "Total MB:";
            // 
            // tssl_Bytes
            // 
            this.tssl_Bytes.Name = "tssl_Bytes";
            this.tssl_Bytes.Size = new System.Drawing.Size(19, 25);
            this.tssl_Bytes.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(74, 25);
            this.toolStripStatusLabel3.Text = "Free MB:";
            // 
            // tssl_FreeBytes
            // 
            this.tssl_FreeBytes.Name = "tssl_FreeBytes";
            this.tssl_FreeBytes.Size = new System.Drawing.Size(46, 25);
            this.tssl_FreeBytes.Text = "1024";
            // 
            // split_main
            // 
            this.split_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split_main.Location = new System.Drawing.Point(0, 49);
            this.split_main.Name = "split_main";
            this.split_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split_main.Panel1
            // 
            this.split_main.Panel1.Controls.Add(this.split_Left);
            // 
            // split_main.Panel2
            // 
            this.split_main.Panel2.Controls.Add(this.splitContainer2);
            this.split_main.Size = new System.Drawing.Size(732, 363);
            this.split_main.SplitterDistance = 298;
            this.split_main.TabIndex = 4;
            // 
            // split_Left
            // 
            this.split_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_Left.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.split_Left.Location = new System.Drawing.Point(0, 0);
            this.split_Left.Name = "split_Left";
            this.split_Left.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split_Left.Panel1
            // 
            this.split_Left.Panel1.Controls.Add(this.split_Sig);
            // 
            // split_Left.Panel2
            // 
            this.split_Left.Panel2.Controls.Add(this.listView_Main);
            this.split_Left.Size = new System.Drawing.Size(732, 298);
            this.split_Left.SplitterDistance = 26;
            this.split_Left.TabIndex = 1;
            // 
            // split_Sig
            // 
            this.split_Sig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_Sig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_Sig.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.split_Sig.Location = new System.Drawing.Point(0, 0);
            this.split_Sig.Name = "split_Sig";
            // 
            // split_Sig.Panel1
            // 
            this.split_Sig.Panel1.Controls.Add(this.label1);
            // 
            // split_Sig.Panel2
            // 
            this.split_Sig.Panel2.Controls.Add(this.textBox_Sig);
            this.split_Sig.Size = new System.Drawing.Size(732, 26);
            this.split_Sig.SplitterDistance = 109;
            this.split_Sig.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Signature:";
            // 
            // textBox_Sig
            // 
            this.textBox_Sig.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_Sig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Sig.Location = new System.Drawing.Point(0, 0);
            this.textBox_Sig.Name = "textBox_Sig";
            this.textBox_Sig.Size = new System.Drawing.Size(617, 26);
            this.textBox_Sig.TabIndex = 0;
            this.textBox_Sig.Text = "PACK";
            this.textBox_Sig.TextChanged += new System.EventHandler(this.textBox_Sig_TextChanged);
            // 
            // listView_Main
            // 
            this.listView_Main.AllowDrop = true;
            this.listView_Main.BackColor = System.Drawing.Color.DarkOrange;
            this.listView_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Main.FullRowSelect = true;
            this.listView_Main.GridLines = true;
            this.listView_Main.Location = new System.Drawing.Point(0, 0);
            this.listView_Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(730, 266);
            this.listView_Main.TabIndex = 1;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            this.listView_Main.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_Main_DragDrop);
            this.listView_Main.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_Main_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 514;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bytes";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MB";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ext";
            this.columnHeader4.Width = 70;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(732, 61);
            this.splitContainer2.SplitterDistance = 352;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.but_AddFiles);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.but_RemFiles);
            this.splitContainer3.Size = new System.Drawing.Size(352, 61);
            this.splitContainer3.SplitterDistance = 163;
            this.splitContainer3.TabIndex = 0;
            // 
            // but_AddFiles
            // 
            this.but_AddFiles.BackColor = System.Drawing.Color.SeaGreen;
            this.but_AddFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_AddFiles.Location = new System.Drawing.Point(0, 0);
            this.but_AddFiles.Name = "but_AddFiles";
            this.but_AddFiles.Size = new System.Drawing.Size(161, 59);
            this.but_AddFiles.TabIndex = 0;
            this.but_AddFiles.Text = "Add Files";
            this.but_AddFiles.UseVisualStyleBackColor = false;
            this.but_AddFiles.Click += new System.EventHandler(this.but_AddFiles_Click);
            // 
            // but_RemFiles
            // 
            this.but_RemFiles.BackColor = System.Drawing.Color.Crimson;
            this.but_RemFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_RemFiles.Location = new System.Drawing.Point(0, 0);
            this.but_RemFiles.Name = "but_RemFiles";
            this.but_RemFiles.Size = new System.Drawing.Size(183, 59);
            this.but_RemFiles.TabIndex = 1;
            this.but_RemFiles.Text = "Rem Files";
            this.but_RemFiles.UseVisualStyleBackColor = false;
            this.but_RemFiles.Click += new System.EventHandler(this.but_RemFiles_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.but_ExportFiles);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.but_ImportPak);
            this.splitContainer4.Size = new System.Drawing.Size(376, 61);
            this.splitContainer4.SplitterDistance = 175;
            this.splitContainer4.TabIndex = 1;
            // 
            // but_ExportFiles
            // 
            this.but_ExportFiles.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.but_ExportFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_ExportFiles.Location = new System.Drawing.Point(0, 0);
            this.but_ExportFiles.Name = "but_ExportFiles";
            this.but_ExportFiles.Size = new System.Drawing.Size(173, 59);
            this.but_ExportFiles.TabIndex = 1;
            this.but_ExportFiles.Text = "Export Files";
            this.but_ExportFiles.UseVisualStyleBackColor = false;
            this.but_ExportFiles.Click += new System.EventHandler(this.but_ExportFiles_Click);
            // 
            // but_ImportPak
            // 
            this.but_ImportPak.BackColor = System.Drawing.Color.Plum;
            this.but_ImportPak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_ImportPak.Location = new System.Drawing.Point(0, 0);
            this.but_ImportPak.Name = "but_ImportPak";
            this.but_ImportPak.Size = new System.Drawing.Size(195, 59);
            this.but_ImportPak.TabIndex = 1;
            this.but_ImportPak.Text = "Import Pak";
            this.but_ImportPak.UseVisualStyleBackColor = false;
            this.but_ImportPak.Click += new System.EventHandler(this.but_ImportPak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 465);
            this.Controls.Add(this.split_main);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Paker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.split_main.Panel1.ResumeLayout(false);
            this.split_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_main)).EndInit();
            this.split_main.ResumeLayout(false);
            this.split_Left.Panel1.ResumeLayout(false);
            this.split_Left.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_Left)).EndInit();
            this.split_Left.ResumeLayout(false);
            this.split_Sig.Panel1.ResumeLayout(false);
            this.split_Sig.Panel1.PerformLayout();
            this.split_Sig.Panel2.ResumeLayout(false);
            this.split_Sig.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Sig)).EndInit();
            this.split_Sig.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem importPAKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Files;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Bytes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssl_FreeBytes;
        private System.Windows.Forms.SplitContainer split_main;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button but_AddFiles;
        private System.Windows.Forms.Button but_RemFiles;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button but_ExportFiles;
        private System.Windows.Forms.Button but_ImportPak;
        private System.Windows.Forms.SplitContainer split_Left;
        private System.Windows.Forms.SplitContainer split_Sig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Sig;
        private System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripButton tsbut_UP;
        private System.Windows.Forms.ToolStripButton tsbut_down;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

