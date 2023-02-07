namespace QLSV
{
    partial class DSLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSLopHoc));
            this.dvgLopHoc = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLopHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgLopHoc
            // 
            this.dvgLopHoc.AllowUserToAddRows = false;
            this.dvgLopHoc.AllowUserToDeleteRows = false;
            this.dvgLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLopHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvgLopHoc.Location = new System.Drawing.Point(0, 113);
            this.dvgLopHoc.MultiSelect = false;
            this.dvgLopHoc.Name = "dvgLopHoc";
            this.dvgLopHoc.ReadOnly = true;
            this.dvgLopHoc.RowTemplate.Height = 25;
            this.dvgLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgLopHoc.Size = new System.Drawing.Size(907, 331);
            this.dvgLopHoc.TabIndex = 0;
            this.dvgLopHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgLopHoc_CellDoubleClick);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(679, 79);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(82, 27);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.BackColor = System.Drawing.Color.DarkBlue;
            this.btnthemmoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnthemmoi.Image")));
            this.btnthemmoi.Location = new System.Drawing.Point(781, 79);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(86, 27);
            this.btnthemmoi.TabIndex = 2;
            this.btnthemmoi.Text = "Thêm Mới";
            this.btnthemmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnthemmoi.UseVisualStyleBackColor = false;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(387, 79);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(286, 27);
            this.txttimkiem.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.btnthemmoi);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 114);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Americana EB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(240, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Danh Sách Lớp Học";
            // 
            // DSLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvgLopHoc);
            this.Name = "DSLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSLopHoc";
            this.Load += new System.EventHandler(this.DSLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgLopHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dvgLopHoc;
        private Button btntimkiem;
        private Button btnthemmoi;
        private TextBox txttimkiem;
        private Panel panel1;
        private Label label1;
    }
}