using System;
using System.Collections.Generic;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation eq = Equation.CreateEquation(0, 0,0);

            Console.WriteLine(eq);
            eq.Solve();
            eq.PrintSolution();
            

        }
    }
}
