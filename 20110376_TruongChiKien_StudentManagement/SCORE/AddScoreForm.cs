using _20110376_TruongChiKien_StudentManagement.COURSE;
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

namespace _20110376_TruongChiKien_StudentManagement.SCORE
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();

        }

        SCORES score = new SCORES();
        STUDENT.STUDENT student = new STUDENT.STUDENT();
        COURSES course = new COURSES();

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std1 ");
            dataGridViewAddScore.DataSource = student.getStudents(command);

            dataGridViewAddScore.Columns[0].HeaderText = "ID";
            dataGridViewAddScore.Columns[1].HeaderText = "First name";
            dataGridViewAddScore.Columns[2].HeaderText = "Last name";
        }

        private void dataGridViewAddScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBoxStudentID.Text);
                int courseId = Convert.ToInt32(comboBoxCourse.SelectedValue);
                float scoreValue = float.Parse(textBoxScore.Text);
                string description = textBoxDescription.Text;
                string semester = textBoxSemester.Text;

                if (!score.studentScoreExists(studentId, courseId))
                {

                    if (score.insertScore(studentId, courseId, scoreValue, description, semester))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //only alow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void comboBoxCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewAddScore_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Text = dataGridViewAddScore.CurrentRow.Cells[0].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddScore_Click_1(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBoxStudentID.Text);
                int courseId = Convert.ToInt32(comboBoxCourse.SelectedValue);
                float scoreValue = float.Parse(textBoxScore.Text);
                string description = textBoxDescription.Text;
                string semester = textBoxSemester.Text;

                if (!score.studentScoreExists(studentId, courseId))
                {

                    if (score.insertScore(studentId, courseId, scoreValue, description, semester))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAddScore_Click_1(object sender, EventArgs e)
        {
            textBoxStudentID.Text = dataGridViewAddScore.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
