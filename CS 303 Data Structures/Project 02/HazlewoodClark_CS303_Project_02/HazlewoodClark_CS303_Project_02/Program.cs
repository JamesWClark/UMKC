//gotta start here:
//http://msdn.microsoft.com/en-us/library/ms379572(v=vs.80).aspx

using System;
using System.IO;

namespace HazlewoodClark_CS303_Project_02 {
    class Program {

        static void Main(string[] args) {

            BinarySearchTree tree = new BinarySearchTree();
            
            using (StreamReader sr = new StreamReader("MorseCode.csv")) {
                while (!sr.EndOfStream) {

                    String[] line = sr.ReadLine().Split(','); //letter, code

                    MorseCode morseCode = new MorseCode(line[0][0], line[1]);

                    BinaryTreeNode node = new BinaryTreeNode(morseCode);

                    tree.Insert(node);

                    Console.WriteLine(morseCode.Letter + morseCode.Code);

                }
            }
        }
    }
}
