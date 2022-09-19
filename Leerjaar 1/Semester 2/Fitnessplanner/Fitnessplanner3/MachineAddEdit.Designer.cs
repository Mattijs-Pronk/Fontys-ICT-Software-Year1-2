
namespace ViewLayer
{
    partial class MachineAddEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.btSaveMachine = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSaveedit = new System.Windows.Forms.Button();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.tbMachinename = new System.Windows.Forms.TextBox();
            this.tbMachinedescription = new System.Windows.Forms.TextBox();
            this.cbMachinetype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Machinedescription:";
            // 
            // btSaveMachine
            // 
            this.btSaveMachine.Location = new System.Drawing.Point(240, 149);
            this.btSaveMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSaveMachine.Name = "btSaveMachine";
            this.btSaveMachine.Size = new System.Drawing.Size(114, 31);
            this.btSaveMachine.TabIndex = 88;
            this.btSaveMachine.Text = "Save";
            this.btSaveMachine.UseVisualStyleBackColor = true;
            this.btSaveMachine.Click += new System.EventHandler(this.btSaveMachine_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(360, 149);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(114, 31);
            this.btExit.TabIndex = 87;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(120, 149);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(114, 31);
            this.btCancel.TabIndex = 86;
            this.btCancel.Text = "Clear";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSaveedit
            // 
            this.btSaveedit.Location = new System.Drawing.Point(240, 150);
            this.btSaveedit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSaveedit.Name = "btSaveedit";
            this.btSaveedit.Size = new System.Drawing.Size(114, 31);
            this.btSaveedit.TabIndex = 85;
            this.btSaveedit.Text = "Save";
            this.btSaveedit.UseVisualStyleBackColor = true;
            this.btSaveedit.Click += new System.EventHandler(this.btSaveedit_Click);
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(9, 56);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(105, 20);
            this.lbLastname.TabIndex = 83;
            this.lbLastname.Text = "Machinename:";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(9, 16);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(97, 20);
            this.lbFirstname.TabIndex = 82;
            this.lbFirstname.Text = "Machinetype:";
            // 
            // tbMachinename
            // 
            this.tbMachinename.Location = new System.Drawing.Point(157, 53);
            this.tbMachinename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMachinename.Name = "tbMachinename";
            this.tbMachinename.Size = new System.Drawing.Size(291, 27);
            this.tbMachinename.TabIndex = 80;
            // 
            // tbMachinedescription
            // 
            this.tbMachinedescription.Location = new System.Drawing.Point(157, 95);
            this.tbMachinedescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMachinedescription.Name = "tbMachinedescription";
            this.tbMachinedescription.Size = new System.Drawing.Size(291, 27);
            this.tbMachinedescription.TabIndex = 81;
            // 
            // cbMachinetype
            // 
            this.cbMachinetype.FormattingEnabled = true;
            this.cbMachinetype.Items.AddRange(new object[] {
            "Bicep",
            "Back",
            "Chest",
            "Shoulders",
            "Legs",
            "Triceps"});
            this.cbMachinetype.Location = new System.Drawing.Point(157, 16);
            this.cbMachinetype.Name = "cbMachinetype";
            this.cbMachinetype.Size = new System.Drawing.Size(291, 28);
            this.cbMachinetype.TabIndex = 91;
            // 
            // MachineAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 193);
            this.Controls.Add(this.cbMachinetype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSaveMachine);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSaveedit);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.tbMachinedescription);
            this.Controls.Add(this.tbMachinename);
            this.Name = "MachineAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MachineAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btSaveMachine;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.Button btSaveedit;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.TextBox tbMachinename;
        private System.Windows.Forms.TextBox tbMachinedescription;
        private System.Windows.Forms.ComboBox cbMachinetype;
    }
}