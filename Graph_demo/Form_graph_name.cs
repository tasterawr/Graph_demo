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
    public partial class Form_graph_name : Form
    {
        public Form1 parent;
        public bool file = false;
        public bool copy = false;
        public int copy_task;
        public Form_graph_name(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        public Form_graph_name(Form1 parent, bool t)
        {
            this.parent = parent;
            file = t;
            InitializeComponent();
        }

        public Form_graph_name(string name, bool copy, Form1 parent)
        {
            this.parent = parent;
            this.copy = copy;
            InitializeComponent();
            gname_tb.Text = name + " копия";
        }

        public Form_graph_name(Form1 parent, int d)
        {
            this.parent = parent;
            copy_task = d;
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (gname_tb.Text == "")
            {
                MessageBox.Show("Не указано имя графа.");
            }
            else
            {
                if (copy == true)
                {
                    parent.CopyGraph(gname_tb.Text);
                    this.Close();
                    return;
                }
                if (copy_task == 1)
                {
                    parent.GetDerivative(gname_tb.Text);
                    this.Close();
                    return;
                }
                if (file != true)
                {
                    parent.CreateGraph(gname_tb.Text);
                    this.Close();
                    return;
                }
                else
                {
                    parent.CreateWithFile(gname_tb.Text);
                    this.Close();
                    return;
                }
            }
        }

        private void Form_graph_name_Load(object sender, EventArgs e)
        {

        }
    }
}
