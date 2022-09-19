
namespace InterfaceLayer
{
    partial class ReservationAddEdit
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
            this.btSaveRes = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSaveedit = new System.Windows.Forms.Button();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.tbTimeslot = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.tbMaxres = new System.Windows.Forms.TextBox();
            this.cbWeek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSaveRes
            // 
            this.btSaveRes.Location = new System.Drawing.Point(185, 204);
            this.btSaveRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSaveRes.Name = "btSaveRes";
            this.btSaveRes.Size = new System.Drawing.Size(114, 31);
            this.btSaveRes.TabIndex = 75;
            this.btSaveRes.Text = "Save";
            this.btSaveRes.UseVisualStyleBackColor = true;
            this.btSaveRes.Click += new System.EventHandler(this.btSaveRes_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(305, 204);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(114, 31);
            this.btExit.TabIndex = 74;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(65, 204);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(114, 31);
            this.btCancel.TabIndex = 73;
            this.btCancel.Text = "Clear";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSaveedit
            // 
            this.btSaveedit.Location = new System.Drawing.Point(185, 205);
            this.btSaveedit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSaveedit.Name = "btSaveedit";
            this.btSaveedit.Size = new System.Drawing.Size(114, 31);
            this.btSaveedit.TabIndex = 72;
            this.btSaveedit.Text = "Save";
            this.btSaveedit.UseVisualStyleBackColor = true;
            this.btSaveedit.Click += new System.EventHandler(this.btSaveedit_Click);
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(11, 56);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(69, 20);
            this.lbLastname.TabIndex = 66;
            this.lbLastname.Text = "Timeslot:";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(11, 16);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(38, 20);
            this.lbFirstname.TabIndex = 65;
            this.lbFirstname.Text = "Day:";
            // 
            // tbTimeslot
            // 
            this.tbTimeslot.Location = new System.Drawing.Point(97, 56);
            this.tbTimeslot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTimeslot.Name = "tbTimeslot";
            this.tbTimeslot.Size = new System.Drawing.Size(291, 27);
            this.tbTimeslot.TabIndex = 61;
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(97, 13);
            this.tbDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(291, 27);
            this.tbDay.TabIndex = 60;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Location = new System.Drawing.Point(11, 153);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(63, 20);
            this.lbAdress.TabIndex = 67;
            this.lbAdress.Text = "Max res:";
            // 
            // tbMaxres
            // 
            this.tbMaxres.Location = new System.Drawing.Point(97, 150);
            this.tbMaxres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaxres.Name = "tbMaxres";
            this.tbMaxres.Size = new System.Drawing.Size(291, 27);
            this.tbMaxres.TabIndex = 62;
            // 
            // cbWeek
            // 
            this.cbWeek.FormattingEnabled = true;
            this.cbWeek.Items.AddRange(new object[] {
            "Normal workday"});
            this.cbWeek.Location = new System.Drawing.Point(97, 106);
            this.cbWeek.Name = "cbWeek";
            this.cbWeek.Size = new System.Drawing.Size(291, 28);
            this.cbWeek.TabIndex = 76;
            this.cbWeek.SelectedIndexChanged += new System.EventHandler(this.cbWeek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Full day:";
            // 
            // ReservationAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWeek);
            this.Controls.Add(this.btSaveRes);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSaveedit);
            this.Controls.Add(this.lbAdress);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.tbMaxres);
            this.Controls.Add(this.tbTimeslot);
            this.Controls.Add(this.tbDay);
            this.Name = "ReservationAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btSaveRes;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.Button btSaveedit;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.TextBox tbTimeslot;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.TextBox tbMaxres;
        public System.Windows.Forms.ComboBox cbWeek;
        public System.Windows.Forms.Label label1;
    }
}