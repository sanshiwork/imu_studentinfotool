using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInfoTool
{
    /// <summary>
    /// TitleInformation类
    /// 2015-09-08
    /// </summary>
    public class TitleInformation
    {
        private string xxmc;//学校名称字段
        private string xymc;//学院名称字段
        private string zymc;//专业名称字段
        private string bjmc;//班级名称字段
        private string tbrmc;//填表人名称字段
        private string lxdh;//联系方式
        private DateTime tbrq;//填表日期字段

        public string Xxmc
        {
            get { return xxmc; }
            set { xxmc = value; }
        }
        public string Xymc
        {
            get { return xymc; }
            set { xymc = value; }
        }
        public string Zymc
        {
            get { return zymc; }
            set { zymc = value; }
        }
        public string Bjmc
        {
            get { return bjmc; }
            set { bjmc = value; }
        }
        public string Tbrmc
        {
            get { return tbrmc; }
            set { tbrmc = value; }
        }
        public string Lxdh
        {
            get { return lxdh; }
            set { lxdh = value; }
        }
        public DateTime Tbrq
        {
            get { return tbrq; }
            set { tbrq = value; }
        }
    }
}
