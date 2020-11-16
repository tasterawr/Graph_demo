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
    public partial class Task8 : Form
    {
        public Form1 parent;
        public Task8(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_tb.Text == "" || s_tb.Text == "")
            {
                MessageBox.Show("Не заполнены все поля.");
                return;
            }
            else
            {
                parent.FindMaxFlow(s_tb.Text, t_tb.Text);
                return;
            }
        }
    }
}
