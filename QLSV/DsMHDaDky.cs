using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class DsMHDaDky : Form
    {
        private string masv;
        public DsMHDaDky(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        

        private void DsMHDaDky_Load(object sender, EventArgs e)
        {
            LoadMonDky();
        }
        private void LoadMonDky()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDSDDkyMH.DataSource = new Database().SelectData("monDaDKy", lst);
            dgvDSDDkyMH.Columns["malophoc"].HeaderText = "mã Lớp Học";
            dgvDSDDkyMH.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvDSDDkyMH.Columns["sotinchi"].HeaderText = "Số Tín Chỉ";
            dgvDSDDkyMH.Columns["gvien"].HeaderText =  "Tên Giáo Viên";
        }

        private void btndangkymonhoc_Click(object sender, EventArgs e)
        {
            new DangKyMonHoc(masv).ShowDialog();
            LoadMonDky();
        }
    }
}
