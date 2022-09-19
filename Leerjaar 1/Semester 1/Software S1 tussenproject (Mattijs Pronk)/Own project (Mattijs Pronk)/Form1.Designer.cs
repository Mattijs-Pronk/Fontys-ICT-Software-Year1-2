
namespace Own_project__Mattijs_Pronk_
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
            this.gbInterface = new System.Windows.Forms.GroupBox();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.tbInterface = new System.Windows.Forms.TextBox();
            this.rbBalance = new System.Windows.Forms.RadioButton();
            this.btNumber0 = new System.Windows.Forms.Button();
            this.btEnter = new System.Windows.Forms.Button();
            this.btNumber3 = new System.Windows.Forms.Button();
            this.btNumber2 = new System.Windows.Forms.Button();
            this.btNumber1 = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btNumber6 = new System.Windows.Forms.Button();
            this.btNumber5 = new System.Windows.Forms.Button();
            this.btNumber4 = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btNumber9 = new System.Windows.Forms.Button();
            this.btNumber8 = new System.Windows.Forms.Button();
            this.btNumber7 = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbInterface);
            this.groupBox1.Controls.Add(this.btNumber0);
            this.groupBox1.Controls.Add(this.btEnter);
            this.groupBox1.Controls.Add(this.btNumber3);
            this.groupBox1.Controls.Add(this.btNumber2);
            this.groupBox1.Controls.Add(this.btNumber1);
            this.groupBox1.Controls.Add(this.btClear);
            this.groupBox1.Controls.Add(this.btNumber6);
            this.groupBox1.Controls.Add(this.btNumber5);
            this.groupBox1.Controls.Add(this.btNumber4);
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btNumber9);
            this.groupBox1.Controls.Add(this.btNumber8);
            this.groupBox1.Controls.Add(this.btNumber7);
            this.groupBox1.Location = new System.Drawing.Point(156, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ATM Interface";
            // 
            // gbInterface
            // 
            this.gbInterface.Controls.Add(this.rbWithdraw);
            this.gbInterface.Controls.Add(this.rbDeposit);
            this.gbInterface.Controls.Add(this.tbInterface);
            this.gbInterface.Controls.Add(this.rbBalance);
            this.gbInterface.Location = new System.Drawing.Point(31, 22);
            this.gbInterface.Name = "gbInterface";
            this.gbInterface.Size = new System.Drawing.Size(348, 113);
            this.gbInterface.TabIndex = 13;
            this.gbInterface.TabStop = false;
            this.gbInterface.Text = "Interface";
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Location = new System.Drawing.Point(6, 50);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(87, 21);
            this.rbWithdraw.TabIndex = 22;
            this.rbWithdraw.TabStop = true;
            this.rbWithdraw.Text = "Withdraw";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(6, 21);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(77, 21);
            this.rbDeposit.TabIndex = 21;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            this.rbDeposit.CheckedChanged += new System.EventHandler(this.rbDeposit_CheckedChanged);
            // 
            // tbInterface
            // 
            this.tbInterface.Location = new System.Drawing.Point(99, 21);
            this.tbInterface.MaxLength = 4;
            this.tbInterface.Name = "tbInterface";
            this.tbInterface.Size = new System.Drawing.Size(144, 22);
            this.tbInterface.TabIndex = 15;
            this.tbInterface.TextChanged += new System.EventHandler(this.tbInterface_TextChanged);
            // 
            // rbBalance
            // 
            this.rbBalance.AutoSize = true;
            this.rbBalance.Location = new System.Drawing.Point(249, 22);
            this.rbBalance.Name = "rbBalance";
            this.rbBalance.Size = new System.Drawing.Size(80, 21);
            this.rbBalance.TabIndex = 24;
            this.rbBalance.TabStop = true;
            this.rbBalance.Text = "Balance";
            this.rbBalance.UseVisualStyleBackColor = true;
            // 
            // btNumber0
            // 
            this.btNumber0.Location = new System.Drawing.Point(134, 362);
            this.btNumber0.Name = "btNumber0";
            this.btNumber0.Size = new System.Drawing.Size(67, 62);
            this.btNumber0.TabIndex = 12;
            this.btNumber0.Text = "0";
            this.btNumber0.UseVisualStyleBackColor = true;
            this.btNumber0.Click += new System.EventHandler(this.btNumber0_Click);
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(280, 294);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(67, 62);
            this.btEnter.TabIndex = 11;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // btNumber3
            // 
            this.btNumber3.Location = new System.Drawing.Point(207, 294);
            this.btNumber3.Name = "btNumber3";
            this.btNumber3.Size = new System.Drawing.Size(67, 62);
            this.btNumber3.TabIndex = 10;
            this.btNumber3.Text = "3";
            this.btNumber3.UseVisualStyleBackColor = true;
            this.btNumber3.Click += new System.EventHandler(this.btNumber3_Click);
            // 
            // btNumber2
            // 
            this.btNumber2.Location = new System.Drawing.Point(134, 294);
            this.btNumber2.Name = "btNumber2";
            this.btNumber2.Size = new System.Drawing.Size(67, 62);
            this.btNumber2.TabIndex = 9;
            this.btNumber2.Text = "2";
            this.btNumber2.UseVisualStyleBackColor = true;
            this.btNumber2.Click += new System.EventHandler(this.btNumber2_Click);
            // 
            // btNumber1
            // 
            this.btNumber1.Location = new System.Drawing.Point(61, 294);
            this.btNumber1.Name = "btNumber1";
            this.btNumber1.Size = new System.Drawing.Size(67, 62);
            this.btNumber1.TabIndex = 8;
            this.btNumber1.Text = "1";
            this.btNumber1.UseVisualStyleBackColor = true;
            this.btNumber1.Click += new System.EventHandler(this.btNumber1_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(280, 226);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(67, 62);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btNumber6
            // 
            this.btNumber6.Location = new System.Drawing.Point(207, 226);
            this.btNumber6.Name = "btNumber6";
            this.btNumber6.Size = new System.Drawing.Size(67, 62);
            this.btNumber6.TabIndex = 6;
            this.btNumber6.Text = "6";
            this.btNumber6.UseVisualStyleBackColor = true;
            this.btNumber6.Click += new System.EventHandler(this.btNumber6_Click);
            // 
            // btNumber5
            // 
            this.btNumber5.Location = new System.Drawing.Point(134, 226);
            this.btNumber5.Name = "btNumber5";
            this.btNumber5.Size = new System.Drawing.Size(67, 62);
            this.btNumber5.TabIndex = 5;
            this.btNumber5.Text = "5";
            this.btNumber5.UseVisualStyleBackColor = true;
            this.btNumber5.Click += new System.EventHandler(this.btNumber5_Click);
            // 
            // btNumber4
            // 
            this.btNumber4.Location = new System.Drawing.Point(61, 226);
            this.btNumber4.Name = "btNumber4";
            this.btNumber4.Size = new System.Drawing.Size(67, 62);
            this.btNumber4.TabIndex = 4;
            this.btNumber4.Text = "4";
            this.btNumber4.UseVisualStyleBackColor = true;
            this.btNumber4.Click += new System.EventHandler(this.btNumber4_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(280, 158);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(67, 62);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btNumber9
            // 
            this.btNumber9.Location = new System.Drawing.Point(207, 158);
            this.btNumber9.Name = "btNumber9";
            this.btNumber9.Size = new System.Drawing.Size(67, 62);
            this.btNumber9.TabIndex = 2;
            this.btNumber9.Text = "9";
            this.btNumber9.UseVisualStyleBackColor = true;
            this.btNumber9.Click += new System.EventHandler(this.btNumber9_Click);
            // 
            // btNumber8
            // 
            this.btNumber8.Location = new System.Drawing.Point(134, 158);
            this.btNumber8.Name = "btNumber8";
            this.btNumber8.Size = new System.Drawing.Size(67, 62);
            this.btNumber8.TabIndex = 1;
            this.btNumber8.Text = "8";
            this.btNumber8.UseVisualStyleBackColor = true;
            this.btNumber8.Click += new System.EventHandler(this.btNumber8_Click);
            // 
            // btNumber7
            // 
            this.btNumber7.Location = new System.Drawing.Point(61, 158);
            this.btNumber7.Name = "btNumber7";
            this.btNumber7.Size = new System.Drawing.Size(67, 62);
            this.btNumber7.TabIndex = 0;
            this.btNumber7.Text = "7";
            this.btNumber7.UseVisualStyleBackColor = true;
            this.btNumber7.Click += new System.EventHandler(this.btNumber7_Click);
            // 
            // lbHistory
            // 
            this.lbHistory.AccessibleName = "lbHistory";
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 16;
            this.lbHistory.Location = new System.Drawing.Point(571, 34);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(152, 404);
            this.lbHistory.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Previous balance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ATM";
            this.groupBox1.ResumeLayout(false);
            this.gbInterface.ResumeLayout(false);
            this.gbInterface.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btNumber0;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btNumber3;
        private System.Windows.Forms.Button btNumber2;
        private System.Windows.Forms.Button btNumber1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btNumber6;
        private System.Windows.Forms.Button btNumber5;
        private System.Windows.Forms.Button btNumber4;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btNumber9;
        private System.Windows.Forms.Button btNumber8;
        private System.Windows.Forms.Button btNumber7;
        private System.Windows.Forms.RadioButton rbBalance;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.TextBox tbInterface;
        private System.Windows.Forms.GroupBox gbInterface;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Label label1;
    }
}

