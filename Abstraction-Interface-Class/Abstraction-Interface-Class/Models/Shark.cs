﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface_Class.Models
{

    internal class Shark : Animal
    {
        public int TeethCount { get; set; }

        public override void Eating()
        {
            Console.WriteLine("Shark eating");
        }
        public override void Sound()
        {
            Console.WriteLine("Shark sound");
        }

    }
}
