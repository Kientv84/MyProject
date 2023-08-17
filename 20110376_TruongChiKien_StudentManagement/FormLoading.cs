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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.ShowDialog();
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            Okbtn.Enabled = false;
            int x = 0;
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 10000;
            progressBar1.Value = 10;
            progressBar1.Step = 3;
            for (x = 1; x <= 10000; x++)
            {
                progressBar1.PerformStep();
            }
            Okbtn.Enabled = true;

        }
    }
}
