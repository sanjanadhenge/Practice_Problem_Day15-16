using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
        public static string InvokeMethod(string message, string methodName)
        {
            
            try
            {
                Type type = Type.GetType("Mood_Analayzer.MoodAnalyze");
                object moodAnalyze = CreateObjectUsingParameterizedConstructor("Practice_Problem.NearestNumber", "NearestNumber", n);
                MethodInfo methodInfo = type.GetMethod(methodName);
                object mood = methodInfo.Invoke(moodAnalyze, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Method not found");
            }
            return default;
        }
        public  object CreateObjectUsingParameterizedConstructor(string className, string constructorName, int num)
        {
            Type type = typeof(NearestNumber);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new Type[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "HAPPY" });
                    return instance;

                }
                else
                {
                  Console.WriteLine("Constructor Not Found");
                }
            }
            else
            {
                Console.WriteLine("Class Not Found");
            }

            return default;
        }
        public  object CreateObj(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(pattern, constructorName);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type type = executing.GetType(className);
                    return Activator.CreateInstance(type);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Method not found");
                }
            }
            else
            {
                   Console.WriteLine( "Constructor Not Found");
                
            }
            return default;
        }
    }
}
