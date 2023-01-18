using CoreDemo.Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.Project.DataAccess.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=DESKTOP-E6SPDSH\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;");
            optionsBuilder.UseSqlServer("server=ISU-NB-00015;database=CoreBlogDb;integrated security=true;");
            //optionsBuilder.UseSqlServer("server=ISU-NB-00015\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.WriterSender)
                .HasForeignKey(z => z.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.ReciverUser)
                .WithMany(y => y.WriterReciver)
                .HasForeignKey(z => z.ReciverId)
                .OnDelete(DeleteBehavior.ClientSetNull);

        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Writer> Writer { get; set; }

        public DbSet<Newsletter> Newsletters { get; set; }

        public DbSet<BlogRating> BlogRatings { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Message2> Messages2s { get; set; }
    }
}
