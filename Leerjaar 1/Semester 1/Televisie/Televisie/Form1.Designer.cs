
namespace Televisie
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
            this.rbOn = new System.Windows.Forms.RadioButton();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSolution = new System.Windows.Forms.Label();
            this.lbPrograms = new System.Windows.Forms.ListBox();
            this.lbCurrentprogram = new System.Windows.Forms.Label();
            this.tbProgram = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbOn
            // 
            this.rbOn.AccessibleName = "rbOn";
            this.rbOn.AutoSize = true;
            this.rbOn.Location = new System.Drawing.Point(15, 71);
            this.rbOn.Name = "rbOn";
            this.rbOn.Size = new System.Drawing.Size(48, 21);
            this.rbOn.TabIndex = 0;
            this.rbOn.TabStop = true;
            this.rbOn.Text = "On";
            this.rbOn.UseVisualStyleBackColor = true;
            this.rbOn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbOff
            // 
            this.rbOff.AccessibleName = "rbOff";
            this.rbOff.AutoSize = true;
            this.rbOff.Location = new System.Drawing.Point(12, 98);
            this.rbOff.Name = "rbOff";
            this.rbOff.Size = new System.Drawing.Size(48, 21);
            this.rbOff.TabIndex = 1;
            this.rbOff.TabStop = true;
            this.rbOff.Text = "Off";
            this.rbOff.UseVisualStyleBackColor = true;
            this.rbOff.CheckedChanged += new System.EventHandler(this.rbOff_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Televisie.Properties.Resources._35770;
            this.pictureBox1.Location = new System.Drawing.Point(108, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "lbSolution";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "TV status:";
            // 
            // lbSolution
            // 
            this.lbSolution.AutoSize = true;
            this.lbSolution.Location = new System.Drawing.Point(219, 166);
            this.lbSolution.Name = "lbSolution";
            this.lbSolution.Size = new System.Drawing.Size(46, 17);
            this.lbSolution.TabIndex = 5;
            this.lbSolution.Text = "label3";
            // 
            // lbPrograms
            // 
            this.lbPrograms.AccessibleName = "lbPrograms";
            this.lbPrograms.FormattingEnabled = true;
            this.lbPrograms.ItemHeight = 16;
            this.lbPrograms.Location = new System.Drawing.Point(545, 51);
            this.lbPrograms.Name = "lbPrograms";
            this.lbPrograms.Size = new System.Drawing.Size(170, 276);
            this.lbPrograms.TabIndex = 6;
            this.lbPrograms.SelectedIndexChanged += new System.EventHandler(this.lbPrograms_SelectedIndexChanged);
            // 
            // lbCurrentprogram
            // 
            this.lbCurrentprogram.AutoSize = true;
            this.lbCurrentprogram.Location = new System.Drawing.Point(219, 203);
            this.lbCurrentprogram.Name = "lbCurrentprogram";
            this.lbCurrentprogram.Size = new System.Drawing.Size(46, 17);
            this.lbCurrentprogram.TabIndex = 7;
            this.lbCurrentprogram.Text = "label3";
            // 
            // tbProgram
            // 
            this.tbProgram.Location = new System.Drawing.Point(545, 353);
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.Size = new System.Drawing.Size(71, 22);
            this.tbProgram.TabIndex = 8;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(635, 353);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(80, 23);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbProgram);
            this.Controls.Add(this.lbCurrentprogram);
            this.Controls.Add(this.lbPrograms);
            this.Controls.Add(this.lbSolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbOff);
            this.Controls.Add(this.rbOn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOn;
        private System.Windows.Forms.RadioButton rbOff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSolution;
        private System.Windows.Forms.ListBox lbPrograms;
        private System.Windows.Forms.Label lbCurrentprogram;
        private System.Windows.Forms.TextBox tbProgram;
        private System.Windows.Forms.Button btAdd;
    }
}

