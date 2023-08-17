using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement.HumanResource
{
    public partial class ListAccountRegisterHR : Form
    {
        public ListAccountRegisterHR()
        {
            InitializeComponent();
        }
        USER user = new USER();
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Id;
            string fname;
            string lname;
            string username;
            string password;
            byte[] image;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                {
                    Id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    fname = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    lname = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    username = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    password = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    image = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
                    MemoryStream picture = new MemoryStream(image);

                    if (user.insertUSer(Id, fname, lname, username, password, picture))
                    {
                        if (user.deleteRegistatrionHR(username))
                        {
                            MessageBox.Show("Accept Account Successfully!", "Accept Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("error!", "Accept Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            ListAccountRegisterHR_Load_1(null, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListAccountRegisterHR_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsvDataSet11.RegisterAccountHR' table. You can move, or remove it, as needed.
            this.registerAccountHRTableAdapter1.Fill(this.qlsvDataSet11.RegisterAccountHR);
            // TODO: This line of code loads data into the 'qlsvDataSet9.RegisterAccountHR' table. You can move, or remove it, as needed.
            this.registerAccountHRTableAdapter.Fill(this.qlsvDataSet9.RegisterAccountHR);
            SqlCommand command = new SqlCommand("SELECT * FROM RegisterAccountHR");
            DataGridViewImageColumn picColHumanResourse = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = user.getAccount(command);
            picColHumanResourse = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picColHumanResourse.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
