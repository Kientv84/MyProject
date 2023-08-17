using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110376_TruongChiKien_StudentManagement.STUDENT
{
    internal class STUDENT
    {
        My_DB mydb = new My_DB();
        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string email, string major, string hometown, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO STD1 (id, fname, lname, bdate, gender, phone, email, major, hometown, address, picture )" +
                "VALUES(@id, @fn, @ln, @bdt,@gdr, @phn, @email, @major, @htown, @adrs, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@major", SqlDbType.VarChar).Value = major;
            command.Parameters.Add("@htown", SqlDbType.VarChar).Value = hometown;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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

        public bool addCourseStudent(string courseName, string studentID)
        {
            SqlCommand command = new SqlCommand("UPDATE std1 SET selectedCourse= @selectedCourse  where id = @studentID", mydb.getConnection);

            command.Parameters.Add("@selectedCourse", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@studentID", SqlDbType.VarChar).Value = studentID;

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

        public string getCourseOfStudentRegister(string studentID)
        {
            string result;
            SqlCommand command = new SqlCommand("SELECT selectedCourse FROM std1 where id = @id  ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = studentID;

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                result = table.Rows[0]["selectedCourse"].ToString();
                return result;
            }
            else return null;
        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string email, string major, string hometown, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std1 SET  fname = @fn, lname = @ln, bdate = @bdt, gender = @gdr, phone = @phn, email = @email, major = @major, hometown = @htown, address = @adrs, picture = @pic WHERE id =@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@major", SqlDbType.VarChar).Value = major;
            command.Parameters.Add("@htown", SqlDbType.VarChar).Value = hometown;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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

        public bool deleteStudent(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std1 WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
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
        //create a function to execute the count queries
        public string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalStudent()
        {

            return execCount("SELECT COUNT(*) FROM std1");

        }
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std1 WHERE gender = 'Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std1 WHERE gender = 'Female'");
        }

        public DataTable getStudentOnCourse(string courseName)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT CourseStudent.studentID as [Student ID], CourseStudent.fname as [First Name], CourseStudent.lname as [Last Name], std1.bdate as [Birthday]  FROM std1 INNER JOIN CourseStudent on std1.id = CourseStudent.studentID WHERE courseName= @courseName");

            command.Parameters.Add("@courseName", SqlDbType.VarChar).Value = courseName;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    } 
}
