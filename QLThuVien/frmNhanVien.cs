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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private string strSQL = "";
        private DataSet ds = null;
        private object t = null;
        private object m = new object();

        private void displayData()
        {
            strSQL = @"EXEC SelectAllNhanVien";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            dgvNhanVien.DataSource = ds.Tables[0];

        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //load dữ liệu cho cbx nhân viên và gridview
            strSQL = @"EXEC SelectAllNhanVien";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxMaNV.DataSource = ds.Tables[0];
            cbxMaNV.DisplayMember = "Mã Nhân Viên";
            cbxMaNV.ValueMember = "Mã Nhân Viên";
            dgvNhanVien.DataSource = ds.Tables[0];

            //load dữ liệu cho cbx bằng cấp
            strSQL = @"select * from BANGCAP";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxBangcap.DataSource = ds.Tables[0];
            cbxBangcap.DisplayMember = "TenBC";
            cbxBangcap.ValueMember = "MaBC";

            //load dữ liệu cho cbx chức vụ
            strSQL = @"select * from CHUCVU";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxChucvu.DataSource = ds.Tables[0];
            cbxChucvu.DisplayMember = "TenCV";
            cbxChucvu.ValueMember = "MaCV";

            //load dữ liệu cho cbx bộ phận
            strSQL = @"select * from BOPHAN";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxBophan.DataSource = ds.Tables[0];
            cbxBophan.DisplayMember = "TenBP";
            cbxBophan.ValueMember = "MaBP";

            //load dữ liệu ban đầu
            cbxMaNV.Text = dgvNhanVien[0, 0].Value.ToString();
            txtHoten.Text = dgvNhanVien[1, 0].Value.ToString();
            dtNgaySinh.Text = dgvNhanVien[2, 0].Value.ToString();
            txtDiachi.Text = dgvNhanVien[3, 0].Value.ToString();
            txtEmail.Text = dgvNhanVien[4, 0].Value.ToString();
            txtDienthai.Text = dgvNhanVien[5, 0].Value.ToString();
            txtAccount.Text = dgvNhanVien[9, 0].Value.ToString();
            txtPass.Text = dgvNhanVien[10, 0].Value.ToString();
            cbxBangcap.SelectedValue = dgvNhanVien[6, 0].Value.ToString();
            cbxBophan.SelectedValue = dgvNhanVien[7, 0].Value.ToString();
            cbxChucvu.SelectedValue = dgvNhanVien[8, 0].Value.ToString();
        }

        private void dgvNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            cbxMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtDiachi.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtDienthai.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtAccount.Text = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
            txtPass.Text = dgvNhanVien.CurrentRow.Cells[10].Value.ToString();
            cbxBangcap.SelectedValue = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            cbxBophan.SelectedValue = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            cbxChucvu.SelectedValue = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
            btLuu.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn xóa Nhân Viên có mã là " + cbxMaNV.Text + " phải không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                strSQL = @"delete from NHANVIEN where MaNV ='" + cbxMaNV.Text + "'";
                t = DataConnection.RunsqlQuery(strSQL);
                displayData();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (cbxMaNV.Text == "" || txtHoten.Text == "")
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin.");
            else
            {
                if (isValidEmail(txtEmail.Text))
                {
                    string bc, bp, cv, d;
                bp = cbxBophan.SelectedValue.ToString();
                bc = cbxBangcap.SelectedValue.ToString();
                cv = cbxChucvu.SelectedValue.ToString();
                d = dtNgaySinh.Value.ToString("yyyy/MM/dd");

                strSQL = @"insert into NHANVIEN values ('" + cbxMaNV.Text + "',N'" + txtHoten.Text + "','" + d + "',N'" + txtDiachi.Text + "','" + txtEmail.Text + "','" + txtDienthai.Text + "','" + bc + "','" + bp + "','" + cv + "','" + txtAccount.Text + "','" + txtPass.Text + "')";
                t = DataConnection.RunsqlQuery(strSQL);
                displayData();
                    MessageBox.Show("Lưu thành công!");
                }
                else
                    MessageBox.Show("Email không hợp lệ!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (isValidEmail(txtEmail.Text))
            {
                string bc, bp, cv;
                bp = cbxBophan.SelectedValue.ToString();
                bc = cbxBangcap.SelectedValue.ToString();
                cv = cbxChucvu.SelectedValue.ToString();

                strSQL = @"update NHANVIEN set HoTen=N'" + txtHoten.Text + "',NgaySinh='" + dtNgaySinh.Value.ToString("yyyy/MM/dd") + "',DiaChi=N'"
                    + txtDiachi.Text + "',DienThoai='" + txtDienthai.Text + "',Email='" + txtEmail.Text + "',BoPhan='" + bp + "',ChucVu='" + cv
                    + "',BangCap='" + bc + "',Account='" + txtAccount.Text + "', Pass='" + txtPass.Text + "' where MaNV='" + cbxMaNV.Text + "'";

                t = DataConnection.RunsqlQuery(strSQL);
                displayData();
                MessageBox.Show("Cập nhật thành công!");
            }
            else
                MessageBox.Show("Email không hợp lệ!");

        }

        private void txtDienthai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;
            txtAccount.Text = "";
            txtDiachi.Text = "";
            txtDienthai.Text = "";
            txtEmail.Text = "";
            txtHoten.Text = "";
            txtPass.Text = "";
            cbxMaNV.Text = "";
            cbxChucvu.SelectedIndex = -1;
            cbxBophan.SelectedIndex = -1;
            cbxBangcap.SelectedIndex = -1;
        }

        private void dgvNhanVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbxMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtDiachi.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtDienthai.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtAccount.Text = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
            txtPass.Text = dgvNhanVien.CurrentRow.Cells[10].Value.ToString();
            cbxBangcap.SelectedValue = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            cbxBophan.SelectedValue = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            cbxChucvu.SelectedValue = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
            btLuu.Enabled = false;
        }
        public bool isValidEmail(string inputEmail)
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