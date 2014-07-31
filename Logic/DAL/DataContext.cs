using System.Data.Entity;
using Logic.Models;

namespace Logic.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<WorkShopApplication> WorkShopApplications { get; set; }

        public DataContext()
            : base("umbracoDbDSN")
        {

        }
    }
}
