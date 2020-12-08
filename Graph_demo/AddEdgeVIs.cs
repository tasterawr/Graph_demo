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
    public partial class AddEdgeVIs : Form
    {
        public string val1;
        public string val2;
        public Form1 parent;
        public AddEdgeVIs(string val1, string val2, Form1 parent)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.parent = parent;
            InitializeComponent();
        }

        private void AddEdgeVIs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Укажите вес.");
            }
            else
            {
                parent.AddEdge(val1, val2, int.Parse(textBox1.Text));
                this.Close();
            }
        }
    }
}
