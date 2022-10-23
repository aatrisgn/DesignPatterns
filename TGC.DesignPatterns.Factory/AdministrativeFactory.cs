using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.DesignPatterns.Factory.Models;

namespace TGC.DesignPatterns.Factory
{
    internal class AdministrativeFactory : IFactory
    {
        public static IAdministrative CreateAdministrative(Type type, object[] parameters) => (IAdministrative)Activator.CreateInstance(type, parameters);
        public static IAdministrative CreateAdministrative(Type type) => (IAdministrative)Activator.CreateInstance(type);

        public static T CreateAdministrative<T>(object[] parameters) where T : IAdministrative => (T)CreateAdministrative(typeof(T), parameters);
        public static T CreateAdministrative<T>() where T : IAdministrative => (T)CreateAdministrative(typeof(T));

        public IEmployee Build(Type type)
        {
            return CreateAdministrative(type);
        }

        public bool CanBuildType(Type type)
        {
            return typeof(IAdministrative).IsAssignableFrom(type);
        }
    }
}
