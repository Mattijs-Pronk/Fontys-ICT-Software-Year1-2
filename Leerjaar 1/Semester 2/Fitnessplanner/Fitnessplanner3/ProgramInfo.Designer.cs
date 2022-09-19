
namespace ViewLayer
{
    partial class ProgramInfo
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
            this.dgvProgramInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProgramInfo
            // 
            this.dgvProgramInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramInfo.Location = new System.Drawing.Point(13, 12);
            this.dgvProgramInfo.Name = "dgvProgramInfo";
            this.dgvProgramInfo.RowHeadersWidth = 51;
            this.dgvProgramInfo.RowTemplate.Height = 29;
            this.dgvProgramInfo.Size = new System.Drawing.Size(538, 357);
            this.dgvProgramInfo.TabIndex = 0;
            // 
            // ProgramInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 381);
            this.Controls.Add(this.dgvProgramInfo);
            this.Name = "ProgramInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProgramInfo;
    }
}