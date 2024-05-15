using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopZadach
{
    internal class Train
    {
        public string destination;
        public int number;
        public string departureTime;

        public Train(string destination, int number, string departureTime)
        {
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
        }
    }
}
