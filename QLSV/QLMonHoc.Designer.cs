namespace QLSV
{
    partial class QLMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLMonHoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnxuatfile = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgMonHoc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnxuatfile);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.btnthemmoi);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 121);
            this.panel1.TabIndex = 0;
            // 
            // btnxuatfile
            // 
            this.btnxuatfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnxuatfile.Image = ((System.Drawing.Image)(resources.GetObject("btnxuatfile.Image")));
            this.btnxuatfile.Location = new System.Drawing.Point(822, 80);
            this.btnxuatfile.Name = "btnxuatfile";
            this.btnxuatfile.Size = new System.Drawing.Size(84, 30);
            this.btnxuatfile.TabIndex = 5;
            this.btnxuatfile.Text = "Xuất File";
            this.btnxuatfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnxuatfile.UseVisualStyleBackColor = false;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Gold;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(634, 80);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(87, 29);
            this.btntimkiem.TabIndex = 4;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.BackColor = System.Drawing.Color.Blue;
            this.btnthemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnthemmoi.Image")));
            this.btnthemmoi.Location = new System.Drawing.Point(727, 80);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(89, 29);
            this.btnthemmoi.TabIndex = 3;
            this.btnthemmoi.Text = "Thêm Mới";
            this.btnthemmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnthemmoi.UseVisualStyleBackColor = false;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(346, 80);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(264, 30);
            this.txttimkiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Americana EB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(244, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Danh Sách Môn Học";
            // 
            // dvgMonHoc
            // 
            this.dvgMonHoc.AllowUserToAddRows = false;
            this.dvgMonHoc.AllowUserToDeleteRows = false;
            this.dvgMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMonHoc.Location = new System.Drawing.Point(-2, 118);
            this.dvgMonHoc.MultiSelect = false;
            this.dvgMonHoc.Name = "dvgMonHoc";
            this.dvgMonHoc.ReadOnly = true;
            this.dvgMonHoc.RowTemplate.Height = 25;
            this.dvgMonHoc.Size = new System.Drawing.Size(909, 332);
            this.dvgMonHoc.TabIndex = 1;
            this.dvgMonHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMonHoc_CellDoubleClick);
            // 
            // QLMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 444);
            this.Controls.Add(this.dvgMonHoc);
            this.Controls.Add(this.panel1);
            this.Name = "QLMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLMonHoc";
            this.Load += new System.EventHandler(this.QLMonHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dvgMonHoc;
        private Button btntimkiem;
        private Button btnthemmoi;
        private TextBox txttimkiem;
        private Button btnxuatfile;
    }
}