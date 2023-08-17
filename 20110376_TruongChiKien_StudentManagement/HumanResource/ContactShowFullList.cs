using _20110376_TruongChiKien_StudentManagement.SCORE;
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
    public partial class ContactShowFullList : Form
    {
        public ContactShowFullList()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        GROUP group = new GROUP();
        SCORES score = new SCORES();
        private void ContactShowFullList_Load(object sender, EventArgs e)
        {
            this.listBoxContact.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            this.listBoxContact.ValueMember = "Id";
            this.listBoxContact.DisplayMember = "name";
            this.listBoxContact.SelectedItem = null;
            SqlCommand command = new SqlCommand("SELECT Contact.Id,  lname as 'Last Name', fname as 'First Name', [Group].name as 'Group', phone as 'Phone', email as 'Email', address as 'Address', pic as 'Picture' FROM [Contact] INNER JOIN [Group] ON Contact.group_id = [Group].Id WHERE [Contact].userid = " + GLOBAL.GlobalUserId);
            dataGridViewContact.ReadOnly = true;
            dataGridViewContact.AllowUserToAddRows = false;
        }
        public void loadDataGridView(SqlCommand command)
        {
            this.dataGridViewContact.ReadOnly = true;

            DataGridViewImageColumn picol = new DataGridViewImageColumn();

            this.dataGridViewContact.RowTemplate.Height = 80;
            this.dataGridViewContact.DataSource = contact.getContact(command);
            picol = (DataGridViewImageColumn)dataGridViewContact.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewContact.AllowUserToAddRows = false;

            for (int i = 0; i < this.dataGridViewContact.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    this.dataGridViewContact.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Contact.Id,  lname as 'Last Name', fname as 'First Name', [Group].name as 'Group', phone as 'Phone', email as 'Email', address as 'Address', pic as 'Picture' FROM [Contact] INNER JOIN [Group] ON Contact.group_id = [Group].Id WHERE [Contact].userid = " + GLOBAL.GlobalUserId);
            this.loadDataGridView(command);
        }

        private void dataGridViewContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewContact_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataGridViewContact.CurrentRow.Cells[0].Value.ToString());
            ListStudentCourseForm listStd = new ListStudentCourseForm();
            listStd.reloadListBoxData(id);
            listStd.Show();
        }

        //private void dataGridViewContact_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAddress.Text = this.dataGridViewContact.CurrentRow.Cells[6].Value.ToString().Trim();
        //}

        private void listBoxContact_Click(object sender, EventArgs e)
        {
            int groupId = (Int32)this.listBoxContact.SelectedValue;
            SqlCommand command = new SqlCommand("SELECT Contact.Id,  lname as 'Last Name', fname as 'First Name', [Group].name as 'Group', phone as 'Phone', email as 'Email', address as 'Address', pic as 'Picture' FROM [Contact] INNER JOIN [Group] ON Contact.group_id = [Group].Id " +
                "WHERE [Contact].userid = @userid AND [Contact].group_id = @groupid");
            command.Parameters.Add("@userid", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
            command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupId;
            this.loadDataGridView(command);
        }

        private void buttonShow_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Contact.Id,  lname as 'Last Name', fname as 'First Name', [Group].name as 'Group', phone as 'Phone', email as 'Email', address as 'Address', pic as 'Picture' FROM [Contact] INNER JOIN [Group] ON Contact.group_id = [Group].Id WHERE [Contact].userid = " + GLOBAL.GlobalUserId);
            this.loadDataGridView(command);
        }

        private void dataGridViewContact_Click(object sender, EventArgs e)
        {
            this.textBoxAddress.Text = this.dataGridViewContact.CurrentRow.Cells[6].Value.ToString().Trim();
        }

        private void dataGridViewContact_DoubleClick_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataGridViewContact.CurrentRow.Cells[0].Value.ToString());
            ListStudentCourseForm listStd = new ListStudentCourseForm();
            listStd.reloadListBoxData(id);
            listStd.Show();
        }

        private void listBoxContact_Click_1(object sender, EventArgs e)
        {
            int groupId = (Int32)this.listBoxContact.SelectedValue;
            SqlCommand command = new SqlCommand("SELECT Contact.Id,  lname as 'Last Name', fname as 'First Name', [Group].name as 'Group', phone as 'Phone', email as 'Email', address as 'Address', pic as 'Picture' FROM [Contact] INNER JOIN [Group] ON Contact.group_id = [Group].Id " +
                "WHERE [Contact].userid = @userid AND [Contact].group_id = @groupid");
            command.Parameters.Add("@userid", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
            command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupId;
            this.loadDataGridView(command);
        }
    }
}