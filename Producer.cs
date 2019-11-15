using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Tema2Ex4
{
    public class Producer:IProducer
    {
        public Producer(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}
