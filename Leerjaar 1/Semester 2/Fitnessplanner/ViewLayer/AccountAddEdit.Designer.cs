
namespace InterfaceLayer
{
    partial class AccountAddEdit
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btSaveedit = new System.Windows.Forms.Button();
            this.lbRole = new System.Windows.Forms.Label();
            this.cbUsertype = new System.Windows.Forms.ComboBox();
            this.lbPassowrd = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btSavecreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(49, 380);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(114, 31);
            this.btCancel.TabIndex = 57;
            this.btCancel.Text = "Clear";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSaveedit
            // 
            this.btSaveedit.Location = new System.Drawing.Point(169, 381);
            this.btSaveedit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSaveedit.Name = "btSaveedit";
            this.btSaveedit.Size = new System.Drawing.Size(114, 31);
            this.btSaveedit.TabIndex = 56;
            this.btSaveedit.Text = "Save";
            this.btSaveedit.UseVisualStyleBackColor = true;
            this.btSaveedit.Click += new System.EventHandler(this.btSaveedit_Click);
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(12, 293);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(42, 20);
            this.lbRole.TabIndex = 55;
            this.lbRole.Text = "Role:";
            // 
            // cbUsertype
            // 
            this.cbUsertype.FormattingEnabled = true;
            this.cbUsertype.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cbUsertype.Location = new System.Drawing.Point(158, 285);
            this.cbUsertype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUsertype.Name = "cbUsertype";
            this.cbUsertype.Size = new System.Drawing.Size(138, 28);
            this.cbUsertype.TabIndex = 54;
            // 
            // lbPassowrd
            // 
            this.lbPassowrd.AutoSize = true;
            this.lbPassowrd.Location = new System.Drawing.Point(12, 233);
            this.lbPassowrd.Name = "lbPassowrd";
            this.lbPassowrd.Size = new System.Drawing.Size(73, 20);
            this.lbPassowrd.TabIndex = 52;
            this.lbPassowrd.Text = "Password:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 177);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(49, 20);
            this.lbEmail.TabIndex = 51;
            this.lbEmail.Text = "Email:";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Location = new System.Drawing.Point(12, 127);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(56, 20);
            this.lbAdress.TabIndex = 50;
            this.lbAdress.Text = "Adress:";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(12, 74);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(75, 20);
            this.lbLastname.TabIndex = 49;
            this.lbLastname.Text = "Lastname:";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(12, 34);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(76, 20);
            this.lbFirstname.TabIndex = 48;
            this.lbFirstname.Text = "Firstname:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(91, 230);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(291, 27);
            this.tbPassword.TabIndex = 47;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(91, 174);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(291, 27);
            this.tbEmail.TabIndex = 46;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(91, 120);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(291, 27);
            this.tbAdress.TabIndex = 45;
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(91, 74);
            this.tbLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(291, 27);
            this.tbLastname.TabIndex = 44;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(91, 31);
            this.tbFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(291, 27);
            this.tbFirstname.TabIndex = 43;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(289, 380);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(114, 31);
            this.btExit.TabIndex = 58;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSavecreate
            // 
            this.btSavecreate.Location = new System.Drawing.Point(169, 380);
            this.btSavecreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSavecreate.Name = "btSavecreate";
            this.btSavecreate.Size = new System.Drawing.Size(114, 31);
            this.btSavecreate.TabIndex = 59;
            this.btSavecreate.Text = "Save";
            this.btSavecreate.UseVisualStyleBackColor = true;
            this.btSavecreate.Click += new System.EventHandler(this.btSavecreate_Click);
            // 
            // AccountAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 424);
            this.Controls.Add(this.btSavecreate);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSaveedit);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.cbUsertype);
            this.Controls.Add(this.lbPassowrd);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbAdress);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.tbFirstname);
            this.Name = "AccountAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.ComboBox cbUsertype;
        private System.Windows.Forms.Label lbPassowrd;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbFirstname;
        public System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Button btExit;
        public System.Windows.Forms.Button btSavecreate;
        public System.Windows.Forms.Button btSaveedit;
    }
}