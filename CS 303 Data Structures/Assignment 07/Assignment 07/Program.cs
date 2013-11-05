using System;
using skmDataStructures;

namespace Assignment_07 {
    class Program {
        static void Main(string[] args) {
            HuffmanTree<string> tree = new HuffmanTree<string>();
            BST index = new BST();
            string rhyme = "Jack, be nimble, Jack, be quick, Jack, jump over the candlestick. "
                + "Jack jumped high. Jack jumped low. Jack jumped over and burned his toe.";
            //all the same charactes used in the tokenizer of the index algorithm in lecture 17 - heaps

            string[] split = rhyme.Split(" ,.:-!?/%\'\"".ToCharArray());
            foreach (string s in split) {
                Node node = index.Search(s);
                if (node != null) {
                    //(IndexNode)node.
                }
            }
            //the first thing to do is build a table of words and frequencies
            //should be index of word counts


            //then, construct a huffman tree

            //encode and decode the rhyme
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

