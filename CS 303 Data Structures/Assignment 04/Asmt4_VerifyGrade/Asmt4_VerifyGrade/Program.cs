using System;

namespace Asmt4_VerifyGrade {
    class Program {
        static void Main(string[] args) {
            double[] x = { 2, 2, 2, 2, 2, 2, 2, 2, -2, -2, -2, -2, -2, -2, -2, -2 };
            int[] n = { 2, 2, -2, -2, 3, 3, -3, -3, 2, 2, -2, -2, 3, 3, -3, -3 };

            for (int i = 0; i < x.Length; i++) {
                double result = power(x[i], n[i]);
                Console.WriteLine("x: {0}, n: {1}, result: {2} \tactual: {3}", 
                    x[i] < 0 ? x[i].ToString() : " " + x[i].ToString(), 
                    n[i] < 0 ? n[i].ToString() : " " + n[i].ToString(),
                    result < 0 ? result.ToString() : " " + result.ToString(),
                    Math.Pow(x[i], n[i]) < 0 ? Math.Pow(x[i], n[i]).ToString() : " " + Math.Pow(x[i], n[i]).ToString());
            }
        }
        static double power(double x, int n) {
            if (n == 0)
                return 1;
            else if (n > 0)
                return x * power(x, n - 1);
            else
                return 1.0 / power(x, -n);
        }
    }
}
