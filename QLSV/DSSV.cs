using OfficeOpenXml;
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
    public partial class DSSV : Form
    {
        
        public DSSV()
        {
            InitializeComponent();
            
        }
        private string tukhoa="";
        private DataTable dataTable;

        private void DSSV_Load(object sender, EventArgs e)
        {
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
            dataTable  =  new Database().SelectData("SelectAllSinhVien",lstPara);

            dgvSinhVien.Columns["masinhvien"].HeaderText = "mã SV";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ Tên";
            dgvSinhVien.Columns["nsinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["gt"].HeaderText = "Giới Tính";
            dgvSinhVien.Columns["quequan"].HeaderText = "Quê Quán";
            dgvSinhVien.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvSinhVien.Columns["email"].HeaderText = "Email";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện Thoại";


        }

        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {//cap nhat
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txttimkiem.Text;
            LoadDSSV();
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(dgvSinhVien.RowCount != 0)
            {
                
                int indexRow = dgvSinhVien.CurrentCell.RowIndex;
                var msv = dgvSinhVien.Rows[indexRow].Cells["masinhvien"].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("bạn có chắc chắn muốn xóa sinh viên [" + dgvSinhVien.Rows[indexRow].Cells["hoten"].Value.ToString() + "]",
                    "xác nhận xóa sinh viên",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ))
                {
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = msv
                    });
                    var rs = new Database().ExeCute("xoasinhvien", lst);
                    if(rs == 1)
                    {
                        MessageBox.Show("sinh viên đã được xóa");
                        LoadDSSV();
                        return;
                    }
                    else
                    {

                        MessageBox.Show("xóa sinh viên thất bại");
                        return;
                       
                    }

                     }    
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            string filePath = "";

            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Excel | *.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Invalid!!!");
                return;
            }
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    p.Workbook.Properties.Author = "Phan Văn Đạt";
                    p.Workbook.Properties.Title = "Report File";
                    p.Workbook.Worksheets.Add("Sheet 1");

                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    ws.Name = "Sheet 1";
                    ws.Cells.Style.Font.Size = 12;
                    ws.Cells.Style.Font.Bold = true;
                    ws.Cells.Style.Font.Name = "Times New Roman";

                    string[] arrColumnHeader =
                    {
                        "Mã sinh viên","Họ tên","Ngày sinh","Giới tính","Địa chỉ","Điện thoại","Email"//headerText
                    };
                    var countColHeader = arrColumnHeader.Count();
                    ws.Cells[1, 1].Value = "Danh sách sinh viên";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    int colHeader = 1;
                    int rowHeader = 2;
                    foreach (var header in arrColumnHeader)
                    {

                        var cell = ws.Cells[rowHeader, colHeader];

                        var fill = cell.Style.Fill;
                        fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);


                        cell.Value = header;
                        colHeader++;
                    }

                    int colIndex = 1;
                    int rowIndex = 2;

                    foreach (DataRow dr in dataTable.Rows)//fields in obj
                    {
                        colIndex = 1;
                        rowIndex++;
                        ws.Cells[rowIndex, colIndex++].Value = dr["masinhvien"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["hoten"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["nsinh"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["gt"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["diachi"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["dienthoai"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["email"].ToString();


                    }
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("thất bại: " + ex);
            }
        }
    }
}
