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
    public partial class DSGV : Form
    {
        public DSGV()
        {
            InitializeComponent();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txttimkiem.Text;
            loadDSGV();
        }
        private string tukhoa = "";
        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter() { 
            key = "@tukhoa",
            value = tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData(sql,lstPara);
            dgvDSGV.Columns["magiaovien"].HeaderText = "mã GV";
            dgvDSGV.Columns["hoten"].HeaderText = "Họ Tên";
            dgvDSGV.Columns["ngsinh"].HeaderText = "Ngày Sinh";
            dgvDSGV.Columns["gt"].HeaderText = "Giới Tính";
            dgvDSGV.Columns["dienthoai"].HeaderText = "Điện Thọ";
            dgvDSGV.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDSGV.Columns["email"].HeaderText = "Email";
            dgvDSGV.Columns["dienthoai"].HeaderText = "Điện Thoại";
        }

        private void DSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            new AddGiaoVien(null).ShowDialog();
            loadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new AddGiaoVien(mgv).ShowDialog();
                loadDSGV();
            }
        }

        private void dgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
