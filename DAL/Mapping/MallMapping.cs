using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class MallMapping : EntityTypeConfiguration<Mall>
    {
        public MallMapping()
        {
            ToTable("Malls", "eCommerce");

            Property(i => i.MallUrl).IsRequired();
        }
    }
}
