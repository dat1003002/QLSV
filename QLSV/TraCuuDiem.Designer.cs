namespace QLSV
{
    partial class TraCuuDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuDiem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntracuu = new System.Windows.Forms.Button();
            this.dgvtracuudiem = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtracuudiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.btntracuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 102);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Americana EB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Sách Điểm Sinh Viên";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(424, 66);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(313, 23);
            this.txttimkiem.TabIndex = 1;
            // 
            // btntracuu
            // 
            this.btntracuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btntracuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntracuu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btntracuu.Image = ((System.Drawing.Image)(resources.GetObject("btntracuu.Image")));
            this.btntracuu.Location = new System.Drawing.Point(743, 58);
            this.btntracuu.Name = "btntracuu";
            this.btntracuu.Size = new System.Drawing.Size(109, 37);
            this.btntracuu.TabIndex = 0;
            this.btntracuu.Text = "Tra Cứu Điểm";
            this.btntracuu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btntracuu.UseVisualStyleBackColor = false;
            this.btntracuu.Click += new System.EventHandler(this.btntracuu_Click);
            // 
            // dgvtracuudiem
            // 
            this.dgvtracuudiem.AllowUserToAddRows = false;
            this.dgvtracuudiem.AllowUserToDeleteRows = false;
            this.dgvtracuudiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtracuudiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtracuudiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvtracuudiem.Location = new System.Drawing.Point(0, 101);
            this.dgvtracuudiem.MultiSelect = false;
            this.dgvtracuudiem.Name = "dgvtracuudiem";
            this.dgvtracuudiem.ReadOnly = true;
            this.dgvtracuudiem.RowTemplate.Height = 25;
            this.dgvtracuudiem.Size = new System.Drawing.Size(907, 362);
            this.dgvtracuudiem.TabIndex = 1;
            // 
            // TraCuuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 463);
            this.Controls.Add(this.dgvtracuudiem);
            this.Controls.Add(this.panel1);
            this.Name = "TraCuuDiem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm Học Tập";
            this.Load += new System.EventHandler(this.TraCuuDiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtracuudiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txttimkiem;
        private Button btntracuu;
        private DataGridView dgvtracuudiem;
        private Label label1;
    }
}