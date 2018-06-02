namespace StudentInfoTool
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.openclass = new System.Windows.Forms.ToolStripMenuItem();
            this.opencryfile = new System.Windows.Forms.ToolStripMenuItem();
            this.openexcelfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.newstu = new System.Windows.Forms.ToolStripMenuItem();
            this.updatestu = new System.Windows.Forms.ToolStripMenuItem();
            this.deletestu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveclass = new System.Windows.Forms.ToolStripMenuItem();
            this.savecpyfile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveexcelfile = new System.Windows.Forms.ToolStripMenuItem();
            this.clearclass = new System.Windows.Forms.ToolStripMenuItem();
            this.helpclass = new System.Windows.Forms.ToolStripMenuItem();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.titleLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbrxxbox = new System.Windows.Forms.TextBox();
            this.tbrxxl = new System.Windows.Forms.Label();
            this.bjxxbox = new System.Windows.Forms.TextBox();
            this.bjxxl = new System.Windows.Forms.Label();
            this.zyxxbox = new System.Windows.Forms.TextBox();
            this.zyryxl = new System.Windows.Forms.Label();
            this.xyxxbox = new System.Windows.Forms.TextBox();
            this.xyxxl = new System.Windows.Forms.Label();
            this.xxxxbox = new System.Windows.Forms.TextBox();
            this.xxxxl = new System.Windows.Forms.Label();
            this.tbrqbox = new System.Windows.Forms.DateTimePicker();
            this.tbrql = new System.Windows.Forms.Label();
            this.lxdhl = new System.Windows.Forms.Label();
            this.lxdhbox = new System.Windows.Forms.TextBox();
            this.stugroup = new System.Windows.Forms.GroupBox();
            this.studatagrid = new System.Windows.Forms.DataGridView();
            this.Bh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zjhm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csrq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lxdh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Whcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zzmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zjxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hjdxzqh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hjdxz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hkxz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bzxx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.titleLayoutPanel.SuspendLayout();
            this.stugroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openclass,
            this.newstu,
            this.updatestu,
            this.deletestu,
            this.saveclass,
            this.clearclass,
            this.helpclass});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(1008, 25);
            this.mainmenu.TabIndex = 0;
            this.mainmenu.Text = "mainmenu";
            // 
            // openclass
            // 
            this.openclass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opencryfile,
            this.openexcelfile,
            this.toolStripMenuItem1,
            this.exitbtn});
            this.openclass.Image = global::imu_studentinfotool.Properties.Resources.open_1;
            this.openclass.Name = "openclass";
            this.openclass.Size = new System.Drawing.Size(60, 21);
            this.openclass.Text = "打开";
            this.openclass.Click += new System.EventHandler(this.openclass_Click);
            // 
            // opencryfile
            // 
            this.opencryfile.Image = global::imu_studentinfotool.Properties.Resources.open_1;
            this.opencryfile.Name = "opencryfile";
            this.opencryfile.Size = new System.Drawing.Size(153, 22);
            this.opencryfile.Text = "打开加密文件";
            this.opencryfile.Click += new System.EventHandler(this.opencryfile_Click);
            // 
            // openexcelfile
            // 
            this.openexcelfile.Image = global::imu_studentinfotool.Properties.Resources.open_1;
            this.openexcelfile.Name = "openexcelfile";
            this.openexcelfile.Size = new System.Drawing.Size(153, 22);
            this.openexcelfile.Text = "打开Excel文件";
            this.openexcelfile.Click += new System.EventHandler(this.openexcelfile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // exitbtn
            // 
            this.exitbtn.Image = global::imu_studentinfotool.Properties.Resources.exit;
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(153, 22);
            this.exitbtn.Text = "退出";
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // newstu
            // 
            this.newstu.Image = global::imu_studentinfotool.Properties.Resources.edit_add;
            this.newstu.Name = "newstu";
            this.newstu.Size = new System.Drawing.Size(60, 21);
            this.newstu.Text = "新建";
            this.newstu.Click += new System.EventHandler(this.newstu_Click);
            // 
            // updatestu
            // 
            this.updatestu.Image = global::imu_studentinfotool.Properties.Resources.pencil;
            this.updatestu.Name = "updatestu";
            this.updatestu.Size = new System.Drawing.Size(60, 21);
            this.updatestu.Text = "修改";
            this.updatestu.Click += new System.EventHandler(this.updatestu_Click);
            // 
            // deletestu
            // 
            this.deletestu.Image = global::imu_studentinfotool.Properties.Resources.edit_remove;
            this.deletestu.Name = "deletestu";
            this.deletestu.Size = new System.Drawing.Size(60, 21);
            this.deletestu.Text = "删除";
            this.deletestu.Click += new System.EventHandler(this.deletestu_Click);
            // 
            // saveclass
            // 
            this.saveclass.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.saveclass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savecpyfile,
            this.saveexcelfile});
            this.saveclass.Image = global::imu_studentinfotool.Properties.Resources.filesave;
            this.saveclass.Name = "saveclass";
            this.saveclass.Size = new System.Drawing.Size(60, 21);
            this.saveclass.Text = "保存";
            this.saveclass.Click += new System.EventHandler(this.saveclass_Click);
            // 
            // savecpyfile
            // 
            this.savecpyfile.Image = global::imu_studentinfotool.Properties.Resources.filesave;
            this.savecpyfile.Name = "savecpyfile";
            this.savecpyfile.Size = new System.Drawing.Size(165, 22);
            this.savecpyfile.Text = "保存为加密文件";
            this.savecpyfile.Click += new System.EventHandler(this.savecpyfile_Click);
            // 
            // saveexcelfile
            // 
            this.saveexcelfile.Image = global::imu_studentinfotool.Properties.Resources.filesave;
            this.saveexcelfile.Name = "saveexcelfile";
            this.saveexcelfile.Size = new System.Drawing.Size(165, 22);
            this.saveexcelfile.Text = "保存为Excel文件";
            this.saveexcelfile.Click += new System.EventHandler(this.saveexcelfile_Click);
            // 
            // clearclass
            // 
            this.clearclass.Image = global::imu_studentinfotool.Properties.Resources.edit_remove_2;
            this.clearclass.Name = "clearclass";
            this.clearclass.Size = new System.Drawing.Size(84, 21);
            this.clearclass.Text = "全部清空";
            this.clearclass.Click += new System.EventHandler(this.clearclass_Click);
            // 
            // helpclass
            // 
            this.helpclass.Image = global::imu_studentinfotool.Properties.Resources.help1;
            this.helpclass.Name = "helpclass";
            this.helpclass.Size = new System.Drawing.Size(60, 21);
            this.helpclass.Text = "帮助";
            this.helpclass.Click += new System.EventHandler(this.helpclass_Click);
            // 
            // openfile
            // 
            this.openfile.Filter = "excel表|*.xls";
            // 
            // savefile
            // 
            this.savefile.DefaultExt = "xls";
            this.savefile.Filter = "excel表|*.xls";
            // 
            // mainContainer
            // 
            this.mainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 25);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.titleLayoutPanel);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.stugroup);
            this.mainContainer.Size = new System.Drawing.Size(1008, 637);
            this.mainContainer.SplitterDistance = 80;
            this.mainContainer.TabIndex = 2;
            // 
            // titleLayoutPanel
            // 
            this.titleLayoutPanel.ColumnCount = 9;
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.10444F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.75457F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.224543F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.40731F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.963447F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.14621F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.399478F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.titleLayoutPanel.Controls.Add(this.tbrxxbox, 3, 1);
            this.titleLayoutPanel.Controls.Add(this.tbrxxl, 2, 1);
            this.titleLayoutPanel.Controls.Add(this.bjxxbox, 1, 1);
            this.titleLayoutPanel.Controls.Add(this.bjxxl, 0, 1);
            this.titleLayoutPanel.Controls.Add(this.zyxxbox, 5, 0);
            this.titleLayoutPanel.Controls.Add(this.zyryxl, 4, 0);
            this.titleLayoutPanel.Controls.Add(this.xyxxbox, 3, 0);
            this.titleLayoutPanel.Controls.Add(this.xyxxl, 2, 0);
            this.titleLayoutPanel.Controls.Add(this.xxxxbox, 1, 0);
            this.titleLayoutPanel.Controls.Add(this.xxxxl, 0, 0);
            this.titleLayoutPanel.Controls.Add(this.tbrqbox, 7, 1);
            this.titleLayoutPanel.Controls.Add(this.tbrql, 6, 1);
            this.titleLayoutPanel.Controls.Add(this.lxdhl, 4, 1);
            this.titleLayoutPanel.Controls.Add(this.lxdhbox, 5, 1);
            this.titleLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.titleLayoutPanel.Name = "titleLayoutPanel";
            this.titleLayoutPanel.RowCount = 2;
            this.titleLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleLayoutPanel.Size = new System.Drawing.Size(1006, 78);
            this.titleLayoutPanel.TabIndex = 0;
            // 
            // tbrxxbox
            // 
            this.tbrxxbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbrxxbox.Location = new System.Drawing.Point(330, 48);
            this.tbrxxbox.Name = "tbrxxbox";
            this.tbrxxbox.Size = new System.Drawing.Size(125, 21);
            this.tbrxxbox.TabIndex = 11;
            // 
            // tbrxxl
            // 
            this.tbrxxl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbrxxl.AutoSize = true;
            this.tbrxxl.Location = new System.Drawing.Point(283, 52);
            this.tbrxxl.Name = "tbrxxl";
            this.tbrxxl.Size = new System.Drawing.Size(41, 12);
            this.tbrxxl.TabIndex = 10;
            this.tbrxxl.Text = "填表人";
            // 
            // bjxxbox
            // 
            this.bjxxbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bjxxbox.Location = new System.Drawing.Point(146, 48);
            this.bjxxbox.Name = "bjxxbox";
            this.bjxxbox.Size = new System.Drawing.Size(120, 21);
            this.bjxxbox.TabIndex = 9;
            // 
            // bjxxl
            // 
            this.bjxxl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bjxxl.AutoSize = true;
            this.bjxxl.Location = new System.Drawing.Point(87, 52);
            this.bjxxl.Name = "bjxxl";
            this.bjxxl.Size = new System.Drawing.Size(53, 12);
            this.bjxxl.TabIndex = 8;
            this.bjxxl.Text = "班级名称";
            // 
            // zyxxbox
            // 
            this.zyxxbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zyxxbox.Location = new System.Drawing.Point(517, 9);
            this.zyxxbox.Name = "zyxxbox";
            this.zyxxbox.Size = new System.Drawing.Size(123, 21);
            this.zyxxbox.TabIndex = 5;
            // 
            // zyryxl
            // 
            this.zyryxl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zyryxl.AutoSize = true;
            this.zyryxl.Location = new System.Drawing.Point(470, 7);
            this.zyryxl.Name = "zyryxl";
            this.zyryxl.Size = new System.Drawing.Size(41, 24);
            this.zyryxl.TabIndex = 4;
            this.zyryxl.Text = "专业名称";
            // 
            // xyxxbox
            // 
            this.xyxxbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xyxxbox.Location = new System.Drawing.Point(330, 9);
            this.xyxxbox.Name = "xyxxbox";
            this.xyxxbox.Size = new System.Drawing.Size(125, 21);
            this.xyxxbox.TabIndex = 3;
            // 
            // xyxxl
            // 
            this.xyxxl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.xyxxl.AutoSize = true;
            this.xyxxl.Location = new System.Drawing.Point(283, 7);
            this.xyxxl.Name = "xyxxl";
            this.xyxxl.Size = new System.Drawing.Size(41, 24);
            this.xyxxl.TabIndex = 2;
            this.xyxxl.Text = "学院名称";
            // 
            // xxxxbox
            // 
            this.xxxxbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xxxxbox.Location = new System.Drawing.Point(146, 9);
            this.xxxxbox.Name = "xxxxbox";
            this.xxxxbox.Size = new System.Drawing.Size(120, 21);
            this.xxxxbox.TabIndex = 1;
            // 
            // xxxxl
            // 
            this.xxxxl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.xxxxl.AutoSize = true;
            this.xxxxl.Location = new System.Drawing.Point(87, 13);
            this.xxxxl.Name = "xxxxl";
            this.xxxxl.Size = new System.Drawing.Size(53, 12);
            this.xxxxl.TabIndex = 0;
            this.xxxxl.Text = "学校名称";
            // 
            // tbrqbox
            // 
            this.tbrqbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbrqbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbrqbox.Location = new System.Drawing.Point(712, 48);
            this.tbrqbox.Name = "tbrqbox";
            this.tbrqbox.Size = new System.Drawing.Size(130, 21);
            this.tbrqbox.TabIndex = 14;
            // 
            // tbrql
            // 
            this.tbrql.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbrql.AutoSize = true;
            this.tbrql.Location = new System.Drawing.Point(653, 52);
            this.tbrql.Name = "tbrql";
            this.tbrql.Size = new System.Drawing.Size(53, 12);
            this.tbrql.TabIndex = 12;
            this.tbrql.Text = "填表日期";
            // 
            // lxdhl
            // 
            this.lxdhl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lxdhl.AutoSize = true;
            this.lxdhl.Location = new System.Drawing.Point(470, 46);
            this.lxdhl.Name = "lxdhl";
            this.lxdhl.Size = new System.Drawing.Size(41, 24);
            this.lxdhl.TabIndex = 15;
            this.lxdhl.Text = "联系方式";
            // 
            // lxdhbox
            // 
            this.lxdhbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lxdhbox.Location = new System.Drawing.Point(517, 48);
            this.lxdhbox.Name = "lxdhbox";
            this.lxdhbox.Size = new System.Drawing.Size(123, 21);
            this.lxdhbox.TabIndex = 16;
            // 
            // stugroup
            // 
            this.stugroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.stugroup.Controls.Add(this.studatagrid);
            this.stugroup.Location = new System.Drawing.Point(0, -1);
            this.stugroup.Name = "stugroup";
            this.stugroup.Size = new System.Drawing.Size(1006, 553);
            this.stugroup.TabIndex = 2;
            this.stugroup.TabStop = false;
            // 
            // studatagrid
            // 
            this.studatagrid.AllowUserToAddRows = false;
            this.studatagrid.AllowUserToDeleteRows = false;
            this.studatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bh,
            this.Xm,
            this.Zjhm,
            this.Xb,
            this.Csrq,
            this.Mz,
            this.Lxdh,
            this.Whcd,
            this.Zzmm,
            this.Zjxy,
            this.Hjdxzqh,
            this.Hjdxz,
            this.Hkxz,
            this.Bzxx});
            this.studatagrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.studatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studatagrid.Location = new System.Drawing.Point(3, 17);
            this.studatagrid.MultiSelect = false;
            this.studatagrid.Name = "studatagrid";
            this.studatagrid.ReadOnly = true;
            this.studatagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studatagrid.RowTemplate.Height = 23;
            this.studatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studatagrid.Size = new System.Drawing.Size(1000, 533);
            this.studatagrid.TabIndex = 0;
            // 
            // Bh
            // 
            this.Bh.DataPropertyName = "Bh";
            this.Bh.HeaderText = "学生临时编号";
            this.Bh.Name = "Bh";
            this.Bh.ReadOnly = true;
            this.Bh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bh.Visible = false;
            this.Bh.Width = 5;
            // 
            // Xm
            // 
            this.Xm.DataPropertyName = "Xm";
            this.Xm.HeaderText = "姓名";
            this.Xm.Name = "Xm";
            this.Xm.ReadOnly = true;
            this.Xm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Zjhm
            // 
            this.Zjhm.DataPropertyName = "Zjhm";
            this.Zjhm.HeaderText = "身份证号码";
            this.Zjhm.Name = "Zjhm";
            this.Zjhm.ReadOnly = true;
            this.Zjhm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Xb
            // 
            this.Xb.DataPropertyName = "Xb";
            this.Xb.HeaderText = "性别";
            this.Xb.Name = "Xb";
            this.Xb.ReadOnly = true;
            this.Xb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Xb.Width = 80;
            // 
            // Csrq
            // 
            this.Csrq.DataPropertyName = "Csrq";
            this.Csrq.HeaderText = "出生日期";
            this.Csrq.Name = "Csrq";
            this.Csrq.ReadOnly = true;
            this.Csrq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Csrq.Visible = false;
            // 
            // Mz
            // 
            this.Mz.DataPropertyName = "Mz";
            this.Mz.HeaderText = "民族";
            this.Mz.Name = "Mz";
            this.Mz.ReadOnly = true;
            this.Mz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mz.Width = 80;
            // 
            // Lxdh
            // 
            this.Lxdh.DataPropertyName = "Lxdh";
            this.Lxdh.HeaderText = "联系电话";
            this.Lxdh.Name = "Lxdh";
            this.Lxdh.ReadOnly = true;
            this.Lxdh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lxdh.Visible = false;
            // 
            // Whcd
            // 
            this.Whcd.DataPropertyName = "Whcd";
            this.Whcd.HeaderText = "文化程度";
            this.Whcd.Name = "Whcd";
            this.Whcd.ReadOnly = true;
            this.Whcd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Zzmm
            // 
            this.Zzmm.DataPropertyName = "Zzmm";
            this.Zzmm.HeaderText = "政治面貌";
            this.Zzmm.Name = "Zzmm";
            this.Zzmm.ReadOnly = true;
            this.Zzmm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Zjxy
            // 
            this.Zjxy.DataPropertyName = "Zjxy";
            this.Zjxy.HeaderText = "宗教信仰";
            this.Zjxy.Name = "Zjxy";
            this.Zjxy.ReadOnly = true;
            this.Zjxy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Hjdxzqh
            // 
            this.Hjdxzqh.DataPropertyName = "Hjdxzqh";
            this.Hjdxzqh.HeaderText = "户籍地代码";
            this.Hjdxzqh.Name = "Hjdxzqh";
            this.Hjdxzqh.ReadOnly = true;
            this.Hjdxzqh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Hjdxz
            // 
            this.Hjdxz.DataPropertyName = "Hjdxz";
            this.Hjdxz.HeaderText = "户籍地详细地址";
            this.Hjdxz.Name = "Hjdxz";
            this.Hjdxz.ReadOnly = true;
            this.Hjdxz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hjdxz.Width = 130;
            // 
            // Hkxz
            // 
            this.Hkxz.DataPropertyName = "Hkxz";
            this.Hkxz.HeaderText = "户口性质";
            this.Hkxz.Name = "Hkxz";
            this.Hkxz.ReadOnly = true;
            this.Hkxz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Bzxx
            // 
            this.Bzxx.DataPropertyName = "Bzxx";
            this.Bzxx.HeaderText = "备注";
            this.Bzxx.Name = "Bzxx";
            this.Bzxx.ReadOnly = true;
            this.Bzxx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bzxx.Width = 110;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.mainmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainmenu;
            this.Name = "MainForm";
            this.Text = "学生信息表生成工具";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.titleLayoutPanel.ResumeLayout(false);
            this.titleLayoutPanel.PerformLayout();
            this.stugroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem newstu;
        private System.Windows.Forms.ToolStripMenuItem saveclass;
        private System.Windows.Forms.ToolStripMenuItem clearclass;
        private System.Windows.Forms.ToolStripMenuItem helpclass;
        private System.Windows.Forms.ToolStripMenuItem updatestu;
        private System.Windows.Forms.ToolStripMenuItem deletestu;
        private System.Windows.Forms.ToolStripMenuItem openclass;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.SaveFileDialog savefile;
        private System.Windows.Forms.ToolStripMenuItem opencryfile;
        private System.Windows.Forms.ToolStripMenuItem openexcelfile;
        private System.Windows.Forms.ToolStripMenuItem savecpyfile;
        private System.Windows.Forms.ToolStripMenuItem saveexcelfile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitbtn;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.GroupBox stugroup;
        private System.Windows.Forms.DataGridView studatagrid;
        private System.Windows.Forms.TableLayoutPanel titleLayoutPanel;
        private System.Windows.Forms.Label xxxxl;
        private System.Windows.Forms.TextBox xxxxbox;
        private System.Windows.Forms.Label tbrql;
        private System.Windows.Forms.TextBox tbrxxbox;
        private System.Windows.Forms.Label tbrxxl;
        private System.Windows.Forms.TextBox bjxxbox;
        private System.Windows.Forms.Label bjxxl;
        private System.Windows.Forms.TextBox zyxxbox;
        private System.Windows.Forms.Label zyryxl;
        private System.Windows.Forms.TextBox xyxxbox;
        private System.Windows.Forms.Label xyxxl;
        private System.Windows.Forms.DateTimePicker tbrqbox;
        private System.Windows.Forms.Label lxdhl;
        private System.Windows.Forms.TextBox lxdhbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zjhm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csrq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lxdh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Whcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zzmm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zjxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hjdxzqh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hjdxz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hkxz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bzxx;


    }
}