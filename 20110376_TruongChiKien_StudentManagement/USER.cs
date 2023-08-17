using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20110376_TruongChiKien_StudentManagement
{
    internal class USER
    {
        My_DB db = new My_DB();

        // function to insert a new user

        public bool insertUSer(string Id, string fname, string lname, string username, string pass, MemoryStream picture)
        {
            SqlCommand comand = new SqlCommand("INSERT INTO [User] (Id,f_name,l_name,uname,pwd, fig)" +
                " VALUES (@cid, @fn,@ln,@una,@pass,@pic)", db.getConnection);

            comand.Parameters.Add("@cid", SqlDbType.VarChar).Value = Id;
            comand.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            comand.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            comand.Parameters.Add("@una", SqlDbType.VarChar).Value = username;
            comand.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            comand.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            db.openConnection();
            if ((comand.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    

        public bool CheckUserNameInAccount(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Login where username = @uname", db.getConnection);
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.closeConnection();
                return false;
            }
            else
            {
                db.closeConnection();
                return true;
            }
        }

        public bool CheckUserNameInRegister(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM RegisterAccount where username = @uname", db.getConnection);
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.closeConnection();
                return false;
            }
            else
            {
                db.closeConnection();
                return true;
            }
        }

        public bool CheckEmailInAccount(string email)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in where email = @email", db.getConnection);
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.closeConnection();
                return false;
            }
            else
            {
                db.closeConnection();
                return true;
            }
        }

        public bool CheckEmailInRegister(string email)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM RegisterAccount where email = @email", db.getConnection);
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.closeConnection();
                return false;
            }
            else
            {
                db.closeConnection();
                return true;
            }
        }

        public bool checkLoginInAccount(string username, string password)
        {
            My_DB db = new My_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE username = @User AND password = @Pass", db.getConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("Pass", SqlDbType.VarChar).Value = password;

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
            command.Parameters.Add("Pass", SqlDbType.VarChar).Value = password;

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

        public string getUsername(string email)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE email = @email", db.getConnection);

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
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE email = @email", db.getConnection);

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
            SqlCommand command = new SqlCommand("UPDATE Login SET password = @pass  WHERE email=@email", db.getConnection);
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = gmail;

            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool registerUser(string username, string password, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO RegisterAccount (verify, username, password, email)" + " VALUES(@vrf, @uname, @pass, @email)", db.getConnection);
            command.Parameters.Add("@vrf", SqlDbType.VarChar).Value = 0;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))

            {
                db.closeConnection();
                return true;
            }

            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable getAccount(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            /*List<CheckedUser> list = new List<CheckedUser>();
            CheckedUser userAccount = new CheckedUser()
            list.Add(CheckedUser);*/
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool CheckUserNameInAccountStudent(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in where username = @uname", db.getConnection);
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.closeConnection();
                return false;
            }
            else
            {
                db.closeConnection();
                return true;
            }
        }

        public bool deleteRegistatrionHR(string username)
        {
            SqlCommand command = new SqlCommand("DELETE FROM RegisterAccountHR WHERE username = '" + username + "'", db.getConnection);
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool CheckUserNameInRegisterHR(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM RegisterAccountHR where username = @uname", db.getConnection);
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.closeConnection();
                return false;
            }
            else
            {
                db.closeConnection();
                return true;
            }
        }

        public bool registerUserHR(string id, string fname, string lname, string username, string password, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("INSERT INTO RegisterAccountHR (verify, Id, firstname, lastname, username, password,pig)" + " VALUES(@vrf,@id, @fname, @lname, @uname, @pass, @image)", db.getConnection);
            command.Parameters.Add("@vrf", SqlDbType.VarChar).Value = 0;
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray();
            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))

            {
                db.closeConnection();
                return true;
            }

            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool CheckUserNameHR(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [User] where uname = @usname", db.getConnection);
            command.Parameters.Add("@usname", SqlDbType.VarChar).Value = username;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.closeConnection();
                return false;
            }
            else
            {
                db.closeConnection();
                return true;
            }
        }
        public bool deleteRegistatrion(string username)
        {
            SqlCommand command = new SqlCommand("DELETE FROM RegisterAccount WHERE username = '" + username + "'", db.getConnection);
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public DataTable getUserById(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE Id = @uid", db.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool updatetUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("Update [User] set f_name = @fn, l_name = @ln, uname = @un, pwd = @pass, fig = @pic where Id = @uid", db.getConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool usernameExist(string username, string operation, int userid)
        {
            string query = "";
            if (operation == "register")
            {
                query = "Select * from [User] where uname = @un";
            }
            else if (operation == "edit")
            {
                query = "Select * from [User] where uname = @un and id <> @uid";
            }

            SqlCommand command = new SqlCommand(query, db.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                return false;        //Da ton tai

            }
            else
            {
                return true;       // Khong ton tai
            }
        }
    }
}
