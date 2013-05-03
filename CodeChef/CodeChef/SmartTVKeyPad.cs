using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef
{
    /*
     You are typing using a smart TV remote to search netflex movie the on screen alphabet grid looks like: KeyPad.txt 

We have buttons up(u), down(d), left(l) and right(r) arrow keys, a select(s) button in the center. Where alphabet in bracket represent the action.
The initials focus is always on letter 'a'. Say we want to search "dog" so the actions will be
"dog" -> r r r s d d l s l l u s
(this can be read as “right right right select down down ….)


     */
        
    public class SmartTVKeyPad
    {
        static string filename = @"C:\Users\ldsouza\documents\visual studio 2010\Projects\ConsoleApplication2\ConsoleApplication2\File\KeyPad.txt";
 
        static string[] keypad;
        public void StartTVKeyPadProblem(string word){
            keypad = Helper.FileReader.ReadFileToStringArray(filename);
            
            var initialPosition = Tuple.Create<int,int>(0, 0);
            var output = new List<Tuple<int, int>>();
            
            foreach (char w in word)
                output.Add(FindPosition(w));

            foreach (var position in output)
            {
                Console.WriteLine(GetTravelPlan(initialPosition, position)+"s");
                initialPosition = position;
            }
        }

        private Tuple<int,int> FindPosition(char w)
        {

            for (int i = 0; i < keypad.Length; i++)
            {
                if (keypad[i].Contains(w))
                    return Tuple.Create(i, keypad[i].IndexOf(w));
            }
            return Tuple.Create(0, 0);
        }

        private string GetTravelPlan(Tuple<int, int> start, Tuple<int, int> end)
        {
            string ret="";
            if ((start.Item1 == end.Item1) && (start.Item2 == end.Item2))
            {
                return ret;
            }

            if ((start.Item1 == end.Item1) && (start.Item2 < end.Item2))
            {
                ret +="r "+ GetTravelPlan(Tuple.Create(start.Item1, (start.Item2 + 1)), end); return ret;
            }
            if ((start.Item1 == end.Item1) && (start.Item2 > end.Item2))
            {
                ret +="l "+ GetTravelPlan(Tuple.Create(start.Item1, (start.Item2 - 1)), end); return ret;
            }
            if ((start.Item2 == end.Item2) && (start.Item1 < end.Item1))
            {
                ret +="d "+ GetTravelPlan(Tuple.Create(start.Item1 + 1, start.Item2), end); return ret;
            }
            if ((start.Item2 == end.Item2) && (start.Item1 > end.Item1))
            {
                ret +="u "+ GetTravelPlan(Tuple.Create(start.Item1 - 1, start.Item2), end); return ret;
            }

            if ((start.Item1 != end.Item1)&& (start.Item2!=end.Item2))
            {
                ret += GetTravelPlan(Tuple.Create(start.Item1, start.Item2), Tuple.Create(start.Item1, end.Item2));
                ret += GetTravelPlan(Tuple.Create(start.Item1, end.Item2), Tuple.Create(end.Item1, end.Item2));
                return ret;
            }
            return ret;
        }
        
    }
}
