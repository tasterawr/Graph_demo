using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace Graph_demo
{
    public class Graph
    {
        private List<Vertex> vertices = new List<Vertex>();
        private List<Edge> edges = new List<Edge>();
        private Dictionary<Vertex, List<Vertex>> adj_list = new Dictionary<Vertex, List<Vertex>>();
        private bool oriented = false;
        private bool weighted = false;

        public Graph()
        {
            return;
        }

        public Graph(bool oriented, bool weighted)
        {
            this.oriented = oriented;
            this.weighted = weighted;
        }

        public Graph(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                List<string> input = new List<string>();
                try
                {
                    string inp = sr.ReadLine(); 
                    if (inp[inp.Length-1] == ';')//проверка что в конце файла стоит ';'
                    {
                        inp = inp.Substring(0, inp.Length - 1);
                    }
                    input = inp.Split(';').ToList();
                }
                catch
                {
                    ErrorMessanger.Message = "Список смежности пуст.";
                    return;
                }
                int i = 0;
                char div = '−';
                try
                {
                    while (!input[i].Contains("−") && !input[i].Contains(">"))
                    {
                        AddVertex(input[i]);
                        i++;
                    }
                }
                catch
                {
                    return;
                }
                if (input[i].Contains(">"))
                {
                    div = '>';
                    oriented = true;
                }
                if (input[i].Contains(":"))
                {
                    weighted = true;
                }
                while (i != input.Count)
                {
                    string[] pair = input[i].Split(div);

                    if (pair.Length != 1)
                    {
                        if (weighted)
                        {
                            string[] temp = pair[1].Split(':');
                            int w = int.Parse(temp[1]);
                            Vertex v1 = AddVertex(pair[0]);
                            Vertex v2 = AddVertex(temp[0]);
                            AddEdge(pair[0], temp[0], int.Parse(temp[1]));
                        }
                        else
                        {
                            Vertex v1 = AddVertex(pair[0]);
                            Vertex v2 = AddVertex(pair[1]);
                            AddEdge(pair[0], pair[1]);
                        }

                    }
                    else
                    {
                        AddVertex(pair[0]);
                    }
                    i++; 
                }
            }
        }

        public Graph(Graph previous)
        {
            this.vertices = new List<Vertex>(previous.vertices);
            this.edges = new List<Edge>(previous.edges);
            this.adj_list = new Dictionary<Vertex, List<Vertex>>();
            foreach (Vertex v in previous.vertices)
            {
                this.adj_list.Add(v, new List<Vertex>(previous.adj_list[v]));
            }
            this.oriented = previous.oriented;
            this.weighted = previous.weighted;
        }

        public Vertex AddVertex(string val)
        {
            Vertex v = new Vertex();
            try
            {
                vertices.Single(x => x.Value == val);
            }
            catch
            {
                v = new Vertex(val);
                vertices.Add(v);
                adj_list.Add(v, new List<Vertex>());
                adj_list[v] = new List<Vertex>();
                return v;
            }
            if (v == null)
            {
                ErrorMessanger.Message = "Граф уже имеет вершину с заданным значением.";
                return null;
            }
            else return null;
        }

        public Edge AddEdge(string val1, string val2)
        {
            Vertex a;
            Vertex b;
            if (weighted)
            {
                ErrorMessanger.Message = "Требуется указать вес.";
                return null;
            }
            try
            {
                a = vertices.Single(x => x.Value == val1);
                b = vertices.Single(x => x.Value == val2);
            }
            catch
            {
                ErrorMessanger.Message = "Граф не имеет вершины с заданным значением.";
                return null;
            };
            if (!oriented)
            {
                if (adj_list[a].IndexOf(b) != -1 || adj_list[b].IndexOf(a) != -1)
                {
                    ErrorMessanger.Message = "Ребро уже существует.";
                    return null;
                }
                else
                {
                    Edge e = new Edge(vertices.Single(x => x.Value == val1),
                        vertices.Single(x => x.Value == val2));
                    if (oriented)
                        adj_list[a].Add(b);
                    else
                    {
                        adj_list[a].Add(b);
                        adj_list[b].Add(a);
                    }
                    edges.Add(e);
                    return e;
                };
            }
            else
            {
                if (adj_list[a].IndexOf(b) != -1)
                {
                    ErrorMessanger.Message = "Дуга уже существует.";
                    return null;
                }
                else
                {
                    Edge e = new Edge(vertices.Single(x => x.Value == val1),
                        vertices.Single(x => x.Value == val2));
                    if (oriented)
                        adj_list[a].Add(b);
                    else
                    {
                        adj_list[a].Add(b);
                        adj_list[b].Add(a);
                    }
                    edges.Add(e);
                    return e;
                }
            }
            
        }

        public Edge AddEdge(string val1, string val2, int weight)
        {
            Vertex a;
            Vertex b;
            if (weighted == false)
            {
                ErrorMessanger.Message = "Граф не взвешенный.";
                return null;
            }
            try
            {
                a = vertices.Single(x => x.Value == val1);
                b = vertices.Single(x => x.Value == val2);
            }
            catch
            {
                ErrorMessanger.Message = "Граф не имеет вершины с заданным значением.";
                return null;
            };
            if (!oriented)
            {
                if (adj_list[a].IndexOf(b) != -1 || adj_list[b].IndexOf(a) != -1)
                {
                    ErrorMessanger.Message = "Ребро уже существует.";
                    return null;
                }
                else
                {
                    Edge e = new Edge(vertices.Single(x => x.Value == val1),
                        vertices.Single(x => x.Value == val2), weight);
                    if (oriented)
                        adj_list[a].Add(b);
                    else
                    {
                        adj_list[a].Add(b);
                        adj_list[b].Add(a);
                    }
                    edges.Add(e);
                    return e;
                };
            }
            else
            {
                if (adj_list[a].IndexOf(b) != -1)
                {
                    ErrorMessanger.Message = "Дуга уже существует.";
                    return null;
                }
                else
                {
                    Edge e = new Edge(vertices.Single(x => x.Value == val1),
                        vertices.Single(x => x.Value == val2), weight);
                    if (oriented)
                        adj_list[a].Add(b);
                    else
                    {
                        adj_list[a].Add(b);
                        adj_list[b].Add(a);
                    }
                    edges.Add(e);
                    return e;
                }
            }
        }

        public void DeleteVertex(string value)
        {
            Vertex a;
            try
            {
                a = vertices.Single(x => x.Value == value);
            }
            catch
            {
                ErrorMessanger.Message = "Граф не имеет вершины с заданным значением.";
                return;
            };

            edges.RemoveAll(x => x.Begin.Value == value || x.End.Value == value);
            adj_list.Remove(a);
            foreach (KeyValuePair<Vertex,List<Vertex>> pair in adj_list)
            {
                if (pair.Value.Contains(a))
                {
                    pair.Value.Remove(a);
                }
            }
            vertices.Remove(a);
        }

        public void DeleteEdge(string val1, string val2)
        {
            Vertex a;
            Vertex b;
            try
            {
                a = vertices.Single(x => x.Value == val1);
                b = vertices.Single(x => x.Value == val2);
            }
            catch
            {
                ErrorMessanger.Message = "Граф не имеет вершины с заданным значением.";
                return;
            };
            if (oriented)
                adj_list[a].Remove(b);
            else
            {
                adj_list[a].Remove(b);
                adj_list[b].Remove(a);
            }
            edges.RemoveAll(x => (x.Begin == a && x.End == b) || (x.Begin == b && x.End == a));
        }

        public void GraphToFile(string filename)
        {
            string div = "";
            if (oriented)
            {
                div = ">";
            }
            else
            {
                div = "−";
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (Vertex v in vertices)
                {
                    List<Edge> tmp = edges.Where(x => x.Begin == v).ToList();

                    if (tmp.Count != 0)
                        foreach (Edge e in tmp)
                        {
                            if (!weighted)
                                sw.Write(e.Begin.Value + div + e.End.Value + ";");
                            else
                                sw.Write(e.Begin.Value + div + e.End.Value + ":" + e.Weight.ToString() + ";");
                        }
                }
                List<Vertex> iso = GetIsolated();
                foreach (Vertex v in iso)
                    sw.Write(v.Value + ";");
            }
            
        }

        public List<Vertex> GetIsolated()
        {
            List<Vertex> included = new List<Vertex>();
            foreach (Vertex v in vertices)
            {
                List<Edge> tmp = edges.Where(x => (x.Begin == v) || (x.End == v)).ToList();

                if (tmp.Count != 0)
                    foreach (Edge e in tmp)
                    {
                        included.Add(e.Begin);
                        included.Add(e.End);
                    }
            }
            return vertices.Except(included).ToList();
        }

        public List<Vertex> GetOutgoingVertices(string val)
        {
            Vertex v = new Vertex();
            try
            {
                v = vertices.Single(x => x.Value == val);
            }
            catch
            {
                ErrorMessanger.Message = "Граф не имеет вершины с заданным значением.";
                return null;
            }
            if (!oriented)
            {
                ErrorMessanger.Message = "Граф не ориентированный.";
                return null;
            }
            List<Vertex> list = adj_list[v];
            return list;
        }

        public IEnumerable<Vertex> GetCommonVertex(string val1, string val2)
        {
            Vertex v1 = new Vertex();
            Vertex v2 = new Vertex();
            try
            {
                v1 = vertices.Single(x => x.Value == val1);
                v2 = vertices.Single(x => x.Value == val2);
            }
            catch
            {
                ErrorMessanger.Message = "Граф не имеет вершины с заданным значением.";
                return null;
            }
            if (oriented)
            {
                ErrorMessanger.Message = "Граф не должен быть ориентированным.";
                return null;
            }
            List<Vertex> l1 = adj_list[v1];
            List<Vertex> l2 = adj_list[v2];
            try
            {
                IEnumerable<Vertex> inter = l1.Intersect(l2);
                return inter;
            }
            catch
            {
                return null;
            }
        }

        public List<List<Vertex>> GetPaths(Vertex from, Vertex to, Dictionary<Vertex,bool> visited, 
            List<List<Vertex>> paths, List<Vertex> path)
        {
            if (from.Value == to.Value)
            {
                paths.Add(new List<Vertex>(path));
                path = new List<Vertex>();
                return paths;
            }
            else
            {
                visited[from] = true;
                foreach (Vertex adj_v in adj_list[from])
                {
                    if (!visited[adj_v])
                    {
                        path.Add(adj_v);
                        GetPaths(adj_v, to, visited, paths, path);
                        path.RemoveAt(path.Count - 1);
                    }
                }
                visited[from] = false;
                return paths;
            }
        } 

        public List<List<Vertex>> GetCycles(Vertex from, Vertex sought,
            List<List<Vertex>> cycles, List<Vertex> path)
        {
            Queue<Vertex> q = new Queue<Vertex>();
            Dictionary<Vertex, bool> visited = new Dictionary<Vertex, bool>();
            Dictionary<Vertex, Vertex> p = new Dictionary<Vertex, Vertex>();
            List<Vertex> cycle_end = new List<Vertex>();
            foreach (Vertex v in vertices)
            {
                p.Add(v, null);
                visited.Add(v, false);
            }
            q.Enqueue(from);
            while (q.Count != 0)
            {
                Vertex v = q.First();
                q.Dequeue();
                foreach (Vertex adj_v in adj_list[v])
                {
                    if (adj_v == from)
                    {
                        if (v == adj_v)
                            continue;
                        int ind = cycle_end.IndexOf(v);
                        if (ind < 0)
                            cycle_end.Add(v);
                        continue;
                    }
                    if (!visited[adj_v])
                    {
                        visited[adj_v] = true;
                        q.Enqueue(adj_v);
                        p[adj_v] = v;
                    }
                    

                }
            }

            foreach(Vertex v in cycle_end)
            {
                Vertex parent = p[v];
                List<Vertex> cycle = new List<Vertex>();
                cycle.Add(from);
                cycle.Add(v);
                while (parent != from)
                {
                    cycle.Add(parent);
                    parent = p[parent];
                }
                cycle.Add(from);
                cycle.Reverse();
                if (cycle.IndexOf(sought) != -1)
                {
                    cycles.Add(cycle);
                }
            }
            return cycles;
        }

        public KeyValuePair<List<Vertex>, int> GetShortestCycle(Vertex v)
        {
            List<Vertex> sought_cycle = new List<Vertex>();
            int min_len = 10000;

            foreach(Vertex ver in vertices)
            {
                List<Vertex> path = new List<Vertex>();
                List<List<Vertex>> cycles = new List<List<Vertex>>();
                path.Add(ver);
                cycles = GetCycles(ver, v, cycles, path);
                foreach(List<Vertex> cycle in cycles)
                {
                    int len = 0;
                    if (cycle.Count() - 1 < min_len)
                    {
                        min_len = cycle.Count() - 1;
                        sought_cycle = cycle;
                    }
                }
            }

            KeyValuePair<List<Vertex>, int> pair = new KeyValuePair<List<Vertex>, int>(sought_cycle, min_len);
            return pair;
        }
        
        public Graph Kruskal()
        {
            if (weighted == false)
            {
                ErrorMessanger.Message = "Граф не взвешенный.";
                return null;
            }

            Graph g = new Graph(this);
            g.edges.Sort();
            List<Edge> new_edges = new List<Edge>();
            List<List<Vertex>> con_comp = new List<List<Vertex>>();
            foreach (Vertex v in g.vertices)
            {
                List<Vertex> l = new List<Vertex>();
                l.Add(v);
                con_comp.Add(l);
            }

            foreach (Edge e in g.edges)
            {
                List<Vertex> comp1 = con_comp.Single(x => x.IndexOf(e.Begin) != -1);
                List<Vertex> comp2 = con_comp.Single(x => x.IndexOf(e.End) != -1);
                if (comp1 != comp2)
                {
                    new_edges.Add(e);
                    List<Vertex> comp = comp1.Concat(comp2).ToList();
                    con_comp.Add(comp);
                    con_comp.Remove(comp1);
                    con_comp.Remove(comp2);
                }
            }

            List<Edge> tmp = new List<Edge>(g.edges);
            foreach (Edge e in tmp)
            {
                if (new_edges.FindIndex(x => x.Begin.Value == e.Begin.Value &&
                x.End.Value == e.End.Value) == -1)
                    g.DeleteEdge(e.Begin.Value, e.End.Value);
            }
            return g;
        }

        public int GetEccentr(Vertex from)
        {
            Dictionary<Vertex, bool> visited = new Dictionary<Vertex, bool>();
            Dictionary<Vertex, Vertex> p = new Dictionary<Vertex, Vertex>();
            Dictionary<Vertex, int> d = new Dictionary<Vertex, int>();
            int n = vertices.Count;

            foreach (Vertex v in vertices)
            {
                d.Add(v, int.MaxValue);
                visited.Add(v, false);
                p.Add(v, null);
            }

            d[from] = 0;
            while (n > 0)
            {
                Vertex v = new Vertex();
                int min = int.MaxValue;
                foreach (KeyValuePair<Vertex, int> pair in d)
                {
                    if (pair.Value < min)
                    {
                        if (visited[pair.Key] == true)
                            continue;
                        v = pair.Key;
                        min = pair.Value;
                    }
                }

                if (v.Value == "")
                    break;
                visited[v] = true;
                n--;

                foreach (Vertex vert in adj_list[v])
                {
                    Edge e = new Edge();
                    if (Orient)
                        e = edges.Single(x => x.Begin == v && x.End == vert);
                    else
                        e = edges.Single(x => (x.Begin == v && x.End == vert) ||
                        (x.End == v && x.Begin == vert));

                    if (d[vert] > d[v] + e.Weight)
                    {
                        d[vert] = d[v] + e.Weight;
                    }
                }
            }

            int eccentr = -1;
            foreach (KeyValuePair<Vertex, int> pair in d)
            {
                if (Math.Abs(pair.Value) > eccentr)
                    eccentr = pair.Value;
            }

            return eccentr;
        }

        public int GetRadius()
        {
            List<List<Vertex>> con_comp = new List<List<Vertex>>();
            foreach (Vertex v in vertices)
            {
                List<Vertex> l = new List<Vertex>();
                l.Add(v);
                con_comp.Add(l);
            }

            foreach (Edge e in edges)
            {
                List<Vertex> comp1 = con_comp.Single(x => x.IndexOf(e.Begin) != -1);
                List<Vertex> comp2 = con_comp.Single(x => x.IndexOf(e.End) != -1);
                if (comp1 != comp2)
                {
                    List<Vertex> comp = comp1.Concat(comp2).ToList();
                    con_comp.Add(comp);
                    con_comp.Remove(comp1);
                    con_comp.Remove(comp2);
                }
            }
            if (con_comp.Count > 1)
            {
                ErrorMessanger.Message = "Граф не является связным.";
                return -1;
            }
            List<int> ecc_s = new List<int>();
            int radius = int.MaxValue;
            foreach (Vertex v in vertices)
            {
                ecc_s.Add(GetEccentr(v));
            }
            
            foreach (int k in ecc_s)
            {
                if (k < radius)
                    radius = k;
            }

            return radius;
        }

        public KeyValuePair<List<Vertex>,int> FordBellman(Vertex from, Vertex to)
        {
            Dictionary<Vertex, int> d = new Dictionary<Vertex, int>();
            Dictionary<Vertex, Vertex> p = new Dictionary<Vertex, Vertex>();
            foreach (Vertex v in vertices)
            {
                d.Add(v, 10000);
                p.Add(v, null);
            }

            d[from] = 0;
            bool neg_cycle_flag = false;

            for (int i=0; i< vertices.Count;++i)
            {
                foreach (Edge e in edges)
                {
                    if (d[e.Begin] < int.MaxValue)
                    {
                        if (Orient)
                        {
                            if (d[e.End] > d[e.Begin] + e.Weight)
                            {
                                d[e.End] = -10000 > d[e.Begin] + e.Weight ? -10000 : d[e.Begin] + e.Weight;
                                p[e.End] = e.Begin;
                            }
                            if (d[e.End] == -10000)
                                neg_cycle_flag = true;
                        }
                        else
                        {
                            if (d[e.End] > d[e.Begin] + e.Weight)
                            {
                                d[e.End] = -10000 > d[e.Begin] + e.Weight ? -10000 : d[e.Begin] + e.Weight;
                                p[e.End] = e.Begin;
                            }
                            else if (d[e.Begin] > d[e.End] + e.Weight)
                            {
                                d[e.Begin] = -10000 > d[e.End] + e.Weight ? -10000 : d[e.End] + e.Weight;
                                p[e.Begin] = e.End;
                            }
                            if (d[e.End] == -10000 || d[e.Begin] == -10000)
                                neg_cycle_flag = true;
                        }
                    }
                }
            }

            List<Vertex> path = new List<Vertex>();
            if (d[to] == int.MaxValue)
                return new KeyValuePair<List<Vertex>, int>(null, -1);
            else
            {
                Vertex cur = to;
                int w = 0;
                while(cur != null)
                {
                    path.Add(cur);
                    cur = p[cur];
                    try
                    {
                        Edge e = edges.Single(x => x.Begin == p[cur] && x.End == cur);
                        w += e.Weight;
                        if (w < -10000)
                            return new KeyValuePair<List<Vertex>, int>(null, -10000);
                    }
                    catch
                    {
                        continue;
                    }
                }

                path.Reverse();
                return new KeyValuePair<List<Vertex>, int>(path, d[to]);
            }
        }

        public KeyValuePair<List<Vertex>,int> FindPathLessThan(Vertex a, Vertex b, int l)
        {
            KeyValuePair<List<Vertex>, int> path = FordBellman(a, b);
            if (path.Value == -10000)
                return new KeyValuePair<List<Vertex>, int>(null, -10000);
            if (path.Value <= l)
                return path;
            else
                return new KeyValuePair<List<Vertex>, int>(null, -1);
        }

        public List<KeyValuePair<List<Vertex>, int>> FloydWarshall(Vertex v1, Vertex v2, Vertex to)
        {
            Dictionary<Vertex, Dictionary<Vertex, int>> d = new Dictionary<Vertex, Dictionary<Vertex, int>>();
            Dictionary<Vertex, Dictionary<Vertex, Vertex>> p = new Dictionary<Vertex, Dictionary<Vertex, Vertex>>();
            foreach (Vertex v in vertices)
            {
                Dictionary<Vertex, int> pair = new Dictionary<Vertex, int>();
                Dictionary<Vertex, Vertex> p_pair = new Dictionary<Vertex, Vertex>();
                foreach (Vertex v_ in vertices)
                {
                    Edge e;
                    try
                    {
                        if (Orient)
                            e = edges.Single(x => x.Begin == v && x.End == v_);
                        else
                            e = edges.Single(x => (x.Begin == v && x.End == v_) || (x.Begin == v_ && x.End == v));
                        pair.Add(v_, e.Weight);
                    }
                    catch
                    {
                        pair.Add(v_, 100000);
                    }
                    p_pair.Add(v_, v_);
                }
                d.Add(v, pair);
                p.Add(v, p_pair);
                d[v][v] = 0;
            }

            bool neg_cycle_flag = false;

            foreach (Vertex a in vertices)
            {
                foreach (Vertex b in vertices)
                {
                    if (d[a][b] != 100000)
                        foreach (Vertex c in vertices)
                        {
                            if (d[a][c] > d[a][b] + d[b][c])
                            {
                                d[a][c] = d[a][b] + d[b][c];
                                p[a][c] = p[a][b];
                            }
                            if (d[a][c] < 100000 && d[c][c] < 0 && d[c][b] < 100000)
                            {
                                d[a][b] = -100000;
                            }
                        }
                }
            }

            foreach (Vertex a in vertices)
            {
                foreach (Vertex b in vertices)
                {
                    if (d[a][b] != 100000)
                        foreach (Vertex c in vertices)
                        {
                            if (d[a][c] < 100000 && d[c][c] < 0 && d[c][b] < 100000)
                            {
                                d[a][b] = -100000;
                            }
                        }
                }
            }

            List<Vertex> path1 = new List<Vertex>();
            List<Vertex> path2 = new List<Vertex>();
            List<KeyValuePair<List<Vertex>, int>> ans = new List<KeyValuePair<List<Vertex>, int>>();

            if (d[v1][to] == -100000)
            {
                List<Vertex> l = new List<Vertex>();
                l.Add(v1);
                l.Add(to);
                ans.Add(new KeyValuePair<List<Vertex>, int>(l, -100000));
            }
            else if (d[v1][to] == 100000)
            {
                path1 = null;
            }
            else
            {
                Vertex ver = v1;
                while (ver != to)
                {
                    path1.Add(ver);
                    ver = p[ver][to];
                }
                path1.Add(to);
                ans.Add(new KeyValuePair<List<Vertex>, int>(path1, d[v1][to]));
            }

            if (d[v2][to] == -100000)
            {
                List<Vertex> l = new List<Vertex>();
                l.Add(v2);
                l.Add(to);
                ans.Add(new KeyValuePair<List<Vertex>, int>(l, -100000));
            }
            else if (d[v2][to] == 100000)
            {
                path2 = null;
            }
            else
            {
                Vertex ver = v2;
                while (ver != to)
                {
                    path2.Add(ver);
                    ver = p[ver][to];
                }
                path2.Add(to);
                ans.Add(new KeyValuePair<List<Vertex>, int>(path2, d[v2][to]));
            }

            return ans;
        }

        public List<Vertex> Vertices
        {
            get => vertices;
        }

        public List<Edge> Edges
        {
            get => edges;
        }

        public Dictionary<Vertex,List<Vertex>> Adj
        {
            get => adj_list;
        }

        public bool Orient
        {
            get => oriented;
        }

        public bool Weighted
        {
            get => weighted;
        }
    }
}
