namespace ppractic2
{
    partial class addc
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c4 = new System.Windows.Forms.TextBox();
            this.c3 = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.id2 = new System.Windows.Forms.TextBox();
            this.addch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Название книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Отчество автора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Имя автора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Фамилия автора";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID книги";
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(12, 237);
            this.c4.Multiline = true;
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(196, 33);
            this.c4.TabIndex = 16;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(12, 186);
            this.c3.Multiline = true;
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(196, 33);
            this.c3.TabIndex = 15;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(12, 134);
            this.c2.Multiline = true;
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(196, 33);
            this.c2.TabIndex = 14;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(12, 84);
            this.c1.Multiline = true;
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(196, 33);
            this.c1.TabIndex = 13;
            // 
            // id2
            // 
            this.id2.Location = new System.Drawing.Point(12, 28);
            this.id2.Multiline = true;
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(49, 33);
            this.id2.TabIndex = 12;
            // 
            // addch
            // 
            this.addch.Location = new System.Drawing.Point(26, 288);
            this.addch.Name = "addch";
            this.addch.Size = new System.Drawing.Size(168, 35);
            this.addch.TabIndex = 11;
            this.addch.Text = "Добавить";
            this.addch.UseVisualStyleBackColor = true;
            this.addch.Click += new System.EventHandler(this.addch_Click);
            // 
            // addc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.id2);
            this.Controls.Add(this.addch);
            this.Name = "addc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c4;
        private System.Windows.Forms.TextBox c3;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.TextBox id2;
        private System.Windows.Forms.Button addch;
    }
}