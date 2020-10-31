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
    public partial class Task6 : Form
    {
        public Form1 parent;
        public Task6(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void execute_b_Click(object sender, EventArgs e)
        {
            if (from_tb.Text == "" || to_tb.Text == "" || len_tb.Text == "")
            {
                ErrorMessanger.Message = "Не заполнены поля.";
                parent.ThrowMessage();
            }
            if (from_tb.Text == to_tb.Text)
            {
                ErrorMessanger.Message = "Нельзя выполнить для петли.";
                parent.ThrowMessage();
            }
            else
            {
                parent.FindPathLessThan(from_tb.Text, to_tb.Text, int.Parse(len_tb.Text));
            }
        }
    }
}
