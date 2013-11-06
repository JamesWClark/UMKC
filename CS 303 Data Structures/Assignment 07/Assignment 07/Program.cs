using System;
using System.Collections.Generic;
using skmDataStructures;

namespace Assignment_07 {
    class Program {
        static void Main(string[] args) {
            HuffmanTree<string> tree = new HuffmanTree<string>();
            BST index = new BST();
            
            //string rhyme = "Jack, be nimble, Jack, be quick, Jack, jump over the candlestick. Jack jumped high. Jack jumped low. Jack jumped over and burned his toe.";
            
            Dictionary<string,long> codes = new Dictionary<string,long>();
            codes.Add("Jack", 0);
            codes.Add("jumped", 10);
            codes.Add("over", 110);
            codes.Add("be", 1110);
            codes.Add("nimble", 11110);
            codes.Add("quick", 111110);
            codes.Add("jumped", 1111110);
            codes.Add("the", 11111110);
            codes.Add("candlestick", 111111110);
            codes.Add("high", 1111111110);
            codes.Add("low", 11111111110);
            codes.Add("and", 111111111110);
            codes.Add("burned", 1111111111110);
            codes.Add("toe", 11111111111110);
            codes.Add("his", 111111111111110);

        }
        static void DoHeap() {
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

