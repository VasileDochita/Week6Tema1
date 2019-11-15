using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Tema2Ex4
{
    public interface IVehicle
    {
        IProducer Producer { get; private set; }

        string Name { get; private set; }
        decimal Price { get; set; }
    }
}
