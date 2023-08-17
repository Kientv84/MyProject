using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement
{
    public partial class CofirmCodeForm : Form
    {
        public CofirmCodeForm()
        {
            InitializeComponent();
        }
        public static string confirmCode;
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (confirmCode == txtCfCode.Text)
            {
                MessageBox.Show("Congratulation! Email has been confirmed!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                RegisterForm.verify = true;
            }
            else
            {
                MessageBox.Show("Invalid Code!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCfCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CofirmCodeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
