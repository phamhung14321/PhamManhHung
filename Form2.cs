using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public void CapNhatDongDaChon(string MSNV, string HoTen, string LuongCB)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                dgvNV.SelectedRows[0].Cells[0].Value = MSNV;
                dgvNV.SelectedRows[0].Cells[1].Value = HoTen;
                dgvNV.SelectedRows[0].Cells[2].Value = LuongCB;
            }
        }

        
        public void AddRowToDataGridView(string MSNV, string HoTen, string LuongCB)
        {
            dgvNV.Rows.Add(MSNV, HoTen, LuongCB);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVienForm = new NhanVien(this);
            nhanVienForm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                var selectedRow = dgvNV.SelectedRows[0];

                string MSNV = selectedRow.Cells[0].Value.ToString();
                string HoTen = selectedRow.Cells[1].Value.ToString();
                string LuongCB = selectedRow.Cells[2].Value.ToString();
                NhanVien nhanVienForm = new NhanVien(MSNV, HoTen, LuongCB, this);
                if (nhanVienForm.ShowDialog() == DialogResult.OK) 
                {
                    selectedRow.Cells[0].Value = nhanVienForm.MSNV;
                    selectedRow.Cells[1].Value = nhanVienForm.HoTen;
                    selectedRow.Cells[2].Value = nhanVienForm.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgvNV.Rows.Remove(dgvNV.SelectedRows[0]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
