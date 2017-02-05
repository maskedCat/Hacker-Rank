using System;
using System.Collections.Generic;
using System.Linq;

namespace Snakes_and_Ladders_Quickest_Way
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfTestCases = ReadLine()[0];
            for(int i = 0; i< numberOfTestCases; i++)
            {
                Solve();
            }
        }

        static int[] ReadLine()
        {
            return Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        }

        static IEnumerable<int[]> ReadRows(int n)
        {
            for(int i = 0; i< n; i++)
            {
                yield return ReadLine();
            }
        }

        static void Solve()
        {
            var numberOfLadders = ReadLine()[0];
            var ladders = ReadRows(numberOfLadders).ToList();

            var numberOfSnakes = ReadLine()[0];
            var snakes = ReadRows(numberOfSnakes).ToList();

            Console.WriteLine(CalculateLeastRolls(ladders, snakes));
        }


        static int CalculateLeastRolls(IEnumerable<int[]> ladders, IEnumerable<int[]> snakes)
        {
            var specialSquares = new Dictionary<int, int>();

            foreach(var ladder in ladders)
            {
                specialSquares.Add(ladder[0], ladder[1]);
            }

            foreach(var snake in snakes)
            {
                specialSquares.Add(snake[0], snake[1]);
            }

            var startNode = new Node(1);
            var endNode = new Node(100);
            var board = new Board(startNode, endNode, specialSquares);
            var algorithm = new BreathFisrtTraversal();
            var result = algorithm.GetResult(board);

            return result;
        }

       
        class BreathFisrtTraversal
        {
            public int GetResult(Board board)
            {
                var endNode = board.EndNode;
                var startNode = board.StartNode;

                IEnumerable<Node> nodesAtCurrentLevel = new[] { startNode };
                var numberOfRolls = 0;

                while(!nodesAtCurrentLevel.Contains(endNode))
                {
                    numberOfRolls++;

                    nodesAtCurrentLevel = GetNodesAtNextLevel(nodesAtCurrentLevel, board).Distinct().ToArray();
                }

                return numberOfRolls;
            }

            protected IEnumerable<Node> GetNodesAtNextLevel(IEnumerable<Node> nodes, Board board)
            {
                var nodesAtNextLevel = new List<Node>();

                foreach(var node in nodes)
                {
                    nodesAtNextLevel.AddRange(GetChildNodes(node, board));
                }

                return nodesAtNextLevel;
            }

            protected IEnumerable<Node> GetChildNodes(Node node, Board board)
            {
                var endNode = board.EndNode;
                var specialSquares = board.SpecialSquares;

                foreach(var i in Enumerable.Range(1,6))
                {
                    var endSquare = node.Square + i;

                    if (board.SpecialSquares.Keys.Contains(endSquare))
                        endSquare = board.SpecialSquares[endSquare];

                    if (endSquare <= endNode.Square)
                        yield return new Node(endSquare);
                }
            }
        }


        class Board
        {
            public Node StartNode { get; protected set; }
            public Node EndNode { get; protected set; }
            public Dictionary<int, int> SpecialSquares { get; protected set; }

            public Board(Node startNode, Node endNode, Dictionary<int, int> specialSquares)
            {
                SpecialSquares = specialSquares;
                StartNode = startNode;
                EndNode = endNode;
            }
        }

        class Node: IComparable, IComparable<Node>, IEquatable<Node>
        {
            public int Square { get; set; }

            public Node(int square)
            {
                Square = square;
            }

            public int CompareTo(object obj)
            {
                var other = AttemptToCastFromObject(obj);
                return CompareTo(other);
            }

            public int CompareTo(Node other)
            {
                return Square.CompareTo(other.Square);
            }

            public bool Equals(Node other)
            {
                return Square.Equals(other.Square);
            }

            public override bool Equals(object obj)
            {
                var other = AttemptToCastFromObject(obj);
                return this == other;
            }

            public override int GetHashCode()
            {
                return this.Square;
            }

            protected Node AttemptToCastFromObject(Object obj)
            {
                if (obj == null)
                    throw new ArgumentNullException("obj");

                Node node = obj as Node;

                if (node == null)
                    throw new NotSupportedException(string.Format("Cannot compare to object of type {0}", node.GetType()));

                return node;
            }

            public static bool operator < (Node node1, Node node2)
            {
                return node1.Square < node2.Square;
            }

            public static bool operator > (Node node1, Node node2)
            {
                return node1.Square > node2.Square;
            }

            public static bool operator <= (Node node1, Node node2)
            {
                return node1.Square <= node2.Square;
            }

            public static bool operator >= (Node node1, Node node2)
            {
                return node1.Square >= node2.Square;
            }

            public static bool operator == (Node node1, Node node2)
            {
                if(object.ReferenceEquals(node1, null))
                {
                    return false;
                }

                if(object.ReferenceEquals(node2, null))
                {
                    return false;
                }

                return node1.Square == node2.Square;
            }

            public static bool operator != (Node node1, Node node2)
            {
                if (node2 == null)
                    return false;
                return node1.Square != node2.Square;
            }
        }
    }
}
