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

public class Tree
{
	public virtual object Height
	{
		get;
		set;
	}

	public virtual object Root
	{
		get;
		set;
	}

	public virtual IEnumerable<TreeNode> TreeNode
	{
		get;
		set;
	}

	public virtual bool IsFull()
	{
		throw new System.NotImplementedException();
	}

	public virtual bool IsComplete()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ToArray()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ToList()
	{
		throw new System.NotImplementedException();
	}

}

