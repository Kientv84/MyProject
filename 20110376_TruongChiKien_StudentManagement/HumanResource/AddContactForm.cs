using Microsoft.Office.Interop.Word;
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

namespace _20110376_TruongChiKien_StudentManagement.HumanResource
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        private void AddContactForm_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();
            comboBoxGroup.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "Id";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                || (TextBoxlname.Text.Trim() == "")
                || (textboxGroup.Text.Trim() == "")
                || (TextBoxPhone.Text.Trim() == "")
                || (textboxEmail.Text.Trim() == "")
                || (TextBoxAdress.Text.Trim() == "")
                || (textBoxId.Text.Trim() == "")
                || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Convert.ToInt32(textBoxId.Text);
                string fname = TextBoxFname.Text;
                string lname = TextBoxlname.Text;
                string phone = TextBoxPhone.Text;
                string address = TextBoxAdress.Text;
                string email = textboxEmail.Text;
                int userid = GLOBAL.GlobalUserId;
                int groupid = (int)comboBoxGroup.SelectedValue;
                MemoryStream pic = new MemoryStream();
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (contact.checkId(Convert.ToInt32(textBoxId.Text)))
                {
                    Contact contact = new Contact();
                    if (contact.insertContact(id, fname, lname, groupid, phone, email, address, pic, userid))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("empty fieds", "add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Convert.ToInt32(textBoxId.Text);
                string fname = TextBoxFname.Text;
                string lname = TextBoxlname.Text;
                string phone = TextBoxPhone.Text;
                string address = TextBoxAdress.Text;
                string email = textboxEmail.Text;
                int userid = GLOBAL.GlobalUserId;
                int groupid = (int)comboBoxGroup.SelectedValue;
                MemoryStream pic = new MemoryStream();
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (contact.checkId(Convert.ToInt32(textBoxId.Text)))
                {
                    Contact contact = new Contact();
                    if (contact.insertContact(id, fname, lname, groupid, phone, email, address, pic, userid))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("empty fieds", "add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void upload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}

