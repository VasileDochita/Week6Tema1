using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Tema2Ex4
{
    public interface IStore
    {
        string Name { get; private set; }

        void AddClient(IPerson person);

        IOrder Order(IPerson person, string carName);

        void CancelOrder(IPerson person, IOrder order);
    }
}
