﻿namespace BaiTapThietKe
{
    partial class frmBai3
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
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNghiaCuaTu = new System.Windows.Forms.TextBox();
            this.btnThemTu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxDSTuMoi = new System.Windows.Forms.ListBox();
            this.txtHienThiNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nghĩa của từ:";
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(162, 43);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(141, 20);
            this.txtTuMoi.TabIndex = 0;
            // 
            // txtNghiaCuaTu
            // 
            this.txtNghiaCuaTu.Location = new System.Drawing.Point(162, 83);
            this.txtNghiaCuaTu.Name = "txtNghiaCuaTu";
            this.txtNghiaCuaTu.Size = new System.Drawing.Size(141, 20);
            this.txtNghiaCuaTu.TabIndex = 1;
            this.txtNghiaCuaTu.TextChanged += new System.EventHandler(this.txtNghiaCuaTu_TextChanged);
            // 
            // btnThemTu
            // 
            this.btnThemTu.Location = new System.Drawing.Point(185, 120);
            this.btnThemTu.Name = "btnThemTu";
            this.btnThemTu.Size = new System.Drawing.Size(75, 23);
            this.btnThemTu.TabIndex = 2;
            this.btnThemTu.Text = "Thêm từ mới";
            this.btnThemTu.UseVisualStyleBackColor = true;
            this.btnThemTu.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH TỪ MỚI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "NGHĨA CỦA TỪ";
            // 
            // lbxDSTuMoi
            // 
            this.lbxDSTuMoi.FormattingEnabled = true;
            this.lbxDSTuMoi.Location = new System.Drawing.Point(69, 182);
            this.lbxDSTuMoi.Name = "lbxDSTuMoi";
            this.lbxDSTuMoi.Size = new System.Drawing.Size(145, 95);
            this.lbxDSTuMoi.TabIndex = 3;
            this.lbxDSTuMoi.SelectedIndexChanged += new System.EventHandler(this.lbxDSTuMoi_SelectedIndexChanged);
            // 
            // txtHienThiNghia
            // 
            this.txtHienThiNghia.Location = new System.Drawing.Point(259, 182);
            this.txtHienThiNghia.Multiline = true;
            this.txtHienThiNghia.Name = "txtHienThiNghia";
            this.txtHienThiNghia.ReadOnly = true;
            this.txtHienThiNghia.Size = new System.Drawing.Size(146, 95);
            this.txtHienThiNghia.TabIndex = 4;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHienThiNghia);
            this.Controls.Add(this.lbxDSTuMoi);
            this.Controls.Add(this.btnThemTu);
            this.Controls.Add(this.txtNghiaCuaTu);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Từ điển Anh - Việt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNghiaCuaTu;
        private System.Windows.Forms.Button btnThemTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxDSTuMoi;
        private System.Windows.Forms.TextBox txtHienThiNghia;
    }
}