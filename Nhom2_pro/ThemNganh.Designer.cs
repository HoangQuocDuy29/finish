﻿namespace Nhom2_pro
{
    partial class ThemNganh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmanganh = new System.Windows.Forms.TextBox();
            this.txttennganh = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnnganhhientai = new System.Windows.Forms.Button();
            this.btnnganhdaxoa = new System.Windows.Forms.Button();
            this.btnkhoiphucnganh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndssv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYÊN NGÀNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Ngành";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btndssv);
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.btnkhoiphucnganh);
            this.panel2.Controls.Add(this.btnnganhdaxoa);
            this.panel2.Controls.Add(this.btnnganhhientai);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.txttennganh);
            this.panel2.Controls.Add(this.txtmanganh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 170);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtmanganh
            // 
            this.txtmanganh.Location = new System.Drawing.Point(107, 11);
            this.txtmanganh.Name = "txtmanganh";
            this.txtmanganh.Size = new System.Drawing.Size(158, 22);
            this.txtmanganh.TabIndex = 5;
            this.txtmanganh.TextChanged += new System.EventHandler(this.txtmanganh_TextChanged);
            // 
            // txttennganh
            // 
            this.txttennganh.Location = new System.Drawing.Point(107, 59);
            this.txttennganh.Name = "txttennganh";
            this.txttennganh.Size = new System.Drawing.Size(158, 22);
            this.txttennganh.TabIndex = 6;
            this.txttennganh.TextChanged += new System.EventHandler(this.txttennganh_TextChanged);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(17, 113);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(82, 41);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(125, 113);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(76, 41);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(235, 113);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 41);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnnganhhientai
            // 
            this.btnnganhhientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnganhhientai.Location = new System.Drawing.Point(357, 11);
            this.btnnganhhientai.Name = "btnnganhhientai";
            this.btnnganhhientai.Size = new System.Drawing.Size(159, 34);
            this.btnnganhhientai.TabIndex = 10;
            this.btnnganhhientai.Text = "Ngành Hiện Tại";
            this.btnnganhhientai.UseVisualStyleBackColor = true;
            this.btnnganhhientai.Click += new System.EventHandler(this.btnnganhhientai_Click);
            // 
            // btnnganhdaxoa
            // 
            this.btnnganhdaxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnganhdaxoa.Location = new System.Drawing.Point(550, 11);
            this.btnnganhdaxoa.Name = "btnnganhdaxoa";
            this.btnnganhdaxoa.Size = new System.Drawing.Size(159, 34);
            this.btnnganhdaxoa.TabIndex = 11;
            this.btnnganhdaxoa.Text = "Ngành Đã Xoá";
            this.btnnganhdaxoa.UseVisualStyleBackColor = true;
            this.btnnganhdaxoa.Click += new System.EventHandler(this.btnnganhdaxoa_Click);
            // 
            // btnkhoiphucnganh
            // 
            this.btnkhoiphucnganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhoiphucnganh.Location = new System.Drawing.Point(357, 65);
            this.btnkhoiphucnganh.Name = "btnkhoiphucnganh";
            this.btnkhoiphucnganh.Size = new System.Drawing.Size(159, 34);
            this.btnkhoiphucnganh.TabIndex = 12;
            this.btnkhoiphucnganh.Text = "Khôi Phục Ngành";
            this.btnkhoiphucnganh.UseVisualStyleBackColor = true;
            this.btnkhoiphucnganh.Click += new System.EventHandler(this.btnkhoiphucnganh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 228);
            this.panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(550, 65);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(159, 34);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndssv
            // 
            this.btndssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndssv.Location = new System.Drawing.Point(357, 113);
            this.btndssv.Name = "btndssv";
            this.btndssv.Size = new System.Drawing.Size(159, 34);
            this.btndssv.TabIndex = 14;
            this.btndssv.Text = "Danh Sách Sinh Viên";
            this.btndssv.UseVisualStyleBackColor = true;
            this.btndssv.Click += new System.EventHandler(this.btndssv_Click);
            // 
            // ThemNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThemNganh";
            this.Text = "ThemNganh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttennganh;
        private System.Windows.Forms.TextBox txtmanganh;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnkhoiphucnganh;
        private System.Windows.Forms.Button btnnganhdaxoa;
        private System.Windows.Forms.Button btnnganhhientai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndssv;
    }
}