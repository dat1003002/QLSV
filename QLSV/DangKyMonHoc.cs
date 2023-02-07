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
    public partial class DangKyMonHoc : Form
    {
      
        public DangKyMonHoc(string masv)
        {
            this.masv = masv;
            InitializeComponent();
            
        }
        private string masv;

        private void DangKyMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã Lớp Học";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvDSLH.Columns["sotinchi"].HeaderText = "Số Tín Chỉ";
            dgvDSLH.Columns["gvien"].HeaderText = "Giáo Viên";


            dgvDSLH.Columns["mamonhoc"].Visible = false;

        }
        private void LoadDSLH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = masv
            });



            dgvDSLH.DataSource = new Database().SelectData("dsLopChuaDKy",lstPara);

        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLH.Rows[e.RowIndex].Index > 0)
            {
                if(DialogResult.Yes==
                MessageBox.Show(
                    "Bạn muốn đăng kí học phần[ " + dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString()+"]",
                    "xác nhận đăng ký",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question
                    )
                )
                {
                    List<CustomParameter> lstPara = new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = masv
                    }) ;
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = dgvDSLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                    });
                    var rs = new Database().ExeCute("[dkyhoc]", lstPara);
                    if (rs== -1)
                    {
                        MessageBox.Show("học phần này bạn đã đăng ký", "Lưu ý SOS!!!");
                        return;
                    }
                    if (rs == 1)
                    {
                        MessageBox.Show("đã đăng kí thành công học phần", "vui lòng kiểm tra lại!!");
                        LoadDSLH();
                    }
                }
            }
        }
    }
}
