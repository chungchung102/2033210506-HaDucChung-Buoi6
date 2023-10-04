using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2033210506_HaDucChung_Buoi6
{
    public partial class frmBaiTap2 : Form
    {
        public frmBaiTap2()
        {
            InitializeComponent();
        }

        private void frmBaiTap2_Load(object sender, EventArgs e)
        {
            string[] ds = { "coc", "oi", "xoai", "me", "buoi", "cam" };
            foreach(string s in ds)
            {
                listBox1.Items.Add(s);
            }
        }
        private void SangPhai()
        {
            if (listBox1.SelectedItem != null)
            {
                // Lấy mục được chọn từ ListBox trái
                string selectedItem = listBox1.SelectedItem.ToString();

                // Thêm mục vào ListBox phải
               listBox2.Items.Add(selectedItem);

                // Xóa mục đã chọn khỏi ListBox trái
                listBox1.Items.Remove(selectedItem);
            }
        }
        private void SangTrai()
        {
            if (listBox2.SelectedItem != null)
            {
                // Lấy mục được chọn từ ListBox phai
                string selectedItem = listBox2.SelectedItem.ToString();

                // Thêm mục vào ListBox trai
                listBox1.Items.Add(selectedItem);

                // Xóa mục đã chọn khỏi ListBox phai
                listBox2.Items.Remove(selectedItem);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SangPhai();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SangTrai();
        }
        private void button4_Click(object sender, EventArgs e)
        {

            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }
    }
}
