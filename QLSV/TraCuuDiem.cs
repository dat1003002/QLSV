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
    public partial class TraCuuDiem : Form
    {
        public TraCuuDiem(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }
        private string msv;

        private void TraCuuDiem_Load(object sender, EventArgs e)
        {
            LoadKQHT();

            dgvtracuudiem.Columns["mamonhoc"].HeaderText = "Mã Học Phần";
            dgvtracuudiem.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvtracuudiem.Columns["lanhoc"].HeaderText = "Lần Học";
            dgvtracuudiem.Columns["gvien"].HeaderText = "Giáo Viên";
            dgvtracuudiem.Columns["diemlan1"].HeaderText = "Điểm Thi Lần 1";
            dgvtracuudiem.Columns["diemlan2"].HeaderText = "Điểm Thi Lần 2";
        }
        private void LoadKQHT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txttimkiem.Text
            });
            dgvtracuudiem.DataSource = new Database().SelectData("tracuudiem", lstPara);

            }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            LoadKQHT();
        }
    }
    }

