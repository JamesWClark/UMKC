//gotta start here:
//http://msdn.microsoft.com/en-us/library/ms379572(v=vs.80).aspx

using System;
using System.IO;

namespace HazlewoodClark_CS303_Project_02 {
    class Program {

        static void Main(string[] args) {

            BinaryTree<MorseCode> tree = BuildMorseTree();
            Console.WriteLine(tree.Root.Right.Right.Left.Value.Letter);
        }
        static BinaryTree<MorseCode> BuildMorseTree() {
            BinaryTree<MorseCode> tree = new BinaryTree<MorseCode>();

            tree.Root = new BinaryTreeNode<MorseCode>(new MorseCode(new char(),String.Empty));
            tree.Root.Left = new BinaryTreeNode<MorseCode>(new MorseCode('e', "*"));
            tree.Root.Right = new BinaryTreeNode<MorseCode>(new MorseCode('t', "–"));

            tree.Root.Left.Left = new BinaryTreeNode<MorseCode>(new MorseCode('i', "**"));
            tree.Root.Left.Right = new BinaryTreeNode<MorseCode>(new MorseCode('a', "*–"));
            tree.Root.Right.Left = new BinaryTreeNode<MorseCode>(new MorseCode('n', "–*"));
            tree.Root.Right.Right = new BinaryTreeNode<MorseCode>(new MorseCode('m', "––"));

            tree.Root.Left.Left.Left = new BinaryTreeNode<MorseCode>(new MorseCode('s', "***"));
            tree.Root.Left.Left.Right = new BinaryTreeNode<MorseCode>(new MorseCode('u', "**–"));
            tree.Root.Left.Right.Left = new BinaryTreeNode<MorseCode>(new MorseCode('r', "*–*"));
            tree.Root.Left.Right.Right = new BinaryTreeNode<MorseCode>(new MorseCode('w', "*––"));
            tree.Root.Right.Left.Left = new BinaryTreeNode<MorseCode>(new MorseCode('d', "–**"));
            tree.Root.Right.Left.Right = new BinaryTreeNode<MorseCode>(new MorseCode('k', "–*–"));
            tree.Root.Right.Right.Left = new BinaryTreeNode<MorseCode>(new MorseCode('g', "––*"));
            tree.Root.Right.Right.Right = new BinaryTreeNode<MorseCode>(new MorseCode('o', "–––"));

            tree.Root.Left.Left.Left.Left = new BinaryTreeNode<MorseCode>(new MorseCode('h', "****"));
            tree.Root.Left.Left.Left.Right = new BinaryTreeNode<MorseCode>(new MorseCode('v', "***–"));
            tree.Root.Left.Left.Right.Left = new BinaryTreeNode<MorseCode>(new MorseCode('f', "**–*"));
            tree.Root.Left.Right.Left.Left = new BinaryTreeNode<MorseCode>(new MorseCode('l', "*–**"));
            tree.Root.Left.Right.Right.Left = new BinaryTreeNode<MorseCode>(new MorseCode('p', "*––*"));
            tree.Root.Left.Right.Right.Right = new BinaryTreeNode<MorseCode>(new MorseCode('j', "*–––"));
            tree.Root.Right.Left.Left.Left = new BinaryTreeNode<MorseCode>(new MorseCode('b', "–***"));
            tree.Root.Right.Left.Left.Right = new BinaryTreeNode<MorseCode>(new MorseCode('x', "–**–"));
            tree.Root.Right.Left.Right.Left = new BinaryTreeNode<MorseCode>(new MorseCode('c', "–*–*"));
            tree.Root.Right.Left.Right.Right = new BinaryTreeNode<MorseCode>(new MorseCode('y', "–*––"));
            tree.Root.Right.Right.Left.Left = new BinaryTreeNode<MorseCode>(new MorseCode('z', "––**"));
            tree.Root.Right.Right.Left.Right = new BinaryTreeNode<MorseCode>(new MorseCode('q', "––*–"));

            return tree;
        }


        /*
        using (StreamReader sr = new StreamReader("MorseCode.csv")) {
            while (!sr.EndOfStream) {

                String[] line = sr.ReadLine().Split(','); //letter, code

                MorseCode morseCode = new MorseCode(line[0][0], line[1]);


                Console.WriteLine(morseCode.Letter + morseCode.Code);

            }
        }
         */ 
    }
}
