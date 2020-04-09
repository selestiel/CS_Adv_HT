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

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>().HasKey(k => k.Admin_ID);
            modelBuilder.Entity<Admins>().HasMany(p => p.Orders);
            modelBuilder.Entity<Admins>().HasMany(p => p.Clients);
            modelBuilder.Entity<Admins>().HasMany(p => p.Products);
            modelBuilder.Entity<Admins>().Map(m => m.ToTable("Admins"));


            modelBuilder.Entity<Clients>().HasKey(k => k.Client_ID);
            modelBuilder.Entity<Clients>().HasMany(p => p.Orders);
            modelBuilder.Entity<Clients>().HasMany(p => p.Products);
            modelBuilder.Entity<Clients>().Map(m => m.ToTable("Clients"));

            modelBuilder.Entity<Login>().HasKey(k => k.Login_ID);
            modelBuilder.Entity<Login>().Map(m => m.ToTable("Logins"));

            modelBuilder.Entity<Orders>().HasKey(k => k.Order_ID);
            modelBuilder.Entity<Orders>().HasMany(p => p.Products);
            modelBuilder.Entity<Orders>().Map(m => m.ToTable("Orders"));

            modelBuilder.Entity<Products>().HasKey(k => k.Product_ID);
            modelBuilder.Entity<Products>().HasMany(p => p.Orders);
            modelBuilder.Entity<Products>().HasMany(p => p.Clients);
            modelBuilder.Entity<Products>().HasMany(p => p.Admins);
            modelBuilder.Entity<Products>().Map(m => m.ToTable("Products"));
        }
    }
}
