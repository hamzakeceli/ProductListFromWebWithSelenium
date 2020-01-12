using DAL.Managements;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductServicesForWeb
    {
        ProductManagementForWeb productManagementForWeb = new ProductManagementForWeb();

        public List<Product> GetProdutsFromWeb(Mall mall, string FilterString)
        {

            return productManagementForWeb.GetProdutsFromWeb(mall, FilterString);
        }
    }
}
