//http://snipd.net/huffman-coding-in-c

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HuffmanTree {
    class Program {
        static void Main(string[] args) {
            string input = " saieooupasssisrpsur";
            HuffmanTree huffmanTree = new HuffmanTree();

            // Build the Huffman tree
            huffmanTree.Build(input);

            // Encode
            //bool[] ba = {true,true,false,false,false,true,false,false,false,true,false,true,false,false,false,true,false,false,true,false,true,true,true,false,true,true,false,false,false,true,true,true,true,true,true,true,false,false,false,true,true,false,true,false,true,false,true,true,true,true,false,true,true,false,true,false,false,true};
            BitArray encoded = huffmanTree.Encode(input); //new BitArray(ba);

            Console.Write("Encoded: ");
            foreach (bool bit in encoded) {
                Console.Write((bit ? 1 : 0) + "");
            }
            Console.WriteLine();

            // Decode
            string decoded = huffmanTree.Decode(encoded);

            Console.WriteLine("Decoded: " + decoded);

            Console.ReadLine();
        }
    }
}