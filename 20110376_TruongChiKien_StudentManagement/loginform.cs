using _20110376_TruongChiKien_StudentManagement.HumanResource;
using Microsoft.Office.Interop.Word;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _20110376_TruongChiKien_StudentManagement
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }



      

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm newuser = new RegisterForm();
            newuser.Show(this);
        }

        private void login_Click_2(object sender, EventArgs e)
        {

            if (radioButtonAdmin.Checked)
            {
                MainForm.roleLogin = "ADMIN";
                MainForm.nameLogin = textBoxUsername.Text;
                My_DB db = new My_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.DataTable table = new System.Data.DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM Log_in WHERE username = @User AND password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.NVarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBoxPass.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);



                if ((table.Rows.Count > 0))
                {
                    //this.DialogResult = DialogResult.OK;
                    //MessageBox.Show("OK, BIp");
                    //MainForm f = new MainForm();
                    //f.ShowDialog();
                    FormLoading form = new FormLoading();
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonStudent.Checked)
            {
                MainForm.roleLogin = "Student";
                //MainForm.nameLogin = textBoxUsername.Text;
                My_DB db = new My_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.DataTable table = new System.Data.DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM Log_in WHERE username = @User AND password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.NVarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBoxPass.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);



                if ((table.Rows.Count > 0))
                {
                    //this.DialogResult = DialogResult.OK;
                    //MessageBox.Show("OK, BIp");
                    //MainForm f = new MainForm();
                    //f.ShowDialog();
                    FormLoading form = new FormLoading();
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (radioButtonHumanResource.Checked)
            {
                try
                {

                    My_DB db = new My_DB();
                    SqlCommand comand = new SqlCommand("Select * From [User] where uname = @Name and pwd = @pass", db.getConnection);
                    comand.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBoxUsername.Text;
                    comand.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBoxPass.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(comand);
                    System.Data.DataTable table = new System.Data.DataTable();
                    adapter.Fill(table);
                    if ((table.Rows.Count == 0))
                    {
                        MessageBox.Show("error login - user or password is not correct!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int userid = Convert.ToInt16(table.Rows[0][0].ToString());
                        GLOBAL.SetGlobalUserId(userid);
                        ContactForm contactForm = new ContactForm();
                        contactForm.ShowDialog();
                        this.Hide();
                    }

                }
                catch (Exception eww)
                {
                    MessageBox.Show("Error Login - Try again later! " + eww.Message);
                }
            }
            else
            {
                MessageBox.Show("Login error! Please check carefully your information!!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButtonStudent.Checked == true)
            {
                RegisterForm newuser = new RegisterForm();
                newuser.Show(this);
            }
            else if (radioButtonHumanResource.Checked == true)
            {
                RegisterResourceForm form = new RegisterResourceForm();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Register error! Please check carefully your information!!", "Register error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fForgetPassword f = new fForgetPassword();
            f.ShowDialog();
        }


        private HelpProvider hlpProvider;
        bool isHelp = false;




        private void ClearLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPass.Clear();
            textBoxUsername.Focus();
        }

     

        private void showpass_btn_Click(object sender, EventArgs e)
        {
            if (textBoxPass.PasswordChar == '*')
            {
                hidepass_btn.BringToFront();
                textBoxPass.PasswordChar = '\0';
            }
        }

        private void hidepass_btn_Click(object sender, EventArgs e)
        {
            if (textBoxPass.PasswordChar == '\0')
            {
                showpass_btn.BringToFront();
                textBoxPass.PasswordChar = '*';
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}