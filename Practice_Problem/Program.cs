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
        }
        
     
        

    }
}

