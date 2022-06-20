using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
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
        public class Graph
        {
        public  HashSet<Node> vertecies;
        public  bool Directed;

        public Graph(bool directed = false)
        {
            this.Directed = directed;
            this.vertecies = new HashSet<Node>();
        }

        public Node AddNode(int value)
        {
            Node node = new Node(value);
            vertecies.Add(node);
            return node;
        }

        public void AddEdge(int firstValue, int secondValue, int weight)
        {
            
                this.GetNode(firstValue).AddEdge(secondValue, weight);

                if (!this.Directed) 
                {
                    this.GetNode(secondValue).AddEdge(firstValue, weight); 
                }
           
        }

        public HashSet<Node> GetNodes()
        {
            return this.vertecies;
        }

        private Node GetNode(int value)
        {
            return vertecies.Where(x => x.Value == value).Select(x => x).FirstOrDefault(); 
        }

        public Dictionary<int, int> GetNeighbors(int value)
        {
            return this.GetNode(value).GetAdjacentVertices();
        }

        public int Size()
        {
            return this.vertecies.Count;
        }
        }
}
