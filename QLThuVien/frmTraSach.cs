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
    public partial class frmTraSach : DevExpress.XtraEditors.XtraForm
    {
        public frmTraSach()
        {
            InitializeComponent();
        }
        private string strSQL = "";
        private DataSet ds = null;
        string dl;
        private object t = null;
        private object m = new object();
        private string maPM, maSach;

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            strSQL = @"SELECT b.MaPhieuMuon AS 'Mã Phiếu Mượn', d.HoTen AS 'Họ tên độc giả', c.TenSach AS 'Tên sách', b.NgayMuon AS 'Ngày Mượn', b.Han AS 'Hạn' FROM dbo.CTMUONSACH a, dbo.MUONSACH b, dbo.SACH c, dbo.DOCGIA d WHERE a.MaPM = b.MaPhieuMuon AND b.MADG = d.MaDG AND c.MaSach = a.SachMuon";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            dgvSachMuon.DataSource = ds.Tables[0];

            strSQL = @"select * from MUONSACH";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxPML.DataSource = ds.Tables[0];
            cbxPML.DisplayMember = "MaPhieuMuon";
            cbxPML.ValueMember = "MaPhieuMuon";

            strSQL = @"  SELECT * FROM dbo.SACH";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxSach.DataSource = ds.Tables[0];
            cbxSach.DisplayMember = "TenSach";
            cbxSach.ValueMember = "MaSach";


            strSQL = @"select * from DOCGIA";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxDG.DataSource = ds.Tables[0];
            cbxDG.DisplayMember = "HoTen";
            cbxDG.ValueMember = "MaDG";
            
            cbxDG.SelectedIndex = -1;
            cbxPML.SelectedIndex = -1;
            cbxSach.SelectedIndex = -1;

            
        }

        private void cbxDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            {
                strSQL = @"SELECT b.MaPhieuMuon AS 'Mã Phiếu Mượn', d.HoTen AS 'Họ tên độc giả', c.TenSach AS 'Tên sách', b.NgayMuon AS 'Ngày Mượn', b.Han AS 'Hạn' FROM dbo.CTMUONSACH a, dbo.MUONSACH b, dbo.SACH c, dbo.DOCGIA d WHERE a.MaPM = b.MaPhieuMuon AND b.MADG = d.MaDG AND c.MaSach = a.SachMuon and HoTen like N'%" + cbxDG.Text.ToString() + "%'";
                ds = new DataSet();
                ds = DataConnection.GetDataSet(strSQL);
                dgvSachMuon.DataSource = ds.Tables[0];

                cbxPML.SelectedIndex = -1;
                cbxSach.SelectedIndex = -1;
            }
        }

        private void cbxPML_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPML.Text.ToString() == "")
            { }
            else
            {
                strSQL = @"SELECT b.MaPhieuMuon AS 'Mã Phiếu Mượn', d.HoTen AS 'Họ tên độc giả', c.TenSach AS 'Tên sách', b.NgayMuon AS 'Ngày Mượn', b.Han AS 'Hạn' FROM dbo.CTMUONSACH a, dbo.MUONSACH b, dbo.SACH c, dbo.DOCGIA d WHERE a.MaPM = b.MaPhieuMuon AND b.MADG = d.MaDG AND c.MaSach = a.SachMuon and MaPM like '" + cbxPML.Text.ToString() + "'";
                ds = new DataSet();
                ds = DataConnection.GetDataSet(strSQL);
                dgvSachMuon.DataSource = ds.Tables[0];

                cbxDG.SelectedIndex = -1;
                cbxSach.SelectedIndex = -1;
            }
        }

        private void cbxSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSach.Text.ToString() == "")
            { }
            else
            {
                strSQL = @"SELECT b.MaPhieuMuon AS 'Mã Phiếu Mượn', d.HoTen AS 'Họ tên độc giả', c.TenSach AS 'Tên sách', b.NgayMuon AS 'Ngày Mượn', b.Han AS 'Hạn' FROM dbo.CTMUONSACH a, dbo.MUONSACH b, dbo.SACH c, dbo.DOCGIA d WHERE a.MaPM = b.MaPhieuMuon AND b.MADG = d.MaDG AND c.MaSach = a.SachMuon and TenSach like N'%" + cbxSach.Text.ToString() + "%'";
                ds = new DataSet();
                ds = DataConnection.GetDataSet(strSQL);
                dgvSachMuon.DataSource = ds.Tables[0];

                cbxDG.SelectedIndex = -1;
                cbxPML.SelectedIndex = -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            strSQL = @"SELECT b.MaPhieuMuon AS 'Mã Phiếu Mượn', d.HoTen AS 'Họ tên độc giả', c.TenSach AS 'Tên sách', b.NgayMuon AS 'Ngày Mượn', b.Han AS 'Hạn' FROM dbo.CTMUONSACH a, dbo.MUONSACH b, dbo.SACH c, dbo.DOCGIA d WHERE a.MaPM = b.MaPhieuMuon AND b.MADG = d.MaDG AND c.MaSach = a.SachMuon";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            dgvSachMuon.DataSource = ds.Tables[0];

            cbxDG.SelectedIndex = -1;
            cbxPML.SelectedIndex = -1;
            cbxSach.SelectedIndex = -1;
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            strSQL = @" UPDATE dbo.CTMUONSACH SET TinhTrang = 0 WHERE MaPM= "+maPM+ " AND SachMuon = = (SELECT MaSach FROM dbo.SACH WHERE TenSach = '"+maSach+"')";

            t = DataConnection.RunsqlQuery(strSQL);
            
            MessageBox.Show("Trả thành công!");

            button3_Click(sender,  e);
            btnTraSach.Enabled = false;
        }

        private void dgvSachMuon_MouseClick(object sender, MouseEventArgs e)
        {
            maPM = dgvSachMuon.CurrentRow.Cells[0].Value.ToString();
            maSach = dgvSachMuon.CurrentRow.Cells[2].Value.ToString();
            btnTraSach.Enabled = true;
        }
    }
}