using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace StudentInfoTool
{
    class DbHelper
    {
        private string accessString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Windows.Forms.Application.StartupPath.Trim() + "\\checkdb.mdb";
        public DataTable GetDataBySql(string sql)//通过sql语句查询出结果
        {
            DataTable dt = new DataTable();
            OleDbConnection conn = new OleDbConnection(this.accessString);
            OleDbCommand comm = new OleDbCommand();
            try
            {
                comm.Connection = conn;
                conn.Open();
                string selectString = sql;//将sql语句放入函数来运行
                comm.CommandText = selectString;
                OleDbDataAdapter adap = new OleDbDataAdapter(comm);
                adap.Fill(dt);
            }
            catch (OleDbException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                conn.Close();
                comm.Dispose();
            }
            return dt;
        }
    }
}
