using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer
{
    class ActivityHelper
    {
        //克隆一个新Activity对象
        public static Activity CloneAct(Activity act)
        {
            if (act == null)
            {
                return null;
            }

            var clone = new Activity()
            {
                ActivityId = act.ActivityId,
                ActType = act.ActType,
                ActDescription = act.ActDescription,
                ActPlace = act.ActPlace,
                ActThought = act.ActThought,
                ActTime = act.ActTime,
                Image = act.Image,
                People = act.People
            };
            return clone;

        }

        //使用from对象的属性值更新to对象的相应属性值
        public static void Populate(Activity from, Activity to)
        {
            if (from != null && to != null)
            {
                to.ActivityId = from.ActivityId;
                to.ActType = from.ActType;
                to.ActDescription = from.ActDescription;
                to.ActPlace = from.ActPlace;               
                to.ActThought = from.ActThought;
                to.ActTime = from.ActTime;
                to.Image = from.Image;
                to.People = from.People;
            }
        }
    }
}
