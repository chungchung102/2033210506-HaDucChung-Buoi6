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
    public partial class frmBaiTap4 : Form
    {
        public frmBaiTap4()
        {
            InitializeComponent();
        }

        private void frmBaiTap4_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giam doc", "To chuc hanh chinh", "Ke hoach", "Ke toan" };
            foreach (string s in pb)
            {
                trv_DS.Nodes.Add(s);
                cbo_phongban.Items.Add(s);

            }
            cbo_phongban.SelectedIndex = 0;
        }
        public bool kiemTra(string s)
        {
            foreach (TreeNode kt in trv_DS.Nodes)
                if (kt.Text == s)
                    return false;
            return true;
        }
        private void btn_ThemPb_Click(object sender, EventArgs e)
        {
            if (kiemTra(txt_phongBan.Text))
            {
                trv_DS.Nodes.Add(txt_phongBan.Text);
                cbo_phongban.Items.Add(txt_phongBan.Text);

            }
            else
                MessageBox.Show("phong ban da ton tai");
            txt_phongBan.Text = "";
            txt_phongBan.Focus();


        }

        private void btn_XoaPb_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ban co chac muon xoa","thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if(trv_DS.SelectedNode!=null)
                {
                    cbo_phongban.Items.Remove(trv_DS.SelectedNode.Text);
                    trv_DS.Nodes.Remove(trv_DS.SelectedNode);
                }
            }

        }

        private void btn_ThemNv_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (TreeNode node in trv_DS.Nodes)
            {
                if(node.Text==cbo_phongban.Text)
                {
                    index = node.Index;
                    break;
                }
            }
            trv_DS.Nodes[index].Nodes.Add(txt_hoTen.Text + "(" + txt_maSo.Text+")");
            trv_DS.ExpandAll();
        }
    }
}

