namespace QLThuVien
{
    partial class frmSach
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
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.cbxMaSach = new System.Windows.Forms.ComboBox();
            this.txtTrigia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxNVNhan = new System.Windows.Forms.ComboBox();
            this.dtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(117, 200);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(137, 21);
            this.txtNamXB.TabIndex = 95;
            this.txtNamXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamXB_KeyPress);
            // 
            // cbxMaSach
            // 
            this.cbxMaSach.FormattingEnabled = true;
            this.cbxMaSach.Location = new System.Drawing.Point(117, 123);
            this.cbxMaSach.Name = "cbxMaSach";
            this.cbxMaSach.Size = new System.Drawing.Size(137, 21);
            this.cbxMaSach.TabIndex = 94;
            // 
            // txtTrigia
            // 
            this.txtTrigia.Location = new System.Drawing.Point(633, 162);
            this.txtTrigia.Name = "txtTrigia";
            this.txtTrigia.Size = new System.Drawing.Size(137, 21);
            this.txtTrigia.TabIndex = 92;
            this.txtTrigia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrigia_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "Trị Giá:";
            // 
            // cbxNVNhan
            // 
            this.cbxNVNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNVNhan.FormattingEnabled = true;
            this.cbxNVNhan.Location = new System.Drawing.Point(633, 199);
            this.cbxNVNhan.Name = "cbxNVNhan";
            this.cbxNVNhan.Size = new System.Drawing.Size(137, 21);
            this.cbxNVNhan.TabIndex = 88;
            // 
            // dtNgaynhap
            // 
            this.dtNgaynhap.Location = new System.Drawing.Point(633, 124);
            this.dtNgaynhap.Name = "dtNgaynhap";
            this.dtNgaynhap.Size = new System.Drawing.Size(137, 21);
            this.dtNgaynhap.TabIndex = 87;
            // 
            // cbxLoai
            // 
            this.cbxLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Location = new System.Drawing.Point(371, 124);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(146, 21);
            this.cbxLoai.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 85;
            this.label5.Text = "Ngày Nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 84;
            this.label4.Text = "Nhân Viên Nhận:";
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSach.Location = new System.Drawing.Point(0, 289);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.Size = new System.Drawing.Size(900, 170);
            this.dgvSach.TabIndex = 83;
            this.dgvSach.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellEnter);
            this.dgvSach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSach_MouseClick);
            // 
            // txtTacgia
            // 
            this.txtTacgia.Location = new System.Drawing.Point(371, 164);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(146, 21);
            this.txtTacgia.TabIndex = 82;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(371, 201);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(146, 21);
            this.txtNXB.TabIndex = 81;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(117, 164);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(137, 21);
            this.txtTen.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 19);
            this.label11.TabIndex = 79;
            this.label11.Text = "Năm Xuất Bản:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(302, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 19);
            this.label10.TabIndex = 78;
            this.label10.Text = "Loại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(302, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 77;
            this.label9.Text = "Tác Giả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(302, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 76;
            this.label8.Text = "Nhà XB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 75;
            this.label3.Text = "Tên Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Mã Sách:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 40);
            this.label1.TabIndex = 73;
            this.label1.Text = "Hồ Sơ Sách";
            // 
            // btLuu
            // 
            this.btLuu.Enabled = false;
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Image = global::QLThuVien.Properties.Resources.notebook__7_;
            this.btLuu.Location = new System.Drawing.Point(287, 241);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(78, 43);
            this.btLuu.TabIndex = 98;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLThuVien.Properties.Resources.open_book__1_;
            this.pictureBox1.Location = new System.Drawing.Point(287, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::QLThuVien.Properties.Resources.notebook__6_;
            this.btSua.Location = new System.Drawing.Point(390, 241);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(109, 43);
            this.btSua.TabIndex = 96;
            this.btSua.Text = "Sửa Sách";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::QLThuVien.Properties.Resources.notebook__5_;
            this.btXoa.Location = new System.Drawing.Point(532, 241);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(114, 43);
            this.btXoa.TabIndex = 93;
            this.btXoa.Text = "Xóa Sách";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btNhap
            // 
            this.btNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhap.Image = global::QLThuVien.Properties.Resources.notebook__4_;
            this.btNhap.Location = new System.Drawing.Point(140, 241);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(114, 43);
            this.btNhap.TabIndex = 89;
            this.btNhap.Text = "Thêm Sách";
            this.btNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 459);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.txtNamXB);
            this.Controls.Add(this.cbxMaSach);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.txtTrigia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.cbxNVNhan);
            this.Controls.Add(this.dtNgaynhap);
            this.Controls.Add(this.cbxLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.txtTacgia);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSach";
            this.Text = "Hồ sơ Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.ComboBox cbxMaSach;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtTrigia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.ComboBox cbxNVNhan;
        private System.Windows.Forms.DateTimePicker dtNgaynhap;
        private System.Windows.Forms.ComboBox cbxLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.TextBox txtTacgia;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLuu;
    }
}