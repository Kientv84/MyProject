using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement
{
    public partial class ListAccountRegister : Form
    {
        public ListAccountRegister()
        {
            InitializeComponent();
        }
        Newuser user = new Newuser();
        private void ListAccountRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.RegisterAccount' table. You can move, or remove it, as needed.
            this.registerAccountTableAdapter.Fill(this.qlsvDataSet5.RegisterAccount);
            SqlCommand command = new SqlCommand("SELECT * FROM RegisterAccount");
            dataGridView1.DataSource = user.getAccount(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            string email;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                {
                    username = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    password = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    email = dataGridView1.Rows[i].Cells[3].Value.ToString();

                    if (user.insertUser(username, password, email))
                    {
                        user.deleteRegistatrion(username);
                        MessageBox.Show("insert succeed", "insert student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("error!", "insert student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            ListAccountRegister_Load(null, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
