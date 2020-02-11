using FarmerCompanion.Users;
using FarmerCompanion.FarmerSurvey;
using System.Data.Entity;

namespace FarmerCompanion
{
    public class FarmerContext : DbContext
    {
        public FarmerContext() : base("ConStr")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<User> Users { get; set; }
        public DbSet<FarmerSurveys> FarmerSurvey { get; set; } 
    }
}
