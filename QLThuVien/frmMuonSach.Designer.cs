namespace QLThuVien
{
    partial class frmMuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonSach));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDG = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPML = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxSach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxDGMuon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 40);
            this.label1.TabIndex = 90;
            this.label1.Text = "Phiếu Mượn Sách";
            // 
            // cbxDG
            // 
            this.cbxDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDG.FormattingEnabled = true;
            this.cbxDG.Items.AddRange(new object[] {
            "--Chưa Chọn--"});
            this.cbxDG.Location = new System.Drawing.Point(102, 21);
            this.cbxDG.Name = "cbxDG";
            this.cbxDG.Size = new System.Drawing.Size(119, 21);
            this.cbxDG.TabIndex = 93;
            this.cbxDG.SelectedIndexChanged += new System.EventHandler(this.cbxDG_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "ĐG Mượn:";
            // 
            // cbxPML
            // 
            this.cbxPML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPML.FormattingEnabled = true;
            this.cbxPML.Location = new System.Drawing.Point(381, 21);
            this.cbxPML.Name = "cbxPML";
            this.cbxPML.Size = new System.Drawing.Size(119, 21);
            this.cbxPML.TabIndex = 95;
            this.cbxPML.SelectedIndexChanged += new System.EventHandler(this.cbxPML_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 94;
            this.label6.Text = "Phiếu Mượn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dgvSachMuon);
            this.groupBox1.Controls.Add(this.cbxPML);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxDG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 163);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu sách mượn";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::QLThuVien.Properties.Resources.refresh;
            this.button3.Location = new System.Drawing.Point(558, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 37);
            this.button3.TabIndex = 97;
            this.button3.Text = "Reload";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Location = new System.Drawing.Point(26, 61);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.ReadOnly = true;
            this.dgvSachMuon.Size = new System.Drawing.Size(859, 87);
            this.dgvSachMuon.TabIndex = 96;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cbxDGMuon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 160);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lập phiếu mượn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDS);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cbxSach);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(72, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 124);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn sách cần mượn";
            // 
            // dgvDS
            // 
            this.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Location = new System.Drawing.Point(179, 20);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.Size = new System.Drawing.Size(227, 94);
            this.dgvDS.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(32, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 99;
            this.button1.Text = "Thêm";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxSach
            // 
            this.cbxSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSach.FormattingEnabled = true;
            this.cbxSach.Location = new System.Drawing.Point(54, 27);
            this.cbxSach.Name = "cbxSach";
            this.cbxSach.Size = new System.Drawing.Size(119, 25);
            this.cbxSach.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 96;
            this.label4.Text = "Sách:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::QLThuVien.Properties.Resources.side_menu;
            this.button2.Location = new System.Drawing.Point(636, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 36);
            this.button2.TabIndex = 100;
            this.button2.Text = "Lập phiếu";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxDGMuon
            // 
            this.cbxDGMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDGMuon.FormattingEnabled = true;
            this.cbxDGMuon.Location = new System.Drawing.Point(636, 47);
            this.cbxDGMuon.Name = "cbxDGMuon";
            this.cbxDGMuon.Size = new System.Drawing.Size(119, 25);
            this.cbxDGMuon.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "Chọn ĐG Mượn:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMuonSach";
            this.Text = "Mượn Sách";
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPML;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDGMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDS;
    }
}