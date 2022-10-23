using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.DesignPatterns.Factory.Models;

namespace TGC.DesignPatterns.Factory
{
    public class TeacherFactory : IFactory
    {
        public static ITeacher CreateTeacher(Type type, object[] parameters) => (ITeacher)Activator.CreateInstance(type, parameters);
        public static ITeacher CreateTeacher(Type type) => (ITeacher)Activator.CreateInstance(type);

        public static T CreateTeacher<T>(object[] parameters) where T : ITeacher => (T)CreateTeacher(typeof(T), parameters);
        public static T CreateTeacher<T>() where T : ITeacher => (T)CreateTeacher(typeof(T));

        public IEmployee Build(Type type)
        {
            return CreateTeacher(type);
        }

        public bool CanBuildType(Type type)
        {
            return typeof(ITeacher).IsAssignableFrom(type);
        }
    }
}
