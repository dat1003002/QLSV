namespace QLSV
{
    partial class DSGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSGV));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Americana EB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Danh Sách Giáo Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 109);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(796, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xuất File";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(702, 74);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(68, 31);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Gold;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(594, 75);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(83, 30);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(301, 75);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(287, 30);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.AllowUserToAddRows = false;
            this.dgvDSGV.AllowUserToDeleteRows = false;
            this.dgvDSGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSGV.Location = new System.Drawing.Point(0, 111);
            this.dgvDSGV.MultiSelect = false;
            this.dgvDSGV.Name = "dgvDSGV";
            this.dgvDSGV.ReadOnly = true;
            this.dgvDSGV.RowTemplate.Height = 25;
            this.dgvDSGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSGV.Size = new System.Drawing.Size(907, 333);
            this.dgvDSGV.TabIndex = 2;
            this.dgvDSGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGV_CellContentClick);
            this.dgvDSGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGV_CellDoubleClick);
            // 
            // DSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 444);
            this.Controls.Add(this.dgvDSGV);
            this.Controls.Add(this.panel1);
            this.Name = "DSGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Giáo Viên";
            this.Load += new System.EventHandler(this.DSGV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnthem;
        private Button btntimkiem;
        private TextBox txttimkiem;
        private DataGridView dgvDSGV;
        private Button button1;
    }
}