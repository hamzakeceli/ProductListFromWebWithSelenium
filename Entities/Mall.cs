using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mall
    {
        public Mall()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }

        public string MallName { get; set; }

        public string MallUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}
