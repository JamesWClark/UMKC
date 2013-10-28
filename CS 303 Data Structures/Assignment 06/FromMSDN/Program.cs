using System;
using skmDataStructures;

namespace FromMSDN {
    class Program {
        static void Main(string[] args) {

        }
        public void InorderTraversal(Node current) {
            if (current != null) {
                InorderTraversal(current.Left);
                Console.WriteLine(current.Value + "\n");
                InorderTraversal(current.Right);
            }
        }
    }
}
