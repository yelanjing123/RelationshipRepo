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
        //private int isDelete = 0;
        //public int IsDelete
        //{
        //    set { IsDelete = value; }
        //}


        /// <summary>
        /// 从数据库中提取所有数据，并且绑定显示于DataGridView中
        /// </summary>
        private void FillDataAndSetBindingSource()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
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

        #region 查找记录
        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        //根据用户输入的文本重新将数据库中数据进行筛选，再绑定到BindingSource
        private void FilterData()
        {
            if (Persons == null)
            {
                return;
            }
            //获取用户输入
            string userinput = txtUserInput.Text.Trim();
            BindingList<Person> result = null;


            //通过LINQ进行查询，并将查询集合赋值给BindingList
            switch (cboFindWhat.SelectedIndex)
            {
                case 0:
                    //按Name过滤数据
                    result = new BindingList<Person>(
                        Persons.Where(person => person.Name.ToString().Contains(userinput)).ToList());

                    break;
                case 1:
                    //按PhoneNumber过滤数据
                    //可能在原数据库中为空检索的话就会出现这种问题

                    //result = new BindingList<Person>(
                    //    Persons.Where(person => person.PhoneNumber.ToString().Contains(userinput)).ToList());

                    break;
                case 2:
                    //按Gender过滤数据
                    result = new BindingList<Person>(
                         Persons.Where(person => person.Gender.ToString().Contains(userinput)).ToList());

                    break;

                //数据库中允许地址为空，查询时出现异常    
                //case 3:
                //    //按MemberAddress过滤数据
                //    result = new BindingList<Member>(
                //        Members.Where(member => member.MemberAddress.Contains(userinput)).ToList());

                //    break;
                default:
                    result = Persons;
                    break;
            }
            bindingSourcePersons.DataSource = result;
        }

        private void cboFindWhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }
        #endregion

        #region 增加记录
        private void btn_Click(object sender, EventArgs e)
        {
            frmAddorEditPersonInfo frm = new frmAddorEditPersonInfo(new Person(), false);

            //窗体成功关闭后，将新增或修改的实体返回到数据库
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bindingSourcePersons.Add(frm.PersonObj);
            };
        }
        #endregion

        #region 查看记录
        private void btnShowPersonInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = bindingSourcePersons.Current as Person;
                if (person != null)
                {
                    //显示分类展示他人信息界面
                    frmShowPersonInfo frmchild = new frmShowPersonInfo(person);
                    //frmchild.Show();

                    //通过是否按下删除档案按钮，判断是否需要删除其档案
                    DialogResult isDelete = frmchild.ShowDialog();
                    if(isDelete == DialogResult.OK)
                    {   
                        //不知道是不是可以通过DataGirdView相应属性或空间实现
                        //测试过 ，只更新Persons值，不重新设置绑定无法刷新显示

                        //为解决DataGridView刷新问题，重新获取Persons值
                        repo = new PersonRepository();
                        //从数据库中提取数据，放到BindingList<T>集合中
                        Persons = repo.GetAllPersons();
                        ////将其关联上BindingSource组件
                        bindingSourcePersons.DataSource = Persons;
                        //设定DataGridView的数据源引用BindingSource
                        dataGridViewPerson.DataSource = bindingSourcePersons;
                    }

                }
              
            }
            catch (Exception ex)
            {

                lblInfo.Text = ex.Message;
            }
            
        }
        #endregion

        
        
        
    }
}
