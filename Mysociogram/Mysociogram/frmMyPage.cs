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
    public partial class frmMyPage : Form
    {
        public frmMyPage()
        {
            InitializeComponent();
        }

        private void btnEditMyInfo_Click(object sender, EventArgs e)
        {
            //显示编辑用户信息界面
            frmEditMyInfo frm = new frmEditMyInfo();
            frm.Show();
        }
    }
}
