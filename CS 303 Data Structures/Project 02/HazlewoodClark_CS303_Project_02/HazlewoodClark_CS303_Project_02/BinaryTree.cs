﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BinaryTree {

    public virtual BinaryTreeNode Root {
        get;
        set;
    }
    public BinaryTree() {

    }
    public BinaryTree(BinaryTreeNode root) {

    }
    public BinaryTree(BinaryTreeNode root, BinaryTree leftChild, BinaryTree rightChild) {

    }

    public virtual BinaryTree GetLeftSubtree() {
        return new BinaryTree(this.Root.LeftNode);
    }

    public virtual BinaryTree GetRightSubtree() {
        return new BinaryTree(this.Root.RightNode);
    }

    public virtual void GetData() {
        throw new System.NotImplementedException();
    }

    public override string ToString() {
        throw new System.NotImplementedException();
    }

}

