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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaGia = new System.Windows.Forms.Button();
            this.btnSuaGia = new System.Windows.Forms.Button();
            this.btnThemGia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaDichVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTenDichVu = new System.Windows.Forms.ComboBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.dgvGiaDichVu = new System.Windows.Forms.DataGridView();
            this.grDichVu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // grDichVu
            // 
            this.grDichVu.Controls.Add(this.dgvDichVu);
            this.grDichVu.Controls.Add(this.groupBox1);
            this.grDichVu.Location = new System.Drawing.Point(0, 0);
            this.grDichVu.Name = "grDichVu";
            this.grDichVu.Size = new System.Drawing.Size(478, 460);
            this.grDichVu.TabIndex = 0;
            this.grDichVu.TabStop = false;
            this.grDichVu.Text = "Dịch vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGiaDichVu);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(484, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 460);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenDichVu);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Location = new System.Drawing.Point(135, 19);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(243, 20);
            this.txtTenDichVu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên dịch vụ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(135, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(222, 45);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(304, 45);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTenDichVu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnXoaGia);
            this.groupBox3.Controls.Add(this.btnSuaGia);
            this.groupBox3.Controls.Add(this.btnThemGia);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtGiaDichVu);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 99);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnXoaGia
            // 
            this.btnXoaGia.Location = new System.Drawing.Point(402, 69);
            this.btnXoaGia.Name = "btnXoaGia";
            this.btnXoaGia.Size = new System.Drawing.Size(75, 23);
            this.btnXoaGia.TabIndex = 5;
            this.btnXoaGia.Text = "Xoa";
            this.btnXoaGia.UseVisualStyleBackColor = true;
            // 
            // btnSuaGia
            // 
            this.btnSuaGia.Location = new System.Drawing.Point(402, 45);
            this.btnSuaGia.Name = "btnSuaGia";
            this.btnSuaGia.Size = new System.Drawing.Size(75, 23);
            this.btnSuaGia.TabIndex = 4;
            this.btnSuaGia.Text = "Sửa";
            this.btnSuaGia.UseVisualStyleBackColor = true;
            // 
            // btnThemGia
            // 
            this.btnThemGia.Location = new System.Drawing.Point(402, 16);
            this.btnThemGia.Name = "btnThemGia";
            this.btnThemGia.Size = new System.Drawing.Size(75, 23);
            this.btnThemGia.TabIndex = 3;
            this.btnThemGia.Text = "Thêm";
            this.btnThemGia.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá dịch vụ";
            // 
            // txtGiaDichVu
            // 
            this.txtGiaDichVu.Location = new System.Drawing.Point(77, 56);
            this.txtGiaDichVu.Name = "txtGiaDichVu";
            this.txtGiaDichVu.Size = new System.Drawing.Size(305, 20);
            this.txtGiaDichVu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên dịch vụ";
            // 
            // cmbTenDichVu
            // 
            this.cmbTenDichVu.FormattingEnabled = true;
            this.cmbTenDichVu.Location = new System.Drawing.Point(77, 20);
            this.cmbTenDichVu.Name = "cmbTenDichVu";
            this.cmbTenDichVu.Size = new System.Drawing.Size(305, 21);
            this.cmbTenDichVu.TabIndex = 7;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(6, 101);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(466, 353);
            this.dgvDichVu.TabIndex = 1;
            // 
            // dgvGiaDichVu
            // 
            this.dgvGiaDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaDichVu.Location = new System.Drawing.Point(6, 124);
            this.dgvGiaDichVu.Name = "dgvGiaDichVu";
            this.dgvGiaDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaDichVu.Size = new System.Drawing.Size(483, 330);
            this.dgvGiaDichVu.TabIndex = 7;
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
            this.grDichVu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grDichVu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTenDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaGia;
        private System.Windows.Forms.Button btnSuaGia;
        private System.Windows.Forms.Button btnThemGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaDichVu;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridView dgvGiaDichVu;
    }
}