using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace Mysociogram
{
    public partial class frmShowAct : Form
    {
        public frmShowAct()
        {
            InitializeComponent();

            //通过程序集中封装的CRUD操作完成对数据库的更新
            repo = new ActivityRepository();

            ShowActInTree();


        }

        private ActivityRepository repo = null;
        private BindingList<Activity> Acts = null;

        private int ShowActInTree()
        {
            //从数据库中提取数据，放到BindingList<T>集合中
            Acts = repo.GetAllActs();

            

            Activity act1 = repo.ShowActInActivityID(Acts, 1);
            lblActThought.Text = act1.ActThought.ToString();

            treeAct.LabelEdit = true;   //可编辑状态


            return 0;
        }
        
    }
}
