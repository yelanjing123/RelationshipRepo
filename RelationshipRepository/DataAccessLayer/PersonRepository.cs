using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class PersonRepository
    {
        private RelationshipDBContext context = null;

        public PersonRepository()
        {
            context = new RelationshipDBContext();
        }

        //获取所有人员信息
        public BindingList<Person> GetAllPersons()
        {
            return new BindingList<Person>(context.People.ToList());
        }

        //添加人员
        public int AddNew(Person person)
        {
            if (person != null)
            {
                context.People.Add(person);
            }
            return context.SaveChanges();
        }

        //修改人员信息
        public int Modify(Person person)
        {
            if (person != null)
            {
                context.People.Attach(person);
                context.Entry(person).State = EntityState.Modified;
            }
            return context.SaveChanges();
        }

        //按照PersonId,删除人员记录
        public int Delete(int PersonId)
        {
            var person = context.People.Find(PersonId);
            if (person != null)
            {
                context.People.Remove(person);
            }
            return context.SaveChanges();
        }

        
    }
}
