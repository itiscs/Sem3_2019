using System;
using System.Collections.Generic;
using System.Text;

namespace Equation
{
    public class Equation
    {
        protected int countSol;
        
        public virtual void Solve()
        {
            Console.WriteLine("Решаем уравнение...");
        }
        public virtual void PrintSolution()
        {
            Console.WriteLine("Ответ уравнения...");
        }

        public static Equation CreateEquation(params int[] coefs)
        {
            var len = coefs.Length;
            if (len == 1)
                return new Equation0(coefs[0]);
            if (len == 2)
                return new Equation1(coefs[0], coefs[1]);
            if (len == 3)
                return new Equation2(coefs[0],coefs[1],coefs[2]);
            throw new ArgumentOutOfRangeException();
        }



        public override string ToString()
        {
            return "Уравнение не определено";
        }
    }
    public class Equation0:Equation
    {
        protected double c;
        public Equation0(double c)
        {
            this.c = c;
        }

        public override void Solve()
        {
            if (c != 0)
                countSol = 0;
            else
                countSol = int.MaxValue;
        }
        public override void PrintSolution()
        {
            if(countSol==0)
                Console.WriteLine("Решений нет");
            else if(countSol==int.MaxValue)
                Console.WriteLine("Решение -  вся числовая ось");
        }
        public override string ToString()
        {
            return $"{c}=0";
        }
    }
    public class Equation1 : Equation0
    {
        protected double b;
        protected double x1;

        public Equation1(double b, double c):base(c)
        {
            this.b = b;
        }

        public override void Solve()
        {
            countSol = 1;
            x1 = -c / b;
        }
        public override void PrintSolution()
        {
            Console.WriteLine($"Решение: x1={x1}");
        }
        public override string ToString()
        {
            return $"{b} x + {c}=0";
        }
    }
    public class Equation2 : Equation1
    {
        protected double a;
        protected double x2;

        public Equation2(double a, double b, double c) : base(b,c)
        {
            this.a = a;
        }

        public override void Solve()
        {
            var d = b * b - (4 * a * c);
            if (d < 0)
                countSol = 0;
            else
            {
                countSol = 2;
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
        }
        public override void PrintSolution()
        {
            if (countSol == 0)
                Console.WriteLine("Нет решения в действ.числах");
            else
                Console.WriteLine($"Решение: x1={x1}  x2={x2}");
        }
        public override string ToString()
        {
            return $"{a}x^2 + {b} x + {c}=0";
        }
    }



}
