using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement
{
    public partial class RegisterResourceForm : Form
    {
        public RegisterResourceForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        USER user = new USER();
        private void btRegister_Click(object sender, EventArgs e)
        {
            string id = txtStudentID.Text;
            string fname = TextBoxFname.Text;
            string lname = TextBoxlname.Text;

            string uname = TextBoxUserName.Text;
            string pass = TextBoxPass.Text;

            MemoryStream pic = new MemoryStream();
            bool verif()
            {
                if ((TextBoxFname.Text.Trim() == "")
                    || (TextBoxlname.Text.Trim() == "")
                    || (TextBoxUserName.Text.Trim() == "")
                    || (TextBoxPass.Text.Trim() == "")
                    || (PictureBoxHumanResourse.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
           
            if (verif())
            {
                PictureBoxHumanResourse.Image.Save(pic, PictureBoxHumanResourse.Image.RawFormat);
                //if (!user.UserNameScoreExist(id, uname))
                //{
                if (user.insertUSer(id, fname, lname, uname, pass, pic))
                {
                    MessageBox.Show("new st add", "add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("error", "add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
                //else
                //{
                //MessageBox.Show("the Id or uname already exists", "add score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
            else
            {
                MessageBox.Show("empty fieds", "add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxHumanResourse.Image = Image.FromFile(opf.FileName);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginform lg = new loginform();
            this.Hide();
            lg.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterResourceForm_Load(object sender, EventArgs e)
        {

        }

        private void upload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxHumanResourse.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btRegister_Click_1(object sender, EventArgs e)
        {

            try
            {

                if (verif())
                {
                    USER user = new USER();
                    // Newuser user = new Newuser();
                    string id = txtStudentID.Text;
                    string fname = TextBoxFname.Text;
                    string lname = TextBoxlname.Text;
                    string uname = TextBoxUserName.Text;
                    string pass = TextBoxPass.Text;

                    MemoryStream pic = new MemoryStream();
                    PictureBoxHumanResourse.Image.Save(pic, PictureBoxHumanResourse.Image.RawFormat);
                    //if (!user.UserNameScoreExist(id, uname))
                    //{
                    /* if (user.insertUSer(id, fname, lname, uname, pass, pic))
                     {
                         MessageBox.Show("new st add", "add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                     else
                     {
                         MessageBox.Show("error", "add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }*/
                    if (user.CheckUserNameHR(uname) && user.CheckUserNameInRegisterHR(uname) && user.CheckUserNameInAccountStudent(uname))
                    {
                        if (user.registerUserHR(id, fname, lname, uname, pass, pic))
                        {
                            MessageBox.Show("Request has been sent! Please wait for confirmation!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Username already existed!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty fieds", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                || (TextBoxlname.Text.Trim() == "")
                || (TextBoxUserName.Text.Trim() == "")
                || (txtStudentID.Text.Trim() == "")
                || (TextBoxPass.Text.Trim() == "")
                || (PictureBoxHumanResourse.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            loginform lg = new loginform();
            this.Hide();
            lg.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
