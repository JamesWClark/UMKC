using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowersOfHanoi {
    class Program {
        static void Main(string[] args) {
            show_moves(3, 'R', 'M', 'L');
        }

        /** Recursive function for "moving" disks.
        pre: start_peg, dest_peg, temp_peg are different, n >= 1.
        post: displays a list of moves that solve the problem
        of moving n disks from start_peg to dest_peg.
        @param n is the number of disks
        @param start_peg is the starting peg
        @param dest_peg is the destination peg
        @param temp_peg is the temporary peg
        @return A string with all the required disk moves
        */
        static void show_moves(int n, char start_peg, char dest_peg, char temp_peg) {
            if (n == 1) {
                Console.WriteLine("show_moves(" + n + ", " + start_peg + ", " + dest_peg + ", " + temp_peg + ")");
                //Console.WriteLine("Move disk 1 from peg " + start_peg + " to peg " + dest_peg);
            } else {  // Recursive step
                show_moves(n - 1, start_peg, temp_peg, dest_peg);
                Console.WriteLine("show_moves(" + (n - 1) + ", " + start_peg + ", " + temp_peg + ", " + dest_peg + ")");
                //Console.WriteLine("Move disk " + n + " from peg " + start_peg + " to peg " + dest_peg);
                show_moves(n - 1, temp_peg, dest_peg, start_peg);
            }
        }


    }
}
