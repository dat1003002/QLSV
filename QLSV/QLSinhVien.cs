﻿using System;
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
    public partial class QLSinhVien : Form
    {
        public QLSinhVien()
        {
            InitializeComponent();
        }

        private void QLSinhVien_Load(object sender, EventArgs e)
        {
            var db = new Database();
            //dgvData.DataSource = db.SelectData(null);
        }
    }
}
