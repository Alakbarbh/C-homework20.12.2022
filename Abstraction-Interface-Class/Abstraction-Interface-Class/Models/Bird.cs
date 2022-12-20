using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface_Class.Models
{
    internal abstract class Bird
    {

        internal abstract class Bird : Animal
        {
            public string Type { get; set; }

            public override void Sound()
            {
                Console.WriteLine("Bird sound");
            }




        }
    }
}
