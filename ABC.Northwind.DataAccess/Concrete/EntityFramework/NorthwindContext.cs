using ABC.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-S3J67QL\SQLEXPRESS2014;User Id=rafet;password=123456789;Initial Catalog=NORTHWND;Integrated Security=false");
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
