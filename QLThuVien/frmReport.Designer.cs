namespace QLThuVien
{
    partial class frmReport
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
            this.cbxDG = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crvDSDG = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxDG
            // 
            this.cbxDG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDG.FormattingEnabled = true;
            this.cbxDG.Location = new System.Drawing.Point(124, 25);
            this.cbxDG.Name = "cbxDG";
            this.cbxDG.Size = new System.Drawing.Size(121, 25);
            this.cbxDG.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Độc giả:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // crvDSDG
            // 
            this.crvDSDG.ActiveViewIndex = -1;
            this.crvDSDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDSDG.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDSDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvDSDG.Location = new System.Drawing.Point(0, 76);
            this.crvDSDG.Name = "crvDSDG";
            this.crvDSDG.Size = new System.Drawing.Size(960, 366);
            this.crvDSDG.TabIndex = 3;
            // 
            // btXuat
            // 
            this.btXuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXuat.Image = global::QLThuVien.Properties.Resources.report;
            this.btXuat.Location = new System.Drawing.Point(262, 15);
            this.btXuat.Name = "btXuat";
            this.btXuat.Size = new System.Drawing.Size(86, 43);
            this.btXuat.TabIndex = 2;
            this.btXuat.Text = "Xuất";
            this.btXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXuat.UseVisualStyleBackColor = true;
            this.btXuat.Click += new System.EventHandler(this.btXuat_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 442);
            this.Controls.Add(this.crvDSDG);
            this.Controls.Add(this.btXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDG);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXuat;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDSDG;
    }
}