using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement.STUDENT
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsvDataSet7.std1' table. You can move, or remove it, as needed.
            this.std1TableAdapter2.Fill(this.qlsvDataSet7.std1);
            // TODO: This line of code loads data into the 'qlsvDataSet6.std1' table. You can move, or remove it, as needed.
            this.std1TableAdapter1.Fill(this.qlsvDataSet6.std1);
            // TODO: This line of code loads data into the 'qLSVDataSet5.std1' table. You can move, or remove it, as needed.
            this.std1TableAdapter.Fill(this.qlsvDataSet.std1);
            fillGrid(new SqlCommand("SELECT * FROM std1"));
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

            // Dem sinh vien
            LabelTotalStudents.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }

        
        private void buttonSearch_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM std1 WHERE CONCAT(id,fname,lname,address,phone,email,major,hometown) LIKE '%" + textBoxSearch.Text + "%'");
            fillGrid(command);
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxMajor.Text = "";
            textBoxHtown.Text = "";
            textBoxAddr.Text = "";
            pictureBoxStudentImage.Image = null;
            radioButtonMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + textBoxID.Text);
            if ((pictureBoxStudentImage.Image == null))
            {
                MessageBox.Show("No Image In The PictureBox");

            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxStudentImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }
        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "")
                || (textBoxLname.Text.Trim() == "")
                || (textBoxAddr.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (textBoxEmail.Text.Trim() == "")
                || (textBoxMajor.Text.Trim() == "")
                || (textBoxHtown.Text.Trim() == "")
                || (pictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string major = textBoxMajor.Text;
            string hometown = textBoxHtown.Text;
            string adrs = textBoxAddr.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, email, major, hometown, adrs, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                string fname = textBoxFname.Text;
                string lname = textBoxLname.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = textBoxPhone.Text;
                string email = textBoxEmail.Text;
                string major = textBoxMajor.Text;
                string hometown = textBoxHtown.Text;
                string adrs = textBoxAddr.Text;
                string gender = "Male";
                if (radioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                MemoryStream pic = new MemoryStream();
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    try
                    {
                        id = Convert.ToInt32(textBoxID.Text);
                        pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
                        if (student.updateStudent(id, fname, lname, bdate, gender, phone, email, major, hometown, adrs, pic))
                        {
                            MessageBox.Show("New Student Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Student Id ", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxID.Text);
                if (MessageBox.Show("Are you sure you want to delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (student.deleteStudent(studentID))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxID.Text = "";
                        textBoxLname.Text = "";
                        textBoxFname.Text = "";
                        textBoxAddr.Text = "";
                        textBoxPhone.Text = "";
                        textBoxEmail.Text = "";
                        textBoxMajor.Text = "";
                        textBoxHtown.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBoxStudentImage.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Student not deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std1 WHERE CONCAT(id,fname,lname,address,phone,email,major,hometown) LIKE '%" + textBoxSearch.Text + "%'");
            fillGrid(command);
        }

        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxMajor.Text = "";
            textBoxHtown.Text = "";
            textBoxAddr.Text = "";
            pictureBoxStudentImage.Image = null;
            radioButtonMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonDownload_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + textBoxID.Text);
            if ((pictureBoxStudentImage.Image == null))
            {
                MessageBox.Show("No Image In The PictureBox");

            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxStudentImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxID.Text);
                if (MessageBox.Show("Are you sure you want to delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (student.deleteStudent(studentID))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxID.Text = "";
                        textBoxLname.Text = "";
                        textBoxFname.Text = "";
                        textBoxAddr.Text = "";
                        textBoxPhone.Text = "";
                        textBoxEmail.Text = "";
                        textBoxMajor.Text = "";
                        textBoxHtown.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBoxStudentImage.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Student not deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id;
                string fname = textBoxFname.Text;
                string lname = textBoxLname.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = textBoxPhone.Text;
                string email = textBoxEmail.Text;
                string major = textBoxMajor.Text;
                string hometown = textBoxHtown.Text;
                string adrs = textBoxAddr.Text;
                string gender = "Male";
                if (radioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                MemoryStream pic = new MemoryStream();
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    try
                    {
                        id = Convert.ToInt32(textBoxID.Text);
                        pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
                        if (student.updateStudent(id, fname, lname, bdate, gender, phone, email, major, hometown, adrs, pic))
                        {
                            MessageBox.Show("New Student Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Student Id ", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string major = textBoxMajor.Text;
            string hometown = textBoxHtown.Text;
            string adrs = textBoxAddr.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, email, major, hometown, adrs, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {

            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }

            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxMajor.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxHtown.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBoxAddr.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxStudentImage.Image = Image.FromStream(picture);
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
