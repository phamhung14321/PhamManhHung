using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp5
{
    public partial class NhanVien : Form
    {
        private Form2 form2;

        private bool isEditing = false;
        public string MSNV { get; private set; }
        public string HoTen { get; private set; }
        public string LuongCB { get; private set; }
        
        public NhanVien()
        {
            InitializeComponent();
            form2 = new Form2();
        }
        public NhanVien(Form2 form2)
        {
            InitializeComponent();            
            this.form2 = form2;

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public NhanVien(string MSNV, string HoTen, string LuongCB, Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
            txtMSNV.Text = MSNV;
            txtHoTen.Text = HoTen;
            txtLuongCB.Text = LuongCB;
            isEditing = true;
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            MSNV = txtMSNV.Text;
            HoTen = txtHoTen.Text;
            LuongCB = txtLuongCB.Text;
            if (string.IsNullOrWhiteSpace(MSNV) || MSNV.Length < 10)
            {
                MessageBox.Show("Mã số nhân viên phải có ít nhất 10 ký tự và không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(HoTen) || HoTen.Length > 50)
            {
                MessageBox.Show(" Số ký tự tối đa là 50 và không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(LuongCB, out decimal luong) || luong < 0)
            {
                MessageBox.Show("Lương cơ bản phải lơn hơn 0 và không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isEditing)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                form2.AddRowToDataGridView(MSNV, HoTen, LuongCB);
                this.DialogResult = DialogResult.OK;
            }
            form2.Show();


        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

      
    }

