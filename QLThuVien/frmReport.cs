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
using System.Data.SqlClient;

namespace QLThuVien
{
    public partial class frmReport : DevExpress.XtraEditors.XtraForm
    {
        public frmReport()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt_DG;
        DataTable dt_Sach;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection("Data Source=DESKTOP-HR37HS0\\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
            da = new SqlDataAdapter("select * from DOCGIA", cnn);
            dt_DG = new DataTable();
            da.Fill(dt_DG);

            da.SelectCommand.CommandText = "SELECT ThongKeDG_1.* FROM dbo.ThongKeDG() AS ThongKeDG_1";
            dt_Sach = new DataTable();
            da.Fill(dt_Sach);

            cbxDG.DataSource = dt_DG;
            cbxDG.DisplayMember = "HoTen";
            cbxDG.ValueMember = "MaDG";
            cbxDG.SelectedIndex = -1;

            CrystalReport3 rpt = new CrystalReport3();
            rpt.SetDataSource(dt_Sach.DefaultView);
            crvDSDG.ReportSource = rpt;
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            dt_Sach.DefaultView.RowFilter = "MaDG= '" + cbxDG.SelectedValue.ToString() + "'";
            CrystalReport3 rpt = new CrystalReport3();
            rpt.SetDataSource(dt_Sach.DefaultView);
            crvDSDG.ReportSource = rpt;
        }
    }
}