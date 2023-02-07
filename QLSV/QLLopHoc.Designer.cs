namespace QLSV
{
    partial class QLLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLLopHoc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntracuu = new System.Windows.Forms.Button();
            this.txttracuu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDSLopHoc = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntracuu);
            this.groupBox1.Controls.Add(this.txttracuu);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra Cứu Lớp Của Giảng Viên";
            // 
            // btntracuu
            // 
            this.btntracuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntracuu.Image = ((System.Drawing.Image)(resources.GetObject("btntracuu.Image")));
            this.btntracuu.Location = new System.Drawing.Point(789, 60);
            this.btntracuu.Name = "btntracuu";
            this.btntracuu.Size = new System.Drawing.Size(105, 35);
            this.btntracuu.TabIndex = 1;
            this.btntracuu.Text = "Tra Cứu";
            this.btntracuu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btntracuu.UseVisualStyleBackColor = false;
            this.btntracuu.Click += new System.EventHandler(this.btntracuu_Click);
            // 
            // txttracuu
            // 
            this.txttracuu.Location = new System.Drawing.Point(502, 64);
            this.txttracuu.Name = "txttracuu";
            this.txttracuu.Size = new System.Drawing.Size(270, 29);
            this.txttracuu.TabIndex = 0;
            this.txttracuu.TextChanged += new System.EventHandler(this.txttracuu_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 106);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvDSLopHoc
            // 
            this.dgvDSLopHoc.AllowUserToAddRows = false;
            this.dgvDSLopHoc.AllowUserToDeleteRows = false;
            this.dgvDSLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLopHoc.Location = new System.Drawing.Point(1, 105);
            this.dgvDSLopHoc.MultiSelect = false;
            this.dgvDSLopHoc.Name = "dgvDSLopHoc";
            this.dgvDSLopHoc.ReadOnly = true;
            this.dgvDSLopHoc.RowTemplate.Height = 25;
            this.dgvDSLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLopHoc.Size = new System.Drawing.Size(908, 360);
            this.dgvDSLopHoc.TabIndex = 1;
            // 
            // QLLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 463);
            this.Controls.Add(this.dgvDSLopHoc);
            this.Controls.Add(this.panel1);
            this.Name = "QLLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLLopHoc";
            this.Load += new System.EventHandler(this.QLLopHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Button btntracuu;
        private TextBox txttracuu;
        private DataGridView dgvDSLopHoc;
    }
}