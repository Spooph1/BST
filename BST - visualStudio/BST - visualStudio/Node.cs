using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST___visualStudio
{
    class Node
    {
        private int data;
        public int Data
        {
            get { return data; }
        }

        private Node right;
        public Node Right //Right node/child
        {
            get { return right; }
            set { right = value; }
        }
        private Node left;
        public Node Left //Left node/child
        {
            get { return left; }
            set { left = value; }
        }

        private bool isHidden; //To make a complete delete-function is very complicateded, so i made a "soft"-delete/hide
        public bool IsHiddden
        {
            get { return isHidden; }
        }

        public Node(int value) //Contructor for the node
        {
            data = value;
        }

        public void Add(int value)//Keeps calling "Add" until it finds the correct spot
        {
            if(value>= data)//If the value is greater or equal than the data then add to the right
            {
                if (right == null)//If there aren't a right, then create one
                {
                    right = new Node(value);
                }
                else//If there are a right node, then call "Add" on that node
                {
                    right.Add(value);
                }
            }
            else //If the value is less than  the data then add to the left
            {
                if (left == null)//If there aren't a left, then create one
                {
                    left = new Node(value);
                }
                else //If there are a left node, then call "Add" on that node
                {
                    left.Add(value);
                }
            }
        }

        public void Hide() //Method to hide/soft-delete
        {
            isHidden = true;
        }

        public Node Find(int value)
        {
            Node currentNode = this;

            while (currentNode != null) //This loops through all the children of the node
            {
                if(value==currentNode.data && isHidden == false) //If the currentNode is equal to the value passed in, then return it
                {
                    Console.WriteLine(currentNode.data + " is in the tree");
                    return currentNode;
                }
                else if(value > currentNode.data)//If the value is greater than the currentNode, check the right child
                {
                    currentNode = currentNode.right;
                }
                else //If the value is less than the currentNode, check the left child
                {
                    currentNode = currentNode.left;
                }
            }
            Console.WriteLine("The node was not found in the tree");
            return null; //The node was not found in the tree
        }

        //Below are three ways of looping throug a binary search tree, wuhuu more code...
        public void InOrderTraversal()//Prints the left branch, then the root and last the right branch
        {
            if (left != null)
            {
                left.InOrderTraversal();
            }
            if (isHidden == false) //Checks if the node is hidden
            {
                Console.Write(data + " ");
            }

            if (right != null)
            {
                right.InOrderTraversal();
            }
        }

        public void PreOrderTraversal()//prints the root, then all the nodes in the left branch and last the right branch
        {
            if (isHidden == false) //Checks if the node is hidden
            {
                Console.Write(data + " ");
            }
            if (left != null)
            {
                left.PreOrderTraversal();
            }
            if (right != null)
            {
                right.PreOrderTraversal();
            }
        }
        public void PostOrderTraversal() //Starts with the left branch, then the right and last the root
        {
            if (left != null)
            {
                left.PostOrderTraversal();
            }
            if (right != null)
            {
                right.PostOrderTraversal();
            }
            if (isHidden == false) //Checks if the node is hidden
            {
                Console.Write(data + " ");
            }
        }


    }
}
