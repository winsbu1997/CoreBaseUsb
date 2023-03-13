using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Windows.Forms;
using CoreBaseUsb.Utilities;
using CoreBaseUsb.RAW; 

namespace CoreBaseUsb.GUI
{
    partial class DirFilePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public View ViewListView
        {
            get
            {
                return this.view_0;
            }
            set
            {
                this.view_0 = value;
            }
        }

        // Token: 0x1700000B RID: 11
        // (get) Token: 0x06000063 RID: 99 RVA: 0x00002379 File Offset: 0x00000579
        // (set) Token: 0x06000064 RID: 100 RVA: 0x00002381 File Offset: 0x00000581
        public bool IsLinux
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        // Token: 0x06000065 RID: 101 RVA: 0x0000564C File Offset: 0x0000384C
        private string method_0()
        {
            string result = "";
            TreeNode treeNode = this.treeView.SelectedNode;
            if (treeNode != null)
            {
                while (treeNode.Parent != null)
                {
                    treeNode = treeNode.Parent;
                }
                result = treeNode.Text.Substring(0, treeNode.Text.IndexOf(" "));
            }
            return result;
        }

        // Token: 0x06000066 RID: 102 RVA: 0x000056A8 File Offset: 0x000038A8
        

        // Token: 0x06000067 RID: 103 RVA: 0x0000238A File Offset: 0x0000058A
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000068 RID: 104 RVA: 0x00005718 File Offset: 0x00003918
        private void InitializeComponent()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DirFilePanel));
            this.treeView = new TreeView();
            this.docContextMenuStrip = new ContextMenuStrip(this.icontainer_0);
            this.formatContextMenuItem = new ToolStripMenuItem();
            this.imageList_0 = new ImageList(this.icontainer_0);
            this.listView = new ListView();
            this.columnHeader_0 = new ColumnHeader();
            this.columnHeader_1 = new ColumnHeader();
            this.columnHeader_2 = new ColumnHeader();
            this.columnHeader_3 = new ColumnHeader();
            this.columnHeader_4 = new ColumnHeader();
            this.columnHeader_5 = new ColumnHeader();
            this.columnHeader_6 = new ColumnHeader();
            this.imageList_2 = new ImageList(this.icontainer_0);
            this.imageList_1 = new ImageList(this.icontainer_0);
            this.docContextMenuStrip_1 = new ContextMenuStrip(this.icontainer_0);
            this.newToolStripMenuItem = new ToolStripMenuItem();
            this.pasteToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripMenuItem5 = new ToolStripSeparator();
            this.viewToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.toolStripMenuItem4 = new ToolStripMenuItem();
            this.detailsToolStripMenuItem = new ToolStripMenuItem();
            this.refreshToolStripMenuItem = new ToolStripMenuItem();
            this.contextMenu_0 = new ContextMenu();
            this.menuItem_14 = new MenuItem();
            this.menuItem_15 = new MenuItem();
            this.menuItem_1 = new MenuItem();
            this.menuItem_9 = new MenuItem();
            this.menuItem_10 = new MenuItem();
            this.menuItem_11 = new MenuItem();
            this.menuItem_12 = new MenuItem();
            this.menuItem_13 = new MenuItem();
            this.contextMenu_1 = new ContextMenu();
            this.menuItem_5 = new MenuItem();
            this.menuItem_6 = new MenuItem();
            this.menuItem_7 = new MenuItem();
            this.menuItem_8 = new MenuItem();
            this.contextMenu_2 = new ContextMenu();
            this.menuItem_17 = new MenuItem();
            this.menuItem_16 = new MenuItem();
            this.menuItem_22 = new MenuItem();
            this.menuItem_0 = new MenuItem();
            this.menuItem_18 = new MenuItem();
            this.menuItem_19 = new MenuItem();
            this.menuItem_20 = new MenuItem();
            this.panelComplete = new Panel();
            this.panelTreeList = new Panel();
            this.lblUSB = new Label();
            this.splitter = new Splitter();
            this.panelDirLabel = new Panel();
            this.btlSearch = new Button();
            this.txtSearch = new TextBox();
            this.lblCopy = new Label();
            this.picUSB = new PictureBox();
            this.labelDirectory = new Label();
            this.contextMenu_3 = new ContextMenu();
            this.menuItem_4 = new MenuItem();
            this.menuItem_21 = new MenuItem();
            this.menuItem_2 = new MenuItem();
            this.menuItem_3 = new MenuItem();
            this.docContextMenuStrip_2 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.modifyToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripMenuItem6 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem7 = new ToolStripMenuItem();
            this.toolStripMenuItem8 = new ToolStripMenuItem();
            this.toolStripMenuItem9 = new ToolStripMenuItem();
            this.toolStripMenuItem10 = new ToolStripMenuItem();
            this.toolStripMenuItem11 = new ToolStripMenuItem();
            this.docContextMenuStrip_3 = new ContextMenuStrip(this.icontainer_0);
            this.modifyToolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem12 = new ToolStripMenuItem();
            this.toolStripMenuItem13 = new ToolStripMenuItem();
            this.cutToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripMenuItem14 = new ToolStripMenuItem();
            this.toolStripMenu_Properties = new ToolStripMenuItem();
            this.timer_0 = new Timer(this.icontainer_0);
            this.docContextMenuStrip.SuspendLayout();
            this.docContextMenuStrip_1.SuspendLayout();
            this.panelComplete.SuspendLayout();
            this.panelTreeList.SuspendLayout();
            this.panelDirLabel.SuspendLayout();
            ((ISupportInitialize)this.picUSB).BeginInit();
            this.docContextMenuStrip_2.SuspendLayout();
            this.docContextMenuStrip_3.SuspendLayout();
            base.SuspendLayout();
            this.treeView.AllowDrop = true;
            this.treeView.BackColor = Color.White;
            this.treeView.ContextMenuStrip = this.docContextMenuStrip;
            this.treeView.Dock = DockStyle.Left;
            this.treeView.HideSelection = false;
            this.treeView.HotTracking = true;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList_0;
            this.treeView.Location = new Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new Size(106, 206);
            this.treeView.Sorted = true;
            this.treeView.TabIndex = 0;
            this.treeView.AfterCollapse += this.treeView_AfterCollapse;
            this.treeView.GiveFeedback += this.treeView_GiveFeedback;
            this.treeView.BeforeExpand += this.treeView_BeforeExpand;
            this.treeView.MouseUp += this.treeView_MouseUp;
            this.treeView.DragDrop += this.treeView_DragDrop;
            this.treeView.AfterSelect += this.treeView_AfterSelect;
            this.treeView.MouseDown += this.treeView_MouseDown;
            this.treeView.DragEnter += this.treeView_DragEnter;
            this.treeView.MouseHover += this.treeView_MouseHover;
            this.treeView.DragOver += this.treeView_DragOver;
            this.docContextMenuStrip.Items.AddRange(new ToolStripItem[]
            {
                this.formatContextMenuItem
            });
            this.docContextMenuStrip.Name = "docContextMenuStrip";
            this.docContextMenuStrip.Size = new Size(114, 26);
            this.docContextMenuStrip.Opening += this.docContextMenuStrip_Opening;
            this.formatContextMenuItem.Image = (Image)componentResourceManager.GetObject("formatContextMenuItem.Image");
            this.formatContextMenuItem.Name = "formatContextMenuItem";
            this.formatContextMenuItem.Size = new Size(113, 22);
            this.formatContextMenuItem.Text = "Refresh";
            this.formatContextMenuItem.Click += this.formatContextMenuItem_Click;
            this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListDirectorySymbols.ImageStream");
            this.imageList_0.TransparentColor = Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "");
            this.imageList_0.Images.SetKeyName(1, "");
            this.imageList_0.Images.SetKeyName(2, "");
            this.imageList_0.Images.SetKeyName(3, "");
            this.imageList_0.Images.SetKeyName(4, "");
            this.imageList_0.Images.SetKeyName(5, "");
            this.imageList_0.Images.SetKeyName(6, "");
            this.imageList_0.Images.SetKeyName(7, "");
            this.imageList_0.Images.SetKeyName(8, "");
            this.listView.AllowDrop = true;
            this.listView.BackColor = Color.SkyBlue;
            this.listView.Columns.AddRange(new ColumnHeader[]
            {
                this.columnHeader_0,
                this.columnHeader_1,
                this.columnHeader_2,
                this.columnHeader_3,
                this.columnHeader_4,
                this.columnHeader_5,
                this.columnHeader_6
            });
            this.listView.Dock = DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.LabelEdit = true;
            this.listView.LargeImageList = this.imageList_2;
            this.listView.Location = new Point(106, 0);
            this.listView.Name = "listView";
            this.listView.Size = new Size(424, 206);
            this.listView.SmallImageList = this.imageList_1;
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = View.Details;
            this.listView.AfterLabelEdit += this.listView_AfterLabelEdit;
            this.listView.SelectedIndexChanged += this.listView_SelectedIndexChanged;
            this.listView.DoubleClick += this.listView_DoubleClick;
            this.listView.MouseUp += this.listView_MouseUp;
            this.listView.DragDrop += this.listView_DragDrop;
            this.listView.ColumnClick += this.listView_ColumnClick;
            this.listView.MouseMove += this.listView_MouseMove;
            this.listView.MouseDown += this.listView_MouseDown;
            this.listView.DragEnter += this.listView_DragEnter;
            this.listView.KeyUp += this.ListView_KeyUp;
            this.listView.BeforeLabelEdit += this.listView_BeforeLabelEdit;
            this.columnHeader_0.Text = "Name";
            this.columnHeader_0.Width = 170;
            this.columnHeader_1.Text = "Size [Bytes]";
            this.columnHeader_1.TextAlign = HorizontalAlignment.Right;
            this.columnHeader_1.Width = 100;
            this.columnHeader_2.Text = "Typ";
            this.columnHeader_3.Text = "Last Modified";
            this.columnHeader_3.Width = 120;
            this.columnHeader_4.Text = "Access";
            this.columnHeader_4.Width = 75;
            this.columnHeader_5.Text = "UserID";
            this.columnHeader_6.Text = "GroupID";
            this.imageList_2.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListLargeListView.ImageStream");
            this.imageList_2.TransparentColor = Color.Transparent;
            this.imageList_2.Images.SetKeyName(0, "");
            this.imageList_2.Images.SetKeyName(1, "");
            this.imageList_2.Images.SetKeyName(2, "");
            this.imageList_2.Images.SetKeyName(3, "");
            this.imageList_2.Images.SetKeyName(4, "");
            this.imageList_2.Images.SetKeyName(5, "");
            this.imageList_2.Images.SetKeyName(6, "");
            this.imageList_2.Images.SetKeyName(7, "");
            this.imageList_2.Images.SetKeyName(8, "");
            this.imageList_2.Images.SetKeyName(9, "");
            this.imageList_2.Images.SetKeyName(10, "");
            this.imageList_2.Images.SetKeyName(11, "");
            this.imageList_2.Images.SetKeyName(12, "");
            this.imageList_2.Images.SetKeyName(13, "");
            this.imageList_2.Images.SetKeyName(14, "");
            this.imageList_2.Images.SetKeyName(15, "");
            this.imageList_2.Images.SetKeyName(16, "");
            this.imageList_1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListSmallListView.ImageStream");
            this.imageList_1.TransparentColor = Color.Red;
            this.imageList_1.Images.SetKeyName(0, "");
            this.imageList_1.Images.SetKeyName(1, "");
            this.imageList_1.Images.SetKeyName(2, "");
            this.imageList_1.Images.SetKeyName(3, "");
            this.imageList_1.Images.SetKeyName(4, "");
            this.imageList_1.Images.SetKeyName(5, "");
            this.imageList_1.Images.SetKeyName(6, "");
            this.imageList_1.Images.SetKeyName(7, "");
            this.imageList_1.Images.SetKeyName(8, "");
            this.imageList_1.Images.SetKeyName(9, "");
            this.imageList_1.Images.SetKeyName(10, "");
            this.imageList_1.Images.SetKeyName(11, "");
            this.imageList_1.Images.SetKeyName(12, "");
            this.imageList_1.Images.SetKeyName(13, "");
            this.imageList_1.Images.SetKeyName(14, "");
            this.imageList_1.Images.SetKeyName(15, "");
            this.imageList_1.Images.SetKeyName(16, "");
            this.imageList_1.Images.SetKeyName(17, "lock_key.png");
            this.imageList_1.Images.SetKeyName(18, "back folder.png");
            this.imageList_1.Images.SetKeyName(19, "open_folder_green.png");
            this.imageList_1.Images.SetKeyName(20, "opened_folder.png");
            this.docContextMenuStrip_1.Items.AddRange(new ToolStripItem[]
            {
                this.newToolStripMenuItem,
                this.pasteToolStripMenuItem,
                this.toolStripMenuItem5,
                this.viewToolStripMenuItem,
                this.refreshToolStripMenuItem
            });
            this.docContextMenuStrip_1.Name = "docContextMenuStrip";
            this.docContextMenuStrip_1.Size = new Size(114, 98);
            this.newToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("newToolStripMenuItem.Image");
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new Size(113, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += this.newToolStripMenuItem_Click;
            this.pasteToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("pasteToolStripMenuItem.Image");
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new Size(113, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += this.pasteToolStripMenuItem_Click;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new Size(110, 6);
            this.viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem2,
                this.toolStripMenuItem3,
                this.toolStripMenuItem4,
                this.detailsToolStripMenuItem
            });
            this.viewToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("viewToolStripMenuItem.Image");
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new Size(113, 22);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.Click += this.viewToolStripMenuItem_Click;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(129, 22);
            this.toolStripMenuItem2.Text = "Small Icon";
            this.toolStripMenuItem2.Click += this.toolStripMenuItem2_Click;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(129, 22);
            this.toolStripMenuItem3.Text = "Large Icon";
            this.toolStripMenuItem3.Click += this.toolStripMenuItem3_Click;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new Size(129, 22);
            this.toolStripMenuItem4.Text = "List";
            this.toolStripMenuItem4.Click += this.toolStripMenuItem4_Click;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new Size(129, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += this.detailsToolStripMenuItem_Click;
            this.refreshToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("refreshToolStripMenuItem.Image");
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new Size(113, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += this.refreshToolStripMenuItem_Click;
            this.contextMenu_0.MenuItems.AddRange(new MenuItem[]
            {
                this.menuItem_14,
                this.menuItem_15,
                this.menuItem_1,
                this.menuItem_9
            });
            this.menuItem_14.Index = 0;
            this.menuItem_14.Text = "&New";
            this.menuItem_14.Click += this.MenuItemListViewNew_Click;
            this.menuItem_15.Index = 1;
            this.menuItem_15.Text = "&Paste";
            this.menuItem_15.Click += this.menuItem_15_Click;
            this.menuItem_1.Index = 2;
            this.menuItem_1.Text = "-";
            this.menuItem_9.Index = 3;
            this.menuItem_9.MenuItems.AddRange(new MenuItem[]
            {
                this.menuItem_10,
                this.menuItem_11,
                this.menuItem_12,
                this.menuItem_13
            });
            this.menuItem_9.Text = "&Views";
            this.menuItem_10.Index = 0;
            this.menuItem_10.RadioCheck = true;
            this.menuItem_10.Text = "Small Icon";
            this.menuItem_10.Click += this.menuItem_10_Click;
            this.menuItem_11.Index = 1;
            this.menuItem_11.RadioCheck = true;
            this.menuItem_11.Text = "Large Icon";
            this.menuItem_11.Click += this.menuItem_11_Click;
            this.menuItem_12.Index = 2;
            this.menuItem_12.RadioCheck = true;
            this.menuItem_12.Text = "List";
            this.menuItem_12.Click += this.menuItem_12_Click;
            this.menuItem_13.Index = 3;
            this.menuItem_13.RadioCheck = true;
            this.menuItem_13.Text = "Details";
            this.menuItem_13.Click += this.menuItem_13_Click;
            this.contextMenu_1.MenuItems.AddRange(new MenuItem[]
            {
                this.menuItem_5,
                this.menuItem_6,
                this.menuItem_7,
                this.menuItem_8
            });
            this.menuItem_5.Index = 0;
            this.menuItem_5.Text = "&Modify";
            this.menuItem_5.Click += this.menuItem_5_Click;
            this.menuItem_6.Index = 1;
            this.menuItem_6.Text = "&Delete";
            this.menuItem_6.Click += this.menuItem_6_Click;
            this.menuItem_7.Index = 2;
            this.menuItem_7.Text = "&Copy";
            this.menuItem_7.Click += this.menuItem_7_Click;
            this.menuItem_8.Index = 3;
            this.menuItem_8.Text = "&View";
            this.menuItem_8.Visible = false;
            this.menuItem_8.Click += this.menuItem_8_Click;
            this.contextMenu_2.MenuItems.AddRange(new MenuItem[]
            {
                this.menuItem_17,
                this.menuItem_16,
                this.menuItem_22,
                this.menuItem_0,
                this.menuItem_18,
                this.menuItem_19,
                this.menuItem_20
            });
            this.contextMenu_2.Popup += this.contextMenu_2_Popup;
            this.menuItem_17.Index = 0;
            this.menuItem_17.Text = "Expand Node";
            this.menuItem_17.Visible = false;
            this.menuItem_17.Click += this.menuItem_17_Click;
            this.menuItem_16.Index = 1;
            this.menuItem_16.Text = "Collapse Node";
            this.menuItem_16.Visible = false;
            this.menuItem_16.Click += this.menuItem_16_Click;
            this.menuItem_22.Index = 2;
            this.menuItem_22.Text = "Remove Drive";
            this.menuItem_22.Visible = false;
            this.menuItem_22.Click += this.menuItem_22_Click;
            this.menuItem_0.Index = 3;
            this.menuItem_0.Text = "-";
            this.menuItem_0.Visible = false;
            this.menuItem_18.Index = 4;
            this.menuItem_18.Text = "&New";
            this.menuItem_18.Visible = false;
            this.menuItem_18.Click += this.MenuItemTreeViewNodeNew_Click;
            this.menuItem_19.Index = 5;
            this.menuItem_19.Text = "&Modify";
            this.menuItem_19.Visible = false;
            this.menuItem_19.Click += this.MenuItemTreeViewNodeModify_Click;
            this.menuItem_20.Index = 6;
            this.menuItem_20.Text = "&Paste";
            this.menuItem_20.Visible = false;
            this.menuItem_20.Click += this.MenuItemTreeViewNodePaste_Click;
            this.panelComplete.Controls.Add(this.panelTreeList);
            this.panelComplete.Controls.Add(this.panelDirLabel);
            this.panelComplete.Dock = DockStyle.Fill;
            this.panelComplete.Location = new Point(0, 0);
            this.panelComplete.Name = "panelComplete";
            this.panelComplete.Size = new Size(530, 241);
            this.panelComplete.TabIndex = 3;
            this.panelTreeList.Controls.Add(this.lblUSB);
            this.panelTreeList.Controls.Add(this.splitter);
            this.panelTreeList.Controls.Add(this.listView);
            this.panelTreeList.Controls.Add(this.treeView);
            this.panelTreeList.Dock = DockStyle.Fill;
            this.panelTreeList.Location = new Point(0, 35);
            this.panelTreeList.Name = "panelTreeList";
            this.panelTreeList.Size = new Size(530, 206);
            this.panelTreeList.TabIndex = 5;
            this.lblUSB.BackColor = Color.White;
            this.lblUSB.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblUSB.ForeColor = Color.Maroon;
            this.lblUSB.Image = (Image)componentResourceManager.GetObject("lblUSB.Image");
            this.lblUSB.ImageAlign = ContentAlignment.MiddleLeft;
            this.lblUSB.Location = new Point(3, 3);
            this.lblUSB.Name = "lblUSB";
            this.lblUSB.Size = new Size(101, 17);
            this.lblUSB.TabIndex = 42;
            this.lblUSB.Text = "         USB";
            this.lblUSB.TextAlign = ContentAlignment.MiddleLeft;
            this.splitter.Location = new Point(106, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new Size(3, 206);
            this.splitter.TabIndex = 2;
            this.splitter.TabStop = false;
            this.splitter.SplitterMoved += this.splitter_SplitterMoved;
            this.panelDirLabel.Controls.Add(this.btlSearch);
            this.panelDirLabel.Controls.Add(this.txtSearch);
            this.panelDirLabel.Controls.Add(this.lblCopy);
            this.panelDirLabel.Controls.Add(this.picUSB);
            this.panelDirLabel.Controls.Add(this.labelDirectory);
            this.panelDirLabel.Dock = DockStyle.Top;
            this.panelDirLabel.Location = new Point(0, 0);
            this.panelDirLabel.Name = "panelDirLabel";
            this.panelDirLabel.Size = new Size(530, 35);
            this.panelDirLabel.TabIndex = 4;
            this.btlSearch.Image = (Image)componentResourceManager.GetObject("btlSearch.Image");
            this.btlSearch.Location = new Point(419, 3);
            this.btlSearch.Name = "btlSearch";
            this.btlSearch.Size = new Size(23, 22);
            this.btlSearch.TabIndex = 45;
            this.btlSearch.UseVisualStyleBackColor = true;
            this.btlSearch.Click += this.btlSearch_Click;
            this.txtSearch.Location = new Point(221, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(192, 20);
            this.txtSearch.TabIndex = 44;
            this.lblCopy.BackColor = Color.FromArgb(255, 255, 128);
            this.lblCopy.FlatStyle = FlatStyle.Popup;
            this.lblCopy.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            this.lblCopy.ForeColor = Color.FromArgb(0, 0, 192);
            this.lblCopy.Location = new Point(355, 2);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new Size(171, 26);
            this.lblCopy.TabIndex = 43;
            this.lblCopy.Text = "Đang xử lý dữ liệu...";
            this.lblCopy.TextAlign = ContentAlignment.MiddleCenter;
            this.picUSB.BackColor = Color.Teal;
            this.picUSB.Image = (Image)componentResourceManager.GetObject("picUSB.Image");
            this.picUSB.Location = new Point(1, 2);
            this.picUSB.Name = "picUSB";
            this.picUSB.Size = new Size(27, 25);
            this.picUSB.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picUSB.TabIndex = 9;
            this.picUSB.TabStop = false;
            this.labelDirectory.BackColor = Color.Teal;
            this.labelDirectory.Dock = DockStyle.Top;
            this.labelDirectory.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.labelDirectory.ForeColor = Color.White;
            this.labelDirectory.Location = new Point(0, 0);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new Size(530, 29);
            this.labelDirectory.TabIndex = 0;
            this.labelDirectory.Text = "         My Computer";
            this.labelDirectory.TextAlign = ContentAlignment.MiddleLeft;
            this.contextMenu_3.MenuItems.AddRange(new MenuItem[]
            {
                this.menuItem_4,
                this.menuItem_21,
                this.menuItem_2,
                this.menuItem_3
            });
            this.menuItem_4.Index = 0;
            this.menuItem_4.Text = "Collapse All";
            this.menuItem_4.Visible = false;
            this.menuItem_4.Click += this.menuItem_4_Click;
            this.menuItem_21.Index = 1;
            this.menuItem_21.Text = "Add Drive ...";
            this.menuItem_21.Visible = false;
            this.menuItem_21.Click += this.MenuItemTreeViewAddDrive_Click;
            this.menuItem_2.Index = 2;
            this.menuItem_2.Text = "-";
            this.menuItem_2.Visible = false;
            this.menuItem_3.Index = 3;
            this.menuItem_3.Text = "&Refresh";
            this.menuItem_3.Click += this.menuItem_3_Click;
            this.docContextMenuStrip_2.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem1,
                this.modifyToolStripMenuItem,
                this.toolStripMenuItem6,
                this.toolStripSeparator1,
                this.toolStripMenuItem7
            });
            this.docContextMenuStrip_2.Name = "docContextMenuStrip";
            this.docContextMenuStrip_2.Size = new Size(113, 98);
            this.toolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem1.Image");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(112, 22);
            this.toolStripMenuItem1.Text = "New";
            this.toolStripMenuItem1.Click += this.toolStripMenuItem1_Click;
            this.modifyToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("modifyToolStripMenuItem.Image");
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new Size(112, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += this.modifyToolStripMenuItem_Click;
            this.toolStripMenuItem6.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem6.Image");
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new Size(112, 22);
            this.toolStripMenuItem6.Text = "Paste";
            this.toolStripMenuItem6.Click += this.toolStripMenuItem6_Click;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(109, 6);
            this.toolStripSeparator1.Visible = false;
            this.toolStripMenuItem7.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem8,
                this.toolStripMenuItem9,
                this.toolStripMenuItem10,
                this.toolStripMenuItem11
            });
            this.toolStripMenuItem7.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem7.Image");
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new Size(112, 22);
            this.toolStripMenuItem7.Text = "View";
            this.toolStripMenuItem7.Visible = false;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new Size(129, 22);
            this.toolStripMenuItem8.Text = "Small Icon";
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new Size(129, 22);
            this.toolStripMenuItem9.Text = "Large Icon";
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new Size(129, 22);
            this.toolStripMenuItem10.Text = "List";
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new Size(129, 22);
            this.toolStripMenuItem11.Text = "Details";
            this.docContextMenuStrip_3.Items.AddRange(new ToolStripItem[]
            {
                this.modifyToolStripMenuItem1,
                this.toolStripMenuItem12,
                this.toolStripMenuItem13,
                this.cutToolStripMenuItem,
                this.toolStripSeparator2,
                this.toolStripMenuItem14,
                this.toolStripMenu_Properties
            });
            this.docContextMenuStrip_3.Name = "docContextMenuStrip";
            this.docContextMenuStrip_3.Size = new Size(128, 142);
            this.modifyToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("modifyToolStripMenuItem1.Image");
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Size = new Size(127, 22);
            this.modifyToolStripMenuItem1.Text = "&Rename";
            this.modifyToolStripMenuItem1.Click += this.modifyToolStripMenuItem1_Click;
            this.toolStripMenuItem12.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem12.Image");
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new Size(127, 22);
            this.toolStripMenuItem12.Text = "&Delete";
            this.toolStripMenuItem12.Click += this.toolStripMenuItem12_Click;
            this.toolStripMenuItem13.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem13.Image");
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new Size(127, 22);
            this.toolStripMenuItem13.Text = "&Copy";
            this.toolStripMenuItem13.Click += this.toolStripMenuItem13_Click;
            this.cutToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("cutToolStripMenuItem.Image");
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new Size(127, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Visible = false;
            this.cutToolStripMenuItem.Click += this.cutToolStripMenuItem_Click;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(124, 6);
            this.toolStripSeparator2.Visible = false;
            this.toolStripMenuItem14.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem14.Image");
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new Size(127, 22);
            this.toolStripMenuItem14.Text = "View";
            this.toolStripMenuItem14.Click += this.toolStripMenuItem14_Click;
            this.toolStripMenu_Properties.Name = "toolStripMenu_Properties";
            this.toolStripMenu_Properties.Size = new Size(127, 22);
            this.toolStripMenu_Properties.Text = "Properties";
            this.toolStripMenu_Properties.Click += this.toolStripMenu_Properties_Click;
            this.timer_0.Interval = 1000;
            this.timer_0.Tick += this.timer_0_Tick;
            this.AllowDrop = true;
            base.Controls.Add(this.panelComplete);
            base.Name = "DirFilePanel";
            base.Size = new Size(530, 241);
            this.docContextMenuStrip.ResumeLayout(false);
            this.docContextMenuStrip_1.ResumeLayout(false);
            this.panelComplete.ResumeLayout(false);
            this.panelTreeList.ResumeLayout(false);
            this.panelDirLabel.ResumeLayout(false);
            this.panelDirLabel.PerformLayout();
            ((ISupportInitialize)this.picUSB).EndInit();
            this.docContextMenuStrip_2.ResumeLayout(false);
            this.docContextMenuStrip_3.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        // Token: 0x06000069 RID: 105 RVA: 0x00007BF0 File Offset: 0x00005DF0
        public void FillDosDirectoryTree()
        {
            string b = DISK.ReadABCFromUSB();
            if (!(LTOOLSnet.MAINMK != b))
            {
                this.IsLinux = false;
                this.lblCopy.Visible = false;
                this.lblUSB.Visible = false;
                this.picUSB.Visible = false;
                this.txtSearch.Visible = false;
                this.btlSearch.Visible = false;
                this.labelDirectory.Text = "         My Computer";
                this.labelDirectory.ForeColor = Color.White;
                this.listView.BackColor = Color.White;
                this.method_18("FillDosDirectoryTree()");
                this.treeView.Nodes.Clear();
                this.treeView.BeginUpdate();
                this.AddDesktopDirectory();
                this.AddMyDoccumentDirectory();
                string[] logicalDrives = Environment.GetLogicalDrives();
                for (int i = 0; i < logicalDrives.Length; i++)
                {
                    if (logicalDrives[i].IndexOf("A:") < 0)
                    {
                        this.method_18("drives[i]): " + logicalDrives[i]);
                        DirectoryNode directoryNode = new DirectoryNode(logicalDrives[i]);
                        directoryNode.SelectedImageIndex = PlatformInvokeKernel32.GetDriveType(logicalDrives[i]);
                        directoryNode.ImageIndex = PlatformInvokeKernel32.GetDriveType(logicalDrives[i]);
                        if (PlatformInvokeKernel32.GetDriveType(logicalDrives[i]) == 2 || PlatformInvokeKernel32.GetDriveType(logicalDrives[i]) == 5)
                        {
                            directoryNode.IsRemovableDrive = true;
                        }
                        else
                        {
                            directoryNode.IsRemovableDrive = false;
                        }
                        this.treeView.Nodes.Add(directoryNode);
                        try
                        {
                            if (!directoryNode.IsRemovableDrive)
                            {
                                this.method_1(directoryNode);
                            }
                        }
                        catch (Exception ex)
                        {
                            this.method_18(ex.Message + "\r\n" + ex.StackTrace);
                        }
                    }
                }
                this.method_2();
                this.treeView.EndUpdate();
            }
        }

        // Token: 0x0600006A RID: 106 RVA: 0x00007DB8 File Offset: 0x00005FB8
        public void AddDesktopDirectory()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryNode directoryNode = new DirectoryNode(folderPath);
            directoryNode.SelectedImageIndex = PlatformInvokeKernel32.GetDriveType(folderPath);
            directoryNode.ImageIndex = PlatformInvokeKernel32.GetDriveType(folderPath);
            this.treeView.Nodes.Add(directoryNode);
            try
            {
                this.method_1(directoryNode);
            }
            catch (Exception ex)
            {
                this.method_18(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        // Token: 0x0600006B RID: 107 RVA: 0x00007E38 File Offset: 0x00006038
        public void AddMyDoccumentDirectory()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            DirectoryNode directoryNode = new DirectoryNode(folderPath);
            directoryNode.SelectedImageIndex = PlatformInvokeKernel32.GetDriveType(folderPath);
            directoryNode.ImageIndex = PlatformInvokeKernel32.GetDriveType(folderPath);
            this.treeView.Nodes.Add(directoryNode);
            try
            {
                this.method_1(directoryNode);
            }
            catch (Exception ex)
            {
                this.method_18(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        // Token: 0x0600006C RID: 108 RVA: 0x00007EB8 File Offset: 0x000060B8
        public void AddMyComputerDirectory()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            DirectoryNode directoryNode = new DirectoryNode(folderPath);
            directoryNode.SelectedImageIndex = PlatformInvokeKernel32.GetDriveType(folderPath);
            directoryNode.ImageIndex = PlatformInvokeKernel32.GetDriveType(folderPath);
            this.treeView.Nodes.Add(directoryNode);
            try
            {
                this.method_1(directoryNode);
            }
            catch (Exception ex)
            {
                this.method_18(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        // Token: 0x0600006D RID: 109 RVA: 0x00007F38 File Offset: 0x00006138
        private void method_1(DirectoryNode directoryNode_2)
        {
            this.method_18("AddDosDirectories()");
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(this.method_12(directoryNode_2));
                DirectoryInfo[] directories = directoryInfo.GetDirectories();
                for (int i = 0; i < directories.Length; i++)
                {
                    string name = directories[i].Name;
                    if (!name.Equals(".") && !name.Equals(".."))
                    {
                        DirectoryNode directoryNode = new DirectoryNode(name);
                        directoryNode.ImageIndex = 7;
                        directoryNode.SelectedImageIndex = 8;
                        directoryNode_2.Nodes.Add(directoryNode);
                    }
                }
            }
            catch (Exception ex)
            {
                this.method_18(string.Concat(new string[]
                {
                    MyDebug.SeparatorLine,
                    ex.Message,
                    "\r\n",
                    ex.StackTrace,
                    MyDebug.SeparatorLine
                }));
            }
        }

        // Token: 0x0600006E RID: 110 RVA: 0x0000801C File Offset: 0x0000621C
        private void WytvnybTJ(DirectoryNode directoryNode_2)
        {
            this.method_18("AddDosSubDirectories()");
            try
            {
                for (int i = 0; i < directoryNode_2.Nodes.Count; i++)
                {
                    this.method_1((DirectoryNode)directoryNode_2.Nodes[i]);
                }
                directoryNode_2.SubDirectoriesAdded = true;
            }
            catch (Exception ex)
            {
                this.method_18(string.Concat(new string[]
                {
                    MyDebug.SeparatorLine,
                    ex.Message,
                    "\r\n",
                    ex.StackTrace,
                    MyDebug.SeparatorLine
                }));
            }
        }

        // Token: 0x0600006F RID: 111 RVA: 0x000080BC File Offset: 0x000062BC
        private void method_2()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            for (int i = 0; i < this.treeView.Nodes.Count; i++)
            {
                if (this.treeView.Nodes[i].Text.ToUpper() == folderPath)
                {
                    this.treeView.SelectedNode = this.treeView.Nodes[i];
                    return;
                }
            }
            this.treeView.SelectedNode = this.treeView.TopNode;
        }

        // Token: 0x06000070 RID: 112 RVA: 0x00008148 File Offset: 0x00006348
        public void ModifyDosFile(ListView.SelectedListViewItemCollection items)
        {
            bool isNew = false;
            foreach (object obj in items)
            {
                ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                if (!listViewItemFile.IsError && !listViewItemFile.FileName.Equals(".."))
                {
                    bool flag = false;
                    bool flag2 = false;
                    bool flag3 = false;
                    FileAttributes attributes;
                    if (listViewItemFile.IsDirectory)
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(listViewItemFile.FullFilePath);
                        attributes = directoryInfo.Attributes;
                        if ((attributes & FileAttributes.ReadOnly) != (FileAttributes)0)
                        {
                            flag = true;
                        }
                        if ((attributes & FileAttributes.Hidden) != (FileAttributes)0)
                        {
                            flag2 = true;
                        }
                        if ((attributes & FileAttributes.System) != (FileAttributes)0)
                        {
                            flag3 = true;
                        }
                    }
                    else
                    {
                        FileInfo fileInfo = new FileInfo(listViewItemFile.FullFilePath);
                        attributes = fileInfo.Attributes;
                        if ((attributes & FileAttributes.ReadOnly) != (FileAttributes)0)
                        {
                            flag = true;
                        }
                        if ((attributes & FileAttributes.Hidden) != (FileAttributes)0)
                        {
                            flag2 = true;
                        }
                        if ((attributes & FileAttributes.System) != (FileAttributes)0)
                        {
                            flag3 = true;
                        }
                    }
                    ModifyDosDialog modifyDosDialog = new ModifyDosDialog(isNew, listViewItemFile.FileName, listViewItemFile.FileSize, listViewItemFile.FileLastModified, listViewItemFile.IsDirectory, flag, flag2, flag3);
                    DialogResult dialogResult = modifyDosDialog.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        FileAttributes fileAttributes = attributes;
                        if (modifyDosDialog.IsReadOnly != flag)
                        {
                            listViewItemFile.IsReadOnly = modifyDosDialog.IsReadOnly;
                            if (modifyDosDialog.IsReadOnly)
                            {
                                fileAttributes |= FileAttributes.ReadOnly;
                            }
                            else
                            {
                                fileAttributes &= ~FileAttributes.ReadOnly;
                            }
                        }
                        if (modifyDosDialog.IsHidden != flag2)
                        {
                            if (modifyDosDialog.IsHidden)
                            {
                                fileAttributes |= FileAttributes.Hidden;
                            }
                            else
                            {
                                fileAttributes &= ~FileAttributes.Hidden;
                            }
                        }
                        if (modifyDosDialog.IsSystem != flag3)
                        {
                            if (modifyDosDialog.IsSystem)
                            {
                                fileAttributes |= FileAttributes.System;
                            }
                            else
                            {
                                fileAttributes &= ~FileAttributes.System;
                            }
                        }
                        this.method_18("FileAttributes: " + fileAttributes.ToString());
                        string text;
                        if (listViewItemFile.Directory.EndsWith(Path.DirectorySeparatorChar.ToString()))
                        {
                            text = listViewItemFile.Directory + modifyDosDialog.FileName;
                        }
                        else
                        {
                            text = listViewItemFile.Directory + Path.DirectorySeparatorChar + modifyDosDialog.FileName;
                        }
                        if (!listViewItemFile.FullFilePath.ToLower().Equals(text.ToLower()) || fileAttributes != attributes)
                        {
                            if (!listViewItemFile.FullFilePath.ToLower().Equals(text.ToLower()))
                            {
                                if (listViewItemFile.IsDirectory)
                                {
                                    this.method_18("ModifyDosFile(): modify directory - source: " + listViewItemFile.FullFilePath + " to destination: " + text);
                                    Directory.Move(listViewItemFile.FullFilePath, text);
                                }
                                else
                                {
                                    this.method_18("ModifyDosFile(): modify file - source: " + listViewItemFile.FullFilePath + " to destination: " + text);
                                    File.Move(listViewItemFile.FullFilePath, text);
                                }
                            }
                            if (fileAttributes != attributes)
                            {
                                if (listViewItemFile.IsDirectory)
                                {
                                    DirectoryInfo directoryInfo = new DirectoryInfo(text);
                                    directoryInfo.Attributes = fileAttributes;
                                }
                                else
                                {
                                    FileInfo fileInfo = new FileInfo(text);
                                    fileInfo.Attributes = fileAttributes;
                                }
                            }
                            this.UpdateNode(this.GetSelectedDirectoryNode());
                        }
                    }
                }
            }
        }

        // Token: 0x06000071 RID: 113 RVA: 0x0000846C File Offset: 0x0000666C
        public void NewDosDirectory(DirectoryNode node)
        {
            this.method_18("NewDosDirectory() in Directory: " + node.Path);
            ModifyDosDialog modifyDosDialog = new ModifyDosDialog(true, "", "", "", true, false, false, false);
            if (modifyDosDialog.ShowDialog() == DialogResult.OK && !modifyDosDialog.FileName.Equals(""))
            {
                try
                {
                    string text = node.Path + Path.DirectorySeparatorChar.ToString() + modifyDosDialog.FileName;
                    DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
                    DirectoryInfo directoryInfo2 = new DirectoryInfo(text);
                    FileAttributes fileAttributes = directoryInfo2.Attributes;
                    if (modifyDosDialog.IsHidden)
                    {
                        fileAttributes |= FileAttributes.Hidden;
                    }
                    if (modifyDosDialog.IsSystem)
                    {
                        fileAttributes |= FileAttributes.System;
                    }
                    if (modifyDosDialog.IsReadOnly)
                    {
                        fileAttributes |= FileAttributes.ReadOnly;
                    }
                    directoryInfo2.Attributes = fileAttributes;
                    if (!directoryInfo.Exists)
                    {
                        MessageBox.Show("Lỗi tạo thư mục!" + text, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    this.UpdateNode(node);
                }
                catch
                {
                    MessageBox.Show("Lỗi tạo thư mục!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        // Token: 0x06000072 RID: 114 RVA: 0x00008590 File Offset: 0x00006790
        public void DeleteDosFile(ListView.SelectedListViewItemCollection items, bool confirmDelete)
        {
            bool flag = false;
            bool flag2 = false;
            flag2 = false;
            if (confirmDelete)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa file (hoặc thư mục) không?", "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }
                flag2 = true;
            }
            else
            {
                flag2 = true;
            }
            if (flag2)
            {
                int i = 0;
                while (i <= 2000)
                {
                    i++;
                    LTOOLSnet.ShowProgessBar(true);
                    Application.DoEvents();
                }
            }
            foreach (object obj in items)
            {
                ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                if (!listViewItemFile.IsError && !listViewItemFile.FileName.Equals(".."))
                {
                    string fullFilePath = listViewItemFile.FullFilePath;
                    this.method_18("DeleteDosFile(): " + fullFilePath + " - " + flag2.ToString());
                    if (flag2)
                    {
                        flag = true;
                        FileAttributes attributes = File.GetAttributes(fullFilePath);
                        if ((attributes & FileAttributes.Directory) != (FileAttributes)0)
                        {
                            try
                            {
                                Directory.Delete(fullFilePath, true);
                                continue;
                            }
                            catch (IOException ex)
                            {
                                this.method_18(ex.Message);
                                MessageBox.Show("Không xóa được thư mục " + fullFilePath + " có lỗi phát sinh.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                continue;
                            }
                            catch (SecurityException ex2)
                            {
                                this.method_18(ex2.Message);
                                MessageBox.Show("Không xóa được thư mục " + fullFilePath + " do quyền người dùng bị hạn chế.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                continue;
                            }
                            catch
                            {
                                MessageBox.Show("Không xóa được thư mục " + fullFilePath, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                continue;
                            }
                        }
                        try
                        {
                            File.Delete(fullFilePath);
                        }
                        catch
                        {
                            MessageBox.Show("Không xóa được file " + fullFilePath, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
            }
            LTOOLSnet.ShowProgessBar(false);
            if (flag)
            {
                DirectoryNode selectedDirectoryNode = this.GetSelectedDirectoryNode();
                this.UpdateNode(selectedDirectoryNode);
            }
        }

        // Token: 0x06000073 RID: 115 RVA: 0x000087EC File Offset: 0x000069EC
        public void StartDosApplication(ListViewItemFile item, bool start)
        {
            try
            {
                if (!item.IsError)
                {
                    if (start)
                    {
                        this.method_18("StartDosApplication() \"" + item.FullFilePath + "\"");
                        Process.Start("\"" + item.FullFilePath + "\"");
                    }
                    else
                    {
                        this.method_18("StartDosApplication() edit.bat " + item.FullFilePath);
                        Process.Start("edit.bat", "\"" + item.FullFilePath + "\"");
                    }
                }
            }
            catch (Exception ex)
            {
                this.method_18(ex.Message);
                MessageBox.Show(ex.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        // Token: 0x06000074 RID: 116 RVA: 0x000088AC File Offset: 0x00006AAC
        public void PasteToDos(string targetDirectory, bool issueMessages)
        {
            bool flag = false;
            int i = 0;
            while (i <= 1000)
            {
                i++;
                LTOOLSnet.ShowProgessBar(true);
                Application.DoEvents();
            }
            if (!targetDirectory.EndsWith("\\"))
            {
                targetDirectory += "\\";
            }
            int j = 0;
            while (j < LTOOLSnet.CopyFileCount)
            {
                if (LTOOLSnet.CopyFileDirPath[j].Equals(""))
                {
                    goto IL_7A6;
                }
                string text = "";
                string[] array;
                string text2;
                if (!LTOOLSnet.CopyFileIsLinux)
                {
                    try
                    {
                        array = LTOOLSnet.CopyFileDirPath[j].ToString().Split(new char[]
                        {
                            '\\'
                        });
                        text2 = "";
                        for (int k = 0; k < array.Length; k++)
                        {
                            if (array[k].Length > 0)
                            {
                                text2 = text2 + array[k].ToString() + "\\";
                            }
                        }
                        if (!Directory.Exists(targetDirectory + "\\" + LTOOLSnet.CopyFileDirPath[j]))
                        {
                            Directory.CreateDirectory(targetDirectory + "\\" + LTOOLSnet.CopyFileDirPath[j]);
                            flag = true;
                        }
                        else if (j == 0 || (j > 0 && !LTOOLSnet.CopyFileDir[j].Equals(LTOOLSnet.CopyFileDir[j - 1])))
                        {
                            DialogResult dialogResult = MessageBox.Show(string.Concat(new string[]
                            {
                                "Thư mục \"",
                                targetDirectory,
                                "\\",
                                text2,
                                "\" đã tồn tại. Bạn có ghi đè không?"
                            }), "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            flag = (dialogResult == DialogResult.Yes);
                        }
                        string sourceFileName = LTOOLSnet.CopyFilePath[j].ToString();
                        text = targetDirectory + "\\" + text2 + LTOOLSnet.CopyFileName[j].ToString();
                        File.Copy(sourceFileName, text, true);
                        goto IL_CEC;
                    }
                    catch (FileNotFoundException ex)
                    {
                        this.method_18(ex.Message);
                        if (issueMessages)
                        {
                            MessageBox.Show("Không mở được file " + LTOOLSnet.CopyFilePath[j], "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        LTOOLSnet.ShowProgessBar(false);
                        return;
                    }
                    catch (IOException ex2)
                    {
                        this.method_18(ex2.Message);
                        if (issueMessages)
                        {
                            MessageBox.Show("Không ghi được file " + text + ".\n" + ex2.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        LTOOLSnet.ShowProgessBar(false);
                        return;
                    }
                    goto IL_7A6;
                }
                string text3 = "ucom";
                array = this.method_5(LTOOLSnet.CopyFileDirPath[j].ToString()).Split(new char[]
                {
                    '/'
                });
                text2 = "";
                string text4 = "";
                targetDirectory.Split(new char[]
                {
                    '\\'
                });
                if (!Directory.Exists(DirFilePanel.tempPathLinuxFiles))
                {
                    Directory.CreateDirectory(DirFilePanel.tempPathLinuxFiles);
                }
                string str = DirFilePanel.tempPathLinuxFiles + "\\";
                for (int k = 0; k < array.Length; k++)
                {
                    if (array[k].Length > 0)
                    {
                        text2 = text2 + UMD5.ConvertHexToString(array[k].ToString(), Encoding.Unicode) + "\\";
                        text4 = text4 + array[k].ToString() + "\\";
                    }
                }
                UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                text = targetDirectory + text2 + LTOOLSnet.CopyFileName[j].ToString();
                if (!Directory.Exists(targetDirectory + text2))
                {
                    Directory.CreateDirectory(targetDirectory + text2);
                    flag = true;
                }
                else if (j == 0 || (j > 0 && !LTOOLSnet.CopyFileDir[j].Equals(LTOOLSnet.CopyFileDir[j - 1])))
                {
                    DialogResult dialogResult = MessageBox.Show("Thư mục \"" + targetDirectory + text2 + "\" đã tồn tại. Bạn có ghi đè không?", "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    flag = (dialogResult == DialogResult.Yes);
                }
                this.method_18(string.Concat(new object[]
                {
                    "PasteToDos(): source: ",
                    LTOOLSnet.CopyFilePath[j],
                    " - destination: ",
                    text
                }));
                string text7;
                if (flag)
                {
                    if (LTOOLSnet.Connected)
                    {
                        goto IL_4BD;
                    }
                    string text5 = this.method_6(LTOOLSnet.CopyFilePath[j].ToString(), LTOOLSnet.CopyFileName[j].ToString());
                    text5 += UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                    string text6 = LTOOLSnet.CopyFileSize[j].ToString();
                    text = targetDirectory + text2 + LTOOLSnet.CopyFileName[j];
                    text7 = str + text4 + UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                    text6 = text6.Replace(",", "");
                    text6 = text6.Replace(".", "");
                    text6 = text6.Replace(" ", "");
                    usbpublic.FILE_SIZE = Convert.ToInt64(text6);
                    Directory.CreateDirectory(str + text4);
                    string text8;
                    ULDir uldir;
                    if (Convert.ToInt64(text6) > 104857600L)
                    {
                        text8 = string.Concat(new string[]
                        {
                            "-READ -q -s",
                            this.method_4(LTOOLSnet.CopyFilePath[j].ToString()),
                            " \"",
                            text5,
                            "\" \"",
                            text7,
                            "\""
                        });
                        this.method_18(text3 + " " + text8);
                        uldir = new ULDir(text3, text8);
                        File.Move(text7, text);
                        try
                        {
                            if (File.Exists(text7))
                            {
                                File.Delete(text7);
                            }
                            goto IL_CF5;
                        }
                        catch
                        {
                            goto IL_CF5;
                        }
                    }
                    text8 = string.Concat(new string[]
                    {
                        "-READ -q -s",
                        this.method_4(LTOOLSnet.CopyFilePath[j].ToString()),
                        " \"",
                        text5,
                        "\" \"",
                        text7,
                        "\""
                    });
                    this.method_18(text3 + " " + text8);
                    uldir = new ULDir(text3, text8);
                    if (LTOOLSnet.IsEncryptFile)
                    {
                        string key_FORMAT = usbpublic.KEY_FORMAT;
                        UMD5.DecryptFile(text7, text, key_FORMAT, false);
                        try
                        {
                            if (File.Exists(text7))
                            {
                                File.Delete(text7);
                            }
                            goto IL_CF5;
                        }
                        catch
                        {
                            goto IL_CF5;
                        }
                        goto IL_4BD;
                    }
                IL_CF5:
                    if (uldir.Response.Length > 0)
                    {
                        if (issueMessages)
                        {
                            MessageBox.Show("Paste file error.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        return;
                    }
                    else
                    {
                        if (LTOOLSnet.Connected)
                        {
                            this.method_18("GetFileFromHost(\"" + text + "\")");
                            this.method_16((string)LTOOLSnet.CopyFileName[j]);
                            File.Move(DirFilePanel.tempPathLinuxFiles + Path.DirectorySeparatorChar.ToString() + LTOOLSnet.CopyFileName[j], text);
                        }
                        goto IL_CEC;
                    }
                IL_4BD:
                    text8 = string.Concat(new string[]
                    {
                        "-READ -x -s",
                        this.method_4(LTOOLSnet.CopyFilePath[j].ToString()),
                        " \"",
                        this.method_5(LTOOLSnet.CopyFilePath[j].ToString()),
                        "\" zzz.xxx"
                    });
                    this.method_18(text3 + " " + text8);
                    uldir = new ULDir(text3, text8, LTOOLSnet.NetSocket);
                    goto IL_CF5;
                }
            IL_CEC:
                j++;
                continue;
            IL_7A6:
                text = targetDirectory + LTOOLSnet.CopyFileName[j];
                text7 = DirFilePanel.tempPathLinuxFiles + "\\";
                if (File.Exists(text))
                {
                    DialogResult dialogResult = MessageBox.Show("File \"" + LTOOLSnet.CopyFileName[j] + "\" đã tồn tại. Bạn có ghi đè không?", "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        goto IL_CEC;
                    }
                }
                this.method_18(string.Concat(new object[]
                {
                    "PasteToDos(): source: ",
                    LTOOLSnet.CopyFilePath[j],
                    " - destination: ",
                    text
                }));
                if (LTOOLSnet.CopyFileIsLinux)
                {
                    text3 = "ucom";
                    array = targetDirectory.Split(new char[]
                    {
                        '\\'
                    });
                    text4 = "";
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (array[k].Length > 0)
                        {
                            text4 = text4 + UMD5.ConvertStringToHex(array[k].ToString(), Encoding.Unicode) + "\\";
                        }
                    }
                    if (LTOOLSnet.Connected)
                    {
                        goto IL_B3A;
                    }
                    string text5 = this.method_6(LTOOLSnet.CopyFilePath[j].ToString(), LTOOLSnet.CopyFileName[j].ToString());
                    text5 += UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                    text7 = DirFilePanel.tempPathLinuxFiles + "\\" + text4 + UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                    string text6 = LTOOLSnet.CopyFileSize[j].ToString();
                    text6 = text6.Replace(",", "");
                    text6 = text6.Replace(".", "");
                    text6 = text6.Replace(" ", "");
                    usbpublic.FILE_SIZE = Convert.ToInt64(text6);
                    if (!Directory.Exists(DirFilePanel.tempPathLinuxFiles + "\\" + text4))
                    {
                        Directory.CreateDirectory(DirFilePanel.tempPathLinuxFiles + "\\" + text4);
                    }
                    string text8;
                    ULDir uldir;
                    if (Convert.ToInt64(text6) > 104857600L)
                    {
                        text8 = string.Concat(new string[]
                        {
                            "-READ -q -s",
                            this.method_4(LTOOLSnet.CopyFilePath[j].ToString()),
                            " \"",
                            text5,
                            "\" \"",
                            text7,
                            "\""
                        });
                        this.method_18(text3 + " " + text8);
                        uldir = new ULDir(text3, text8);
                        File.Move(text7, text);
                        try
                        {
                            if (File.Exists(text7))
                            {
                                File.Delete(text7);
                            }
                            goto IL_BBE;
                        }
                        catch
                        {
                            goto IL_BBE;
                        }
                    }
                    text8 = string.Concat(new string[]
                    {
                        "-READ -q -s",
                        this.method_4(LTOOLSnet.CopyFilePath[j].ToString()),
                        " \"",
                        text5,
                        "\" \"",
                        text7,
                        "\""
                    });
                    this.method_18(text3 + " " + text8);
                    uldir = new ULDir(text3, text8);
                    if (LTOOLSnet.IsEncryptFile)
                    {
                        string key_FORMAT = usbpublic.KEY_FORMAT;
                        UMD5.DecryptFile(text7, text, key_FORMAT, false);
                        try
                        {
                            if (File.Exists(text7))
                            {
                                File.Delete(text7);
                            }
                            goto IL_BBE;
                        }
                        catch
                        {
                            goto IL_BBE;
                        }
                        goto IL_B3A;
                    }
                IL_BBE:
                    if (uldir.Response.Length <= 0)
                    {
                        if (!LTOOLSnet.CutSelected)
                        {
                        }
                        if (LTOOLSnet.Connected)
                        {
                            this.method_18("GetFileFromHost(\"" + text + "\")");
                            this.method_16((string)LTOOLSnet.CopyFileName[j]);
                            File.Move(DirFilePanel.tempPathLinuxFiles + Path.DirectorySeparatorChar.ToString() + LTOOLSnet.CopyFileName[j], text);
                        }
                        goto IL_CEC;
                    }
                    else
                    {
                        if (issueMessages)
                        {
                            MessageBox.Show("Copy file Error.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        return;
                    }
                IL_B3A:
                    text8 = string.Concat(new string[]
                    {
                        "-READ -x -s",
                        this.method_4(LTOOLSnet.CopyFilePath[j].ToString()),
                        " \"",
                        this.method_5(LTOOLSnet.CopyFilePath[j].ToString()),
                        "\" zzz.xxx"
                    });
                    this.method_18(text3 + " " + text8);
                    uldir = new ULDir(text3, text8, LTOOLSnet.NetSocket);
                    goto IL_BBE;
                }
                try
                {
                    File.Copy(LTOOLSnet.CopyFilePath[j].ToString(), text, true);
                }
                catch (FileNotFoundException ex)
                {
                    this.method_18(ex.Message);
                    if (issueMessages)
                    {
                        MessageBox.Show("Không mở được file " + LTOOLSnet.CopyFilePath[j], "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    LTOOLSnet.ShowProgessBar(false);
                    return;
                }
                catch (IOException ex2)
                {
                    this.method_18(ex2.Message);
                    if (issueMessages)
                    {
                        MessageBox.Show("Không ghi được file " + text + ".\n" + ex2.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    LTOOLSnet.ShowProgessBar(false);
                    return;
                }
                goto IL_CEC;
            }
            LTOOLSnet.ShowProgessBar(false);
            DirectoryNode selectedDirectoryNode = this.GetSelectedDirectoryNode();
            this.UpdateNode(selectedDirectoryNode);
        }

        // Token: 0x06000075 RID: 117 RVA: 0x000096D8 File Offset: 0x000078D8
        public void UpdateDosListView(DirectoryNode dirNode)
        {
            try
            {
                string text = this.method_12(dirNode);
                DirectoryInfo directoryInfo = new DirectoryInfo(text);
                DirectoryInfo[] directories = directoryInfo.GetDirectories();
                FileInfo[] files = directoryInfo.GetFiles(LTOOLSnet.DOSFilePattern);
                ArrayList arrayList = new ArrayList();
                ArrayList arrayList2 = new ArrayList();
                this.listView.Clear();
                this.listView.View = this.view_0;
                this.method_14();
                for (int i = 0; i < directories.Length; i++)
                {
                    string name = directories[i].Name;
                    if (!text.EndsWith(Path.DirectorySeparatorChar.ToString()))
                    {
                        text += Path.DirectorySeparatorChar.ToString();
                    }
                    string text2 = text + name;
                    ListViewItemFile listViewItemFile = new ListViewItemFile(name, DirFilePanel.IndexIconFolder, true, text, "0", Directory.GetLastWriteTime(text2).ToString(), " ");
                    if ((directories[i].Attributes & FileAttributes.ReadOnly) != (FileAttributes)0)
                    {
                        listViewItemFile.IsReadOnly = true;
                    }
                    else
                    {
                        listViewItemFile.IsReadOnly = false;
                    }
                    listViewItemFile.SubItems.Add("");
                    listViewItemFile.SubItems.Add("");
                    listViewItemFile.SubItems.Add(listViewItemFile.FileLastModified);
                    arrayList.Add(listViewItemFile);
                }
                for (int i = 0; i < files.Length; i++)
                {
                    string name = files[i].Name;
                    string text2;
                    if (text.EndsWith(Path.DirectorySeparatorChar.ToString()))
                    {
                        text2 = text + name;
                    }
                    else
                    {
                        text2 = text + Path.DirectorySeparatorChar.ToString() + name;
                    }
                    FileInfo fileInfo = new FileInfo(text2);
                    FileAttributes attributes = fileInfo.Attributes;
                    ListViewItemFile listViewItemFile = new ListViewItemFile(name, DirFilePanel.IndexIconFile, false, text, fileInfo.Length.ToString(), fileInfo.LastWriteTime.ToString(), " ");
                    listViewItemFile.FullFilePath = text2;
                    if ((attributes & FileAttributes.ReadOnly) != (FileAttributes)0)
                    {
                        listViewItemFile.IsReadOnly = true;
                    }
                    else
                    {
                        listViewItemFile.IsReadOnly = false;
                    }
                    string text3;
                    if (Convert.ToInt64(listViewItemFile.FileSize) > 2147483647L)
                    {
                        text3 = string.Format("{0:0,0}", Convert.ToInt64(listViewItemFile.FileSize));
                    }
                    else
                    {
                        text3 = string.Format("{0:0,0}", Convert.ToInt32(listViewItemFile.FileSize));
                    }
                    listViewItemFile.SubItems.Add(text3);
                    listViewItemFile.SubItems.Add(Path.GetExtension(listViewItemFile.FullFilePath));
                    listViewItemFile.SubItems.Add(listViewItemFile.FileLastModified);
                    arrayList2.Add(listViewItemFile);
                }
                this.method_15(text, arrayList, arrayList2);
            }
            catch (Exception ex)
            {
                this.method_18(string.Concat(new object[]
                {
                    MyDebug.SeparatorLine,
                    "UpdateDosListView() Exception - isLinux: ",
                    this.bool_0,
                    "\r\n",
                    ex.Message,
                    MyDebug.SeparatorLine
                }));
                this.listView.Clear();
                this.listView.View = View.Details;
                this.listView.Columns.Add("Error", this.listView.Size.Width - 50, HorizontalAlignment.Left);
                ListViewItemFile listViewItemFile = new ListViewItemFile(ex.Message.Replace("\r\n", " "), DirFilePanel.IndexIconError, false);
                listViewItemFile.IsError = true;
                this.listView.Items.Add(listViewItemFile);
            }
        }

        // Token: 0x06000076 RID: 118 RVA: 0x00009AA4 File Offset: 0x00007CA4
        public void FillLinuxDirectoryTree()
        {
            string b = DISK.ReadABCFromUSB();
            if (!(LTOOLSnet.MAINMK != b))
            {
                try
                {
                    this.treeView.Nodes.Clear();
                    this.listView.Items.Clear();
                    this.labelDirectory.Text = "         USB-AT";
                    this.labelDirectory.ForeColor = Color.White;
                    this.listView.BackColor = Color.FromArgb(192, 255, 255);
                    this.lblCopy.Visible = false;
                    this.lblUSB.Visible = false;
                    this.picUSB.Visible = true;
                    this.IsLinux = true;
                    ArrayList arrayList = this.method_3();
                    this.method_18("FillUSBDirectoryTree()");
                    this.treeView.Width = 2;
                    this.splitter.Enabled = false;
                    this.treeView.BeginUpdate();
                    LTOOLSnet.HDB_No = arrayList[0].ToString().Substring(0, arrayList[0].ToString().IndexOf(" "));
                    for (int i = 0; i < arrayList.Count; i++)
                    {
                        this.method_18("drive[]" + arrayList[i].ToString());
                        DirectoryNode directoryNode = new DirectoryNode(arrayList[i].ToString());
                        directoryNode.ImageIndex = 0;
                        directoryNode.SelectedImageIndex = 0;
                        this.treeView.Nodes.Add(directoryNode);
                        try
                        {
                            if (!this.method_7(directoryNode, false))
                            {
                                this.method_18("FillUSBDirectoryTree(): Removed a USB drive " + directoryNode + "\n");
                                this.treeView.Nodes.Remove(directoryNode);
                            }
                        }
                        catch (Exception ex)
                        {
                            this.method_18("AddUSBDirectories-Exception in FillUSBDirectoryTree: " + ex.Message + ex.StackTrace);
                        }
                    }
                    this.treeView.EndUpdate();
                    try
                    {
                        if (this.treeView.Nodes.Count > 0)
                        {
                            this.treeView.SelectedNode = this.treeView.Nodes[0];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.listView.Items.Clear();
                }
            }
        }

        // Token: 0x06000077 RID: 119 RVA: 0x00009D44 File Offset: 0x00007F44
        private ArrayList method_3()
        {
            int num = 0;
            this.method_18("GetUSBDrives()");
            ArrayList arrayList = new ArrayList();
            try
            {
                ULDir uldir;
                if (LTOOLSnet.Connected)
                {
                    uldir = new ULDir("ucom", "-x -part", LTOOLSnet.NetSocket);
                }
                else
                {
                    uldir = new ULDir("ucom", "-part");
                }
                string partitions = uldir.GetPartitions();
                Class1 @class = new Class1(partitions, "\n\r");
                while (@class.method_3())
                {
                    string string_ = @class.method_4();
                    if (this.method_9(string_, 3).ToLower().Equals("d5") && !this.method_9(string_, 4).ToLower().Equals("swap"))
                    {
                        num++;
                        arrayList.Add(string.Concat(new object[]
                        {
                            this.method_9(string_, 0),
                            this.method_9(string_, 1),
                            " ",
                            DirFilePanel.char_0
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                arrayList = null;
            }
            int i = 0;
        IL_1D0:
            while (i < arrayList.Count)
            {
                string text = string.Concat(arrayList[i]).Substring(6, 5);
                for (int j = i + 1; j < arrayList.Count; j++)
                {
                    string text2 = string.Concat(arrayList[j]).Substring(6, 5);
                    if (text.Equals(text2))
                    {
                        this.method_18(string.Concat(new object[]
                        {
                            "Duplicate partition removed: i=",
                            i,
                            "---",
                            text,
                            "---   j=",
                            j,
                            "---",
                            text2,
                            "---   "
                        }));
                        arrayList.RemoveAt(i);
                    IL_1CA:
                        i++;
                        goto IL_1D0;
                    }
                }
                goto IL_1CA;
            }
            return arrayList;
        }

        // Token: 0x06000078 RID: 120 RVA: 0x00009F48 File Offset: 0x00008148
        private string method_4(string string_0)
        {
            return string_0.Substring(0, string_0.IndexOf(" "));
        }

        // Token: 0x06000079 RID: 121 RVA: 0x00009F6C File Offset: 0x0000816C
        private string method_5(string string_0)
        {
            return string_0.Substring(string_0.IndexOf(" ") + 1);
        }

        // Token: 0x0600007A RID: 122 RVA: 0x00009F90 File Offset: 0x00008190
        private string method_6(string string_0, string string_1)
        {
            string_0 = string_0.Substring(string_0.IndexOf(" ") + 1);
            return string_0.Substring(0, string_0.Length - string_1.Length);
        }

        // Token: 0x0600007B RID: 123 RVA: 0x00009FC8 File Offset: 0x000081C8
        private bool method_7(DirectoryNode directoryNode_2, bool bool_1)
        {
            try
            {
                string text = string.Concat(new string[]
                {
                    "-s",
                    this.method_4(this.method_12(directoryNode_2)),
                    " \"",
                    this.method_5(this.method_12(directoryNode_2)),
                    "\""
                });
                this.method_18("AddUSBDirectories() - Process arguments: \"ldir " + text + "\"");
                ULDir uldir;
                if (LTOOLSnet.Connected)
                {
                    uldir = new ULDir("ucom", "-x " + text, LTOOLSnet.NetSocket);
                }
                else
                {
                    uldir = new ULDir("ucom", text);
                }
                this.method_18("<<<<< AddUSBDirectories():\n" + uldir.Response + "\n>>>>>>>>>>>>>>>>>>>\n");
                if (!uldir.Response.StartsWith("d") || !uldir.Response.Substring(56, 1).Equals("."))
                {
                    if (bool_1)
                    {
                        MessageBox.Show(uldir.Response, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    return false;
                }
                Class1 @class = new Class1(uldir.Response, "\n\r");
                while (@class.method_3())
                {
                    string text2 = @class.method_4();
                    if (text2.Length > 56 && this.method_9(text2, 0)[0].ToString().Equals("d"))
                    {
                        string text3 = this.method_9(text2, 9);
                        if (!text3.Equals(".") && !text3.Equals("..") && !text3.Equals("lost+found"))
                        {
                            text3 = UMD5.ConvertHexToString(text3, Encoding.Unicode);
                            DirectoryNode directoryNode = new DirectoryNode(text3);
                            directoryNode.ImageIndex = 7;
                            directoryNode.SelectedImageIndex = 8;
                            directoryNode_2.Nodes.Add(directoryNode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.method_18(string.Concat(new string[]
                {
                    MyDebug.SeparatorLine,
                    ex.Message,
                    "\r\n",
                    ex.StackTrace,
                    MyDebug.SeparatorLine
                }));
            }
            return true;
        }

        // Token: 0x0600007C RID: 124 RVA: 0x0000A210 File Offset: 0x00008410
        private void method_8(DirectoryNode directoryNode_2)
        {
            this.method_18("AddUSBSubDirectories()");
            try
            {
                for (int i = 0; i < directoryNode_2.Nodes.Count; i++)
                {
                    this.method_7((DirectoryNode)directoryNode_2.Nodes[i], true);
                }
                directoryNode_2.SubDirectoriesAdded = true;
            }
            catch
            {
                this.method_18("AddUSBSubDirectories-Exception");
            }
        }

        // Token: 0x0600007D RID: 125 RVA: 0x0000A280 File Offset: 0x00008480
        public void NewLinuxDirectory(DirectoryNode node)
        {
            this.method_18("NewUSBDirectory" + node.Path);
            if (LTOOLSnet.IsLinuxReadOnly)
            {
                MessageBox.Show("Hệ thống đã kích hoạt tính năng chống ghi USB.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                ModifyLinuxDialog modifyLinuxDialog = new ModifyLinuxDialog(true, "", "", "", "          0", "          0", "-rwxr-xr-x");
                modifyLinuxDialog.Text = "Tạo thư mục";
                DialogResult dialogResult = modifyLinuxDialog.ShowDialog();
                if (dialogResult == DialogResult.OK && !modifyLinuxDialog.FileName.Equals(""))
                {
                    string text = "ucom";
                    string text2 = "-WRITE ";
                    if (modifyLinuxDialog.IsLink)
                    {
                        text2 += "-link ";
                    }
                    else
                    {
                        text2 += "-mkdir ";
                    }
                    if (LTOOLSnet.Connected)
                    {
                        text2 += "-x ";
                    }
                    else
                    {
                        text2 += "-q ";
                    }
                    text2 = string.Concat(new string[]
                    {
                        text2,
                        "-s",
                        this.method_0(),
                        " -f",
                        modifyLinuxDialog.Access,
                        " -g",
                        modifyLinuxDialog.GID.Trim(),
                        " -u",
                        modifyLinuxDialog.UID.Trim(),
                        " "
                    });
                    if (modifyLinuxDialog.IsLink)
                    {
                        text2 = text2 + "\"" + modifyLinuxDialog.TargetName + "\" ";
                    }
                    else
                    {
                        text2 += "ldirtmpl ";
                    }
                    string text3 = this.method_5(node.Path);
                    if (!text3.EndsWith(DirFilePanel.char_0.ToString()))
                    {
                        text3 += DirFilePanel.char_0;
                    }
                    string text4 = modifyLinuxDialog.FileName;
                    text4 = UMD5.ConvertStringToHex(text4, Encoding.Unicode);
                    text2 = string.Concat(new string[]
                    {
                        text2,
                        "\"",
                        text3,
                        text4,
                        "\""
                    });
                    this.method_18(text + " " + text2);
                    ULDir uldir;
                    if (LTOOLSnet.Connected)
                    {
                        uldir = new ULDir(text, text2, LTOOLSnet.NetSocket);
                    }
                    else
                    {
                        uldir = new ULDir(text, text2);
                    }
                    this.method_18("NewUSBDirectory:" + uldir.Response + "<<<\n");
                    if (uldir.Response.Length > 0)
                    {
                        if (uldir.Response.IndexOf("exists") > 0)
                        {
                            MessageBox.Show("Thư mục đã tồn tại.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi tạo thư mục.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        this.UpdateNode(node);
                    }
                }
            }
        }

        // Token: 0x0600007E RID: 126 RVA: 0x0000A548 File Offset: 0x00008748
        public ArrayList GetLinuxFiles(string linuxDir)
        {
            this.method_18("GetLinuxFiles()");
            ArrayList arrayList = new ArrayList();
            string text = string.Concat(new string[]
            {
                "-s",
                this.method_4(linuxDir),
                " \"",
                this.method_5(linuxDir),
                "\""
            });
            this.method_18("UpdateListView() - Process arguments: \"ldir " + text + "\"");
            ULDir uldir;
            if (LTOOLSnet.Connected)
            {
                uldir = new ULDir("ucom", "-x " + text, LTOOLSnet.NetSocket);
            }
            else
            {
                uldir = new ULDir("ucom", text);
            }
            Class1 @class = new Class1(uldir.Response, "\n\r");
            while (@class.method_3())
            {
                string text2 = @class.method_4();
                if (text2.Length < 56)
                {
                    StringBuilder stringBuilder = new StringBuilder(text2);
                    while (@class.method_3())
                    {
                        stringBuilder.Append(@class.method_4());
                    }
                    this.method_18("StartColumnUSBFilename > token.length: " + stringBuilder.ToString());
                    return arrayList;
                }
                string text3 = this.method_9(text2, 9);
                if (!this.method_9(text2, 0)[0].ToString().Equals("d") && LTOOLSnet.LinuxFilePattern.Equals("*"))
                {
                    string text4 = this.method_9(text2, 3);
                    try
                    {
                        if (Convert.ToInt64(text4) > 2147483647L)
                        {
                            text4 = string.Format("{0:0,0}", Convert.ToInt64(text4));
                        }
                        else
                        {
                            text4 = string.Format("{0:0,0}", Convert.ToInt32(text4));
                        }
                        string text5 = string.Concat(new string[]
                        {
                            this.method_9(text2, 4),
                            " ",
                            this.method_9(text2, 5),
                            " ",
                            this.method_9(text2, 6),
                            " ",
                            this.method_9(text2, 7),
                            " ",
                            this.method_9(text2, 8)
                        });
                        DateTime dateTime;
                        DateTime.TryParseExact(text5, "ddd MMM dd HH:mm:ss yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
                        dateTime = dateTime.AddHours(7.0);
                        text5 = dateTime.ToString("MM/dd/yyyy HH:mm:ss");
                        ListViewItemFile listViewItemFile = new ListViewItemFile(text3, DirFilePanel.IndexIconFile, false, linuxDir, text4, text5, text2);
                        listViewItemFile.SubItems.Add(listViewItemFile.FileSize);
                        listViewItemFile.SubItems.Add(this.method_11(listViewItemFile.FullFilePath));
                        listViewItemFile.SubItems.Add(listViewItemFile.FileLastModified);
                        listViewItemFile.SubItems.Add(this.method_9(listViewItemFile.LinuxFileInfoString, 0));
                        listViewItemFile.SubItems.Add(this.method_9(listViewItemFile.LinuxFileInfoString, 1));
                        listViewItemFile.SubItems.Add(this.method_9(listViewItemFile.LinuxFileInfoString, 2));
                        arrayList.Add(listViewItemFile);
                    }
                    catch
                    {
                    }
                }
            }
            if (LTOOLSnet.LinuxFilePattern.Equals("*"))
            {
            }
            return arrayList;
        }

        // Token: 0x0600007F RID: 127 RVA: 0x0000A898 File Offset: 0x00008A98
        public ArrayList GetLinuxSubDirs(string linuxDir)
        {
            this.method_18("GetLinuxFiles()");
            string text = linuxDir;
            ArrayList arrayList = new ArrayList();
            if (!text.EndsWith(DirFilePanel.char_0.ToString()))
            {
                text += DirFilePanel.char_0;
            }
            string text2 = string.Concat(new string[]
            {
                "-s",
                this.method_4(text),
                " \"",
                this.method_5(text),
                "\""
            });
            this.method_18("UpdateListView() - Process arguments: \"ldir " + text2 + "\"");
            ULDir uldir;
            if (LTOOLSnet.Connected)
            {
                uldir = new ULDir("ucom", "-x " + text2, LTOOLSnet.NetSocket);
            }
            else
            {
                uldir = new ULDir("ucom", text2);
            }
            Class1 @class = new Class1(uldir.Response, "\n\r");
            while (@class.method_3())
            {
                string text3 = @class.method_4();
                if (text3.Length < 56)
                {
                    StringBuilder stringBuilder = new StringBuilder(text3);
                    while (@class.method_3())
                    {
                        stringBuilder.Append(@class.method_4());
                    }
                    this.method_18("StartColumnUSBFilename > token.length: " + stringBuilder.ToString());
                    return arrayList;
                }
                string text4 = this.method_9(text3, 9);
                if (this.method_9(text3, 0)[0].ToString().Equals("d") && !text4.Equals(".") && !text4.Equals("..") && !text4.Equals("lost+found"))
                {
                    arrayList.Add(text4);
                }
            }
            return arrayList;
        }

        // Token: 0x06000080 RID: 128 RVA: 0x0000AA54 File Offset: 0x00008C54
        public ArrayList GetFilesLinuxTree(string root)
        {
            ArrayList arrayList = new ArrayList();
            Stack<string> stack = new Stack<string>(20);
            stack.Push(root);
            while (stack.Count > 0)
            {
                string text = stack.Pop();
                ArrayList arrayList2 = new ArrayList();
                try
                {
                    arrayList2 = this.GetLinuxSubDirs(text);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (DirectoryNotFoundException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    continue;
                }
                ArrayList arrayList3 = new ArrayList();
                try
                {
                    arrayList3 = this.GetLinuxFiles(text);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (DirectoryNotFoundException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    continue;
                }
                foreach (object obj in arrayList3)
                {
                    ListViewItemFile value = (ListViewItemFile)obj;
                    try
                    {
                        arrayList.Add(value);
                    }
                    catch (FileNotFoundException ex3)
                    {
                        Console.WriteLine(ex3.Message);
                    }
                }
                foreach (object obj2 in arrayList2)
                {
                    string arg = (string)obj2;
                    stack.Push(text + arg + DirFilePanel.char_0);
                }
            }
            return arrayList;
        }

        // Token: 0x06000081 RID: 129 RVA: 0x0000AC08 File Offset: 0x00008E08
        public ArrayList GetDirsLinuxTree(string root)
        {
            ArrayList arrayList = new ArrayList();
            Stack<string> stack = new Stack<string>(20);
            stack.Push(root);
            while (stack.Count > 0)
            {
                string text = stack.Pop();
                ArrayList arrayList2 = new ArrayList();
                try
                {
                    arrayList2 = this.GetLinuxSubDirs(text);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (DirectoryNotFoundException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    continue;
                }
                foreach (object obj in arrayList2)
                {
                    string str = (string)obj;
                    myDir myDir = new myDir();
                    try
                    {
                        myDir.Name = text + str;
                        string text2 = this.method_5(text + str);
                        string[] array = text2.Split(new char[]
                        {
                            '/'
                        });
                        myDir.ID = array.Length - 1;
                        arrayList.Add(myDir);
                    }
                    catch (FileNotFoundException ex3)
                    {
                        Console.WriteLine(ex3.Message);
                    }
                }
                foreach (object obj2 in arrayList2)
                {
                    string arg = (string)obj2;
                    stack.Push(text + arg + DirFilePanel.char_0);
                }
            }
            return arrayList;
        }

        // Token: 0x06000082 RID: 130 RVA: 0x0000ADB4 File Offset: 0x00008FB4
        public ArrayList SearchLinuxFileInDir(string root, string sFind)
        {
            ArrayList arrayList = new ArrayList();
            Stack<string> stack = new Stack<string>(20);
            ArrayList result;
            if (sFind.Length <= 0)
            {
                result = null;
            }
            else
            {
                stack.Push(root);
                while (stack.Count > 0)
                {
                    string text = stack.Pop();
                    ArrayList arrayList2 = new ArrayList();
                    try
                    {
                        arrayList2 = this.GetLinuxSubDirs(text);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    catch (DirectoryNotFoundException ex2)
                    {
                        Console.WriteLine(ex2.Message);
                        continue;
                    }
                    ArrayList arrayList3 = new ArrayList();
                    try
                    {
                        arrayList3 = this.GetLinuxFiles(text);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    catch (DirectoryNotFoundException ex2)
                    {
                        Console.WriteLine(ex2.Message);
                        continue;
                    }
                    foreach (object obj in arrayList3)
                    {
                        ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                        try
                        {
                            string text2 = UMD5.ConvertHexToString(listViewItemFile.FileName, Encoding.Unicode);
                            listViewItemFile.FileName = text2;
                            string str = "";
                            string[] array = this.method_5(listViewItemFile.FullFilePath).Split(new char[]
                            {
                                '/'
                            });
                            for (int i = 0; i < array.Length - 1; i++)
                            {
                                if (array[i].Length > 0)
                                {
                                    str = str + UMD5.ConvertHexToString(array[i].ToString(), Encoding.Unicode) + "\\";
                                }
                            }
                            listViewItemFile.Text = str + text2;
                            listViewItemFile.FullFilePath = listViewItemFile.Directory + text2;
                            if (this.StringContains(listViewItemFile.FileName, sFind, StringComparison.OrdinalIgnoreCase))
                            {
                                arrayList.Add(listViewItemFile);
                            }
                        }
                        catch (FileNotFoundException ex3)
                        {
                            Console.WriteLine(ex3.Message);
                        }
                    }
                    foreach (object obj2 in arrayList2)
                    {
                        string arg = (string)obj2;
                        stack.Push(text + arg + DirFilePanel.char_0);
                    }
                }
                result = arrayList;
            }
            return result;
        }

        // Token: 0x06000083 RID: 131 RVA: 0x000023AF File Offset: 0x000005AF
        public bool StringContains(string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }

        // Token: 0x06000084 RID: 132 RVA: 0x0000B0A0 File Offset: 0x000092A0
        public long GetLinuxDirSize(string root)
        {
            long num = 0L;
            new ArrayList();
            Stack<string> stack = new Stack<string>(20);
            stack.Push(root);
            while (stack.Count > 0)
            {
                string text = stack.Pop();
                ArrayList arrayList = new ArrayList();
                try
                {
                    arrayList = this.GetLinuxSubDirs(text);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (DirectoryNotFoundException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    continue;
                }
                ArrayList arrayList2 = new ArrayList();
                try
                {
                    arrayList2 = this.GetLinuxFiles(text);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (DirectoryNotFoundException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    continue;
                }
                foreach (object obj in arrayList2)
                {
                    ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                    try
                    {
                        string text2 = listViewItemFile.FileSize.ToString();
                        text2 = text2.Replace(",", "");
                        text2 = text2.Replace(".", "");
                        text2 = text2.Replace(" ", "");
                        long num2 = Convert.ToInt64(text2);
                        num += num2;
                    }
                    catch (FileNotFoundException ex3)
                    {
                        Console.WriteLine(ex3.Message);
                    }
                }
                foreach (object obj2 in arrayList)
                {
                    string arg = (string)obj2;
                    stack.Push(text + arg + DirFilePanel.char_0);
                }
            }
            return num;
        }

        // Token: 0x06000085 RID: 133 RVA: 0x0000B2AC File Offset: 0x000094AC
        public void CreateNewLinuxDirectory(string dirPath, string dirName)
        {
            this.method_18("NewUSBDirectory" + dirPath);
            if (LTOOLSnet.IsLinuxReadOnly)
            {
                MessageBox.Show("Hệ thống đã kích hoạt tính năng chống ghi USB.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (!dirName.Equals(""))
            {
                if (!dirPath.EndsWith(DirFilePanel.char_0.ToString()))
                {
                    dirPath += DirFilePanel.char_0;
                }
                if (this.SearchLinuxFile(this.method_0() + " " + dirPath, dirName))
                {
                    MessageBox.Show("Thư mục đã tồn tại. Bạn có ghi đè nội dung thư mục không?", "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string text = "ucom";
                    string text2 = "-WRITE ";
                    text2 += "-mkdir ";
                    if (LTOOLSnet.Connected)
                    {
                        text2 += "-x ";
                    }
                    else
                    {
                        text2 += "-q ";
                    }
                    text2 = text2 + "-s" + this.method_0() + " -f777 -g0 -u0 ";
                    text2 += "ldirtmpl ";
                    if (!dirPath.EndsWith(DirFilePanel.char_0.ToString()))
                    {
                        dirPath += DirFilePanel.char_0;
                    }
                    string text3 = UMD5.ConvertStringToHex(dirName, Encoding.Unicode);
                    text2 = string.Concat(new string[]
                    {
                        text2,
                        "\"",
                        dirPath,
                        text3,
                        "\""
                    });
                    this.method_18(text + " " + text2);
                    ULDir uldir;
                    if (LTOOLSnet.Connected)
                    {
                        uldir = new ULDir(text, text2, LTOOLSnet.NetSocket);
                    }
                    else
                    {
                        uldir = new ULDir(text, text2);
                    }
                    this.method_18("NewUSBDirectory:" + uldir.Response + "<<<\n");
                    if (uldir.Response.Length > 0)
                    {
                        if (uldir.Response.IndexOf("exists") > 0)
                        {
                            MessageBox.Show("Thư mục đã tồn tại.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi tạo thư mục.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        DirectoryNode selectedDirectoryNode = this.GetSelectedDirectoryNode();
                        this.UpdateNode(selectedDirectoryNode);
                    }
                }
            }
        }

        // Token: 0x06000086 RID: 134 RVA: 0x0000B4D4 File Offset: 0x000096D4
        public void DeleteLinuxFile(ListView.SelectedListViewItemCollection items, bool confirmDelete)
        {
            this.method_18("DeleteUSBFile()");
            bool flag = false;
            bool flag2 = false;
            DirectoryNode directoryNode = null;
            if (LTOOLSnet.IsLinuxReadOnly)
            {
                this.method_18("USBIsReadOnly");
                MessageBox.Show("Hệ thống đã kích hoạt tính năng chống ghi USB.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (items.Count > 0)
            {
                flag2 = false;
                if (confirmDelete)
                {
                    string text = "Bạn có chắc chắn xóa file/thư mục đã chọn không?";
                    DialogResult dialogResult = MessageBox.Show(text, "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dialogResult != DialogResult.Yes)
                    {
                        return;
                    }
                    flag2 = true;
                }
                int i = 0;
                while (i <= 2000)
                {
                    i++;
                    LTOOLSnet.ShowProgessBar(true);
                    Application.DoEvents();
                }
                foreach (object obj in items)
                {
                    ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                    if (!listViewItemFile.IsError && !listViewItemFile.FileName.Equals(".."))
                    {
                        string fullFilePath = listViewItemFile.FullFilePath;
                        this.method_18("DeleteUSBFile(): " + fullFilePath + " - " + flag2.ToString());
                        if (flag2)
                        {
                            flag = true;
                            string text2 = "ucom";
                            string text3;
                            if (listViewItemFile.IsLink)
                            {
                                text3 = this.method_5(this.method_10(fullFilePath));
                            }
                            else if (listViewItemFile.IsDirectory)
                            {
                                string str = listViewItemFile.Directory + UMD5.ConvertStringToHex(listViewItemFile.FileName, Encoding.Unicode);
                                ArrayList filesLinuxTree = this.GetFilesLinuxTree(str + "/");
                                foreach (object obj2 in filesLinuxTree)
                                {
                                    ListViewItemFile listViewItemFile2 = (ListViewItemFile)obj2;
                                    string text4 = this.method_5(listViewItemFile2.FullFilePath);
                                    string text5 = string.Concat(new string[]
                                    {
                                        "-WRITE -del -q -s",
                                        this.method_4(listViewItemFile2.FullFilePath),
                                        " \"",
                                        text4,
                                        "\""
                                    });
                                    this.method_18(text2 + " " + text5);
                                    new ULDir(text2, text5);
                                }
                                ArrayList arrayList = new ArrayList();
                                arrayList = this.GetDirsLinuxTree(str + "/");
                                arrayList.Sort(new ObjCompare
                                {
                                    ComparisonMethod = ObjCompare.ComparisonType.ID
                                });
                                foreach (object obj3 in arrayList)
                                {
                                    myDir myDir = (myDir)obj3;
                                    string text4 = this.method_5(myDir.Name);
                                    string text5 = string.Concat(new string[]
                                    {
                                        "-WRITE -del -q -s",
                                        this.method_4(myDir.Name),
                                        " \"",
                                        text4,
                                        "\""
                                    });
                                    this.method_18(text2 + " " + text5);
                                    new ULDir(text2, text5);
                                }
                                text3 = this.method_5(fullFilePath);
                                directoryNode = (DirectoryNode)this.GetSelectedDirectoryNode().Parent;
                            }
                            else
                            {
                                text3 = this.method_5(fullFilePath);
                                directoryNode = this.GetSelectedDirectoryNode();
                            }
                            ULDir uldir;
                            if (LTOOLSnet.Connected)
                            {
                                string text6 = string.Concat(new string[]
                                {
                                    "-WRITE -del -q -s",
                                    this.method_4(fullFilePath),
                                    " \"",
                                    text3,
                                    "\""
                                });
                                this.method_18(text2 + " " + text6);
                                uldir = new ULDir(text2, text6, LTOOLSnet.NetSocket);
                            }
                            else
                            {
                                text3 = this.method_5(listViewItemFile.Directory + UMD5.ConvertStringToHex(listViewItemFile.FileName, Encoding.Unicode));
                                string text6 = string.Concat(new string[]
                                {
                                    "-WRITE -del -q -s",
                                    this.method_4(fullFilePath),
                                    " \"",
                                    text3,
                                    "\""
                                });
                                this.method_18(text2 + " " + text6);
                                uldir = new ULDir(text2, text6);
                            }
                            this.method_18("DeleteUSBFile 1>>>" + uldir.Response + "<<<");
                            if (uldir.Response.Length > 0)
                            {
                                MessageBox.Show("Delete file error.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                LTOOLSnet.ShowProgessBar(false);
                                this.FillLinuxDirectoryTree();
                                return;
                            }
                        }
                    }
                }
                LTOOLSnet.ShowProgessBar(false);
                if (flag)
                {
                    if (directoryNode == null)
                    {
                        this.FillLinuxDirectoryTree();
                    }
                    else
                    {
                        this.UpdateNode(directoryNode);
                    }
                }
            }
        }

        // Token: 0x06000087 RID: 135 RVA: 0x0000B9FC File Offset: 0x00009BFC
        public void StartLinuxApplication(ListViewItemFile item, bool start)
        {
            if (!Directory.Exists(DirFilePanel.tempPathLinuxFiles))
            {
                this.method_18("Create Directory " + DirFilePanel.tempPathLinuxFiles);
                Directory.CreateDirectory(DirFilePanel.tempPathLinuxFiles);
            }
            this.method_18(string.Concat(new object[]
            {
                "StartLinuxApplication- isLinux: ",
                this.bool_0,
                ". Process.Start(\"",
                item.FullFilePath,
                "\")"
            }));
            if (!item.IsDirectory)
            {
                string text = item.FileSize.ToString();
                text = text.Replace(",", "");
                text = text.Replace(".", "");
                text = text.Replace(" ", "");
                if (Convert.ToInt64(text) > 10485760L)
                {
                    MessageBox.Show("Không View/Edit file có kích thước quá 10MB.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string text3;
                    string text4;
                    if (item.LinuxFileInfoString[0].ToString().Equals("l"))
                    {
                        int startIndex = item.FileName.IndexOf("->", 0) + 3;
                        string text2 = item.FileName.Substring(startIndex);
                        if (text2.StartsWith(DirFilePanel.char_0.ToString()))
                        {
                            text3 = text2.Substring(text2.LastIndexOf(DirFilePanel.char_0.ToString()) + 1);
                            text4 = text2;
                        }
                        else
                        {
                            text3 = text2;
                            text4 = this.method_5(item.Directory) + text2;
                        }
                    }
                    else
                    {
                        text3 = item.FileName;
                        text4 = this.method_5(item.FullFilePath);
                    }
                    string command = "ucom";
                    StringBuilder stringBuilder = new StringBuilder();
                    string text5 = this.method_5(item.Directory + UMD5.ConvertStringToHex(item.FileName, Encoding.Unicode));
                    string text6 = DirFilePanel.tempPathLinuxFiles + Path.DirectorySeparatorChar.ToString() + UMD5.AddStringToCryptFile(UMD5.ConvertStringToHex(item.FileName, Encoding.Unicode));
                    string text7 = DirFilePanel.tempPathLinuxFiles + Path.DirectorySeparatorChar.ToString() + text3;
                    if (LTOOLSnet.Connected)
                    {
                        stringBuilder.Append(string.Concat(new string[]
                        {
                            "-READ -x -s",
                            this.method_4(item.FullFilePath),
                            " \"",
                            text4,
                            "\" zzz.xxx"
                        }));
                        ULDir uldir = new ULDir(command, stringBuilder.ToString(), LTOOLSnet.NetSocket);
                        this.method_18("connected: " + LTOOLSnet.Connected.ToString() + "\n" + uldir.Response);
                        if (uldir.Response.Length > 0)
                        {
                            MessageBox.Show(uldir.Response.Trim(), "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    else
                    {
                        stringBuilder.Append(string.Concat(new string[]
                        {
                            "-READ -q -s",
                            this.method_4(item.FullFilePath),
                            " \"",
                            text5,
                            "\" \"",
                            text6,
                            "\""
                        }));
                        ULDir uldir = new ULDir(command, stringBuilder.ToString());
                        if (uldir.Response.Length > 0)
                        {
                            MessageBox.Show("Read file error.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        string key_FORMAT = usbpublic.KEY_FORMAT;
                        UMD5.DecryptFile(text6, text7, key_FORMAT, false);
                    }
                    if (LTOOLSnet.Connected)
                    {
                        this.method_16(text3);
                        try
                        {
                            this.method_18(string.Concat(new object[]
                            {
                                "StartUSBApplication() Connected:",
                                LTOOLSnet.Connected,
                                " - isLinux: ",
                                this.bool_0,
                                ". Process.Start(\"",
                                text3,
                                "\")"
                            }));
                            if (start)
                            {
                                Process.Start("\"" + text7 + "\"");
                            }
                            else
                            {
                                Process.Start("edit.bat", "\"" + text7 + "\"");
                            }
                            goto IL_525;
                        }
                        catch (Exception ex)
                        {
                            this.method_18(ex.Message);
                            MessageBox.Show(ex.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            goto IL_525;
                        }
                    }
                    try
                    {
                        this.method_18(string.Concat(new object[]
                        {
                            "StartUSBApplication() Connected:",
                            LTOOLSnet.Connected,
                            " - isLinux: ",
                            this.bool_0,
                            ". Process.Start(\"",
                            text3,
                            "\")"
                        }));
                        if (start)
                        {
                            Process.Start("\"" + text7 + "\"");
                        }
                        else
                        {
                            Process.Start("edit.bat", "\"" + text7 + "\"");
                        }
                    }
                    catch (Exception ex)
                    {
                        this.method_18(ex.Message);
                        MessageBox.Show(ex.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                IL_525:
                    item.m_LastModified = File.GetLastWriteTime(DirFilePanel.tempPathLinuxFiles + "\\" + item.FileName);
                    this.m_OpenedFiles.Add(item);
                }
            }
        }

        // Token: 0x06000088 RID: 136 RVA: 0x0000BF78 File Offset: 0x0000A178
        public void PasteToLinux(string targetDirectory, bool issueMessages)
        {
            this.method_18("LTOOLSnet.CopyFileCount: " + LTOOLSnet.CopyFileCount);
            bool flag = false;
            int i = 0;
            while (i <= 1000)
            {
                i++;
                LTOOLSnet.ShowProgessBar(true);
                Application.DoEvents();
            }
            int j = 0;
            while (j < LTOOLSnet.CopyFileCount)
            {
                if (LTOOLSnet.CopyFileDirPath[j].Equals(""))
                {
                    goto IL_C12;
                }
                Application.DoEvents();
                string text = UMD5.ConvertStringToHex(LTOOLSnet.CopyFileDirPath[j].ToString(), Encoding.Unicode);
                string text2 = string.Concat(new object[]
                {
                    targetDirectory,
                    text,
                    "/",
                    LTOOLSnet.CopyFileName[j]
                });
                string text3 = LTOOLSnet.CopyFileSize[j].ToString();
                text3 = text3.Replace(",", "");
                text3 = text3.Replace(".", "");
                text3 = text3.Replace(" ", "");
                usbpublic.FILE_SIZE = Convert.ToInt64(text3);
                string text4 = LTOOLSnet.CopyFilePath[j].ToString();
                string text5 = UMD5.AddStringToCryptFile(text4);
                string strFileToDecrypt = UMD5.AddStringToCryptFile((string)LTOOLSnet.CopyFileName[j]);
                UMD5.GetFileNameFromDecrypt(strFileToDecrypt);
                this.method_18(string.Concat(new object[]
                {
                    "PasteToUSB(): source: ",
                    LTOOLSnet.CopyFilePath[j],
                    " - destination: ",
                    text2
                }));
                string text6;
                string[] array;
                string text7;
                string text16;
                if (LTOOLSnet.CopyFileIsLinux)
                {
                    text6 = "ucom";
                    array = this.method_5(LTOOLSnet.CopyFileDirPath[j].ToString()).Split(new char[]
                    {
                        '/'
                    });
                    text7 = "";
                    if (LTOOLSnet.Connected)
                    {
                        goto IL_1500;
                    }
                    string text8 = UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                    string text9 = this.method_5(LTOOLSnet.CopyFilePath[j].ToString());
                    text9 = text9.Substring(0, text9.Length - LTOOLSnet.CopyFileName[j].ToString().Length) + text8;
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (array[k].Length > 0)
                        {
                            text7 = text7 + array[k].ToString() + "/";
                        }
                    }
                    text8 = UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                    text2 = targetDirectory + text7 + text8;
                    DirectoryNode selectedDirectoryNode = this.GetSelectedDirectoryNode();
                    string text10 = this.method_5(selectedDirectoryNode.Path);
                    string text11 = this.method_12(selectedDirectoryNode);
                    bool flag2 = true;
                    if (this.LinuxFileExist(LTOOLSnet.CopyFileDir[j].ToString()) && (j == 0 || (j > 0 && !LTOOLSnet.CopyFileDir[j].Equals(LTOOLSnet.CopyFileDir[j - 1]))))
                    {
                        string text12 = "Thư mục '" + LTOOLSnet.CopyFileDir[j].ToString() + "' đã tồn tại. Bạn có muốn ghi đè không?";
                        if (MessageBox.Show(text12, "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            flag2 = false;
                        }
                    }
                    if (!flag2)
                    {
                        goto IL_1500;
                    }
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (array[k].Length > 0)
                        {
                            string text13 = array[k];
                            if (!this.SearchLinuxFile(text11, text13))
                            {
                                string dirName = UMD5.ConvertHexToString(array[k].ToString(), Encoding.Unicode);
                                this.CreateNewLinuxDirectory(this.method_5(text11), dirName);
                            }
                            if (text10.Length > 1)
                            {
                                text10 = text10 + text13 + DirFilePanel.char_0;
                                text11 = text11 + text13 + DirFilePanel.char_0;
                            }
                            else
                            {
                                text10 += text13;
                                text11 += text13;
                            }
                        }
                    }
                    text8 = UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                    if (!text7.EndsWith(DirFilePanel.char_0.ToString()))
                    {
                        text7 += DirFilePanel.char_0;
                    }
                    ArrayList linuxFiles = this.GetLinuxFiles(targetDirectory + text7);
                    if (this.LinuxFileExistArray(text8, linuxFiles))
                    {
                        string text14 = this.method_5(text2);
                        string text15 = string.Concat(new string[]
                        {
                            "-WRITE -del -q -s",
                            this.method_4(text2),
                            " \"",
                            text14,
                            "\""
                        });
                        this.method_18(text6 + " " + text15);
                        new ULDir(text6, text15);
                    }
                    text16 = string.Concat(new string[]
                    {
                        "-READ -q -s",
                        this.method_4(LTOOLSnet.CopyFilePath[j].ToString()),
                        " \"",
                        this.method_5(text9),
                        "\" zzz.tmp"
                    });
                    this.method_18("PasteToUSB()-READ:" + text6 + " " + text16);
                    LTOOLSnet.UpdateStatusBarPanel_Copyfile("Đang copy file: " + (string)LTOOLSnet.CopyFileName[j]);
                    ULDir uldir = new ULDir(text6, text16);
                    if (uldir.Response.Length > 0)
                    {
                        if (issueMessages)
                        {
                            MessageBox.Show("Lỗi copy file!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        LTOOLSnet.ShowProgessBar(false);
                        return;
                    }
                    text16 = string.Concat(new string[]
                    {
                        "-WRITE -q -s",
                        this.method_0(),
                        " -copy zzz.tmp \"",
                        this.method_5(text2),
                        "\""
                    });
                    this.method_18("PasteToUSB()-WRITE USBToUSB:" + text6 + " " + text16);
                    ULDir uldir2 = new ULDir(text6, text16);
                    if (uldir2.Response.Length > 0)
                    {
                        if (issueMessages)
                        {
                            MessageBox.Show("Lỗi copy file!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        LTOOLSnet.ShowProgessBar(false);
                        return;
                    }
                    flag = true;
                    try
                    {
                        goto IL_1500;
                    }
                    catch
                    {
                        goto IL_1500;
                    }
                }
                text6 = "ucom";
                array = LTOOLSnet.CopyFileDirPath[j].ToString().Split(new char[]
                {
                    '\\'
                });
                text7 = "";
                if (!LTOOLSnet.Connected)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        text7 = text7 + UMD5.ConvertStringToHex(array[k].ToString(), Encoding.Unicode) + "/";
                    }
                    string text8 = UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                    text2 = targetDirectory + text7 + text8;
                    if (LTOOLSnet.IsEncryptFile)
                    {
                        if (Convert.ToInt64(text3) > 104857600L)
                        {
                            text5 = DirFilePanel.tempPathLinuxFiles + "\\" + text8;
                            if (File.Exists(text5))
                            {
                                File.Delete(text5);
                            }
                            try
                            {
                                File.Copy(text4, text5, true);
                            }
                            catch
                            {
                                break;
                            }
                            text16 = string.Concat(new string[]
                            {
                                "-WRITE -q -s",
                                this.method_0(),
                                " -copy \"",
                                text5,
                                "\" \"",
                                this.method_5(text2),
                                "\""
                            });
                        }
                        else
                        {
                            if (!Directory.Exists(DirFilePanel.tempPathLinuxFiles))
                            {
                                this.method_18("Create Directory " + DirFilePanel.tempPathLinuxFiles);
                                Directory.CreateDirectory(DirFilePanel.tempPathLinuxFiles);
                            }
                            text5 = DirFilePanel.tempPathLinuxFiles + "\\" + text8;
                            if (File.Exists(text5))
                            {
                                File.Delete(text5);
                            }
                            string key_FORMAT = usbpublic.KEY_FORMAT;
                            UMD5.EncryptFile(text4, text5, key_FORMAT, false);
                            text16 = string.Concat(new string[]
                            {
                                "-WRITE -q -s",
                                this.method_0(),
                                " -copy \"",
                                text5,
                                "\" \"",
                                this.method_5(text2),
                                "\""
                            });
                        }
                    }
                    else
                    {
                        text16 = string.Concat(new object[]
                        {
                            "-WRITE -q -s",
                            this.method_0(),
                            " -copy \"",
                            LTOOLSnet.CopyFilePath[j],
                            "\" \"",
                            this.method_5(text2),
                            "\""
                        });
                    }
                }
                else
                {
                    this.method_17((string)LTOOLSnet.CopyFilePath[j]);
                    text16 = string.Concat(new string[]
                    {
                        "-WRITE -x -s",
                        this.method_0(),
                        " -copy zzz.xxx  \"",
                        this.method_5(text2),
                        "\""
                    });
                }
                if (LTOOLSnet.Connected)
                {
                    ULDir uldir = new ULDir(text6, text16, LTOOLSnet.NetSocket);
                }
                else
                {
                    DirectoryNode selectedDirectoryNode = this.GetSelectedDirectoryNode();
                    string text10 = this.method_5(selectedDirectoryNode.Path);
                    string text11 = this.method_12(selectedDirectoryNode);
                    bool flag2 = true;
                    if (this.LinuxFileExist(LTOOLSnet.CopyFileDir[j].ToString()) && (j == 0 || (j > 0 && !LTOOLSnet.CopyFileDir[j].Equals(LTOOLSnet.CopyFileDir[j - 1]))))
                    {
                        string text12 = "Thư mục '" + array[0].ToString() + "' đã tồn tại. Bạn có muốn ghi đè không?";
                        if (MessageBox.Show(text12, "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            flag2 = false;
                        }
                    }
                    if (flag2)
                    {
                        for (int k = 0; k < array.Length; k++)
                        {
                            string text13 = UMD5.ConvertStringToHex(array[k], Encoding.Unicode);
                            bool flag3;
                            if (this.method_5(text11).ToString().Length > 1)
                            {
                                flag3 = this.SearchLinuxFile(text11 + "/", text13);
                            }
                            else
                            {
                                flag3 = this.SearchLinuxFile(text11, text13);
                            }
                            if (!flag3)
                            {
                                this.CreateNewLinuxDirectory(this.method_5(text11), array[k]);
                            }
                            if (text10.Length > 1)
                            {
                                text10 = text10 + DirFilePanel.char_0 + text13;
                                text11 = text11 + DirFilePanel.char_0 + text13;
                            }
                            else
                            {
                                text10 += text13;
                                text11 += text13;
                            }
                        }
                        this.method_18(string.Concat(new object[]
                        {
                            "PasteToUSB()-WRITE DosToUSB:",
                            text6,
                            " ",
                            text16,
                            " - connected: ",
                            LTOOLSnet.Connected
                        }));
                        string text8 = UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                        if (!text7.EndsWith(DirFilePanel.char_0.ToString()))
                        {
                            text7 += DirFilePanel.char_0;
                        }
                        ArrayList linuxFiles = this.GetLinuxFiles(targetDirectory + text7);
                        if (this.LinuxFileExistArray(text8, linuxFiles))
                        {
                            string text14 = this.method_5(text2);
                            string text15 = string.Concat(new string[]
                            {
                                "-WRITE -del -q -s",
                                this.method_4(text2),
                                " \"",
                                text14,
                                "\""
                            });
                            this.method_18(text6 + " " + text15);
                            new ULDir(text6, text15);
                        }
                        LTOOLSnet.UpdateStatusBarPanel_Copyfile("Đang copy file: " + (string)LTOOLSnet.CopyFileName[j]);
                        ULDir uldir = new ULDir(text6, text16);
                        if (uldir.Response.Length > 0)
                        {
                            if (issueMessages)
                            {
                                MessageBox.Show("Lỗi copy file!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            LTOOLSnet.ShowProgessBar(false);
                            return;
                        }
                        flag = true;
                        if (LTOOLSnet.CutSelected)
                        {
                            try
                            {
                                File.Delete(text4);
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                if (File.Exists(text5))
                {
                    try
                    {
                        File.Delete(text5);
                        goto IL_1500;
                    }
                    catch
                    {
                        goto IL_1500;
                    }
                    goto IL_C12;
                }
            IL_1500:
                j++;
                continue;
            IL_C12:
                Application.DoEvents();
                text2 = targetDirectory + LTOOLSnet.CopyFileName[j];
                text3 = LTOOLSnet.CopyFileSize[j].ToString();
                text3 = text3.Replace(",", "");
                text3 = text3.Replace(".", "");
                usbpublic.FILE_SIZE = Convert.ToInt64(text3);
                text4 = LTOOLSnet.CopyFilePath[j].ToString();
                text5 = UMD5.AddStringToCryptFile(text4);
                strFileToDecrypt = UMD5.AddStringToCryptFile((string)LTOOLSnet.CopyFileName[j]);
                UMD5.GetFileNameFromDecrypt(strFileToDecrypt);
                this.method_18(string.Concat(new object[]
                {
                    "PasteToUSB(): source: ",
                    LTOOLSnet.CopyFilePath[j],
                    " - destination: ",
                    text2
                }));
                if (!LTOOLSnet.IsLinuxReadOnly)
                {
                    if (LTOOLSnet.CopyFileIsLinux)
                    {
                        text6 = "ucom";
                        if (LTOOLSnet.Connected)
                        {
                            text16 = string.Concat(new string[]
                            {
                                "-READ -x -s",
                                this.method_4(LTOOLSnet.CopyFilePath[j].ToString()),
                                " \"",
                                this.method_5(LTOOLSnet.CopyFilePath[j].ToString()),
                                "\" zzz.tmp"
                            });
                            this.method_18("PasteToUSB()-READ:" + text6 + " " + text16);
                            ULDir uldir = new ULDir(text6, text16, LTOOLSnet.NetSocket);
                            if (uldir.Response.Length <= 0)
                            {
                                text16 = string.Concat(new string[]
                                {
                                    "-WRITE -x -s",
                                    this.method_0(),
                                    " -copy zzz.tmp \"",
                                    this.method_5(text2),
                                    "\""
                                });
                                this.method_18("PasteToUSB()-WRITE USBToUSB:" + text6 + " " + text16);
                                ULDir uldir2 = new ULDir(text6, text16, LTOOLSnet.NetSocket);
                                if (uldir2.Response.Length <= 0)
                                {
                                    flag = true;
                                    goto IL_1500;
                                }
                                if (issueMessages)
                                {
                                    MessageBox.Show("Lỗi copy file!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                            }
                            else if (issueMessages)
                            {
                                MessageBox.Show("Lỗi copy file!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                        else
                        {
                            string text8 = UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                            string text9 = this.method_5(LTOOLSnet.CopyFilePath[j].ToString());
                            text9 = text9.Substring(0, text9.Length - LTOOLSnet.CopyFileName[j].ToString().Length) + text8;
                            text2 = targetDirectory + text8;
                            text16 = string.Concat(new string[]
                            {
                                "-READ -q -s",
                                this.method_4(LTOOLSnet.CopyFilePath[j].ToString()),
                                " \"",
                                this.method_5(text9),
                                "\" zzz.tmp"
                            });
                            this.method_18("PasteToUSB()-READ:" + text6 + " " + text16);
                            ULDir uldir = new ULDir(text6, text16);
                            if (uldir.Response.Length <= 0)
                            {
                                if (this.LinuxFileExist(LTOOLSnet.CopyFileName[j].ToString()))
                                {
                                    string text12 = "File '" + (string)LTOOLSnet.CopyFileName[j] + "' đã tồn tại. Bạn có muốn ghi đè không?";
                                    if (MessageBox.Show(text12, "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                    {
                                        goto IL_1500;
                                    }
                                    string text14 = this.method_5(targetDirectory + UMD5.ConvertStringToHex((string)LTOOLSnet.CopyFileName[j], Encoding.Unicode));
                                    string text15 = string.Concat(new string[]
                                    {
                                        "-WRITE -del -q -s",
                                        this.method_4(text2),
                                        " \"",
                                        text14,
                                        "\""
                                    });
                                    this.method_18(text6 + " " + text15);
                                    new ULDir(text6, text15);
                                }
                                text16 = string.Concat(new string[]
                                {
                                    "-WRITE -q -s",
                                    this.method_0(),
                                    " -copy zzz.tmp \"",
                                    this.method_5(text2),
                                    "\""
                                });
                                this.method_18("PasteToUSB()-WRITE USBToUSB:" + text6 + " " + text16);
                                ULDir uldir2 = new ULDir(text6, text16);
                                if (uldir2.Response.Length <= 0)
                                {
                                    flag = true;
                                    goto IL_1500;
                                }
                                if (issueMessages)
                                {
                                    MessageBox.Show("Lỗi copy file!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                LTOOLSnet.ShowProgessBar(false);
                            }
                            else
                            {
                                if (issueMessages)
                                {
                                    MessageBox.Show("Lỗi copy file!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                LTOOLSnet.ShowProgessBar(false);
                            }
                        }
                    }
                    else
                    {
                        text6 = "ucom";
                        if (!LTOOLSnet.Connected)
                        {
                            string text8 = UMD5.ConvertStringToHex(LTOOLSnet.CopyFileName[j].ToString(), Encoding.Unicode);
                            text2 = targetDirectory + text8;
                            if (!LTOOLSnet.CopyFileDirPath[j].Equals(""))
                            {
                                text = UMD5.ConvertStringToHex(LTOOLSnet.CopyFileDirPath[j].ToString(), Encoding.Unicode);
                                text2 = targetDirectory + text + "/" + text8;
                            }
                            if (LTOOLSnet.IsEncryptFile)
                            {
                                if (Convert.ToInt64(text3) > 104857600L)
                                {
                                    text5 = DirFilePanel.tempPathLinuxFiles + "\\" + text8;
                                    if (File.Exists(text5))
                                    {
                                        File.Delete(text5);
                                    }
                                    try
                                    {
                                        File.Copy(text4, text5, true);
                                    }
                                    catch
                                    {
                                        break;
                                    }
                                    text16 = string.Concat(new string[]
                                    {
                                        "-WRITE -q -s",
                                        this.method_0(),
                                        " -copy \"",
                                        text5,
                                        "\" \"",
                                        this.method_5(text2),
                                        "\""
                                    });
                                }
                                else
                                {
                                    if (!Directory.Exists(DirFilePanel.tempPathLinuxFiles))
                                    {
                                        this.method_18("Create Directory " + DirFilePanel.tempPathLinuxFiles);
                                        Directory.CreateDirectory(DirFilePanel.tempPathLinuxFiles);
                                    }
                                    text5 = DirFilePanel.tempPathLinuxFiles + "\\" + text8;
                                    if (File.Exists(text5))
                                    {
                                        File.Delete(text5);
                                    }
                                    string key_FORMAT = usbpublic.KEY_FORMAT;
                                    UMD5.EncryptFile(text4, text5, key_FORMAT, false);
                                    text16 = string.Concat(new string[]
                                    {
                                        "-WRITE -q -s",
                                        this.method_0(),
                                        " -copy \"",
                                        text5,
                                        "\" \"",
                                        this.method_5(text2),
                                        "\""
                                    });
                                }
                            }
                            else
                            {
                                text16 = string.Concat(new object[]
                                {
                                    "-WRITE -q -s",
                                    this.method_0(),
                                    " -copy \"",
                                    LTOOLSnet.CopyFilePath[j],
                                    "\" \"",
                                    this.method_5(text2),
                                    "\""
                                });
                            }
                        }
                        else
                        {
                            this.method_17((string)LTOOLSnet.CopyFilePath[j]);
                            text16 = string.Concat(new string[]
                            {
                                "-WRITE -x -s",
                                this.method_0(),
                                " -copy zzz.xxx  \"",
                                this.method_5(text2),
                                "\""
                            });
                        }
                        LTOOLSnet.UpdateStatusBarPanel_Copyfile("Đang copy file: " + (string)LTOOLSnet.CopyFileName[j]);
                        this.method_18(string.Concat(new object[]
                        {
                            "PasteToUSB()-WRITE DosToUSB:",
                            text6,
                            " ",
                            text16,
                            " - connected: ",
                            LTOOLSnet.Connected
                        }));
                        ULDir uldir;
                        if (LTOOLSnet.Connected)
                        {
                            uldir = new ULDir(text6, text16, LTOOLSnet.NetSocket);
                        }
                        else
                        {
                            if (this.LinuxFileExist(LTOOLSnet.CopyFileName[j].ToString()))
                            {
                                string text12 = "File '" + (string)LTOOLSnet.CopyFileName[j] + "' đã tồn tại. Bạn có muốn ghi đè không?";
                                if (MessageBox.Show(text12, "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                {
                                    goto IL_1500;
                                }
                                string text14 = this.method_5(targetDirectory + UMD5.ConvertStringToHex((string)LTOOLSnet.CopyFileName[j], Encoding.Unicode));
                                string text15 = string.Concat(new string[]
                                {
                                    "-WRITE -del -q -s",
                                    this.method_4(text2),
                                    " \"",
                                    text14,
                                    "\""
                                });
                                this.method_18(text6 + " " + text15);
                                new ULDir(text6, text15);
                            }
                            uldir = new ULDir(text6, text16);
                            if (File.Exists(text5))
                            {
                                try
                                {
                                    File.Delete(text5);
                                }
                                catch
                                {
                                }
                            }
                            if (LTOOLSnet.CutSelected)
                            {
                                try
                                {
                                    File.Delete(text4);
                                }
                                catch
                                {
                                }
                            }
                        }
                        if (uldir.Response.Length <= 0)
                        {
                            flag = true;
                            this.UpdateNode(this.GetSelectedDirectoryNode());
                            goto IL_1500;
                        }
                        if (issueMessages)
                        {
                            MessageBox.Show("Lỗi copy file!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        LTOOLSnet.ShowProgessBar(false);
                    }
                }
                else
                {
                    MessageBox.Show("Hệ thống đã kích hoạt tính năng chống ghi USB.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return;
            }
            LTOOLSnet.ShowProgessBar(false);
            if (flag)
            {
                this.UpdateNode(this.GetSelectedDirectoryNode());
                return;
            }
        }

        // Token: 0x06000089 RID: 137 RVA: 0x0000D628 File Offset: 0x0000B828
        public bool LinuxFileExist(string fileName)
        {
            ListView.ListViewItemCollection items = this.listView.Items;
            foreach (object obj in items)
            {
                ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                if (listViewItemFile.FileName.Equals(fileName))
                {
                    return true;
                }
            }
            return false;
        }

        // Token: 0x0600008A RID: 138 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
        public bool LinuxFileExistArray(string fileName, ArrayList files)
        {
            foreach (object obj in files)
            {
                ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                if (listViewItemFile.FileName.Equals(fileName))
                {
                    return true;
                }
            }
            return false;
        }

        // Token: 0x0600008B RID: 139 RVA: 0x0000D70C File Offset: 0x0000B90C
        public bool SearchLinuxFile(string ldirPath, string fname)
        {
            string text = string.Concat(new string[]
            {
                "-s",
                this.method_4(ldirPath),
                " \"",
                this.method_5(ldirPath),
                "\""
            });
            this.method_18("UpdateListView() - Process arguments: \"ldir " + text + "\"");
            ULDir uldir = new ULDir("ucom", text);
            Class1 @class = new Class1(uldir.Response, "\n\r");
            while (@class.method_3())
            {
                string text2 = @class.method_4();
                bool result;
                if (text2.Length >= 56)
                {
                    string text3 = this.method_9(text2, 9);
                    if (!this.method_9(text2, 0)[0].ToString().Equals("d") || (text3.Equals(".") || text3.Equals("..") || text3.Equals("lost+found")) || !(text3 == fname))
                    {
                        continue;
                    }
                    result = true;
                }
                else
                {
                    StringBuilder stringBuilder = new StringBuilder(text2);
                    while (@class.method_3())
                    {
                        stringBuilder.Append(@class.method_4());
                    }
                    this.method_18("StartColumnUSBFilename > token.length: " + stringBuilder.ToString());
                    result = false;
                }
                return result;
            }
            return false;
        }

        // Token: 0x0600008C RID: 140 RVA: 0x0000D864 File Offset: 0x0000BA64
        public void ModifyLinuxFile(ListView.SelectedListViewItemCollection items)
        {
            this.method_18("ModifyUSBFile()");
            bool flag = false;
            foreach (object obj in items)
            {
                ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                if (!listViewItemFile.IsError && !listViewItemFile.FileName.Equals(".."))
                {
                    this.method_18("ModifyUSBFile(): fullpath: " + listViewItemFile.FullFilePath + " --- fileName: " + listViewItemFile.FileName);
                    string access = "";
                    string text = "      ";
                    string text2 = "      ";
                    string fileLength = "";
                    string str = "";
                    string str2 = "";
                    Class1 @class = new Class1(listViewItemFile.LinuxFileInfoString, " ");
                    int num = 0;
                    while (@class.method_3())
                    {
                        string text3 = @class.method_4();
                        switch (num)
                        {
                            case 0:
                                access = text3;
                                break;
                            case 1:
                                text += text3;
                                break;
                            case 2:
                                text2 += text3;
                                break;
                            case 3:
                                fileLength = text3;
                                break;
                            case 5:
                                str = text3;
                                break;
                            case 6:
                                str = str + " " + text3;
                                break;
                            case 7:
                                str2 = text3;
                                break;
                            case 8:
                                str = str + " " + text3;
                                break;
                        }
                        num++;
                    }
                    string text4;
                    if (listViewItemFile.IsLink)
                    {
                        text4 = this.method_10(listViewItemFile.FileName);
                    }
                    else
                    {
                        text4 = listViewItemFile.FileName;
                    }
                    ModifyLinuxDialog modifyLinuxDialog = new ModifyLinuxDialog(false, text4, str + " " + str2, fileLength, text, text2, access);
                    modifyLinuxDialog.Text = "Rename";
                    if (modifyLinuxDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (LTOOLSnet.IsLinuxReadOnly)
                        {
                            this.method_18("USBIsReadOnly");
                            string text5 = "Hệ thống đã kích hoạt tính năng chống ghi USB.";
                            MessageBox.Show(text5, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if (modifyLinuxDialog.FileName.Equals("") || modifyLinuxDialog.FileName.IndexOf(DirFilePanel.char_0.ToString()) > 0)
                        {
                            string text6;
                            if (modifyLinuxDialog.FileName.Equals(""))
                            {
                                text6 = "The new filename is not allowed. The length of the filename is 0.";
                            }
                            else
                            {
                                text6 = "The new filename is not allowed. The filename contains a /.";
                            }
                            MessageBox.Show(text6, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else if (!text4.Equals(modifyLinuxDialog.FileName) || !modifyLinuxDialog.GID.Equals(text2) || !modifyLinuxDialog.UID.Equals(text) || modifyLinuxDialog.IsAccessChanged)
                        {
                            flag = true;
                            this.method_18("USBDrive: \"" + listViewItemFile.LinuxDrive + "\"");
                            string text3 = "ucom ";
                            string text7 = "-WRITE ";
                            if (!text4.Equals(modifyLinuxDialog.FileName))
                            {
                                text7 += "-ren ";
                            }
                            if (LTOOLSnet.Connected)
                            {
                                text7 += "-x ";
                            }
                            else
                            {
                                text7 += "-q ";
                            }
                            text7 = string.Concat(new string[]
                            {
                                text7,
                                "-s",
                                listViewItemFile.LinuxDrive,
                                " -f",
                                modifyLinuxDialog.Access,
                                " "
                            });
                            if (!modifyLinuxDialog.GID.Equals(text2))
                            {
                                text7 = text7 + "-g" + modifyLinuxDialog.GID + " ";
                            }
                            if (!modifyLinuxDialog.UID.Equals(text))
                            {
                                text7 = text7 + "-u" + modifyLinuxDialog.UID + " ";
                            }
                            string text8 = this.method_5(listViewItemFile.FullFilePath);
                            text8 = this.method_5(listViewItemFile.Directory + UMD5.ConvertStringToHex(listViewItemFile.FileName, Encoding.Unicode));
                            if (listViewItemFile.IsLink)
                            {
                                text8 = text8.Substring(0, text8.IndexOf("->") - 1);
                            }
                            text7 = text7 + "\"" + text8 + "\"";
                            if (!text4.Equals(modifyLinuxDialog.FileName))
                            {
                                text7 = text7 + " \"" + UMD5.ConvertStringToHex(modifyLinuxDialog.FileName, Encoding.Unicode) + "\"";
                            }
                            this.method_18("ModifyUSBFile(): " + text3 + text7);
                            ULDir uldir;
                            if (LTOOLSnet.Connected)
                            {
                                uldir = new ULDir(text3, text7, LTOOLSnet.NetSocket);
                            }
                            else
                            {
                                uldir = new ULDir(text3, text7);
                            }
                            this.method_18("ModifyUSBFile 1:>>>" + uldir.Response + "<<<");
                            if (uldir.Response.Length > 0)
                            {
                                MessageBox.Show(uldir.Response, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                    }
                }
            }
            if (flag)
            {
                this.UpdateNode(this.GetSelectedDirectoryNode());
            }
        }

        // Token: 0x0600008D RID: 141 RVA: 0x0000DD78 File Offset: 0x0000BF78
        public void UpdateLinuxListView(DirectoryNode dirNode)
        {
            this.method_18("UpdateListView() - LINUX: " + dirNode.Path);
            string text = dirNode.Text;
            string text2 = this.method_12(dirNode);
            ArrayList arrayList = new ArrayList();
            ArrayList arrayList2 = new ArrayList();
            string text3 = string.Concat(new string[]
            {
                "-s",
                this.method_4(text2),
                " \"",
                this.method_5(text2),
                "\""
            });
            this.method_18("UpdateListView() - Process arguments: \"ldir " + text3 + "\"");
            ULDir uldir;
            if (LTOOLSnet.Connected)
            {
                uldir = new ULDir("ucom", "-x " + text3, LTOOLSnet.NetSocket);
            }
            else
            {
                uldir = new ULDir("ucom", text3);
            }
            Class1 @class = new Class1(uldir.Response, "\n\r");
            while (@class.method_3())
            {
                string text4 = @class.method_4();
                if (text4.Length < 56)
                {
                    StringBuilder stringBuilder = new StringBuilder(text4);
                    while (@class.method_3())
                    {
                        stringBuilder.Append(@class.method_4());
                    }
                    this.method_18("StartColumnUSBFilename > token.length: " + stringBuilder.ToString());
                    this.listView.Clear();
                    this.listView.View = this.view_0;
                    this.listView.Columns.Add("Error", this.listView.Size.Width - 50, HorizontalAlignment.Left);
                    ListViewItemFile listViewItemFile = new ListViewItemFile(stringBuilder.ToString(), 0, false);
                    listViewItemFile.IsError = true;
                    this.listView.Items.Add(listViewItemFile);
                    return;
                }
                string text5 = this.method_9(text4, 9);
                if (this.method_9(text4, 0)[0].ToString().Equals("d"))
                {
                    if (text5.Equals(".") || text5.Equals("..") || text5.Equals("lost+found"))
                    {
                        continue;
                    }
                    string text6 = this.method_9(text4, 3);
                    try
                    {
                        if (Convert.ToInt64(text6) > 2147483647L)
                        {
                            text6 = string.Format("{0:0,0}", Convert.ToInt64(text6));
                        }
                        else
                        {
                            text6 = string.Format("{0:0,0}", Convert.ToInt32(text6));
                        }
                        string text7 = string.Concat(new string[]
                        {
                            this.method_9(text4, 4),
                            " ",
                            this.method_9(text4, 5),
                            " ",
                            this.method_9(text4, 6),
                            " ",
                            this.method_9(text4, 7),
                            " ",
                            this.method_9(text4, 8)
                        });
                        DateTime dateTime;
                        DateTime.TryParseExact(text7, "ddd MMM dd HH:mm:ss yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
                        dateTime = dateTime.AddHours(7.0);
                        text7 = dateTime.ToString("MM/dd/yyyy HH:mm:ss");
                        text5 = UMD5.ConvertHexToString(text5, Encoding.Unicode);
                        ListViewItemFile listViewItemFile2 = new ListViewItemFile(text5, DirFilePanel.IndexIconFolderL, true, text2, text6, text7, text4);
                        listViewItemFile2.SubItems.Add("");
                        listViewItemFile2.SubItems.Add("");
                        listViewItemFile2.SubItems.Add(listViewItemFile2.FileLastModified);
                        listViewItemFile2.SubItems.Add(this.method_9(listViewItemFile2.LinuxFileInfoString, 0));
                        listViewItemFile2.SubItems.Add(this.method_9(listViewItemFile2.LinuxFileInfoString, 1));
                        listViewItemFile2.SubItems.Add(this.method_9(listViewItemFile2.LinuxFileInfoString, 2));
                        arrayList.Add(listViewItemFile2);
                        continue;
                    }
                    catch
                    {
                        continue;
                    }
                }
                if (LTOOLSnet.LinuxFilePattern.Equals("*"))
                {
                    string text6 = this.method_9(text4, 3);
                    try
                    {
                        if (Convert.ToInt64(text6) > 2147483647L)
                        {
                            text6 = string.Format("{0:0,0}", Convert.ToInt64(text6));
                        }
                        else
                        {
                            text6 = string.Format("{0:0,0}", Convert.ToInt32(text6));
                        }
                        string text7 = string.Concat(new string[]
                        {
                            this.method_9(text4, 4),
                            " ",
                            this.method_9(text4, 5),
                            " ",
                            this.method_9(text4, 6),
                            " ",
                            this.method_9(text4, 7),
                            " ",
                            this.method_9(text4, 8)
                        });
                        DateTime dateTime;
                        DateTime.TryParseExact(text7, "ddd MMM dd HH:mm:ss yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
                        dateTime = dateTime.AddHours(7.0);
                        text7 = dateTime.ToString("MM/dd/yyyy HH:mm:ss");
                        text5 = UMD5.ConvertHexToString(text5, Encoding.Unicode);
                        ListViewItemFile listViewItemFile3 = new ListViewItemFile(text5, DirFilePanel.IndexIconFile, false, text2, text6, text7, text4);
                        listViewItemFile3.SubItems.Add(listViewItemFile3.FileSize);
                        listViewItemFile3.SubItems.Add(this.method_11(listViewItemFile3.FullFilePath));
                        listViewItemFile3.SubItems.Add(listViewItemFile3.FileLastModified);
                        listViewItemFile3.SubItems.Add(this.method_9(listViewItemFile3.LinuxFileInfoString, 0));
                        listViewItemFile3.SubItems.Add(this.method_9(listViewItemFile3.LinuxFileInfoString, 1));
                        listViewItemFile3.SubItems.Add(this.method_9(listViewItemFile3.LinuxFileInfoString, 2));
                        arrayList2.Add(listViewItemFile3);
                    }
                    catch
                    {
                    }
                }
            }
            if (!LTOOLSnet.LinuxFilePattern.Equals("*"))
            {
                string text8 = string.Concat(new string[]
                {
                    "-s",
                    this.method_4(text2),
                    " \"",
                    this.method_5(text2),
                    LTOOLSnet.LinuxFilePattern,
                    "\""
                });
                this.method_18("UpdateListView() - Process arguments: \"ldir " + text8 + "\"");
                ULDir uldir2;
                if (LTOOLSnet.Connected)
                {
                    uldir2 = new ULDir("ucom", "-x " + text8, LTOOLSnet.NetSocket);
                }
                else
                {
                    uldir2 = new ULDir("ucom", text8);
                }
                Class1 class2 = new Class1(uldir2.Response, "\n\r");
                while (class2.method_3())
                {
                    string text4 = class2.method_4();
                    if (text4.Length < 56)
                    {
                        StringBuilder stringBuilder = new StringBuilder(text4);
                        while (class2.method_3())
                        {
                            stringBuilder.Append(class2.method_4());
                        }
                        this.method_18("StartColumnUSBFilename > token.length: " + stringBuilder.ToString());
                        if (!stringBuilder.ToString().Equals("Can't find '" + LTOOLSnet.LinuxFilePattern + "'.USB Path Invalid"))
                        {
                            this.listView.Clear();
                            this.listView.View = this.view_0;
                            this.listView.Columns.Add("Error", this.listView.Size.Width - 50, HorizontalAlignment.Left);
                            ListViewItemFile listViewItemFile = new ListViewItemFile(stringBuilder.ToString(), 0, false);
                            listViewItemFile.IsError = true;
                            this.listView.Items.Add(listViewItemFile);
                            return;
                        }
                    }
                    else
                    {
                        string text5 = this.method_9(text4, 9);
                        if (!this.method_9(text4, 0)[0].ToString().Equals("d"))
                        {
                            string text6 = this.method_9(text4, 3);
                            string text7 = string.Concat(new string[]
                            {
                                this.method_9(text4, 4),
                                " ",
                                this.method_9(text4, 5),
                                " ",
                                this.method_9(text4, 6),
                                " ",
                                this.method_9(text4, 7),
                                " ",
                                this.method_9(text4, 8)
                            });
                            ListViewItemFile listViewItemFile3 = new ListViewItemFile(text5, DirFilePanel.IndexIconFile, false, text2, text6, text7, text4);
                            listViewItemFile3.SubItems.Add(listViewItemFile3.FileSize);
                            listViewItemFile3.SubItems.Add(this.method_11(listViewItemFile3.FullFilePath));
                            listViewItemFile3.SubItems.Add(listViewItemFile3.FileLastModified);
                            listViewItemFile3.SubItems.Add(this.method_9(listViewItemFile3.LinuxFileInfoString, 0));
                            listViewItemFile3.SubItems.Add(this.method_9(listViewItemFile3.LinuxFileInfoString, 1));
                            listViewItemFile3.SubItems.Add(this.method_9(listViewItemFile3.LinuxFileInfoString, 2));
                            arrayList2.Add(listViewItemFile3);
                        }
                    }
                }
            }
            this.method_15(text2, arrayList, arrayList2);
        }

        // Token: 0x0600008E RID: 142 RVA: 0x0000E67C File Offset: 0x0000C87C
        private string method_9(string string_0, int int_2)
        {
            Class1 @class = new Class1(string_0, " ");
            int num = 0;
            while (@class.method_3())
            {
                string text = @class.method_4();
                if (num == 9)
                {
                    text = string_0.Substring(string_0.IndexOf(text));
                }
                if (num == int_2)
                {
                    return text;
                }
                num++;
            }
            return "";
        }

        // Token: 0x0600008F RID: 143 RVA: 0x0000E6D8 File Offset: 0x0000C8D8
        public string GetFilePathFromLink(string fullPath)
        {
            int startIndex = fullPath.IndexOf("->", 0) + 3;
            string text = fullPath.Substring(startIndex);
            string result;
            if (text.StartsWith(DirFilePanel.char_0.ToString()))
            {
                result = text;
            }
            else
            {
                string text2 = this.method_5(fullPath);
                result = text2.Substring(0, text2.LastIndexOf(DirFilePanel.char_0.ToString()) + 1) + text;
            }
            return result;
        }

        // Token: 0x06000090 RID: 144 RVA: 0x0000E74C File Offset: 0x0000C94C
        public string GetFileNameFromLink(string fullPath)
        {
            int startIndex = fullPath.IndexOf("->", 0) + 3;
            string text = fullPath.Substring(startIndex);
            string result;
            if (text.StartsWith(DirFilePanel.char_0.ToString()))
            {
                result = text.Substring(text.LastIndexOf(DirFilePanel.char_0.ToString()) + 1);
            }
            else
            {
                result = text;
            }
            return result;
        }

        // Token: 0x06000091 RID: 145 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
        private string method_10(string string_0)
        {
            int length = string_0.IndexOf("->", 0) - 1;
            return string_0.Substring(0, length);
        }

        // Token: 0x06000092 RID: 146 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.directoryNode_0 = (DirectoryNode)e.Node;
            ((DirectoryNode)e.Node).Path = this.method_12(e.Node);
            this.method_18("TreeView_AfterSelect(): IsUSB = " + this.IsLinux.ToString() + " - DirectoryNode.Path: " + ((DirectoryNode)e.Node).Path);
            if (((DirectoryNode)e.Node).Text.EndsWith(Path.DirectorySeparatorChar.ToString()) && ((DirectoryNode)e.Node).IsRemovableDrive)
            {
                ((DirectoryNode)e.Node).Collapse();
                ((DirectoryNode)e.Node).Nodes.Clear();
                ((DirectoryNode)e.Node).SubDirectoriesAdded = false;
                this.method_1((DirectoryNode)e.Node);
                ((DirectoryNode)e.Node).Expand();
                this.UpdateDosListView((DirectoryNode)e.Node);
            }
            else if (this.IsLinux)
            {
                this.UpdateLinuxListView((DirectoryNode)e.Node);
            }
            else
            {
                this.UpdateDosListView((DirectoryNode)e.Node);
            }
        }

        // Token: 0x06000093 RID: 147 RVA: 0x0000E91C File Offset: 0x0000CB1C
        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (this.bool_0)
            {
                DirectoryNode directoryNode = (DirectoryNode)e.Node;
                if (!directoryNode.SubDirectoriesAdded)
                {
                    this.method_8(directoryNode);
                }
            }
            else
            {
                DirectoryNode directoryNode = (DirectoryNode)e.Node;
                if (!directoryNode.SubDirectoriesAdded)
                {
                    this.WytvnybTJ(directoryNode);
                }
            }
        }

        // Token: 0x06000094 RID: 148 RVA: 0x000022A9 File Offset: 0x000004A9
        private void treeView_DragEnter(object sender, DragEventArgs e)
        {
        }

        // Token: 0x06000095 RID: 149 RVA: 0x000022A9 File Offset: 0x000004A9
        private void treeView_DragDrop(object sender, DragEventArgs e)
        {
        }

        // Token: 0x06000096 RID: 150 RVA: 0x0000E96C File Offset: 0x0000CB6C
        private void treeView_DragOver(object sender, DragEventArgs e)
        {
            Point pt = this.treeView.PointToClient(new Point(e.X, e.Y));
            DirectoryNode directoryNode = (DirectoryNode)this.treeView.GetNodeAt(pt);
            if (directoryNode != this.directoryNode_1)
            {
                if (this.directoryNode_1 != null)
                {
                    this.treeView.BeginUpdate();
                    this.directoryNode_1.BackColor = this.treeView.BackColor;
                    this.treeView.EndUpdate();
                }
            }
            try
            {
                this.treeView.BeginUpdate();
                if (directoryNode != null)
                {
                    this.directoryNode_1 = directoryNode;
                    directoryNode.BackColor = Color.CornflowerBlue;
                }
                this.treeView.EndUpdate();
            }
            catch (Exception ex)
            {
                this.method_18(ex.Message);
            }
        }

        // Token: 0x06000097 RID: 151 RVA: 0x0000EA3C File Offset: 0x0000CC3C
        private void treeView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.treeView.SelectedNode = this.treeView.GetNodeAt(e.X, e.Y);
                if (this.treeView.GetNodeAt(e.X, e.Y) != null)
                {
                    string fullPath = this.treeView.SelectedNode.FullPath;
                    string str;
                    if (this.IsLinux)
                    {
                        str = this.method_4(fullPath);
                    }
                    else
                    {
                        str = fullPath.Substring(0, fullPath.IndexOf("\\"));
                    }
                    this.menuItem_22.Text = "USB Drive " + str;
                }
            }
            this.treeView.SelectedNode = this.directoryNode_0;
        }

        // Token: 0x06000098 RID: 152 RVA: 0x000022A9 File Offset: 0x000004A9
        private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
        }

        // Token: 0x06000099 RID: 153 RVA: 0x000022A9 File Offset: 0x000004A9
        private void treeView_MouseHover(object sender, EventArgs e)
        {
        }

        // Token: 0x0600009A RID: 154 RVA: 0x000022A9 File Offset: 0x000004A9
        private void treeView_MouseDown(object sender, MouseEventArgs e)
        {
        }

        // Token: 0x0600009B RID: 155 RVA: 0x000022A9 File Offset: 0x000004A9
        private void treeView_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
        }

        // Token: 0x0600009C RID: 156 RVA: 0x000023BF File Offset: 0x000005BF
        private void menuItem_4_Click(object sender, EventArgs e)
        {
            this.treeView.CollapseAll();
            if (this.IsLinux)
            {
                this.treeView.SelectedNode = this.treeView.TopNode;
            }
            else
            {
                this.method_2();
            }
        }

        // Token: 0x0600009D RID: 157 RVA: 0x000023F5 File Offset: 0x000005F5
        private void menuItem_3_Click(object sender, EventArgs e)
        {
            if (this.IsLinux)
            {
                this.FillLinuxDirectoryTree();
            }
            else
            {
                this.FillDosDirectoryTree();
            }
        }

        // Token: 0x0600009E RID: 158 RVA: 0x0000EB04 File Offset: 0x0000CD04
        public void MenuItemTreeViewAddDrive_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemTreeViewAddDrive_Click()");
            AddDriveDialog addDriveDialog = new AddDriveDialog(this.IsLinux);
            DialogResult dialogResult = addDriveDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                this.method_18("dialog.result: " + dialogResult.ToString());
            }
            else
            {
                this.method_18("Device: " + addDriveDialog.Device + " -- Directory: " + addDriveDialog.Directory);
                if (this.IsLinux)
                {
                    string text = addDriveDialog.Device + " " + addDriveDialog.Directory;
                    if (!text.EndsWith(DirFilePanel.char_0.ToString()))
                    {
                        text += DirFilePanel.char_0.ToString();
                    }
                    DirectoryNode directoryNode = new DirectoryNode(text);
                    this.treeView.BeginUpdate();
                    this.treeView.Nodes.Add(directoryNode);
                    if (!this.method_7(directoryNode, true))
                    {
                        this.treeView.Nodes.Remove(directoryNode);
                    }
                    else
                    {
                        this.treeView.SelectedNode = directoryNode;
                    }
                    this.treeView.EndUpdate();
                }
                else
                {
                    string text = addDriveDialog.Device + addDriveDialog.Directory;
                    DirectoryNode directoryNode = new DirectoryNode(text);
                    this.treeView.BeginUpdate();
                    this.treeView.Nodes.Add(directoryNode);
                    this.method_1(directoryNode);
                    this.treeView.SelectedNode = directoryNode;
                    this.treeView.EndUpdate();
                }
            }
        }

        // Token: 0x0600009F RID: 159 RVA: 0x00002410 File Offset: 0x00000610
        private void menuItem_17_Click(object sender, EventArgs e)
        {
            if (this.treeView.SelectedNode != null)
            {
                this.treeView.SelectedNode.Expand();
            }
        }

        // Token: 0x060000A0 RID: 160 RVA: 0x00002432 File Offset: 0x00000632
        private void menuItem_16_Click(object sender, EventArgs e)
        {
            if (this.treeView.SelectedNode != null)
            {
                this.treeView.SelectedNode.Collapse();
            }
        }

        // Token: 0x060000A1 RID: 161 RVA: 0x0000EC7C File Offset: 0x0000CE7C
        private void menuItem_22_Click(object sender, EventArgs e)
        {
            DirectoryNode directoryNode = (DirectoryNode)this.treeView.SelectedNode;
            while (directoryNode.Parent != null)
            {
                directoryNode = (DirectoryNode)this.treeView.SelectedNode.Parent;
                this.treeView.SelectedNode = directoryNode;
            }
            this.method_18("remove Drive: " + directoryNode.Text);
            this.treeView.BeginUpdate();
            this.treeView.SelectedNode.Remove();
            this.treeView.EndUpdate();
            this.listView.BeginUpdate();
            this.listView.Items.Clear();
            this.listView.EndUpdate();
        }

        // Token: 0x060000A2 RID: 162 RVA: 0x00002454 File Offset: 0x00000654
        private void MenuItemTreeViewNodeNew_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemTreeViewNodeNew_Click");
        }

        // Token: 0x060000A3 RID: 163 RVA: 0x00002461 File Offset: 0x00000661
        private void MenuItemTreeViewNodeModify_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemTreeViewNodeModify_Click");
        }

        // Token: 0x060000A4 RID: 164 RVA: 0x0000246E File Offset: 0x0000066E
        private void MenuItemTreeViewNodePaste_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemTreeViewNodePaste_Click");
        }

        // Token: 0x060000A5 RID: 165 RVA: 0x0000ED30 File Offset: 0x0000CF30
        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                try
                {
                    ListView listView = sender as ListView;
                    ListViewItemFile listViewItemFile = (ListViewItemFile)listView.SelectedItems[0];
                    if (listViewItemFile.IsError)
                    {
                        return;
                    }
                    if (listView.SelectedIndices.Count > 0)
                    {
                        if (listViewItemFile.IsDirectory)
                        {
                            this.method_18(string.Concat(new object[]
                            {
                                "ListView_DoubleClick() - isUSB: ",
                                this.bool_0,
                                ". Change Directory in TreeView to ",
                                listViewItemFile.Text,
                                " - (",
                                listViewItemFile.FullFilePath,
                                ")"
                            }));
                            this.method_13(listViewItemFile.Text);
                        }
                        else if (!LTOOLSnet.IsViewEditFile)
                        {
                            MessageBox.Show("Không cho phép xem và sửa nội dung file!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            this.StartLinuxApplication(listViewItemFile, true);
                        }
                    }
                    return;
                }
                catch (Exception ex)
                {
                    this.method_18(MyDebug.SeparatorLine + "ListView_DoubleClick\r\n" + ex.Message + MyDebug.SeparatorLine);
                    return;
                }
            }
            try
            {
                ListView listView = sender as ListView;
                if (listView.SelectedIndices.Count > 0)
                {
                    ListViewItemFile listViewItemFile = (ListViewItemFile)listView.SelectedItems[0];
                    if (listViewItemFile.IsDirectory)
                    {
                        this.method_18(string.Concat(new object[]
                        {
                            "ListView_DoubleClick() - isUSB: ",
                            this.bool_0,
                            ". Change Directory in TreeView to ",
                            listViewItemFile.Text
                        }));
                        this.method_13(listViewItemFile.Text);
                    }
                    else if (!LTOOLSnet.IsViewEditFile)
                    {
                        MessageBox.Show("Không cho phép xem và sửa nội dung file!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        this.StartDosApplication(listViewItemFile, true);
                    }
                }
            }
            catch (Exception ex)
            {
                this.method_18(MyDebug.SeparatorLine + "ListView_DoubleClick\r\n" + ex.Message + MyDebug.SeparatorLine);
            }
        }

        // Token: 0x060000A6 RID: 166 RVA: 0x0000EF34 File Offset: 0x0000D134
        private void listView_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    ListView listView = sender as ListView;
                    if (listView.SelectedItems.Count == 0)
                    {
                        this.menuItem_13.Checked = (this.listView.View == View.Details);
                        this.menuItem_11.Checked = (this.listView.View == View.LargeIcon);
                        this.menuItem_10.Checked = (this.listView.View == View.SmallIcon);
                        this.menuItem_12.Checked = (this.listView.View == View.List);
                        listView.ContextMenuStrip = this.docContextMenuStrip_1;
                    }
                    else if (this.bool_0)
                    {
                        ListView.SelectedListViewItemCollection selectedListViewItemFile = this.GetSelectedListViewItemFile();
                        foreach (object obj in selectedListViewItemFile)
                        {
                            ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                            if (listViewItemFile.IsError)
                            {
                                return;
                            }
                        }
                        listView.ContextMenuStrip = this.docContextMenuStrip_3;
                    }
                    else
                    {
                        listView.ContextMenuStrip = this.docContextMenuStrip_3;
                    }
                }
            }
            catch (Exception ex)
            {
                this.method_18("listView_MouseUP - catch\r\n" + ex.Message);
            }
        }

        // Token: 0x060000A7 RID: 167 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
        private void listView_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int num = 1;
                if (e.X > this.int_0 + 1 || e.Y > this.int_1 + num || e.X < this.int_0 - num || e.Y < this.int_1 - num)
                {
                    int count = ((ListView)sender).SelectedItems.Count;
                    ArrayList arrayList = new ArrayList();
                    ArrayList arrayList2 = new ArrayList();
                    ArrayList arrayList3 = new ArrayList();
                    ArrayList arrayList4 = new ArrayList();
                    ArrayList arrayList5 = new ArrayList();
                    int i = 0;
                    while (i < count)
                    {
                        if (((ListViewItemFile)((ListView)sender).SelectedItems[i]).IsDirectory)
                        {
                            if (!this.IsLinux)
                            {
                                long num2 = DCOPY.DirSize_files(((ListViewItemFile)((ListView)sender).SelectedItems[i]).FullFilePath) / 1000L;
                                string text = LTOOLSnet.USBInfo.Substring(12, LTOOLSnet.USBInfo.IndexOf("MB") - 12);
                                long num3 = Convert.ToInt64(text.Substring(0, text.IndexOf("."))) * 1000L;
                                if (num2 > num3 - 200000L)
                                {
                                    string text2 = "Dung lượng thư mục vượt quá dung lượng trống của USB!";
                                    MessageBox.Show(text2, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return;
                                }
                                long num4 = DCOPY.DirCount_files(((ListViewItemFile)((ListView)sender).SelectedItems[i]).FullFilePath);
                                if (num4 >= 150L)
                                {
                                    string text2 = "Số lượng file trong thư mục quá nhiều!";
                                    MessageBox.Show(text2, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return;
                                }
                                ArrayList arrayList6 = DCOPY.TraverseDOSTree(((ListViewItemFile)((ListView)sender).SelectedItems[i]).FullFilePath);
                                using (IEnumerator enumerator = arrayList6.GetEnumerator())
                                {
                                    while (enumerator.MoveNext())
                                    {
                                        object obj = enumerator.Current;
                                        FileInfo fileInfo = (FileInfo)obj;
                                        string value = fileInfo.DirectoryName.Replace(((ListViewItemFile)((ListView)sender).SelectedItems[i]).Directory, "");
                                        arrayList.Add(fileInfo.FullName);
                                        arrayList2.Add(fileInfo.Name);
                                        arrayList3.Add(fileInfo.Length);
                                        arrayList4.Add(((ListViewItemFile)((ListView)sender).SelectedItems[i]).FileName);
                                        arrayList5.Add(value);
                                    }
                                    goto IL_4C2;
                                }
                            }
                            string root = ((ListViewItemFile)((ListView)sender).SelectedItems[i]).Directory + UMD5.ConvertStringToHex(((ListViewItemFile)((ListView)sender).SelectedItems[i]).FileName, Encoding.Unicode) + "/";
                            ArrayList filesLinuxTree = this.GetFilesLinuxTree(root);
                            using (IEnumerator enumerator = filesLinuxTree.GetEnumerator())
                            {
                                while (enumerator.MoveNext())
                                {
                                    object obj2 = enumerator.Current;
                                    ListViewItemFile listViewItemFile = (ListViewItemFile)obj2;
                                    string text3 = UMD5.ConvertHexToString(listViewItemFile.FileName, Encoding.Unicode);
                                    string value2 = listViewItemFile.Directory + text3;
                                    arrayList.Add(value2);
                                    arrayList2.Add(text3);
                                    arrayList3.Add(listViewItemFile.FileSize);
                                    arrayList5.Add(listViewItemFile.Directory);
                                    arrayList4.Add(((ListViewItemFile)((ListView)sender).SelectedItems[i]).FileName);
                                }
                                goto IL_4C2;
                            }
                            goto IL_391;
                        }
                        goto IL_391;
                    IL_4C2:
                        i++;
                        continue;
                    IL_391:
                        if (((ListViewItemFile)((ListView)sender).SelectedItems[i]).IsLink)
                        {
                            string fullFilePath = ((ListViewItemFile)((ListView)sender).SelectedItems[i]).FullFilePath;
                            arrayList.Add(this.method_4(fullFilePath) + " " + this.GetFilePathFromLink(fullFilePath));
                            arrayList2.Add(this.GetFileNameFromLink(((ListViewItemFile)((ListView)sender).SelectedItems[i]).FileName));
                            goto IL_4C2;
                        }
                        if (!((ListViewItemFile)((ListView)sender).SelectedItems[i]).IsError)
                        {
                            arrayList.Add(((ListViewItemFile)((ListView)sender).SelectedItems[i]).FullFilePath);
                            arrayList2.Add(((ListViewItemFile)((ListView)sender).SelectedItems[i]).FileName);
                            arrayList3.Add(((ListViewItemFile)((ListView)sender).SelectedItems[i]).FileSize);
                            arrayList4.Add("");
                            arrayList5.Add("");
                            goto IL_4C2;
                        }
                        return;
                    }
                    LTOOLSnet.SetCopyFilePath(arrayList, arrayList2, arrayList3, arrayList5, arrayList4, this.IsLinux);
                    this.listView.DoDragDrop("LTOOLScopy", DragDropEffects.Copy);
                }
            }
        }

        // Token: 0x060000A8 RID: 168 RVA: 0x0000247B File Offset: 0x0000067B
        private void listView_MouseDown(object sender, MouseEventArgs e)
        {
            this.int_0 = e.X;
            this.int_1 = e.Y;
        }

        // Token: 0x060000A9 RID: 169 RVA: 0x0000F604 File Offset: 0x0000D804
        private void listView_DragDrop(object sender, DragEventArgs e)
        {
            this.method_18("ListView_DragDrop(): ");
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                if (e.Data.GetData(DataFormats.Text).ToString().Equals("LTOOLScopy"))
                {
                    this.method_18("source: " + e.Data.GetData(DataFormats.Text).ToString());
                    this.method_18("destination: " + this.method_12(this.GetSelectedDirectoryNode()));
                    if (this.IsLinux && this.GetSelectedDirectoryNode() != null)
                    {
                        this.PasteToLinux(this.GetSelectedDirectoryNode().Path, true);
                    }
                    else if (!this.IsLinux && this.GetSelectedDirectoryNode() != null)
                    {
                        this.PasteToDos(this.GetSelectedDirectoryNode().Path, true);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu không rõ định dạng", "UTools");
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                ArrayList arrayList = new ArrayList();
                ArrayList arrayList2 = new ArrayList();
                ArrayList arrayList3 = new ArrayList();
                ArrayList arrayList4 = new ArrayList();
                ArrayList arrayList5 = new ArrayList();
                ArrayList arrayList6 = new ArrayList();
                this.method_18("source: " + e.Data.GetData(DataFormats.FileDrop).ToString());
                string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
                string text = "";
                for (int i = 0; i < array.Length; i++)
                {
                    if (Directory.Exists(array[i]))
                    {
                        arrayList3.Add(array[i]);
                        text = text + array[i] + "\n";
                    }
                    else if (File.Exists(array[i]))
                    {
                        arrayList.Add(array[i]);
                        arrayList2.Add(new FileInfo(array[i]).Name);
                        arrayList4.Add(new FileInfo(array[i]).Length);
                        arrayList5.Add("");
                        arrayList6.Add("");
                    }
                    else
                    {
                        arrayList3.Add(array[i]);
                        text = text + array[i] + "\n";
                    }
                }
                if (arrayList3.Count > 0)
                {
                    if (arrayList.Count <= 0)
                    {
                        MessageBox.Show("Không copy được do file không tồn tại hoặc là thư mục:\n" + text, "UTools");
                        return;
                    }
                    if (MessageBox.Show("Không copy được nhiều file :\n" + text + "\nChỉ copy được file chọn cuối cùng?", "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return;
                    }
                }
                LTOOLSnet.SetCopyFilePath(arrayList, arrayList2, arrayList4, arrayList6, arrayList5, false);
                if (this.IsLinux)
                {
                    this.PasteToLinux(this.GetSelectedDirectoryNode().Path, true);
                }
                else
                {
                    this.PasteToDos(this.GetSelectedDirectoryNode().Path, true);
                }
                this.method_18("destination: " + this.method_12(this.GetSelectedDirectoryNode()));
            }
        }

        // Token: 0x060000AA RID: 170 RVA: 0x0000F91C File Offset: 0x0000DB1C
        private void listView_DragEnter(object sender, DragEventArgs e)
        {
            this.method_18("ListView_DragEnter() - IsUSB: " + this.IsLinux);
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
                this.method_18("DataFormats.Text");
            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                this.method_18("DataFormats.FileDrop");
            }
            else
            {
                e.Effect = DragDropEffects.None;
                this.method_18("DataFormats ?");
            }
        }

        // Token: 0x060000AB RID: 171 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
        public void ListView_KeyUp(object sender, KeyEventArgs e)
        {
            this.method_18("ListView_KeyUp()");
            if (e.Control && e.KeyCode == Keys.A)
            {
                ListView.ListViewItemCollection items = this.listView.Items;
                using (IEnumerator enumerator = items.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        object obj = enumerator.Current;
                        ListViewItem listViewItem = (ListViewItem)obj;
                        listViewItem.Selected = true;
                    }
                    return;
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                LTOOLSnet.MyProg.ListViewItemFilesDelete();
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.method_18("F5 pressed - refresh the ListView, IsUSB: " + this.IsLinux);
                if (this.IsLinux)
                {
                    this.UpdateLinuxListView(this.GetSelectedDirectoryNode());
                }
                else
                {
                    this.UpdateDosListView(this.GetSelectedDirectoryNode());
                }
            }
            else if (e.KeyCode == Keys.Return)
            {
                this.method_18("Return pressed - start an application, IsUSB: " + this.IsLinux);
                try
                {
                    ListView.SelectedListViewItemCollection selectedListViewItemFile = this.GetSelectedListViewItemFile();
                    if (selectedListViewItemFile.Count == 1)
                    {
                        ListViewItemFile listViewItemFile = (ListViewItemFile)selectedListViewItemFile[0];
                        if (listViewItemFile.IsDirectory)
                        {
                            this.method_13(listViewItemFile.Text);
                        }
                        else if (LTOOLSnet.IsViewEditFile && !this.IsLinux)
                        {
                            this.StartDosApplication(listViewItemFile, true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.method_18("Exception: " + ex.Message);
                }
            }
        }

        // Token: 0x060000AC RID: 172 RVA: 0x0000FB5C File Offset: 0x0000DD5C
        private void listView_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                ListViewItemFile listViewItemFile = (ListViewItemFile)((ListView)sender).SelectedItems[0];
                if (listViewItemFile.Text.Equals("..") || listViewItemFile.IsLink || listViewItemFile.IsError)
                {
                    e.CancelEdit = true;
                }
            }
            catch (Exception ex)
            {
                this.method_18(ex.Message);
            }
        }

        // Token: 0x060000AD RID: 173 RVA: 0x0000FBD4 File Offset: 0x0000DDD4
        private void listView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                bool flag = false;
                this.method_18("ListView_AfterLabelEdit()");
                ListViewItemFile listViewItemFile = (ListViewItemFile)((ListView)sender).SelectedItems[0];
                if (e.Label == null || e.Label.Equals("") || e.Label.IndexOf(DirFilePanel.char_0.ToString()) > 0)
                {
                    e.CancelEdit = true;
                    listViewItemFile.Text = listViewItemFile.FileName;
                }
                else
                {
                    string fullFilePath = listViewItemFile.FullFilePath;
                    string text = listViewItemFile.Directory;
                    if (this.IsLinux)
                    {
                        if (LTOOLSnet.IsLinuxReadOnly)
                        {
                            e.CancelEdit = true;
                            this.method_18("USBIsReadOnly");
                            MessageBox.Show("Ch!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (!listViewItemFile.FileName.Equals(e.Label))
                        {
                            flag = true;
                            if (!text.EndsWith(DirFilePanel.char_0.ToString()))
                            {
                                text = text + DirFilePanel.char_0.ToString() + e.Label;
                            }
                            else
                            {
                                text += e.Label;
                            }
                            string text2 = "ucom ";
                            string text3 = "-WRITE ";
                            text3 += "-ren ";
                            if (LTOOLSnet.Connected)
                            {
                                text3 += "-x ";
                            }
                            else
                            {
                                text3 += "-q ";
                            }
                            text3 += "-s";
                            text3 += listViewItemFile.FullFilePath;
                            text3 = text3 + " \"" + e.Label + "\"";
                            this.method_18("ListView_AfterLabelEdit(): " + text2 + text3);
                            ULDir uldir = new ULDir(text2, text3);
                            this.method_18(uldir.Response);
                            if (uldir.Response.Length > 0)
                            {
                                MessageBox.Show(uldir.Response, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                    }
                    else if (!listViewItemFile.FileName.Equals(e.Label))
                    {
                        flag = true;
                        if (!text.EndsWith(Path.DirectorySeparatorChar.ToString()))
                        {
                            text = text + Path.DirectorySeparatorChar.ToString() + e.Label;
                        }
                        else
                        {
                            text += e.Label;
                        }
                        this.method_18(string.Concat(new object[]
                        {
                            "IsUSB:",
                            this.IsLinux,
                            " - source: ",
                            fullFilePath,
                            " - destination:",
                            text
                        }));
                        if (listViewItemFile.IsDirectory)
                        {
                            Directory.Move(listViewItemFile.FullFilePath, text);
                        }
                        else
                        {
                            File.Move(listViewItemFile.FullFilePath, text);
                        }
                    }
                    if (flag)
                    {
                        this.UpdateNode(this.GetSelectedDirectoryNode());
                    }
                }
            }
            catch (Exception ex)
            {
                this.method_18(ex.Message);
            }
        }

        // Token: 0x060000AE RID: 174 RVA: 0x0000FEE0 File Offset: 0x0000E0E0
        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                if (this.sortOrder_0 == SortOrder.Ascending)
                {
                    this.sortOrder_0 = SortOrder.Descending;
                }
                else
                {
                    this.sortOrder_0 = SortOrder.Ascending;
                }
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < this.listView.Items.Count; i++)
                {
                    arrayList.Add(this.listView.Items[i]);
                }
                this.listView.BeginUpdate();
                this.listView.Clear();
                this.method_14();
                for (int i = arrayList.Count - 1; i >= 0; i--)
                {
                    this.listView.Items.Add((ListViewItemFile)arrayList[i]);
                }
                this.listView.EndUpdate();
            }
        }

        // Token: 0x060000AF RID: 175 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
        private string method_11(string string_0)
        {
            int num = string_0.LastIndexOf(".");
            int num2 = string_0.LastIndexOf(DirFilePanel.char_0.ToString());
            string result;
            if (num2 > 0 && num2 > num)
            {
                result = "";
            }
            else
            {
                result = string_0.Substring(num);
            }
            return result;
        }

        // Token: 0x060000B0 RID: 176 RVA: 0x00010004 File Offset: 0x0000E204
        public void CopyModifiedFile_K(ListViewItemFile ModFile)
        {
            this.method_18("LTOOLSnet.CopyModifiedFile");
            string text = DirFilePanel.tempPathLinuxFiles + "\\" + ModFile.FileName;
            string fullFilePath = ModFile.FullFilePath;
            this.method_18("CopyModifiedFile(): source: " + text + " - destination: " + fullFilePath);
            if (!LTOOLSnet.IsLinuxReadOnly)
            {
                string text2 = "ucom";
                string text3;
                if (!LTOOLSnet.Connected)
                {
                    text3 = string.Concat(new string[]
                    {
                        "-WRITE -q -s",
                        this.method_0(),
                        " -copy \"",
                        text,
                        "\" \"",
                        this.method_5(fullFilePath),
                        "\""
                    });
                }
                else
                {
                    this.method_17(text);
                    text3 = "-WRITE -x -s" + this.method_0() + " -copy zzz.xxx  \"" + this.method_5(fullFilePath);
                }
                this.method_18(string.Concat(new object[]
                {
                    "CopyModifiedFile()-WRITE DosToLinux:",
                    text2,
                    " ",
                    text3,
                    " - connected: ",
                    LTOOLSnet.Connected
                }));
                ULDir uldir;
                if (LTOOLSnet.Connected)
                {
                    uldir = new ULDir(text2, text3, LTOOLSnet.NetSocket);
                }
                else
                {
                    uldir = new ULDir(text2, text3);
                }
                if (uldir.Response.Length > 0)
                {
                    MessageBox.Show(uldir.Response.Trim(), "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    this.UpdateNode(this.GetSelectedDirectoryNode());
                }
            }
        }

        // Token: 0x060000B1 RID: 177 RVA: 0x00010184 File Offset: 0x0000E384
        public void CopyModifiedFile_B(ListViewItemFile ModFile)
        {
            try
            {
                this.method_18("LTOOLSnet.CopyModifiedFile");
                string text = DirFilePanel.tempPathLinuxFiles + "\\" + ModFile.FileName;
                string text2 = DirFilePanel.tempPathLinuxFiles + "\\zzz_xxx_" + ModFile.FileName;
                string fullFilePath = ModFile.FullFilePath;
                this.method_18("CopyModifiedFile(): source: " + text + " - destination: " + fullFilePath);
                string text3 = ModFile.FileSize.ToString();
                text3 = text3.Replace(",", "");
                text3 = text3.Replace(".", "");
                usbpublic.FILE_SIZE = Convert.ToInt64(text3);
                this.method_18("PasteToUSB(): source: " + text + " - destination: " + fullFilePath);
                if (LTOOLSnet.IsLinuxReadOnly)
                {
                    MessageBox.Show("Hệ thống đã kích hoạt tính năng chống ghi USB.", "USBTOOLS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string text4 = "ucom";
                    string text8;
                    if (!LTOOLSnet.Connected)
                    {
                        string text5 = UMD5.ConvertStringToHex(ModFile.FileName, Encoding.Unicode);
                        string text6 = DirFilePanel.tempPathLinuxFiles + "\\" + text5;
                        string string_ = ModFile.Directory + text5;
                        string text7 = this.method_4(ModFile.FullFilePath);
                        if (Convert.ToInt64(text3) > 104857600L)
                        {
                            MessageBox.Show("Không Edit file có kích thước quá 100MB.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if (LTOOLSnet.IsEncryptFile)
                        {
                            if (Convert.ToInt64(text3) > 104857600L)
                            {
                                if (UMD5.IsVietnamFileName(ModFile.FileName))
                                {
                                    MessageBox.Show("Tên file không hợp lệ!", "USBTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return;
                                }
                                text8 = string.Concat(new string[]
                                {
                                    "-WRITE -q -s",
                                    text7,
                                    " -copy \"",
                                    text,
                                    "\" \"",
                                    this.method_5(fullFilePath),
                                    "\""
                                });
                            }
                            else
                            {
                                string key_FORMAT = usbpublic.KEY_FORMAT;
                                File.Copy(text, text2, true);
                                UMD5.EncryptFile(text2, text6, key_FORMAT, false);
                                text8 = string.Concat(new string[]
                                {
                                    "-WRITE -q -s",
                                    text7,
                                    " -copy \"",
                                    text6,
                                    "\" \"",
                                    this.method_5(string_),
                                    "\""
                                });
                            }
                        }
                        else
                        {
                            text8 = string.Concat(new string[]
                            {
                                "-WRITE -q -s",
                                text7,
                                " -copy \"",
                                text,
                                "\" \"",
                                this.method_5(fullFilePath),
                                "\""
                            });
                        }
                    }
                    else
                    {
                        this.method_17(text);
                        text8 = string.Concat(new string[]
                        {
                            "-WRITE -x -s",
                            this.method_0(),
                            " -copy zzz.xxx  \"",
                            this.method_5(fullFilePath),
                            "\""
                        });
                    }
                    this.method_18(string.Concat(new object[]
                    {
                        "PasteToUSB()-WRITE DosToUSB:",
                        text4,
                        " ",
                        text8,
                        " - connected: ",
                        LTOOLSnet.Connected
                    }));
                    ULDir uldir;
                    if (LTOOLSnet.Connected)
                    {
                        uldir = new ULDir(text4, text8, LTOOLSnet.NetSocket);
                    }
                    else
                    {
                        uldir = new ULDir(text4, text8);
                    }
                    if (uldir.Response.Length > 0)
                    {
                        MessageBox.Show("Edit file error.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        this.UpdateNode(this.GetSelectedDirectoryNode());
                    }
                }
            }
            catch
            {
            }
        }

        // Token: 0x060000B2 RID: 178 RVA: 0x00010540 File Offset: 0x0000E740
        public void UpdateOpenedFiles(ArrayList OpenedFiles)
        {
            try
            {
                this.method_18("DeleteOpenedFiles()");
                bool flag = false;
                if (LTOOLSnet.IsLinuxReadOnly)
                {
                    this.method_18("LinuxIsReadOnly");
                }
                else
                {
                    for (int i = 0; i < OpenedFiles.Count; i++)
                    {
                        ListViewItemFile listViewItemFile = (ListViewItemFile)OpenedFiles[i];
                        if (!listViewItemFile.IsError && !listViewItemFile.FileName.Equals(".."))
                        {
                            string fullFilePath = listViewItemFile.FullFilePath;
                            if (File.Exists(DirFilePanel.tempPathLinuxFiles + "\\" + listViewItemFile.FileName) && !(listViewItemFile.m_LastModified == File.GetLastWriteTime(DirFilePanel.tempPathLinuxFiles + "\\" + listViewItemFile.FileName)))
                            {
                                listViewItemFile.m_LastModified = File.GetLastWriteTime(DirFilePanel.tempPathLinuxFiles + "\\" + listViewItemFile.FileName);
                                this.method_18("DeleteOpenedFile(): " + fullFilePath);
                                flag = true;
                                string text = "ucom";
                                string text2;
                                if (listViewItemFile.IsLink)
                                {
                                    text2 = this.method_5(this.method_10(fullFilePath));
                                }
                                else
                                {
                                    text2 = this.method_5(fullFilePath);
                                }
                                ULDir uldir;
                                if (LTOOLSnet.Connected)
                                {
                                    string text3 = string.Concat(new string[]
                                    {
                                        "-WRITE -del -q -s",
                                        this.method_4(fullFilePath),
                                        " \"",
                                        text2,
                                        "\""
                                    });
                                    this.method_18(text + " " + text3);
                                    uldir = new ULDir(text, text3, LTOOLSnet.NetSocket);
                                }
                                else
                                {
                                    text2 = this.method_5(listViewItemFile.Directory + UMD5.ConvertStringToHex(listViewItemFile.FileName, Encoding.Unicode));
                                    string text3 = string.Concat(new string[]
                                    {
                                        "-WRITE -del -q -s",
                                        this.method_4(fullFilePath),
                                        " \"",
                                        text2,
                                        "\""
                                    });
                                    this.method_18(text + " " + text3);
                                    uldir = new ULDir(text, text3);
                                }
                                this.method_18("DeleteLinuxFile 1>>>" + uldir.Response + "<<<");
                                if (uldir.Response.Length > 0)
                                {
                                    return;
                                }
                                this.CopyModifiedFile_B(listViewItemFile);
                            }
                        }
                    }
                    if (flag)
                    {
                        DirectoryNode selectedDirectoryNode = this.GetSelectedDirectoryNode();
                        this.UpdateNode(selectedDirectoryNode);
                    }
                }
            }
            catch
            {
            }
        }

        // Token: 0x060000B3 RID: 179 RVA: 0x00002495 File Offset: 0x00000695
        private void menuItem_13_Click(object sender, EventArgs e)
        {
            this.UpdateViewStyle(View.Details);
        }

        // Token: 0x060000B4 RID: 180 RVA: 0x0000249E File Offset: 0x0000069E
        private void menuItem_12_Click(object sender, EventArgs e)
        {
            this.UpdateViewStyle(View.List);
        }

        // Token: 0x060000B5 RID: 181 RVA: 0x000024A7 File Offset: 0x000006A7
        private void menuItem_11_Click(object sender, EventArgs e)
        {
            this.UpdateViewStyle(View.LargeIcon);
        }

        // Token: 0x060000B6 RID: 182 RVA: 0x000024B0 File Offset: 0x000006B0
        private void menuItem_10_Click(object sender, EventArgs e)
        {
            this.UpdateViewStyle(View.SmallIcon);
        }

        // Token: 0x060000B7 RID: 183 RVA: 0x000107C4 File Offset: 0x0000E9C4
        private void MenuItemListViewNew_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewNew_Click");
            DirectoryNode selectedDirectoryNode;
            if ((selectedDirectoryNode = this.GetSelectedDirectoryNode()) == null)
            {
                MessageBox.Show("Chọn thư mục chứa thư mục mới", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.IsLinux)
            {
                this.NewLinuxDirectory(selectedDirectoryNode);
            }
            else
            {
                this.NewDosDirectory(selectedDirectoryNode);
            }
        }

        // Token: 0x060000B8 RID: 184 RVA: 0x000024B9 File Offset: 0x000006B9
        private void menuItem_15_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewPaste_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesPaste();
            LTOOLSnet.CutSelected = false;
        }

        // Token: 0x060000B9 RID: 185 RVA: 0x000024D6 File Offset: 0x000006D6
        private void menuItem_5_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewItemModify_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesModify();
        }

        // Token: 0x060000BA RID: 186 RVA: 0x000024ED File Offset: 0x000006ED
        private void menuItem_6_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewItemDelete_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesDelete();
        }

        // Token: 0x060000BB RID: 187 RVA: 0x00002504 File Offset: 0x00000704
        private void menuItem_7_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewItemCopy_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesCopy();
        }

        // Token: 0x060000BC RID: 188 RVA: 0x0000251B File Offset: 0x0000071B
        private void menuItem_8_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewItemView_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesView();
        }

        // Token: 0x060000BD RID: 189 RVA: 0x0001081C File Offset: 0x0000EA1C
        private string method_12(TreeNode treeNode_0)
        {
            string result;
            if (treeNode_0.Parent == null)
            {
                result = treeNode_0.Text;
            }
            else
            {
                string text = Path.Combine(this.method_12(treeNode_0.Parent), treeNode_0.Text);
                if (this.bool_0)
                {
                    string path = UMD5.ConvertStringToHex(treeNode_0.Text, Encoding.Unicode);
                    text = Path.Combine(this.method_12(treeNode_0.Parent), path);
                    text.Replace(Path.DirectorySeparatorChar, DirFilePanel.char_0);
                    text += "/";
                }
                result = text;
            }
            return result;
        }

        // Token: 0x060000BE RID: 190 RVA: 0x000108A8 File Offset: 0x0000EAA8
        public DirectoryNode GetSelectedDirectoryNode()
        {
            return (DirectoryNode)this.treeView.SelectedNode;
        }

        // Token: 0x060000BF RID: 191 RVA: 0x000108C8 File Offset: 0x0000EAC8
        public void UpdateNode(DirectoryNode node)
        {
            node.Collapse();
            node.Nodes.Clear();
            node.SubDirectoriesAdded = false;
            if (this.IsLinux)
            {
                this.method_7(node, true);
                node.Expand();
                this.UpdateLinuxListView(node);
            }
            else
            {
                this.method_1(node);
                node.Expand();
                this.UpdateDosListView(node);
            }
        }

        // Token: 0x060000C0 RID: 192 RVA: 0x00010924 File Offset: 0x0000EB24
        private void method_13(string string_0)
        {
            this.method_18("ChangeDirectoryInTreeView() to " + string_0);
            if (string_0.Equals(".."))
            {
                if (this.treeView.SelectedNode.Parent != null)
                {
                    this.treeView.SelectedNode = this.treeView.SelectedNode.Parent;
                }
            }
            else
            {
                int index = 0;
                for (int i = 0; i < this.treeView.SelectedNode.Nodes.Count; i++)
                {
                    if (this.treeView.SelectedNode.Nodes[i].Text == string_0)
                    {
                        index = i;
                    }
                }
                this.treeView.SelectedNode = this.treeView.SelectedNode.Nodes[index];
            }
        }

        // Token: 0x060000C1 RID: 193 RVA: 0x000109F4 File Offset: 0x0000EBF4
        public Color GetBackColorTreeView()
        {
            return this.treeView.BackColor;
        }

        // Token: 0x060000C2 RID: 194 RVA: 0x00002532 File Offset: 0x00000732
        public void UpdateViewStyle(View icon)
        {
            this.ViewListView = icon;
            this.listView.View = this.ViewListView;
        }

        // Token: 0x060000C3 RID: 195 RVA: 0x00010A10 File Offset: 0x0000EC10
        public ListView.SelectedListViewItemCollection GetSelectedListViewItemFile()
        {
            ListView.SelectedListViewItemCollection result;
            if (this.listView.SelectedIndices.Count > 0)
            {
                result = this.listView.SelectedItems;
            }
            else
            {
                result = null;
            }
            return result;
        }

        // Token: 0x060000C4 RID: 196 RVA: 0x00010A48 File Offset: 0x0000EC48
        private void method_14()
        {
            this.listView.Columns.Add(this.columnHeader_0);
            this.listView.Columns.Add(this.columnHeader_1);
            this.listView.Columns.Add(this.columnHeader_2);
            this.listView.Columns.Add(this.columnHeader_3);
            if (!this.IsLinux)
            {
            }
        }

        // Token: 0x060000C5 RID: 197 RVA: 0x00010ABC File Offset: 0x0000ECBC
        private void method_15(string string_0, ArrayList arrayList_0, ArrayList arrayList_1)
        {
            try
            {
                this.listView.Clear();
                this.listView.View = this.view_0;
                this.method_14();
                this.columnHeader_0.Text = string.Concat(new string[]
                {
                    "Name   [",
                    arrayList_0.Count.ToString(),
                    " Directories], [",
                    arrayList_1.Count.ToString(),
                    " Files]"
                });
                arrayList_0.Sort();
                arrayList_1.Sort();
                if (this.sortOrder_0 == SortOrder.Ascending)
                {
                    if (this.treeView.SelectedNode.Parent != null)
                    {
                        ListViewItemFile listViewItemFile = new ListViewItemFile("..", DirFilePanel.IndexIconFolderUp, true);
                        listViewItemFile.FileName = "..";
                        listViewItemFile.Directory = string_0;
                        listViewItemFile.FullFilePath = string_0;
                        this.listView.Items.Add(listViewItemFile);
                    }
                    foreach (object obj in arrayList_0)
                    {
                        ListViewItemFile value = (ListViewItemFile)obj;
                        this.listView.Items.Add(value);
                    }
                    using (IEnumerator enumerator = arrayList_1.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            object obj2 = enumerator.Current;
                            ListViewItemFile value2 = (ListViewItemFile)obj2;
                            this.listView.Items.Add(value2);
                        }
                        goto IL_25A;
                    }
                }
                if (this.sortOrder_0 == SortOrder.Descending)
                {
                    for (int i = arrayList_1.Count - 1; i >= 0; i--)
                    {
                        ListViewItemFile value2 = (ListViewItemFile)arrayList_1[i];
                        this.listView.Items.Add(value2);
                    }
                    for (int i = arrayList_0.Count - 1; i >= 0; i--)
                    {
                        ListViewItemFile value = (ListViewItemFile)arrayList_0[i];
                        this.listView.Items.Add(value);
                    }
                    if (this.treeView.SelectedNode.Parent != null)
                    {
                        ListViewItemFile listViewItemFile = new ListViewItemFile("..", DirFilePanel.IndexIconFolderUp, true);
                        listViewItemFile.FileName = "..";
                        listViewItemFile.Directory = string_0;
                        listViewItemFile.FullFilePath = string_0;
                        this.listView.Items.Add(listViewItemFile);
                    }
                }
            IL_25A:;
            }
            catch (Exception ex)
            {
                this.method_18(string.Concat(new object[]
                {
                    MyDebug.SeparatorLine,
                    "updateListView() Exception - isUSB: ",
                    this.bool_0,
                    "\r\n",
                    ex.Message,
                    MyDebug.SeparatorLine
                }));
                this.listView.Items.Clear();
                this.listView.View = View.Details;
                this.listView.Items.Add(ex.Message.Replace("\r\n", " "));
            }
        }

        // Token: 0x060000C6 RID: 198 RVA: 0x00010E10 File Offset: 0x0000F010
        private void method_16(string string_0)
        {
            this.method_18("GetFileFromHost: " + string_0);
            byte[] array = new byte[LTOOLSnet.BUFSIZE];
            try
            {
                string s = "SENDFILE\n";
                Encoding ascii = Encoding.ASCII;
                byte[] bytes = ascii.GetBytes(s);
                LTOOLSnet.NetSocket.Send(bytes, bytes.Length, SocketFlags.None);
                this.method_18("GetFileFromHost(): send-ok");
                int num = LTOOLSnet.NetSocket.Receive(array, array.Length, SocketFlags.None);
                string @string = ascii.GetString(array, 0, num);
                int num2 = int.Parse(@string);
                this.method_18(string.Concat(new string[]
                {
                    "Receive1-ok Bytes: ",
                    num.ToString(),
                    " : --",
                    @string,
                    "--"
                }));
                FileStream fileStream = new FileStream(DirFilePanel.tempPathLinuxFiles + "\\" + string_0, FileMode.Create, FileAccess.Write);
                int i = 0;
                while (i < num2)
                {
                    num = LTOOLSnet.NetSocket.Receive(array, array.Length, SocketFlags.None);
                    this.method_18(string.Concat(new object[]
                    {
                        "bytesRead: ",
                        i,
                        " bytesToRead",
                        num2,
                        " i:",
                        num
                    }));
                    i += num;
                    fileStream.Write(array, 0, num);
                }
                fileStream.Close();
            }
            catch (IOException ex)
            {
                this.method_18("Failed I/O " + ex.Message);
            }
            catch (Exception ex2)
            {
                this.method_18(ex2.Message ?? "");
            }
        }

        // Token: 0x060000C7 RID: 199 RVA: 0x00010FE4 File Offset: 0x0000F1E4
        private void method_17(string string_0)
        {
            this.method_18("PutFileToHost(" + string_0 + ")");
            int num = 0;
            byte[] buffer = new byte[LTOOLSnet.BUFSIZE];
            try
            {
                FileInfo fileInfo = new FileInfo(string_0);
                string str = fileInfo.Length.ToString();
                FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
                string s = "RECEIVEFILE\n" + str + "\n";
                Encoding ascii = Encoding.ASCII;
                byte[] bytes = ascii.GetBytes(s);
                LTOOLSnet.NetSocket.Send(bytes, bytes.Length, SocketFlags.None);
                int num2;
                do
                {
                    num2 = fileStream.Read(buffer, 0, LTOOLSnet.BUFSIZE);
                    if (num2 < 0)
                    {
                        break;
                    }
                    LTOOLSnet.NetSocket.Send(buffer, num2, SocketFlags.None);
                    num += num2;
                }
                while (num2 > 0);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                this.method_18("Exception PutFileToHost(): " + ex.Message);
            }
        }

        // Token: 0x060000C8 RID: 200 RVA: 0x0000254C File Offset: 0x0000074C
        public void SetBackground(Color col)
        {
            this.treeView.BackColor = col;
            this.listView.BackColor = col;
        }

        // Token: 0x060000C9 RID: 201 RVA: 0x00002566 File Offset: 0x00000766
        public void SetDebugDialog(MyDebug dDialog)
        {
            DirFilePanel.debugDialog = dDialog;
        }

        // Token: 0x060000CA RID: 202 RVA: 0x0000256E File Offset: 0x0000076E
        private void method_18(string string_0)
        {
            if (DirFilePanel.debugDialog != null)
            {
                DirFilePanel.debugDialog.AppendText(string_0 + "\r\n");
            }
        }

        // Token: 0x060000CB RID: 203 RVA: 0x0000258F File Offset: 0x0000078F
        public void SetPropertiesDialog(frmProperties dDialog)
        {
            DirFilePanel.fProperties = dDialog;
        }

        // Token: 0x060000CC RID: 204 RVA: 0x00002597 File Offset: 0x00000797
        private void method_19(string string_0)
        {
            DirFilePanel.fProperties = new frmProperties();
        }

        // Token: 0x060000CD RID: 205 RVA: 0x000023F5 File Offset: 0x000005F5
        private void formatContextMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsLinux)
            {
                this.FillLinuxDirectoryTree();
            }
            else
            {
                this.FillDosDirectoryTree();
            }
        }

        // Token: 0x060000CE RID: 206 RVA: 0x000022A9 File Offset: 0x000004A9
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x060000CF RID: 207 RVA: 0x000022A9 File Offset: 0x000004A9
        private void contextMenu_2_Popup(object sender, EventArgs e)
        {
        }

        // Token: 0x060000D0 RID: 208 RVA: 0x00002454 File Offset: 0x00000654
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemTreeViewNodeNew_Click");
        }

        // Token: 0x060000D1 RID: 209 RVA: 0x00002461 File Offset: 0x00000661
        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemTreeViewNodeModify_Click");
        }

        // Token: 0x060000D2 RID: 210 RVA: 0x0000246E File Offset: 0x0000066E
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemTreeViewNodePaste_Click");
        }

        // Token: 0x060000D3 RID: 211 RVA: 0x000107C4 File Offset: 0x0000E9C4
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewNew_Click");
            DirectoryNode selectedDirectoryNode;
            if ((selectedDirectoryNode = this.GetSelectedDirectoryNode()) == null)
            {
                MessageBox.Show("Chọn thư mục chứa thư mục mới", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.IsLinux)
            {
                this.NewLinuxDirectory(selectedDirectoryNode);
            }
            else
            {
                this.NewDosDirectory(selectedDirectoryNode);
            }
        }

        // Token: 0x060000D4 RID: 212 RVA: 0x000025A3 File Offset: 0x000007A3
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewPaste_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesPaste();
        }

        // Token: 0x060000D5 RID: 213 RVA: 0x000024B0 File Offset: 0x000006B0
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.UpdateViewStyle(View.SmallIcon);
        }

        // Token: 0x060000D6 RID: 214 RVA: 0x000024A7 File Offset: 0x000006A7
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.UpdateViewStyle(View.LargeIcon);
        }

        // Token: 0x060000D7 RID: 215 RVA: 0x0000249E File Offset: 0x0000069E
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.UpdateViewStyle(View.List);
        }

        // Token: 0x060000D8 RID: 216 RVA: 0x00002495 File Offset: 0x00000695
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.UpdateViewStyle(View.Details);
        }

        // Token: 0x060000D9 RID: 217 RVA: 0x000024D6 File Offset: 0x000006D6
        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewItemModify_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesModify();
        }

        // Token: 0x060000DA RID: 218 RVA: 0x000024ED File Offset: 0x000006ED
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewItemDelete_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesDelete();
        }

        // Token: 0x060000DB RID: 219 RVA: 0x00002504 File Offset: 0x00000704
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewItemCopy_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesCopy();
        }

        // Token: 0x060000DC RID: 220 RVA: 0x0000251B File Offset: 0x0000071B
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewItemView_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesView();
        }

        // Token: 0x060000DD RID: 221 RVA: 0x000022A9 File Offset: 0x000004A9
        private void docContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
        }

        // Token: 0x060000DE RID: 222 RVA: 0x000110DC File Offset: 0x0000F2DC
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsLinux)
            {
                this.method_18("The USBPanel is active.");
                DirectoryNode selectedDirectoryNode = this.GetSelectedDirectoryNode();
                this.UpdateNode(selectedDirectoryNode);
            }
            else
            {
                this.method_18("The DOSPanel is active.");
                DirectoryNode selectedDirectoryNode = this.GetSelectedDirectoryNode();
                this.UpdateNode(selectedDirectoryNode);
            }
        }

        // Token: 0x060000DF RID: 223 RVA: 0x000022A9 File Offset: 0x000004A9
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x060000E0 RID: 224 RVA: 0x000022A9 File Offset: 0x000004A9
        private void timer_0_Tick(object sender, EventArgs e)
        {
        }

        // Token: 0x060000E1 RID: 225 RVA: 0x000022A9 File Offset: 0x000004A9
        private void splitter_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        // Token: 0x060000E2 RID: 226 RVA: 0x000025BA File Offset: 0x000007BA
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.method_18("MenuItemListViewItemCopy_Click()");
            LTOOLSnet.MyProg.ListViewItemFilesCopy();
            LTOOLSnet.CutSelected = true;
        }

        // Token: 0x060000E3 RID: 227 RVA: 0x00011128 File Offset: 0x0000F328
        private void toolStripMenu_Properties_Click(object sender, EventArgs e)
        {
            string text = "";
            string sFilesCount = "";
            string sDirCount = "";
            ListView.SelectedListViewItemCollection selectedListViewItemFile;
            if (this.IsLinux)
            {
                selectedListViewItemFile = this.GetSelectedListViewItemFile();
                if (selectedListViewItemFile.Count > 1)
                {
                    MessageBox.Show("Chỉ xem thông tin của 1 file/thu mục", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (selectedListViewItemFile == null)
                {
                    return;
                }
                using (IEnumerator enumerator = selectedListViewItemFile.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        object obj = enumerator.Current;
                        ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                        if (!listViewItemFile.IsDirectory)
                        {
                            string text2 = listViewItemFile.FileSize.ToString();
                            text2 = text2.Replace(",", "");
                            text2 = text2.Replace(".", "");
                            text2 = text2.Replace(" ", "");
                            double num = (double)Convert.ToInt64(text2);
                            string[] array = this.method_6(listViewItemFile.FullFilePath, listViewItemFile.FileName).Split(new char[]
                            {
                                '/'
                            });
                            for (int i = 0; i < array.Length; i++)
                            {
                                if (array[i].Length > 0)
                                {
                                    text = text + UMD5.ConvertHexToString(array[i].ToString(), Encoding.Unicode) + "\\";
                                }
                            }
                            text += listViewItemFile.FileName;
                            string sSize = string.Format("{0:0,0}", num);
                            string fileLastModified = listViewItemFile.FileLastModified;
                            string sTime = fileLastModified;
                            frmProperties frmProperties = new frmProperties();
                            frmProperties.Show();
                            frmProperties.ShowInfor(text, sSize, sTime, sFilesCount, sDirCount);
                        }
                        else
                        {
                            string[] array = this.method_6(listViewItemFile.FullFilePath, listViewItemFile.FileName).Split(new char[]
                            {
                                '/'
                            });
                            for (int i = 0; i < array.Length; i++)
                            {
                                if (array[i].Length > 0)
                                {
                                    text = text + UMD5.ConvertHexToString(array[i].ToString(), Encoding.Unicode) + "\\";
                                }
                            }
                            text += listViewItemFile.FileName;
                            string str = listViewItemFile.Directory + UMD5.ConvertStringToHex(listViewItemFile.FileName, Encoding.Unicode);
                            string sSize = string.Format("{0:0,0}", Convert.ToInt64(this.GetLinuxDirSize(str + "/")));
                            string sTime = listViewItemFile.FileLastModified;
                            frmProperties frmProperties = new frmProperties();
                            frmProperties.Show();
                            frmProperties.ShowInfor(text, sSize, sTime, sFilesCount, sDirCount);
                        }
                    }
                    return;
                }
            }
            selectedListViewItemFile = this.GetSelectedListViewItemFile();
            if (selectedListViewItemFile.Count > 1)
            {
                MessageBox.Show("Chỉ xem thông tin của 1 file/thu mục", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (selectedListViewItemFile != null)
            {
                foreach (object obj2 in selectedListViewItemFile)
                {
                    ListViewItemFile listViewItemFile = (ListViewItemFile)obj2;
                    if (!listViewItemFile.IsDirectory)
                    {
                        text = listViewItemFile.FullFilePath;
                        string sSize = string.Format("{0:0,0}", Convert.ToInt64(listViewItemFile.FileSize));
                        string sTime = listViewItemFile.FileLastModified;
                        frmProperties frmProperties = new frmProperties();
                        frmProperties.Show();
                        frmProperties.ShowInfor(text, sSize, sTime, sFilesCount, sDirCount);
                    }
                    else
                    {
                        text = listViewItemFile.FullFilePath;
                        string sSize = string.Format("{0:0,0}", DCOPY.DirSize_All(listViewItemFile.Directory));
                        string sTime = listViewItemFile.FileLastModified;
                        frmProperties frmProperties = new frmProperties();
                        frmProperties.Show();
                        frmProperties.ShowInfor(text, sSize, sTime, sFilesCount, sDirCount);
                    }
                }
            }
        }

        // Token: 0x060000E4 RID: 228 RVA: 0x00011530 File Offset: 0x0000F730
        private void btlSearch_Click(object sender, EventArgs e)
        {
            string sFilesCount = "";
            string sDirCount = "";
            if (this.IsLinux)
            {
                DirectoryNode selectedDirectoryNode = this.GetSelectedDirectoryNode();
                ArrayList arrayList_ = new ArrayList();
                ArrayList arrayList = new ArrayList();
                arrayList = this.SearchLinuxFileInDir(selectedDirectoryNode.Path, this.txtSearch.Text);
                string string_ = this.method_4(selectedDirectoryNode.FullPath);
                if (arrayList.Count > 0)
                {
                    this.method_15(string_, arrayList_, arrayList);
                }
            }
            else
            {
                ListView.SelectedListViewItemCollection selectedListViewItemFile = this.GetSelectedListViewItemFile();
                if (selectedListViewItemFile == null || selectedListViewItemFile.Count > 1)
                {
                    MessageBox.Show("Chỉ xem thông tin của 1 file/thu mục", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (selectedListViewItemFile != null)
                {
                    foreach (object obj in selectedListViewItemFile)
                    {
                        ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                        if (!listViewItemFile.IsDirectory)
                        {
                            string fullFilePath = listViewItemFile.FullFilePath;
                            string sSize = string.Format("{0:0,0}", Convert.ToInt64(listViewItemFile.FileSize));
                            string fileLastModified = listViewItemFile.FileLastModified;
                            frmProperties frmProperties = new frmProperties();
                            frmProperties.Show();
                            frmProperties.ShowInfor(fullFilePath, sSize, fileLastModified, sFilesCount, sDirCount);
                        }
                        else
                        {
                            string fullFilePath = listViewItemFile.FullFilePath;
                            string sSize = string.Format("{0:0,0}", DCOPY.DirSize_All(listViewItemFile.Directory));
                            string fileLastModified = listViewItemFile.FileLastModified;
                            frmProperties frmProperties = new frmProperties();
                            frmProperties.Show();
                            frmProperties.ShowInfor(fullFilePath, sSize, fileLastModified, sFilesCount, sDirCount);
                        }
                    }
                }
            }
        }

        // Token: 0x060000E5 RID: 229 RVA: 0x000116F8 File Offset: 0x0000F8F8
        static DirFilePanel()
        {
            Class3.vd4OXo2zYFEgU();
            DirFilePanel.char_0 = '/';
            DirFilePanel.tempPathLinuxFiles = LTOOLSnet.GUIDirectory + "temp";
            DirFilePanel.IndexIconFolder = 0;
            DirFilePanel.IndexIconFolderL = 0;
            DirFilePanel.IndexIconFile = 1;
            DirFilePanel.IndexIconBitmap = 2;
            DirFilePanel.IndexIconPdf = 3;
            DirFilePanel.IndexIconHtml = 4;
            DirFilePanel.IndexIconAvi = 5;
            DirFilePanel.IndexIconMp3 = 6;
            DirFilePanel.IndexIconLink = 7;
            DirFilePanel.IndexIconFolderUp = 8;
            DirFilePanel.IndexIconError = 9;
            DirFilePanel.IndexIconAccess = 10;
            DirFilePanel.IndexIconExcel = 11;
            DirFilePanel.IndexIconWord = 12;
            DirFilePanel.IndexIconPowerPoint = 13;
            DirFilePanel.IndexIconExe = 14;
            DirFilePanel.IndexIconJava = 15;
            DirFilePanel.IndexIconFolderBack = 18;
            DirFilePanel.IndexIconZip = 16;
            DirFilePanel.IndexIconEncrypt = 17;
        }

        // Token: 0x0400002C RID: 44
        public const int Folder = 7;

        // Token: 0x0400002D RID: 45
        public const int FolderOpened = 8;

        // Token: 0x0400002E RID: 46
        private ListView listView;

        // Token: 0x0400002F RID: 47
        private TreeView treeView;

        // Token: 0x04000030 RID: 48
        private Panel panelDirLabel;

        // Token: 0x04000031 RID: 49
        private Panel panelComplete;

        // Token: 0x04000032 RID: 50
        private Panel panelTreeList;

        // Token: 0x04000033 RID: 51
        private Splitter splitter;

        // Token: 0x04000034 RID: 52
        private Label labelDirectory;

        // Token: 0x04000035 RID: 53
        private ContextMenu contextMenu_0;

        // Token: 0x04000036 RID: 54
        private ContextMenu contextMenu_1;

        // Token: 0x04000037 RID: 55
        private ContextMenu contextMenu_2;

        // Token: 0x04000038 RID: 56
        private ContextMenu contextMenu_3;

        // Token: 0x04000039 RID: 57
        private MenuItem menuItem_0;

        // Token: 0x0400003A RID: 58
        private MenuItem menuItem_1;

        // Token: 0x0400003B RID: 59
        private MenuItem menuItem_2;

        // Token: 0x0400003C RID: 60
        private MenuItem menuItem_3;

        // Token: 0x0400003D RID: 61
        private MenuItem menuItem_4;

        // Token: 0x0400003E RID: 62
        private MenuItem menuItem_5;

        // Token: 0x0400003F RID: 63
        private MenuItem menuItem_6;

        // Token: 0x04000040 RID: 64
        private MenuItem menuItem_7;

        // Token: 0x04000041 RID: 65
        private MenuItem menuItem_8;

        // Token: 0x04000042 RID: 66
        private MenuItem menuItem_9;

        // Token: 0x04000043 RID: 67
        private MenuItem menuItem_10;

        // Token: 0x04000044 RID: 68
        private MenuItem menuItem_11;

        // Token: 0x04000045 RID: 69
        private MenuItem menuItem_12;

        // Token: 0x04000046 RID: 70
        private MenuItem menuItem_13;

        // Token: 0x04000047 RID: 71
        private MenuItem menuItem_14;

        // Token: 0x04000048 RID: 72
        private MenuItem menuItem_15;

        // Token: 0x04000049 RID: 73
        private MenuItem menuItem_16;

        // Token: 0x0400004A RID: 74
        private MenuItem menuItem_17;

        // Token: 0x0400004B RID: 75
        private MenuItem menuItem_18;

        // Token: 0x0400004C RID: 76
        private MenuItem menuItem_19;

        // Token: 0x0400004D RID: 77
        private MenuItem menuItem_20;

        // Token: 0x0400004E RID: 78
        private MenuItem menuItem_21;

        // Token: 0x0400004F RID: 79
        private MenuItem menuItem_22;

        // Token: 0x04000050 RID: 80
        private ColumnHeader columnHeader_0;

        // Token: 0x04000051 RID: 81
        private ColumnHeader columnHeader_1;

        // Token: 0x04000052 RID: 82
        private ColumnHeader columnHeader_2;

        // Token: 0x04000053 RID: 83
        private ColumnHeader columnHeader_3;

        // Token: 0x04000054 RID: 84
        private ColumnHeader columnHeader_4;

        // Token: 0x04000055 RID: 85
        private ColumnHeader columnHeader_5;

        // Token: 0x04000056 RID: 86
        private ColumnHeader columnHeader_6;

        // Token: 0x04000057 RID: 87
        private ImageList imageList_0;

        // Token: 0x04000058 RID: 88
        private ImageList imageList_1;

        // Token: 0x04000059 RID: 89
        private ImageList imageList_2;

        // Token: 0x0400005A RID: 90
        private IContainer icontainer_0;

        // Token: 0x0400005B RID: 91
        public ArrayList m_OpenedFiles;

        // Token: 0x0400005C RID: 92
        public ArrayList m_LinuxFiles;

        // Token: 0x0400005D RID: 93
        private static readonly char char_0;

        // Token: 0x0400005E RID: 94
        public static string tempPathLinuxFiles;

        // Token: 0x0400005F RID: 95
        private bool bool_0;

        // Token: 0x04000060 RID: 96
        public static MyDebug debugDialog;

        // Token: 0x04000061 RID: 97
        public static frmProperties fProperties;

        // Token: 0x04000062 RID: 98
        private View view_0;

        // Token: 0x04000063 RID: 99
        private DirectoryNode directoryNode_0;

        // Token: 0x04000064 RID: 100
        private DirectoryNode directoryNode_1;

        // Token: 0x04000065 RID: 101
        private int int_0;

        // Token: 0x04000066 RID: 102
        private int int_1;

        // Token: 0x04000067 RID: 103
        private SortOrder sortOrder_0;

        // Token: 0x04000068 RID: 104
        public static readonly int IndexIconFolder;

        // Token: 0x04000069 RID: 105
        public static readonly int IndexIconFolderL;

        // Token: 0x0400006A RID: 106
        public static readonly int IndexIconFile;

        // Token: 0x0400006B RID: 107
        public static readonly int IndexIconBitmap;

        // Token: 0x0400006C RID: 108
        public static readonly int IndexIconPdf;

        // Token: 0x0400006D RID: 109
        public static readonly int IndexIconHtml;

        // Token: 0x0400006E RID: 110
        public static readonly int IndexIconAvi;

        // Token: 0x0400006F RID: 111
        public static readonly int IndexIconMp3;

        // Token: 0x04000070 RID: 112
        public static readonly int IndexIconLink;

        // Token: 0x04000071 RID: 113
        public static readonly int IndexIconFolderUp;

        // Token: 0x04000072 RID: 114
        public static readonly int IndexIconError;

        // Token: 0x04000073 RID: 115
        public static readonly int IndexIconAccess;

        // Token: 0x04000074 RID: 116
        public static readonly int IndexIconExcel;

        // Token: 0x04000075 RID: 117
        public static readonly int IndexIconWord;

        // Token: 0x04000076 RID: 118
        public static readonly int IndexIconPowerPoint;

        // Token: 0x04000077 RID: 119
        public static readonly int IndexIconExe;

        // Token: 0x04000078 RID: 120
        public static readonly int IndexIconJava;

        // Token: 0x04000079 RID: 121
        public static readonly int IndexIconFolderBack;

        // Token: 0x0400007A RID: 122
        internal ContextMenuStrip docContextMenuStrip;

        // Token: 0x0400007B RID: 123
        internal ToolStripMenuItem formatContextMenuItem;

        // Token: 0x0400007C RID: 124
        internal ContextMenuStrip docContextMenuStrip_1;

        // Token: 0x0400007D RID: 125
        internal ToolStripMenuItem viewToolStripMenuItem;

        // Token: 0x0400007E RID: 126
        internal ToolStripMenuItem toolStripMenuItem2;

        // Token: 0x0400007F RID: 127
        internal ToolStripMenuItem toolStripMenuItem3;

        // Token: 0x04000080 RID: 128
        internal ToolStripMenuItem toolStripMenuItem4;

        // Token: 0x04000081 RID: 129
        private PictureBox picUSB;

        // Token: 0x04000082 RID: 130
        private ToolStripMenuItem newToolStripMenuItem;

        // Token: 0x04000083 RID: 131
        private ToolStripMenuItem pasteToolStripMenuItem;

        // Token: 0x04000084 RID: 132
        private ToolStripSeparator toolStripMenuItem5;

        // Token: 0x04000085 RID: 133
        private ToolStripMenuItem detailsToolStripMenuItem;

        // Token: 0x04000086 RID: 134
        internal ContextMenuStrip docContextMenuStrip_2;

        // Token: 0x04000087 RID: 135
        private ToolStripMenuItem toolStripMenuItem1;

        // Token: 0x04000088 RID: 136
        private ToolStripMenuItem toolStripMenuItem6;

        // Token: 0x04000089 RID: 137
        private ToolStripSeparator toolStripSeparator1;

        // Token: 0x0400008A RID: 138
        internal ToolStripMenuItem toolStripMenuItem7;

        // Token: 0x0400008B RID: 139
        internal ToolStripMenuItem toolStripMenuItem8;

        // Token: 0x0400008C RID: 140
        internal ToolStripMenuItem toolStripMenuItem9;

        // Token: 0x0400008D RID: 141
        internal ToolStripMenuItem toolStripMenuItem10;

        // Token: 0x0400008E RID: 142
        private ToolStripMenuItem toolStripMenuItem11;

        // Token: 0x0400008F RID: 143
        private ToolStripMenuItem modifyToolStripMenuItem;

        // Token: 0x04000090 RID: 144
        internal ContextMenuStrip docContextMenuStrip_3;

        // Token: 0x04000091 RID: 145
        private ToolStripMenuItem modifyToolStripMenuItem1;

        // Token: 0x04000092 RID: 146
        private ToolStripMenuItem toolStripMenuItem12;

        // Token: 0x04000093 RID: 147
        private ToolStripMenuItem toolStripMenuItem13;

        // Token: 0x04000094 RID: 148
        private ToolStripSeparator toolStripSeparator2;

        // Token: 0x04000095 RID: 149
        internal ToolStripMenuItem toolStripMenuItem14;

        // Token: 0x04000096 RID: 150
        public static readonly int IndexIconZip;

        // Token: 0x04000097 RID: 151
        private ToolStripMenuItem refreshToolStripMenuItem;

        // Token: 0x04000098 RID: 152
        public Label lblCopy;

        // Token: 0x04000099 RID: 153
        private Timer timer_0;

        // Token: 0x0400009A RID: 154
        private Label lblUSB;

        // Token: 0x0400009B RID: 155
        private ToolStripMenuItem cutToolStripMenuItem;

        // Token: 0x0400009C RID: 156
        private ToolStripMenuItem toolStripMenu_Properties;

        // Token: 0x0400009D RID: 157
        private Button btlSearch;

        // Token: 0x0400009E RID: 158
        private TextBox txtSearch;

        // Token: 0x0400009F RID: 159
        public static readonly int IndexIconEncrypt;
    }
}
