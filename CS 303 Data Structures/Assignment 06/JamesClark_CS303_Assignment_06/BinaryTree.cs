using System;
using System.IO;

namespace JamesClark_CS303_Assignment_06 {
    class BinaryTree<T> {

        #region PROPERTIES
        public BTNode<T> Root;
        #endregion

        #region CONSTRUCTORS
        public BinaryTree() {
            this.Root = null;
        }
        public BinaryTree(BTNode<T> root) {
            this.Root = root;
        }
        public BinaryTree(BTNode<T> data, BinaryTree<T> left, BinaryTree<T> right) {
            this.Root = data;
            this.Root.Left = left.Root;
            this.Root.Right = right.Root;
        }
        #endregion

        #region METHODS
        /*
        public BinaryTree<T> GetLeftSubtree() {

        }
        public BinaryTree<T> GetRightSubtree() {

        }
        public T GetData() {
            return false;
        }
        public bool IsLeaf() {
            return false;
        }
        public bool IsNull() {
            return false;
        }
        public override string ToString() {
            return base.ToString();
        }
        static BinaryTree(StreamReader input) {

        }
        
         * */
        #endregion
    }
}
