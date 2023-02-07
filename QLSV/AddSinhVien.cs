using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AddSinhVien : Form
    {
        public AddSinhVien(string msv)
        {
            this.msv = msv; 
            InitializeComponent();
        }
        private string msv;
        private void AddSinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "thêm sinh viên mới";
            }
            else
            {
                this.Text = "cập nhật thông tin sinh viên";
                var r = new Database().select("selectSV '"+msv+"'");
                // MessageBox.Show(r[0].ToString());

                txtho.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                mtbNgaysinh.Text = r["ngsinh"].ToString();
                if (int.Parse(r["gioiTinh"].ToString()) == 0)
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }
                txtQueQuan.Text = r["quequan"].ToString();
                txtDiaChi.Text = r["diachi"].ToString() ;
                txtDienThoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
                pictureBox1.ImageLocation= r["avatar"].ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void btnthem_Click(object sender, EventArgs e)
        {
           //LUU
            Console.WriteLine(txtho.Text);
            string sql = "";
            string ho = txtho.Text;
            string tendem = txtTendem.Text;
            string ten = txtTen.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch(Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaysinh.Select();
                return;
            }
            string gioitinh = rbtNam.Checked ? "0" : "1";
            string quequan = txtQueQuan.Text;
            string diachi = txtDiaChi.Text;
            string dienthoai = txtDienThoai.Text;
            string email = txtEmail.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(msv))
            {
                sql = "ThemMoiSV";

            }
            else
            {
                sql = "updateSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = ho
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = tendem
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = ten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@quequan",
                value = quequan
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = diachi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = dienthoai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = email
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@avatar",
                value = pictureBox1.ImageLocation.ToString()
            });

            var rs = new Database().ExeCute(sql,lstPara);
            if(rs == 1)
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Thêm  Mới sinh viên thành công");
                }
                else {
                    MessageBox.Show("cập nhật thông tin sinh viên thành công");
                        }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("thực thi thất bại");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "vui lòng chọn ảnh";
            var rs = openFileDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                pictureBox1.ImageLocation = file;
                Console.WriteLine(file.ToString());

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn thoát?");
            this.Close();
        }
    }
}
