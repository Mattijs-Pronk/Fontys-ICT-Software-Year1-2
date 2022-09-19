
namespace Computer_Rekenen
{
    partial class Form1
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
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btTimes = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btDevide = new System.Windows.Forms.Button();
            this.tbSolution = new System.Windows.Forms.TextBox();
            this.Solution = new System.Windows.Forms.Label();
            this.btPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(206, 66);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(100, 22);
            this.tbNumber1.TabIndex = 0;
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(393, 66);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(100, 22);
            this.tbNumber2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Getal1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Getal2";
            // 
            // btTimes
            // 
            this.btTimes.Location = new System.Drawing.Point(541, 169);
            this.btTimes.Name = "btTimes";
            this.btTimes.Size = new System.Drawing.Size(58, 50);
            this.btTimes.TabIndex = 4;
            this.btTimes.Text = "x";
            this.btTimes.UseVisualStyleBackColor = true;
            this.btTimes.Click += new System.EventHandler(this.btTimes_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(541, 111);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(58, 52);
            this.btMinus.TabIndex = 5;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btDevide
            // 
            this.btDevide.Location = new System.Drawing.Point(541, 225);
            this.btDevide.Name = "btDevide";
            this.btDevide.Size = new System.Drawing.Size(58, 56);
            this.btDevide.TabIndex = 6;
            this.btDevide.Text = "/";
            this.btDevide.UseVisualStyleBackColor = true;
            this.btDevide.Click += new System.EventHandler(this.btDevide_Click);
            // 
            // tbSolution
            // 
            this.tbSolution.Location = new System.Drawing.Point(297, 151);
            this.tbSolution.Name = "tbSolution";
            this.tbSolution.Size = new System.Drawing.Size(100, 22);
            this.tbSolution.TabIndex = 7;
            this.tbSolution.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Solution
            // 
            this.Solution.AutoSize = true;
            this.Solution.Location = new System.Drawing.Point(315, 131);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(62, 17);
            this.Solution.TabIndex = 9;
            this.Solution.Text = "Uitkomst";
            this.Solution.Click += new System.EventHandler(this.label3_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(541, 49);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(58, 56);
            this.btPlus.TabIndex = 10;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.tbSolution);
            this.Controls.Add(this.btDevide);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btTimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTimes;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btDevide;
        private System.Windows.Forms.TextBox tbSolution;
        private System.Windows.Forms.Label Solution;
        private System.Windows.Forms.Button btPlus;
    }
}

