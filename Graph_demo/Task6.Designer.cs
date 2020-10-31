namespace Graph_demo
{
    partial class Task6
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
            this.from_tb = new System.Windows.Forms.TextBox();
            this.to_tb = new System.Windows.Forms.TextBox();
            this.len_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.execute_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // from_tb
            // 
            this.from_tb.Location = new System.Drawing.Point(67, 30);
            this.from_tb.Name = "from_tb";
            this.from_tb.Size = new System.Drawing.Size(174, 20);
            this.from_tb.TabIndex = 0;
            // 
            // to_tb
            // 
            this.to_tb.Location = new System.Drawing.Point(67, 66);
            this.to_tb.Name = "to_tb";
            this.to_tb.Size = new System.Drawing.Size(174, 20);
            this.to_tb.TabIndex = 1;
            // 
            // len_tb
            // 
            this.len_tb.Location = new System.Drawing.Point(67, 102);
            this.len_tb.Name = "len_tb";
            this.len_tb.Size = new System.Drawing.Size(174, 20);
            this.len_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Из:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "В:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Длина:";
            // 
            // execute_b
            // 
            this.execute_b.Location = new System.Drawing.Point(129, 148);
            this.execute_b.Name = "execute_b";
            this.execute_b.Size = new System.Drawing.Size(75, 23);
            this.execute_b.TabIndex = 6;
            this.execute_b.Text = "Поиск";
            this.execute_b.UseVisualStyleBackColor = true;
            this.execute_b.Click += new System.EventHandler(this.execute_b_Click);
            // 
            // Task6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.execute_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.len_tb);
            this.Controls.Add(this.to_tb);
            this.Controls.Add(this.from_tb);
            this.Name = "Task6";
            this.Text = "Форд-Беллман I";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox from_tb;
        private System.Windows.Forms.TextBox to_tb;
        private System.Windows.Forms.TextBox len_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button execute_b;
    }
}