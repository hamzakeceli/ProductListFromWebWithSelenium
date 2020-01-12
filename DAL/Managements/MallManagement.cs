using DAL.Databese;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Managements
{
    public class MallManagement
    {

        private ProjeContext database;

        public MallManagement()
        {
            database = new ProjeContext();
        }


        public List<Mall> GetMalls() => database.Mall.ToList();

        public Mall GetMalls(string mallName)
        {
            var mall=database.Mall.
                                   Where(i => i.MallName==mallName).
                                   FirstOrDefault();

            return mall;                                                  
                                                           
            
        }
    }
}
