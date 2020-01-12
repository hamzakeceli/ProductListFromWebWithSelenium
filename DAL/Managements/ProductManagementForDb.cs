using DAL.Databese;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Managements
{
    public class ProductManagementForDb
    {
        private ProjeContext database;

        public ProductManagementForDb()
        {
            database = new ProjeContext();
        }


        public List<Product> GetProductsFromDbByNameFilter(String productName)
        {
            var products = database.Product.Include("Mall").
                
                                                           Where(i => i.KeyValue.Contains(productName))
                                                           .OrderByDescending(i=>i.ListingDate)
                                                           .ToList();               

            return products;
        }



    }
}
