using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLINQ.Entities
{
    public class CustomerOrders
    {

        public string CustomerId { get; set; }

        public string CompanyName { get; set; }

        public string CustomerRegion { get; set; }

        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public CustomerOrders() {   
        }

 

    }
}
