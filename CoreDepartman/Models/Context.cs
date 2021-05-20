using Microsoft.EntityFrameworkCore;

namespace CoreDepartman.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=CorePersonel;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
