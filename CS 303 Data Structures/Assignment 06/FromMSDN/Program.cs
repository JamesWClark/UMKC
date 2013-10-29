using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using skmDataStructures;

namespace FromMSDN {
    class Program {
        static void Main(string[] args) {
            //create a tree
            //source: http://msdn.microsoft.com/en-us/library/aa289150(v=vs.71).aspx
            BST tree = new BST();
            //split a phrase by space characters
            List<string> words = new List<string>("buy a motorcycle and go fishing".Split(' '));
            words.Remove(String.Empty);
            //phrase is not alphabetized. insert into tree
            foreach (string word in words) {
                tree.Add(word);
            }
            try {
                RecursiveTest(tree, words);
                Console.WriteLine("Test succeeded");
            } catch (Exception) {
                Console.WriteLine("Test failed");
            }
        }
        //recursively remove one random string from words list and tree, then test alphabetic order
        static void RecursiveTest(BST tree, List<string> words) {
            if (words.Count > 0) {
                //test alphabetic order first, throws error if not alphabetized
                TestAlphabeticOrder(tree);
                //remove a random element from the tree and word list
                int random = new Random().Next(0, words.Count);
                string remove = words[random];
                words.RemoveAt(random);
                tree.Delete(remove);
                RecursiveTest(tree, words);
            }
        }
        //compare ascending alpha order for every string, inorder traversal
        static void TestAlphabeticOrder(BST tree) {
            //traverse the tree in order
            List<string> sorted = new List<string>(InorderTraversal(tree.Root).Split('\n'));
            sorted.Remove(String.Empty);
            //test the alphabetic order
            //get the first sting to compare
            string previous = sorted[0];
            //from the second to the end, compare against the previous
            for (int i = 1; i < sorted.Count; i++) {
                //get another string to compare
                string compare = sorted[i];
                //if previous and current are out of order, throw an exception
                if (compare.CompareTo(previous) < 0) {
                    throw new Exception("Failed test");
                }
                //else, keep comparing and move the previous forward by one
                previous = compare;
            }
        }

        /*
        public void InorderTraversal(Node current) {
            if (current != null) {
                InorderTraversal(current.Left);
                Console.WriteLine(current.Value + "\n");
                InorderTraversal(current.Right);
            }
        }
        */


        public static string InorderTraversal(Node current) {
            if (current != null) {
                StringBuilder sb = new StringBuilder();
                sb.Append(InorderTraversal(current.Left));
                sb.Append(current.Value.ToString());
                sb.Append("\n");
                sb.Append(InorderTraversal(current.Right));
                return sb.ToString();
            } else {
                return String.Empty;
            }
        }
    }
}
