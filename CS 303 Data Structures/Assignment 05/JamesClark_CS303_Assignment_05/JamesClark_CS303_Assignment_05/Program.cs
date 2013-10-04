/*
 * •Programming 1, Page 411
•Self-check: 1,  4, page 419
•Programming 1, page 426
•Programming 2, page 426
 * */

using System;
using System.Diagnostics;

namespace JamesClark_CS303_Assignment_05 {
    class Program {
        static void Main(string[] args) {
            //SELF-CHECK 1, PAGE 419
            //(-2)^2 = 4
            Console.WriteLine(power(-2, 2));
            //(-2)^3 = -8
            Console.WriteLine(power(-2, 3));
            //(2)^(-2) = 1/(2^2) = 1/4 = .25
            Console.WriteLine(power(2, -2));
            //(2)^(-3) = 1/(2^3) = 1/8 = .125
            Console.WriteLine(power(2, -3));
            //(-2)^(-2) = 1/[(-2)^(2)] = 1/4 = .25
            Console.WriteLine(power(-2, -2));
            //(-2)^(-3) = 1/[(-2)^(3)] = -1/8 = -.125
            Console.WriteLine(power(-2, -3));

            Stopwatch s = new Stopwatch();
            int start = 45;
            int finish = start + 5;
            for (int i = start; i < finish; i++) {
                s.Start();
                int f = fibonacci(i);
                s.Stop();
                Console.WriteLine("i = {0}, fibonacci = {1}, elapsed = {2}", i, f, s.Elapsed.TotalSeconds);
                s.Reset();
            }

        }
        #region SELF-CHECK 1, PAGE 419
        //recursive algorithm for raising x to the power of n, page 414
        static double power(double x, int n) {
            if (n == 0)
                return 1;
            else if (n > 0)
                return x * power(x, n - 1);
            else
                return 1.0 / power(x, -n);
        }
        #endregion

        #region SELF-CHECK 4, PAGE 419
        //Recursive function to calculate Fibonacci numbers
        static int fibonacci(int n) {
            if (n <= 2)
                return 1;
            else
                return fibonacci(n - 1) + fibonacci(n - 2);
        }
        #endregion

    }
}
