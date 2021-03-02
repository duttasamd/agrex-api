using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set;}
        public DbSet<ItemType> ItemTypes { get; set; }

        public DbSet<ItemSubType> ItemSubTypes { get; set; }

        public DbSet<ItemCategory> ItemCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Item>()
                .HasOne(p => p.ItemSubType)
                .WithMany(x => x.Items)
                .HasForeignKey(y => y.ItemSubTypeId);

            builder.Entity<ItemSubType>()
                .HasOne(p => p.ItemType)
                .WithMany(x => x.ItemSubTypes)
                .HasForeignKey(y => y.ItemTypeId);

            builder.Entity<ItemType>()
                .HasOne(p => p.ItemCategory)
                .WithMany(x => x.ItemTypes)
                .HasForeignKey(y => y.ItemCategoryId);

            builder.Entity<Item>()
                .HasIndex(x => x.Name).IsUnique();

            builder.Entity<ItemType>()
                .HasIndex(x => x.Name).IsUnique();

            builder.Entity<ItemCategory>()
                .HasIndex(x => x.Name).IsUnique();

            builder.Entity<ItemSubType>()
                .HasIndex(x => x.Name).IsUnique();
        }
    }
}
