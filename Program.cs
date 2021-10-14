using System;

namespace Laba2_2_norma_lvl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A:");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите C:");
            double C = double.Parse(Console.ReadLine());

            if ((Math.Abs(C) - Math.Abs(A)) > (Math.Abs(B) - Math.Abs(A))) Console.WriteLine("B ближе к А");
            else if ((Math.Abs(C) - Math.Abs(A)) > (Math.Abs(B) - Math.Abs(A))) Console.WriteLine("C ближе к А");
            else if (B == C) Console.WriteLine("C и B на одном расстоянии от А");
