using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC.DesignPatterns.Factory.Models
{
    public class Janitor : IAdministrative
    {
        public void Administrate()
        {
            Console.WriteLine("I sweep and fix stuff");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello and welcome to my basement");
        }
    }
}
