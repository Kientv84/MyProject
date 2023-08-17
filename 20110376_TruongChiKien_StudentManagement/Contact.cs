using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _20110376_TruongChiKien_StudentManagement
{
    class Contact
    {
        My_DB mydb = new My_DB();
        public bool insertContact(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture, int userid)
        {
            SqlCommand comand = new SqlCommand("INSERT INTO [Contact] (Id, fname, lname, group_id, phone,email, address, pic,userid)" +
                " VALUES (@id, @fn, @ln, @gri,@phn,@em, @adrs, @pic,@ui)", mydb.getConnection);
            comand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            comand.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            comand.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            comand.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            comand.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            comand.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            comand.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            comand.Parameters.Add("@ui", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
            comand.Parameters.Add("@gri", SqlDbType.Int).Value = groupid;
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
        public bool UpdateContact(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand comand = new SqlCommand("UPDATE [Contact] SET fname=@fn,lname=@ln,group_id=@gri,phone=@phn,email=@em,ad" +
                "dress=@adrs,pic=@pic WHERE id=" + id, mydb.getConnection);

            comand.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            comand.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            comand.Parameters.Add("@gri", SqlDbType.Int).Value = groupid;
            comand.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            comand.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            comand.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            comand.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            comand.Parameters.Add("@ui", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
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

        public bool deleteContact(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Contact] WHERE id= @id", mydb.getConnection);
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
        public System.Data.DataTable getContactById(int id)
        {
            SqlCommand command = new SqlCommand("select * from [Contact] where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            return table;
        }

        public System.Data.DataTable getContact(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            return table;
        }
        public System.Data.DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkId(int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Contact] WHERE Id=@cId", mydb.getConnection);
            command.Parameters.Add("@cId", SqlDbType.VarChar).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new System.Data.DataTable();
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
