using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Tema2Ex4
{
    public class Order:IOrder
    {
        public IPerson Person { get; set; }

        public IVehicle Vehicle { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
