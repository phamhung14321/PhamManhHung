namespace WindowsFormsApp5
{
    partial class Form2
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
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.MSVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSVN,
            this.HoTen,
            this.LuongCB});
            this.dgvNV.Location = new System.Drawing.Point(92, 144);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 102;
            this.dgvNV.RowTemplate.Height = 40;
            this.dgvNV.Size = new System.Drawing.Size(2012, 577);
            this.dgvNV.TabIndex = 0;
            // 
            // MSVN
            // 
            this.MSVN.HeaderText = "MSNV";
            this.MSVN.MinimumWidth = 12;
            this.MSVN.Name = "MSVN";
            this.MSVN.Width = 250;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 12;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 250;
            // 
            // LuongCB
            // 
            this.LuongCB.HeaderText = "Lương cơ bản";
            this.LuongCB.MinimumWidth = 12;
            this.LuongCB.Name = "LuongCB";
            this.LuongCB.Width = 250;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(2136, 144);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(182, 79);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(2136, 298);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(182, 79);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(2136, 448);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(182, 79);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(2136, 622);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(182, 79);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3006, 918);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNV);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}