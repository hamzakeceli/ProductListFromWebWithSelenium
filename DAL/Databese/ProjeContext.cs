using DAL.Mapping;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Databese
{
    public class ProjeContext:DbContext
    {

        public ProjeContext()
            : base("E-Commerce")
        {

        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new MallMapping());
            modelBuilder.Configurations.Add(new ProductMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        public DbSet<Mall> Mall { get; set; }

        public DbSet<Product> Product { get; set; }
    }
}
