using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem
{
    internal class NearestNumber
    {
        List<int> list = new List<int>() { 11,16,25,32,14,20};
        List<int> number = new List<int>();
        public void CheckNum(int n)
        {
            int rem = 0;
            int flag = 0;
            int temp = 0;
            foreach(int i in list)
            {
                if (i % 2 == 0)
                {
                    temp = i;
                    while (temp != 0)
                    {
                        rem = temp % 10;
                        if (rem % 2 != 0)
                        {
                            flag = 1;
                            break;
                        }
                        flag = 0;
                        temp = temp / 10;
                    }
                    if (flag == 0)
                    {
                        number.Add(i);
                    }
                }

            } 
            int nearest = number.OrderBy(x=>Math.Abs(n-x)).First();
            Console.WriteLine("Nearest Number is {0} whose digits are even ", nearest);


        } 
      

        

    }
}
