using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9H60TTH\\SERCANKURBAN;Database=MvcCoreProjectCampApi150;User Id=WebMobile_302;Password=webmobile.302;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
