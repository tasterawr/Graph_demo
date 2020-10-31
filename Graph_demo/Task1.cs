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
    public partial class Task1 : Form
    {
        public Form1 parent;
        public Task1(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void Task1_Load(object sender, EventArgs e)
        {

        }

        private void outgoing_b_Click(object sender, EventArgs e)
        {
            if (vertex_inp.Text == "")
            {
                MessageBox.Show("Не указана вершина.");
            }
            else
            {
                List<Vertex> list = parent.GetOutgoing(vertex_inp.Text);
                if (list.Count == 0)
                {
                    MessageBox.Show("Нет выходящих вершин.");
                    return;
                }
                outgoing_lb.Items.Clear();
                foreach (Vertex v in list)
                {
                    outgoing_lb.Items.Add(v.Value);
                }
            }
        }
    }
}
