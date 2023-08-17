using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement.STUDENT
{
    public partial class SearchResultForm : Form
    {
        private DataTable table;
        public SearchResultForm(DataTable table)
        {
            InitializeComponent();
            this.table = table;
        }

       

        private void SearchResultForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet3.std1' table. You can move, or remove it, as needed.
            this.std1TableAdapter.Fill(this.qlsvDataSet1.std1);
            dataGridView1.DataSource = table;
        }
    }
}
