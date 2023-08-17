using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement.SCORE
{
    public partial class avgScoreByCourseForm : Form
    {
        public avgScoreByCourseForm()
        {
            InitializeComponent();
        }

        private void avgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            SCORES score = new SCORES();
            dataGridViewavgScore.DataSource = score.avgScoreByCourse();
            dataGridViewavgScore.AllowUserToAddRows = false;
            try
            {
                int len = this.dataGridViewavgScore.Rows.Count;
                for (int i = 0; i < len; i++)
                {

                    string s = dataGridViewavgScore.Rows[i].Cells[0].Value.ToString();
                    string k = dataGridViewavgScore.Rows[i].Cells[1].Value.ToString();
                    double kq = Convert.ToDouble(k);
                    chart1.Series["Score"].Points.AddXY(s, k);
                }
            }
            catch (NullReferenceException ee)
            {
                ee.InnerException.ToString();
            }

        }
    }
}
