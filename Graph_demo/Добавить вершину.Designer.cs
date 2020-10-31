namespace Graph_demo
{
    partial class AddVer_Form
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
            this.addver_gb = new System.Windows.Forms.GroupBox();
            this.addver_tb = new System.Windows.Forms.TextBox();
            this.addver_b = new System.Windows.Forms.Button();
            this.addver_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // addver_gb
            // 
            this.addver_gb.Controls.Add(this.addver_tb);
            this.addver_gb.Location = new System.Drawing.Point(13, 13);
            this.addver_gb.Name = "addver_gb";
            this.addver_gb.Size = new System.Drawing.Size(259, 42);
            this.addver_gb.TabIndex = 0;
            this.addver_gb.TabStop = false;
            this.addver_gb.Text = "Введите значение";
            // 
            // addver_tb
            // 
            this.addver_tb.Location = new System.Drawing.Point(6, 16);
            this.addver_tb.Name = "addver_tb";
            this.addver_tb.Size = new System.Drawing.Size(247, 20);
            this.addver_tb.TabIndex = 0;
            // 
            // addver_b
            // 
            this.addver_b.Location = new System.Drawing.Point(76, 76);
            this.addver_b.Name = "addver_b";
            this.addver_b.Size = new System.Drawing.Size(133, 23);
            this.addver_b.TabIndex = 1;
            this.addver_b.Text = "Добавить вершину";
            this.addver_b.UseVisualStyleBackColor = true;
            this.addver_b.Click += new System.EventHandler(this.addver_b_Click);
            // 
            // AddVer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.addver_b);
            this.Controls.Add(this.addver_gb);
            this.Name = "AddVer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить вершину";
            this.Load += new System.EventHandler(this.Добавить_вершину_Load);
            this.addver_gb.ResumeLayout(false);
            this.addver_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addver_gb;
        private System.Windows.Forms.TextBox addver_tb;
        private System.Windows.Forms.Button addver_b;
    }
}