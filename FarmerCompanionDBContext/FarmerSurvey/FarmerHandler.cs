using FarmerCompanionDBContext.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerCompanionDBContext.FarmerSurvey
{
    public class FarmerHandler
    {
        public void SaveSurvey(FarmerSurveys fs)
        {
            try
            {
                using (FarmerContext dbcontext = new FarmerContext())
                {
                    dbcontext.Entry<User>(fs.Users).State = EntityState.Unchanged;
                    dbcontext.FarmerSurvey.Add(fs);
                    dbcontext.SaveChanges();
                }
            }
            catch (Exception e) { }
        }

        public List<FarmerSurveys> GetSurveyListByUser(int UserId)
        {
            try
            {
                using (FarmerContext dbcontext = new FarmerContext())
                {
                    return (from u in dbcontext.FarmerSurvey
                            where u.UserId == UserId
                            select u).ToList();
                }
            }
            catch(Exception e) { return null; }
        }

        public List<FarmerSurveys> GetSurveyListByUserId(int UserId)
        {
            try
            {
                using (FarmerContext dbcontext = new FarmerContext())
                {
                    return (from s in dbcontext.FarmerSurvey
                            where s.UserId == UserId
                            select s).ToList();
                }
            }
            catch(Exception e) { return null; }
        }
    }
}
