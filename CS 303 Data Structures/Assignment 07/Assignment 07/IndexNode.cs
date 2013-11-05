using System;
using skmDataStructures;

namespace Assignment_07 {
    class IndexNode : Node {
        public string Word { get; set; }
        public int Count { get; set; }
        public IndexNode() {
            this.Count = 0;
        }
        public IndexNode(string word) {
            this.Word = word;
            this.Count = 1;
        }
    }
}
