
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
            this.btAttackKnight = new System.Windows.Forms.Button();
            this.btAttackRanger = new System.Windows.Forms.Button();
            this.lbHpKnight = new System.Windows.Forms.Label();
            this.lbHpRanger = new System.Windows.Forms.Label();
            this.pbKnight = new System.Windows.Forms.ProgressBar();
            this.pbRanger = new System.Windows.Forms.ProgressBar();
            this.btReset = new System.Windows.Forms.Button();
            this.btHealKnight = new System.Windows.Forms.Button();
            this.btHealRanger = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRestart = new System.Windows.Forms.Button();
            this.btGambleKnight = new System.Windows.Forms.Button();
            this.pbWeaponRanger = new System.Windows.Forms.PictureBox();
            this.pbWeaponKnight = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btGambleRanger = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbArmorKnight = new System.Windows.Forms.PictureBox();
            this.pbArmorRanger = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeaponRanger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeaponKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArmorKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArmorRanger)).BeginInit();
            this.SuspendLayout();
            // 
            // btAttackKnight
            // 
            this.btAttackKnight.Location = new System.Drawing.Point(34, 289);
            this.btAttackKnight.Margin = new System.Windows.Forms.Padding(2);
            this.btAttackKnight.Name = "btAttackKnight";
            this.btAttackKnight.Size = new System.Drawing.Size(166, 19);
            this.btAttackKnight.TabIndex = 2;
            this.btAttackKnight.Text = "Attack!";
            this.btAttackKnight.UseVisualStyleBackColor = true;
            this.btAttackKnight.Click += new System.EventHandler(this.btAttackKnight_Click);
            // 
            // btAttackRanger
            // 
            this.btAttackRanger.Location = new System.Drawing.Point(401, 289);
            this.btAttackRanger.Margin = new System.Windows.Forms.Padding(2);
            this.btAttackRanger.Name = "btAttackRanger";
            this.btAttackRanger.Size = new System.Drawing.Size(166, 19);
            this.btAttackRanger.TabIndex = 3;
            this.btAttackRanger.Text = "Attack!";
            this.btAttackRanger.UseVisualStyleBackColor = true;
            this.btAttackRanger.Click += new System.EventHandler(this.btAttackRanger_Click);
            // 
            // lbHpKnight
            // 
            this.lbHpKnight.AutoSize = true;
            this.lbHpKnight.Location = new System.Drawing.Point(5, 337);
            this.lbHpKnight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHpKnight.Name = "lbHpKnight";
            this.lbHpKnight.Size = new System.Drawing.Size(25, 13);
            this.lbHpKnight.TabIndex = 4;
            this.lbHpKnight.Text = "HP:";
            // 
            // lbHpRanger
            // 
            this.lbHpRanger.AutoSize = true;
            this.lbHpRanger.Location = new System.Drawing.Point(372, 337);
            this.lbHpRanger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHpRanger.Name = "lbHpRanger";
            this.lbHpRanger.Size = new System.Drawing.Size(25, 13);
            this.lbHpRanger.TabIndex = 5;
            this.lbHpRanger.Text = "HP:";
            // 
            // pbKnight
            // 
            this.pbKnight.Location = new System.Drawing.Point(34, 337);
            this.pbKnight.Margin = new System.Windows.Forms.Padding(2);
            this.pbKnight.Name = "pbKnight";
            this.pbKnight.Size = new System.Drawing.Size(166, 19);
            this.pbKnight.TabIndex = 6;
            this.pbKnight.Value = 100;
            // 
            // pbRanger
            // 
            this.pbRanger.Location = new System.Drawing.Point(401, 337);
            this.pbRanger.Margin = new System.Windows.Forms.Padding(2);
            this.pbRanger.Name = "pbRanger";
            this.pbRanger.Size = new System.Drawing.Size(166, 19);
            this.pbRanger.TabIndex = 7;
            this.pbRanger.Value = 100;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(216, 26);
            this.btReset.Margin = new System.Windows.Forms.Padding(2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(166, 19);
            this.btReset.TabIndex = 8;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btHealKnight
            // 
            this.btHealKnight.Location = new System.Drawing.Point(34, 312);
            this.btHealKnight.Margin = new System.Windows.Forms.Padding(2);
            this.btHealKnight.Name = "btHealKnight";
            this.btHealKnight.Size = new System.Drawing.Size(166, 19);
            this.btHealKnight.TabIndex = 9;
            this.btHealKnight.Text = "Heal";
            this.btHealKnight.UseVisualStyleBackColor = true;
            this.btHealKnight.Click += new System.EventHandler(this.btHealKnight_Click);
            // 
            // btHealRanger
            // 
            this.btHealRanger.Location = new System.Drawing.Point(401, 312);
            this.btHealRanger.Margin = new System.Windows.Forms.Padding(2);
            this.btHealRanger.Name = "btHealRanger";
            this.btHealRanger.Size = new System.Drawing.Size(166, 19);
            this.btHealRanger.TabIndex = 10;
            this.btHealRanger.Text = "Heal";
            this.btHealRanger.UseVisualStyleBackColor = true;
            this.btHealRanger.Click += new System.EventHandler(this.btHealRanger_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ranger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Knight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Weapon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Weapon";
            // 
            // btRestart
            // 
            this.btRestart.Location = new System.Drawing.Point(216, 49);
            this.btRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(166, 19);
            this.btRestart.TabIndex = 18;
            this.btRestart.Text = "Restart";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // btGambleKnight
            // 
            this.btGambleKnight.Image = global::Challange_BattleSim.Properties.Resources.Counterterrorist;
            this.btGambleKnight.Location = new System.Drawing.Point(204, 289);
            this.btGambleKnight.Margin = new System.Windows.Forms.Padding(2);
            this.btGambleKnight.Name = "btGambleKnight";
            this.btGambleKnight.Size = new System.Drawing.Size(46, 42);
            this.btGambleKnight.TabIndex = 19;
            this.btGambleKnight.UseVisualStyleBackColor = true;
            this.btGambleKnight.Click += new System.EventHandler(this.btGambleKnight_Click);
            // 
            // pbWeaponRanger
            // 
            this.pbWeaponRanger.Location = new System.Drawing.Point(327, 89);
            this.pbWeaponRanger.Name = "pbWeaponRanger";
            this.pbWeaponRanger.Size = new System.Drawing.Size(55, 50);
            this.pbWeaponRanger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeaponRanger.TabIndex = 12;
            this.pbWeaponRanger.TabStop = false;
            // 
            // pbWeaponKnight
            // 
            this.pbWeaponKnight.Location = new System.Drawing.Point(216, 89);
            this.pbWeaponKnight.Name = "pbWeaponKnight";
            this.pbWeaponKnight.Size = new System.Drawing.Size(55, 50);
            this.pbWeaponKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeaponKnight.TabIndex = 11;
            this.pbWeaponKnight.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(401, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btGambleRanger
            // 
            this.btGambleRanger.Image = global::Challange_BattleSim.Properties.Resources.Terrorist;
            this.btGambleRanger.Location = new System.Drawing.Point(351, 289);
            this.btGambleRanger.Margin = new System.Windows.Forms.Padding(2);
            this.btGambleRanger.Name = "btGambleRanger";
            this.btGambleRanger.Size = new System.Drawing.Size(46, 42);
            this.btGambleRanger.TabIndex = 20;
            this.btGambleRanger.UseVisualStyleBackColor = true;
            this.btGambleRanger.Click += new System.EventHandler(this.btGambleRanger_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gamble";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gamble";
            // 
            // pbArmorKnight
            // 
            this.pbArmorKnight.Location = new System.Drawing.Point(216, 164);
            this.pbArmorKnight.Name = "pbArmorKnight";
            this.pbArmorKnight.Size = new System.Drawing.Size(55, 50);
            this.pbArmorKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArmorKnight.TabIndex = 23;
            this.pbArmorKnight.TabStop = false;
            // 
            // pbArmorRanger
            // 
            this.pbArmorRanger.Location = new System.Drawing.Point(327, 164);
            this.pbArmorRanger.Name = "pbArmorRanger";
            this.pbArmorRanger.Size = new System.Drawing.Size(55, 50);
            this.pbArmorRanger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArmorRanger.TabIndex = 24;
            this.pbArmorRanger.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Armor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Armor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbArmorRanger);
            this.Controls.Add(this.pbArmorKnight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGambleRanger);
            this.Controls.Add(this.btGambleKnight);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbWeaponRanger);
            this.Controls.Add(this.pbWeaponKnight);
            this.Controls.Add(this.btHealRanger);
            this.Controls.Add(this.btHealKnight);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.pbRanger);
            this.Controls.Add(this.pbKnight);
            this.Controls.Add(this.lbHpRanger);
            this.Controls.Add(this.lbHpKnight);
            this.Controls.Add(this.btAttackRanger);
            this.Controls.Add(this.btAttackKnight);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "BattleSim";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeaponRanger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeaponKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArmorKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArmorRanger)).EndInit();
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
        private System.Windows.Forms.Button btHealKnight;
        private System.Windows.Forms.Button btHealRanger;
        private System.Windows.Forms.PictureBox pbWeaponKnight;
        private System.Windows.Forms.PictureBox pbWeaponRanger;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Button btGambleKnight;
        private System.Windows.Forms.Button btGambleRanger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbArmorKnight;
        private System.Windows.Forms.PictureBox pbArmorRanger;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

