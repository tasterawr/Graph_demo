namespace Graph_demo
{
    partial class Task1
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
            this.vertex_inp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outgoing_lb = new System.Windows.Forms.ListBox();
            this.outgoing_b = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vertex_inp
            // 
            this.vertex_inp.Location = new System.Drawing.Point(20, 51);
            this.vertex_inp.Name = "vertex_inp";
            this.vertex_inp.Size = new System.Drawing.Size(128, 20);
            this.vertex_inp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите вершину:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outgoing_lb);
            this.groupBox1.Location = new System.Drawing.Point(13, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вершины выходящие из данной:";
            // 
            // outgoing_lb
            // 
            this.outgoing_lb.FormattingEnabled = true;
            this.outgoing_lb.Location = new System.Drawing.Point(7, 20);
            this.outgoing_lb.Name = "outgoing_lb";
            this.outgoing_lb.Size = new System.Drawing.Size(346, 82);
            this.outgoing_lb.TabIndex = 0;
            // 
            // outgoing_b
            // 
            this.outgoing_b.Location = new System.Drawing.Point(166, 51);
            this.outgoing_b.Name = "outgoing_b";
            this.outgoing_b.Size = new System.Drawing.Size(84, 20);
            this.outgoing_b.TabIndex = 3;
            this.outgoing_b.Text = "Поиск";
            this.outgoing_b.UseVisualStyleBackColor = true;
            this.outgoing_b.Click += new System.EventHandler(this.outgoing_b_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.outgoing_b);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vertex_inp);
            this.Name = "Task1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание la 1";
            this.Load += new System.EventHandler(this.Task1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vertex_inp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox outgoing_lb;
        private System.Windows.Forms.Button outgoing_b;
    }
}