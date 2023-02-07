namespace QLSV
{
    partial class DSSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSSV));
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 116);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowTemplate.Height = 25;
            this.dgvSinhVien.Size = new System.Drawing.Size(907, 347);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick);
            this.dgvSinhVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellDoubleClick);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(222, 82);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(307, 29);
            this.txttimkiem.TabIndex = 2;
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnthemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnthemmoi.Image")));
            this.btnthemmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemmoi.Location = new System.Drawing.Point(628, 82);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(89, 32);
            this.btnthemmoi.TabIndex = 4;
            this.btnthemmoi.Text = "Thêm Mới";
            this.btnthemmoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemmoi.UseVisualStyleBackColor = false;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Americana EB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản Lý Danh Sách Sinh Viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnFile);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.btnthemmoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 120);
            this.panel1.TabIndex = 6;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(722, 82);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(59, 32);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Fuchsia;
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.Location = new System.Drawing.Point(787, 82);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(82, 32);
            this.btnFile.TabIndex = 7;
            this.btnFile.Text = "Xuất Fie";
            this.btnFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Gold;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.Location = new System.Drawing.Point(547, 82);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 32);
            this.btntimkiem.TabIndex = 6;
            this.btntimkiem.Text = "tìm kiếm";
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // DSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "DSSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sinh Viên";
            this.Load += new System.EventHandler(this.DSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvSinhVien;
        private TextBox txttimkiem;
        private Button btnthemmoi;
        private Label label2;
        private Panel panel1;
        private Button btntimkiem;
        private Button btnFile;
        private Button btnxoa;
    }
}