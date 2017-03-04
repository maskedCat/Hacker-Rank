using System;
using System.Collections.Generic;
using System.Linq;


namespace Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for(int i =0; i < t; i++)
            {
                Console.ReadLine();
                var arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

                var nodesAtCurrentLevel = new List<Node>() { new Node(arr) };
                var numberOfCycles = 0;

                while(!nodesAtCurrentLevel.Any(node => node.IsDistributionEqual()))
                {
                    numberOfCycles++;
                    nodesAtCurrentLevel = GetNodesAtNextLevel(nodesAtCurrentLevel).ToList();
                }

                Console.WriteLine(numberOfCycles);
            }
        }

        static IEnumerable<Node> GetNodesAtNextLevel(IEnumerable<Node> nodesAtCurrentLevel)
        {
            foreach(var node in nodesAtCurrentLevel)
            {
                var childrenOfNode = node.GetChildNodes();
                foreach(var childNode in childrenOfNode)
                {
                    yield return childNode;
                }
            }
        }
    }

    class Node
    {
        public int[] DistributionOfCholocate { get; set; }

        public Node(int[] distributionOfChocolate)
        {
            DistributionOfCholocate = distributionOfChocolate;
        }

        public bool IsDistributionEqual()
        {
            var firstElement = DistributionOfCholocate[0];

            return DistributionOfCholocate.All(e => e.Equals(firstElement));
        }

        public IEnumerable<Node> GetChildNodes()
        {
            var childNodes = new List<Node>();

            for(int i =0;i< DistributionOfCholocate.Length; i++)
            {
                var addOne = AddToAllElementsExeceptAt(i, 1, DistributionOfCholocate);
                childNodes.Add(new Node(addOne));

                var addTwo = AddToAllElementsExeceptAt(i, 2, DistributionOfCholocate);
                childNodes.Add(new Node(addTwo));

                var addFive = AddToAllElementsExeceptAt(i, 5, DistributionOfCholocate);
                childNodes.Add(new Node(addFive));
            }

            return childNodes;
        }

        public int[] AddToAllElementsExeceptAt(int index, int increase, int[] arr)
        {
            var result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    result.Add(arr[i]);
                }
                else
                {
                    result.Add(arr[i] + increase);
                }
            }

            return result.ToArray();
        }
    }

}
