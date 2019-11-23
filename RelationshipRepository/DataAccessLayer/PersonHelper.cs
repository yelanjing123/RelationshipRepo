using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class PersonHelper
    {
        //克隆一个新Person对象
        public static Person CloneMember(Person person)
        {
            if (person == null)
            {
                return null;
            }

            var clone = new Person()
            {
                Name = person.Name,
                Gender = person.Gender,
                Brithday = person.Brithday,
                PersonId = person.PersonId,
                PhoneNumber = person.PhoneNumber,
                AcquaintanceDay = person.AcquaintanceDay ,
                Photo = person.Photo
            };
            return clone;

        }

        //使用from对象的属性值更新to对象的相应属性值
        public static void Populate(Person from, Person to)
        {
            if (from != null && to != null)
            {
                to.Name = from.Name;
                to.Gender = from.Gender;
                to.Brithday = from.Brithday;
                to.PersonId = from.PersonId;
                to.PhoneNumber = from.PhoneNumber;
                to.AcquaintanceDay = from.AcquaintanceDay;
                to.Photo = from.Photo;
            }
        }
    }
}
