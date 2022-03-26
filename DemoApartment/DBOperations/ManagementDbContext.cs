#nullable disable
using DemoApartment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoApartment.DBOperations
{
    public class ManagementDbContext : DbContext
    {
        public ManagementDbContext(DbContextOptions<ManagementDbContext> options)
            : base(options)
        {
        }
        
        // ***** Entities ***** //
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Renter> Renters { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Apartment_Bill> Apartments_Bills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // çoka - çok ilişki
            modelBuilder.Entity<Apartment_Bill>().HasKey(x => new { x.ApartmentId, x.BillId });
            modelBuilder.Entity<Apartment_Bill>().HasOne(m => m.Bill).WithMany(am => am.Apartments_Bills).HasForeignKey(m => m.BillId);
            modelBuilder.Entity<Apartment_Bill>().HasOne(m => m.Apartment).WithMany(am => am.Apartments_Bills).HasForeignKey(m => m.ApartmentId);
            modelBuilder.Entity<Apartment_Bill>().Property(p => p.CreateDate).HasDefaultValueSql("GETDATE()");

            base.OnModelCreating(modelBuilder);
        }
    }
}