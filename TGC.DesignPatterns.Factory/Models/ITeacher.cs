using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.DesignPatterns.Factory.Models;

namespace TGC.DesignPatterns.Factory
{
    public interface ITeacher : IEmployee
    {
        void Teach();
    }
}
