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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void btn_removeCourse_Click(object sender, EventArgs e)
        {


            try
            {
                COURSES course = new COURSES();
                int courseID = Convert.ToInt32(textBoxCourseID.Text);
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void RemoveCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_removeCourse_Click_1(object sender, EventArgs e)
        {

            try
            {
                COURSES course = new COURSES();
                int courseID = Convert.ToInt32(textBoxCourseID.Text);
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
