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

namespace _20110376_TruongChiKien_StudentManagement.STUDENT
{
    public partial class AddCourceForStudentForm : Form
    {
        public AddCourceForStudentForm()
        {
            InitializeComponent();
        }
        public static string studentID;
        public static string studentFirstName;
        public static string studentLastName;
        STUDENT student = new STUDENT();
        COURSES course = new COURSES();
        My_DB mydb = new My_DB();
        private void AddCourceForStudentForm_Load(object sender, EventArgs e)
        {
            txtStudentID.Text = studentID;
            loadSemester();
        }
        private void loadSemester()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Semester");
            cbBoxSemester.DataSource = student.getStudents(command);
            cbBoxSemester.DisplayMember = "semester";
            cbBoxSemester.ValueMember = "id";
            cbBoxSemester.SelectedItem = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string stringCourseToSaveStudent = student.getCourseOfStudentRegister(studentID);
            string courseName = "";
            foreach (var item in lstBxSelect.Items)
            {
                string semester;
                courseName = item.ToString();
                int courseID = course.getCourseIDByCourseName(courseName);
                if (cbBoxSemester.Text != null)
                {
                    semester = cbBoxSemester.Text;
                    if (course.checkCourseOfCourseStudent(studentID, courseID))
                    {
                        if (course.insertCourseToCourseStudent(studentID, studentFirstName, studentLastName, courseID, courseName, semester))
                        {
                            if (stringCourseToSaveStudent == "")
                            {
                                stringCourseToSaveStudent += courseName;
                            }
                            else
                            {
                                stringCourseToSaveStudent += ", " + courseName;
                            }
                            MessageBox.Show("Successfully registered for the course " + courseName, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Not OK");
                        }
                    }
                    else
                    {
                        MessageBox.Show(courseName + " has been registered by you", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose Semester", "Error Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (student.addCourseStudent(stringCourseToSaveStudent, studentID)) { }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string coursecChoosed = "";
            int courseID;
            try
            {
                if (cbBoxSemester.SelectedItem != null)
                {
                    if (lstBxAvailable.SelectedItem != null)
                    {
                        coursecChoosed = lstBxAvailable.SelectedItem.ToString();
                        if (lstBxAvailable.SelectedIndex != -1) // Kiểm tra xem có phần tử nào được chọn hay không
                        {
                            lstBxAvailable.Items.Remove(coursecChoosed);
                            lstBxSelect.Items.Add(coursecChoosed).ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choose Semester", "Error Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string coursecChoosed = "";
            int courseID;
            try
            {
                if (cbBoxSemester.SelectedItem != null)
                {
                    if (lstBxSelect.SelectedItem != null)
                    {
                        coursecChoosed = lstBxSelect.SelectedItem.ToString();
                        if (lstBxSelect.SelectedIndex != -1) // Kiểm tra xem có phần tử nào được chọn hay không
                        {

                            lstBxSelect.Items.Remove(coursecChoosed);
                            lstBxAvailable.Items.Add(coursecChoosed).ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choose Semester", "Error Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstBxAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBxAvailable_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void lstBxSelect_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
            btnAdd.Enabled = false;
        }
        private void loadAvailableCourseBySemester(string semester)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM course where semester = '" + semester + "'", mydb.getConnection);

            //command.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int courseID = reader.GetInt32(0);
                string courseName = reader.GetString(1);

                // Đổ từng sản phẩm vào ListBox
                lstBxAvailable.Items.Add(courseName);
            }

            // Đóng đối tượng SqlDataReader sau khi sử dụng xong
            reader.Close();

            // Đóng kết nối và giải phóng tài nguyên
            mydb.closeConnection();
        }

        private void cbBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBxAvailable.Items.Clear();
            lstBxSelect.Items.Clear();
            string semesterChoose = "";
            if (cbBoxSemester.SelectedItem != null)
            {
                semesterChoose = ((DataRowView)cbBoxSemester.SelectedItem)["semester"].ToString();
            }
            else
            {
                semesterChoose = null;
            }
            loadAvailableCourseBySemester(semesterChoose);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string coursecChoosed = "";
            int courseID;
            try
            {
                if (cbBoxSemester.SelectedItem != null)
                {
                    if (lstBxAvailable.SelectedItem != null)
                    {
                        coursecChoosed = lstBxAvailable.SelectedItem.ToString();
                        if (lstBxAvailable.SelectedIndex != -1) // Kiểm tra xem có phần tử nào được chọn hay không
                        {
                            lstBxAvailable.Items.Remove(coursecChoosed);
                            lstBxSelect.Items.Add(coursecChoosed).ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choose Semester", "Error Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            string coursecChoosed = "";
            int courseID;
            try
            {
                if (cbBoxSemester.SelectedItem != null)
                {
                    if (lstBxSelect.SelectedItem != null)
                    {
                        coursecChoosed = lstBxSelect.SelectedItem.ToString();
                        if (lstBxSelect.SelectedIndex != -1) // Kiểm tra xem có phần tử nào được chọn hay không
                        {

                            lstBxSelect.Items.Remove(coursecChoosed);
                            lstBxAvailable.Items.Add(coursecChoosed).ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choose Semester", "Error Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string stringCourseToSaveStudent = student.getCourseOfStudentRegister(studentID);
            string courseName = "";
            foreach (var item in lstBxSelect.Items)
            {
                string semester;
                courseName = item.ToString();
                int courseID = course.getCourseIDByCourseName(courseName);
                if (cbBoxSemester.Text != null)
                {
                    semester = cbBoxSemester.Text;
                    if (course.checkCourseOfCourseStudent(studentID, courseID))
                    {
                        if (course.insertCourseToCourseStudent(studentID, studentFirstName, studentLastName, courseID, courseName, semester))
                        {
                            if (stringCourseToSaveStudent == "")
                            {
                                stringCourseToSaveStudent += courseName;
                            }
                            else
                            {
                                stringCourseToSaveStudent += ", " + courseName;
                            }
                            MessageBox.Show("Successfully registered for the course " + courseName, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Not OK");
                        }
                    }
                    else
                    {
                        MessageBox.Show(courseName + " has been registered by you", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose Semester", "Error Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (student.addCourseStudent(stringCourseToSaveStudent, studentID)) { }
        }

        private void lstBxAvailable_Click_1(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void lstBxSelect_Click_1(object sender, EventArgs e)
        {
            {
                btnRemove.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private void cbBoxSemester_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lstBxAvailable.Items.Clear();
            lstBxSelect.Items.Clear();
            string semesterChoose = "";
            if (cbBoxSemester.SelectedItem != null)
            {
                semesterChoose = ((DataRowView)cbBoxSemester.SelectedItem)["semester"].ToString();
            }
            else
            {
                semesterChoose = null;
            }
            loadAvailableCourseBySemester(semesterChoose);
        }
    }
}
