using OcpDepois.Enums;
using OcpDepois.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpDepois
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = TypeVehicle.MOTORCYCLE;

            if(type == TypeVehicle.CAR)
            {
                Car vehicle = new Car("Azul", 2021, 2.0, 5, 4);
            }
            else
            {

                Motorcycle vehicle = new Motorcycle("Branco", 2020, 250);
            }

            Console.ReadLine();
        }
    }
}
