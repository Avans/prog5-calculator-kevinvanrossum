﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Success!");
            Console.ReadLine();

            Controller calculator = new Controller();
            calculator.start();
        }
    }
}
