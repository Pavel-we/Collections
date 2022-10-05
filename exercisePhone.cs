using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        class Node
        {
            public char Value { get; set; }
            public List<Node> listNode { get; set; }
            public Node node { get; set; }
            public int deep { get; set; }

            public Node(char value, int depth, Node parentNode)
            {
                this.Value = value; // this добавил Sonar(плагин)
                listNode = new List<Node>();
                deep = depth;
                node = parentNode;
            }
            public Node FindChildNode(char charNumber)
            {
                foreach (var childNode in listNode)
                {
                    if (childNode.Value == charNumber)
                        return childNode;
                }
                return null;
            }
        }

        class Tree
        {
            private readonly Node root;
            public int count { get; private set; }
            public Tree() => root = new Node('^', 0, null);

            public Node Prefix(string prefixNode)
            {
                var currentNode = root;
                var result = currentNode;

                foreach (var pref in prefixNode)
                {
                    currentNode = currentNode.FindChildNode(pref);

                        if (currentNode == null) break;

                    result = currentNode;
                }
                return result;
            }
            public void Add(string prefix)
            {
                var commonPrefix = Prefix(prefix);
                var current = commonPrefix;

                for (var i = current.deep; i < prefix.Length; i++)
                {
                    var newNode = new Node(prefix[i], current.deep + 1, current);
                    current.listNode.Add(newNode);
                    current = newNode;
                    count++;
                }
                current.listNode.Add(new Node('$', current.deep + 1, current));
            }
        }
        static void Main()
        {
            Tree tree = new Tree();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var number = Console.ReadLine();
                tree.Add(number);
            }

            Console.WriteLine(tree.count);
        }
    }
}
