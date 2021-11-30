namespace EF_CodeFirst.Migrations
{
    using EF_CodeFirst.ORM.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_CodeFirst.ORM.Context.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EF_CodeFirst.ORM.Context.AppDbContext context)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryName="Beverages", CreatedDate=DateTime.Now},
                new Category{CategoryName="Condiment",CreatedDate=DateTime.Now},
                new Category{CategoryName="Diary Products",CreatedDate=DateTime.Now}
            };

            //Any() geriye boolean dönen ve içerisinde bir koşul belirtebileceğiniz bir geliştirilmiş metottur. Aslında herhangi bir değer var mı yok mu sorgusu yapar.
            if (!context.Categories.Any())
            {
                foreach (Category item in categories)
                {
                    context.Categories.Add(item);
                    context.SaveChanges();
                }
            }
            
        }
    }
}
