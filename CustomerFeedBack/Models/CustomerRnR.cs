namespace CustomerFeedBack.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomerRnR : DbContext
    {
        public CustomerRnR()
            : base("name=CustomerRnR")
        {
        }

        public virtual DbSet<CustomerReview> CustomerReviews { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerReview>()
                .Property(e => e.Rating)
                .HasPrecision(10, 2);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CustomerReviews)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
