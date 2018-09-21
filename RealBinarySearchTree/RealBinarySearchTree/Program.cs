using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree theTree = new SearchTree();
            Node testNode = new Node();
            theTree.Insert(20);
            theTree.Insert(25);
            theTree.Insert(45);
            theTree.Insert(15);
            theTree.Insert(67);
            theTree.Insert(43);
            theTree.Insert(80);
            theTree.Insert(33);
            theTree.Insert(67);
            theTree.Insert(99);
            theTree.Insert(91);

            Node found = theTree.SearchTheTree(30);
            if (null == found)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("you found it!");
            }

            Console.ReadLine();
        }
    }
}
