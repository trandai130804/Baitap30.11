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
    public partial class Form2 : Form
    {
        public string ms { get; set; }
        public string ten { get; set; }
        public int luong { get; set; }
        public Form2(string MS = "", string Ten = "", string Luong = "0")
        {
            InitializeComponent();
            txtms.Text = MS;
            txtten.Text = Ten;
            txtluong.Text = int.TryParse(Luong, out int parsedSalary) ? parsedSalary.ToString() : "0";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            ms = txtms.Text;
            ten = txtten.Text;
            if (int.TryParse(txtluong.Text, out int Luong))
            {
                luong = Luong;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lương phải là một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
