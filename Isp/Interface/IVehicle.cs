﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Interface
{
    interface IVehicle
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
        void ConfigureMotorcycle(string color, int year, double engine);
        void StartVehicle();
    }
}
