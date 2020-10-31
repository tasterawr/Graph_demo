namespace Graph_demo
{
    partial class Task_Form
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
            this.task_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.task_exec_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task_cb
            // 
            this.task_cb.FormattingEnabled = true;
            this.task_cb.Location = new System.Drawing.Point(22, 33);
            this.task_cb.Name = "task_cb";
            this.task_cb.Size = new System.Drawing.Size(121, 21);
            this.task_cb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список заданий";
            // 
            // task_exec_b
            // 
            this.task_exec_b.Location = new System.Drawing.Point(163, 31);
            this.task_exec_b.Name = "task_exec_b";
            this.task_exec_b.Size = new System.Drawing.Size(95, 23);
            this.task_exec_b.TabIndex = 2;
            this.task_exec_b.Text = "Выполнить";
            this.task_exec_b.UseVisualStyleBackColor = true;
            this.task_exec_b.Click += new System.EventHandler(this.task_exec_b_Click);
            // 
            // Task_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.task_exec_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task_cb);
            this.Name = "Task_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор задания";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox task_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button task_exec_b;
    }
}