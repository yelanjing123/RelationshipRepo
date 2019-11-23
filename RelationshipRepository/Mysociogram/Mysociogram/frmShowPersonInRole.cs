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
    public partial class frmShowPersonInRole : Form
    {

        //窗体构造函数
        public frmShowPersonInRole()
        {
            InitializeComponent();

            //通过程序集中封装的CRUD操作完成对数据库的更新
            repo = new PersonRepository();

            //设置不允许表格自动生成数据库对应列，而使用手动添加绑定的中文列名
            dataGridViewPerson.AutoGenerateColumns = false;

            //查找选项默认为姓名
            cboFindWhat.SelectedIndex = 0;

            FillDataAndSetBindingSource();

        }

        private PersonRepository repo = null;
        private BindingList<Person> Persons = null;


        /// <summary>
        /// 从数据库中提取所有数据，并且绑定显示于DataGridView中
        /// </summary>
        private void FillDataAndSetBindingSource()
        {
            //try
            //{
                //响应BindingSource的相关事件，显示在控制台和lblInfo中以便查看触发事件
                bindingSourcePersons.AddingNew += bindingSourcePersons_AddingNew;
                bindingSourcePersons.BindingComplete += bindingSourcePersons_BindingComplete;
                bindingSourcePersons.CurrentChanged += bindingSourcePersons_CurrentChanged;
                bindingSourcePersons.CurrentItemChanged += bindingSourcePersons_CurrentItemChanged;
                bindingSourcePersons.ListChanged += bindingSourcePersons_ListChanged;
                bindingSourcePersons.PositionChanged += bindingSourcePersons_PositionChanged;

                //从数据库中提取数据，放到BindingList<T>集合中
                Persons = repo.GetAllPersons();
                //将其关联上BindingSource组件
                bindingSourcePersons.DataSource = Persons;
                //设定DataGridView的数据源引用BindingSource
                dataGridViewPerson.DataSource = bindingSourcePersons;

                lblInfo.Text = string.Format("装入记录{0}条", Persons.Count);
            //}
            //catch (Exception ex)
            //{
            //    lblInfo.Text = ex.Message;
            //}
        }

        #region 挂接到BindList的事件代码
        private void bindingSourcePersons_CurrentChanged(object sender, EventArgs e)
        {
            Console.WriteLine("\nBindingSource1_CurrentChanged");
        }

        private void bindingSourcePersons_PositionChanged(object sender, EventArgs e)
        {
            Console.WriteLine("\nBindingSource1_PositionChanged");
            lblInfo.Text = string.Format("第{0}条/共{1}条",
               bindingSourcePersons.Position + 1,
               bindingSourcePersons.Count);
        }

        private void bindingSourcePersons_ListChanged(object sender, ListChangedEventArgs e)
        {
            Console.WriteLine("\nBindingSource1_ListChanged,ListChangedType:{0},NewIndex:{1},OldIndex:{2}", e.ListChangedType, e.NewIndex, e.OldIndex);
        }

        private void bindingSourcePersons_CurrentItemChanged(object sender, EventArgs e)
        {
            Console.WriteLine("\nBindingSource1_CurrentItemChanged");
        }

        private void bindingSourcePersons_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            Console.WriteLine("\nBindingSource1_BindingComplete,BindingCompleteState:{0},Cancel:{1},Exception:{2},ErrorText:{3}",
                e.BindingCompleteState, e.Cancel, e.Exception, e.ErrorText);
        }

        private void bindingSourcePersons_AddingNew(object sender, AddingNewEventArgs e)
        {
            Console.WriteLine("\nBindingSource1_AddingNew,{0}", e.NewObject);
        }
        #endregion

        #region 调用bindingSource自身方法实现焦点在记录行间的移动
        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindingSourcePersons.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bindingSourcePersons.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingSourcePersons.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bindingSourcePersons.MoveLast();
        }
        #endregion



        private void btnShowPersonInfo_Click(object sender, EventArgs e)
        {
            //显示分类展示他人信息界面
            frmShowPersonInfo frm = new frmShowPersonInfo();
            frm.Show();
        }

        
    }
}
