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
    public partial class Task2 : Form
    {
        private Form1 parent;
        public Task2(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void find_b_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "" || tb2.Text == "")
            {
                MessageBox.Show("Не указаны вершины.");
                return;
            }
            IEnumerable<Vertex> list = parent.GetCommon(tb1.Text, tb2.Text);
            if (list == null)
                return;
            if (list.Count() == 0)
            {
                MessageBox.Show("Не существует общих вершин.");
                return;
            }
            else if (list.Count() > 1)
            {
                MessageBox.Show("Существует более одной общей вершины.");
                return;
            }
            else
            {
                MessageBox.Show("Общая вершина: " + list.ElementAt(0).Value);
                return;
            }
        }
    }
}
