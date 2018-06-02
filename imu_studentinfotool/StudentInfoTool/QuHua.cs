using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInfoTool
{
    public class QuHua
    {
        private string qhdm;//区划代码
        private string qhmc;//区划名称
        private string qhjb;//区划级别
        private string sjqhdm;//上级区划代码

        public string Qhdm
        {
            get { return qhdm; }
            set { qhdm = value; }
        }
        public string Qhmc
        {
            get { return qhmc; }
            set { qhmc = value; }
        }
        public string Qhjb
        {
            get { return qhjb; }
            set { qhjb = value; }
        }
        public string Sjqhdm
        {
            get { return sjqhdm; }
            set { sjqhdm = value; }
        }
    }
}
