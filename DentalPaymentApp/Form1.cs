using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalPaymentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateTotal(object sender, EventArgs e)
        {
            int total = 0;
            if(chkClean.Checked)
                total += 100000;
            if (chkWhitening.Checked)
                total += 1200000;
            if (chkXRay.Checked)
                total += 200000;
            total += (int)numFilling.Value * 80000;

            txtTotal.Text = total.ToString();
        }

        private void tbnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = 0;
            if (chkClean.Checked) total += 100000;
            if (chkWhitening.Checked) total += 1200000;
            if (chkXRay.Checked) total += 200000;
            total += (int)numFilling.Value * 80000;

            txtTotal.Text = total.ToString();

            MessageBox.Show($"Tổng tiền: {total} VND", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
