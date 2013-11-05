using System;

namespace Assignment_07 {
    class Program {
        static void Main(string[] args) {
            Heap<Person> heap = new Heap<Person>();
            //insert some people with dependents in no particular order
            heap.Insert(new Person(4));
            heap.Insert(new Person(1));
            heap.Insert(new Person(8));
            heap.Insert(new Person(0));
            heap.Insert(new Person(13)); //this will be removed first
            heap.Insert(new Person(2));
            heap.Remove(); //person with 13 dependents is no longer in the heap
            Console.WriteLine(heap.ToString());
        }
    }
}

