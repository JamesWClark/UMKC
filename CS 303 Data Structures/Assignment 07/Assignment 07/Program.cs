using System;

namespace Assignment_07 {
    class Program {
        static void Main(string[] args) {
            private ArrayList queue = new ArrayList();
            while (!reader.EndOfStream) {
                string data = reader.ReadLine();
                queue.Add(data);
            }
            queue.Sort(new MorsePriorityComparer());
        }
    }
}
