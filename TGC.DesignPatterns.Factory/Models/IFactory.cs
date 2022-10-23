using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC.DesignPatterns.Factory.Models
{
    interface IFactory
    {
        bool CanBuildType(Type type);
        IEmployee Build(Type type);
    }
}
