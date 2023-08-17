using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110376_TruongChiKien_StudentManagement
{
    internal class GROUP
    {
        My_DB mydb = new My_DB();
        public bool insertGroup(int Id, string gname, int userid)
        {
            SqlCommand comand = new SqlCommand("INSERT INTO [Group] (Id, name, userid)" +
                " VALUES (@cid, @fn,@ln)", mydb.getConnection);

            comand.Parameters.Add("@cid", SqlDbType.Int).Value = Id;
            comand.Parameters.Add("@fn", SqlDbType.VarChar).Value = gname;
            comand.Parameters.Add("@ln", SqlDbType.Int).Value = userid;
            mydb.openConnection();
            if ((comand.ExecuteNonQuery() == 1))
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
        public bool updateGroup(int Id, string gname, int userid)
        {
            SqlCommand command = new SqlCommand("UPDATE [Group] SET name=@fn, userid=@ln WHERE Id=@Id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@ln", SqlDbType.Int).Value = userid;
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
        public bool deleteGroup(int id)
        {

            SqlCommand command = new SqlCommand("DELETE FROM [Group] WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public DataTable getGroups(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Group] WHERE userid=@cId", mydb.getConnection);
            command.Parameters.Add("@cId", SqlDbType.Int).Value = userid;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool groupExist(string name, string operation, int userid, int groupid)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if (operation == "add")
            {
                query = "SELECT * FROM [Group] WHERE name = @name AND userid = @uid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM [Group] WHERE name=@name AND userid = @uid AND id<> @gid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }
            command.Connection = mydb.getConnection;
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
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
        public bool checkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Group] WHERE Id=@cId", mydb.getConnection);
            command.Parameters.Add("@cId", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
