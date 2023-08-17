using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110376_TruongChiKien_StudentManagement
{
    internal class Newuser
    {
        My_DB mydb = new My_DB();
        public bool insertUser(string username, string password, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO log_in (username, password, email) VALUES (@us, @pw, @em)", mydb.getConnection);
            command.Parameters.Add("@us", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pw", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@em", SqlDbType.NVarChar).Value = email;


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

        public bool CheckUserName(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in where username = @uname", mydb.getConnection);
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
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

        public bool CheckUserNameInRegister(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM RegisterAccount where username = @uname", mydb.getConnection);
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
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
        public bool checkLoginInAccount(string username, string password)
        {
            My_DB db = new My_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM Log_in WHERE username = @User AND password = @Pass", db.getConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkLoginInRegister(string username, string password)
        {
            My_DB db = new My_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM RegisterAccount WHERE username = @User AND password = @Pass", db.getConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getAccount(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            /*List<CheckedUser> list = new List<CheckedUser>();
            CheckedUser userAccount = new CheckedUser()
            list.Add(CheckedUser);*/
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool registerUser(string username, string password, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO RegisterAccount (verify, username, password, email)" + " VALUES(@vrf, @uname, @pass, @email)", mydb.getConnection);
            command.Parameters.Add("@vrf", SqlDbType.VarChar).Value = 0;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
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
        public bool deleteRegistatrion(string username)
        {
            SqlCommand command = new SqlCommand("DELETE FROM RegisterAccount WHERE username = '" + username + "'", mydb.getConnection);
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
        public bool CheckEmailInAccount(string email)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in where email = @email", mydb.getConnection);
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            mydb.openConnection();
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
        public bool CheckEmailInRegister(string email)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM RegisterAccount where email = @email", mydb.getConnection);
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            mydb.openConnection();
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
        public string getUsername(string email)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in WHERE email = @email", mydb.getConnection);

            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            string username = table.Rows[0]["username"].ToString();

            return username;
        }

        public string getPassword(string email)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in WHERE email = @email", mydb.getConnection);

            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            string password = table.Rows[0]["password"].ToString();

            return password;
        }
        public bool updatePassword(string gmail, string password)
        {
            SqlCommand command = new SqlCommand("UPDATE Log_in SET password = @pass  WHERE email=@email", mydb.getConnection);
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = gmail;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
