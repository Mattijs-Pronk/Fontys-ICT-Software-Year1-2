
namespace ViewLayer
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btMachinemanager = new System.Windows.Forms.Button();
            this.btMyreservations = new System.Windows.Forms.Button();
            this.btReservations = new System.Windows.Forms.Button();
            this.btResmanager = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeslots)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDays
            // 
            this.cbDays.FormattingEnabled = true;
            this.cbDays.Location = new System.Drawing.Point(876, 135);
            this.cbDays.Name = "cbDays";
            this.cbDays.Size = new System.Drawing.Size(151, 28);
            this.cbDays.TabIndex = 1;
            this.cbDays.SelectedIndexChanged += new System.EventHandler(this.cbDays_SelectedIndexChanged);
            // 
            // dgvTimeslots
            // 
            this.dgvTimeslots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeslots.Location = new System.Drawing.Point(235, 169);
            this.dgvTimeslots.Name = "dgvTimeslots";
            this.dgvTimeslots.RowHeadersWidth = 51;
            this.dgvTimeslots.RowTemplate.Height = 29;
            this.dgvTimeslots.Size = new System.Drawing.Size(1420, 729);
            this.dgvTimeslots.TabIndex = 3;
            this.dgvTimeslots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeslots_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(825, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 38);
            this.label2.TabIndex = 27;
            this.label2.Text = "Reservation page";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(1607, 65);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(50, 20);
            this.lbLastname.TabIndex = 26;
            this.lbLastname.Text = "label2";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(1607, 45);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(50, 20);
            this.lbFirstname.TabIndex = 25;
            this.lbFirstname.Text = "label2";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(1607, 85);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 20);
            this.lbEmail.TabIndex = 24;
            this.lbEmail.Text = "label3";
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(1507, 47);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(94, 29);
            this.btLogout.TabIndex = 28;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 62);
            this.button3.TabIndex = 58;
            this.button3.Text = "Account manager";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 659);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 62);
            this.button2.TabIndex = 57;
            this.button2.Text = "Mysubscription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btMachinemanager
            // 
            this.btMachinemanager.Location = new System.Drawing.Point(12, 373);
            this.btMachinemanager.Name = "btMachinemanager";
            this.btMachinemanager.Size = new System.Drawing.Size(217, 62);
            this.btMachinemanager.TabIndex = 56;
            this.btMachinemanager.Text = "Machine manager";
            this.btMachinemanager.UseVisualStyleBackColor = true;
            this.btMachinemanager.Click += new System.EventHandler(this.btMachinemanager_Click);
            // 
            // btMyreservations
            // 
            this.btMyreservations.Location = new System.Drawing.Point(12, 591);
            this.btMyreservations.Name = "btMyreservations";
            this.btMyreservations.Size = new System.Drawing.Size(217, 62);
            this.btMyreservations.TabIndex = 55;
            this.btMyreservations.Text = "Myreservations";
            this.btMyreservations.UseVisualStyleBackColor = true;
            this.btMyreservations.Click += new System.EventHandler(this.btMyreservations_Click_1);
            // 
            // btReservations
            // 
            this.btReservations.Location = new System.Drawing.Point(12, 523);
            this.btReservations.Name = "btReservations";
            this.btReservations.Size = new System.Drawing.Size(217, 62);
            this.btReservations.TabIndex = 54;
            this.btReservations.Text = "Reservate";
            this.btReservations.UseVisualStyleBackColor = true;
            this.btReservations.Click += new System.EventHandler(this.btReservations_Click);
            // 
            // btResmanager
            // 
            this.btResmanager.Location = new System.Drawing.Point(12, 237);
            this.btResmanager.Name = "btResmanager";
            this.btResmanager.Size = new System.Drawing.Size(217, 62);
            this.btResmanager.TabIndex = 53;
            this.btResmanager.Text = "Reservation manager";
            this.btResmanager.UseVisualStyleBackColor = true;
            this.btResmanager.Click += new System.EventHandler(this.btResmanager_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 62);
            this.button4.TabIndex = 59;
            this.button4.Text = "Userreservations manager";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Reservation
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
            this.Controls.Add(this.dgvTimeslots);
            this.Controls.Add(this.cbDays);
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation page";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeslots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDays;
        private System.Windows.Forms.DataGridView dgvTimeslots;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbEmail;
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