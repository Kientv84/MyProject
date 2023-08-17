using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110376_TruongChiKien_StudentManagement.COURSE
{
    internal class COURSES
    {
        My_DB mydb = new My_DB();

        public bool insertCourse(int id, string courseName, int hoursNumber, string description, string semester)
        {

            SqlCommand command = new SqlCommand("INSERT INTO course (id, label, period, description, semester)" + "VALUES (@cID,@name,@hrs, @dscr, @semes)", mydb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@dscr", SqlDbType.Text).Value = description;
            command.Parameters.Add("@semes", SqlDbType.VarChar).Value = semester;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))

            {
                mydb.closeConnection();
                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool deleteCourseOnCourseStudent(string studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CourseStudent WHERE studentID = @studentID and courseID = @courseID", mydb.getConnection);

            command.Parameters.Add("@studentID", SqlDbType.VarChar).Value = studentID;
            command.Parameters.Add("@courseID", SqlDbType.Int).Value = courseID;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateCourse(int courseID, string courseName, int hoursNumber, string description, string semester, int teacherid)
        {
            SqlCommand command = new SqlCommand("UPDATE course SET label=@name, period=@hrs, description=@dscr, semester=@semes, teacherid =@tid WHERE id=@cID ", mydb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@dscr", SqlDbType.Text).Value = description;
            command.Parameters.Add("@semes", SqlDbType.VarChar).Value = semester;
            command.Parameters.Add("@tid", SqlDbType.Int).Value = teacherid;


            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool insertCourse(int id, string courseName, int hoursNumber, string description, string semester, int teacherid)
        {

            SqlCommand command = new SqlCommand("INSERT INTO course (id, label, period, description, semester, teacherid)" + "VALUES (@cID,@name,@hrs, @dscr, @semes, @tid)", mydb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@dscr", SqlDbType.Text).Value = description;
            command.Parameters.Add("@semes", SqlDbType.VarChar).Value = semester;
            command.Parameters.Add("@tid", SqlDbType.Int).Value = teacherid;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))

            {
                mydb.closeConnection();
                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool checkCourseName(string courseName, int courseID = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course  WHERE label = @cName And id<> @cID", mydb.getConnection);
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course ", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAll1Coursess(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseById(int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE id = @cID", mydb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool updateCourse(int courseID, string courseName, int hoursNumber, string description, string semester)
        {
            SqlCommand command = new SqlCommand("UPDATE course SET label=@name, period=@hrs, description=@dscr, semester=@semes WHERE id=@cID ", mydb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@dscr", SqlDbType.Text).Value = description;
            command.Parameters.Add("@semes", SqlDbType.VarChar).Value = semester;



            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteCourse(int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM course  WHERE id = @cID", mydb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();

                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        //get the total courses
        public string totalCourses()
        {

            return execCount("SELECT COUNT(*) FROM course");

        }

        public int getCourseIDByCourseName(string courseName)
        {
            int result;
            SqlCommand command = new SqlCommand("SELECT id FROM Course WHERE label = '" + courseName + "'", mydb.getConnection);
            //command.Parameters.Add("@lable", SqlDbType.VarChar).Value = courseName;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                string s = table.Rows[0]["id"].ToString();
                result = Convert.ToInt32(s);
                return result;
            }
            else return 0;
        }

        public bool checkCourseOfCourseStudent(string studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CourseStudent WHERE studentID = @studentID and courseID = @courseID", mydb.getConnection);
            command.Parameters.Add("@studentID", SqlDbType.VarChar).Value = studentID;
            command.Parameters.Add("@courseID", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool insertCourseToCourseStudent(string studentID, string firstName, string lastName, int courseID, string courseName, string semester)
        {
            SqlCommand command = new SqlCommand("INSERT INTO CourseStudent (studentID, fname, lname, courseID, courseName, semester)" + " VALUES(@studentID, @firstName, @lastName, @courseID, @courseName, @semester)", mydb.getConnection);

            command.Parameters.Add("@studentID", SqlDbType.VarChar).Value = studentID;
            command.Parameters.Add("@firstName", SqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@lastName", SqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@courseID", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@courseName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))

            {
                mydb.closeConnection();
                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
