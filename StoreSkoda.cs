using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Tema2Ex4
{
    class StoreSkoda:IStore
    {
        private List<IOrder> Orders;

        public StoreSkoda(string name)
        {
            this.Name = name;
            Orders = new List<IOrder>();
        }
        public string Name { get; set; }
        public IOrder EnterAndMakeOrder(IPerson person, IVehicle vehicle)
        {
            Console.WriteLine($"{person.Name} entered to {this.Name}");

            Console.WriteLine($"{person.Name} ordered {vehicle.Name}");

            var order = new Order
            {
                Person = person,
                Vehicle = vehicle,
                DeliveryDate = DateTime.Now
            };

            Orders.Add(order);

            return order;
        }
    }
}
