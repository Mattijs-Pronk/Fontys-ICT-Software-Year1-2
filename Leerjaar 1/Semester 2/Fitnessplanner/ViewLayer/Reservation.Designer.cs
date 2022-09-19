
namespace InterfaceLayer
{
    partial class Reservation
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
            this.cbDays = new System.Windows.Forms.ComboBox();
            this.dgvTimeslots = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.btAccountmanager = new System.Windows.Forms.Button();
            this.btReservationsmanager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeslots)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDays
            // 
            this.cbDays.FormattingEnabled = true;
            this.cbDays.Location = new System.Drawing.Point(905, 124);
            this.cbDays.Name = "cbDays";
            this.cbDays.Size = new System.Drawing.Size(151, 28);
            this.cbDays.TabIndex = 1;
            this.cbDays.SelectedIndexChanged += new System.EventHandler(this.cbDays_SelectedIndexChanged);
            // 
            // dgvTimeslots
            // 
            this.dgvTimeslots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeslots.Location = new System.Drawing.Point(118, 124);
            this.dgvTimeslots.Name = "dgvTimeslots";
            this.dgvTimeslots.RowHeadersWidth = 51;
            this.dgvTimeslots.RowTemplate.Height = 29;
            this.dgvTimeslots.Size = new System.Drawing.Size(781, 446);
            this.dgvTimeslots.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(425, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 38);
            this.label2.TabIndex = 27;
            this.label2.Text = "Reservations";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(1006, 45);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(50, 20);
            this.lbLastname.TabIndex = 26;
            this.lbLastname.Text = "label2";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(1006, 25);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(50, 20);
            this.lbFirstname.TabIndex = 25;
            this.lbFirstname.Text = "label2";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(1006, 65);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 20);
            this.lbEmail.TabIndex = 24;
            this.lbEmail.Text = "label3";
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(271, 12);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(94, 29);
            this.btLogout.TabIndex = 28;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btAccountmanager
            // 
            this.btAccountmanager.Location = new System.Drawing.Point(13, 13);
            this.btAccountmanager.Name = "btAccountmanager";
            this.btAccountmanager.Size = new System.Drawing.Size(165, 29);
            this.btAccountmanager.TabIndex = 29;
            this.btAccountmanager.Text = "Account Manager";
            this.btAccountmanager.UseVisualStyleBackColor = true;
            this.btAccountmanager.Click += new System.EventHandler(this.btAccountmanager_Click);
            // 
            // btReservationsmanager
            // 
            this.btReservationsmanager.Location = new System.Drawing.Point(13, 48);
            this.btReservationsmanager.Name = "btReservationsmanager";
            this.btReservationsmanager.Size = new System.Drawing.Size(165, 29);
            this.btReservationsmanager.TabIndex = 30;
            this.btReservationsmanager.Text = "Reservations Manager";
            this.btReservationsmanager.UseVisualStyleBackColor = true;
            this.btReservationsmanager.Click += new System.EventHandler(this.btReservationsmanager_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 582);
            this.Controls.Add(this.btReservationsmanager);
            this.Controls.Add(this.btAccountmanager);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.dgvTimeslots);
            this.Controls.Add(this.cbDays);
            this.Name = "Reservation";
            this.Text = "Reservation Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeslots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lbTimeslots;
        private System.Windows.Forms.ComboBox cbDays;
        private System.Windows.Forms.DataGridView dgvTimeslots;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btAccountmanager;
        private System.Windows.Forms.Button btReservationsmanager;
    }
}