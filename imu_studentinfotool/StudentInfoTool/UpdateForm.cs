using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data.OleDb;

namespace StudentInfoTool
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        //从远程数据库中更新验证信息
        private void updatebtn_Click(object sender, EventArgs e)
        {
            String connString = @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));User Id=QYCS1_DB;Password=jhsy";
            String accessString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Windows.Forms.Application.StartupPath.Trim() + "\\checkdb.mdb";
            OracleConnection oraCon = new OracleConnection(connString);
            OleDbConnection connAccess = new OleDbConnection(accessString);
            Boolean flag = false;//标记处理失败
            connAccess.Open();
            this.updatebtn.Enabled = false;//更新按钮不可用
            //OleDbTransaction trans = connAccess.BeginTransaction();//开启访问Access数据库的事务
            try
            {
                string deleteXb = "delete * from T_BC_DMXB";
                string deleteMz = "delete * from T_BC_DMMZ";
                string deleteWHCD = "delete * from T_BC_DMWHCD";
                string deleteZZMM = "delete * from T_BC_DMZZMM";
                string deleteZJXY = "delete * from T_BC_DMZJXY";
                string deleteHKXZ = "delete * from T_BC_DMHKXZ";
                string deleteQH = "delete * from T_BC_QH";
                OleDbCommand command = new OleDbCommand(deleteXb, connAccess);
                command.ExecuteNonQuery();
                command = new OleDbCommand(deleteMz, connAccess);
                command.ExecuteNonQuery();
                command = new OleDbCommand(deleteWHCD, connAccess);
                command.ExecuteNonQuery();
                command = new OleDbCommand(deleteZZMM, connAccess);
                command.ExecuteNonQuery();
                command = new OleDbCommand(deleteZJXY, connAccess);
                command.ExecuteNonQuery();
                command = new OleDbCommand(deleteHKXZ, connAccess);
                command.ExecuteNonQuery();
                command = new OleDbCommand(deleteQH, connAccess);
                command.ExecuteNonQuery();
                //新建一个DataAdapter用于填充DataSet
                OracleDataAdapter adapter = new OracleDataAdapter("select * from T_BC_DMXB", oraCon);//处理性别代码表
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string insertSql = string.Format(@"insert into T_BC_DMXB(DM,MC) values('{0}','{1}')", r["DM"].ToString(), r["MC"].ToString());
                    OleDbCommand cmdInsert = new OleDbCommand(insertSql, connAccess);
                    cmdInsert.ExecuteNonQuery();
                }
                //处理民族代码表
                adapter = new OracleDataAdapter("select * from T_BC_DMMZ", oraCon);
                ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string insertSql = string.Format(@"insert into T_BC_DMMZ(DM,MC) values('{0}','{1}')", r["DM"].ToString(), r["MC"].ToString());
                    OleDbCommand cmdInsert = new OleDbCommand(insertSql, connAccess);
                    cmdInsert.ExecuteNonQuery();
                }
                //处理文化程度代码表
                adapter = new OracleDataAdapter("select * from T_BC_DMWHCD", oraCon);
                ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string insertSql = string.Format(@"insert into T_BC_DMWHCD(DM,MC) values('{0}','{1}')", r["DM"].ToString(), r["MC"].ToString());
                    OleDbCommand cmdInsert = new OleDbCommand(insertSql, connAccess);
                    cmdInsert.ExecuteNonQuery();
                }
                //处理政治面貌代码表
                adapter = new OracleDataAdapter("select * from T_BC_DMZZMM", oraCon);
                ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string insertSql = string.Format(@"insert into T_BC_DMZZMM(DM,MC) values('{0}','{1}')",r["DM"].ToString(), r["MC"].ToString());
                    OleDbCommand cmdInsert = new OleDbCommand(insertSql, connAccess);
                    cmdInsert.ExecuteNonQuery();
                }
                //处理宗教信仰代码表
                adapter = new OracleDataAdapter("select * from T_BC_DMZJXY", oraCon);
                ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string insertSql = string.Format(@"insert into T_BC_DMZJXY(DM,MC) values('{0}','{1}')", r["DM"].ToString(), r["MC"].ToString());
                    OleDbCommand cmdInsert = new OleDbCommand(insertSql, connAccess);
                    cmdInsert.ExecuteNonQuery();
                }
                //处理户口性质代码表
                adapter = new OracleDataAdapter("select * from T_BC_DMHKXZ", oraCon);
                ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string insertSql = string.Format(@"insert into T_BC_DMHKXZ(DM,MC) values('{0}','{1}')", r["DM"].ToString(), r["MC"].ToString());
                    OleDbCommand cmdInsert = new OleDbCommand(insertSql, connAccess);
                    cmdInsert.ExecuteNonQuery();
                }
                //处理户籍地代码表
                adapter = new OracleDataAdapter("select QHDM,QHMC,QHJB,SJQHDM,QHXZ from T_BC_QH", oraCon);
                ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    String msg = "";
                    try
                    {
                        string insertSql = string.Format(@"insert into T_BC_QH(QHDM,QHMC,QHJB,SJQHDM,QHXZ) values('{0}','{1}','{2}','{3}','{4}')",
                            Convert.ToString(r["QHDM"]), Convert.ToString(r["QHMC"]), Convert.ToString(r["QHJB"]), Convert.ToString(r["SJQHDM"]), Convert.ToString(r["QHXZ"]));
                        msg = insertSql;//获取插入语句
                        OleDbCommand cmdInsert = new OleDbCommand(insertSql, connAccess);
                        //cmdInsert.Transaction = trans;
                        cmdInsert.ExecuteNonQuery();
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine("出错语句：" + msg);
                        Console.WriteLine("插入出错：" + error.Message);
                    }
                }
                //trans.Commit();//事务提交
                flag = true;//正常处理结束
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                //trans.Rollback();//事务回滚
                flag = false;//事务处理失败
            }
            finally
            {
                connAccess.Close();
                //trans.Dispose();  
            }
            this.updatebtn.Enabled = true;//更新按钮不可用
            if (flag)
            {
                MessageBox.Show("验证数据库信息更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("验证数据库信息导入失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
