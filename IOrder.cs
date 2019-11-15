using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Tema2Ex4
{
    public interface IOrder
    {
        
        string RefferenceNumber { get; set; }

        string StoreName { get; set; }

        IVehicle Vehicle { get; set; }

        DateTime DeliveryDate { get; set; }
        IOrder EnterAndMakeOrder(IPerson person, IVehicle vehicle);
        
        void CancelOrder(IOrder order);
    }

}
