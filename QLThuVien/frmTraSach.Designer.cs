namespace QLThuVien
{
    partial class frmTraSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.cbxPML = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxDG = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 40);
            this.label1.TabIndex = 90;
            this.label1.Text = "Phiếu Trả Sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLThuVien.Properties.Resources.rainbow;
            this.pictureBox1.Location = new System.Drawing.Point(262, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTraSach);
            this.groupBox1.Controls.Add(this.cbxSach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dgvSachMuon);
            this.groupBox1.Controls.Add(this.cbxPML);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxDG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 290);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu sách mượn";
            // 
            // cbxSach
            // 
            this.cbxSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSach.FormattingEnabled = true;
            this.cbxSach.Location = new System.Drawing.Point(531, 21);
            this.cbxSach.Name = "cbxSach";
            this.cbxSach.Size = new System.Drawing.Size(119, 21);
            this.cbxSach.TabIndex = 99;
            this.cbxSach.SelectedIndexChanged += new System.EventHandler(this.cbxSach_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 98;
            this.label4.Text = "Sách:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::QLThuVien.Properties.Resources.refresh;
            this.button3.Location = new System.Drawing.Point(676, 12);
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
            this.dgvSachMuon.Size = new System.Drawing.Size(859, 173);
            this.dgvSachMuon.TabIndex = 96;
            this.dgvSachMuon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSachMuon_MouseClick);
            // 
            // cbxPML
            // 
            this.cbxPML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPML.FormattingEnabled = true;
            this.cbxPML.Location = new System.Drawing.Point(343, 21);
            this.cbxPML.Name = "cbxPML";
            this.cbxPML.Size = new System.Drawing.Size(119, 21);
            this.cbxPML.TabIndex = 95;
            this.cbxPML.SelectedIndexChanged += new System.EventHandler(this.cbxPML_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 94;
            this.label6.Text = "Phiếu Mượn:";
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
            // btnTraSach
            // 
            this.btnTraSach.Enabled = false;
            this.btnTraSach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.Image = global::QLThuVien.Properties.Resources.exit__1_;
            this.btnTraSach.Location = new System.Drawing.Point(390, 240);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(107, 37);
            this.btnTraSach.TabIndex = 100;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmTraSach";
            this.Text = "Trả Sách";
            this.Load += new System.EventHandler(this.frmTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.ComboBox cbxPML;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTraSach;
    }
}