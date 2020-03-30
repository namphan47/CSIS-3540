namespace WatchShopDAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WatchShopEntities : DbContext
    {
        public WatchShopEntities()
            : base("name=Entities")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmpId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Transactions)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.EmpCashierID);

            modelBuilder.Entity<Product>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.ProductTotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TaxAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.OverallTotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CustomerEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Transaction)
                .WillCascadeOnDelete(false);
        }
    }
}
