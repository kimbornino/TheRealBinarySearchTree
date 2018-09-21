using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealBinarySearchTree
{
    class SearchTree
    {
 
            public Node root;


            public SearchTree()
            {
                Node node = new Node();

            }

            public void Tree()
            {
                root = null;
            }

            public Node ReturnRoot()
            {
                return root;
            }
            public void Insert(int lemons)
            {
                Node newNode = new Node();
                newNode.item = lemons;
                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (lemons < current.item)
                        {
                            current = current.Leftc;
                            if (current == null)
                            {
                                parent.Leftc = newNode;
                                return;
                            }
                        }
                        else
                        {
                            current = current.Rightc;
                            if (current == null)
                            {
                                parent.Rightc = newNode;
                                return;
                            }
                        }
                    }
                }
            }

            //This is where I start searching

            public Node SearchTheTree(int searchTerm)
            {
                return SearchTheTreeHelper(root, searchTerm);
            }

            private Node SearchTheTreeHelper(Node currentNode, int searchTerm)
            {
                if (currentNode == null)
                {
                    return null;
                }
                if (currentNode.item == searchTerm)
                    return currentNode;
                if (searchTerm > currentNode.item)
                {
                    return SearchTheTreeHelper(currentNode.Rightc, searchTerm);
                }
                else
                {
                    return SearchTheTreeHelper(currentNode.Leftc, searchTerm);
                }
            }
        }
}
