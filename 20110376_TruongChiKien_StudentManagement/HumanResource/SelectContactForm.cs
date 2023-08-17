using Microsoft.Office.Interop.Word;
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

namespace _20110376_TruongChiKien_StudentManagement.HumanResource
{
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }

        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            SqlCommand command = new SqlCommand("SELECT  Id ,  fname  as'First Name',  lname  as 'Last Name',  group_id  as'Group Id' FROM  [Contact]  WHERE  userid  = @uid");
            command.Parameters.Add("@uid", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
            dataGridView2.DataSource = contact.SelectContactList(command);
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ReadOnly = true;
        }


        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ContactForm form = new ContactForm();
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView2.Rows[index];
            form.textBoxID.Text = selectRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_DoubleClick_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

