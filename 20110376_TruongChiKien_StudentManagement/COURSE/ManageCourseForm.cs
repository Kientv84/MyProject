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
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        COURSES course = new COURSES();
        int pos;
        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        public void reloadListBoxData()
        {
            listBoxCourses.DataSource = course.getAllCourses();
            listBoxCourses.ValueMember = "id";
            listBoxCourses.DisplayMember = "label";

            // unselect the item from listbox
            listBoxCourses.SelectedItem = null;

            //display the total courses
            labelTotalCourse.Text = "Total Courses: " + course.totalCourses();
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];
            listBoxCourses.SelectedIndex = index;
            textBoxID.Text = dr.ItemArray[0].ToString();
            textBoxLabel.Text = dr.ItemArray[1].ToString();
            numericUpDownPeriod.Value = int.Parse(dr.ItemArray[2].ToString());
            textBoxDescription.Text = dr.ItemArray[3].ToString();
            textBoxSemester.Text = dr.ItemArray[4].ToString();
        }

    
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(0);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourses().Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }

        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string courseLabel = textBoxLabel.Text;
            int hours = (int)numericUpDownPeriod.Value;
            string description = textBoxDescription.Text;
            string semester = textBoxSemester.Text;


            COURSES course = new COURSES();
            if (courseLabel.Trim() == "")
            {
                MessageBox.Show("New a Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(courseLabel))
            {
                if (course.insertCourse(id, courseLabel, hours, description, semester))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
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

        private void btn_EditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxLabel.Text;
                int hrs = (int)numericUpDownPeriod.Value;
                string descr = textBoxDescription.Text;
                int id = Convert.ToInt32(textBoxID.Text);
                string semester = textBoxSemester.Text;




                if (name.Trim() != "")
                {
                    if (!course.checkCourseName(name, id))
                    {
                        MessageBox.Show("Thí Course Name Already Exitst", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (course.updateCourse(id, name, hrs, descr, semester))
                    {
                        MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter The Course Name", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No Course Selected", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                COURSES course = new COURSES();
                int courseID = Convert.ToInt32(textBoxID.Text);
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Numberic ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void listBoxCourses_DoubleClick(object sender, EventArgs e)
        {
            string courseName = "";
            courseName = textBoxLabel.Text;
            CourseStudentForm.courseName = courseName;
            CourseStudentForm.semester = textBoxSemester.Text;
            CourseStudentForm f = new CourseStudentForm();
            f.ShowDialog();
        }

        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            //display the selected course data
            pos = listBoxCourses.SelectedIndex;
            showData(pos);
        }

        private void btn_AddCourse_Click_1(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBoxID.Text);
            string courseLabel = textBoxLabel.Text;
            int hours = (int)numericUpDownPeriod.Value;
            string description = textBoxDescription.Text;
            string semester = textBoxSemester.Text;
            int teacherid = int.Parse(textBoxTeacherID.Text);

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
                    reloadListBoxData();
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

        private void btn_EditCourse_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxLabel.Text;
                int hrs = (int)numericUpDownPeriod.Value;
                string descr = textBoxDescription.Text;
                int id = Convert.ToInt32(textBoxID.Text);
                string semester = textBoxSemester.Text;
                int teacherid = int.Parse(textBoxTeacherID.Text);



                if (name.Trim() != "")
                {
                    if (!course.checkCourseName(name, id))
                    {
                        MessageBox.Show("Thí Course Name Already Exitst", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (course.updateCourse(id, name, hrs, descr, semester, teacherid))
                    {
                        MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter The Course Name", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No Course Selected", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                COURSES course = new COURSES();
                int courseID = Convert.ToInt32(textBoxID.Text);
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Numberic ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void listBoxCourses_Click_1(object sender, EventArgs e)
        {
            //display the selected course data
            pos = listBoxCourses.SelectedIndex;
            showData(pos);
        }

        private void listBoxCourses_DoubleClick_1(object sender, EventArgs e)
        {
            string courseName = "";
            courseName = textBoxLabel.Text;
            CourseStudentForm.courseName = courseName;
            CourseStudentForm.semester = textBoxSemester.Text;
            CourseStudentForm f = new CourseStudentForm();
            f.ShowDialog();
        }
    }
}

