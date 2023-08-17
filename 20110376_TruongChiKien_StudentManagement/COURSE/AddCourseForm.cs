using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement.COURSE
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxCourseID.Text);
            string courseLabel = textBoxLabel.Text;
            int hours = (int)numericUpDown1.Value;
            string description = textBoxDescription.Text;
            string semester = textBoxSemester.Text;
            int teacherid = int.Parse(textBoxTeacherID.Text.Trim());
            COURSES course = new COURSES();
            if (courseLabel.Trim() == "")
            {
                MessageBox.Show("New a Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(courseLabel))
            {
                if (course.insertCourse(id, courseLabel, hours, description, semester, teacherid))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void textBoxCourseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}

