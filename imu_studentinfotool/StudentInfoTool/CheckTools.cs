using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
namespace StudentInfoTool
{
    public class CheckTools
    {
        private IdCardValidator idcardValidator;//身份证验证器
        private List<CommonItem> xbs;//性别数据
        private List<CommonItem> mzs;//民族数据
        private List<CommonItem> whcds;//文化程度数据
        private List<CommonItem> zzmms;//政治面貌数据
        private List<CommonItem> zjxys;//宗教信仰数据
        private List<CommonItem> hkxzs;//户口性质数据
        private List<QuHua> qhs;//区划信息数据
        private DbHelper dbHelper;//数据库操作类
        private List<ErrorMsg> errorList;//错误信息列表

        public List<CommonItem> Xbs
        {
            get { return xbs; }
            set { xbs = value; }
        }
        public List<CommonItem> Mzs
        {
            get { return mzs; }
            set { mzs = value; }
        }
        public List<CommonItem> Whcds
        {
            get { return whcds; }
            set { whcds = value; }
        }
        public List<CommonItem> Zzmms
        {
            get { return zzmms; }
            set { zzmms = value; }
        }
        public List<CommonItem> Zjxys
        {
            get { return zjxys; }
            set { zjxys = value; }
        }
        public List<CommonItem> Hkxzs
        {
            get { return hkxzs; }
            set { hkxzs = value; }
        }
        public List<QuHua> Qhs
        {
            get { return qhs; }
            set { qhs = value; }
        }
        public List<ErrorMsg> ErrorList
        {
            get { return errorList; }
            set { errorList = value; }
        }

        public CheckTools()
        {
            idcardValidator = new IdCardValidator();//初始化身份证验证器
            xbs = new List<CommonItem>();
            mzs = new List<CommonItem>();
            whcds = new List<CommonItem>();
            zzmms = new List<CommonItem>();
            zjxys = new List<CommonItem>();
            hkxzs = new List<CommonItem>();
            qhs = new List<QuHua>();
            dbHelper = new DbHelper();//初始化数据库类
            initDatas();//初始化学生信息验证数据
        }
        private void initDatas()
        {
            initXbs();//初始化性别信息
            initMzs();//初始化民族信息
            initWhcds();//初始化文化程度
            initZjxys();//初始化宗教信仰
            initZzmms();//初始化政治面貌
            initHkxzs();//初始化户口性质
            initQhs();//初始化区划
        }
        //初始化性别数据
        private bool initXbs()
        {
            bool result = false;//默认初始化失败
            try
            {
                DataTable dt = dbHelper.GetDataBySql("select * from T_BC_DMXB");
                foreach (DataRow row in dt.Rows)
                {
                    CommonItem item = new CommonItem();
                    item.Dm = Convert.ToString(row["DM"]);
                    item.Mc = Convert.ToString(row["MC"]);
                    this.Xbs.Add(item);
                }
                result = true;//初始化成功
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;//初始化失败
            }
            return result;
        }
        //初始化民族数据
        private bool initMzs()
        {
            bool result = false;//默认初始化失败
            try
            {
                DataTable dt = dbHelper.GetDataBySql("select * from T_BC_DMMZ");
                foreach (DataRow row in dt.Rows)
                {
                    CommonItem item = new CommonItem();
                    item.Dm = Convert.ToString(row["DM"]);
                    item.Mc = Convert.ToString(row["MC"]);
                    this.Mzs.Add(item);
                }
                result = true;//初始化成功
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;//初始化失败
            }
            return result;
        }
        //初始化文化程度数据
        private bool initWhcds()
        {
            bool result = false;//默认初始化失败
            try
            {
                DataTable dt = dbHelper.GetDataBySql("select * from T_BC_DMWHCD");
                foreach (DataRow row in dt.Rows)
                {
                    CommonItem item = new CommonItem();
                    item.Dm = Convert.ToString(row["DM"]);
                    item.Mc = Convert.ToString(row["MC"]);
                    this.Whcds.Add(item);
                }
                result = true;//初始化成功
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;//初始化失败
            }
            return result;
        }
        //初始化政治面貌数据
        private bool initZzmms()
        {
            bool result = false;//默认初始化失败
            try
            {
                DataTable dt = dbHelper.GetDataBySql("select * from T_BC_DMZZMM");
                foreach (DataRow row in dt.Rows)
                {
                    CommonItem item = new CommonItem();
                    item.Dm = Convert.ToString(row["DM"]);
                    item.Mc = Convert.ToString(row["MC"]);
                    this.Zzmms.Add(item);
                }
                result = true;//初始化成功
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;//初始化失败
            }
            return result;
        }
        //初始化宗教信仰数据
        private bool initZjxys()
        {
            bool result = false;//默认初始化失败
            try
            {
                DataTable dt = dbHelper.GetDataBySql("select * from T_BC_DMZJXY");
                foreach (DataRow row in dt.Rows)
                {
                    CommonItem item = new CommonItem();
                    item.Dm = Convert.ToString(row["DM"]);
                    item.Mc = Convert.ToString(row["MC"]);
                    this.Zjxys.Add(item);
                }
                result = true;//初始化成功
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;//初始化失败
            }
            return result;
        }
        //初始化户口性质数据
        private bool initHkxzs()
        {
            bool result = false;//默认初始化失败
            try
            {
                DataTable dt = dbHelper.GetDataBySql("select * from T_BC_DMHKXZ");
                foreach (DataRow row in dt.Rows)
                {
                    CommonItem item = new CommonItem();
                    item.Dm = Convert.ToString(row["DM"]);
                    item.Mc = Convert.ToString(row["MC"]);
                    this.Hkxzs.Add(item);
                }
                result = true;//初始化成功
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;//初始化失败
            }
            return result;
        }
        //初始化区划信息
        private bool initQhs()
        {
            bool result = false;//默认初始化失败
            try
            {
                DataTable dt = dbHelper.GetDataBySql("select * from T_BC_QH where sjqhdm = '000000000000'");
                foreach (DataRow row in dt.Rows)
                {
                    QuHua item = new QuHua();
                    item.Qhdm = Convert.ToString(row["QHDM"]);
                    item.Qhmc = Convert.ToString(row["QHMC"]);
                    item.Qhjb = Convert.ToString(row["QHJB"]);
                    item.Sjqhdm = Convert.ToString(row["SJQHDM"]);
                    this.Qhs.Add(item);
                }
                result = true;//初始化成功
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;//初始化失败
            }
            return result;
        }
        //根据上级区划代码获取子区划信息
        public List<QuHua> getQhs(string sjqhdm)
        {
            List<QuHua> list = new List<QuHua>();
            try
            {
                DataTable dt = dbHelper.GetDataBySql(string.Format("select * from T_BC_QH where sjqhdm = '{0}'",sjqhdm));
                foreach (DataRow row in dt.Rows)
                {
                    QuHua item = new QuHua();
                    item.Qhdm = Convert.ToString(row["QHDM"]);
                    item.Qhmc = Convert.ToString(row["QHMC"]);
                    item.Qhjb = Convert.ToString(row["QHJB"]);
                    item.Sjqhdm = Convert.ToString(row["SJQHDM"]);
                    list.Add(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list;
        }
        //检查身份证号输入是否正确，未使用
        public bool checkIdCard(string idcard)
        {
            bool result = false;
            if (String.IsNullOrEmpty(idcard))
            {
                result = false;
            }
            else 
            {
                result = idcardValidator.CheckIDCard(idcard);//检查身份证号是否正确
            }
            return result;
        }
        //判断性别是否有效
        public bool checkXb(string xb)
        {
            bool result = false;
            foreach (CommonItem item in Xbs)
            {
                if (xb.Equals(item.Mc))
                {
                    result = true;//如果输入数据在列表中存在，则验证通过
                    break;
                }
            }
            return result;//返回验证结果
        }
        //判断民族是否有效
        public bool checkMz(string mz)
        {
            bool result = false;
            foreach (CommonItem item in Mzs)
            {
                if (mz.Equals(item.Mc))
                {
                    result = true;//如果输入数据在列表中存在，则验证通过
                    break;
                }
            }
            return result;//返回验证结果
        }
        //判断文化程度是否有效
        public bool checkWhcd(string whcd)
        {
            bool result = false;
            foreach (CommonItem item in Whcds)
            {
                if (whcd.Equals(item.Mc))
                {
                    result = true;//如果输入数据在列表中存在，则验证通过
                    break;
                }
            }
            return result;//返回验证结果
        }
        //判断政治面貌是否有效
        public bool checkZzmm(string zzmm)
        {
            bool result = false;
            foreach (CommonItem item in Zzmms)
            {
                if (zzmm.Equals(item.Mc))
                {
                    result = true;//如果输入数据在列表中存在，则验证通过
                    break;
                }
            }
            return result;//返回验证结果
        }
        //判断宗教信仰是否有效
        public bool checkZjxy(string zjxy)
        {
            bool result = false;
            foreach (CommonItem item in Zjxys)
            {
                if (zjxy.Equals(item.Mc))
                {
                    result = true;//如果输入数据在列表中存在，则验证通过
                    break;
                }
            }
            return result;//返回验证结果
        }
        //判断户口性质是否有效
        public bool checkHkxz(string hkxz)
        {
            bool result = false;
            foreach (CommonItem item in Hkxzs)
            {
                if (hkxz.Equals(item.Mc))
                {
                    result = true;//如果输入数据在列表中存在，则验证通过
                    break;
                }
            }
            return result;//返回验证结果
        }
        //判断日期数据是否正确
        public bool checkDateFormat(string date)
        {
            bool result = false;
            string year = date.Substring(0, 4);
            string month = date.Substring(4, 2);
            string day = date.Substring(6, 2);
            date = year + "/" + month + "/" + day;
            DateTime rDate;
            if (DateTime.TryParse(date, out rDate))
            {
                result = true;//验证正确
            }
            else
            {
                result = false;
            }
            return result;//返回验证结果
        }
        //判断电话格式是否正确
        public bool checkTelNum(string tel)
        {
            bool result = false;
            result = Regex.IsMatch(tel, @"^1[3|4|5|7|8]\d{9}$") || Regex.IsMatch(tel, @"^0\d{2,3}-?\d{7,8}$");
            return result;
        }
        //判断证件号格式是否正确
        public bool checkZjhm(string zjhm)
        {
            bool result = false;
            if (zjhm.Length == 15 || zjhm.Length == 18)
            {
                result = this.idcardValidator.CheckIDCard(zjhm);
            }
            else if (zjhm.Length == 8)
            {
                result = checkDateFormat(zjhm);
            }
            return result;
        }
        //判断行政区划代码是否存在
        public bool checkHjdxzqh(string hjdxzqh)
        {
            bool result = false;
            try
            {
                DataTable dt = dbHelper.GetDataBySql(string.Format("select * from T_BC_QH where qhdm = '{0}'", hjdxzqh));
                if (dt.Rows.Count >= 1)
                {
                    result = true;//户籍地代码信息存在
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;//户籍地代码验证错误
            }
            return result;
        }
        //填写判断函数
        public bool isFillIn(string content)
        {
            bool result = !string.IsNullOrEmpty(content);//判断填写内容是否为空
            return result;
        }
        //没有填写判断函数
        public bool isNotFillIn(string content)
        {
            bool result = string.IsNullOrEmpty(content);
            return result;
        }
        //根据身份证号判断学生信息是否重复
        public bool isStuDuplicate(StudentInfo stu, List<StudentInfo> stuList)
        {
            bool result = false;
            foreach (StudentInfo item in stuList)
            {
                if (item.Zjhm.Length == 18 || item.Zjhm.Length == 15)
                {
                    if (item.Zjhm.Equals(stu.Zjhm) && item.Bh != stu.Bh)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }
        //对单个学生信息进行正确性验证
        public List<ErrorMsg> checkStuInfo(StudentInfo stu, List<StudentInfo> stuList)
        {
            List<ErrorMsg> list = new List<ErrorMsg>();
            //姓名检查
            if (this.isNotFillIn(stu.Xm))
            {
                ErrorMsg error = new ErrorMsg();
                error.Bh = stu.Bh;//获得临时变量
                error.Type = 1;
                error.Msg = "姓名为必填信息！";
                list.Add(error);
            }
            //身份证检查
            if (this.isNotFillIn(stu.Zjhm))
            {
                ErrorMsg error = new ErrorMsg();
                error.Bh = stu.Bh;//获得临时变量
                error.Type = 1;
                error.Msg = "身份证号为必填信息！";
                list.Add(error);
            }
            if (this.isFillIn(stu.Zjhm))
            {
                if (!this.checkZjhm(stu.Zjhm))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = stu.Bh;
                    error.Type = 2;
                    error.Msg = "身份证号格式不正确！";
                    list.Add(error);
                }
                if (this.isStuDuplicate(stu, stuList))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = stu.Bh;
                    error.Type = 2;
                    error.Msg = "身份证号在列表中已存在！";
                    list.Add(error);
                }
            }
            //性别检查
            if (this.isNotFillIn(stu.Xb))
            {
                ErrorMsg error = new ErrorMsg();
                error.Bh = stu.Bh;//获得临时变量
                error.Type = 1;
                error.Msg = "性别为必填信息！";
                list.Add(error);
            }
            if (this.isFillIn(stu.Xb))
            {
                if (!this.checkXb(stu.Xb))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = stu.Bh;
                    error.Type = 2;
                    error.Msg = "性别信息不正确！";
                    list.Add(error);
                }
            }
            //民族检查
            if (this.isNotFillIn(stu.Mz))
            {
                ErrorMsg error = new ErrorMsg();
                error.Bh = stu.Bh;//获得临时变量
                error.Type = 1;
                error.Msg = "民族为必填信息！";
                list.Add(error);
            }
            if (this.isFillIn(stu.Mz))
            {
                if (!this.checkMz(stu.Mz))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = stu.Bh;
                    error.Type = 2;
                    error.Msg = "民族信息不正确！";
                    list.Add(error);
                }
            }
            //文化程度检查
            if (this.isNotFillIn(stu.Whcd))
            {
                ErrorMsg error = new ErrorMsg();
                error.Bh = stu.Bh;//获得临时变量
                error.Type = 1;
                error.Msg = "文化程度为必填信息！";
                list.Add(error);
            }
            if (this.isFillIn(stu.Whcd))
            {
                if (!this.checkWhcd(stu.Whcd))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = stu.Bh;
                    error.Type = 2;
                    error.Msg = "文化程度信息不正确！";
                    list.Add(error);
                }
            }
            //政治面貌检查
            if (this.isNotFillIn(stu.Zzmm))
            {
                ErrorMsg error = new ErrorMsg();
                error.Bh = stu.Bh;//获得临时变量
                error.Type = 1;
                error.Msg = "政治面貌为必填信息！";
                list.Add(error);
            }
            if (this.isFillIn(stu.Zzmm))
            {
                if (!this.checkZzmm(stu.Zzmm))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = stu.Bh;
                    error.Type = 2;
                    error.Msg = "政治面貌信息不正确！";
                    list.Add(error);
                }
            }
            //宗教信仰检查
            if (this.isNotFillIn(stu.Zjxy))
            {
                ErrorMsg error = new ErrorMsg();
                error.Bh = stu.Bh;//获得临时变量
                error.Type = 1;
                error.Msg = "宗教信仰为必填信息！";
                list.Add(error);
            }
            if (this.isFillIn(stu.Zjxy))
            {
                if (!this.checkZjxy(stu.Zjxy))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = stu.Bh;
                    error.Type = 2;
                    error.Msg = "宗教信仰信息不正确！";
                    list.Add(error);
                }
            }
            //户籍地代码检查
            if (this.isNotFillIn(stu.Hjdxzqh))
            {
                ErrorMsg error = new ErrorMsg();
                error.Bh = stu.Bh;//获得临时变量
                error.Type = 1;
                error.Msg = "户籍地代码为必填信息！";
                list.Add(error);
            }
            if (this.isFillIn(stu.Hjdxzqh))
            {
                if (!this.checkHjdxzqh(stu.Hjdxzqh))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = stu.Bh;
                    error.Type = 2;
                    error.Msg = "户籍地代码信息不正确！";
                    list.Add(error);
                }
            }
            //户籍地详址
            if (this.isNotFillIn(stu.Hjdxz))
            {
                ErrorMsg error = new ErrorMsg();
                error.Bh = stu.Bh;//获得临时变量
                error.Type = 1;
                error.Msg = "户籍地详址为必填信息！";
                list.Add(error);
            }
            //户口性质检查
            if (this.isNotFillIn(stu.Hkxz))
            {
                ErrorMsg error = new ErrorMsg();
                error.Bh = stu.Bh;//获得临时变量
                error.Type = 1;
                error.Msg = "户口性质为必填信息！";
                list.Add(error);
            }
            if (this.isFillIn(stu.Hkxz))
            {
                if (!this.checkHkxz(stu.Hkxz))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = stu.Bh;
                    error.Type = 2;
                    error.Msg = "户口性质信息不正确！";
                    list.Add(error);
                }
            }
            return list;
        }
        //对学生信息列表进行正确性验证
        public List<ErrorMsg> checkStuList(List<StudentInfo> stuList)
        {
            this.errorList = new List<ErrorMsg>();
            foreach (StudentInfo item in stuList)
            {
                //姓名检查
                if (this.isNotFillIn(item.Xm))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = item.Bh;//获得临时变量
                    error.Type = 1;
                    error.Msg = "姓名为必填信息！";
                    this.errorList.Add(error);
                }
                //身份证检查
                if (this.isNotFillIn(item.Zjhm))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = item.Bh;//获得临时变量
                    error.Type = 1;
                    error.Msg = "身份证号为必填信息！";
                    this.errorList.Add(error);
                }
                if(this.isFillIn(item.Zjhm))
                {
                    if (!this.checkZjhm(item.Zjhm))
                    {
                        ErrorMsg error = new ErrorMsg();
                        error.Bh = item.Bh;
                        error.Type = 2;
                        error.Msg = "身份证号格式不正确！";
                        this.ErrorList.Add(error);
                    }
                }
                //性别检查
                if (this.isNotFillIn(item.Xb))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = item.Bh;//获得临时变量
                    error.Type = 1;
                    error.Msg = "性别为必填信息！";
                    this.errorList.Add(error);
                }
                if (this.isFillIn(item.Xb))
                {
                    if (!this.checkXb(item.Xb))
                    {
                        ErrorMsg error = new ErrorMsg();
                        error.Bh = item.Bh;
                        error.Type = 2;
                        error.Msg = "性别信息不正确！";
                        this.ErrorList.Add(error);
                    }
                }
                //民族检查
                if (this.isNotFillIn(item.Mz))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = item.Bh;//获得临时变量
                    error.Type = 1;
                    error.Msg = "民族为必填信息！";
                    this.errorList.Add(error);
                }
                if (this.isFillIn(item.Mz))
                {
                    if (!this.checkMz(item.Mz))
                    {
                        ErrorMsg error = new ErrorMsg();
                        error.Bh = item.Bh;
                        error.Type = 2;
                        error.Msg = "民族信息不正确！";
                        this.ErrorList.Add(error);
                    }
                }
                //文化程度检查
                if (this.isNotFillIn(item.Whcd))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = item.Bh;//获得临时变量
                    error.Type = 1;
                    error.Msg = "文化程度为必填信息！";
                    this.errorList.Add(error);
                }
                if (this.isFillIn(item.Whcd))
                {
                    if (!this.checkWhcd(item.Whcd))
                    {
                        ErrorMsg error = new ErrorMsg();
                        error.Bh = item.Bh;
                        error.Type = 2;
                        error.Msg = "文化程度信息不正确！";
                        this.ErrorList.Add(error);
                    }
                }
                //政治面貌检查
                if (this.isNotFillIn(item.Zzmm))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = item.Bh;//获得临时变量
                    error.Type = 1;
                    error.Msg = "政治面貌为必填信息！";
                    this.errorList.Add(error);
                }
                if (this.isFillIn(item.Zzmm))
                {
                    if (!this.checkZzmm(item.Zzmm))
                    {
                        ErrorMsg error = new ErrorMsg();
                        error.Bh = item.Bh;
                        error.Type = 2;
                        error.Msg = "政治面貌信息不正确！";
                        this.ErrorList.Add(error);
                    }
                }
                //宗教信仰检查
                if (this.isNotFillIn(item.Zjxy))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = item.Bh;//获得临时变量
                    error.Type = 1;
                    error.Msg = "宗教信仰为必填信息！";
                    this.errorList.Add(error);
                }
                if (this.isFillIn(item.Zjxy))
                {
                    if (!this.checkZjxy(item.Zjxy))
                    {
                        ErrorMsg error = new ErrorMsg();
                        error.Bh = item.Bh;
                        error.Type = 2;
                        error.Msg = "宗教信仰信息不正确！";
                        this.ErrorList.Add(error);
                    }
                }
                //户籍地代码检查
                if (this.isNotFillIn(item.Hjdxzqh))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = item.Bh;//获得临时变量
                    error.Type = 1;
                    error.Msg = "户籍地代码为必填信息！";
                    this.errorList.Add(error);
                }
                if (this.isFillIn(item.Hjdxzqh))
                {
                    if (!this.checkHjdxzqh(item.Hjdxzqh))
                    {
                        ErrorMsg error = new ErrorMsg();
                        error.Bh = item.Bh;
                        error.Type = 2;
                        error.Msg = "户籍地代码信息不正确！";
                        this.ErrorList.Add(error);
                    }
                }
                //户籍地详址
                if (this.isNotFillIn(item.Hjdxz))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = item.Bh;//获得临时变量
                    error.Type = 1;
                    error.Msg = "户籍地详址为必填信息！";
                    this.errorList.Add(error);
                }
                //户口性质检查
                if (this.isNotFillIn(item.Hkxz))
                {
                    ErrorMsg error = new ErrorMsg();
                    error.Bh = item.Bh;//获得临时变量
                    error.Type = 1;
                    error.Msg = "户籍地性质为必填信息！";
                    this.errorList.Add(error);
                }
                if (this.isFillIn(item.Hkxz))
                {
                    if (!this.checkHkxz(item.Hkxz))
                    {
                        ErrorMsg error = new ErrorMsg();
                        error.Bh = item.Bh;
                        error.Type = 2;
                        error.Msg = "户籍地性质信息不正确！";
                        this.ErrorList.Add(error);
                    }
                }
            }
            return this.errorList;
        }
        //检查学生数据输入是否正确，错误数据置空
        public void checkAndSetStuList(List<StudentInfo> stuList)
        {
            foreach (StudentInfo item in stuList)
            {
                //身份证检查
                if (this.isFillIn(item.Zjhm))
                {
                    if (!this.checkZjhm(item.Zjhm))
                    {
                        item.Zjhm = "";
                    }
                }
                //性别检查
                if (this.isFillIn(item.Xb))
                {
                    if (!this.checkXb(item.Xb))
                    {
                        item.Xb = "";
                    }
                }
                //民族检查
                if (this.isFillIn(item.Mz))
                {
                    if (!this.checkMz(item.Mz))
                    {
                        item.Mz = "";
                    }
                }
                //文化程度检查
                if (this.isFillIn(item.Whcd))
                {
                    if (!this.checkWhcd(item.Whcd))
                    {
                        item.Whcd = "";
                    }
                }
                //政治面貌检查
                if (this.isFillIn(item.Zzmm))
                {
                    if (!this.checkZzmm(item.Zzmm))
                    {
                        item.Zzmm = "";
                    }
                }
                //宗教信仰检查
                if (this.isFillIn(item.Zjxy))
                {
                    if (!this.checkZjxy(item.Zjxy))
                    {
                        item.Zjxy = "";
                    }
                }
                //户籍地代码检查
                if (this.isFillIn(item.Hjdxzqh))
                {
                    if (!this.checkHjdxzqh(item.Hjdxzqh))
                    {
                        item.Hjdxzqh = "";
                    }
                }
                //户口性质检查
                if (this.isFillIn(item.Hkxz))
                {
                    if (!this.checkHkxz(item.Hkxz))
                    {
                        item.Hkxz = "";
                    }
                }
            }
        }
        //判断当前是否存在位数存在8位日期
        public bool checkEightExist(List<StudentInfo> stuList)
        {
            bool result = false;
            foreach (StudentInfo stu in stuList)
            {
                if (stu.Zjhm.Length == 8)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
