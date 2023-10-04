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
    public partial class frmBaiTap3 : Form
    {
        public frmBaiTap3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dt = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khac" };
            foreach (string s in dt)
            {
                comboBox1.Items.Add(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "Dan toc duoc chon: ";
            if (comboBox1.SelectedIndex >= 0)
                label2.Text = s+comboBox1.SelectedItem.ToString() ;
            else
                label2.Text = "ban chua chon dan toc";
        }

        
    }
}
