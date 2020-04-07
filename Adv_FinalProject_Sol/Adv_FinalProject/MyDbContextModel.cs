namespace Adv_FinalProject
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDbContextModel : DbContext
    {
        public DbSet<Admins> Adminses { get; set; }
        public DbSet<Clients> Clientses { get; set; }
        public DbSet<LoginPass> LoginPasses { get; set; }
        public DbSet<Orders> Orderses { get; set; }
        public DbSet<Products> Productses { get; set; }

        public MyDbContextModel()
            : base("name=MyDbContextModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginPass>()
                        .HasKey(e => e.Login)
                        .Property(e => e.Password);
        }
    }
}
