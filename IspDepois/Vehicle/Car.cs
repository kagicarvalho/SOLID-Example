using IspDepois.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspDepois.Vehicle
{
    class Car : IVehicle
    {
        protected string color;
        protected int year;
        protected double engine;
        protected int seats;
        protected int doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;

            Console.WriteLine($"Adicionando carro ano {year} da cor {color}.");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando o motor");
        }
    }
}
