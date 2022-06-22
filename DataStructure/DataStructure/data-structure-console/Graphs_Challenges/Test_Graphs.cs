using System;
using Xunit;
using Graphs;
using System.Collections.Generic;

namespace Test_Graph
{
    public class Graph
    {
        Graphs.Graph graph = new Graphs.Graph(true, true);
     
        [Fact]
        public void Test1_Node_can_be_successfully_added_to_the_graph()
        {
            Vertex node = graph.AddNode(33);
            Assert.Contains(node, graph.GetNodes());

        }
        
        [Fact]
        public void Test2_An_edge_can_be_successfully_added_to_the_graph()
        {
            Vertex vertex1 = graph.AddNode(88);
            Vertex vertex2 = graph.AddNode(4);

            graph.AddEdge(vertex1, vertex2, 10);

            Assert.NotNull(vertex1.edges);
        }
        
        [Fact]
        public void Test3_A_collection_of_all_nodes_can_be_properly_retrieved_from_the_graph()
        {
            Vertex vertex1 = graph.AddNode(32);
            Vertex vertex2 = graph.AddNode(1);
            Vertex vertex3 = graph.AddNode(29);
            List<Vertex> expected = new List<Vertex>() { vertex1 , vertex2 , vertex3 };
            Assert.Equal(expected, graph.GetNodes());
        }
        
        [Fact]
        public void Test4_All_appropriate_neighbors_can_be_retrieved_from_the_graph()
        {
            Vertex vertex1 = graph.AddNode(32);
            Vertex vertex2 = graph.AddNode(1);
            Vertex vertex3 = graph.AddNode(29);
            graph.AddEdge(vertex1, vertex2, 10);
            graph.AddEdge(vertex1, vertex3, 10);
            var result = graph.GetNeighbors(vertex1);
            Assert.Equal(2, result.Count);
        }
        
        [Fact]
        public void Test5_Neighbors_are_returned_with_the_weight_between_nodes_included()
        {
            Vertex vertex1 = graph.AddNode(1);
            Vertex vertex2 = graph.AddNode(2);
            graph.AddEdge(vertex1, vertex2, 98);
            Edge[] result = graph.GetNeighbors(vertex1).ToArray();
            Assert.Equal(98, result[0].getWeight());
        }
        

        [Fact]
        public void Test6_The_proper_size_is_returned_representing_the_number_of_nodes_in_the_graph()
        {
            Vertex vertex1 = graph.AddNode(21);
            Vertex vertex2 = graph.AddNode(20);
            Vertex vertex3 = graph.AddNode(43);
            graph.AddEdge(vertex1, vertex2, 33);
            graph.AddEdge(vertex1, vertex3, 33);
            var result = graph.Size();
            Assert.Equal(3, result);
        }
        

        [Fact]
        public void Test7_A_graph_with_only_one_node_and_edge_can_be_properly_returned()
        {
            Vertex vertex = graph.AddNode(10);
            graph.AddEdge(vertex, vertex, 5);
            List<Vertex> result = graph.GetNodes();
            Assert.Equal(vertex, result.ToArray()[0]);
        }
        
        [Fact]
        public void Test8_An_empty_graph_properly_returns_null()
        {
            List<Vertex> result = graph.GetNodes();
            Assert.Null(result);
        }
        
    }
}
