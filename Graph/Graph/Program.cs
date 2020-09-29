using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var graph = new Graph();
            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);

            Console.WriteLine("\nAfter Adding Vertex 0, 1, 2, 3, 4, 5");

            graph.PrintGraph();

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(3, 5);
            graph.AddEdge(3, 4);
            Console.WriteLine("\nAfter Adding Edges {0, 1}, {0, 2}, (1, 2), (1, 3), (3, 5), (3, 4)");
            graph.PrintGraph();

            graph.RemoveEdge(1, 3);

            Console.WriteLine("\nAfter Removing Edge {1, 3}");
            graph.PrintGraph();

            graph.RemoveVertex(3);
            Console.WriteLine("\nAfter Removing Vertex 3");
            graph.PrintGraph();

        }

    }
}
