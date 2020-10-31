using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Graph_demo
{
    public partial class Task4 : Form
    {
        public List<Edge> edges = new List<Edge>();
        public List<Edge> excl_edges = new List<Edge>();
        public Form1 parent;
        public Task4(Form1 parent)
        {
            this.parent = parent;
            edges = parent.control.Graph_.Edges;
            InitializeComponent();
            RefreshEdges();
        }

        public void RefreshEdges()
        {
            edges_lb.Items.Clear();
            del_edges_lb.Items.Clear();
            char div = '-';
            if (parent.control.Graph_.Orient)
                div = '>';
            foreach (Edge e in edges)
            {
                if (!excl_edges.Contains(e))
                {
                    if (parent.control.Graph_.Weighted)
                        edges_lb.Items.Add(e.Begin.Value + div + e.End.Value + ":" + e.Weight);
                    else
                        edges_lb.Items.Add(e.Begin.Value + div + e.End.Value);
                }
            }

            foreach (Edge e in excl_edges)
            {
                if (parent.control.Graph_.Weighted)
                    del_edges_lb.Items.Add(e.Begin.Value + div + e.End.Value + ":" + e.Weight);
                else
                    del_edges_lb.Items.Add(e.Begin.Value + div + e.End.Value);
            }
            cntr_lab.Text = excl_edges.Count().ToString();
        }

        private void edges_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            char div = '-';
            if (parent.control.Graph_.Orient)
                div = '>';
            string[] s = edges_lb.SelectedItem.ToString().Split(div);
            string[] s_;
            if (parent.control.Graph_.Weighted)
            {
                s_ = s[1].Split(':');
                Edge edg = edges.Single(x => x.Begin.Value == s[0] && x.End.Value == s_[0]);
                excl_edges.Add(edg);
            }
            else
            {
                Edge edg = edges.Single(x => x.Begin.Value == s[0] && x.End.Value == s[1]);
                excl_edges.Add(edg);
            }
            RefreshEdges();
        }

        private void del_edges_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            char div = '-';
            if (parent.control.Graph_.Orient)
                div = '>';
            string[] s = del_edges_lb.SelectedItem.ToString().Split(div);
            string[] s_;
            if (parent.control.Graph_.Weighted)
            {
                s_ = s[1].Split(':');
                Edge edg = edges.Single(x => x.Begin.Value == s[0] && x.End.Value == s_[0]);
                excl_edges.Remove(edg);
            }
            else
            {
                Edge edg = edges.Single(x => x.Begin.Value == s[0] && x.End.Value == s[1]);
                excl_edges.Remove(edg);
            }
            RefreshEdges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vertex from;
            Vertex to;
            if (from_tb.Text == "" || to_tb.Text == "")
            {
                MessageBox.Show("Не заполнены поля.");
                return;
            }
            try
            {
                from = parent.control.Graph_.Vertices.Single(x => x.Value == from_tb.Text);
                to = parent.control.Graph_.Vertices.Single(x => x.Value == to_tb.Text);
            }
            catch
            {
                MessageBox.Show("Граф не содержит указанные вершины.");
                return;
            }
            List<Vertex> path = new List<Vertex>();
            path.Add(from);
            paths_lab.Text = "Пути из " + from.Value + " в " + to.Value + ": ";
            Dictionary<Vertex, bool> visited = new Dictionary<Vertex, bool>();

            foreach(Vertex v in parent.control.Graph_.Vertices)
            {
                visited.Add(v, false);
            }
            List<List<Vertex>> paths = parent.control.Graph_.GetPaths(from, to, visited,
                new List<List<Vertex>>(),path);

            using (StreamWriter sw = new StreamWriter("out.txt"))
            {
                paths_lb.Items.Clear();
                foreach (List<Vertex> path_ in paths)
                {
                    char div = '-';
                    if (parent.control.Graph_.Orient)
                        div = '>';
                    StringBuilder str = new StringBuilder();
                    foreach (Vertex v in path_)
                    {
                        sw.Write(v.Value + div);
                        str.Append(v.Value + div);
                    }
                    sw.WriteLine();
                    str.Length = str.Length - 1;
                    paths_lb.Items.Add(str.ToString());
                }
            }

            int n = paths.Count;
            foreach(List<Vertex> path_ in paths)
            {
                bool done = false;
                for (int i = 0; i< path_.Count - 1; i++)
                {
                    foreach(Edge edg in excl_edges)
                    {
                        string v1 = path_[i].Value;
                        string v2 = path_[i + 1].Value;
                        if (edg.Begin.Value == path_[i].Value && edg.End.Value == path_[i+1].Value)
                        {
                            n--;
                            done = true;
                            break;
                        }
                    }
                    if (done)
                        break;
                }
            }

            if (n == 0)
            {
                MessageBox.Show("При исключении заданных дуг (ребер) не останется путей из " + from.Value + " в " + to.Value + ".");
            }
            else
            {
                MessageBox.Show("При исключении заданных дуг (ребер) останутся пути из " + from.Value + " в " + to.Value + ".");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
