using EjercicioMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.Logic
{
    public class ShippersLogic : BaseLogic
    {
        public List<Shippers> GetList()
        {
            return context.Shippers.ToList();
        }


    }
}
