using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysociogram
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnShowfrmMain_Click(object sender, EventArgs e)
        {
            string keyword = "123456";

            if (txtKeyword.Text.Equals(keyword))
            {
                //显示主界面
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("密码错误，请重新输入！");
            }
        }
    }
}
