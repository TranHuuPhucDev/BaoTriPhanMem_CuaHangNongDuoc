namespace CuahangNongduoc.Resources
{
    partial class frmDichVu
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
            this.grDichVu = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grDichVu
            // 
            this.grDichVu.Location = new System.Drawing.Point(0, 0);
            this.grDichVu.Name = "grDichVu";
            this.grDichVu.Size = new System.Drawing.Size(478, 460);
            this.grDichVu.TabIndex = 0;
            this.grDichVu.TabStop = false;
            this.grDichVu.Text = "Dịch vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(484, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 460);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá dịch vụ";
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grDichVu);
            this.Name = "frmDichVu";
            this.Text = "frmDichVu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grDichVu;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}