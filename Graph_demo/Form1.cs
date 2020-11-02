using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_demo
{
    public partial class Form1 : Form
    {
        public Controller control = new Controller();
        public Dictionary<string,Graph> dict = new Dictionary<string, Graph>();
        public Form1()
        {
            InitializeComponent();
        }

        public void RefreshVertices()
        {
            List<Vertex> list = control.Graph_.Vertices;
            List<Vertex> iso = control.Graph_.GetIsolated();
            vertices_list.Items.Clear();
            foreach (Vertex v in list)
            {
                if (iso.Contains(v))
                    vertices_list.Items.Add(v.Value + " (изолированная)");
                else
                    vertices_list.Items.Add(v.Value);
            }
        }

        public void RefreshEdges()
        {
            edges_list.Items.Clear();
            List<Edge> list = control.Graph_.Edges;
            string div = "";
            bool weighted = control.Graph_.Weighted;
            if (control.Graph_.Orient)
                div = ">";
            else
                div = "-";
            foreach (Edge e in list)
            {
                if (!weighted)
                    edges_list.Items.Add(e.Begin.Value + div + e.End.Value);
                else
                    edges_list.Items.Add(e.Begin.Value + div + e.End.Value + ":" + e.Weight.ToString());
            }
        }

        public void RefreshAdjList()
        {
            adj_lb.Items.Clear();
            if (!control.Graph_.Weighted)
            {
                foreach (KeyValuePair<Vertex, List<Vertex>> pair in control.Graph_.Adj)
                {
                    StringBuilder s = new StringBuilder();
                    s.Append(pair.Key.Value.ToString() + " : ");
                    foreach (Vertex v in pair.Value)
                    {
                        s.Append(v.Value.ToString() + ", ");
                    }
                    adj_lb.Items.Add(s.ToString());
                }
            }
            else
            {
                foreach (KeyValuePair<Vertex, List<Vertex>> pair in control.Graph_.Adj)
                {
                    StringBuilder s = new StringBuilder();
                    if (control.Graph_.Orient)
                    {
                        s.Append(pair.Key.Value.ToString() + " : ");
                        foreach (Vertex v in pair.Value)
                        {
                            try
                            {
                                Edge e = control.Graph_.Edges.Single(x => x.Begin == pair.Key && x.End == v);
                                s.Append(v.Value.ToString() + "(" + e.Weight + ")" + ", ");
                            }
                            catch
                            {
                                return;
                            }
                        }
                        adj_lb.Items.Add(s.ToString());
                    }
                    else
                    {
                        s.Append(pair.Key.Value.ToString() + " : ");
                        foreach (Vertex v in pair.Value)
                        {
                            try
                            {
                                Edge e = control.Graph_.Edges.Single(x => (x.Begin == pair.Key && x.End == v) ||
                                (x.End == pair.Key && x.Begin == v));
                                s.Append( v.Value.ToString() + "(" + e.Weight + ")" + ", ");
                            }
                            catch
                            {
                                return;
                            }
                        }
                        adj_lb.Items.Add(s.ToString());
                    }
                    
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void openfile_b_Click(object sender, EventArgs e)
        {
            Form_graph_name form = new Form_graph_name(this,true);
            form.Show();
        }

        public void CreateWithFile(string name)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    Graph g = control.AddGraph(file.FileName);
                    try
                    {
                        dict.Add(name, g);
                    }
                    catch
                    {
                        MessageBox.Show("Имя графа уже используется.");
                        return;
                    }
                    control.Graph_ = g;
                    RefreshVertices();
                    RefreshEdges();
                    RefreshGraphs();
                    RefreshAdjList();
                }
            }
        }

        private void create_b_Click(object sender, EventArgs e)
        {
            Form_graph_name form = new Form_graph_name(this);
            form.Show();
        }

        public void CreateGraph(string name)
        {
            bool orient = false;
            bool weighted = false;
            if (orient_cb.Checked)
            {
                orient = true;
                orient_cb.Checked = false;
            }
            if (weight_cb.Checked)
            {
                weighted = true;
                weight_cb.Checked = false;
            }
            if (orient == false && weighted == false)
            {
                Graph g = control.AddGraph();
                dict.Add(name, g);
            }
            else
            {
                Graph g = control.AddGraph(orient, weighted);
                dict.Add(name, g);
                control.Graph_ = g;
            }
            RefreshGraphs();
            RefreshVertices();
            RefreshAdjList();
            RefreshEdges();
        }

        private void RefreshGraphs()
        {
            graph_lb.Items.Clear();
            foreach (KeyValuePair<string, Graph> g in dict)
            {
                if (g.Value.Orient == false && g.Value.Weighted == false)
                    graph_lb.Items.Add(g.Key + " (Неор. и Невзв.)");
                else if (g.Value.Orient == false && g.Value.Weighted == true)
                    graph_lb.Items.Add(g.Key + " (Неор. и Взв.)");
                else if (g.Value.Orient == true && g.Value.Weighted == false)
                    graph_lb.Items.Add(g.Key + " (Ор. и Невзв.)");
                else
                    graph_lb.Items.Add(g.Key + " (Ор. и Взв.)");

            }
        }
        private void savetofile_b_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    control.Graph_.GraphToFile(save.FileName);
                    MessageBox.Show("Граф успешно сохранен.");
                }
            }

        }

        public void AddVertex(string value)
        {
            control.Graph_.AddVertex(value);
            ThrowMessage();
            RefreshVertices();
            RefreshAdjList();
        }

        public void AddEdge(string val1, string val2)
        {
            control.Graph_.AddEdge(val1, val2);
            ThrowMessage();
            RefreshEdges();
            RefreshVertices();
            RefreshAdjList();
        }

        public void AddEdge(string val1, string val2, int weight)
        {
            control.Graph_.AddEdge(val1, val2, weight);
            ThrowMessage();
            RefreshEdges();
            RefreshVertices();
            RefreshAdjList();
        }

        private void addver_b_Click(object sender, EventArgs e)
        {
            AddVer_Form form = new AddVer_Form(this);
            form.Show();
        }

        private void addedge_b_Click(object sender, EventArgs e)
        {
            Add_Edge_Form form = new Add_Edge_Form(this);
            form.Show();
            RefreshEdges();
            RefreshVertices();
            RefreshAdjList();
        }

        private void deletever_b_Click(object sender, EventArgs e)
        {
            if (vertices_list.SelectedItem == null)
            {
                MessageBox.Show("Не выбрана вершина для удаления.");
            }
            else
            {
                string[] temp = vertices_list.SelectedItem.ToString().Split(' ');
                control.Graph_.DeleteVertex(temp[0]);
                ThrowMessage();
                RefreshEdges();
                RefreshVertices();
                RefreshAdjList();
            }
        }

        private void deleteedge_b_Click(object sender, EventArgs e)
        {
            if (edges_list.SelectedItem == null)
            {
                MessageBox.Show("Не выбрано ребро (дуга) для удаления.");
            }
            else
            {
                char div;
                if (!control.Graph_.Orient)
                    div = '-';
                else
                    div = '>';
                string[] pair = edges_list.SelectedItem.ToString().Split(div);
                if (control.Graph_.Weighted)
                {
                    string[] v = pair[1].Split(':');
                    control.Graph_.DeleteEdge(pair[0], v[0]);
                    ThrowMessage();
                }
                else
                {
                    control.Graph_.DeleteEdge(pair[0], pair[1]);
                    ThrowMessage();
                }
                RefreshEdges();
                RefreshVertices();
                RefreshAdjList();
            }
        }

        private void graph_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = graph_lb.SelectedItem.ToString().IndexOf('(');
            string name = graph_lb.SelectedItem.ToString().Substring(0, pos - 1);
            control.Graph_ = dict[name];
            RefreshEdges();
            RefreshVertices();
            RefreshAdjList();
        }

        private void copy_b_Click(object sender, EventArgs e)
        {
            int pos = graph_lb.SelectedItem.ToString().IndexOf('(');
            string prev_name = graph_lb.SelectedItem.ToString().Substring(0, pos - 1);
            Form_graph_name form = new Form_graph_name(prev_name,true, this);
            form.Show();
        }

        public void CopyGraph(string name)
        {
            int pos = graph_lb.SelectedItem.ToString().IndexOf('(');
            string prev_name = graph_lb.SelectedItem.ToString().Substring(0, pos - 1);
            Graph prev = dict[prev_name];
            Graph n = new Graph(prev);
            dict.Add(name, n);
            RefreshGraphs();
            RefreshEdges();
            RefreshVertices();
            RefreshAdjList();
        }

        private void tasks_b_Click(object sender, EventArgs e)
        {
            if (control.Graph_ == null)
            {
                MessageBox.Show("Граф не был создан.");
                return;
            }
            Task_Form form = new Task_Form(this);
            form.Show();
        }

        public List<Vertex> GetOutgoing(string val)
        {
            if (control.Graph_ == null)
            {
                MessageBox.Show("Граф не был создан.");
                return new List<Vertex>();
            }
            else
            {
                List<Vertex> list = control.Graph_.GetOutgoingVertices(val);
                ThrowMessage();
                return list;
            }
        }

        public IEnumerable<Vertex> GetCommon(string val1, string val2)
        {
            if (control.Graph_ == null)
            {
                MessageBox.Show("Граф не был создан.");
                return new List<Vertex>();
            }
            else
            {
                IEnumerable<Vertex> list = control.Graph_.GetCommonVertex(val1, val2);
                ThrowMessage();
                return list;
            }
        }

        public void GetDerivative(string name)
        {
            Graph g = new Graph(control.Graph_);
            dict.Add(name, g);
            control.Graph_ = g;
            List<Vertex> list = g.GetIsolated();
            foreach (Vertex v in list)
            {
                g.DeleteVertex(v.Value);
                ThrowMessage();
            }
            RefreshVertices();
            RefreshGraphs();
            RefreshEdges();
            RefreshAdjList();
            MessageBox.Show("Граф образован, удалено " + list.Count + " изолированных вершин.");
        }

        public void Kruskal()
        {
            if (control.Graph_.Orient)
            {
                ErrorMessanger.Message = "Граф не должен быть ориентированным.";
                ThrowMessage();
            }
            Graph g = control.Graph_.Kruskal();
            dict.Add("sp. tree", g);
            control.Graph_ = g;
            RefreshVertices();
            RefreshGraphs();
            RefreshEdges();
            RefreshAdjList();
            MessageBox.Show("Минимальное остовное дерево построено.");
        }

        public void GetRadius()
        {
            if (NegWeightsCheck() == 1)
            {
                ErrorMessanger.Message = "Граф имеет отрицательные ребра (дуги).";
                ThrowMessage();
                return;
            }

            MessageBox.Show("Радиус графа = " + control.Graph_.GetRadius());
        }

        public int NegWeightsCheck()
        {
            if (!control.Graph_.Weighted)
            {
                ErrorMessanger.Message = "Ребра (дуги) графа не имеют весов";
                ThrowMessage();
                return -1;

            }

            List<Edge> l = new List<Edge>();
            foreach(Edge e in control.Graph_.Edges)
            {
                if (e.Weight < 0)
                    l.Add(e);
            }

            if (l.Count == 0)
                return 0;
            else return 1;
        }

        public void FindPathLessThan(string v1, string v2, int l)
        {
            Vertex a;
            Vertex b;
            try
            {
                a = control.Graph_.Vertices.Single(x => x.Value == v1);
                b = control.Graph_.Vertices.Single(x => x.Value == v2);
            }
            catch
            {
                ErrorMessanger.Message = "Граф не содержит вершин с указанными значениями.";
                ThrowMessage();
                return;
            }

            KeyValuePair<List<Vertex>,int> pair = control.Graph_.FindPathLessThan(a, b, l);

            if (pair.Key == null)
                MessageBox.Show("Не существует пути.");
            else
            {
                StringBuilder s = new StringBuilder();
                foreach (Vertex v in pair.Key)
                {
                    s.Append(v.Value + "-");
                }
                s.Length--;
                MessageBox.Show("Путь: " + s.ToString() + ", длина = " + pair.Value);
            }
        }

        public void Floyd(string v1, string v2, string to)
        {
            Vertex a;
            Vertex b;
            Vertex c;
            try
            {
                a = control.Graph_.Vertices.Single(x => x.Value == v1);
                b = control.Graph_.Vertices.Single(x => x.Value == v2);
                c = control.Graph_.Vertices.Single(x => x.Value == to);
            }
            catch
            {
                ErrorMessanger.Message = "Граф не содержит вершин с указанными значениями.";
                ThrowMessage();
                return;
            }

            List<KeyValuePair<List<Vertex>, int>> pair = control.Graph_.FloydWarshall(a, b, c);
            StringBuilder s = new StringBuilder();
            s.Append("Из " + v1 + " в " + to + ": ");
            if (pair[0].Key != null)
            {
                foreach (Vertex v in pair[0].Key)
                    s.Append(v.Value + "-");
                s.Length--;
                s.Append(", длина = " + pair[0].Value);
                s.Append("\n");
            }
            else
                s.Append("Не существует.\n");
            s.Append("Из " + v2 + " в " + to + ": ");
            if (pair[1].Key != null)
            {
                foreach (Vertex v in pair[1].Key)
                    s.Append(v.Value + "-");
                s.Length--;
                s.Append(", длина = " + pair[1].Value);
                s.Append("\n");
            }
            else
                s.Append("Не существует.");

            MessageBox.Show(s.ToString());

        }
        public void ThrowMessage()
        {
            if (ErrorMessanger.Message != "")
            {
                MessageBox.Show(ErrorMessanger.Message);
                ErrorMessanger.Message = "";
            }
        }
    }
}
