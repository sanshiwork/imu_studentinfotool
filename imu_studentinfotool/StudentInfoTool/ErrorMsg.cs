using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInfoTool
{
    public class ErrorMsg
    {
        private int bh;//临时编号信息
        private int type;//错误类型，1代表必填项未填，2代表填入项不正确
        private string msg;//错误描述信息

        public int Bh
        {
            get { return bh; }
            set { bh = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
    }
}
