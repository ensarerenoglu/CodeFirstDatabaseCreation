using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EF_CodeFirst.ORM.Entity;

namespace EF_CodeFirst.ORM.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=CodeFirstDb;Trusted_Connection=True;";
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
