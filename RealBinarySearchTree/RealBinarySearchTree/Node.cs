using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealBinarySearchTree
{
    class Node
    {
        //member variables
        public int item;
        public Node Rightc;
        public Node Leftc;
        public void display()
        {
            Console.WriteLine("[");
            Console.WriteLine(item);
            Console.WriteLine("]");
        }
    }
}
