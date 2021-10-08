using eHyperStore.Data.Entities;
using eHyperStore.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHyperStore.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eHyperStore" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eHyperStore" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eHyperStore" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = false },
                new Language() { Id = "en", Name = "English", IsDefault = true });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Giày nam", LanguageId = "vi", SeoAlias = "giay-nam", SeoDescription = "Sản phẩm giày thời trang nam", SeoTitle = "Sản phẩm giày thời trang nam" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shoes", LanguageId = "en", SeoAlias = "men-shoes", SeoDescription = "Men's fashion shoes", SeoTitle = "Men's fashion shoes" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Giày nữ", LanguageId = "vi", SeoAlias = "giay-nu", SeoDescription = "Sản phẩm giày thời trang nữ", SeoTitle = "Sản phẩm giày thời trang nữ" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shoes", LanguageId = "en", SeoAlias = "women-shoes", SeoDescription = "Women's fashion shoes", SeoTitle = "Women's fashion shoes" }
                    );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                });
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Giày thể thao nam Nike",
                    LanguageId = "vi",
                    SeoAlias = "giay-the-thao-nam-nike",
                    SeoDescription = "Giày thể thao nam Nike",
                    SeoTitle = "Giày thể thao nam Nike",
                    Details = "Giày thể thao nam Nike",
                    Description = "Giày thể thao nam Nike"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Nike Men's Sports Shoes",
                    LanguageId = "en",
                    SeoAlias = "nike-men-sport-shoes",
                    SeoDescription = "Nike Men's Sports Shoes",
                    SeoTitle = "Nike Men's Sports Shoes",
                    Details = "Nike Men's Sports Shoes",
                    Description = "Nike Men's Sports Shoes"
                });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
            // any guid
            var roleId = new Guid("09A7BCDF-396C-4E25-B159-3F5D5BEB671B");
            var adminId = new Guid("42F80CCE-24C7-491B-8C70-B1908C66DF23");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "locnhgcs17219@fpt.edu.vn",
                NormalizedEmail = "locnhgcs17219@fpt.edu.vn",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Hieuloc@12345"),
                SecurityStamp = string.Empty,
                FirstName = "Loc",
                LastName = "Nguyen",
                Dob = new DateTime(1999, 11, 17)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}