﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpDepois.Vehicles
{
    class Motorcycle : Vehicles
    {
        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando uma Moto {color}, {year}, {engine} cilindrada");
            StartVehicle();
        }
    }
}
