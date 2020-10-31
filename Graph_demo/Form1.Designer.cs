namespace Graph_demo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_create_graph = new System.Windows.Forms.GroupBox();
            this.savetofile_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.create_gb = new System.Windows.Forms.GroupBox();
            this.create_b = new System.Windows.Forms.Button();
            this.orient_cb = new System.Windows.Forms.CheckBox();
            this.weight_cb = new System.Windows.Forms.CheckBox();
            this.openfile_b = new System.Windows.Forms.Button();
            this.vertices_list = new System.Windows.Forms.ListBox();
            this.vertices_gb = new System.Windows.Forms.GroupBox();
            this.deletever_b = new System.Windows.Forms.Button();
            this.addver_b = new System.Windows.Forms.Button();
            this.edges_gb = new System.Windows.Forms.GroupBox();
            this.deleteedge_b = new System.Windows.Forms.Button();
            this.addedge_b = new System.Windows.Forms.Button();
            this.edges_list = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.graph_lb = new System.Windows.Forms.ListBox();
            this.copy_b = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tasks_b = new System.Windows.Forms.Button();
            this.adj_gb = new System.Windows.Forms.GroupBox();
            this.adj_lb = new System.Windows.Forms.ListBox();
            this.gb_create_graph.SuspendLayout();
            this.create_gb.SuspendLayout();
            this.vertices_gb.SuspendLayout();
            this.edges_gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.adj_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_create_graph
            // 
            this.gb_create_graph.Controls.Add(this.savetofile_b);
            this.gb_create_graph.Controls.Add(this.label1);
            this.gb_create_graph.Controls.Add(this.create_gb);
            this.gb_create_graph.Controls.Add(this.openfile_b);
            this.gb_create_graph.Location = new System.Drawing.Point(21, 26);
            this.gb_create_graph.Name = "gb_create_graph";
            this.gb_create_graph.Size = new System.Drawing.Size(332, 151);
            this.gb_create_graph.TabIndex = 1;
            this.gb_create_graph.TabStop = false;
            this.gb_create_graph.Text = "Управление графом";
            // 
            // savetofile_b
            // 
            this.savetofile_b.Location = new System.Drawing.Point(191, 29);
            this.savetofile_b.Name = "savetofile_b";
            this.savetofile_b.Size = new System.Drawing.Size(119, 23);
            this.savetofile_b.TabIndex = 3;
            this.savetofile_b.Text = "Сохранить в файл";
            this.savetofile_b.UseVisualStyleBackColor = true;
            this.savetofile_b.Click += new System.EventHandler(this.savetofile_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "или";
            // 
            // create_gb
            // 
            this.create_gb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.create_gb.Controls.Add(this.create_b);
            this.create_gb.Controls.Add(this.orient_cb);
            this.create_gb.Controls.Add(this.weight_cb);
            this.create_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_gb.Location = new System.Drawing.Point(6, 78);
            this.create_gb.Name = "create_gb";
            this.create_gb.Size = new System.Drawing.Size(320, 67);
            this.create_gb.TabIndex = 1;
            this.create_gb.TabStop = false;
            this.create_gb.Text = "Создать новый граф";
            // 
            // create_b
            // 
            this.create_b.Location = new System.Drawing.Point(18, 28);
            this.create_b.Name = "create_b";
            this.create_b.Size = new System.Drawing.Size(89, 23);
            this.create_b.TabIndex = 2;
            this.create_b.Text = "Создать";
            this.create_b.UseVisualStyleBackColor = true;
            this.create_b.Click += new System.EventHandler(this.create_b_Click);
            // 
            // orient_cb
            // 
            this.orient_cb.AutoSize = true;
            this.orient_cb.Location = new System.Drawing.Point(185, 19);
            this.orient_cb.Name = "orient_cb";
            this.orient_cb.Size = new System.Drawing.Size(119, 17);
            this.orient_cb.TabIndex = 0;
            this.orient_cb.Text = "Ориентированный";
            this.orient_cb.UseVisualStyleBackColor = true;
            // 
            // weight_cb
            // 
            this.weight_cb.AutoSize = true;
            this.weight_cb.Location = new System.Drawing.Point(185, 44);
            this.weight_cb.Name = "weight_cb";
            this.weight_cb.Size = new System.Drawing.Size(91, 17);
            this.weight_cb.TabIndex = 1;
            this.weight_cb.Text = "Взвешенный";
            this.weight_cb.UseVisualStyleBackColor = true;
            // 
            // openfile_b
            // 
            this.openfile_b.Location = new System.Drawing.Point(6, 29);
            this.openfile_b.Name = "openfile_b";
            this.openfile_b.Size = new System.Drawing.Size(107, 23);
            this.openfile_b.TabIndex = 0;
            this.openfile_b.Text = "Открыть...";
            this.openfile_b.UseVisualStyleBackColor = true;
            this.openfile_b.Click += new System.EventHandler(this.openfile_b_Click);
            // 
            // vertices_list
            // 
            this.vertices_list.FormattingEnabled = true;
            this.vertices_list.Location = new System.Drawing.Point(6, 19);
            this.vertices_list.Name = "vertices_list";
            this.vertices_list.Size = new System.Drawing.Size(320, 69);
            this.vertices_list.TabIndex = 2;
            // 
            // vertices_gb
            // 
            this.vertices_gb.Controls.Add(this.deletever_b);
            this.vertices_gb.Controls.Add(this.addver_b);
            this.vertices_gb.Controls.Add(this.vertices_list);
            this.vertices_gb.Location = new System.Drawing.Point(21, 183);
            this.vertices_gb.Name = "vertices_gb";
            this.vertices_gb.Size = new System.Drawing.Size(414, 100);
            this.vertices_gb.TabIndex = 3;
            this.vertices_gb.TabStop = false;
            this.vertices_gb.Text = "Список вершин";
            // 
            // deletever_b
            // 
            this.deletever_b.Location = new System.Drawing.Point(333, 49);
            this.deletever_b.Name = "deletever_b";
            this.deletever_b.Size = new System.Drawing.Size(75, 23);
            this.deletever_b.TabIndex = 4;
            this.deletever_b.Text = "Удалить";
            this.deletever_b.UseVisualStyleBackColor = true;
            this.deletever_b.Click += new System.EventHandler(this.deletever_b_Click);
            // 
            // addver_b
            // 
            this.addver_b.Location = new System.Drawing.Point(333, 20);
            this.addver_b.Name = "addver_b";
            this.addver_b.Size = new System.Drawing.Size(75, 23);
            this.addver_b.TabIndex = 3;
            this.addver_b.Text = "Добавить";
            this.addver_b.UseVisualStyleBackColor = true;
            this.addver_b.Click += new System.EventHandler(this.addver_b_Click);
            // 
            // edges_gb
            // 
            this.edges_gb.Controls.Add(this.deleteedge_b);
            this.edges_gb.Controls.Add(this.addedge_b);
            this.edges_gb.Controls.Add(this.edges_list);
            this.edges_gb.Location = new System.Drawing.Point(21, 289);
            this.edges_gb.Name = "edges_gb";
            this.edges_gb.Size = new System.Drawing.Size(414, 100);
            this.edges_gb.TabIndex = 4;
            this.edges_gb.TabStop = false;
            this.edges_gb.Text = "Список ребер (дуг)";
            // 
            // deleteedge_b
            // 
            this.deleteedge_b.Location = new System.Drawing.Point(333, 49);
            this.deleteedge_b.Name = "deleteedge_b";
            this.deleteedge_b.Size = new System.Drawing.Size(75, 23);
            this.deleteedge_b.TabIndex = 2;
            this.deleteedge_b.Text = "Удалить";
            this.deleteedge_b.UseVisualStyleBackColor = true;
            this.deleteedge_b.Click += new System.EventHandler(this.deleteedge_b_Click);
            // 
            // addedge_b
            // 
            this.addedge_b.Location = new System.Drawing.Point(333, 19);
            this.addedge_b.Name = "addedge_b";
            this.addedge_b.Size = new System.Drawing.Size(75, 23);
            this.addedge_b.TabIndex = 1;
            this.addedge_b.Text = "Добавить";
            this.addedge_b.UseVisualStyleBackColor = true;
            this.addedge_b.Click += new System.EventHandler(this.addedge_b_Click);
            // 
            // edges_list
            // 
            this.edges_list.FormattingEnabled = true;
            this.edges_list.Location = new System.Drawing.Point(7, 19);
            this.edges_list.Name = "edges_list";
            this.edges_list.Size = new System.Drawing.Size(319, 69);
            this.edges_list.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.graph_lb);
            this.groupBox1.Controls.Add(this.copy_b);
            this.groupBox1.Location = new System.Drawing.Point(567, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 523);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список графов";
            // 
            // graph_lb
            // 
            this.graph_lb.FormattingEnabled = true;
            this.graph_lb.Location = new System.Drawing.Point(7, 20);
            this.graph_lb.Name = "graph_lb";
            this.graph_lb.Size = new System.Drawing.Size(208, 420);
            this.graph_lb.TabIndex = 0;
            this.graph_lb.SelectedIndexChanged += new System.EventHandler(this.graph_lb_SelectedIndexChanged);
            // 
            // copy_b
            // 
            this.copy_b.Location = new System.Drawing.Point(55, 456);
            this.copy_b.Name = "copy_b";
            this.copy_b.Size = new System.Drawing.Size(110, 44);
            this.copy_b.TabIndex = 6;
            this.copy_b.Text = "Копировать выбранный граф";
            this.copy_b.UseVisualStyleBackColor = true;
            this.copy_b.Click += new System.EventHandler(this.copy_b_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tasks_b);
            this.groupBox2.Location = new System.Drawing.Point(21, 506);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 43);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выполнение заданий";
            // 
            // tasks_b
            // 
            this.tasks_b.Location = new System.Drawing.Point(141, 14);
            this.tasks_b.Name = "tasks_b";
            this.tasks_b.Size = new System.Drawing.Size(136, 23);
            this.tasks_b.TabIndex = 0;
            this.tasks_b.Text = "Выбор задания...";
            this.tasks_b.UseVisualStyleBackColor = true;
            this.tasks_b.Click += new System.EventHandler(this.tasks_b_Click);
            // 
            // adj_gb
            // 
            this.adj_gb.Controls.Add(this.adj_lb);
            this.adj_gb.Location = new System.Drawing.Point(21, 395);
            this.adj_gb.Name = "adj_gb";
            this.adj_gb.Size = new System.Drawing.Size(414, 100);
            this.adj_gb.TabIndex = 8;
            this.adj_gb.TabStop = false;
            this.adj_gb.Text = "Список смежности";
            // 
            // adj_lb
            // 
            this.adj_lb.FormattingEnabled = true;
            this.adj_lb.Location = new System.Drawing.Point(6, 14);
            this.adj_lb.Name = "adj_lb";
            this.adj_lb.Size = new System.Drawing.Size(402, 69);
            this.adj_lb.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.adj_gb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.edges_gb);
            this.Controls.Add(this.vertices_gb);
            this.Controls.Add(this.gb_create_graph);
            this.Name = "Form1";
            this.Text = "Граф";
            this.gb_create_graph.ResumeLayout(false);
            this.gb_create_graph.PerformLayout();
            this.create_gb.ResumeLayout(false);
            this.create_gb.PerformLayout();
            this.vertices_gb.ResumeLayout(false);
            this.edges_gb.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.adj_gb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_create_graph;
        private System.Windows.Forms.Button openfile_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox create_gb;
        private System.Windows.Forms.Button create_b;
        private System.Windows.Forms.CheckBox orient_cb;
        private System.Windows.Forms.CheckBox weight_cb;
        private System.Windows.Forms.Button savetofile_b;
        private System.Windows.Forms.ListBox vertices_list;
        private System.Windows.Forms.GroupBox vertices_gb;
        private System.Windows.Forms.Button deletever_b;
        private System.Windows.Forms.Button addver_b;
        private System.Windows.Forms.GroupBox edges_gb;
        private System.Windows.Forms.Button deleteedge_b;
        private System.Windows.Forms.Button addedge_b;
        private System.Windows.Forms.ListBox edges_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox graph_lb;
        private System.Windows.Forms.Button copy_b;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button tasks_b;
        private System.Windows.Forms.GroupBox adj_gb;
        private System.Windows.Forms.ListBox adj_lb;
    }
}

