using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLThuVien
{
    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {
        public frmSach()
        {
            InitializeComponent();
        }
        private string strSQL = "";
        private DataSet ds = null;
        private object t = null;
        private object m = new object();

        private void displayData()
        {
            strSQL = @"EXEC SelectAllSach";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            dgvSach.DataSource = ds.Tables[0];

        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            if (Form1.boPhan != "BP2")
            {
                btNhap.Enabled = false;
                btLuu.Enabled = false;
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }

            //load dữ liệu cho cbx mã sách và girdview
            strSQL = @"EXEC SelectAllSach";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxMaSach.DataSource = ds.Tables[0];
            cbxMaSach.DisplayMember = "Mã Sách";
            cbxMaSach.ValueMember = "Mã Sách";
            dgvSach.DataSource = ds.Tables[0];

            //load dữ liệu cho cbx nhân viên
            strSQL = @"select * from NHANVIEN where BoPhan ='BP2'";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxNVNhan.DataSource = ds.Tables[0];
            cbxNVNhan.DisplayMember = "HoTen";
            cbxNVNhan.ValueMember = "MaNV";

            //load dữ liệu ban đầu cho các textbox
            cbxMaSach.Text = dgvSach[0, 0].Value.ToString();
            txtTen.Text = dgvSach[1, 0].Value.ToString();
            txtTacgia.Text = dgvSach[2, 0].Value.ToString();
            txtNamXB.Text = dgvSach[3, 0].Value.ToString();
            txtNXB.Text = dgvSach[4, 0].Value.ToString();
            dtNgaynhap.Text = dgvSach[5, 0].Value.ToString();
            txtTrigia.Text = dgvSach[6, 0].Value.ToString();
            cbxNVNhan.SelectedValue = dgvSach[7, 0].Value.ToString();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            txtNamXB.Text = "";
            txtNXB.Text = "";
            txtTacgia.Text = "";
            txtTen.Text = "";
            txtTrigia.Text = "";
            cbxMaSach.Text = "";
            cbxNVNhan.Text = "";
            btLuu.Enabled = true;
            strSQL = @"select MaNV from NHANVIEN where Account = N'" + Form1.user + "'";
            cbxNVNhan.SelectedValue = DataConnection.RunsqlScalar(strSQL);
        }

        private void dgvSach_MouseClick(object sender, MouseEventArgs e)
        {
            cbxMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvSach.CurrentRow.Cells[1].Value.ToString();
            txtTacgia.Text = dgvSach.CurrentRow.Cells[2].Value.ToString();
            txtNamXB.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
            txtNXB.Text = dgvSach.CurrentRow.Cells[4].Value.ToString();
            dtNgaynhap.Text = dgvSach.CurrentRow.Cells[5].Value.ToString();
            txtTrigia.Text = dgvSach.CurrentRow.Cells[6].Value.ToString();
            cbxNVNhan.SelectedValue = dgvSach.CurrentRow.Cells[7].Value.ToString();
            btLuu.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            strSQL = @"select MaPM from CTMUONSACH where SachMuon='" + cbxMaSach.Text + "'";
            m = DataConnection.RunsqlScalar(strSQL);
            if (m != null)
                MessageBox.Show("Sách còn đang mượn.");
            else
            {
                DialogResult result = MessageBox.Show("Bạn Muốn xóa cuốn sách có mã là " + cbxMaSach.Text + " phải không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    strSQL = @"EXEC dbo.XoaSach @maSach = '" + cbxMaSach.Text + "'";
                    string tt = (string)DataConnection.RunsqlScalar(strSQL);
                    MessageBox.Show(tt);
                    displayData();
                }
            }
        }

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNamXB.MaxLength = 4;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTrigia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string nv;
            nv = cbxNVNhan.SelectedValue.ToString();

            strSQL = @"update Sach set TenSach=N'" + txtTen.Text + "', NamXB='" + txtNamXB.Text + "', TacGia=N'" + txtTacgia.Text
                + "', NhaXB=N'" + txtNXB.Text + "', NgayNhap='" + dtNgaynhap.Value.ToString("yyyy/MM/dd") + "', TriGia='" + txtTrigia.Text
                + "', NVTiepNhan='" + nv + "' where MaSach='" + cbxMaSach.Text + "'";
            t = DataConnection.RunsqlQuery(strSQL);
            displayData();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (cbxMaSach.Text == "" || txtTrigia.Text == "" || txtNamXB.Text == "" || txtTen.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin.");
            if (int.Parse(txtNamXB.Text) > 2017 || int.Parse(txtNamXB.Text) < 2009)
                MessageBox.Show("Năm xuất bản không hợp lệ.");
            else
            {
                string bp, d;
                bp = cbxNVNhan.SelectedValue.ToString();
                d = dtNgaynhap.Value.ToString("yyyy/MM/dd");

                strSQL = @"insert into SACH values ('" + cbxMaSach.Text + "',N'" + txtTen.Text + "',N'" + txtTacgia.Text + "','" + txtNamXB.Text + "',N'" + txtNXB.Text + "','" + d + "','" + txtTrigia.Text + "','" + bp + "')";
                t = DataConnection.RunsqlQuery(strSQL);
                displayData();
            }
        }

        private void dgvSach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbxMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvSach.CurrentRow.Cells[1].Value.ToString();
            txtTacgia.Text = dgvSach.CurrentRow.Cells[2].Value.ToString();
            txtNamXB.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
            txtNXB.Text = dgvSach.CurrentRow.Cells[4].Value.ToString();
            dtNgaynhap.Text = dgvSach.CurrentRow.Cells[5].Value.ToString();
            txtTrigia.Text = dgvSach.CurrentRow.Cells[6].Value.ToString();
            cbxNVNhan.SelectedValue = dgvSach.CurrentRow.Cells[7].Value.ToString();
            btLuu.Enabled = false;
        }
    }
}