/*
Exercise 2 : a,b, c Page 456
Exercise 2, 3 , page 466

Programming 2,3 page 484 on binary search trees
 * 
Due: October 28, 2013 end of the day
Team-based assignment, but you can work individually if you like.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using skmDataStructures;

namespace Assignment_06 {
    class Program {
        static void Main(string[] args) {
            BST b = new BST();
            for (int i = 0; i < 10; i++) {
                b.Add(i);
            }
            
            
        }
    }
}
/*
2. Write a function that returns the tree contents in ascending order (using an
inorder traversal) with newline characters separating the tree elements.
3. Write a main function to test a binary search tree based on Listing 4.3.

 *Programming #3 should be based on listing 4.6 rather than listing 4.3.  You basically want to test your binary search tree in a similar way to how an ordered list was tested in listing 4.6, page 290. 
 *
Koffman, Elliot B. (2011-12-01). Objects, Abstraction, Data Structures and Design: Using C++ (Page 484). Wiley. Kindle Edition. 
*/


/*
Testing a Binary Search Tree
To test a binary search tree, you need to verify that an inorder traversal will display
the tree contents in ascending order after a series of insertions (to build the tree) and
deletions are performed. You can base the main function of your testing code on that
shown in Listing 4.3 (which validates these operations for an Ordered_List). You
need to write a function that returns a vector of strings built from an inorder traversal. These strings should be in alphabetical order (see Programming Exercise 3).

Koffman, Elliot B. (2011-12-01). Objects, Abstraction, Data Structures and Design: Using C++ (Page 479). Wiley. Kindle Edition. 
*/