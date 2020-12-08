using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Graph_demo
{
    public partial class VisualForm : Form
    {
        public Form1 parent;
        public int field_x = 8;
        public int field_y = 40;
        public int field_width = 480;
        public int field_height = 384;
        public Dictionary<Vertex, Point> vertices_points = new Dictionary<Vertex, Point>();
        public Dictionary<Edge, KeyValuePair<Point, Point>> edges_points = new Dictionary<Edge, KeyValuePair<Point, Point>>();
        public Dictionary<Edge, bool> kruskal_edges = new Dictionary<Edge, bool>();
        public List<Point> connector = new List<Point>();
        public int ptr_l = 20;
        public bool nextstep;
        public Thread thread;
        public bool working = false;
        public VisualForm(Form1 parent)
        {
            this.parent = parent;
            parent.visualizer = this;
            InitializeComponent();
        }

        public void SetMessage(string s)
        {
            string[] str = s.Split('\n');
            Invoke((MethodInvoker)delegate {
                this.textBox1.Text = "";
                foreach(string s_ in str)
                {
                    this.textBox1.AppendText(s_);
                    this.textBox1.AppendText(Environment.NewLine);
                }
                this.nextstep = false;
            });
        }

        public void SetKruskalState(Edge e)
        {
            Invoke((MethodInvoker)delegate {
                Graphics g = this.CreateGraphics();
                if (e != null)
                    kruskal_edges[e] = true;
                this.PaintField();
                this.DrawEdges();
                this.DrawVertices();
                this.nextstep = false;
            });
        }

        public void SetSelectedEdge(Edge e)
        {
            Invoke((MethodInvoker)delegate {
                this.ShowSelectedEdge(e);
            });
        }

        public void TurnOffFunction()
        {
            Invoke((MethodInvoker)delegate {
                this.working = false;
                this.nextstep = false;
                this.button1.Text = "Запуск";
                this.textBox1.Text = "";
                foreach (Edge e in parent.control.Graph_.Edges)
                    kruskal_edges[e] = false;
                UpdatePicture();
                this.working = false;
                this.nextstep = false;
            });
        }

        public void PaintField()
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, field_x, field_y, field_width, field_height);
        }

        public void UpdatePicture()
        {
            PaintField();
            DrawEdges();
            DrawVertices();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Graphics g = this.CreateGraphics();
                Pen pen = new Pen(Color.Black);
                for (int i = field_x + 32; i < field_x + field_width; i += 32)
                {
                    g.DrawLine(pen, i, field_y, i, field_y + field_height);
                }
                for (int i = field_y + 32; i < field_y + field_height; i += 32)
                {
                    g.DrawLine(pen, field_x, i, field_x + field_width, i);
                }
                UpdatePicture();
            }
            else
            {
                Graphics g = this.CreateGraphics();
                g.Clear(SystemColors.Control);
                UpdatePicture();
            }
        }

        private void VisualForm_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            if (x < field_x || y < field_y || x > field_x + field_width || y > field_y + field_height)
                return;
            else
            {
                try
                {
                    KeyValuePair<Vertex, Point> p = vertices_points.Single(obj => Math.Abs(x - obj.Value.X) < 32 && Math.Abs(y - obj.Value.Y) < 32);
                    connector.Add(p.Value);

                    if (connector.Count == 2)
                    {
                        KeyValuePair<Vertex, Point> p1 = vertices_points.Single(obj => obj.Value == connector[0]);
                        KeyValuePair<Vertex, Point> p2 = vertices_points.Single(obj => obj.Value == connector[1]);
                        edges_points.Add(new Edge(p1.Key, p2.Key, int.MaxValue), new KeyValuePair<Point, Point>(p1.Value, p2.Value));
                        connector.Remove(p1.Value);
                        connector.Remove(p2.Value);

                        if (parent.control.Graph_.Weighted)
                        {
                            AddEdgeVIs form = new AddEdgeVIs(p1.Key.Value, p2.Key.Value, parent);
                            form.Show();
                        }
                        else
                        {
                            parent.AddEdge(p1.Key.Value, p2.Key.Value);
                        }
                    }
                }
                catch
                {
                    int v_x = -1;
                    int v_y = -1;
                    for (int i = field_x; i < field_x + field_width; i += 32)
                    {
                        if (e.X - i < 32)
                        {
                            v_x = i;
                            break;
                        }
                    }
                    for (int i = field_y; i < field_y + field_height; i += 32)
                    {
                        if (e.Y - i < 32)
                        {
                            v_y = i;
                            break;
                        }
                    }

                    Point p = new Point(v_x, v_y);
                    AddVer_Form form = new AddVer_Form(parent);
                    form.Show();
                    vertices_points.Add(new Vertex(""), p);
                }
            }
        }

        public void AddVertexToList(Vertex v)
        {
            KeyValuePair<Vertex, Point> pair = vertices_points.Single(x => x.Key.Value == "");
            Point p = pair.Value;
            vertices_points.Remove(pair.Key);
            vertices_points.Add(v, p);
            UpdatePicture();
            
        }

        public void DrawVertices()
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(Color.DarkOrange);
            Brush t_br = new SolidBrush(Color.Black);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            pen.Width = 3;
            Font drawFont = new Font("Times New Roman", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            //StringFormat drawFormat = new StringFormat();
            foreach (KeyValuePair<Vertex, Point> pair in vertices_points)
            {
                g.DrawEllipse(pen, pair.Value.X, pair.Value.Y, 32, 32);
                g.FillEllipse(br, pair.Value.X, pair.Value.Y, 32, 32);
                string s = pair.Key.Value;
                Rectangle r = new Rectangle(pair.Value.X, pair.Value.Y, 32, 32);
                g.DrawString(s, drawFont, t_br, r, stringFormat);
            }
        }

        public void AddEdgeToList(Edge e)
        {
            KeyValuePair<Edge, KeyValuePair<Point, Point>> pair = edges_points.Single(x => x.Key.Weight == int.MaxValue);
            Point p1 = pair.Value.Key;
            Point p2 = pair.Value.Value;
            edges_points.Remove(pair.Key);
            edges_points.Add(e, new KeyValuePair<Point, Point>(p1, p2));
            kruskal_edges.Add(e, false);
            UpdatePicture();
        }

        public void DrawEdges()
        {
            Graphics g = this.CreateGraphics();
            Brush t_br = new SolidBrush(Color.Red);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            Font drawFont = new Font("Times New Roman", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            Pen pen = new Pen(Color.Black);
            pen.Width = 5;
            if (!working)
            {
                if (!parent.control.Graph_.Orient)
                    foreach (KeyValuePair<Edge, KeyValuePair<Point, Point>> pair in edges_points)
                    {
                        Point p1 = new Point();
                        Point p2 = new Point();
                        p1.X = pair.Value.Key.X + 16;
                        p1.Y = pair.Value.Key.Y + 16;
                        p2.X = pair.Value.Value.X + 16;
                        p2.Y = pair.Value.Value.Y + 16;
                        g.DrawLine(pen, pair.Value.Key.X + 16, pair.Value.Key.Y + 16,
                        pair.Value.Value.X + 16, pair.Value.Value.Y + 16);
                        if (parent.control.Graph_.Weighted)
                        {
                            Point middle = GetMiddlePoint(p1, p2);
                            Rectangle r = new Rectangle(middle.X, middle.Y, 32, 32);
                            g.DrawString(pair.Key.Weight.ToString(), drawFont, t_br, r, stringFormat);
                        }

                    }
                else
                {
                    foreach (KeyValuePair<Edge, KeyValuePair<Point, Point>> pair in edges_points)
                    {
                        Point p1 = new Point();
                        Point p2 = new Point();
                        p1.X = pair.Value.Key.X + 16;
                        p1.Y = pair.Value.Key.Y + 16;
                        p2.X = pair.Value.Value.X + 16;
                        p2.Y = pair.Value.Value.Y + 16;
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        Point p = GetIntersectPoint(p1, p2);
                        g.DrawLine(pen, p.X, p.Y, pair.Value.Key.X + 16, pair.Value.Key.Y + 16);
                        if (parent.control.Graph_.Weighted)
                        {
                            Point middle = GetMiddlePoint(p1, p2);
                            Rectangle r = new Rectangle(middle.X, middle.Y, 32, 32);
                            g.DrawString(pair.Key.Weight.ToString(), drawFont, t_br, r, stringFormat);
                        }
                    }
                }
            }
            else
            {
                foreach (KeyValuePair<Edge, bool> pair_ in kruskal_edges)
                {
                    if (kruskal_edges[pair_.Key] == false)
                        pen.Color = Color.LightGray;
                    else
                        pen.Color = Color.Black;
                    KeyValuePair<Edge, KeyValuePair<Point, Point>> pair = edges_points.Single(x => x.Key == pair_.Key);
                    Point p1 = new Point();
                    Point p2 = new Point();
                    p1.X = pair.Value.Key.X + 16;
                    p1.Y = pair.Value.Key.Y + 16;
                    p2.X = pair.Value.Value.X + 16;
                    p2.Y = pair.Value.Value.Y + 16;
                    Point p = GetIntersectPoint(p1, p2);
                    g.DrawLine(pen, p.X, p.Y, pair.Value.Key.X + 16, pair.Value.Key.Y + 16);
                    if (parent.control.Graph_.Weighted)
                    {
                        Point middle = GetMiddlePoint(p1, p2);
                        Rectangle r = new Rectangle(middle.X, middle.Y, 32, 32);
                        g.DrawString(pair.Key.Weight.ToString(), drawFont, t_br, r, stringFormat);
                    }
                }
            }
            
        }

        public void ShowSelectedEdge(Edge e)
        {
            Graphics g = this.CreateGraphics();
            Brush t_br = new SolidBrush(Color.Red);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            Font drawFont = new Font("Times New Roman", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            Pen pen = new Pen(Color.Green);
            pen.Width = 5;
            KeyValuePair<Edge, KeyValuePair<Point, Point>> pair = edges_points.Single(x => x.Key == e);
            Point p1 = new Point();
            Point p2 = new Point();
            p1.X = pair.Value.Key.X + 16;
            p1.Y = pair.Value.Key.Y + 16;
            p2.X = pair.Value.Value.X + 16;
            p2.Y = pair.Value.Value.Y + 16;
            Point p = GetIntersectPoint(p1, p2);
            g.DrawLine(pen, p.X, p.Y, pair.Value.Key.X + 16, pair.Value.Key.Y + 16);
            if (parent.control.Graph_.Weighted)
            {
                Point middle = GetMiddlePoint(p1, p2);
                Rectangle r = new Rectangle(middle.X, middle.Y, 32, 32);
                g.DrawString(pair.Key.Weight.ToString(), drawFont, t_br, r, stringFormat);
            }
            DrawVertices();
        }

        public Point GetMiddlePoint(Point p1, Point p2)
        {
            Point p = new Point();
            double x = (p1.X + p2.X) / 2;
            double y = (p1.Y + p2.Y) / 2;

            p.X = (int)x;
            p.Y = (int)y;
            return p;
        }

        public Point GetIntersectPoint(Point p1, Point p2)
        {
            Graphics g = this.CreateGraphics();
            Point p = new Point();
            int edg_len = (int)Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
            double ratio = (double)16 / edg_len;

            double angle = 45 * (Math.PI / 180);
            double costheta = Math.Cos(angle);
            double sintheta = Math.Sin(angle);

            if (p2.X > p1.X && p2.Y > p1.Y)
            {
                double vert_leg = Math.Abs(p2.Y - p1.Y)*ratio;
                double horiz_leg = Math.Abs(p2.X - p1.X) * ratio;
                p.X = p2.X - (int)horiz_leg;
                p.Y = p2.Y - (int)vert_leg;
            }
            else if (p2.X > p1.X && p2.Y < p1.Y)
            {
                double vert_leg = Math.Abs(p2.Y - p1.Y) * ratio;
                double horiz_leg = Math.Abs(p2.X - p1.X) * ratio;
                p.X = p2.X - (int)horiz_leg;
                p.Y = p2.Y + (int)vert_leg;
            }
            else if (p2.X < p1.X && p2.Y < p1.Y)
            {
                double vert_leg = Math.Abs(p2.Y - p1.Y) * ratio;
                double horiz_leg = Math.Abs(p2.X - p1.X) * ratio;
                p.X = p2.X + (int)horiz_leg;
                p.Y = p2.Y + (int)vert_leg;
            }
            else if (p2.X < p1.X && p2.Y > p1.Y)
            {
                double vert_leg = Math.Abs(p2.Y - p1.Y) * ratio;
                double horiz_leg = Math.Abs(p2.X - p1.X) * ratio;
                p.X = p2.X + (int)horiz_leg;
                p.Y = p2.Y - (int)vert_leg;
            }
            else if (p2.X > p1.X && p2.Y == p1.Y)
            {
                p.X = p2.X - 16;
                p.Y = p2.Y;
            }
            else if (p2.X == p1.X && p2.Y < p1.Y)
            {
                p.X = p2.X;
                p.Y = p2.Y + 16;
            }
            else if (p2.X < p1.X && p2.Y == p1.Y)
            {
                p.X = p2.X + 16;
                p.Y = p2.Y;
            }
            else if (p2.X == p1.X && p2.Y > p1.Y)
            {
                p.X = p2.X;
                p.Y = p2.Y - 16;
            }

            return p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (working == false)
            {
                working = true;
                button1.Text = "Следующий шаг";
                thread = new Thread(delegate () { parent.VisualKruskal(this); });
                thread.Start();
            }
            else
            {
                if (!nextstep)
                    nextstep = true;
                else
                    nextstep = false;
            }
        }

        public void CheckIfGraphExists()
        {
            if (parent.control.Graph_.Vertices.Count != 0)
            {
                GenerateGraph();
            }
        }

        public void GenerateGraph()
        {
            Dictionary<Vertex, Point> temp = new Dictionary<Vertex, Point>();
            foreach(Vertex v in parent.control.Graph_.Vertices)
            {
                bool done = false;
                while (!done)
                {
                    KeyValuePair<int, int> p = RandGenerator.GeneratePoint(field_x, field_y, field_width, field_height);

                    for (int i = field_x; i < field_x + field_width; i += 32)
                    {
                        for (int j = field_y; j < field_y + field_height; j += 32)
                        {
                            if (p.Key - i < 32 && p.Value - j < 32)
                            {
                                foreach (KeyValuePair<Vertex,Point> pair in temp)
                                {
                                    if (pair.Value.X == i && pair.Value.Y == j ||
                                        Math.Abs(pair.Value.X - p.Key) < 64 && Math.Abs(pair.Value.Y - p.Value) < 64)
                                        break;

                                }

                                Point pnt = new Point(p.Key, p.Value);
                                temp.Add(v, pnt);
                                vertices_points.Add(v, pnt);
                                done = true;
                                break;
                            }
                        }
                        if (done)
                            break;
                    }
                }
                
            }

            //foreach(Edge e1 in parent.control.Graph_.Edges)
            //{
            //    foreach(Edge e2 in parent.control.Graph_.Edges)
            //    {
            //        if (e1 != e2)
            //        {
            //            Point p1 = vertices_points[e1.Begin];
            //            Point p2 = vertices_points[e1.End];
            //            Point p3 = vertices_points[e2.Begin];
            //            Point p4 = vertices_points[e2.End];

            //            if (CheckIntersection.Intersect(p1, p2, p3, p4))
            //            {
            //                vertices_points = new Dictionary<Vertex, Point>();
            //                temp = null;
            //                GenerateGraph();
            //            }
            //        }
            //    }
            //}

            foreach (Edge e1 in parent.control.Graph_.Edges)
            {
                Point p1 = vertices_points[e1.Begin];
                Point p2 = vertices_points[e1.End];

                edges_points.Add(e1, new KeyValuePair<Point, Point>(p1,p2));

            }

            UpdatePicture();
        }
    }
}
