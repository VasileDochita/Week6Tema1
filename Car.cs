using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Tema2Ex4
{
    public class Vehicle:IVehicle
    {
        public IProducer Producer { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
