using System;
using System.Collections.Generic;
using System.Text;

namespace BFSAndDFS
{
    public class Graph
    {
        Dictionary<int, HashSet<int>> Vertices { get; set; }
        public Graph()
        {
            Vertices = new Dictionary<int, HashSet<int>>();
        }

        public void AddVertex(int newVertex)
        {
            Vertices.Add(newVertex, new HashSet<int>());
        }

        public void AddEdge(int startKey, int endKey)
        {
            var startVertex = Vertices.ContainsKey(startKey) ? Vertices[startKey] : null;
            var endVertex = Vertices.ContainsKey(endKey) ? Vertices[endKey] : null;

            if (startVertex == null)
                throw new ArgumentException("start vertex does not exist.");

            if (endVertex == null)
            {
                AddVertex(endKey);
                endVertex = Vertices[endKey];
            }

            startVertex.Add(endKey);
            endVertex.Add(startKey);

        }

        public void RemoveVertex(int vertexKey)
        {
            var vertex = Vertices.ContainsKey(vertexKey) ? Vertices[vertexKey] : null;

            if (vertex == null)
                throw new ArgumentException("There is no vertex to remove.");

            //first remove the edge / adjacency entries
            var adjacentCount = vertex.Count;
            var list = new List<int>();
            foreach (var item in vertex)
            {
                list.Add(item);
            }
            for (var i = 0; i < adjacentCount; i++)
            {
                var neighbourVertexKey = list[i];
                RemoveEdge(vertexKey, neighbourVertexKey);
            }

            //Lastly remove the vertex / adj. list
            Vertices.Remove(vertexKey);
        }

        public void RemoveEdge(int startKey, int endKey)
        {
            var startVertex = Vertices.ContainsKey(startKey) ? Vertices[startKey] : null;
            var endVertex = Vertices.ContainsKey(endKey) ? Vertices[endKey] : null;


            if (startVertex == null || endVertex == null)
                throw new ArgumentException("start or end vertex does not exist.");

            startVertex.Remove(endKey);
            endVertex.Remove(startKey);

        }


        public void PrintGraph()
        {
            foreach (var v in Vertices)
            {
                Console.Write(v.Key + "-->");
                foreach (var ve in v.Value)
                {
                    Console.Write(ve + "  ");
                }
                Console.Write("\n");
            }
        }

        public void BFSWalkWithStartNode(int vertex)
        {
            //Initialize Hashset to mart item as visited.
            var visited = new HashSet<int>();
            //Initialize Queue to 
            var queue = new Queue<int>();

            //mark start item as visited
            visited.Add(vertex);
            queue.Enqueue(vertex);

            Console.WriteLine("Visited: " + vertex);


            //loop until queue is empty
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                //If Vertices conatins vertex item
                if (Vertices.ContainsKey(current))
                {
                    //loop all neighbors
                    var neList = Vertices[current];
                    foreach (var ne in neList)
                    {
                        //If not visited add to visited item and insert item into the queue
                        if (!visited.Contains(ne))
                        {
                            Console.WriteLine("Visited: " + ne);

                            visited.Add(ne);
                            queue.Enqueue(ne);
                        }
                    }
                }

            }

        }

        internal void BFSFindNodeWithStartNode(int vertex, int nodeToFind)
        {
            if (vertex == nodeToFind)
            {
                Console.WriteLine("Found Node;) " + nodeToFind);
                Console.WriteLine("Steps took to found: 0");
            }

            HashSet<int> visited = new HashSet<int>();
            visited.Add(vertex);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(vertex);

            var steps = 0;

            while (queue.Count > 0)
            {
                steps++;
                var current = queue.Dequeue();
                if (Vertices.ContainsKey(current))
                {
                    var neList = Vertices[current];
                    foreach (var ne in neList)
                    {
                        if (ne == nodeToFind)
                        {
                            Console.WriteLine("Found Node;) " + nodeToFind);
                            Console.WriteLine("Steps took to found: " + steps);
                            return;
                        }
                        if (!visited.Contains(ne))
                        {
                            visited.Add(ne);
                            queue.Enqueue(ne);
                        }
                        
                    }
                }

            }

            Console.WriteLine("Not Found node: " + nodeToFind);

        }

        public void DFSWalkWithStartNode(int vertex)
        {
            //Initialize Hashset to mart item as visited.
            var visited = new HashSet<int>();
            //Initialize Queue to 
            var stack = new Stack<int>();

            //mark start item as visited
            visited.Add(vertex);
            stack.Push(vertex);

            Console.WriteLine("Visited: " + vertex);


            //loop until queue is empty
            while (stack.Count > 0)
            {
                var current = stack.Pop();

                //If Vertices conatins vertex item
                if (Vertices.ContainsKey(current))
                {
                    //loop all neighbors
                    var neList = Vertices[current];
                    foreach (var ne in neList)
                    {
                        //If not visited add to visited item and insert item into the queue
                        if (!visited.Contains(ne))
                        {
                            Console.WriteLine("Visited: " + ne);

                            visited.Add(ne);
                            stack.Push(ne);
                        }
                    }
                }

            }

        }

        public void DFSWithRecursion(int vertex)
        {
            var visited = new HashSet<int>();
            Traverse(vertex, visited);
        }

        private void Traverse(int v, HashSet<int> visited)
        {
            // Mark this node as visited
            visited.Add(v);
            Console.WriteLine(v);
            // Only if the node has a any adj notes
            if (Vertices.ContainsKey(v))
            {
                // Iterate through UNVISITED nodes
                foreach (int neighbour in Vertices[v])
                {
                    if (!visited.Contains(neighbour))
                    {
                        Traverse(neighbour, visited);
                    }
                }
            }
        }


        
    }
}
