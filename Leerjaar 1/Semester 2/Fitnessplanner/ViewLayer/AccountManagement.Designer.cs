
namespace Fitnessplanner3
{
    partial class AccountManagement
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddaccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btViewall = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btResmanager = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btReservations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 133);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 29;
            this.dgvUsers.Size = new System.Drawing.Size(871, 342);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(331, 100);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(261, 27);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search by Email";
            // 
            // btAddaccount
            // 
            this.btAddaccount.Location = new System.Drawing.Point(331, 481);
            this.btAddaccount.Name = "btAddaccount";
            this.btAddaccount.Size = new System.Drawing.Size(261, 29);
            this.btAddaccount.TabIndex = 6;
            this.btAddaccount.Text = "Add Account";
            this.btAddaccount.UseVisualStyleBackColor = true;
            this.btAddaccount.Click += new System.EventHandler(this.btAddaccount_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btViewall
            // 
            this.btViewall.Location = new System.Drawing.Point(213, 100);
            this.btViewall.Name = "btViewall";
            this.btViewall.Size = new System.Drawing.Size(112, 29);
            this.btViewall.TabIndex = 8;
            this.btViewall.Text = "View all";
            this.btViewall.UseVisualStyleBackColor = true;
            this.btViewall.Click += new System.EventHandler(this.btViewall_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(721, 49);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 20);
            this.lbEmail.TabIndex = 10;
            this.lbEmail.Text = "label3";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(721, 9);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(50, 20);
            this.lbFirstname.TabIndex = 11;
            this.lbFirstname.Text = "label2";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(721, 29);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(50, 20);
            this.lbLastname.TabIndex = 12;
            this.lbLastname.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(315, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "Account management";
            // 
            // btResmanager
            // 
            this.btResmanager.Location = new System.Drawing.Point(12, 15);
            this.btResmanager.Name = "btResmanager";
            this.btResmanager.Size = new System.Drawing.Size(158, 29);
            this.btResmanager.TabIndex = 25;
            this.btResmanager.Text = "Reservation manager";
            this.btResmanager.UseVisualStyleBackColor = true;
            this.btResmanager.Click += new System.EventHandler(this.btResmanager_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(213, 15);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(94, 29);
            this.btLogout.TabIndex = 26;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btReservations
            // 
            this.btReservations.Location = new System.Drawing.Point(12, 50);
            this.btReservations.Name = "btReservations";
            this.btReservations.Size = new System.Drawing.Size(158, 29);
            this.btReservations.TabIndex = 27;
            this.btReservations.Text = "Reservations";
            this.btReservations.UseVisualStyleBackColor = true;
            this.btReservations.Click += new System.EventHandler(this.btReservations_Click);
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 522);
            this.Controls.Add(this.btReservations);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btResmanager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btViewall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAddaccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvUsers);
            this.Name = "AccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btAddaccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btViewall;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btResmanager;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btReservations;
    }
}

