using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n= Convert.ToInt32(Console.ReadLine());
            NearestNumber nearestNumber = new NearestNumber();
            nearestNumber.CheckNum(n);
            Reflection reflection = new Reflection();
            reflection.Test();
            object expected = new NearestNumber();
            object obj =reflection.CreateObj("Practice_Problem.NearestNumber", "NearestNumber");
            object obj2 = reflection.CreateObjectUsingParameterizedConstructor("Practice_Problem.NearestNumber", "NearestNumber", n);
        }
        
     
        

    }
}

