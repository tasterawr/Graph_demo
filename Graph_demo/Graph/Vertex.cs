using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_demo
{
    public class Vertex
    {
        private string value_;

        public Vertex()
        {
            this.value_ = "";
        }

        public Vertex(string value)
        {
            this.value_ = value;
        }

        public string Value
        {
            get => value_;
            set => value_ = value;
        }
    }
}
