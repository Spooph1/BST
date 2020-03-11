using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST___visualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree bst = new Tree();
            int treeSize;
            int i;
            Console.WriteLine("Binary Search Tree");
            Console.WriteLine("This was quite a big task, but with the help of youtube \n" +
                " and a couple of hours of reading, \n" +
                "i think i understand most of it :D");
            Console.WriteLine("You are going to write in the numbers yourself,\n so how many numbers would you like to type in?");
            treeSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You are now going to write {0} numbers, and the first number is going to be the root of the tree", treeSize);
            for (i = 0; i < treeSize; i++)
            {
                Console.Write("#{0} - ", i);
                bst.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Perfect, now to the fun part, there are a couple of diffrent commands in this program and the keywords are:\n " +
                "Add (the value you want to add)\n Find (the value you want to find)\n Hide (the value you want to hide)\n InOrderTraversal\n PreOrderTraversal\n PostOrderTraversal");

            while (true)
            {
                Console.WriteLine("\nPlease enter a command");
                string command = Console.ReadLine();
                string[] commands = command.Split(' ');
                switch (commands[0])
                {
                    case "Add":
                        bst.Add(Convert.ToInt32(commands[1]));
                        break;

                    case "Find":
                        bst.Find(Convert.ToInt32(commands[1]));
                        break;

                    case "Hide":
                        bst.Hide(Convert.ToInt32(commands[1]));
                        break;

                    case "InOrderTraversal":
                        bst.InOrderTraversal();
                        break;

                    case "PreOrderTraversal":
                        bst.PreOrderTraversal();
                        break;

                    case "PostOrderTraversal":
                        bst.PostOrderTraversal();
                        break;

                    default:
                        Console.WriteLine("I didn't understand that");
                        break;
                }
            }
        }
    }
}
