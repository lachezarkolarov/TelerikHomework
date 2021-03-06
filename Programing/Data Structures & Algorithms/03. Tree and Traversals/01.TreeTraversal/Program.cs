﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TreeTraversal
{
    class Program
    {
        static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException("nodes", "The tree has not root.");
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var nodes = new Node<int>[N];

            for (int i = 0; i < N; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i <= N - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
                nodes[childId].Parent = nodes[parentId];

            }

            // 1. Find the root
            var root = FindRoot(nodes);
            Console.WriteLine("The root of the tree is: {0}", root.Value);

            // 2. Find all leafs
            var leafs = FindAllLeafs(nodes);
            Console.Write("Leafs: ");

            foreach (var leaf in leafs)
            {
                Console.Write("{0}, ", leaf.Value);
            }

            Console.WriteLine();

            // 3. Find all middle leafs
            var middleNodes = FindAllMiddleNodes(nodes);
            Console.Write("Middle nodes: ");

            foreach (var node in middleNodes)
            {
                Console.Write("{0}, ", node.Value);
            }

            Console.WriteLine();

            // 4. Find longest path from the root
            var longestPath = FindLongestPath(FindRoot(nodes));
            Console.WriteLine("Longest path from the root is: {0}", longestPath);

            // 5. * all paths in the tree with given sum S of their nodes

            Root = root;
            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    usedNodes.Clear();
                    FindPathWithBiggestSum(node, 0);
                }
            }

            foreach (var item in used)
            {
                Console.Write("{0} ->", item.Value);
            }
            Console.WriteLine();
            Console.WriteLine(maxSum);

        }

        public static int maxSum = 0;
        public static List<Node<int>> usedNodes = new List<Node<int>>();
        public static List<Node<int>> used = new List<Node<int>>();
        public static bool isRoot = false;
        public static Node<int> Root;

        private static void FindPathWithBiggestSum(Node<int> node, int currentSum)
        {
            usedNodes.Add(node);
            currentSum += node.Value;

            if (Root == node)
            {
                isRoot = true;
            }

            if (isRoot)
            {

                for (int i = 0; i < node.Children.Count; i++)
                {
                    if (usedNodes.Contains(node.Children[i]))
                    {
                        continue;
                    }

                    FindPathWithBiggestSum(node.Children[i], currentSum);
                }
            }
            else if (node.Parent != null)
            {
                FindPathWithBiggestSum(node.Parent, currentSum);
            }

            isRoot = false;

            if (currentSum >= maxSum && node.Children.Count == 0)
            {
                used = usedNodes;
                maxSum = currentSum;

            }
        }

        private static void TraverserDFS(Node<int> node, string spaces)
        {
            Console.Write(node.Value + spaces);
            Console.WriteLine();
        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;

            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }

        private static List<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            List<Node<int>> middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }
    }
}