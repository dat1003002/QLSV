namespace QLSV
{
    partial class DsMHDaDky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsMHDaDky));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btndangkymonhoc = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dgvDSDDkyMH = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDDkyMH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.btndangkymonhoc);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 109);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Americana EB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Đã Đăng Ký Học Phần";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(393, 74);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(237, 28);
            this.txttimkiem.TabIndex = 2;
            // 
            // btndangkymonhoc
            // 
            this.btndangkymonhoc.BackColor = System.Drawing.Color.MediumBlue;
            this.btndangkymonhoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndangkymonhoc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndangkymonhoc.Image = ((System.Drawing.Image)(resources.GetObject("btndangkymonhoc.Image")));
            this.btndangkymonhoc.Location = new System.Drawing.Point(733, 65);
            this.btndangkymonhoc.Name = "btndangkymonhoc";
            this.btndangkymonhoc.Size = new System.Drawing.Size(142, 37);
            this.btndangkymonhoc.TabIndex = 1;
            this.btndangkymonhoc.Text = "Đăng Ký Học Phần";
            this.btndangkymonhoc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btndangkymonhoc.UseVisualStyleBackColor = false;
            this.btndangkymonhoc.Click += new System.EventHandler(this.btndangkymonhoc_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(636, 65);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(91, 37);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btntimkiem.UseVisualStyleBackColor = false;
            // 
            // dgvDSDDkyMH
            // 
            this.dgvDSDDkyMH.AllowUserToAddRows = false;
            this.dgvDSDDkyMH.AllowUserToDeleteRows = false;
            this.dgvDSDDkyMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDDkyMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDDkyMH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSDDkyMH.Location = new System.Drawing.Point(0, 108);
            this.dgvDSDDkyMH.MultiSelect = false;
            this.dgvDSDDkyMH.Name = "dgvDSDDkyMH";
            this.dgvDSDDkyMH.ReadOnly = true;
            this.dgvDSDDkyMH.RowTemplate.Height = 25;
            this.dgvDSDDkyMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDDkyMH.Size = new System.Drawing.Size(907, 336);
            this.dgvDSDDkyMH.TabIndex = 1;
            // 
            // DsMHDaDky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 444);
            this.Controls.Add(this.dgvDSDDkyMH);
            this.Controls.Add(this.panel1);
            this.Name = "DsMHDaDky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DsMHDaDky";
            this.Load += new System.EventHandler(this.DsMHDaDky_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDDkyMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dgvDSDDkyMH;
        private TextBox txttimkiem;
        private Button btndangkymonhoc;
        private Button btntimkiem;
        private Label label1;
    }
}