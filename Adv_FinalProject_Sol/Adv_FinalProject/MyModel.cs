namespace Adv_FinalProject
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Admins)
                .Map(m => m.ToTable("ProductsAdmins"));
            modelBuilder.Entity<Admins>()
                .HasMany(e => e.Orders)
                .WithMany(e => e.Admins)
                .Map(m => m.ToTable("OrdersAdmins"));
            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Orders)
                .WithMany(e => e.Clients)
                .Map(m => m.ToTable("OrdersClients"));
            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Clients)
                .Map(m => m.ToTable("ProductsClients"));

            modelBuilder.Entity<Login>()
                .HasKey(e => e.Login_ID)
                .HasKey(e => e.Admins_ID)
                .HasKey(e => e.Clients_ID)
                .Property(e => e.Login_Name);

            modelBuilder.Entity<Password>()
                .HasKey(e => e.Password_ID)
                .HasKey(e => e.Admins_ID)
                .HasKey(e => e.Clients_ID)
                .Property(e => e.Password_Name);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Orders)
                .Map(m => m.ToTable("ProductsOrders"));

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Admins)
                .WithMany(e => e.Orders)
                .Map(m => m.ToTable("ProductsOrders"));

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Clients)
                .WithMany(e => e.Orders)
                .Map(m => m.ToTable("ProductsOrders"));
        }
    }
}
