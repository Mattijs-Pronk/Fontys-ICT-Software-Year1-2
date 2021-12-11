
namespace Worpengenerator
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
            this.gbsettings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDice = new System.Windows.Forms.Button();
            this.nudEyes = new System.Windows.Forms.NumericUpDown();
            this.nudRolls = new System.Windows.Forms.NumericUpDown();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSolution = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSolution = new System.Windows.Forms.ListBox();
            this.gbsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRolls)).BeginInit();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbsettings
            // 
            this.gbsettings.Controls.Add(this.label3);
            this.gbsettings.Controls.Add(this.label2);
            this.gbsettings.Controls.Add(this.btDice);
            this.gbsettings.Controls.Add(this.nudEyes);
            this.gbsettings.Controls.Add(this.nudRolls);
            this.gbsettings.Location = new System.Drawing.Point(36, 54);
            this.gbsettings.Name = "gbsettings";
            this.gbsettings.Size = new System.Drawing.Size(283, 187);
            this.gbsettings.TabIndex = 0;
            this.gbsettings.TabStop = false;
            this.gbsettings.Text = "Settings";
            this.gbsettings.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount of eyes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount of rolls";
            // 
            // btDice
            // 
            this.btDice.Location = new System.Drawing.Point(120, 133);
            this.btDice.Name = "btDice";
            this.btDice.Size = new System.Drawing.Size(126, 35);
            this.btDice.TabIndex = 3;
            this.btDice.Text = "Roll Dice";
            this.btDice.UseVisualStyleBackColor = true;
            this.btDice.Click += new System.EventHandler(this.btDice_Click);
            // 
            // nudEyes
            // 
            this.nudEyes.Location = new System.Drawing.Point(126, 84);
            this.nudEyes.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudEyes.Name = "nudEyes";
            this.nudEyes.Size = new System.Drawing.Size(120, 22);
            this.nudEyes.TabIndex = 2;
            this.nudEyes.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudEyes.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nudRolls
            // 
            this.nudRolls.Location = new System.Drawing.Point(126, 36);
            this.nudRolls.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRolls.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRolls.Name = "nudRolls";
            this.nudRolls.Size = new System.Drawing.Size(120, 22);
            this.nudRolls.TabIndex = 1;
            this.nudRolls.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRolls.ValueChanged += new System.EventHandler(this.nudRolls_ValueChanged);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.label4);
            this.gbResult.Controls.Add(this.tbSolution);
            this.gbResult.Controls.Add(this.label1);
            this.gbResult.Controls.Add(this.lbSolution);
            this.gbResult.Location = new System.Drawing.Point(484, 54);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(304, 320);
            this.gbResult.TabIndex = 1;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            this.gbResult.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rolls";
            // 
            // tbSolution
            // 
            this.tbSolution.Location = new System.Drawing.Point(147, 286);
            this.tbSolution.Name = "tbSolution";
            this.tbSolution.Size = new System.Drawing.Size(100, 22);
            this.tbSolution.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total eyes:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSolution
            // 
            this.lbSolution.AccessibleName = "lbSolution";
            this.lbSolution.FormattingEnabled = true;
            this.lbSolution.ItemHeight = 16;
            this.lbSolution.Location = new System.Drawing.Point(25, 54);
            this.lbSolution.Name = "lbSolution";
            this.lbSolution.Size = new System.Drawing.Size(260, 196);
            this.lbSolution.TabIndex = 0;
            this.lbSolution.SelectedIndexChanged += new System.EventHandler(this.lbSolution_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbsettings);
            this.Name = "Form1";
            this.Text = "Roll the Dice";
            this.gbsettings.ResumeLayout(false);
            this.gbsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRolls)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbsettings;
        private System.Windows.Forms.NumericUpDown nudEyes;
        private System.Windows.Forms.NumericUpDown nudRolls;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.ListBox lbSolution;
        private System.Windows.Forms.Button btDice;
        private System.Windows.Forms.TextBox tbSolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

