using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInfoTool
{
    public class StudentInfo
    {
        private int bh;//学生临时编号
        private String xm;//学生姓名
        private String zjhm;//学生身份证号码
        private String xb;//学生性别
        private String csrq;//出生日期
        private String mz;//民族
        private String lxdh;//联系电话
        private String whcd;//文化程度
        private String zzmm;//政治面貌
        private String zjxy;//宗教信仰
        private String hjdxzqh;//户籍地代码
        private String hjdxz;//户籍地详细地址
        private String hkxz;//户口性质
        private String bzxx;//备注信息


        public int Bh
        {
            get { return bh; }
            set { bh = value; }
        }
        public String Xm
        {
            get { return xm; }
            set { xm = value; }
        }
        public String Zjhm
        {
            get { return zjhm; }
            set { zjhm = value; }
        }
        public String Xb
        {
            get { return xb; }
            set { xb = value; }
        }
        public String Csrq
        {
            get { return csrq; }
            set { csrq = value; }
        }

        public String Mz
        {
            get { return mz; }
            set { mz = value; }
        }
        public String Lxdh
        {
            get { return lxdh; }
            set { lxdh = value; }
        }

        public String Whcd
        {
            get { return whcd; }
            set { whcd = value; }
        }

        public String Zzmm
        {
            get { return zzmm; }
            set { zzmm = value; }
        }

        public String Zjxy
        {
            get { return zjxy; }
            set { zjxy = value; }
        }

        public String Hjdxzqh
        {
            get { return hjdxzqh; }
            set { hjdxzqh = value; }
        }

        public String Hjdxz
        {
            get { return hjdxz; }
            set { hjdxz = value; }
        }
        
        public String Hkxz
        {
            get { return hkxz; }
            set { hkxz = value; }
        }

        public String Bzxx
        {
            get { return bzxx; }
            set { bzxx = value; }
        }
        //判断当前学生信息是否全空
        public bool CheckAllEmpty()
        {
            bool result = true;//默认全空
            if (!String.IsNullOrEmpty(this.xm))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.zjhm))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.xb))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.csrq))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.mz))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.lxdh))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.whcd))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.zzmm))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.zjxy))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.hjdxzqh))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.hjdxz))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.hkxz))
            {
                result = false;
                return result;
            }
            if (!String.IsNullOrEmpty(this.bzxx))
            {
                result = false;
                return result;
            }
            return result;
        }
    }
}
