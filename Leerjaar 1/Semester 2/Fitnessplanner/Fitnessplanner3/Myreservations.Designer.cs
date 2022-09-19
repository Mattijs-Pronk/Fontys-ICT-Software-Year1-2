
namespace ViewLayer
{
    partial class Myreservations
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
            this.btLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.dgvMyreservations = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btMachinemanager = new System.Windows.Forms.Button();
            this.btMyreservations = new System.Windows.Forms.Button();
            this.btReservations = new System.Windows.Forms.Button();
            this.btResmanager = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyreservations)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(1513, 52);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(94, 29);
            this.btLogout.TabIndex = 33;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(816, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 38);
            this.label2.TabIndex = 32;
            this.label2.Text = "Myreservations page";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(1613, 72);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(50, 20);
            this.lbLastname.TabIndex = 31;
            this.lbLastname.Text = "label2";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(1613, 52);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(50, 20);
            this.lbFirstname.TabIndex = 30;
            this.lbFirstname.Text = "label2";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(1613, 92);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 20);
            this.lbEmail.TabIndex = 29;
            this.lbEmail.Text = "label3";
            // 
            // dgvMyreservations
            // 
            this.dgvMyreservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyreservations.Location = new System.Drawing.Point(235, 163);
            this.dgvMyreservations.Name = "dgvMyreservations";
            this.dgvMyreservations.RowHeadersWidth = 51;
            this.dgvMyreservations.RowTemplate.Height = 29;
            this.dgvMyreservations.Size = new System.Drawing.Size(1428, 764);
            this.dgvMyreservations.TabIndex = 34;
            this.dgvMyreservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyreservations_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 62);
            this.button3.TabIndex = 52;
            this.button3.Text = "Account manager";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 62);
            this.button2.TabIndex = 51;
            this.button2.Text = "Mysubscription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btMachinemanager
            // 
            this.btMachinemanager.Location = new System.Drawing.Point(12, 367);
            this.btMachinemanager.Name = "btMachinemanager";
            this.btMachinemanager.Size = new System.Drawing.Size(217, 62);
            this.btMachinemanager.TabIndex = 50;
            this.btMachinemanager.Text = "Machine manager";
            this.btMachinemanager.UseVisualStyleBackColor = true;
            this.btMachinemanager.Click += new System.EventHandler(this.btMachinemanager_Click);
            // 
            // btMyreservations
            // 
            this.btMyreservations.Location = new System.Drawing.Point(12, 553);
            this.btMyreservations.Name = "btMyreservations";
            this.btMyreservations.Size = new System.Drawing.Size(217, 62);
            this.btMyreservations.TabIndex = 49;
            this.btMyreservations.Text = "Myreservations";
            this.btMyreservations.UseVisualStyleBackColor = true;
            this.btMyreservations.Click += new System.EventHandler(this.btMyreservations_Click);
            // 
            // btReservations
            // 
            this.btReservations.Location = new System.Drawing.Point(12, 485);
            this.btReservations.Name = "btReservations";
            this.btReservations.Size = new System.Drawing.Size(217, 62);
            this.btReservations.TabIndex = 48;
            this.btReservations.Text = "Reservate";
            this.btReservations.UseVisualStyleBackColor = true;
            this.btReservations.Click += new System.EventHandler(this.btReservations_Click);
            // 
            // btResmanager
            // 
            this.btResmanager.Location = new System.Drawing.Point(12, 231);
            this.btResmanager.Name = "btResmanager";
            this.btResmanager.Size = new System.Drawing.Size(217, 62);
            this.btResmanager.TabIndex = 47;
            this.btResmanager.Text = "Reservation manager";
            this.btResmanager.UseVisualStyleBackColor = true;
            this.btResmanager.Click += new System.EventHandler(this.btResmanager_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 62);
            this.button4.TabIndex = 53;
            this.button4.Text = "Userreservations manager";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Myreservations
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
            this.Controls.Add(this.dgvMyreservations);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.lbEmail);
            this.Name = "Myreservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Myreservationspage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyreservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.DataGridView dgvMyreservations;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btMachinemanager;
        private System.Windows.Forms.Button btMyreservations;
        private System.Windows.Forms.Button btReservations;
        private System.Windows.Forms.Button btResmanager;
        private System.Windows.Forms.Button button4;
    }
}