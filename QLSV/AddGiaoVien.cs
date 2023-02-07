using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLSV
{
    public partial class AddGiaoVien : Form
    {
        public AddGiaoVien(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private string nguoithucthi = "admin";

        private void AddGiaoVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm giáo viên mới";
            }
            else
            {
                this.Text = "Cập nhật giáo viên";
                var r = new Database().select("selectGV '" + int.Parse(mgv) + "'");
                txtHo.Text = r["ho"].ToString();
                txtTenDem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                if (int.Parse(r["gioiTinh"].ToString()) == 0)
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }
                mtbNgaySinh.Text = r["ngsinh"].ToString();
                txtDienThoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
                txtDiaChi.Text = r["diachi"].ToString();


            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {//LUU SAU KHI UPDATE HOAC THEM MOI
            Console.WriteLine(txtHo.Text);
            string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTenDem.Text;
            string ten = txtTen.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaySinh.Select();
                return;
                
            }
            string gioiTinh = rbtNam.Checked ? "0" : "1";
            string dienthoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            string diachi = txtDiaChi.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mgv))
            {
                //this.Text = "Thêm giáo viên mới";
                
                sql = "InsertGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = "admin"
                });//dữ liệu cần ở thêm


            }
            else
            {
                //CHEN 
                sql = "UpdateGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = mgv
                });//dữ liệu cần ở chèn 
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = "admin"
                });


            }

            //them và sửa dùng chung dữ liệu truyền vào
            
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }catch
            {
                MessageBox.Show("ngày sinh không hợp lệ");
                mtbNgaySinh.Select();
                return;
            }
            string gioitinh = rbtNam.Checked ? "0" : "1";

            lstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = txtHo.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = txtTenDem.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = txtTen.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = mtbNgaySinh.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = txtDienThoai.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = txtEmail.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value =txtDiaChi.Text
            });





            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm  Mới giáo viên viên thành công");
                }
                else
                {
                    MessageBox.Show("cập nhật thông tin giáo viên thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("thực thi thất bại");
            }
        }
    }
}
