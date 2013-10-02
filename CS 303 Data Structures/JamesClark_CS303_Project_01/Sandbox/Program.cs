using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a number: ");
            int action;
            int.TryParse(Console.ReadLine(), out action);
            Console.WriteLine("You wrote: {0} ", action);
        }
    }
}
