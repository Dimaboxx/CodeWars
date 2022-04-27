using System;
using System.Collections.Generic;

namespace Sort_binary_tree_by_levels
{
    class Program
    {
        static void Main(string[] args)
        {

          Node testTree =   new Node(
                                    new Node(
                                            null, 
                                            new Node(null, null, 4), 
                                            2), 
                                    new Node(
                                            new Node(null, null, 5),
                                            new Node(null, null, 6),
                                            3),
                                    1);
        
        Console.WriteLine("Hello World!");
        }
    }


    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }


    class Kata
    {
        public static List<int> TreeByLevels(Node node)
        {
            Queue<Node> nodeQueue = new Queue<Node>();
            List<int> result = new List<int>();
            if (node != null) nodeQueue.Enqueue(node);
            while(nodeQueue.Count >0)
            {
                Node currNode = nodeQueue.Dequeue();
                if (currNode.Left != null) nodeQueue.Enqueue(currNode.Left);
                if (currNode.Right != null) nodeQueue.Enqueue(currNode.Right);
                result.Add(currNode.Value);
            }
            //off ya go!
            return result;
        }

       // public static Queue<Node> nodeQueue;

    }
}
