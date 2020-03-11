using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST___visualStudio
{
    class Tree
    {
        private Node root;
        public Node Root
        {
            get { return root; }
        }
        public void Add(int data)
        {
            if (root != null) //If the root isn't null, then we call the "Add" method on the root node
            {
                root.Add(data);
            }
            else //If the root is null, then there isn't created a tree, and this node will become the root of this tree 
            {
                root = new Node(data);
            }
        }

        public Node Find(int data)
        {
            if (root != null)//If the root isn't null, then we call the "Find" method
            {
                return root.Find(data);
            }
            else//If the root is null, then there isn't a tree and nothing to find
            {
                return null;
            }
        }
        
        public void Hide(int data)
        {
            Node toHide = Find(data); //Find the node
            if (toHide != null) //Set the hide-boolean to true
            {
                toHide.Hide();
            }
        }

        //Three ways of moving through a search tree - this was quite hard for me too understand without having a visual representation, 
        //but https://www.youtube.com/watch?v=pN1RWeX47tg&ab_channel=kc70 is a quite good video to help you understand it
        public void InOrderTraversal() //Goes as far to the left as possible and prints the data, then its parent and print the data, then its right sibling and prints it data...ect.
        {
            if (root != null)
            {
                root.InOrderTraversal();
            }
        }

        public void PreOrderTraversal() //Goes as far to the left as possible, but prints all the data on the way, then goes to the right nodes and prints them too
        {
            if (root != null)
            {
                root.PreOrderTraversal();
            }
        }

        public void PostOrderTraversal()//Prints all the data in numerical order
        {
            if (root != null)
            {
                root.PostOrderTraversal();
            }
        }
       
    }
}
