using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //DB ile classlarımı ilişkilendirdiğim yer.
    public  class NorthwindContext:DbContext
    {
        //veritabanım ne
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //normalde ip adresi yazılır.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        //hangi nesne hangi nesneye karşılık gelecek
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
