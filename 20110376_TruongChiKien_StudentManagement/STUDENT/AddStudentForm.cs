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

namespace _20110376_TruongChiKien_StudentManagement.STUDENT
{
    public partial class address : Form
    {
        public address()
        {
            InitializeComponent();
        }


        private void add_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(textstudentID.Text);
            string fname = textfname.Text;
            string lname = textlname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textphone.Text;
            string email = textEmail.Text;
            string major = textMajor.Text;
            string hometown = textHtown.Text;
            string adrs = textaddress.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBoxstudentimage.Image.Save(pic, pictureBoxstudentimage.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, email, major, hometown, adrs, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textfname.Text.Trim() == "")
                || (textlname.Text.Trim() == "")
                || (textaddress.Text.Trim() == "")
                || (textphone.Text.Trim() == "")
                || (textEmail.Text.Trim() == "")
                || (textMajor.Text.Trim() == "")
                || (textHtown.Text.Trim() == "")
                || (pictureBoxstudentimage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxstudentimage_Click(object sender, EventArgs e)
        {

        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxstudentimage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textstudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
