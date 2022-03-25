using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taksi
            Taxi taxi = new Taxi()

            //pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.Numpassenger = 10;

            //pemanggil method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }

    }
}