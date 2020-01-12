using DAL.Managements;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductServicesForDb
    {
        private ProductManagementForDb productManagement;
        public ProductServicesForDb()
        {
            productManagement = new ProductManagementForDb();
        }

        public bool IsEmptyNameFilter(string productName)
        {
            if (productName == string.Empty)
                return true;

            return false;
        }


        public List<Product> GetProductsByNameFilter(string productName)
        {


            return productManagement.GetProductsFromDbByNameFilter(productName);
        }
        //public List<Product> GetProducts(string productName) => productManagement.GetProducts(productName);
    }
}
