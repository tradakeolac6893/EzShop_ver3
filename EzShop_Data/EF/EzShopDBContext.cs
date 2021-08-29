using EzShop_Data.Configuration;
using EzShop_Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EzShop_Data.EF
{
    public class EzShopDBContext : DbContext
    {
        public EzShopDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new CartConfiguration());

            //modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
           //modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            //modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            /*modelBuilder.ApplyConfiguration(new TransactionConfiguration());
             * modelBuilder.ApplyConfiguration(new SlideConfiguration());

           //modelBuilder.ApplyConfiguration(new AppUserConfiguration());
           //modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
           
           //modelBuilder.ApplyConfiguration(new SlideConfiguration());*/
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //public DbSet<AppConfig> AppConfigs { get; set; }

        public DbSet<Carts> Carts { get; set; }

        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        //public DbSet<Language> Languages { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }

        //public DbSet<Promotion> Promotions { get; set; }

        public DbSet<Transactions> Transactions { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        //public DbSet<Slide> Slides { get; set; }

    }
}
