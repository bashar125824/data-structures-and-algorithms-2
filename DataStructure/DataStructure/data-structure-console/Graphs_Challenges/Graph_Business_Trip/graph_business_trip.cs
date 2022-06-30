using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Vertex
    {
        public string value { get; set; }
        public List<Edge> edges;

        public Vertex(string value)
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
        public Vertex AddNode(string val)
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

        public List<Vertex> BreadthFirst(Vertex vertex)
        {
            List<Vertex> visitedVertices = new List<Vertex>();
            Queue<Vertex> visitQueue = new Queue<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            visitQueue.Enqueue(vertex);
            visited.Add(vertex);
            if (visitQueue.Count == 0)
            {
                throw new Exception("There is no nodes added !");
            }
            while (visitQueue.Count != 0)
            {
                Vertex front = visitQueue.Dequeue();
                visitedVertices.Add(front);
                foreach (Edge child in ((Vertex)front).edges)
                {
                    Vertex neighbor = child.getEnd();
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        visitQueue.Enqueue(neighbor);
                    }
                }
            }
            return visitedVertices;
        }

        public Vertex GetVertexByValue(string value)
        {
            foreach (Vertex vertex in vertices)

            {
                if (vertex.value == value)
                {
                    return vertex;
                }
            }
            return null;
        }
        public int? BusinessTrip(Graph graph, string[] cities)
        {
            var total = 0;
            for (int i = 0; i < cities.Length - 1; i++)
            {
                Vertex vertex = graph.GetVertexByValue(cities[i]);
                List<Edge> neighbors = graph.GetNeighbors(vertex);
                for (var j = 0; j < neighbors.Count; j++)
                {
                    if (neighbors[j].getStart().value == vertex.value)
                    {
                        total += neighbors[j].getWeight();
                    }
                }
            }
            if (total == 0)
            {
                return null;
            }
            else
            {
                return total;
            }
        }

    }
}

