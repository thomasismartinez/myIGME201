using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    static internal class Program
    {
        public static void Main(string[] args)
        {
            // create an object of a class that inherits IPassengerCarrier
            Compact myCompact = new Compact();

            // create an object of a class that does not inherit IPassengerCarrier
            FreightTrain myFreightTrain = new FreightTrain();

            // call AddPassenger with an IPassengerCarrier object
            AddPassenger(myCompact);

            // call AddPassenger with a non-IPassengerCarrier object
            //AddPassenger(myFreightTrain);
            // causes a compile-time error because FreightTrain does not implement
            // the IPassengerCarrier interface so it won't pass as a parameter
        }

        public static void AddPassenger(IPassengerCarrier vehicle)
        {
            vehicle.LoadPassenger();
            Console.WriteLine(vehicle.ToString());
        }
    }
}