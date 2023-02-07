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
    public partial class IndexQLSV : Form
    {
        public IndexQLSV()
        {
            InitializeComponent();
            LoadDSSV();
        }
        private string tukhoa = "";
        private string taikhoan;
        private string loaitk;
        private string dangky;
        private void btnsinhvien_Click(object sender, EventArgs e)
        {
            new DSSV().ShowDialog();

   
        }

        private void btngiaovien_Click(object sender, EventArgs e)
        {
            new DSGV().ShowDialog();
        }

        private void IndexQLSV_Load(object sender, EventArgs e)
        {

            var fn = new DangNhap();
            fn.ShowDialog();

            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk; 
            if(loaitk.Equals("admin"))
            {
                //nếu là admin thì ẩn chấm điểm và đăng kí 
                //chỉ để lại menu quản lý
                quanlylophocToolStripMenuItem.Visible = false;
                dangkymonhocToolStripMenuItem.Visible=false;
                
                
                
            }
            else
            {
                //nếu không phải là quản lý thì ẩn menu quản lý
                quanlyToolStripMenuItem.Visible = false;
                if (loaitk.Equals("gv"))
                {
                    dangkymonhocToolStripMenuItem.Visible=false;
                }
                else
                {
                    quanlylophocToolStripMenuItem.Visible=false;
                    btngiaovien.Visible=false;
                    btnlophoc.Visible=false;
                    btnsinhvien.Visible=false;
                    button5.Visible=false;




                }
            }  


            LoadDSSV();

        }
        private void LoadDSSV()
        {

            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "tukhoa",
                value = tukhoa


            });
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);


            dgvSinhVien.Columns["masinhvien"].HeaderText = "mã SV";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ Tên";
            dgvSinhVien.Columns["nsinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["gt"].HeaderText = "Giới Tính";
            dgvSinhVien.Columns["quequan"].HeaderText = "Quê Quán";
            dgvSinhVien.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvSinhVien.Columns["email"].HeaderText = "Email";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện Thoại";

            

        }



        private void button5_Click(object sender, EventArgs e)
        {
            new QLMonHoc().ShowDialog();
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                new AddSinhVien(msv).ShowDialog();
                LoadDSSV();
            }
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            new AddSinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txttimkiem.Text;
            LoadDSSV();
        }

        private void btnlophoc_Click(object sender, EventArgs e)
        {
            new DSLopHoc().ShowDialog();
        }

        private void dangkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*new DsMHDaDky(taikhoan).ShowDialog();*/
        }

        private void btnDkMonHoc_Click(object sender, EventArgs e)
        {
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void traCuuDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TraCuuDiem(taikhoan).ShowDialog();
        }

        private void dangkymonhocHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DsMHDaDky(taikhoan).ShowDialog();
        }

        private void quanlylophocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QLLopHoc(taikhoan).ShowDialog();
        }
    }
}
