using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace StudentInfoTool
{
    public partial class MainForm : Form
    {
        //学生信息列表
        private List<StudentInfo> stuList;
        //当前选中学生信息
        private StudentInfo stu;
        //学生临时编号
        private int bhCount;
        //检查类实例
        private CheckTools checkTool;
        //标题类实例化
        private TitleInformation titleInformation;

        public List<StudentInfo> StuList
        {
            get { return stuList; }
            set { stuList = value; }
        }
        public StudentInfo Stu
        {
            get { return stu; }
            set { stu = value; }
        }
        public int BhCount
        {
            get { bhCount = bhCount + 1; return bhCount; }
        }
        public CheckTools CheckTool
        {
            get { return checkTool; }
            set { checkTool = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            stuList = new List<StudentInfo>();//对学生列表进行初始化
            bhCount = 0;//主窗体启动时，为临时编号变量赋初值
            checkTool = new CheckTools();//实例化检查类
        }
        //打开新建对话框
        private void newstu_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);//将MainForm作为参数传给AddForm
            addForm.ShowDialog();
        }
        //打开修改对话框
        private void updatestu_Click(object sender, EventArgs e)
        {
            if (this.studatagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.studatagrid.CurrentRow;
                this.Stu = new StudentInfo();//初始化要删除的学生信息
                this.Stu.Bh = Convert.ToInt32(row.Cells["Bh"].Value);
                this.Stu.Xm = Convert.ToString(row.Cells["Xm"].Value);
                this.Stu.Zjhm = Convert.ToString(row.Cells["Zjhm"].Value);
                this.Stu.Xb = Convert.ToString(row.Cells["Xb"].Value);
                this.Stu.Csrq = Convert.ToString(row.Cells["Csrq"].Value);
                this.Stu.Mz = Convert.ToString(row.Cells["Mz"].Value);
                this.Stu.Lxdh = Convert.ToString(row.Cells["Lxdh"].Value);
                this.Stu.Whcd = Convert.ToString(row.Cells["Whcd"].Value);
                this.Stu.Zzmm = Convert.ToString(row.Cells["Zzmm"].Value);
                this.Stu.Zjxy = Convert.ToString(row.Cells["Zjxy"].Value);
                this.Stu.Hjdxzqh = Convert.ToString(row.Cells["Hjdxzqh"].Value);
                this.Stu.Hjdxz = Convert.ToString(row.Cells["Hjdxz"].Value);
                this.Stu.Hkxz = Convert.ToString(row.Cells["Hkxz"].Value);
                this.Stu.Bzxx = Convert.ToString(row.Cells["Bzxx"].Value);
                EditForm editForm = new EditForm(this);//初始化修改窗体
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有选中任何数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //删除选中的数据行
        private void deletestu_Click(object sender, EventArgs e)
        {
            if (this.studatagrid.SelectedRows.Count > 0)
            {
                int Bh = Convert.ToInt32(studatagrid.CurrentRow.Cells["Bh"].Value);//获得此条数据的学生编号
                String Xm = Convert.ToString(studatagrid.CurrentRow.Cells["Xm"].Value);//获得此条数据的学生名称

                if (MessageBox.Show("确认要删除" + Xm + "吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Boolean flag = false;//删除失败
                    foreach (StudentInfo stu in this.StuList)
                    {
                        if (stu.Bh == Bh)//获得要删除的学生信息
                        {
                            this.StuList.Remove(stu);//删除此数据
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        MessageBox.Show("数据已经删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("由于未知原因操作失败！" ,"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.datagridRefresh();//刷新学生数据显示
                }
            }
            else
            {
                MessageBox.Show("没有选中任何数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //打开帮助对话框
        private void helpclass_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }
        //打开excel学生信息数据表
        private void openclass_Click(object sender, EventArgs e)
        {
            //作废
        }
        //刷新datagrid控件数据
        public void datagridRefresh()
        {
            this.studatagrid.DataSource = this.assembleTable();//设置学生数据
            this.studatagrid.Refresh();
            this.studatagrid.ClearSelection();//清空选中项
        }
        //封装学生信息到DataTable中已提供显示
        private DataTable assembleTable()
        {
            DataTable dt = new DataTable();
            dt = new DataTable("studentinfo");//初始化学生信息表
            DataColumnCollection columns = dt.Columns;//获得列的引用
            DataColumn Bh = new DataColumn("Bh", typeof(int));//设置学生临时编号
            DataColumn Xm = new DataColumn("Xm", typeof(string));//设置学生姓名列
            DataColumn Zjhm = new DataColumn("Zjhm", typeof(string));//设置学生身份证号列
            DataColumn Xb = new DataColumn("Xb", typeof(string));//设置学生性别列
            DataColumn Csrq = new DataColumn("Csrq", typeof(string));//设置出生日期列
            DataColumn Mz = new DataColumn("Mz", typeof(string));//设置民族列
            DataColumn Lxdh = new DataColumn("Lxdh", typeof(string));//设置联系电话列
            DataColumn Whcd = new DataColumn("Whcd", typeof(string));//设置联系电话列
            DataColumn Zzmm = new DataColumn("Zzmm", typeof(string));//设置政治面貌列
            DataColumn Zjxy = new DataColumn("Zjxy", typeof(string));//设置宗教信仰列
            DataColumn Hjdxzqh = new DataColumn("Hjdxzqh", typeof(string));//设置户籍地代码列
            DataColumn Hjdxz = new DataColumn("Hjdxz", typeof(string));//设置户籍地详址列
            DataColumn Hkxz = new DataColumn("Hkxz", typeof(string));//设置户口性质列
            DataColumn Bzxx = new DataColumn("Bzxx", typeof(string));//设置备注信息列

            columns.Add(Bh);
            columns.Add(Xm);
            columns.Add(Zjhm);
            columns.Add(Xb);
            columns.Add(Csrq);
            columns.Add(Mz);
            columns.Add(Lxdh);
            columns.Add(Whcd);
            columns.Add(Zzmm);
            columns.Add(Zjxy);
            columns.Add(Hjdxzqh);
            columns.Add(Hjdxz);
            columns.Add(Hkxz);
            columns.Add(Bzxx);

            if (this.StuList.Count > 0)
            {
                foreach(StudentInfo stu in this.StuList)
                {
                    DataRow row = dt.NewRow();//创建一个新行
                    row["Bh"] = stu.Bh;
                    row["Xm"] = stu.Xm;
                    row["Zjhm"] = stu.Zjhm;
                    row["Xb"] = stu.Xb;
                    row["Csrq"] = stu.Csrq;
                    row["Mz"] = stu.Mz;
                    row["Lxdh"] = stu.Lxdh;
                    row["Whcd"] = stu.Whcd;
                    row["Zzmm"] = stu.Zzmm;
                    row["Zjxy"] = stu.Zjxy;
                    row["Hjdxzqh"] = stu.Hjdxzqh;
                    row["Hjdxz"] = stu.Hjdxz;
                    row["Hkxz"] = stu.Hkxz;
                    row["Bzxx"] = stu.Bzxx;
                    dt.Rows.Add(row);//添加新行
                }
            }
            return dt;
        }
        //清空所有学生信息
        private void clearclass_Click(object sender, EventArgs e)
        {
            if (this.StuList.Count > 0)
            {
                if (MessageBox.Show("确认要清空所有学生数据吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.StuList.Clear();//清空所有学生数据
                    this.datagridRefresh();//刷新学生数据
                    MessageBox.Show("学生信息已全部清除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("当前没有学生信息可以清除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //将数据按excel格式导出
        private void saveclass_Click(object sender, EventArgs e)
        {
            //作废
        }
        //退出应用程序
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //打开普通excel文件
        private void openexcelfile_Click(object sender, EventArgs e)
        {
            this.openfile.Filter = "excel表|*.xls";//只能获打开xls后缀文件
            this.openfile.FileName = "";
            if (this.openfile.ShowDialog() == DialogResult.OK)
            {
                if (this.openFile(this.openfile.FileName))
                {
                    this.datagridRefresh();//刷新学生信息显示
                }
                else
                {
                    MessageBox.Show("导入Excel文件时知错，请检查文件是否损坏！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //打开加密excel文件
        private void opencryfile_Click(object sender, EventArgs e)
        {
            this.openfile.Filter = "加密数据表|*.enc";
            this.openfile.FileName = "";
            if (this.openfile.ShowDialog() == DialogResult.OK)
            {
                string fileName = Directory.GetCurrentDirectory() + "\\exportTemp.xls";//临时Excel路径
                byte[] key = { 24, 55, 102, 24, 98, 26, 67, 29, 84, 19, 37, 118, 104, 85, 121, 27, 93, 86, 24, 55, 102, 24, 98, 26, 67, 29, 9, 2, 49, 69, 73, 92 };
                byte[] IV = { 22, 56, 82, 77, 84, 31, 74, 24, 55, 102, 24, 98, 26, 67, 29, 99 };
                try
                {
                    RijndaelManaged myRij = new RijndaelManaged();
                    //创建FileStream对象
                    FileStream fsOut = File.Open(this.openfile.FileName, FileMode.Open, FileAccess.ReadWrite);
                    FileStream fsIn = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
                    CryptoStream csDecry = new CryptoStream(fsOut, myRij.CreateDecryptor(key, IV), CryptoStreamMode.Read);
                    BinaryReader sr = new BinaryReader(csDecry);
                    BinaryWriter sw = new BinaryWriter(fsIn);//解密信息写入临时文件
                    sw.Write(sr.ReadBytes((int)fsOut.Length));
                    sw.Flush();
                    sw.Close();//关闭写入器
                    sr.Close();//关闭读入器
                    fsOut.Close();//关闭文件流
                    fsIn.Close();//关闭文件流
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    MessageBox.Show("文件打开错误，请检查文件格式是否正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //对学生数据进行导入
                if (this.openFile(fileName))
                {
                    this.datagridRefresh();//刷新学生信息显示
                }
                else
                {
                    MessageBox.Show("导入Excel文件时知错，请检查文件是否损坏！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //如果临时文件存在，删除临时文件
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
            }
        }
        //保存为加密excel文件
        private void savecpyfile_Click(object sender, EventArgs e)
        {
            //面板控件为空部分
            if (!this.judgeTitleFillIn())
            {
                return;
            }
            else
            {
                if (this.checkTool.checkTelNum(this.lxdhbox.Text.Trim()))
                {
                    getTitleInformation();//从控件中获取用户信息
                }
                else
                {
                    MessageBox.Show("联系方式格式不正确，请检查！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //判断学生列表里是否存在错误
            if (this.judgeStuInfo())
            {
                return;
            }
            //判断是否存在位数不正确的问题
            if (this.judgeEightExist())
            {
                if (MessageBox.Show("位数不正确，是否导出为加密文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
                {
                    return;
                }
            }
            //文件保存部分
            this.savefile.Filter = "加密数据表|*.enc";
            this.savefile.FileName = "";
            if (this.savefile.ShowDialog() == DialogResult.OK)
            {
                string fileName = Directory.GetCurrentDirectory() + "\\exportTemp.xls";//临时Excel路径
                if (this.saveFile(fileName))
                {
                    try
                    {
                        byte[] key = { 24, 55, 102, 24, 98, 26, 67, 29, 84, 19, 37, 118, 104, 85, 121, 27, 93, 86, 24, 55, 102, 24, 98, 26, 67, 29, 9, 2, 49, 69, 73, 92 };
                        byte[] IV = { 22, 56, 82, 77, 84, 31, 74, 24, 55, 102, 24, 98, 26, 67, 29, 99 };
                        RijndaelManaged myRijn = new RijndaelManaged();
                        FileStream fsOut = File.Open(this.savefile.FileName, FileMode.Create, FileAccess.ReadWrite);
                        FileStream fsIn = File.Open(fileName, FileMode.Open, FileAccess.Read);
                        //写入加密文件
                        CryptoStream csCrypt = new CryptoStream(fsOut, myRijn.CreateEncryptor(key, IV), CryptoStreamMode.Write);
                        BinaryReader br = new BinaryReader(fsIn);//创建阅读器来读加密文本
                        csCrypt.Write(br.ReadBytes((int)fsIn.Length), 0, (int)fsIn.Length);//将数据写入加密文本
                        csCrypt.FlushFinalBlock();
                        csCrypt.Close();//关闭CryptoStream对象
                        fsIn.Close();//关闭FileStream对象
                        fsOut.Close();//关闭FileStream对象
                        File.Delete(fileName);//删除临时文件
                        MessageBox.Show("已经将学生信息数据导入到Excel文件中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                        //如果临时文件存在，删除临时文件
                        if (File.Exists(fileName))
                        {
                            File.Delete(fileName);
                        }
                        MessageBox.Show("学生信息加密出现错误，请检查文件设置是否存在问题！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("将学生信息保存到Excel文件出现未知错！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //保存为普通excel文件
        private void saveexcelfile_Click(object sender, EventArgs e)
        {
            //面板控件为空部分
            if (!this.judgeTitleFillIn())
            {
                return;
            }
            else
            {
                if (this.checkTool.checkTelNum(this.lxdhbox.Text.Trim()))
                {
                    getTitleInformation();//从控件中获取用户信息
                }
                else
                {
                    MessageBox.Show("联系方式格式不正确，请检查！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            //判断学生列表里是否存在错误
            if (this.judgeStuInfo())
            {
                return;
            }
            //判断是否存在位数不正确的问题
            if (this.judgeEightExist())
            {
                if (MessageBox.Show("位数不正确，是否导出为Excel文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
                {
                    return;
                }
            }
            //文件保存部分
            this.savefile.Filter = "excel表|*.xls";//只能保存为xls后缀文件
            this.savefile.FileName = "";
            if (this.savefile.ShowDialog() == DialogResult.OK)
            {
                if (this.saveFile(this.savefile.FileName))
                {
                    MessageBox.Show("已经将学生信息数据导入到Excel文件中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("将学生信息保存到Excel文件出现未知错！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //从指定文件中读出学生数据
        private bool openFile(string fileName)
        {
            bool result = false;
            try
            {
                DataSet myds = new DataSet();
                //获取全部数据
                String pOledbCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName +
                    ";Extended Properties=Excel 8.0;";
                OleDbConnection oledbCon = new OleDbConnection(pOledbCon);//创建Oledb数据库连接对象
                string pExcelSql = "";//记录要执行的Excel查询语句
                OleDbDataAdapter oledba = null;//创建Oledb数据桥连接器对象
                string sheetName = "Sheet1";
                pExcelSql = String.Format("select * from [{0}$]", sheetName);//可以考虑修改为可配置
                oledba = new OleDbDataAdapter(pExcelSql, pOledbCon);
                oledba.Fill(myds, sheetName);
                
                if (myds.Tables[0].Rows.Count > 4)
                {
                    ///初始化title信息
                    DataRow r0 = myds.Tables[0].Rows[0];
                    string title1 = Convert.ToString(r0[0]);
                    title1 = title1.Trim();
                    if (!title1.Equals("人员基本信息表"))
                    {
                        string[] titles = title1.Split(' ');
                        this.titleInformation = new TitleInformation();
                        this.titleInformation.Xxmc = titles[0];
                        this.titleInformation.Xymc = titles[1];
                        this.titleInformation.Zymc = string.IsNullOrEmpty(titles[2]) ? titles[2] : titles[2].Replace("人员基本信息表", "");
                    }
                    DataRow r1 = myds.Tables[0].Rows[1];
                    string bjmcTemp = Convert.ToString(r1[1]);
                    if (!string.IsNullOrEmpty(bjmcTemp))
                    {
                        this.titleInformation.Bjmc = bjmcTemp;
                    }
                    string tbrmcTemp = Convert.ToString(r1[4]);
                    if (!string.IsNullOrEmpty(tbrmcTemp))
                    {
                        this.titleInformation.Tbrmc = tbrmcTemp;
                    }
                    string lxdhTemp = Convert.ToString(r1[7]);
                    if (!string.IsNullOrEmpty(lxdhTemp))
                    {
                        this.titleInformation.Lxdh = lxdhTemp;
                    }
                    DateTime dt = Convert.ToDateTime(r1[10]);
                    if (dt != null)
                    {
                        this.titleInformation.Tbrq = dt;
                    }
                    this.setTitleInformation();//设置title信息
                    ///初始化title信息
                    ///
                    for (int i = 3; i < myds.Tables[0].Rows.Count; i++)
                    {
                        DataRow r = myds.Tables[0].Rows[i];
                        StudentInfo stu = new StudentInfo();
                        stu.Bh = BhCount;//获取学生临时编号
                        stu.Xm = Convert.ToString(r[0]);
                        stu.Zjhm = Convert.ToString(r[1]);
                        stu.Xb = Convert.ToString(r[2]);
                        stu.Mz = Convert.ToString(r[3]);
                        stu.Whcd = Convert.ToString(r[4]);
                        stu.Zzmm = Convert.ToString(r[5]);
                        stu.Zjxy = Convert.ToString(r[6]);
                        stu.Hjdxzqh = Convert.ToString(r[7]);
                        stu.Hjdxz = Convert.ToString(r[8]);
                        stu.Hkxz = Convert.ToString(r[9]);
                        stu.Bzxx = Convert.ToString(r[10]);
                        if (!stu.CheckAllEmpty())
                        {
                            this.StuList.Add(stu);//添加学生信息
                        }
                    }
                }
                checkTool.checkAndSetStuList(this.StuList);//检测学生列表并置空错误项
                result = true;//标记正常处理完成
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }
            return result;
        }
        //保存学生数据到指定Excel文件中
        private bool saveFile(string fileName)
        {
            bool result = false;//默认保存失败
            try
            {
                //创建Excel对象
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                object missing = System.Reflection.Missing.Value;//获取缺少的object类型值
                //打开Excel文件
                Microsoft.Office.Interop.Excel.Workbook workBook = excel.Application.Workbooks.Add(true);
                Microsoft.Office.Interop.Excel.Worksheet workSheet = workBook.Worksheets["Sheet1"];//workBook.Worksheets.Add(missing, missing, missing, missing);
                int rowIndex = 1;//excel操作行标号
                Microsoft.Office.Interop.Excel.Range contentRange1 = excel.Range[workSheet.Cells[rowIndex, 1], workSheet.Cells[rowIndex, 11]];
                contentRange1.Merge();//合并单元格
                contentRange1.RowHeight = 1;
                rowIndex = rowIndex + 1;//第二行标号
                Microsoft.Office.Interop.Excel.Range contentRange2 = excel.Range[workSheet.Cells[rowIndex, 1], workSheet.Cells[rowIndex, 11]];
                contentRange2.Merge();//合并单元格
                contentRange2.RowHeight = 40;
                contentRange2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;//居中显示
                contentRange2.Font.Bold = true;
                contentRange2.Font.Name = "宋体";
                contentRange2.Font.Size = 18;
                contentRange2.NumberFormat = "@";//文本格式
                workSheet.Cells[rowIndex, 1] = this.titleInformation.Xxmc + " " + this.titleInformation.Xymc + " " + this.titleInformation.Zymc + "人员基本信息表";
                //contentRange2.UseStandardHeight = 5;
                rowIndex = rowIndex + 1;//第三行标号
                Microsoft.Office.Interop.Excel.Range contentRange3 = excel.Range[workSheet.Cells[rowIndex, 1], workSheet.Cells[rowIndex, 11]];
                contentRange3.RowHeight = 30;//设置行高
                contentRange3.NumberFormat = "@";//文本格式
                Microsoft.Office.Interop.Excel.Range contentRange31 = excel.Range[workSheet.Cells[rowIndex, 2], workSheet.Cells[rowIndex, 3]];
                contentRange31.Merge();
                workSheet.Cells[rowIndex, 1] = "班级：";
                workSheet.Cells[rowIndex, 2] = this.titleInformation.Bjmc;
                workSheet.Cells[rowIndex, 4] = "填表人：";
                workSheet.Cells[rowIndex, 5] = this.titleInformation.Tbrmc;
                workSheet.Cells[rowIndex, 7] = "联系方式：";
                workSheet.Cells[rowIndex, 8] = this.titleInformation.Lxdh;
                workSheet.Cells[rowIndex, 10] = "填表日期：";
                workSheet.Cells[rowIndex, 11] = this.titleInformation.Tbrq.ToString("yyyy/MM/dd");
                rowIndex = rowIndex + 1;//第四行标号
                Microsoft.Office.Interop.Excel.Range contentRange4 = excel.Range[workSheet.Cells[rowIndex, 1], workSheet.Cells[rowIndex, 11]];
                contentRange4.Worksheet.StandardWidth = 15;
                contentRange4.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                contentRange4.Borders.LineStyle = 1;//设置边框格式
                contentRange4.NumberFormat = "@";//文本格式
                workSheet.Cells[rowIndex, 1] = "姓名";
                workSheet.Cells[rowIndex, 2] = "身份证号";
                workSheet.Cells[rowIndex, 3] = "性别";
                workSheet.Cells[rowIndex, 4] = "民族";
                workSheet.Cells[rowIndex, 5] = "文化程度";
                workSheet.Cells[rowIndex, 6] = "政治面貌";
                workSheet.Cells[rowIndex, 7] = "宗教信仰";
                workSheet.Cells[rowIndex, 8] = "户籍地代码";
                workSheet.Cells[rowIndex, 9] = "户籍地详细地址";
                workSheet.Cells[rowIndex, 10] = "户口性质";
                workSheet.Cells[rowIndex, 11] = "备注";
                rowIndex = rowIndex + 1;//第五行标号开始进行数据录入
                foreach (StudentInfo stuItem in this.StuList)
                {
                    Microsoft.Office.Interop.Excel.Range contentRange = excel.Range[workSheet.Cells[rowIndex, 1], workSheet.Cells[rowIndex, 11]];
                    contentRange.Worksheet.StandardWidth = 15;
                    contentRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    contentRange.NumberFormat = "@";//文本格式
                    contentRange.Borders.LineStyle = 1;//设置边框格式
                    workSheet.Cells[rowIndex, 1] = stuItem.Xm;
                    workSheet.Cells[rowIndex, 2] = stuItem.Zjhm;
                    workSheet.Cells[rowIndex, 3] = stuItem.Xb;
                    workSheet.Cells[rowIndex, 4] = stuItem.Mz;
                    workSheet.Cells[rowIndex, 5] = stuItem.Whcd;
                    workSheet.Cells[rowIndex, 6] = stuItem.Zzmm;
                    workSheet.Cells[rowIndex, 7] = stuItem.Zjxy;
                    workSheet.Cells[rowIndex, 8] = stuItem.Hjdxzqh;
                    workSheet.Cells[rowIndex, 9] = stuItem.Hjdxz;
                    workSheet.Cells[rowIndex, 10] = stuItem.Hkxz;
                    workSheet.Cells[rowIndex, 11] = stuItem.Bzxx;
                    rowIndex++;//换下一行
                }
                excel.Application.DisplayAlerts = false;//不显示提示对话框
                workBook.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlAddIn8);//保存工作表:xlAddIn8设置输出格式为xls
                workBook.Close(false, missing, missing);
                //获取并关闭Excel相关进程
                System.Diagnostics.Process[] excelProcess = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (System.Diagnostics.Process p in excelProcess)
                {
                    p.Kill();
                }
                result = true;//标志正常写入完成
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }
            return result;
        }
        //从Title面板中获取TitleInformation类信息
        private void getTitleInformation()
        {
            this.titleInformation = new TitleInformation();
            this.titleInformation.Xxmc = xxxxbox.Text.Trim();//获取学校名称
            this.titleInformation.Xymc = xyxxbox.Text.Trim();//获取学院名称
            this.titleInformation.Zymc = zyxxbox.Text.Trim();//获取专业名称
            this.titleInformation.Bjmc = bjxxbox.Text.Trim();//获取班级名称
            this.titleInformation.Tbrmc = tbrxxbox.Text.Trim();//获取填表人名称
            this.titleInformation.Lxdh = lxdhbox.Text.Trim();//联获取系方式
            this.titleInformation.Tbrq = tbrqbox.Value;//获取填表日期
        }
        //为Title面板中TitleInformation类信息赋值
        private void setTitleInformation()
        {
            //判断当前titleInformation类是不是进行了初始化
            if (this.titleInformation != null)
            {
                xxxxbox.Text = this.titleInformation.Xxmc;
                xyxxbox.Text = this.titleInformation.Xymc;
                zyxxbox.Text = this.titleInformation.Zymc;
                bjxxbox.Text = this.titleInformation.Bjmc;
                tbrxxbox.Text = this.titleInformation.Tbrmc;
                lxdhbox.Text = this.titleInformation.Lxdh;
                tbrqbox.Text = this.titleInformation.Tbrq.ToString("yyyy/MM/dd");
            }
        }
        //判断Title面板中的信息是否填写
        private bool judgeTitleFillIn()
        {
            bool result = true;//默认信息填写不完整
            if (checkTool.isNotFillIn(this.xxxxbox.Text.Trim()))
            {
                result = false;
                MessageBox.Show("学校名称信息没有填写，请输入学校名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            if (checkTool.isNotFillIn(this.xyxxbox.Text.Trim()))
            {
                result = false;
                MessageBox.Show("学院名称信息没有填写，请输入学院名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            if (checkTool.isNotFillIn(this.zyxxbox.Text.Trim()))
            {
                result = false;
                MessageBox.Show("专业名称信息没有填写，请输入专业名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            if (checkTool.isNotFillIn(this.bjxxbox.Text.Trim()))
            {
                result = false;
                MessageBox.Show("班级名称信息没有填写，请输入班级名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            if (checkTool.isNotFillIn(this.tbrxxbox.Text.Trim()))
            {
                result = false;
                MessageBox.Show("填表人信息没有填写，请输入填表人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            if (checkTool.isNotFillIn(this.lxdhbox.Text.Trim()))
            {
                result = false;
                MessageBox.Show("联系方式信息没有填写，请输入填表人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            if (checkTool.isNotFillIn(this.tbrqbox.Text.Trim()))
            {
                result = false;
                MessageBox.Show("填表日期没有填写，请输入填表日期！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            return result;
        }
        //判断要保存数据是否存在错误
        private bool judgeStuInfo()
        {
            bool result = false;
            List<ErrorMsg> errors = new List<ErrorMsg>();
            for (int i = 0; i < this.StuList.Count; i++ )
            {
                StudentInfo stu = this.StuList[i];
                errors = this.CheckTool.checkStuInfo(stu, this.StuList);//判断当前行是否有错误
                if (errors.Count > 0)
                {
                    this.studatagrid.ClearSelection();//清除选中项
                    this.studatagrid.CurrentCell = this.studatagrid.Rows[i].Cells[1];
                    this.studatagrid.Rows[i].Selected = true;//设置被选中项
                    result = true;
                    break;
                }
            }
            //如果存在错误，通过窗体显示错误
            if (result)
            {
                MsgForm mForm = new MsgForm(errors);//初始化错误窗体
                mForm.ShowDialog();
            }
            return result;
        }
        //判断是否存在8位日期数据
        private bool judgeEightExist()
        {
            bool result = false;
            result = this.CheckTool.checkEightExist(this.StuList);
            return result;
        }
        //判断身份证号是否重复
        public bool judgeDuplicate(StudentInfo stu)
        {
            bool result = false;
            result = this.CheckTool.isStuDuplicate(stu, this.StuList);
            return result;
        }
    }
}
