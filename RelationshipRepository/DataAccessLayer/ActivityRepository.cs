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

        //获取所有活动信息
        public BindingList<Activity> GetAllActs()
        {
            return new BindingList<Activity>(context.Activities.ToList());
        }

        //添加活动
        public int AddNew(Activity act)
        {
            if (act != null)
            {
                context.Activities.Add(act);
            }
            return context.SaveChanges();
        }

        //修改活动信息
        public int Modify(Activity act)
        {
            if (act != null)
            {
                context.Activities.Attach(act);
                context.Entry(act).State = EntityState.Modified;
            }
            return context.SaveChanges();
        }

        //按照AcitvityId,删除活动记录
        public int Delete(int ActivityId)
        {
            var act = context.Activities.Find(ActivityId);
            if (act != null)
            {
                context.Activities.Remove(act);
            }
            return context.SaveChanges();
        }

        

        //给活动添加任务
        //在选择人物时先将现有信息创建一个Act
        public int AddPersonToAct(Activity act,Person person)
        {
            if(person != null)
            {
                act.People.Add(person);
            }
            return context.SaveChanges();
        }

        //根据ID查询出Act
        public Activity ShowActInActivityID(BindingList<Activity> acts,int actId)
        {
            var query = from admin in context.Activities
                            where admin.ActivityId.CompareTo(actId) == 0 
                            select admin;

            Activity act1 = null;

            foreach (var act in query)
            {               
                act1 = ActivityHelper.CloneAct(act);
            }

            return act1;
        }   
    }
}
