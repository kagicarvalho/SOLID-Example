﻿using DipBefore.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess payment = new PaymentProcess();

            payment.Pay("ABC123");

            Console.ReadLine();
        }
    }
}
