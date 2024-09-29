namespace WindowsFormsApp5
{
    partial class NhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lương cơ bản";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(535, 108);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(540, 38);
            this.txtMSNV.TabIndex = 1;
            this.txtMSNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(535, 255);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(540, 38);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(535, 381);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(540, 38);
            this.txtLuongCB.TabIndex = 1;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(404, 556);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(194, 92);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(881, 556);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(194, 92);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2091, 833);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhanVien";
            this.Text = "Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnDong;
    }
}

