
namespace Eendenvijver__Mattijs_Pronk_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btManEend = new System.Windows.Forms.Button();
            this.btVrouwEend = new System.Windows.Forms.Button();
            this.btKikkers = new System.Windows.Forms.Button();
            this.tbManEeend = new System.Windows.Forms.TextBox();
            this.tbVrouwEend = new System.Windows.Forms.TextBox();
            this.tbKikkers = new System.Windows.Forms.TextBox();
            this.btVulVijver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btManEend
            // 
            this.btManEend.Location = new System.Drawing.Point(24, 138);
            this.btManEend.Name = "btManEend";
            this.btManEend.Size = new System.Drawing.Size(166, 23);
            this.btManEend.TabIndex = 0;
            this.btManEend.Text = "Maneend";
            this.btManEend.UseVisualStyleBackColor = true;
            this.btManEend.Click += new System.EventHandler(this.btManEend_Click);
            // 
            // btVrouwEend
            // 
            this.btVrouwEend.Location = new System.Drawing.Point(264, 138);
            this.btVrouwEend.Name = "btVrouwEend";
            this.btVrouwEend.Size = new System.Drawing.Size(166, 23);
            this.btVrouwEend.TabIndex = 1;
            this.btVrouwEend.Text = "Vrouweend";
            this.btVrouwEend.UseVisualStyleBackColor = true;
            // 
            // btKikkers
            // 
            this.btKikkers.Location = new System.Drawing.Point(494, 138);
            this.btKikkers.Name = "btKikkers";
            this.btKikkers.Size = new System.Drawing.Size(166, 23);
            this.btKikkers.TabIndex = 2;
            this.btKikkers.Text = "Kikkers";
            this.btKikkers.UseVisualStyleBackColor = true;
            // 
            // tbManEeend
            // 
            this.tbManEeend.Location = new System.Drawing.Point(24, 195);
            this.tbManEeend.Name = "tbManEeend";
            this.tbManEeend.Size = new System.Drawing.Size(166, 23);
            this.tbManEeend.TabIndex = 3;
            // 
            // tbVrouwEend
            // 
            this.tbVrouwEend.Location = new System.Drawing.Point(264, 195);
            this.tbVrouwEend.Name = "tbVrouwEend";
            this.tbVrouwEend.Size = new System.Drawing.Size(166, 23);
            this.tbVrouwEend.TabIndex = 4;
            // 
            // tbKikkers
            // 
            this.tbKikkers.Location = new System.Drawing.Point(494, 195);
            this.tbKikkers.Name = "tbKikkers";
            this.tbKikkers.Size = new System.Drawing.Size(166, 23);
            this.tbKikkers.TabIndex = 5;
            // 
            // btVulVijver
            // 
            this.btVulVijver.Location = new System.Drawing.Point(494, 372);
            this.btVulVijver.Name = "btVulVijver";
            this.btVulVijver.Size = new System.Drawing.Size(166, 23);
            this.btVulVijver.TabIndex = 6;
            this.btVulVijver.Text = "Vulvijver";
            this.btVulVijver.UseVisualStyleBackColor = true;
            this.btVulVijver.Click += new System.EventHandler(this.btVulVijver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVulVijver);
            this.Controls.Add(this.tbKikkers);
            this.Controls.Add(this.tbVrouwEend);
            this.Controls.Add(this.tbManEeend);
            this.Controls.Add(this.btKikkers);
            this.Controls.Add(this.btVrouwEend);
            this.Controls.Add(this.btManEend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btManEend;
        private System.Windows.Forms.Button btVrouwEend;
        private System.Windows.Forms.Button btKikkers;
        private System.Windows.Forms.TextBox tbManEeend;
        private System.Windows.Forms.TextBox tbVrouwEend;
        private System.Windows.Forms.TextBox tbKikkers;
        private System.Windows.Forms.Button btVulVijver;
    }
}

