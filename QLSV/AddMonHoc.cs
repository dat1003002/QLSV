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
    public partial class AddMonHoc : Form
    {
        public AddMonHoc(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }
        private string mamh;
        private string nguoithuchien = "admin";
        private void AddMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm Mới Môn Học";
            }
            else
            {

                this.Text = "Cập nhật môn học";
                var r = new Database().select("exec selectMH '" + mamh + "'");
                txtMonHoc.Text = r["tenmonhoc"].ToString();
                txtSoTc.Text = r["sotinchi"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
             var stc =   int.Parse(txtSoTc.Text);
                if (stc <= 0)
                {
                    MessageBox.Show("số tín chỉ phải lớn hơn 0");
                    txtSoTc.Select();
                    return;
                }

            }
            catch
            {
                MessageBox.Show("số tín chỉ phải là số nguyên");
                txtSoTc.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMonHoc.Text))
            {
                MessageBox.Show("tên môn học không được để trông");
                txtMonHoc.Select();
                return;
            }

            string sql = "";
            string nguoitao = "admin";
            string tenmonhoc = txtMonHoc.Text;
            string sotinchi = txtSoTc.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(mamh))
            {//them moi 
                sql = "insertMonHoc";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoitao
                });
            }
            else
            {//chen
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = mamh
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                sql = "updateMonHoc";

                
               
            }//chèn




            //chung dữ liệu
            lstPara.Add(new CustomParameter()
            {
                key = "@tenmonhoc",
                value = txtMonHoc.Text
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@sotinchi",
                value = txtSoTc.Text
            });

            //xử lý
            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("thêm mới thành công");
                }
                else
                {
                    MessageBox.Show("cập nhật thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("thực hiện thất bại");
            }
        }
    }
}
