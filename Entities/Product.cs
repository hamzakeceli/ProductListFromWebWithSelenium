using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Product
    {


        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal DiscountedPrice { get; set; }

        public DateTime ListingDate { get; set; }

        public string KeyValue { get; set; }

        public int MallId { get; set; }

        [ForeignKey("MallId")]
        public Mall Mall { get; set; }


    }
}
