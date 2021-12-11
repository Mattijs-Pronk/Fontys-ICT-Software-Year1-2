
namespace Calorie_Calculator
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
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.gbLifestyle = new System.Windows.Forms.GroupBox();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.gbGeslacht.SuspendLayout();
            this.gbLifestyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.Controls.Add(this.rbFemale);
            this.gbGeslacht.Controls.Add(this.rbMale);
            this.gbGeslacht.Location = new System.Drawing.Point(75, 114);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(200, 100);
            this.gbGeslacht.TabIndex = 0;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "Geslacht";
            this.gbGeslacht.Enter += new System.EventHandler(this.gbGeslacht_Enter);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(7, 21);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(7, 63);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // gbLifestyle
            // 
            this.gbLifestyle.Controls.Add(this.rbInactive);
            this.gbLifestyle.Controls.Add(this.rbActive);
            this.gbLifestyle.Location = new System.Drawing.Point(336, 114);
            this.gbLifestyle.Name = "gbLifestyle";
            this.gbLifestyle.Size = new System.Drawing.Size(200, 100);
            this.gbLifestyle.TabIndex = 2;
            this.gbLifestyle.TabStop = false;
            this.gbLifestyle.Text = "Lifestyle";
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(7, 63);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(77, 21);
            this.rbInactive.TabIndex = 1;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            this.rbInactive.CheckedChanged += new System.EventHandler(this.rbInactive_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(7, 21);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(67, 21);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(569, 154);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 22);
            this.tbAge.TabIndex = 3;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Age";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(253, 276);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(102, 65);
            this.btCalculate.TabIndex = 5;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.gbLifestyle);
            this.Controls.Add(this.gbGeslacht);
            this.Name = "Form1";
            this.Text = "Calorie Calculator";
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            this.gbLifestyle.ResumeLayout(false);
            this.gbLifestyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox gbLifestyle;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalculate;
    }
}

