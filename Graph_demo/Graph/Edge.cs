using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_demo
{
    public class Edge : IComparable<Edge>
    {
        private Vertex begin = new Vertex();
        private Vertex end = new Vertex();
        private int weight;
        private int capacity;
        private int flow;

        public Edge()
        {
            this.weight = 1;
            capacity = weight;
            this.flow = 0;
        }

        public int CompareTo(Edge comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.Weight.CompareTo(comparePart.Weight);
        }

        public Edge(Vertex a, Vertex b)
        {
            this.begin = a;
            this.end = b;
            this.weight = 1;
            capacity = weight;
        }

        public Edge(Vertex a, Vertex b, int weight)
        {
            this.begin = a;
            this.end = b;
            this.weight = weight;
            capacity = weight;
        }
        
        public Vertex Begin
        {
            get => begin;
            set => begin = value;
        }

        public Vertex End
        {
            get => end;
            set => end = value;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public int Capacity
        {
            get => capacity;
            set => capacity = value;
        }

        public int Flow
        {
            get => flow;
            set => flow = value;
        }
    }
}
