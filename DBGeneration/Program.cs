using FarmerCompanionDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (FarmerContext context = new FarmerContext())
                {
                    var result = (from u in context.Users
                                  select u);
                }
            }
            catch (Exception ex) { }
        }
    }
}
