using IspDepois.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspDepois
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Azul", 2021, 4.0, 2, 2);
            Motorcycle motorcycle = new Motorcycle("Branca", 2020, 600);

            Console.ReadLine();
        }
    }
}
