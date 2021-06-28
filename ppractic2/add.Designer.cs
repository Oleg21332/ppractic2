namespace ppractic2
{
    partial class add
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
            this.addall = new System.Windows.Forms.Button();
            this.id1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.n3 = new System.Windows.Forms.TextBox();
            this.n4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addall
            // 
            this.addall.Location = new System.Drawing.Point(47, 290);
            this.addall.Name = "addall";
            this.addall.Size = new System.Drawing.Size(168, 35);
            this.addall.TabIndex = 0;
            this.addall.Text = "Добавить";
            this.addall.UseVisualStyleBackColor = true;
            this.addall.Click += new System.EventHandler(this.addall_Click);
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(33, 30);
            this.id1.Multiline = true;
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(49, 33);
            this.id1.TabIndex = 1;
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(33, 86);
            this.n1.Multiline = true;
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(196, 33);
            this.n1.TabIndex = 2;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(33, 136);
            this.n2.Multiline = true;
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(196, 33);
            this.n2.TabIndex = 3;
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(33, 188);
            this.n3.Multiline = true;
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(196, 33);
            this.n3.TabIndex = 4;
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(33, 239);
            this.n4.Multiline = true;
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(196, 33);
            this.n4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия автора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя автора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Отчество автора";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Название книги";
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 364);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.addall);
            this.Name = "add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addall;
        private System.Windows.Forms.TextBox id1;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox n3;
        private System.Windows.Forms.TextBox n4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}