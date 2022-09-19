
namespace ViewLayer
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
            this.btLogout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btMachinemanager = new System.Windows.Forms.Button();
            this.btMyreservations = new System.Windows.Forms.Button();
            this.btReservations = new System.Windows.Forms.Button();
            this.btResmanager = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(766, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 38);
            this.label2.TabIndex = 23;
            this.label2.Text = "Reservation management";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(1623, 77);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(50, 20);
            this.lbLastname.TabIndex = 22;
            this.lbLastname.Text = "label2";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(1623, 57);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(50, 20);
            this.lbFirstname.TabIndex = 21;
            this.lbFirstname.Text = "label2";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(1623, 97);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 20);
            this.lbEmail.TabIndex = 20;
            this.lbEmail.Text = "label3";
            // 
            // btViewall
            // 
            this.btViewall.Location = new System.Drawing.Point(594, 113);
            this.btViewall.Name = "btViewall";
            this.btViewall.Size = new System.Drawing.Size(217, 62);
            this.btViewall.TabIndex = 19;
            this.btViewall.Text = "View all";
            this.btViewall.UseVisualStyleBackColor = true;
            this.btViewall.Click += new System.EventHandler(this.btViewall_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1084, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 62);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAddaccount
            // 
            this.btAddaccount.Location = new System.Drawing.Point(817, 876);
            this.btAddaccount.Name = "btAddaccount";
            this.btAddaccount.Size = new System.Drawing.Size(261, 62);
            this.btAddaccount.TabIndex = 17;
            this.btAddaccount.Text = "Add Timeslot";
            this.btAddaccount.UseVisualStyleBackColor = true;
            this.btAddaccount.Click += new System.EventHandler(this.btAddaccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(891, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search by Day";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(817, 131);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(261, 27);
            this.tbSearch.TabIndex = 15;
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(235, 181);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 29;
            this.dgvReservations.Size = new System.Drawing.Size(1440, 689);
            this.dgvReservations.TabIndex = 14;
            this.dgvReservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellContentClick);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(1523, 63);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(94, 29);
            this.btLogout.TabIndex = 25;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 62);
            this.button3.TabIndex = 58;
            this.button3.Text = "Account manager";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 642);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 62);
            this.button2.TabIndex = 57;
            this.button2.Text = "Mysubscription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btMachinemanager
            // 
            this.btMachinemanager.Location = new System.Drawing.Point(12, 385);
            this.btMachinemanager.Name = "btMachinemanager";
            this.btMachinemanager.Size = new System.Drawing.Size(217, 62);
            this.btMachinemanager.TabIndex = 56;
            this.btMachinemanager.Text = "Machine manager";
            this.btMachinemanager.UseVisualStyleBackColor = true;
            this.btMachinemanager.Click += new System.EventHandler(this.btMachinemanager_Click_1);
            // 
            // btMyreservations
            // 
            this.btMyreservations.Location = new System.Drawing.Point(12, 574);
            this.btMyreservations.Name = "btMyreservations";
            this.btMyreservations.Size = new System.Drawing.Size(217, 62);
            this.btMyreservations.TabIndex = 55;
            this.btMyreservations.Text = "Myreservations";
            this.btMyreservations.UseVisualStyleBackColor = true;
            this.btMyreservations.Click += new System.EventHandler(this.btMyreservations_Click_1);
            // 
            // btReservations
            // 
            this.btReservations.Location = new System.Drawing.Point(12, 506);
            this.btReservations.Name = "btReservations";
            this.btReservations.Size = new System.Drawing.Size(217, 62);
            this.btReservations.TabIndex = 54;
            this.btReservations.Text = "Reservate";
            this.btReservations.UseVisualStyleBackColor = true;
            this.btReservations.Click += new System.EventHandler(this.btReservations_Click);
            // 
            // btResmanager
            // 
            this.btResmanager.Location = new System.Drawing.Point(12, 249);
            this.btResmanager.Name = "btResmanager";
            this.btResmanager.Size = new System.Drawing.Size(217, 62);
            this.btResmanager.TabIndex = 53;
            this.btResmanager.Text = "Reservation manager";
            this.btResmanager.UseVisualStyleBackColor = true;
            this.btResmanager.Click += new System.EventHandler(this.btResmanager_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 62);
            this.button4.TabIndex = 59;
            this.button4.Text = "Userreservations manager";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReservationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btMachinemanager);
            this.Controls.Add(this.btMyreservations);
            this.Controls.Add(this.btReservations);
            this.Controls.Add(this.btResmanager);
            this.Controls.Add(this.btLogout);
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
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btMachinemanager;
        private System.Windows.Forms.Button btMyreservations;
        private System.Windows.Forms.Button btReservations;
        private System.Windows.Forms.Button btResmanager;
        private System.Windows.Forms.Button button4;
    }
}