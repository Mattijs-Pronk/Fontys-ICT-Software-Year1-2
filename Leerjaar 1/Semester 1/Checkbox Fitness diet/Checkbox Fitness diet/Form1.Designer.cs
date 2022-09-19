
namespace Checkbox_Fitness_diet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbMultifruit = new System.Windows.Forms.CheckBox();
            this.cbShake = new System.Windows.Forms.CheckBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbSolution = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.cbMultifruit);
            this.groupBox1.Controls.Add(this.cbShake);
            this.groupBox1.Location = new System.Drawing.Point(38, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Breakfast";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 84);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 21);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbMultifruit
            // 
            this.cbMultifruit.AutoSize = true;
            this.cbMultifruit.Location = new System.Drawing.Point(6, 57);
            this.cbMultifruit.Name = "cbMultifruit";
            this.cbMultifruit.Size = new System.Drawing.Size(83, 21);
            this.cbMultifruit.TabIndex = 2;
            this.cbMultifruit.Text = "Multifruit";
            this.cbMultifruit.UseVisualStyleBackColor = true;
            // 
            // cbShake
            // 
            this.cbShake.AutoSize = true;
            this.cbShake.Location = new System.Drawing.Point(6, 30);
            this.cbShake.Name = "cbShake";
            this.cbShake.Size = new System.Drawing.Size(70, 21);
            this.cbShake.TabIndex = 1;
            this.cbShake.Text = "Shake";
            this.cbShake.UseVisualStyleBackColor = true;
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(424, 183);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(75, 23);
            this.btCalculate.TabIndex = 1;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lbSolution
            // 
            this.lbSolution.FormattingEnabled = true;
            this.lbSolution.ItemHeight = 16;
            this.lbSolution.Location = new System.Drawing.Point(576, 33);
            this.lbSolution.Name = "lbSolution";
            this.lbSolution.Size = new System.Drawing.Size(198, 356);
            this.lbSolution.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSolution);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cbMultifruit;
        private System.Windows.Forms.CheckBox cbShake;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.ListBox lbSolution;
    }
}

