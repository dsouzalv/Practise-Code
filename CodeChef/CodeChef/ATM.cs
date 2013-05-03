using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CodeChef
{
    class ATM
    {

        
        public static void ATMProblem()
        {
            var arg = Console.ReadLine().Split(' ');
            //args = new string[2] { "30", "120.00" }; //89.50

            //args = new string[2] { "42","120.00"}; //120.00

            //args = new string[2] {"300","120.00"}; //120.00
            if (arg.Count() > 1)
            {
                int i;
                float b;
                int.TryParse(arg[0], out i);
                float.TryParse(arg[1], out b);
                if ((i + 0.5 >= b) || (i % 5 != 0))
                    Console.Write("{0:0.00}", b);
                else
                    Console.Write("{0:0.00}", b - (i + 0.5));

            }
            Console.Read();
        }

       
    }
}
