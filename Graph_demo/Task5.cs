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
    public partial class Task5 : Form
    {
        public Form1 parent;
        public Task5(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vertex v;
            if (inp_tb.Text == "")
            {
                MessageBox.Show("Не указана вершина.");
            }

            try
            {
                v = parent.control.Graph_.Vertices.Single(x => x.Value == inp_tb.Text);
            }
            catch
            {
                MessageBox.Show("В графе нет заданной вершины.");
                return;
            }

            KeyValuePair<List<Vertex>, int> pair = parent.control.Graph_.GetShortestCycle(v);
            if (pair.Value == 10000)
            {
                MessageBox.Show("Цикл отсутствует.");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (Vertex ver in pair.Key)
                    sb.Append(ver.Value + "-");
                sb.Length = sb.Length - 1;
                MessageBox.Show("Цикл: " + sb.ToString() + " Длина: " + pair.Value + ".");
            }
        }
    }
}
