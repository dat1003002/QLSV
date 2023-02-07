namespace QLSV
{
    partial class AddDSLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDSLopHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.cbbgiaovien = new System.Windows.Forms.ComboBox();
            this.cbbmonhoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Americana EB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Danh Sách Lớp Học";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnhuy);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.cbbgiaovien);
            this.panel1.Controls.Add(this.cbbmonhoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 204);
            this.panel1.TabIndex = 1;
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Red;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(575, 89);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(84, 37);
            this.btnhuy.TabIndex = 6;
            this.btnhuy.Text = "Thoát";
            this.btnhuy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Gold;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(484, 89);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 37);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // cbbgiaovien
            // 
            this.cbbgiaovien.FormattingEnabled = true;
            this.cbbgiaovien.Location = new System.Drawing.Point(156, 123);
            this.cbbgiaovien.Name = "cbbgiaovien";
            this.cbbgiaovien.Size = new System.Drawing.Size(289, 29);
            this.cbbgiaovien.TabIndex = 4;
            // 
            // cbbmonhoc
            // 
            this.cbbmonhoc.FormattingEnabled = true;
            this.cbbmonhoc.Location = new System.Drawing.Point(156, 77);
            this.cbbmonhoc.Name = "cbbmonhoc";
            this.cbbmonhoc.Size = new System.Drawing.Size(289, 29);
            this.cbbmonhoc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giáo Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn Học";
            // 
            // AddDSLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 204);
            this.Controls.Add(this.panel1);
            this.Name = "AddDSLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDSLopHoc";
            this.Load += new System.EventHandler(this.AddDSLopHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnhuy;
        private Button btnluu;
        private ComboBox cbbgiaovien;
        private ComboBox cbbmonhoc;
        private Label label3;
        private Label label2;
    }
}