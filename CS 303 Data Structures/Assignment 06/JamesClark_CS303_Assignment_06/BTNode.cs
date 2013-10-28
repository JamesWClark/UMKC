using System;

namespace JamesClark_CS303_Assignment_06 {
    class BTNode<T> {
        public T Data;
        public BTNode<T> Left;
        public BTNode<T> Right;

        public BTNode(T data) {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }

        public override string ToString() {
            return this.Data.ToString();
        }
    }
}
