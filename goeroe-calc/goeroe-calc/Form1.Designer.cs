
namespace goeroe_calc
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
            this.tbgetal1 = new System.Windows.Forms.TextBox();
            this.tbuitkomst = new System.Windows.Forms.TextBox();
            this.tbgetal2 = new System.Windows.Forms.TextBox();
            this.btplus = new System.Windows.Forms.Button();
            this.btkeer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbgetal1
            // 
            this.tbgetal1.Location = new System.Drawing.Point(198, 133);
            this.tbgetal1.Name = "tbgetal1";
            this.tbgetal1.Size = new System.Drawing.Size(100, 22);
            this.tbgetal1.TabIndex = 0;
            this.tbgetal1.TextChanged += new System.EventHandler(this.getal1_TextChanged);
            // 
            // tbuitkomst
            // 
            this.tbuitkomst.Location = new System.Drawing.Point(263, 238);
            this.tbuitkomst.Name = "tbuitkomst";
            this.tbuitkomst.ReadOnly = true;
            this.tbuitkomst.Size = new System.Drawing.Size(100, 22);
            this.tbuitkomst.TabIndex = 1;
            // 
            // tbgetal2
            // 
            this.tbgetal2.Location = new System.Drawing.Point(336, 133);
            this.tbgetal2.Name = "tbgetal2";
            this.tbgetal2.Size = new System.Drawing.Size(100, 22);
            this.tbgetal2.TabIndex = 2;
            this.tbgetal2.TextChanged += new System.EventHandler(this.tbgetal2_TextChanged);
            // 
            // btplus
            // 
            this.btplus.Location = new System.Drawing.Point(484, 122);
            this.btplus.Name = "btplus";
            this.btplus.Size = new System.Drawing.Size(54, 44);
            this.btplus.TabIndex = 3;
            this.btplus.Text = "+";
            this.btplus.UseVisualStyleBackColor = true;
            this.btplus.Click += new System.EventHandler(this.btplus_Click);
            // 
            // btkeer
            // 
            this.btkeer.Location = new System.Drawing.Point(562, 122);
            this.btkeer.Name = "btkeer";
            this.btkeer.Size = new System.Drawing.Size(54, 44);
            this.btkeer.TabIndex = 4;
            this.btkeer.Text = "X";
            this.btkeer.UseVisualStyleBackColor = true;
            this.btkeer.Click += new System.EventHandler(this.btkeer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "getal1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "getal2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "uitkomst";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btkeer);
            this.Controls.Add(this.btplus);
            this.Controls.Add(this.tbgetal2);
            this.Controls.Add(this.tbuitkomst);
            this.Controls.Add(this.tbgetal1);
            this.Name = "Form1";
            this.Text = "Goeroe calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbgetal1;
        private System.Windows.Forms.TextBox tbuitkomst;
        private System.Windows.Forms.TextBox tbgetal2;
        private System.Windows.Forms.Button btplus;
        private System.Windows.Forms.Button btkeer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

