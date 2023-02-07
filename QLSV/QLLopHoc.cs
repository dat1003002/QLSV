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
    public partial class QLLopHoc : Form
    {
        
        public QLLopHoc(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
            
        }
        private string mgv;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttracuu_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLLopHoc_Load(object sender, EventArgs e)
        {
            LoadDSLop();
            dgvDSLopHoc.Columns["malophoc"].HeaderText = "Mã Lớp";
            dgvDSLopHoc.Columns["mamonhoc"].HeaderText = "Mã Học Phần";
            dgvDSLopHoc.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvDSLopHoc.Columns["sotinchi"].HeaderText = "Số Tín Chỉ";
            dgvDSLopHoc.Columns["siso"].HeaderText = "Sĩ Số";
        }
        private void LoadDSLop()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                
                key = "@magiaovien",
                value = mgv

            }) ;
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txttracuu.Text
            });
            dgvDSLopHoc.DataSource = new Database().SelectData("tracuulop", lstPara);
        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            LoadDSLop();
        }
    }
}
