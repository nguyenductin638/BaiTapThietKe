using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKe
{
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void txtNghiaCuaTu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghiaCuaTu.Text;
            lbxDSTuMoi.Items.Add(tu);
            list.Add(nghia);
            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghiaCuaTu.Text = "";
            lbxDSTuMoi.SelectedIndex = lbxDSTuMoi.Items.Count - 1;
            txtHienThiNghia.Text = nghia;
        }

        private void lbxDSTuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt =lbxDSTuMoi.SelectedIndex;
            txtHienThiNghia.Text = list[stt];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
