
using System;
using Xunit;
using Graphs;
using System.Collections.Generic;

namespace Test_Graph_Breadth_First
{

    public class Graph
    {
        Graphs.Graph test_graph = new Graphs.Graph(true, true);

        [Fact]
        public void Test1()
        {
            test_graph.AddNode(12);
            Vertex test_vertex = new Vertex(22);
            test_graph.AddEdge(test_vertex, test_vertex, 1);
            List<Vertex> result = test_graph.BreadthFirst(test_vertex);
            Assert.Equal(22, result[0].edges[0].getEnd().value);
        }

        public void Test2()
        {
            test_graph.AddNode(1);
            test_graph.AddNode(2);
            Vertex vertex1 = new Vertex(1);
            Vertex vertex2 = new Vertex(2);
            test_graph.AddEdge(vertex2 , vertex2 , 10);
            List<Vertex> test_list = test_graph.BreadthFirst(vertex1);
            List<Vertex> expected = new List<Vertex> { vertex1 , vertex2 };
            Assert.Equal(expected, test_list);
        }
    }
}
