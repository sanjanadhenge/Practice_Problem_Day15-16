using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem
{
    internal class Reflection
    {
        public  void Test()
        {
            Type type = Type.GetType("Practice_Problem.NearestNumber");
            Console.WriteLine("Full Name : {0}", type.FullName);
            Console.WriteLine("Class Name : {0}", type.Name);
            Console.WriteLine("Methods in NearestNumber class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + ": " + method.Name);
            }
            Console.WriteLine("Properties in NearestNumber class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine("Constructors in NearestNumber class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructors.ToString());
            }
        }
    }
}
