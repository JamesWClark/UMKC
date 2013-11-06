using System;
using System.Collections.Generic;
using System.IO;
using skmDataStructures.BinaryTree;

public class HuffmanTree<T> : BinaryTree {
    public virtual Dictionary<string, int> codes { get; set; }

    public virtual string Encode(string text) {
        string bytes = "";

        foreach (string s in text.Split(" ,.:-!?/%\'\"".ToCharArray()) {
            bytes += codes[s].ToString();
        }

        return bytes;
    }
}