using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef
{
    class MainWindow
    {
        public static void Main(string[] args)
        {
            //ATM.ATMProblem();

            //LevelOfDifference.LevelOfDifferenceProblem();

            //SmallFactorials.SmallFactorialProblem();

            //TupleTest.TestingTuple();

            //Maze.MazeProblem();

            SmartTVKeyPad s = new SmartTVKeyPad();
            s.StartTVKeyPadProblem("adirect");
            Console.Read();
        }
    }
}
