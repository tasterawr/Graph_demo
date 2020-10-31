using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_demo
{
    public class Controller
    {
        private List<Graph> graphs = new List<Graph>();
        private Graph current;

        public Controller()
        {
            return;
        }

        public Graph AddGraph()
        {
            Graph g = new Graph();
            this.graphs.Add(g);
            current = g;
            return g;
        }

        public Graph AddGraph(string filename)
        {
            Graph g = new Graph(filename);
            graphs.Add(g);
            current = g;
            return g;
        }

        public Graph AddGraph(bool orient, bool weight)
        {
            Graph g = new Graph(orient, weight);
            graphs.Add(g);
            current = g;
            return g;
        }

        public Controller Controller_
        {
            get => this;
        }

        public Graph Graph_
        {
            get => current;
            set => current = value;
        }
    }
}
