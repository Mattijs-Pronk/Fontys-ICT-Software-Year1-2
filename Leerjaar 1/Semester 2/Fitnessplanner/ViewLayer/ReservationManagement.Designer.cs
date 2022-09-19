
namespace InterfaceLayer
{
    partial class ReservationManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btViewall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btAddaccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.btAccmanager = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(314, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 38);
            this.label2.TabIndex = 23;
            this.label2.Text = "Reservation management";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(720, 34);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(50, 20);
            this.lbLastname.TabIndex = 22;
            this.lbLastname.Text = "label2";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(720, 14);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(50, 20);
            this.lbFirstname.TabIndex = 21;
            this.lbFirstname.Text = "label2";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(720, 54);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 20);
            this.lbEmail.TabIndex = 20;
            this.lbEmail.Text = "label3";
            // 
            // btViewall
            // 
            this.btViewall.Location = new System.Drawing.Point(212, 105);
            this.btViewall.Name = "btViewall";
            this.btViewall.Size = new System.Drawing.Size(112, 29);
            this.btViewall.TabIndex = 19;
            this.btViewall.Text = "View all";
            this.btViewall.UseVisualStyleBackColor = true;
            this.btViewall.Click += new System.EventHandler(this.btViewall_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAddaccount
            // 
            this.btAddaccount.Location = new System.Drawing.Point(330, 486);
            this.btAddaccount.Name = "btAddaccount";
            this.btAddaccount.Size = new System.Drawing.Size(261, 29);
            this.btAddaccount.TabIndex = 17;
            this.btAddaccount.Text = "Add Timeslot";
            this.btAddaccount.UseVisualStyleBackColor = true;
            this.btAddaccount.Click += new System.EventHandler(this.btAddaccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search by Day";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(330, 105);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(261, 27);
            this.tbSearch.TabIndex = 15;
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(11, 138);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 29;
            this.dgvReservations.Size = new System.Drawing.Size(871, 342);
            this.dgvReservations.TabIndex = 14;
            this.dgvReservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellContentClick);
            // 
            // btAccmanager
            // 
            this.btAccmanager.Location = new System.Drawing.Point(13, 14);
            this.btAccmanager.Name = "btAccmanager";
            this.btAccmanager.Size = new System.Drawing.Size(135, 28);
            this.btAccmanager.TabIndex = 24;
            this.btAccmanager.Text = "Account manager";
            this.btAccmanager.UseVisualStyleBackColor = true;
            this.btAccmanager.Click += new System.EventHandler(this.btResmanager_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(212, 5);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(94, 29);
            this.btLogout.TabIndex = 25;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Reservations";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReservationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btAccmanager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btViewall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAddaccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvReservations);
            this.Name = "ReservationManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btViewall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAddaccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        public System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Button btAccmanager;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button button2;
    }
}