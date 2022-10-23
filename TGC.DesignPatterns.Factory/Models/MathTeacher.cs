using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC.DesignPatterns.Factory
{
    public class MathTeacher : ITeacher
    {
        public void SayHello()
        {
            Console.WriteLine("Hello my pythagoreans");
        }

        public void Teach()
        {
            Console.WriteLine("I teach Math");
        }
    }
}
