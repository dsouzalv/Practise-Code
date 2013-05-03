using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CodeChef
{
    class TupleTest
    {
       
        public static void TestingTuple()
        {
            // Code sample!
            List<Tuple<int, string>> tuple = new List<Tuple<int, string>>();
            var st1 = new Stopwatch();
            var st2 = new Stopwatch();

            st1.Start();
            st2.Start();
            foreach (var item in Enumerable.Range(2, 10))
            {
                tuple.Add(Tuple.Create<int, string>(item, "new" + item));
                Console.WriteLine(item);

            }
            Console.WriteLine("st1:{0} ... st2:{1}", st1.ElapsedMilliseconds, st2.ElapsedMilliseconds);
            st1.Reset();
            //st1.Start();
            st2.Restart();

            foreach (var item in tuple)
            {
                Console.WriteLine(item.Item1 + " -- " + item.Item2);
            }


            foreach (var item in Enumerable.Repeat<List<Tuple<int, string>>>(tuple, 4))
            {
                foreach (var i in item)
                {
                    Console.WriteLine("****" + i.Item1 + " ***** " + i.Item2);

                }

                Console.WriteLine("Set Done");
            }
            Console.WriteLine("st1:{0} ... st2:{1}", st1.ElapsedMilliseconds, st2.ElapsedMilliseconds);
            //foreach (var item in Enumerable.Repeat<int>(2, 4))
            //{
            //    Console.WriteLine(item);
            //}
            Console.Read();
        }
    }
}
