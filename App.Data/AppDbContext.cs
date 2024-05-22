using App.Data.Entity;
using Microsoft.EntityFrameworkCore;



namespace App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<IPhone> Iphone { get; set; }
        public DbSet<DealerIphone> DealerIphones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<Dealer>().ToTable("Dealer");
            modelBuilder.Entity<IPhone>().ToTable("iPhone");
            modelBuilder.Entity<DealerIphone>().ToTable("Dealer_iPhone");



            modelBuilder.Entity<DealerIphone>()
                .HasKey(di => new
                { di.DealerID, di.IphoneID });

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserID);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.IPhone)
                .WithMany(i => i.Comments)
                .HasForeignKey(c => c.iPhoneID);

            modelBuilder.Entity<DealerIphone>()
                .HasOne(di => di.IPhone)
                .WithMany(d => d.DealerIphones)
                .HasForeignKey(di => di.IphoneID);
        }

    }
}
