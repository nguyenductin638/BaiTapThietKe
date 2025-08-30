﻿using System;
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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSo.Text);
            lbKetQua.Text = "Không tìm thấy";
            foreach (int so in listBox1.Items)
            {
                if (soCanTim == so)
                {
                    lbKetQua.Text = "Tìm thấy";
                    break;
                }                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int so;
            for(int i = 0; i <= 10; i++)
            {
                so = random.Next(1, 100);
                listBox1.Items.Add(so);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
