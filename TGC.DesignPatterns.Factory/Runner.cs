using TGC.DesignPatterns.Factory.Models;

namespace TGC.DesignPatterns.Factory
{
    public class Runner
    {
        public static void Run()
        {
            //One way without specific implementation
            var mathTeacher = TeacherFactory.CreateTeacher(typeof(MathTeacher));
            var scienceTeacher = TeacherFactory.CreateTeacher(typeof(ScienceTeacher));

            mathTeacher.Teach();
            scienceTeacher.Teach();

            //Other way with generics for specific implementation
            var mathTeacherGeneric = TeacherFactory.CreateTeacher<MathTeacher>();
            var scienceTeacherGeneric = TeacherFactory.CreateTeacher<ScienceTeacher>();

            mathTeacherGeneric.Teach();
            scienceTeacherGeneric.Teach();

            var janitor = BaseFactory.Build(typeof(Janitor));
            var math3 = BaseFactory.Build(typeof(MathTeacher));

            janitor.SayHello();
            ((IAdministrative)janitor).Administrate();

            math3.SayHello();
            ((ITeacher)math3).Teach();

            Console.ReadLine();
        }
    }
}
