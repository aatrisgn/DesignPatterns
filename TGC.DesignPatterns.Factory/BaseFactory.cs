using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.DesignPatterns.Factory.Models;

namespace TGC.DesignPatterns.Factory
{
    public  class BaseFactory
    {
        //Ideally, through DI
        private static List<IFactory> factoryLists = new List<IFactory>() {
            new AdministrativeFactory(),
            new TeacherFactory()
        };

        public static IEmployee Build(Type type)
        {
            var factory = factoryLists.FirstOrDefault(f => f.CanBuildType(type));
            return factory.Build(type);
        }
    }
}
