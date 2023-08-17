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

namespace _20110376_TruongChiKien_StudentManagement.STUDENT
{
    public partial class studentListForm : Form
    {
        public studentListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void studentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet1.std1' table. You can move, or remove it, as needed.
            this.std1TableAdapter.Fill(this.qlsvDataSet2.std1);
            SqlCommand command = new SqlCommand("SELECT * FROM std1");
            DataGridView1.ReadOnly = true;
            //Xu lys hinh anh, code co tam khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[10];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;

            
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std1");
            DataGridView1.ReadOnly = true;
            //Xu lys hinh anh, code co tam khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[10];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {


        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDeletStdF = new UpdateDeleteStudentForm();
            
            updateDeletStdF.TextBoxID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeletStdF.TextBoxFname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeletStdF.TextBoxLname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeletStdF.DateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;

            if ((DataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                updateDeletStdF.RadioButtonFemale.Checked = true;
            }
            else
            {
                updateDeletStdF.RadioButtonMale.Checked = true;
            }

            updateDeletStdF.TextBoxPhone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeletStdF.TextBoxEmail.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            updateDeletStdF.TextBoxMajor.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            updateDeletStdF.TextBoxhtown.Text = DataGridView1.CurrentRow.Cells[8].Value.ToString();
            updateDeletStdF.TextBoxAddress.Text = DataGridView1.CurrentRow.Cells[9].Value.ToString();

            byte[] pic;
            pic = (byte[])DataGridView1.CurrentRow.Cells[10].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeletStdF.PictureBoxStudentImage.Image = Image.FromStream(picture);
            updateDeletStdF.Show();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonRefresh_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std1");
            DataGridView1.ReadOnly = true;
            //Xu lys hinh anh, code co tam khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[10];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeletStdF = new UpdateDeleteStudentForm();
            updateDeletStdF.TextBoxID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeletStdF.TextBoxFname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeletStdF.TextBoxLname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeletStdF.DateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;

            if ((DataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                updateDeletStdF.RadioButtonFemale.Checked = true;
            }
            else
            {
                updateDeletStdF.RadioButtonMale.Checked = true;
            }

            updateDeletStdF.TextBoxPhone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeletStdF.TextBoxEmail.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            updateDeletStdF.TextBoxMajor.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            updateDeletStdF.TextBoxhtown.Text = DataGridView1.CurrentRow.Cells[8].Value.ToString();
            updateDeletStdF.TextBoxAddress.Text = DataGridView1.CurrentRow.Cells[9].Value.ToString();

            byte[] pic;
            pic = (byte[])DataGridView1.CurrentRow.Cells[10].Value;
            MemoryStream picture = new MemoryStream(pic);

            updateDeletStdF.Show();
        }
    }
}
