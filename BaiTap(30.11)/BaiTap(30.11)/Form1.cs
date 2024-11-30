using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_30._11_
{
    public partial class Form1 : Form
    {
        List<Form2> nv;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtaGV1.Columns.Add("MSNV", "MSNV");
            dtaGV1.Columns.Add("TenNV", "Tên NV");
            dtaGV1.Columns.Add("LuongCB", "Lương CB");


            dtaGV1.Rows.Add("NV001", "Nguyễn Thị Thu Hiền", 8500000);

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtaGV1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dtaGV1.SelectedRows[0];


                string employeeID = selectedRow.Cells[0].Value.ToString();
                string employeeName = selectedRow.Cells[1].Value.ToString();
                string employeeSalary = selectedRow.Cells[2].Value.ToString();


                Form2 nv = new Form2(employeeID, employeeName, employeeSalary);
                if (nv.ShowDialog() == DialogResult.OK)
                {

                    selectedRow.Cells[0].Value = nv.ms;
                    selectedRow.Cells[1].Value = nv.ten;
                    selectedRow.Cells[2].Value = nv.luong;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 nv = new Form2();
            if (nv.ShowDialog() == DialogResult.OK)
            {

                dtaGV1.Rows.Add(nv.ms, nv.ten, nv.luong);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtaGV1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dtaGV1.Rows.Remove(dtaGV1.SelectedRows[0]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dtaGV1.Columns.Add("MSNV", "MSNV");
            dtaGV1.Columns.Add("TenNV", "Tên NV");
            dtaGV1.Columns.Add("LuongCB", "Lương CB");


            dtaGV1.Rows.Add("NV001", "Nguyễn Thị Thu Hiền", 8500000);
        }
    }
}
