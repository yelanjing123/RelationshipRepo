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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMyPage_Click(object sender, EventArgs e)
        {
            //显示用户个人界面
            frmMyPage frm = new frmMyPage();
            frm.Show();
        }

        private void btnShowPersonInRole_Click(object sender, EventArgs e)
        {
            //显示分类展示他人信息界面
            frmShowPersonInRole frm = new frmShowPersonInRole();
            frm.Show();
        }

        private void btnfrmAddorEditAct_Click(object sender, EventArgs e)
        {
            frmAddorEditAct frm = new frmAddorEditAct();
            frm.Show();
        }

        private void btnfrmShowAct_Click(object sender, EventArgs e)
        {
            frmShowAct frm = new frmShowAct();
            frm.Show();
        }
    }
}
