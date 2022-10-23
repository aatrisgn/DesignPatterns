using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC.DesignPatterns.Factory
{
    public class ScienceTeacher : ITeacher
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, my fellow atoms");
        }

        public void Teach()
        {
            Console.WriteLine("I teach science");
        }
    }
}
