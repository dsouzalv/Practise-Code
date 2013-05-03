using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CodeChef
{
    class SmallFactorials
    {
        /*------------------------
        Problem: http://www.codechef.com/problems/FCTRL2
        -------------------------*/

        public static void SmallFactorialProblem()
        {

            var count = Console.ReadLine();
            var no = new List<int>();
            for (int i = 0; i < int.Parse(count); i++)
                no.Add(int.Parse(Console.ReadLine()));
            foreach (var i in no)
                GetFactorialFor(i);
            Console.Read();
        }     
        static void GetFactorialFor(int number)
        {            
            var result = new List<int>{1};
            if(number>0)
            for (int i = number; i>1; i--)
                result = Multiply(result.ToArray(), i);                
            PrintNumber(result.ToArray());
        }

        static List<int> Multiply(int[] number, int multiplier)
        {
            var multipliedNumber = new List<int>();
            int numToAdd = 0;
            int mult = 10;
            int digitmultiplied = 0;
            foreach (int i in number)
            {
                digitmultiplied = (i * multiplier)+numToAdd;
                multipliedNumber.Add(digitmultiplied % mult);
                numToAdd = digitmultiplied / mult;
            }
            while (numToAdd > 0)
            {
                multipliedNumber.Add(numToAdd % mult);
                numToAdd = numToAdd / mult;
            }               
            return multipliedNumber;
        }

        static void PrintNumber(int[] number)
        {
            var st = new StringBuilder();           
            for (int i = number.Length - 1; i >= 0; i--)
                st.Append(number[i]);
            Console.WriteLine(st.ToString());
           
        }
    }
}

