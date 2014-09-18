using System.Data.Entity;
using Logic.Controllers;
using Logic.Models;

namespace Logic.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<WorkShopApplication> WorkShopApplications { get; set; }
        public DbSet<WorkShopFirstDayApplication> WorkShopFirstDayApplications { get; set; }
        public DbSet<WorkShopVolunteerApplication> WorkShopVolunteerApplications { get; set; }

        public DataContext()
            : base("umbracoDbDSN")
        {

        }
    }
}
