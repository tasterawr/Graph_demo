namespace Graph_demo
{
    partial class Task4
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
            this.edges_lb = new System.Windows.Forms.ListBox();
            this.del_edges_lb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cntr_lab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.from_tb = new System.Windows.Forms.TextBox();
            this.to_tb = new System.Windows.Forms.TextBox();
            this.paths_lb = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paths_lab = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edges_lb
            // 
            this.edges_lb.FormattingEnabled = true;
            this.edges_lb.Location = new System.Drawing.Point(18, 37);
            this.edges_lb.Name = "edges_lb";
            this.edges_lb.Size = new System.Drawing.Size(153, 108);
            this.edges_lb.TabIndex = 0;
            this.edges_lb.SelectedIndexChanged += new System.EventHandler(this.edges_lb_SelectedIndexChanged);
            // 
            // del_edges_lb
            // 
            this.del_edges_lb.FormattingEnabled = true;
            this.del_edges_lb.Location = new System.Drawing.Point(275, 37);
            this.del_edges_lb.Name = "del_edges_lb";
            this.del_edges_lb.Size = new System.Drawing.Size(153, 108);
            this.del_edges_lb.TabIndex = 1;
            this.del_edges_lb.SelectedIndexChanged += new System.EventHandler(this.del_edges_lb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список ребер (дуг):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список ребер (дуг) для исключения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "k =";
            // 
            // cntr_lab
            // 
            this.cntr_lab.AutoSize = true;
            this.cntr_lab.Location = new System.Drawing.Point(395, 148);
            this.cntr_lab.Name = "cntr_lab";
            this.cntr_lab.Size = new System.Drawing.Size(13, 13);
            this.cntr_lab.TabIndex = 5;
            this.cntr_lab.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Запустить проверку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Из:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "В:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // from_tb
            // 
            this.from_tb.Location = new System.Drawing.Point(177, 156);
            this.from_tb.Name = "from_tb";
            this.from_tb.Size = new System.Drawing.Size(100, 20);
            this.from_tb.TabIndex = 9;
            // 
            // to_tb
            // 
            this.to_tb.Location = new System.Drawing.Point(177, 179);
            this.to_tb.Name = "to_tb";
            this.to_tb.Size = new System.Drawing.Size(100, 20);
            this.to_tb.TabIndex = 10;
            // 
            // paths_lb
            // 
            this.paths_lb.FormattingEnabled = true;
            this.paths_lb.Location = new System.Drawing.Point(29, 287);
            this.paths_lb.Name = "paths_lb";
            this.paths_lb.Size = new System.Drawing.Size(411, 82);
            this.paths_lb.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edges_lb);
            this.groupBox1.Controls.Add(this.del_edges_lb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.to_tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.from_tb);
            this.groupBox1.Controls.Add(this.cntr_lab);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 241);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // paths_lab
            // 
            this.paths_lab.AutoSize = true;
            this.paths_lab.Location = new System.Drawing.Point(29, 269);
            this.paths_lab.Name = "paths_lab";
            this.paths_lab.Size = new System.Drawing.Size(79, 13);
            this.paths_lab.TabIndex = 13;
            this.paths_lab.Text = "Пути из ... в ...";
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.paths_lab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paths_lb);
            this.Name = "Task4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пункт II, з. 10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox edges_lb;
        private System.Windows.Forms.ListBox del_edges_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cntr_lab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox from_tb;
        private System.Windows.Forms.TextBox to_tb;
        private System.Windows.Forms.ListBox paths_lb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label paths_lab;
    }
}