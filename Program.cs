using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4. Model in c# the following business model
//Store(IStore)
//Customer(IPerson)
//Order(IOrder)
//Producer(IProducer)
//Car(IVehicle)

//Inside the main method to implement the following behavior: 
//Alex intended to buy a Ford Focus 2015 model.
//He walked to the FordStore in Bucuresti and agreed to buy one for 15000Euro.
//They informed him it will take 4 weeks for delivery.
//He then decided to visit another store SkodaStore and agreed to buy one for 14000Euro and 3 weeks delivery.
//He then canceled his original order from the FordStore.
//After 3 weeks, he received the model.


namespace Week5Tema2Ex4
{
    class Program
    {
        private static void Main(string[] args)
        {
            var store = new StoreFord();

            var client = new Client("Ion");

            store.EnterAndMakeOrder(client);

            var order = store.EnterAndMakeOrder(client, "Focus");

            store.CancelOrder(client, order);

            var store2 = new StoreSkoda();

            var client2 = new Client("Ion");

            store.EnterAndMakeOrder(client2);

            var order = store.EnterAndMakeOrder(client2, "Octavia");
            
        }
    }
}
