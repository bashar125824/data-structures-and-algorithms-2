using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Vertex
    {
        public int value { get; set; }
        public List<Edge> edges;

        public Vertex(int value)
        {
            this.value = value;
            this.edges = new List<Edge>();
        }
        public void addEdge(Vertex endVertex, int weight)
        {
            this.edges.Add(new Edge(this, endVertex, weight));
        }
    }
    public class Edge
    {
        private Vertex start;
        private Vertex end;
        private int weight;

        public Edge(Vertex start, Vertex end, int Weight)
        {
            this.start = start;
            this.end = end;
            this.weight = Weight;
        }

        public Vertex getStart()
        {
            return this.start;
        }

        public Vertex getEnd()
        {
            return this.end;
        }

        public int getWeight()
        {
            return this.weight;
        }
        public class Node
        {
            public int Value;

            public Dictionary<int, int> Neighbors;

            public Node(int data)
            {
                this.Value = data;
                this.Neighbors = new Dictionary<int, int>();
            }

            public void AddEdge(int value, int weight)
            {

                this.Neighbors.Add(value, weight);
            }

            public Dictionary<int, int> GetAdjacentVertices()
            {
                return this.Neighbors;
            }
        }
    }
    public class Graph
    {
        private List<Vertex> vertices;
        private bool Weighted;
        private bool Directed;
        public Graph(bool inputIsWeighted, bool inputIsDirected)
        {
            this.vertices = new List<Vertex>();
            this.Weighted = inputIsWeighted;
            this.Directed = inputIsDirected;
        }
        public Vertex AddNode(int val)
        {
            Vertex newvertex = new Vertex(val);
            vertices.Add(newvertex);
            return newvertex;
        }
        public void AddEdge(Vertex vertex1, Vertex vertex2, int weight)
        {
            if (!this.Weighted)
            {
                weight = (int)(int?)null;
            }
            vertex1.addEdge(vertex2, weight);
            if (!this.Directed)
            {
                vertex2.addEdge(vertex1, weight);
            }
        }
        public List<Vertex> GetNodes()
        {
            if (vertices.Count == 0)
            {
                return null;
            }
            else
            {
                return vertices;

            }
        }
        public List<Edge> GetNeighbors(Vertex node)
        {
            return vertices.Find(v => v.value == node.value).edges;
        }
        public int Size()
        {
            return vertices.Count;
        }

    }
}

