
namespace Challange_BattleSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btAttackKnight = new System.Windows.Forms.Button();
            this.btAttackRanger = new System.Windows.Forms.Button();
            this.lbHpKnight = new System.Windows.Forms.Label();
            this.lbHpRanger = new System.Windows.Forms.Label();
            this.pbKnight = new System.Windows.Forms.ProgressBar();
            this.pbRanger = new System.Windows.Forms.ProgressBar();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(535, 32);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 318);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btAttackKnight
            // 
            this.btAttackKnight.Location = new System.Drawing.Point(45, 356);
            this.btAttackKnight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAttackKnight.Name = "btAttackKnight";
            this.btAttackKnight.Size = new System.Drawing.Size(221, 23);
            this.btAttackKnight.TabIndex = 2;
            this.btAttackKnight.Text = "Attack!";
            this.btAttackKnight.UseVisualStyleBackColor = true;
            this.btAttackKnight.Click += new System.EventHandler(this.btAttackKnight_Click);
            // 
            // btAttackRanger
            // 
            this.btAttackRanger.Location = new System.Drawing.Point(535, 356);
            this.btAttackRanger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAttackRanger.Name = "btAttackRanger";
            this.btAttackRanger.Size = new System.Drawing.Size(221, 23);
            this.btAttackRanger.TabIndex = 3;
            this.btAttackRanger.Text = "Attack!";
            this.btAttackRanger.UseVisualStyleBackColor = true;
            this.btAttackRanger.Click += new System.EventHandler(this.btAttackRanger_Click);
            // 
            // lbHpKnight
            // 
            this.lbHpKnight.AutoSize = true;
            this.lbHpKnight.Location = new System.Drawing.Point(45, 386);
            this.lbHpKnight.Name = "lbHpKnight";
            this.lbHpKnight.Size = new System.Drawing.Size(31, 17);
            this.lbHpKnight.TabIndex = 4;
            this.lbHpKnight.Text = "HP:";
            // 
            // lbHpRanger
            // 
            this.lbHpRanger.AutoSize = true;
            this.lbHpRanger.Location = new System.Drawing.Point(532, 386);
            this.lbHpRanger.Name = "lbHpRanger";
            this.lbHpRanger.Size = new System.Drawing.Size(31, 17);
            this.lbHpRanger.TabIndex = 5;
            this.lbHpRanger.Text = "HP:";
            // 
            // pbKnight
            // 
            this.pbKnight.Location = new System.Drawing.Point(45, 415);
            this.pbKnight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbKnight.Name = "pbKnight";
            this.pbKnight.Size = new System.Drawing.Size(221, 23);
            this.pbKnight.TabIndex = 6;
            this.pbKnight.Value = 100;
            // 
            // pbRanger
            // 
            this.pbRanger.Location = new System.Drawing.Point(535, 415);
            this.pbRanger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRanger.Name = "pbRanger";
            this.pbRanger.Size = new System.Drawing.Size(221, 23);
            this.pbRanger.TabIndex = 7;
            this.pbRanger.Value = 100;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(288, 32);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(221, 23);
            this.btReset.TabIndex = 8;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.pbRanger);
            this.Controls.Add(this.pbKnight);
            this.Controls.Add(this.lbHpRanger);
            this.Controls.Add(this.lbHpKnight);
            this.Controls.Add(this.btAttackRanger);
            this.Controls.Add(this.btAttackKnight);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btAttackKnight;
        private System.Windows.Forms.Button btAttackRanger;
        private System.Windows.Forms.Label lbHpKnight;
        private System.Windows.Forms.Label lbHpRanger;
        private System.Windows.Forms.ProgressBar pbKnight;
        private System.Windows.Forms.ProgressBar pbRanger;
        private System.Windows.Forms.Button btReset;
    }
}

