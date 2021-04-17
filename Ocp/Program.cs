using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle typeVehicle = TypeVehicle.MOTORCYCLE;
            if (typeVehicle == TypeVehicle.CAR)
            {
                Vehicle vehicle = new Vehicle("Azul", 2021, 2.0, 5,4);
                vehicle.Car();
            }
            else
            {

                Vehicle vehicle = new Vehicle("Branco", 2020, 250, 1, 0);
                vehicle.Motorcycle();
            }
            Console.ReadLine();
        }
    }
}
