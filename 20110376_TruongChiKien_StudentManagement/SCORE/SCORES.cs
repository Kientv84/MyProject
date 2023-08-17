using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110376_TruongChiKien_StudentManagement.SCORE
{

    internal class SCORES
    {
        My_DB mydb = new My_DB();

        public bool insertScore(int studentId, int courseId, float score, string description, string semester)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (student_id, course_id, student_score, description, semester) VALUES (@sid, @cid, @scr, @dscr, @sms)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = courseId;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = score;
            command.Parameters.Add("@dscr", SqlDbType.Text).Value = description;
            command.Parameters.Add("@sms", SqlDbType.VarChar).Value = semester;

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

        public bool insertScore(int studentId, int courseId, float score, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (student_id, course_id, student_score, description) VALUES (@sid, @cid, @scr, @dscr)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = courseId;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = score;
            command.Parameters.Add("@dscr", SqlDbType.Text).Value = description;


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
        public bool studentScoreExists(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE student_id=@sid AND course_id =@cid", mydb.getConnection);

            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {

                return false;
            }
            else
            {

                return true;
            }
        }

        //create a function to get students score
        public DataTable getStudentsScore()
        {
            SqlCommand command = new SqlCommand("SELECT score.student_id , std1.fname, std1.lname, score.course_id, course.label, score.student_score FROM std1 INNER JOIN score ON std1.id = score.student_id INNER JOIN course ON score.course_id = course.id", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public DataTable getStudentScore(int courseid)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT score.student_id as 'Student ID', std1.fname as 'First Name', std1.lname as 'Last Name',std1.address as 'Address',std1.phone as 'Phone', score.student_score as 'Score', std1.picture as 'Picture'" +
                " FROM std1 INNER JOIN score ON std1.id = score.student_id INNER JOIN course ON score.course_id = course.id WHERE score.course_id ="
                + courseid);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteScore(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score  WHERE student_id = @sid AND course_id =@cid ", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
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

        //create a function to get the average score by course
        public DataTable avgScoreByCourse()
        {
            SqlCommand command = new SqlCommand("SELECT course.label , avg(score.student_score) as 'Average Score' FROM course, score WHERE course.id = score.course_id GROUP BY course.label ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        //get course scores
        public DataTable getCourseScores(int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT score.student_id, std1.fname, std1.lname, score.course_id, course.label, score.student_score FROM std1 INNER JOIN score ON std1.id = score.student_id INNER JOIN course ON score.course_id = course.Id WHERE score.course_id =" + courseId, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        //get studnet scores
        public DataTable getStudentScores(int studentId)
        {
            SqlCommand command = new SqlCommand("SELECT score.student_id, std1.fname, std1.lname, score.course_id, course.label, score.student_score FROM std1 INNER JOIN score ON std1.id = score. INNER JOIN course ON score.course_id = course.Id WHERE score.student_id =" + studentId, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        internal DataTable getStudentScores(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
