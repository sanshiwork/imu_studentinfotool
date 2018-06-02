using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentInfoTool
{
    public partial class EditForm : Form
    {
        private MainForm main;//添加对主窗体的引用

        public EditForm()
        {
            InitializeComponent();
            this.main = new MainForm();//初始化一个空窗体
        }

        public EditForm(MainForm main)
        {
            InitializeComponent();//初始化窗体信息
            this.stuhjdxzqh.TvTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stuhjdxzqh_Click);//注册treeview单击事件
            this.stuhjdxzqh.TvTreeView.DoubleClick += new System.EventHandler(this.stuhjdxzqh_DoubleClick);//注册treeview双击事件
            this.main = main;//为属性main初始化
        }
        //保存对学生数据的修改
        private void savebtn_Click(object sender, EventArgs e)
        {
            StudentInfo stu = new StudentInfo();
            if (main.CheckTool.isNotFillIn(stuxm.Text.Trim()))
            {
                MessageBox.Show("姓名为必须填写内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.CheckTool.isNotFillIn(stuzjhm.Text.Trim()))
            {
                MessageBox.Show("身份证号码为必须填写内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.CheckTool.isNotFillIn(stuxb.Text.Trim()))
            {
                MessageBox.Show("性别为必须填写内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.CheckTool.isNotFillIn(stumz.Text.Trim()))
            {
                MessageBox.Show("民族为必须填写内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.CheckTool.isNotFillIn(stuwhcd.Text.Trim()))
            {
                MessageBox.Show("文化程度为必须填写内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.CheckTool.isNotFillIn(stuzzmm.Text.Trim()))
            {
                MessageBox.Show("政治面貌为必须填写内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.CheckTool.isNotFillIn(stuzjxy.Text.Trim()))
            {
                MessageBox.Show("宗教信仰为必须填写内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.CheckTool.isNotFillIn(stuhkxz.Text.Trim()))
            {
                MessageBox.Show("户口性质为必须填写内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.CheckTool.isNotFillIn(stuhjdxzqh.Text.Trim()))
            {
                MessageBox.Show("户籍地代码为必须填写内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.CheckTool.isNotFillIn(stuhjdxz.Text.Trim()))
            {
                MessageBox.Show("户籍地详址为必须填写内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.CheckTool.isFillIn(stuzjhm.Text.Trim()))
            {
                if (!main.CheckTool.checkZjhm(stuzjhm.Text.Trim()))
                {
                    MessageBox.Show("身份证格式不正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                stu.Bh = this.main.Stu.Bh;
                stu.Zjhm = stuzjhm.Text.Trim();
                if (main.judgeDuplicate(stu))
                {
                    MessageBox.Show("身份证号在学生列表中已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (StudentInfo stuItem in this.main.StuList)
            {
                if (stuItem.Bh == this.main.Stu.Bh)//如果当前学生消息项等于修改项，获取本项引用
                {
                    stu = stuItem;
                    break;
                }
            }
            stu.Xm = stuxm.Text.Trim();
            stu.Zjhm = stuzjhm.Text.Trim();
            stu.Xb = stuxb.Text.Trim();
            stu.Mz = stumz.Text.Trim();
            stu.Whcd = stuwhcd.Text.Trim();
            stu.Zzmm = stuzzmm.Text.Trim();
            stu.Zjxy = stuzjxy.Text.Trim();
            stu.Hjdxzqh = stuhjdxzqh.Text.Trim();
            stu.Hjdxz = stuhjdxz.Text.Trim();
            stu.Hkxz = stuhkxz.Text.Trim();
            stu.Bzxx = stubzxx.Text.Trim();
            main.datagridRefresh();//刷新学生信息显示
            this.Close();
        }
        //当前窗口关闭按钮
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗口
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            //初始化区划代码根节点
            if (this.main.CheckTool.Qhs.Count > 0)
            {
                foreach (QuHua qh in this.main.CheckTool.Qhs)
                {
                    if (qh.Qhjb.Equals("1"))
                    {
                        TreeNode node = new TreeNode();
                        node.Name = qh.Qhdm;
                        node.Text = qh.Qhmc;
                        this.stuhjdxzqh.Nodes.Add(node);
                    }
                }
            }
            //初始化性别列表
            if (this.main.CheckTool.Xbs.Count > 0)
            {
                foreach (CommonItem item in this.main.CheckTool.Xbs)
                {
                    this.stuxb.Items.Add(item.Mc);
                }
            }
            //初始化民族列表
            if (this.main.CheckTool.Mzs.Count > 0)
            {
                foreach (CommonItem item in this.main.CheckTool.Mzs)
                {
                    this.stumz.Items.Add(item.Mc);
                }
            }
            //初始化政治面貌列表
            if (this.main.CheckTool.Zzmms.Count > 0)
            {
                foreach (CommonItem item in this.main.CheckTool.Zzmms)
                {
                    this.stuzzmm.Items.Add(item.Mc);
                }
            }
            //初始化文化程度列表
            if (this.main.CheckTool.Whcds.Count > 0)
            {
                foreach (CommonItem item in this.main.CheckTool.Whcds)
                {
                    this.stuwhcd.Items.Add(item.Mc);
                }
            }
            //初始化宗教信仰列表
            if (this.main.CheckTool.Zjxys.Count > 0)
            {
                foreach (CommonItem item in this.main.CheckTool.Zjxys)
                {
                    this.stuzjxy.Items.Add(item.Mc);
                }
            }
            //初始化户口性质列表
            if (this.main.CheckTool.Hkxzs.Count > 0)
            {
                foreach (CommonItem item in this.main.CheckTool.Hkxzs)
                {
                    this.stuhkxz.Items.Add(item.Mc);
                }
            }
            this.stuxm.Text = this.main.Stu.Xm;
            this.stuzjhm.Text = this.main.Stu.Zjhm;
            this.stuxb.Text = this.main.Stu.Xb;
            this.stumz.Text = this.main.Stu.Mz;
            this.stuwhcd.Text = this.main.Stu.Whcd;
            this.stuzzmm.Text = this.main.Stu.Zzmm;
            this.stuzjxy.Text = this.main.Stu.Zjxy;
            this.stuhjdxzqh.Text = this.main.Stu.Hjdxzqh;
            this.stuhjdxz.Text = this.main.Stu.Hjdxz;
            this.stuhkxz.Text = this.main.Stu.Hkxz;
            this.stubzxx.Text = this.main.Stu.Bzxx;
        }
        private void stuhjdxzqh_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            Console.WriteLine("Test Result:" + e.Node.Name);
            if (!string.IsNullOrEmpty(e.Node.Name) && e.Node.Nodes.Count == 0 && e.Node.Level != 4)
            {
                List<QuHua> qhs = this.main.CheckTool.getQhs(e.Node.Name);
                foreach (QuHua qh in qhs)
                {
                    TreeNode node = new TreeNode();
                    node.Name = qh.Qhdm;
                    node.Text = qh.Qhmc;
                    e.Node.Nodes.Add(node);
                }
                e.Node.Expand();
            }
        }

        private void stuhjdxzqh_DoubleClick(object sender, EventArgs e)
        {
            this.stuhjdxzqh.Text = this.stuhjdxzqh.SelectedNode.Name;
            this.stuhjdxz.Text = this.stuhjdxzqh.SelectedNode.FullPath.Replace("\\", "");
        }
    }
}
