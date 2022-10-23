using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC.DesignPatterns.Factory.Models
{
    public class Inspector : IAdministrative
    {
        public void Administrate()
        {
            Console.WriteLine("I do administrative things.");
        }

        public void SayHello()
        {
            Console.WriteLine("Who haven't done their homework!?");
        }
    }
}
