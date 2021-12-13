
namespace Galgje
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
            this.btCheck = new System.Windows.Forms.Button();
            this.tbChecklines = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(112, 177);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 23);
            this.btCheck.TabIndex = 0;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // tbChecklines
            // 
            this.tbChecklines.Location = new System.Drawing.Point(112, 231);
            this.tbChecklines.Name = "tbChecklines";
            this.tbChecklines.Size = new System.Drawing.Size(100, 20);
            this.tbChecklines.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbChecklines);
            this.Controls.Add(this.btCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.TextBox tbChecklines;
    }
}

