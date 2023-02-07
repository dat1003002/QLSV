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
    public partial class QLMonHoc : Form
    {
        public QLMonHoc()
        {
            InitializeComponent();
        }
        private string tukhoa = "";

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            new AddMonHoc(null).ShowDialog();
            LoadDSMH();
        }

        private void dvgMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var mamh = dvgMonHoc.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new AddMonHoc(mamh).ShowDialog();
            }
            LoadDSMH();
        }
        private void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            { 
            key = "@tukhoa",
            value = tukhoa
            });
            dvgMonHoc.DataSource = new Database().SelectData("selectAllMonHoc", lstPara);
        }

        private void QLMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSMH();
            dvgMonHoc.Columns["mamonhoc"].HeaderText = "Mã MH";
            dvgMonHoc.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dvgMonHoc.Columns["sotinchi"].HeaderText = "Số Tín Chỉ";

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txttimkiem.Text;
            LoadDSMH();
        }
    }
}
