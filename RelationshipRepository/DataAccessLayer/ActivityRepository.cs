using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class ActivityRepository
    {
        private RelationshipDBContext context = null;

        public ActivityRepository()
        {
            context = new RelationshipDBContext();
        }

        //获取所有人员信息
        public BindingList<Activity> GetAllActivities()
        {
            return new BindingList<Activity>(context.Activities.ToList());
        }

        //添加人员
        public int AddNew(Activity act)
        {
            if (act != null)
            {
                context.Activities.Add(act);
            }
            return context.SaveChanges();
        }

        //修改人员信息
        public int Modify(Activity act)
        {
            if (act != null)
            {
                context.Activities.Attach(act);
                context.Entry(act).State = EntityState.Modified;
            }
            return context.SaveChanges();
        }

        //按照PersonId,删除人员记录
        public int Delete(int ActivityId)
        {
            var act = context.Activities.Find(ActivityId);
            if (act != null)
            {
                context.Activities.Remove(act);
            }
            return context.SaveChanges();
        }
    }
}
