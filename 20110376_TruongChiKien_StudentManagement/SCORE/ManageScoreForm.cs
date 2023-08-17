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
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        SCORES score = new SCORES();
        STUDENT.STUDENT student = new STUDENT.STUDENT();
        COURSES course = new COURSES();
        string data = "score";
        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            //populate the datagridview with students score
            dataGridViewManageScore.DataSource = score.getStudentsScore();
            dataGridViewManageScore.Columns[0].HeaderText = " ID";
            dataGridViewManageScore.Columns[1].HeaderText = "First name";
            dataGridViewManageScore.Columns[2].HeaderText = "Last name";
            dataGridViewManageScore.Columns[3].HeaderText = "Course ID";
            dataGridViewManageScore.Columns[4].HeaderText = "Label";
            dataGridViewManageScore.Columns[5].HeaderText = "Student score";


        }

        private void buttonShowStudent_Click(object sender, EventArgs e)
        {
            data = "std1";
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate FROM std1");
            dataGridViewManageScore.DataSource = student.getStudents(command);
            dataGridViewManageScore.Columns[0].HeaderText = "ID";
            dataGridViewManageScore.Columns[1].HeaderText = "First name";
            dataGridViewManageScore.Columns[2].HeaderText = "Last name";
            dataGridViewManageScore.Columns[3].HeaderText = "Birthdate";
        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridViewManageScore.DataSource = score.getStudentsScore();
            dataGridViewManageScore.Columns[0].HeaderText = "Student ID";
            dataGridViewManageScore.Columns[3].HeaderText = "Course ID";
            dataGridViewManageScore.Columns[4].HeaderText = "Label";
            dataGridViewManageScore.Columns[5].HeaderText = "Student score";

        }

        private void dataGridViewManageScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void getDataFromDatagridview()
        {
            //if the user select to show student data than we will show only the student id 
            if (data == "std1")
            {
                textBoxStudentID.Text = dataGridViewManageScore.CurrentRow.Cells[0].Value.ToString();

            }

            //if the user select to show student data than we will show the student id + select the course from the cobobox
            else if (data == "score")
            {

                textBoxStudentID.Text = dataGridViewManageScore.CurrentRow.Cells[0].Value.ToString();

                comboBoxCourse.SelectedValue = dataGridViewManageScore.CurrentRow.Cells[3].Value;
                textBoxScore.Text = dataGridViewManageScore.CurrentRow.Cells[5].Value.ToString();

            }


        }

       
      
       

        private void textBoxStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void dataGridViewManageScore_Click(object sender, EventArgs e)
        {
            getDataFromDatagridview();
        }

        private void btn_AddScore_Click_1(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBoxStudentID.Text);
                int courseId = Convert.ToInt32(comboBoxCourse.SelectedValue);
                float scoreValue = float.Parse(textBoxScore.Text);
                string description = textBoxDescription.Text;

                if (!score.studentScoreExists(studentId, courseId))
                {

                    if (score.insertScore(studentId, courseId, scoreValue, description))
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

        private void btn_removeScore_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(dataGridViewManageScore.CurrentRow.Cells[0].Value.ToString());
            int courseId = int.Parse(dataGridViewManageScore.CurrentRow.Cells[3].Value.ToString());

            if (MessageBox.Show("Do You Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentId, courseId))
                {
                    MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewManageScore.DataSource = score.getStudentsScore();
                }
                else
                {
                    MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_AvgScore_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avgScrByCrsF = new avgScoreByCourseForm();
            avgScrByCrsF.Show(this);
        }

        private void buttonShowStudent_Click_1(object sender, EventArgs e)
        {
            data = "std1";
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate FROM std1");
            dataGridViewManageScore.DataSource = student.getStudents(command);
            dataGridViewManageScore.Columns[0].HeaderText = "ID";
            dataGridViewManageScore.Columns[1].HeaderText = "First name";
            dataGridViewManageScore.Columns[2].HeaderText = "Last name";
            dataGridViewManageScore.Columns[3].HeaderText = "Birthdate";
        }

        private void buttonShowScore_Click_1(object sender, EventArgs e)
        {
            data = "score";
            dataGridViewManageScore.DataSource = score.getStudentsScore();
            dataGridViewManageScore.Columns[0].HeaderText = "Student ID";
            dataGridViewManageScore.Columns[3].HeaderText = "Course ID";
            dataGridViewManageScore.Columns[4].HeaderText = "Label";
            dataGridViewManageScore.Columns[5].HeaderText = "Student score";
        }

        private void dataGridViewManageScore_Click_1(object sender, EventArgs e)
        {
            getDataFromDatagridview();
        }
    }
}
