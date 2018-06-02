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
    public partial class MsgForm : Form
    {
        private List<ErrorMsg> errors;//添加对主窗体的引用

        public MsgForm()
        {
            InitializeComponent();
            this.errors = new List<ErrorMsg>();
        }

        public MsgForm(List<ErrorMsg> errors)
        {
            InitializeComponent();
            this.errors = errors;
        }

        private void MsgForm_Load(object sender, EventArgs e)
        {
            string msgs = "";
            msgs = msgs + "\r\n";
            msgs = msgs + "\r\n";
            foreach (ErrorMsg error in this.errors)
            {
                msgs = msgs + error.Msg;
                msgs = msgs + "\r\n";
                msgs = msgs + "\r\n";
            }
            this.errormsg.Text = msgs;
        }
    }
}
