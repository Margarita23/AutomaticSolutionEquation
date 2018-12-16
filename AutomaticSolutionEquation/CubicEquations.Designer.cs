namespace AutomaticSolutionEquation
{
    partial class CubicEquations
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
            this.f = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = " x^3 +\r\n";
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(299, 44);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(30, 20);
            this.f.TabIndex = 35;
            this.f.Text = "f";
            this.f.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "* x +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 15.75F);
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "x = ";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(136, 91);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 32;
            this.solveButton.Text = "Решить";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(244, 44);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(30, 20);
            this.d.TabIndex = 31;
            this.d.Text = "d";
            this.d.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "=";
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(174, 44);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(30, 20);
            this.c.TabIndex = 29;
            this.c.Text = "c";
            this.c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(92, 44);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(30, 20);
            this.b.TabIndex = 28;
            this.b.Text = "b";
            this.b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "* x^2 +\r\n";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(12, 44);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(30, 20);
            this.a.TabIndex = 38;
            this.a.Text = "a";
            this.a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CubicEquations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 211);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.f);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.d);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label1);
            this.Name = "CubicEquations";
            this.Text = "Cubic Equations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a;
    }
}