using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    public class NorthwindConctext :DbContext
    {
        //Proje hangi veritabanı ile ilişkiliyse onu söylediğimiz yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true") ;
        }
        //Db'deki Customer tablom bendeki Customers'a karşılık geliyor vb. 
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
