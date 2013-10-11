/*
 * •Programming 1, Page 411
•Self-check: 1,  4, page 419
•Programming 1, page 426
•Programming 2, page 426
 * */

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace JamesClark_CS303_Assignment_05 {
    class Program {
        static void Main(string[] args) {

            /* PROGRAMMING 1, PAGE 411
             */
            int total = to_number("3ac4asdf123");
            Console.WriteLine(total);
 

            /* PROGRAMMING 2, PAGE 426
            List<int> list = new List<int>();
            list.Add(15);
            list.Add(12);
            list.Add(15);
            list.Add(33);
            int found = linear_search(list, 15, list.Count-1);
            Console.WriteLine(found);
            */

            /* PROGRAMMING 1, PAGE 426
            List<int> list = new List<int>();
            int t = 0;
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(i);
                t += i;
                list.Add(i);
            }
            Console.WriteLine("t in for loop = " + t);

            int total = sum(list);
            Console.WriteLine("sum function = " + total);
             */
 
            /* SELF-CHECK 1, PAGE 426 
            List<string> list = new List<string>();
            string[] names = { "Caryn", "Debbie", "Dustin", "Elliot", "Jacquie", "Jonathan", "Rich" };
            for (int i = 0; i < names.Length; i++) {
                list.Add(names[i]);
            }
            string[] searchFor = { "Rich", "Alice", "Daryn" };
            int[] rich = binary_search(list, searchFor[0]);
            int[] alice = binary_search(list, searchFor[1]);
            int[] daryn = binary_search(list, searchFor[2]);

            Console.WriteLine("rich:  first =  {0}, middle = {1}, last = {2}", rich[0], rich[1], rich[2]);
            Console.WriteLine("alice: first =  {0}, middle = {1}, last = {2}", alice[0], alice[1], alice[2]);
            Console.WriteLine("daryn: first =  {0}, middle = {1}, last = {2}", daryn[0], daryn[1], daryn[2]);
            */

            /* SELF-CHECK 1, PAGE 419
            int[] x = { 2, 2, 2, 2, -2, -2, -2, -2, 3, 3, 3, 3, -3, -3, -3, -3 };
            int[] n = { 2, 2, -2, -2, 3, 3, -3, -3, 2, 2, -2, -2, 3, 3, -3, -3 };

            for (int i = 0; i < x.Length; i++) {
                Console.WriteLine("x = {0}\tn = {1},\tresult = {2}", x[i], n[i], power(x[i], n[i]));
            }
             */

            /* SELF-CHECK 4, PAGE 419
            Stopwatch s = new Stopwatch();
            int n = 47;
            s.Start();
            int f = fibo(1,0,n);
            s.Stop();
            Console.WriteLine("i = {0}, fibonacci = {1}, elapsed = {2}", n, f, s.Elapsed.TotalSeconds);
            s.Reset();
             */
        }

        #region PROGRAMMING 1, PAGE 411
static int to_number(string s) {
    if (s.Length == 0) {
        return 0;
    } else if (char.IsDigit(s[0])) {
        return int.Parse(s[0].ToString()) + to_number(s.Substring(1));
    } else {
        return to_number(s.Substring(1));
    }
}
        #endregion

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
        static int fibo(int fib_current, int fib_previous, int n) {
            if (n == 1)
                return fib_current;
            else
                return fibo(fib_current + fib_previous, fib_current, n - 1);
        }
        static int fibonacci_start(int n) {
            return fibo(1, 0, n);
        }
        #endregion

        #region SELF-CHECK 1, PAGE 426
        /** Recursive binary search function (in binary_search.h).
        @param items The vector being searched
        @param first The subscript of the first element
        @param last The subscript of the last element
        @param target The item being searched for
        @return The subscript of target if found; otherwise -1
        */
        static int[] binary_search(List<string> items, int first, int last, string target) {
            int[] array = new int[3];
            if (first > last) {
                array[0] = -1; array[1] = -1; array[2] = -1;
                return array;     // Base case for unsuccessful search.
            } else {
                int middle = (first + last) / 2;  // Next probe index.
                if (target == items[middle]) {
                    array[0] = first; array[1] = middle; array[2] = last;
                    return array;   // Base case for successful search.
                } else if (target.CompareTo(items[middle]) < 0)
                    return binary_search(items, first, middle - 1, target);
                else
                    return binary_search(items, middle + 1, last, target);
            }
        }
        /** Wrapper for recursive binary search function (in binary_search.h).
        @param items The vector being searched
        @param target The item being searched for
        @return The subscript of target if found; otherwise -1
        */
        static int[] binary_search(List<string> items, string target) {
            return binary_search(items, 0, items.Count - 1, target);
        }
        #endregion

        #region PROGRAMMING 1, PAGE 426

        static int sum (List<int> list) {
            if (list.Count == 0) {
                return 0;
            }
            return list[0] + sum(list.GetRange(1, list.Count-1));
        }
        #endregion

        #region PROGRAMMING 2, PAGE 426
        /** Recursive linear search function (in linear_search.h).
        @param items The vector being searched
        @param target The item being searched for
        @param pos_first The position of the current first element
        @return The subscript of target if found; otherwise -1
        */
        static int linear_search(List<int> items, int target, int pos_last) {
            if (pos_last == items.Count)
                return -1;
            else if (target == items[pos_last])
                return pos_last;
            else
                return linear_search(items, target, pos_last - 1);
        }
        static int linear_search(List<int> items, int target) {
            return linear_search(items, target, 0);
        }
        #endregion
    }
}
