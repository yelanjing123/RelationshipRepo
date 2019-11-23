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
    public partial class frmAddorEditPersonInfo : Form
    {
        
        public frmAddorEditPersonInfo(Person person, bool IsModify)
        {
            InitializeComponent();
            _person = person;
            _isModify = IsModify;

            // 给文本框控件设置数据绑定
            SetBinding();

            //通过标识更改窗体名称
            if (!IsModify)
            {
                this.Text = "新增记录";

            }
            else
            {
                this.Text = "修改记录";

            }
        }

        //person对象只读
        private Person _person = null;
        public Person PersonObj
        {
            get { return _person; }
        }

        private bool _isModify = false; //窗体是否被修改      
        private bool CanClose = false;  //是否可以关闭窗体

        // 给文本框控件设置数据绑定
        private void SetBinding()
        {
            txtName.DataBindings.Add("Text", _person, "Name");
            txtPhoneNumber.DataBindings.Add("Text", _person, "PhoneNumber");
            txtGender.DataBindings.Add("Text", _person, "Gender");           
            //txtMemberAddress.DataBindings.Add("Text", _person, "MemberAddress");
            //txtPoints.DataBindings.Add("Text", _person, "Points");
            //txtDiscountAmmount.DataBindings.Add("Text", _person, "DiscountAmmount");
        }
      

        private void btnOK_Click(object sender, EventArgs e)
        {
            //检查所有数据验证，数据全部有效才允许关闭
            if (this.ValidateChildren() == false)
            {
                MessageBox.Show("你输入了无效的数据,请更正……");
                return;
            }
            CanClose = true;

            //保存到数据库中 
            PersonRepository repo = new PersonRepository();

            try
            {
                if (_isModify)
                {
                    repo.Modify(_person);
                }
                else
                {
                    repo.AddNew(_person);
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            CanClose = true;
            Close();
        }

        
    }
}
