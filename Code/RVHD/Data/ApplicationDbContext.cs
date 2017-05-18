using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RVHD.Models;

namespace RVHD.Data
{
    public class ApplicationDbContext : IdentityDbContext<Member>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Categories> Category { get; set; }
        public DbSet<CategoryItems> CategoryItems { get; set; }
        public DbSet<CategorySubItems> CategorySubItems { get; set; }
        public DbSet<Ads> Ads { get; set; }
        public DbSet<FavouriteAds> FavouriteAds { get;set;}
        public DbSet<Likes> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CategoryItems>()
           .HasOne(p => p.Categories)
           .WithMany(b => b.ListCategoryItems)
           .HasForeignKey(p => p.Categories_Id)
           .HasConstraintName("ForeignKey_CategoryItems_Categories");

            builder.Entity<CategorySubItems>()
           .HasOne(p => p.CategoryItems)
           .WithMany(b => b.ListCategorySubItems)
           .HasForeignKey(p => p.Cs_Id)
           .HasConstraintName("ForeignKey_CategorySubItems_CategoryItems");

            builder.Entity<Ads>()
          .HasOne(p => p.CategorySubItems)
          .WithMany(b => b.ListAds)
          .HasForeignKey(p => p.CategoriesSubItemId)
          .HasConstraintName("ForeignKey_Ads_CategorySubItems");

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        

    }
}
