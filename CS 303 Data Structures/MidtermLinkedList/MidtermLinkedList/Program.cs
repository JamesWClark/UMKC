using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermLinkedList {
    class Program {

        private static LinkedList<int> set = new LinkedList<int>();

        static void Main(string[] args) {
            for (int i = 1; i < 6; i++) {
                set.AddLast(i);
            }
            Filter(2, set.First);

            for (int i = 0; i < set.Count; i++) {
                Console.Write(set.ElementAt(i) + ", ");
            }
        }
        static void Filter(int key, LinkedListNode<int> node) {
            if (node.Value == key) {
                LinkedListNode<int> next = node.Next;
                set.Remove(next.Previous);
                Filter(key, next);
            } else if (node.Next != null) {
                Filter(key, node.Next);
            }
        }
    }
}
