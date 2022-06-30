using System;
using Xunit;
using Graphs;

namespace Test_Graph_Business_Trip
{
    public class graph_business_trip
    {
        Graph graph = new Graph(true, true);

        [Fact]
        public void Test1()
        {

            var ArendelleVertex = graph.AddNode("Arendelle");
            var MetrovilleVertex = graph.AddNode("Metroville");
            var PandoraVertex = graph.AddNode("Pandora");

            graph.AddEdge(PandoraVertex, ArendelleVertex, 876);
            graph.AddEdge(ArendelleVertex, MetrovilleVertex, 21);

            string[] arr = { "Pandora", "Arendelle", "Metroville" };
            Assert.Equal(897, graph.BusinessTrip(graph, arr));
        }
      
       
        [Fact]
        public void Test2()
        {
            var ArendelleVertex = graph.AddNode("Arendelle");
            var MetrovilleVertex = graph.AddNode("Metroville");
            var PandoraVertex = graph.AddNode("Pandora");

            graph.AddEdge(PandoraVertex, ArendelleVertex, 111);
            graph.AddEdge(ArendelleVertex, MetrovilleVertex, 343);

            string[] arr = { "Pandora", "Arendelle", "Metroville" };
            Assert.NotEqual(999, graph.BusinessTrip(graph, arr));
        }
        [Fact]
        public void Test3()
        {
            var PandoraVertex = graph.AddNode("Pandora");
            var ArendelleVertex = graph.AddNode("Arendelle");
            graph.AddEdge(PandoraVertex, ArendelleVertex, 0);
            string[] arr = { };
            Assert.Null(graph.BusinessTrip(graph, arr));

        }
    }
}
