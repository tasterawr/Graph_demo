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
    public partial class AddVer_Form : Form
    {
        public Form1 parent;
        public AddVer_Form()
        {
            InitializeComponent();
        }

        public AddVer_Form(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void Добавить_вершину_Load(object sender, EventArgs e)
        {

        }

        private void addver_b_Click(object sender, EventArgs e)
        {
            if (parent.control.Graph_ == null)
            {
                MessageBox.Show("Граф не был создан.");
                return;
            }
            if (addver_tb.Text != "")
            {
                parent.AddVertex(addver_tb.Text);
                this.Close();
            }
        }
    }
}
