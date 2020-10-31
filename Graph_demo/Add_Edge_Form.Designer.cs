namespace Graph_demo
{
    partial class Add_Edge_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ver_a_lab = new System.Windows.Forms.Label();
            this.ver_b_lab = new System.Windows.Forms.Label();
            this.weight_lab = new System.Windows.Forms.Label();
            this.ver_a_tb = new System.Windows.Forms.TextBox();
            this.ver_b_tb = new System.Windows.Forms.TextBox();
            this.ver_weight_tb = new System.Windows.Forms.TextBox();
            this.add_edge_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ver_a_lab
            // 
            this.ver_a_lab.AutoSize = true;
            this.ver_a_lab.Location = new System.Drawing.Point(13, 24);
            this.ver_a_lab.Name = "ver_a_lab";
            this.ver_a_lab.Size = new System.Drawing.Size(65, 13);
            this.ver_a_lab.TabIndex = 0;
            this.ver_a_lab.Text = "Вершина А:";
            // 
            // ver_b_lab
            // 
            this.ver_b_lab.AutoSize = true;
            this.ver_b_lab.Location = new System.Drawing.Point(13, 50);
            this.ver_b_lab.Name = "ver_b_lab";
            this.ver_b_lab.Size = new System.Drawing.Size(65, 13);
            this.ver_b_lab.TabIndex = 1;
            this.ver_b_lab.Text = "Вершина B:";
            // 
            // weight_lab
            // 
            this.weight_lab.AutoSize = true;
            this.weight_lab.Location = new System.Drawing.Point(47, 81);
            this.weight_lab.Name = "weight_lab";
            this.weight_lab.Size = new System.Drawing.Size(29, 13);
            this.weight_lab.TabIndex = 2;
            this.weight_lab.Text = "Вес:";
            // 
            // ver_a_tb
            // 
            this.ver_a_tb.Location = new System.Drawing.Point(82, 24);
            this.ver_a_tb.Name = "ver_a_tb";
            this.ver_a_tb.Size = new System.Drawing.Size(190, 20);
            this.ver_a_tb.TabIndex = 3;
            // 
            // ver_b_tb
            // 
            this.ver_b_tb.Location = new System.Drawing.Point(82, 51);
            this.ver_b_tb.Name = "ver_b_tb";
            this.ver_b_tb.Size = new System.Drawing.Size(190, 20);
            this.ver_b_tb.TabIndex = 4;
            // 
            // ver_weight_tb
            // 
            this.ver_weight_tb.Location = new System.Drawing.Point(82, 78);
            this.ver_weight_tb.Name = "ver_weight_tb";
            this.ver_weight_tb.Size = new System.Drawing.Size(190, 20);
            this.ver_weight_tb.TabIndex = 5;
            // 
            // add_edge_b
            // 
            this.add_edge_b.Location = new System.Drawing.Point(134, 116);
            this.add_edge_b.Name = "add_edge_b";
            this.add_edge_b.Size = new System.Drawing.Size(120, 23);
            this.add_edge_b.TabIndex = 6;
            this.add_edge_b.Text = "Добавить";
            this.add_edge_b.UseVisualStyleBackColor = true;
            this.add_edge_b.Click += new System.EventHandler(this.add_edge_b_Click);
            // 
            // Add_Edge_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.add_edge_b);
            this.Controls.Add(this.ver_weight_tb);
            this.Controls.Add(this.ver_b_tb);
            this.Controls.Add(this.ver_a_tb);
            this.Controls.Add(this.weight_lab);
            this.Controls.Add(this.ver_b_lab);
            this.Controls.Add(this.ver_a_lab);
            this.Name = "Add_Edge_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить ребро (дугу)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ver_a_lab;
        private System.Windows.Forms.Label ver_b_lab;
        private System.Windows.Forms.Label weight_lab;
        private System.Windows.Forms.TextBox ver_a_tb;
        private System.Windows.Forms.TextBox ver_b_tb;
        private System.Windows.Forms.TextBox ver_weight_tb;
        private System.Windows.Forms.Button add_edge_b;
    }
}