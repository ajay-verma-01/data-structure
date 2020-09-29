using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Node
    { 
        public int Index { get; set; }
        public int Data { get; set; }
    }
    public class Graph
    {
        int NoOfVertices { get; set; }
        Dictionary<int, List<int>> Vertices { get; set; }
        public Graph()
        {
            NoOfVertices = 0;
            Vertices = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int newVertex)
        {
            Vertices.Add(newVertex, new List<int>());
            NoOfVertices++;
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
    }
}
