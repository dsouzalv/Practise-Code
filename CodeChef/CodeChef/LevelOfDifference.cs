using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef
{
    class LevelOfDifference
    {
        /*------------------------
         Problem: http://www.codechef.com/problems/TASTR
         -------------------------*/

        public static void LevelOfDifferenceProblem()
        {
            string str1 = string.Empty;
            string str2 = string.Empty;
            do
            {
                str1 = Console.ReadLine().Trim();
            } while (!(str1.Length > 0));
            do
            {
                str2 = Console.ReadLine().Trim();
            } while (!(str2.Length > 0));

            List<string> arg1 = CreateCombination(str1);
            List<string> arg2 = CreateCombination(str2);
            List<string> difference = (arg1.Union(arg2)).Except(arg1.Intersect(arg2)).ToList();

            Console.WriteLine(difference.Count());
            Console.Read();
        }

        private static List<string> CreateCombination(string n)
        {
            List<string> combi = new List<string>();
           
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i; j < n.Length; j++)
                {
                    AddCombination(n.Substring(i, j - i + 1), combi);
                }
            }

            return combi;
        }

        private static void AddCombination(string subStr, List<string> combi)
        {
            if (!combi.Contains(subStr))
            { combi.Add(subStr); }
        }
    }
}
