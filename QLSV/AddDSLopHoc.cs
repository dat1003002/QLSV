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
    public partial class AddDSLopHoc : Form
    {
        public AddDSLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }
        private string malophoc;
        private Database db;
        private string nguoithuchien = "admin";
        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddDSLopHoc_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>() {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = ""
                }
            };
            //load dữ liệu cho 2 combobox
            cbbmonhoc.DataSource = db.SelectData("selectAllMonHoc",lst);
            cbbmonhoc.DisplayMember = "tenmonhoc";
            cbbmonhoc.ValueMember = "mamonhoc";
            cbbmonhoc.SelectedIndex = -1;

            cbbgiaovien.DataSource = db.SelectData("selectAllGV", lst);
            cbbgiaovien.DisplayMember = "hoten";
            cbbgiaovien.ValueMember = "magiaovien";
            cbbgiaovien.SelectedIndex = -1;

            if(string.IsNullOrEmpty(malophoc))
            {
                this.Text = "thêm mới lớp học";
            }
            else
            {
                this.Text = "cập nhật lớp học";
                var r = db.select(" selectLopHoc '"+malophoc+"'");
                Console.WriteLine(r.ToString());
                cbbgiaovien.SelectedValue = r["magiaovien"].ToString();
                cbbmonhoc.SelectedValue = r["mamonhoc"].ToString(); 

            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql = "";

            if(cbbmonhoc.SelectedIndex < 0)
            {
                MessageBox.Show("vui lòng môn học");
                return;
            }
            if(cbbgiaovien.SelectedIndex < 0)
            {
                MessageBox.Show("vui longf chọn giáo viên");
                    return;
            }
            List<CustomParameter> lst = new List<CustomParameter>();
            if (string.IsNullOrEmpty(malophoc))
            {
                sql = "insertLopHoc";
                lst.Add(new CustomParameter()
                {
                    key ="@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                lst.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = malophoc
                });
            }
            lst.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = cbbmonhoc.SelectedValue.ToString()//lấy giá trị được chọnn
            });
            lst.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = cbbgiaovien.SelectedValue.ToString()//lấy giá trị được chọnn
            });
            var kq = db.ExeCute(sql, lst);
            if (kq == 1)
            {
                if (string.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("thêm thành công");
                }
                else
                {
                    MessageBox.Show("cập nhật thành công");
                }
            }
            else
            {
                MessageBox.Show("lưu dữ liệu thất bại");
            }
            this.Dispose();
        }
    }
}
