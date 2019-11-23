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
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(Person person)
        {
            InitializeComponent();
            _person = person;

            // 给标签控件设置数据绑定
            SetBinding();
        }

        //person对象只读
        private Person _person = null;

        private void SetBinding()
        {
            lblName.DataBindings.Add("Text", _person, "Name");
            lblPhoneNumber.DataBindings.Add("Text", _person, "PhoneNumber");
            lblGender.DataBindings.Add("Text", _person, "Gender");
            //txtMemberAddress.DataBindings.Add("Text", _person, "MemberAddress");
            //txtPoints.DataBindings.Add("Text", _person, "Points");
            //txtDiscountAmmount.DataBindings.Add("Text", _person, "DiscountAmmount");
        }

        private void btnEditPersonInfo_Click(object sender, EventArgs e)
        {
            //将想要修改的对象复制至新对象中进行修改，以免用户选择取消而丢失原有对象信息
            var modifyObj = PersonHelper.CloneMember(_person);
            frmAddorEditPersonInfo frm = new frmAddorEditPersonInfo(modifyObj, true);

            //确认修改后，将新对象的值复制到原选中对象中
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PersonHelper.Populate(frm.PersonObj, _person);
                //刷新显示
                lblName.Text = _person.Name;
                lblPhoneNumber.Text = _person.PhoneNumber;
                lblGender.Text = _person.Gender;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                PersonRepository repo = new PersonRepository();
                if (_person != null)
                {
                    repo.Delete(_person.PersonId);
                }
                this.Close();

                //删除之后原绑定控件DataGridView不能更新
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}
