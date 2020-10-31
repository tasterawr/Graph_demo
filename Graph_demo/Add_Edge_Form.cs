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
    public partial class Add_Edge_Form : Form
    {
        public Form1 parent;
        public Add_Edge_Form()
        {
            InitializeComponent();
        }

        public Add_Edge_Form(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void add_edge_b_Click(object sender, EventArgs e)
        {
            if (parent.control.Graph_ == null)
            {
                MessageBox.Show("Граф не был создан.");
                return;
            }
            if (ver_a_tb.Text != "" && ver_b_tb.Text != "" && ver_weight_tb.Text == "")
            {
                parent.AddEdge(ver_a_tb.Text, ver_b_tb.Text);
            }
            else if (ver_a_tb.Text != "" && ver_b_tb.Text != "" && ver_weight_tb.Text != "")
            {
                parent.AddEdge(ver_a_tb.Text, ver_b_tb.Text, int.Parse(ver_weight_tb.Text));
            }
            this.Close();
        }
    }
}
