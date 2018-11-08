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
using System.Text.RegularExpressions;

namespace QLThuVien
{
    public partial class frmDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmDocGia()
        {
            InitializeComponent();
        }
        private string strSQL = "";
        private DataSet ds = null;
        private object t = null;
        private object m = new object();

        private void displayData()
        {
            strSQL = @"EXEC SelectAllDocGia";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            dgvDG.DataSource = ds.Tables[0];

        }
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            //load dữ liệu cho cbx mã độc giả và girdview
            strSQL = @"EXEC SelectAllDocGia";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxMaDG.DataSource = ds.Tables[0];
            cbxMaDG.DisplayMember = "Mã độc giả";
            cbxMaDG.ValueMember = "Mã độc giả";
            dgvDG.DataSource = ds.Tables[0];

            //load dữ liệu cho cbx loại độc giả
            strSQL = @"select * from LOAIDOCGIA";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxLoai.DataSource = ds.Tables[0];
            cbxLoai.DisplayMember = "LoaiDG";
            cbxLoai.ValueMember = "MaDG";

            //load dữ liệu cho cbx nhân viên
            strSQL = @"select * from NHANVIEN where BoPhan ='BP1'";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxNVLap.DataSource = ds.Tables[0];
            cbxNVLap.DisplayMember = "HoTen";
            cbxNVLap.ValueMember = "MaNV";

            //load dữ liệu ban đầu cho girdview
            cbxMaDG.Text = dgvDG[0,0].Value.ToString();
            txtHoten.Text = dgvDG[1, 0].Value.ToString();
            dtNgaySinh.Text = dgvDG[2, 0].Value.ToString();
            txtDiachi.Text = dgvDG[3, 0].Value.ToString();
            txtEmail.Text = dgvDG[4, 0].Value.ToString();
            dtNgayLap.Text = dgvDG[6, 0].Value.ToString();
            cbxLoai.SelectedValue = dgvDG[5, 0].Value.ToString();
            cbxNVLap.SelectedValue = dgvDG[7, 0].Value.ToString();
        }

        private void dgvDG_MouseClick(object sender, MouseEventArgs e)
        {
            cbxMaDG.Text = dgvDG.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvDG.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvDG.CurrentRow.Cells[2].Value.ToString();
            txtDiachi.Text = dgvDG.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvDG.CurrentRow.Cells[4].Value.ToString();
            dtNgayLap.Text = dgvDG.CurrentRow.Cells[6].Value.ToString();
            cbxLoai.SelectedValue = dgvDG.CurrentRow.Cells[5].Value.ToString();
            cbxNVLap.SelectedValue = dgvDG.CurrentRow.Cells[7].Value.ToString();
            btLuu.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            strSQL = @"select * from CTMUONSACH where MaDG='" + cbxMaDG.Text + "'";
            m = DataConnection.RunsqlScalar(strSQL);
            if (m != null)
                MessageBox.Show("Độc Giả chưa trả hết sách.");
            else
            {

                DialogResult result = MessageBox.Show("Bạn Muốn xóa Độc Giả có mã là " + cbxMaDG.Text + " phải không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    strSQL = @"select MaSach from THONGKEMUONSACH,MUONSACH where MaDG='" + cbxMaDG.Text + "' and MaPM=MaPhieuMuon";
                    m = DataConnection.RunsqlScalar(strSQL);
                    if (m != null)
                    {
                        strSQL = @"delete from THONGKEMUONSACH where MaPM =( select MaPhieumuon from MUONSACH where MaDG='" + cbxMaDG.Text + "')";
                        t = DataConnection.RunsqlQuery(strSQL);

                        strSQL = @"delete from MUONSACH where MaDG ='" + cbxMaDG.Text + "'";
                        t = DataConnection.RunsqlQuery(strSQL);
                    }

                    strSQL = @"delete from DOCGIA where MaDG ='" + cbxMaDG.Text + "'";
                    t = DataConnection.RunsqlQuery(strSQL);
                    displayData();
                }
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (cbxMaDG.Text == "" || txtHoten.Text == "")
                MessageBox.Show("Bạn hãy nhập đủ thông tin.");
            else
            {
                if (isValidEmail(txtEmail.Text))
                {
                    string bc, bp, d, dt;
                    bc = cbxLoai.SelectedValue.ToString();
                    bp = cbxNVLap.SelectedValue.ToString();
                    d = dtNgaySinh.Value.ToString("yyyy/MM/dd");
                    dt = dtNgayLap.Value.ToString("yyyy/MM/dd");

                    strSQL = @"insert into DOCGIA values ('" + cbxMaDG.Text + "',N'" + txtHoten.Text + "','" + d + "',N'" + txtDiachi.Text + "','" + txtEmail.Text + "','" + bc + "','" + dt + "','" + bp + "')";
                    t = DataConnection.RunsqlQuery(strSQL);
                    displayData();
                    MessageBox.Show("Lập thẻ thành công!");
                }
                else
                    MessageBox.Show("Email không hợp lệ!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(isValidEmail(txtEmail.Text))
            {
                string nl, nv;
                nl = cbxLoai.SelectedValue.ToString();
                nv = cbxNVLap.SelectedValue.ToString();

                strSQL = @"update DOCGIA set HoTen=N'" + txtHoten.Text + "', NgaySinh='" + dtNgaySinh.Value.ToString("yyyy/MM/dd") + "', DiaChi=N'"
                    + txtDiachi.Text + "', Email='" + txtEmail.Text + "', LoaiDG='" + nl + "', NgayLap='" + dtNgayLap.Value.ToString("yyyy/MM/dd")
                    + "', NVLap='" + nv + "' where MaDG='" + cbxMaDG.Text + "'";
                t = DataConnection.RunsqlQuery(strSQL);
                displayData();
                MessageBox.Show("Cập nhật thành công!");
            }
            else
                MessageBox.Show("Email không hợp lệ!");

        }

        private void btLapthe_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtHoten.Text = "";
            cbxLoai.SelectedIndex = -1;
            cbxMaDG.Text = "";
            cbxNVLap.SelectedIndex = -1;
            
        }

        



        private void dgvDG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbxMaDG.Text = dgvDG.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvDG.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvDG.CurrentRow.Cells[2].Value.ToString();
            txtDiachi.Text = dgvDG.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvDG.CurrentRow.Cells[4].Value.ToString();
            dtNgayLap.Text = dgvDG.CurrentRow.Cells[6].Value.ToString();
            cbxLoai.SelectedValue = dgvDG.CurrentRow.Cells[5].Value.ToString();
            cbxNVLap.SelectedValue = dgvDG.CurrentRow.Cells[7].Value.ToString();
            btLuu.Enabled = false;
        }

        //kiểm tra gmail
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
}