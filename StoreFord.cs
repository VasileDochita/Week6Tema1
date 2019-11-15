using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Tema2Ex4
{
    public class StoreFord : IStore
    {
        private List<IOrder> Orders;

        public StoreFord(string name)
        {
            this.Name = name;
            Orders = new List<IOrder>();
        }

        public string Name { get; set; }

        public void CancelOrder(Client client, IOrder order)
        {
            Console.WriteLine($"{order.Person.Name} cancelled {order.Vehicle.Name}");

            Orders.Remove(order);
        }

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
