
namespace ViewLayer
{
    partial class BookingPrograms
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
            this.dgvBookingprogram = new System.Windows.Forms.DataGridView();
            this.btLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btMachinemanager = new System.Windows.Forms.Button();
            this.btMyreservations = new System.Windows.Forms.Button();
            this.btReservations = new System.Windows.Forms.Button();
            this.btResmanager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingprogram)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookingprogram
            // 
            this.dgvBookingprogram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingprogram.Location = new System.Drawing.Point(235, 145);
            this.dgvBookingprogram.Name = "dgvBookingprogram";
            this.dgvBookingprogram.RowHeadersWidth = 51;
            this.dgvBookingprogram.RowTemplate.Height = 29;
            this.dgvBookingprogram.Size = new System.Drawing.Size(1412, 835);
            this.dgvBookingprogram.TabIndex = 42;
            this.dgvBookingprogram.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookingprogram_CellContentClick);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(1493, 28);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(94, 29);
            this.btLogout.TabIndex = 41;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(783, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 38);
            this.label2.TabIndex = 40;
            this.label2.Text = "Bookingsprogram page";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(1593, 48);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(50, 20);
            this.lbLastname.TabIndex = 39;
            this.lbLastname.Text = "label2";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(1593, 28);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(50, 20);
            this.lbFirstname.TabIndex = 38;
            this.lbFirstname.Text = "label2";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(1593, 68);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 20);
            this.lbEmail.TabIndex = 37;
            this.lbEmail.Text = "label3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 62);
            this.button3.TabIndex = 58;
            this.button3.Text = "Account manager";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 62);
            this.button2.TabIndex = 57;
            this.button2.Text = "Mysubscription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btMachinemanager
            // 
            this.btMachinemanager.Location = new System.Drawing.Point(12, 281);
            this.btMachinemanager.Name = "btMachinemanager";
            this.btMachinemanager.Size = new System.Drawing.Size(217, 62);
            this.btMachinemanager.TabIndex = 56;
            this.btMachinemanager.Text = "Machine manager";
            this.btMachinemanager.UseVisualStyleBackColor = true;
            this.btMachinemanager.Click += new System.EventHandler(this.btMachinemanager_Click);
            // 
            // btMyreservations
            // 
            this.btMyreservations.Location = new System.Drawing.Point(12, 496);
            this.btMyreservations.Name = "btMyreservations";
            this.btMyreservations.Size = new System.Drawing.Size(217, 62);
            this.btMyreservations.TabIndex = 55;
            this.btMyreservations.Text = "Myreservations";
            this.btMyreservations.UseVisualStyleBackColor = true;
            this.btMyreservations.Click += new System.EventHandler(this.btMyreservations_Click);
            // 
            // btReservations
            // 
            this.btReservations.Location = new System.Drawing.Point(12, 428);
            this.btReservations.Name = "btReservations";
            this.btReservations.Size = new System.Drawing.Size(217, 62);
            this.btReservations.TabIndex = 54;
            this.btReservations.Text = "Reservate";
            this.btReservations.UseVisualStyleBackColor = true;
            this.btReservations.Click += new System.EventHandler(this.btReservations_Click);
            // 
            // btResmanager
            // 
            this.btResmanager.Location = new System.Drawing.Point(12, 213);
            this.btResmanager.Name = "btResmanager";
            this.btResmanager.Size = new System.Drawing.Size(217, 62);
            this.btResmanager.TabIndex = 53;
            this.btResmanager.Text = "Reservation manager";
            this.btResmanager.UseVisualStyleBackColor = true;
            this.btResmanager.Click += new System.EventHandler(this.btResmanager_Click);
            // 
            // BookingPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btMachinemanager);
            this.Controls.Add(this.btMyreservations);
            this.Controls.Add(this.btReservations);
            this.Controls.Add(this.btResmanager);
            this.Controls.Add(this.dgvBookingprogram);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.lbEmail);
            this.Name = "BookingPrograms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingProgram";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingprogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBookingprogram;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btMachinemanager;
        private System.Windows.Forms.Button btMyreservations;
        private System.Windows.Forms.Button btReservations;
        private System.Windows.Forms.Button btResmanager;
    }
}