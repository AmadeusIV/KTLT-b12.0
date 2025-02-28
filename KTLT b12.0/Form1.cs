using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTLT_b12._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

      

        private void buttonDatHang_Click(object sender, EventArgs e)
        {
            string khachHang = txtBox1.Text;
            string dienThoai = txtBox2.Text;

            if (string.IsNullOrWhiteSpace(khachHang) || string.IsNullOrWhiteSpace(dienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Khách hàng và Điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listBoxDanSachSanPham.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để đặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBoxTTDH.Items.Add("Khách hàng: " + khachHang);
            listBoxTTDH.Items.Add("Số điện thoại: " + dienThoai);
            listBoxTTDH.Items.Add("Sản phẩm đặt mua: ");

            foreach (var item in listBoxDanSachSanPham.SelectedItems)
            {
                listBoxTTDH.Items.Add("- " + item.ToString());
            }
        }

        private void listBoxDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
