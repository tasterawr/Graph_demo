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
    public partial class Task_Form : Form
    {
        public Form1 parent;

        public Task_Form(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
            task_cb.Items.Add("Задание 1 (la 1)");
            task_cb.Items.Add("Задание 2 (la 16)");
            task_cb.Items.Add("Задание 3 (lb 11)");
            task_cb.Items.Add("Задание 10, п. II");
            task_cb.Items.Add("Задание 32, п. II");
            task_cb.Items.Add("Задание Крускал");
            task_cb.Items.Add("Задание Дийкстра");
            task_cb.Items.Add("Задание Форд-Беллман I");
            task_cb.Text = "Задание 1 (la 1)";
        }

        private void task_exec_b_Click(object sender, EventArgs e)
        {
            if (task_cb.SelectedItem.ToString() == "Задание 1 (la 1)")
            {
                if (!parent.control.Graph_.Orient)
                {
                    MessageBox.Show("Граф не ориентированный.");
                    return;
                }
                Task1 form = new Task1(parent);
                form.Show();
                this.Close();
                return;
            }
            else if (task_cb.SelectedItem.ToString() == "Задание 2 (la 16)")
            {
                if (parent.control.Graph_.Orient)
                {
                    MessageBox.Show("Граф ориентированный.");
                    return;
                }
                Task2 form = new Task2(parent);
                form.Show();
                this.Close();
                return;
            }
            else if (task_cb.SelectedItem.ToString() == "Задание 3 (lb 11)")
            {
                if (!parent.control.Graph_.Orient)
                {
                    MessageBox.Show("Граф не ориентированный.");
                    return;
                }
                Form_graph_name form = new Form_graph_name(parent, 1);
                form.Show();
                this.Close();
                return;
            }
            else if (task_cb.SelectedItem.ToString() == "Задание 10, п. II")
            {
                Task4 form = new Task4(parent);
                form.Show();
                this.Close();
                return;
            }
            else if (task_cb.SelectedItem.ToString() == "Задание 32, п. II")
            {
                if (!parent.control.Graph_.Orient)
                {
                    MessageBox.Show("Граф не ориентированный.");
                    return;
                }
                Task5 form = new Task5(parent);
                form.Show();
                this.Close();
                return;
            }

            else if (task_cb.SelectedItem.ToString() == "Задание Крускал")
            {
                if (!parent.control.Graph_.Weighted)
                {
                    MessageBox.Show("Граф не взвешенный.");
                    return;
                }
                parent.Kruskal();
                this.Close();
                return;
            }

            else if(task_cb.SelectedItem.ToString() == "Задание Дийкстра")
            {
                if (!parent.control.Graph_.Weighted)
                {
                    MessageBox.Show("Граф не взвешенный.");
                    return;
                }
                parent.GetRadius();
                this.Close();
                return;
            }

            else if (task_cb.SelectedItem.ToString() == "Задание Форд-Беллман I")
            {
                if (!parent.control.Graph_.Weighted)
                {
                    MessageBox.Show("Граф не взвешенный.");
                    return;
                }
                Task6 form = new Task6(parent);
                form.Show();
                this.Close();
                return;
            }
        }
    }
}
