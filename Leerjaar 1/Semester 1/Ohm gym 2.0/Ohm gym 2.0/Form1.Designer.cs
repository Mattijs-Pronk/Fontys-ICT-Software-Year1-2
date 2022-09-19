
namespace Ohm_gym_2._0
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbComport = new System.Windows.Forms.ComboBox();
            this.cbBautrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbSolution = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSolution);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 266);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDisconnect);
            this.groupBox1.Controls.Add(this.btConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBautrate);
            this.groupBox1.Controls.Add(this.cbComport);
            this.groupBox1.Location = new System.Drawing.Point(12, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port settings";
            // 
            // cbComport
            // 
            this.cbComport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComport.FormattingEnabled = true;
            this.cbComport.Location = new System.Drawing.Point(137, 23);
            this.cbComport.Name = "cbComport";
            this.cbComport.Size = new System.Drawing.Size(121, 24);
            this.cbComport.TabIndex = 0;
            this.cbComport.DropDown += new System.EventHandler(this.cbComport_DropDown);
            this.cbComport.SelectedIndexChanged += new System.EventHandler(this.cbComport_SelectedIndexChanged);
            // 
            // cbBautrate
            // 
            this.cbBautrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBautrate.FormattingEnabled = true;
            this.cbBautrate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cbBautrate.Location = new System.Drawing.Point(136, 52);
            this.cbBautrate.Name = "cbBautrate";
            this.cbBautrate.Size = new System.Drawing.Size(121, 24);
            this.cbBautrate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD Rate";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(352, 26);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(98, 50);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(456, 27);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(98, 50);
            this.btDisconnect.TabIndex = 5;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // lbSolution
            // 
            this.lbSolution.AccessibleName = "lbSolution";
            this.lbSolution.FormattingEnabled = true;
            this.lbSolution.ItemHeight = 16;
            this.lbSolution.Location = new System.Drawing.Point(378, 4);
            this.lbSolution.Name = "lbSolution";
            this.lbSolution.Size = new System.Drawing.Size(395, 260);
            this.lbSolution.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ohm GYM app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBautrate;
        private System.Windows.Forms.ComboBox cbComport;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox lbSolution;
    }
}

