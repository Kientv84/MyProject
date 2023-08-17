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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        COURSES course = new COURSES();
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            comboBoxCourse.SelectedItem = null;
        }
        public void fillCombo(int index)
        {
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            comboBoxCourse.SelectedItem = index;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                textBoxLabel.Text = table.Rows[0][0].ToString();

                textBoxLabel.Text = table.Rows[0][1].ToString();
                numericUpDown1.Value = Int32.Parse(table.Rows[0][2].ToString());
                textBoxDescription.Text = table.Rows[0][3].ToString();
                textBoxSemester.Text = table.Rows[0][4].ToString();
                textBoxTeacherID.Text = table.Rows[0][5].ToString();
            }
            catch
            {

            }
        }

        private void btn_EditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxLabel.Text;
                int hrs = (int)numericUpDown1.Value;
                string descr = textBoxDescription.Text;
                int id = (int)comboBoxCourse.SelectedValue;
                string semester = textBoxSemester.Text;
                int teacherid = int.Parse(textBoxTeacherID.Text);

                if (name.Trim() != "")
                {
                    if (!course.checkCourseName(name, id))
                    {
                        MessageBox.Show("The Course Name Already Exitst", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (course.updateCourse(id, name, hrs, descr, semester, teacherid))
                    {
                        MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_EditCourse_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxLabel.Text;
                int hrs = (int)numericUpDown1.Value;
                string descr = textBoxDescription.Text;
                int id = (int)comboBoxCourse.SelectedValue;
                string semester = textBoxSemester.Text;
                int teacherid = int.Parse(textBoxTeacherID.Text);

                if (name.Trim() != "")
                {
                    if (!course.checkCourseName(name, id))
                    {
                        MessageBox.Show("The Course Name Already Exitst", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (course.updateCourse(id, name, hrs, descr, semester, teacherid))
                    {
                        MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
