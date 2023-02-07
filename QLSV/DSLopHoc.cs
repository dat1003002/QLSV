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
    public partial class DSLopHoc : Form
    {
        public DSLopHoc()
        {
            InitializeComponent();
        }
        private string tukhoa = ""; 
        private void DSLopHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
        }
        private void LoadDSLH()
        {
            string sql = "allLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>() {
                new CustomParameter()
                {
                    key ="@tukhoa",
                    value = tukhoa
                }
            };
            dvgLopHoc.DataSource = new Database().SelectData(sql,lstPara);
            dvgLopHoc.Columns["malophoc"].HeaderText = "mã Lớp Học";
            dvgLopHoc.Columns["gv"].HeaderText = "Mã Giáo Viên";
            dvgLopHoc.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txttimkiem.Text;
            LoadDSLH();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            new AddDSLopHoc(null).ShowDialog();
            LoadDSLH();
        }

        private void dvgLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new AddDSLopHoc(dvgLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()).ShowDialog();
                LoadDSLH();
            }
        }
    }
}
