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
    public partial class Task7 : Form
    {
        public Form1 parent;
        public Task7(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (v1_tb.Text == "" || v2_tb.Text == "" || v3_tb.Text == "")
            {
                ErrorMessanger.Message = "Не заполнены поля.";
                parent.ThrowMessage();
                return;
            }
            else
                parent.Floyd(v1_tb.Text, v2_tb.Text, v3_tb.Text);
        }
    }
}
