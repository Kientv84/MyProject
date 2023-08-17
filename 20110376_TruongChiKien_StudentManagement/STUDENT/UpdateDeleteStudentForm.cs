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
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        
        STUDENT student = new STUDENT();
        private void find_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBoxID.Text);
                SqlCommand command = new SqlCommand("SELECT id , fname, lname, bdate, gender, phone, email, major, hometown, address, picture FROM std1 WHERE id =  " + id);

                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                    TextBoxLname.Text = table.Rows[0]["lname"].ToString();

                    DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        RadioButtonFemale.Checked = true;
                    }
                    else
                    {
                        RadioButtonMale.Checked = true;
                    }
                    TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    TextBoxEmail.Text = table.Rows[0]["email"].ToString();
                    TextBoxMajor.Text = table.Rows[0]["major"].ToString();
                    TextBoxhtown.Text = table.Rows[0]["hometown"].ToString();
                    TextBoxAddress.Text = table.Rows[0]["address"].ToString();


                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxStudentImage.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Student Id ", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void firstname_Click(object sender, EventArgs e)
        {

        }

        private void ButtoneEditStudent_Click(object sender, EventArgs e)
        {

        }
        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                || (TextBoxLname.Text.Trim() == "")
                || (TextBoxAddress.Text.Trim() == "")
                || (TextBoxPhone.Text.Trim() == "")
                || (TextBoxEmail.Text.Trim() == "")
                || (TextBoxMajor.Text.Trim() == "")
                || (TextBoxhtown.Text.Trim() == "")
                || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void RadioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBoxMajor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBoxhtown_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void findFname_Click(object sender, EventArgs e)
        {
            string firstname = TextBoxFname.Text.Trim();

            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std1 WHERE fname  = @firstname");
            command.Parameters.Add("@firstname", SqlDbType.VarChar).Value = firstname;

            DataTable table = student.getStudents(command);

            if (table.Rows.Count > 0)
            {
                SearchResultForm searchResultForm = new SearchResultForm(table);
                searchResultForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void buttonlnfind_Click(object sender, EventArgs e)
        {
            string lastname = TextBoxLname.Text.Trim();

            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std1 WHERE lname  = @lastname");
            command.Parameters.Add("@lastname", SqlDbType.VarChar).Value = lastname;

            DataTable table = student.getStudents(command);

            if (table.Rows.Count > 0)
            {
                SearchResultForm searchResultForm = new SearchResultForm(table);
                searchResultForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void find_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBoxID.Text);
                SqlCommand command = new SqlCommand("SELECT id , fname, lname, bdate, gender, phone, email, major, hometown, address, picture FROM std1 WHERE id =  " + id);

                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                    TextBoxLname.Text = table.Rows[0]["lname"].ToString();

                    DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        RadioButtonFemale.Checked = true;
                    }
                    else
                    {
                        RadioButtonMale.Checked = true;
                    }
                    TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    TextBoxEmail.Text = table.Rows[0]["email"].ToString();
                    TextBoxMajor.Text = table.Rows[0]["major"].ToString();
                    TextBoxhtown.Text = table.Rows[0]["hometown"].ToString();
                    TextBoxAddress.Text = table.Rows[0]["address"].ToString();


                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxStudentImage.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Student Id ", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void findFname_Click_1(object sender, EventArgs e)
        {
            string firstname = TextBoxFname.Text.Trim();

            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std1 WHERE fname  = @firstname");
            command.Parameters.Add("@firstname", SqlDbType.VarChar).Value = firstname;

            DataTable table = student.getStudents(command);

            if (table.Rows.Count > 0)
            {
                SearchResultForm searchResultForm = new SearchResultForm(table);
                searchResultForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonlnfind_Click_1(object sender, EventArgs e)
        {
            string lastname = TextBoxLname.Text.Trim();

            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std1 WHERE lname  = @lastname");
            command.Parameters.Add("@lastname", SqlDbType.VarChar).Value = lastname;

            DataTable table = student.getStudents(command);

            if (table.Rows.Count > 0)
            {
                SearchResultForm searchResultForm = new SearchResultForm(table);
                searchResultForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                upload.Image = Image.FromFile(opf.FileName);
            }
        }

        private void ButtoneEditStudent_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id;
                string fname = TextBoxFname.Text;
                string lname = TextBoxLname.Text;
                DateTime bdate = DateTimePicker1.Value;
                string phone = TextBoxPhone.Text;
                string email = TextBoxEmail.Text;
                string major = TextBoxMajor.Text;
                string hometown = TextBoxhtown.Text;
                string adrs = TextBoxAddress.Text;
                string gender = "Male";
                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                MemoryStream pic = new MemoryStream();
                int born_year = DateTimePicker1.Value.Year;
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
                        id = Convert.ToInt32(TextBoxID.Text);
                        PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
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

        private void ButtonRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(TextBoxID.Text);
                if (MessageBox.Show("Are you sure you want to delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (student.deleteStudent(studentID))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBoxID.Text = "";
                        TextBoxLname.Text = "";
                        TextBoxFname.Text = "";
                        TextBoxAddress.Text = "";
                        TextBoxPhone.Text = "";
                        TextBoxEmail.Text = "";
                        TextBoxMajor.Text = "";
                        TextBoxhtown.Text = "";
                        DateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
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

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            AddCourceForStudentForm.studentID = TextBoxID.Text;
            AddCourceForStudentForm.studentFirstName = TextBoxFname.Text;
            AddCourceForStudentForm.studentLastName = TextBoxLname.Text;
            AddCourceForStudentForm f = new AddCourceForStudentForm();
            f.ShowDialog();
        }
    }
}
