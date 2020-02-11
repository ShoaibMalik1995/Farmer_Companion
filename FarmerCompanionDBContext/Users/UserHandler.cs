using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FarmerCompanionDBContext.Users
{
    public class UserHandler
    {
        public void RegisterUser(User user)
        {
            try
            {
                using (FarmerContext dbcontext = new FarmerContext())
                {
                    dbcontext.Users.Add(user);
                    dbcontext.SaveChanges();
                }
            }
            catch (Exception ex) { }
        }

        public User GetUser(string username,string password)
        {   try
            {
                using (FarmerContext dbcontext = new FarmerContext())
                {
                    return (from u in dbcontext.Users
                            where (u.Email == username || u.UserName ==username) && u.Password==password
                            select u).FirstOrDefault();
                }
            }
            catch(Exception ex) { return null; }
        }
    }
}
