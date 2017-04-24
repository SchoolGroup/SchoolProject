namespace OstManSysAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OstManSysContext : DbContext
    {
        public OstManSysContext()
            : base("name=OstManSysContext1")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Problem> Problems { get; set; }
        public virtual DbSet<Resident> Residents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartment>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Apartment>()
                .Property(e => e.MonthlyRent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Apartment>()
                .Property(e => e.Condition)
                .IsUnicode(false);

            modelBuilder.Entity<Apartment>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Apartment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Apartment>()
                .HasMany(e => e.Problems)
                .WithRequired(e => e.Apartment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Problem>()
                .Property(e => e.Header)
                .IsUnicode(false);

            modelBuilder.Entity<Problem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Resident)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resident>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Resident)
                .WillCascadeOnDelete(false);
        }
    }
}
