using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string user = "";
        public static string boPhan = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool ExistForm(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT COUNT(*) FROM NHANVIEN WHERE Account ='" + txtName.Text + "' AND Pass ='" + txtPass.Text + "'";
            int i = (int)DataConnection.RunsqlScalar(sql);
            if (i == 1)
            {
                string sql1 = @"SELECT BoPhan FROM NHANVIEN WHERE Account ='" + txtName.Text + "' AND Pass ='" + txtPass.Text + "'";
                string bp = (string)DataConnection.RunsqlScalar(sql1);
                boPhan = bp;
                user = txtName.Text;

                ribbonControl1.Visible = true;
                groupBox1.Visible = false;
            }
            else
                MessageBox.Show("Đăng nhập thất bại!");
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSach fn = new frmSach();
            bool Exist = ExistForm(fn);
            if (Exist) return;
            fn.MdiParent = this;
            fn.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien fn = new frmNhanVien();
            bool Exist = ExistForm(fn);
            if (Exist) return;
            fn.MdiParent = this;
            fn.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tt = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tt == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDoiMK fn = new FrmDoiMK();
            this.Hide();
            fn.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDocGia fm = new frmDocGia();
            bool Exist = ExistForm(fm);
            if (Exist) return;
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMK fm = new FrmDoiMK();
            //bool Exist = ExistForm(fm);
            //if (Exist) return;
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1.user = "";
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMuonSach fm = new frmMuonSach();
            bool Exist = ExistForm(fm);
            if (Exist) return;
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTraSach fm = new frmTraSach();
            bool Exist = ExistForm(fm);
            if (Exist) return;
            fm.MdiParent = this;
            fm.Show();
        }
    }
}
