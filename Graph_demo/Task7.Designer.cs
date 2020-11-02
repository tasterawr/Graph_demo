namespace Graph_demo
{
    partial class Task7
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
            this.v1_tb = new System.Windows.Forms.TextBox();
            this.v2_tb = new System.Windows.Forms.TextBox();
            this.v3_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // v1_tb
            // 
            this.v1_tb.Location = new System.Drawing.Point(110, 34);
            this.v1_tb.Name = "v1_tb";
            this.v1_tb.Size = new System.Drawing.Size(129, 20);
            this.v1_tb.TabIndex = 0;
            // 
            // v2_tb
            // 
            this.v2_tb.Location = new System.Drawing.Point(110, 71);
            this.v2_tb.Name = "v2_tb";
            this.v2_tb.Size = new System.Drawing.Size(129, 20);
            this.v2_tb.TabIndex = 1;
            // 
            // v3_tb
            // 
            this.v3_tb.Location = new System.Drawing.Point(110, 106);
            this.v3_tb.Name = "v3_tb";
            this.v3_tb.Size = new System.Drawing.Size(129, 20);
            this.v3_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вершина 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вершина 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "В: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Поиск путей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v3_tb);
            this.Controls.Add(this.v2_tb);
            this.Controls.Add(this.v1_tb);
            this.Name = "Task7";
            this.Text = "Флойд-Уоршелл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox v1_tb;
        private System.Windows.Forms.TextBox v2_tb;
        private System.Windows.Forms.TextBox v3_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}