using System;
using System.IO;

namespace HazlewoodClark_CS303_Project_02 {
    class Program {

        static void Main(string[] args) {

            BinaryTreeNode root = new BinaryTreeNode();
            BinarySearchTree tree = new BinarySearchTree(root);
            
            using (StreamReader sr = new StreamReader("MorseCode.csv")) {
                while (!sr.EndOfStream) {

                    String[] line = sr.ReadLine().Split(','); //letter, code

                    MorseCode morseCode = new MorseCode(line[0][0], line[1]);

                    BinaryTreeNode node = new BinaryTreeNode(morseCode);

                    

                    Console.WriteLine(morseCode.Letter + morseCode.Code);

                }
            }
        }
    }
}
