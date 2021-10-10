using CampProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CampProject.DataAccessLayer.Concrete
{
    public class CampContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("server=DESKTOP-STGF1UC;database=CampProject;integrated security=true")
                .UseLazyLoadingProxies(true)
                ;
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
