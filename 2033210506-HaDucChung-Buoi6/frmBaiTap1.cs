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
    public partial class frmBaiTap1 : Form
    {
        private List<string> students;
        public frmBaiTap1()
        {
            InitializeComponent();
            students = new List<string>();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

        }
    }
}
