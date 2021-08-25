using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Client.Data
{
    public class DataContext // : DbContext
    {
        //public DataContext(DbContextOptions<ECommerceContext> options) : base(options)
        //{

        //}

        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }

        public void Add()
        {
            //_dataContext.Add();
        }

        public bool Exist()
        {
            //_dataContext.Exist();
            return true;
        }

        public void Find()
        {
            //_dataContext.Find();
        }
    }
}
