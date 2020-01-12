using DAL.Managements;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MallServices
    {

        private MallManagement mallManagement;
        public MallServices()
        {
            mallManagement = new MallManagement();
        }




        public List<Mall> GetMalls() => mallManagement.GetMalls();
        public Mall GetMall(string MallName) => mallManagement.GetMalls(MallName);
    }
}
