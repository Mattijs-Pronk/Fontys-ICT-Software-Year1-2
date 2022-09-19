
namespace Bankrekening
{
    partial class Bankzaken
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
            this.btDeposit = new System.Windows.Forms.Button();
            this.btWithdraw = new System.Windows.Forms.Button();
            this.btTransfer = new System.Windows.Forms.Button();
            this.tbLinks = new System.Windows.Forms.TextBox();
            this.tbRechts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btDeposit
            // 
            this.btDeposit.Location = new System.Drawing.Point(354, 104);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.Size = new System.Drawing.Size(75, 23);
            this.btDeposit.TabIndex = 0;
            this.btDeposit.Text = "Deposit";
            this.btDeposit.UseVisualStyleBackColor = true;
            // 
            // btWithdraw
            // 
            this.btWithdraw.Location = new System.Drawing.Point(354, 154);
            this.btWithdraw.Name = "btWithdraw";
            this.btWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btWithdraw.TabIndex = 1;
            this.btWithdraw.Text = "Withdraw";
            this.btWithdraw.UseVisualStyleBackColor = true;
            // 
            // btTransfer
            // 
            this.btTransfer.Location = new System.Drawing.Point(354, 204);
            this.btTransfer.Name = "btTransfer";
            this.btTransfer.Size = new System.Drawing.Size(75, 23);
            this.btTransfer.TabIndex = 2;
            this.btTransfer.Text = "Transfer";
            this.btTransfer.UseVisualStyleBackColor = true;
            // 
            // tbLinks
            // 
            this.tbLinks.Location = new System.Drawing.Point(196, 105);
            this.tbLinks.Name = "tbLinks";
            this.tbLinks.Size = new System.Drawing.Size(100, 22);
            this.tbLinks.TabIndex = 3;
            // 
            // tbRechts
            // 
            this.tbRechts.Location = new System.Drawing.Point(487, 105);
            this.tbRechts.Name = "tbRechts";
            this.tbRechts.Size = new System.Drawing.Size(100, 22);
            this.tbRechts.TabIndex = 4;
            // 
            // Bankzaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbRechts);
            this.Controls.Add(this.tbLinks);
            this.Controls.Add(this.btTransfer);
            this.Controls.Add(this.btWithdraw);
            this.Controls.Add(this.btDeposit);
            this.Name = "Bankzaken";
            this.Text = "Bankzaken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.Button btWithdraw;
        private System.Windows.Forms.Button btTransfer;
        private System.Windows.Forms.TextBox tbLinks;
        private System.Windows.Forms.TextBox tbRechts;
    }
}

