using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class DangNhap : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public DangNhap()
        {
            AllocConsole();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string tendangnhap = "";
        public string loaitk;

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            #region ktra
            if (cbbLoaiTaikhoan.SelectedIndex <0)
            {
                MessageBox.Show("chọn loại tài khoản");
                return;
            }  
            if(string.IsNullOrEmpty(txttendangnhap.Text))
            {
                MessageBox.Show("vui lòng nhập tên tài khoản");
                txttendangnhap.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtmatkhau.Text))
            {
                MessageBox.Show("vui lòng nhập mật khẩu");
            }
            #endregion
            tendangnhap = txttendangnhap.Text;
             loaitk = "";

            #region swtk
            switch (cbbLoaiTaikhoan.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo Viên":
                    loaitk = "gv";
                    break;
                case "Sinh Viên":
                    loaitk = "sv";
                    break;
            }
            #endregion

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value =loaitk
                },
                 new CustomParameter()
                {
                    key = "@taikhoan",
                    value =txttendangnhap.Text
                },
                  new CustomParameter()
                {
                    key = "@matkhau",
                    value =txtmatkhau.Text
                },
            };
            Console.WriteLine(loaitk);
            var rs = new Database().SelectData("dangnhap", lst);
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();   
            }
            else
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không hợp lệ");

            }

              
        }
    }
}
