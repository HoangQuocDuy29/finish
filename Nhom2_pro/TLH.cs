﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_pro
{
    public partial class TLH : Form
    {
        public TLH()
        {
            InitializeComponent();
            ketnoi(); // Gọi hàm kết nối
           
            
        }
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter sqlda;
        public void ketnoi()
        {
            string ketnoi;
            ketnoi = "Data Source=HOANG-QUOC-DUY;Initial Catalog=QuanLySinhVien;Integrated Security=True;";
            conn = new SqlConnection(ketnoi);
            conn.Open();
        }
        private void LoadComboBoxData()
        {
            ketnoi();

            // Load danh sách môn học
            SqlCommand cmdMonHoc = new SqlCommand("SELECT MaMonHoc, TenMon FROM MonHoc WHERE DaXoa = 0", conn);
            SqlDataAdapter daMonHoc = new SqlDataAdapter(cmdMonHoc);
            DataTable dtMonHoc = new DataTable();
            daMonHoc.Fill(dtMonHoc);
            cbMonHoc.DataSource = dtMonHoc;
            cbMonHoc.DisplayMember = "TenMon";
            cbMonHoc.ValueMember = "MaMonHoc";

            // Load danh sách học kỳ
            SqlCommand cmdHocKy = new SqlCommand("SELECT MaHocKy, TenHocKy FROM HocKy WHERE DaXoa = 0", conn);
            SqlDataAdapter daHocKy = new SqlDataAdapter(cmdHocKy);
            DataTable dtHocKy = new DataTable();
            daHocKy.Fill(dtHocKy);
            cbHocKy.DataSource = dtHocKy;
            cbHocKy.DisplayMember = "TenHocKy";
            cbHocKy.ValueMember = "MaHocKy";

            conn.Close();
        }
        private void LoadDanhSachLop()
        {
            ketnoi();
            SqlCommand command = new SqlCommand(
                "SELECT LopHoc.MaLop, MonHoc.MaMonHoc, MonHoc.TenMon, LopHoc.TenLop, LopHoc.SoLuongSV, HocKy.MaHocKy, HocKy.TenHocKy " +
                "FROM LopHoc " +
                "JOIN MonHoc ON LopHoc.MaMonHoc = MonHoc.MaMonHoc " +
                "JOIN HocKy ON LopHoc.MaHocKy = HocKy.MaHocKy " +
                "WHERE LopHoc.DaXoa = 0", conn);

            sqlda = new SqlDataAdapter(command);
            ds = new DataSet();
            sqlda.Fill(ds, "LopHoc");

            dgvDanhSachLop.DataSource = ds.Tables["LopHoc"];
            conn.Close();
        }

        private void TLH_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadDanhSachLop();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (cbMonHoc.SelectedValue == null || string.IsNullOrWhiteSpace(txt_TenLop.Text) || string.IsNullOrWhiteSpace(txt_SoSV.Text))
            {
                MessageBox.Show("Vui lòng chọn môn học, nhập tên lớp và số sinh viên.");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm lớp học này không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                ketnoi();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO LopHoc (MaLop, MaMonHoc, MaHocKy, TenLop, SoLuongSV, DaXoa) " +
                    "VALUES (@MaLop, @MaMonHoc, @MaHocKy, @TenLop, @SoLuongSV, 0)", conn);

                cmd.Parameters.AddWithValue("@MaLop", txtMaLH.Text);
                cmd.Parameters.AddWithValue("@MaMonHoc", cbMonHoc.SelectedValue);
                cmd.Parameters.AddWithValue("@MaHocKy", cbHocKy.SelectedValue);
                cmd.Parameters.AddWithValue("@TenLop", txt_TenLop.Text);
                cmd.Parameters.AddWithValue("@SoLuongSV", txt_SoSV.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm lớp học thành công!");

                LoadDanhSachLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btThoay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                
                return; 
            }
            this.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLH.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa");
                return;
            }
            if (!ValidateInput()) return;

            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa lớp học này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            try
            {
                ketnoi();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE LopHoc SET MaMonHoc = @MaMonHoc, MaHocKy = @MaHocKy, TenLop = @TenLop, SoLuongSV = @SoLuongSV " +
                    "WHERE MaLop = @MaLop AND DaXoa = 0", conn);

                cmd.Parameters.AddWithValue("@MaLop", txtMaLH.Text);
                cmd.Parameters.AddWithValue("@MaMonHoc", cbMonHoc.SelectedValue);
                cmd.Parameters.AddWithValue("@MaHocKy", cbHocKy.SelectedValue);
                cmd.Parameters.AddWithValue("@TenLop", txt_TenLop.Text);
                cmd.Parameters.AddWithValue("@SoLuongSV", txt_SoSV.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin lớp học thành công!");

                LoadDanhSachLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLH.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa.");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lớp học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                ketnoi();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE LopHoc SET DaXoa = 1 WHERE MaLop = @MaLop", conn);

                cmd.Parameters.AddWithValue("@MaLop", txtMaLH.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa lớp học thành công!");

                LoadDanhSachLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvDanhSachLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDanhSachLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachLop.Rows[e.RowIndex];

                // Gán giá trị cho các TextBox và ComboBox
                txtMaLH.Text = row.Cells["MaLop"].Value.ToString();
                txt_TenLop.Text = row.Cells["TenLop"].Value.ToString();
                txt_SoSV.Text = row.Cells["SoLuongSV"].Value.ToString();

                // Kiểm tra và gán giá trị cho ComboBox
                if (row.Cells["MaMonHoc"].Value != null)
                {
                    cbMonHoc.SelectedValue = row.Cells["MaMonHoc"].Value;
                }

                if (row.Cells["MaHocKy"].Value != null)
                {
                    cbHocKy.SelectedValue = row.Cells["MaHocKy"].Value;
                }
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txt_TenLop.Text))
            {
                MessageBox.Show("Tên lớp không được để trống.");
                txt_TenLop.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_SoSV.Text) || !int.TryParse(txt_SoSV.Text, out int soSinhVien))
            {
                MessageBox.Show("Số sinh viên phải là một số nguyên hợp lệ.");
                txt_SoSV.Focus();
                return false;
            }

            if (soSinhVien > 60)
            {
                MessageBox.Show("Số sinh viên không được vượt quá 60.");
                txt_SoSV.Focus();
                return false;
            }

            if (cbMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn môn học.");
                cbMonHoc.Focus();
                return false;
            }

            return true;
        }

        private void dgvDanhSachLop_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lbl_Tieude_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachLop_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
