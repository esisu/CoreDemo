using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=DESKTOP-E6SPDSH\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;");
            optionsBuilder.UseSqlServer("server=ISU-NB-00414\\SQLEXPRESS;database=CoreBlogDbAPIDB;integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
