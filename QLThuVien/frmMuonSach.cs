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
    public partial class frmMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmMuonSach()
        {
            InitializeComponent();
        }
        private string strSQL = "";
        private DataSet ds = null;
        string dl;
        private object t = null;
        private object m = new object();
        private DataTable dt = new DataTable();
        private List<string> maSach = new List<string>();


        private void cbxDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            strSQL = @"SELECT b.MaPhieuMuon AS 'Mã Phiếu Mượn', d.HoTen AS 'Họ tên độc giả', c.TenSach AS 'Tên sách', b.NgayMuon AS 'Ngày Mượn', b.Han AS 'Hạn' FROM dbo.CTMUONSACH a, dbo.MUONSACH b, dbo.SACH c, dbo.DOCGIA d WHERE a.MaPM = b.MaPhieuMuon AND b.MADG = d.MaDG AND c.MaSach = a.SachMuon and HoTen like N'%" + cbxDG.Text.ToString()+ "%'";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            dgvSachMuon.DataSource = ds.Tables[0];
        }

        private void cbxPML_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPML.Text.ToString() == "")
            {}
            else
            {
                strSQL = @"SELECT b.MaPhieuMuon AS 'Mã Phiếu Mượn', d.HoTen AS 'Họ tên độc giả', c.TenSach AS 'Tên sách', b.NgayMuon AS 'Ngày Mượn', b.Han AS 'Hạn' FROM dbo.CTMUONSACH a, dbo.MUONSACH b, dbo.SACH c, dbo.DOCGIA d WHERE a.MaPM = b.MaPhieuMuon AND b.MADG = d.MaDG AND c.MaSach = a.SachMuon and MaPM like '" + cbxPML.Text.ToString() + "'";
                ds = new DataSet();
                ds = DataConnection.GetDataSet(strSQL);
                dgvSachMuon.DataSource = ds.Tables[0];
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            bool kt = false;
            foreach(var i in maSach)
            {
                if (i == cbxSach.SelectedValue.ToString())
                {
                    kt = true;
                    break;
                }
            }
            if (kt)
                MessageBox.Show("Sách đã được chọn!");
            else
            {
                DataRow row;
                row = dt.NewRow();
                row["Danh sách sách mượn"] = cbxSach.Text.ToString();
                dt.Rows.Add(row);

                dgvDS.DataSource = dt;
                maSach.Add(cbxSach.SelectedValue.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xml = "<Root>";
            foreach (var i in maSach)
                xml += "<ID>" + i + "</ID>";
            xml += "</Root>";
            strSQL = @"EXEC dbo.PhieuMuonSach @xml = '"+xml+"', @MaDG = '"+cbxDGMuon.SelectedValue.ToString()+"'";
            string tt = (string)DataConnection.RunsqlScalar(strSQL);
            MessageBox.Show(tt);
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
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

            strSQL = @"  SELECT * FROM dbo.SACH a WHERE a.MaSach NOT IN (SELECT SachMuon FROM dbo.CTMUONSACH WHERE TinhTrang = 1)";
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

            strSQL = @"select * from DOCGIA";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxDGMuon.DataSource = ds.Tables[0];
            cbxDGMuon.DisplayMember = "HoTen";
            cbxDGMuon.ValueMember = "MaDG";

            cbxDG.SelectedIndex = -1;
            cbxPML.SelectedIndex = -1;

            dt.Columns.Add("Danh sách sách mượn");
        }
    }
}