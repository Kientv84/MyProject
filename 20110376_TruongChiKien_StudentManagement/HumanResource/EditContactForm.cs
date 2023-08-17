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
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        My_DB mydb = new My_DB();
        private void EditContactForm_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();
            comboBoxGroup.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            comboBoxGroup.DisplayMember = "group_id";
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxlname.Text;
            int groupby = int.Parse(comboBoxGroup.Text.ToString());
            string phone = TextBoxPhone.Text;
            string email = textBoxEmail.Text;
            string adrs = TextBoxAdress.Text;
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (contact.UpdateContact(id, fname, lname, groupby, phone, email, adrs, pic))
                {
                    MessageBox.Show("da cap nhat", "add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("error", "add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("empty fieds", "add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bool verif()
            {
                if ((TextBoxFname.Text.Trim() == "")
                    || (TextBoxlname.Text.Trim() == "")
                    || (Group.Text.Trim() == "")
                    || (TextBoxPhone.Text.Trim() == "")
                    || (textBoxEmail.Text.Trim() == "")
                    || (TextBoxAdress.Text.Trim() == "")
                    || (PictureBoxStudentImage.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private void buttonSelectId_Click(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();
            try
            {

                int contactId = Convert.ToInt32(SelectContactF.dataGridView2.CurrentRow.Cells[0].Value.ToString());

                Contact contact = new Contact();
                System.Data.DataTable table = contact.getContactById(contactId);

                textBoxId.Text = table.Rows[0]["Id"].ToString();
                TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                TextBoxlname.Text = table.Rows[0]["lname"].ToString();
                comboBoxGroup.SelectedValue = table.Rows[0]["group_id"];
                TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxEmail.Text = table.Rows[0]["email"].ToString();
                TextBoxAdress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);

            }
            catch (Exception)
            {

            }
        }

        private void buttonSelectId_Click_1(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();
            try
            {

                int contactId = Convert.ToInt32(SelectContactF.dataGridView2.CurrentRow.Cells[0].Value.ToString());

                Contact contact = new Contact();
                System.Data.DataTable table = contact.getContactById(contactId);

                textBoxId.Text = table.Rows[0]["Id"].ToString();
                TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                TextBoxlname.Text = table.Rows[0]["lname"].ToString();
                comboBoxGroup.SelectedValue = table.Rows[0]["group_id"];
                TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxEmail.Text = table.Rows[0]["email"].ToString();
                TextBoxAdress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);

            }
            catch (Exception)
            {

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

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxlname.Text;
            int groupby = int.Parse(comboBoxGroup.Text.ToString());
            string phone = TextBoxPhone.Text;
            string email = textBoxEmail.Text;
            string adrs = TextBoxAdress.Text;
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (contact.UpdateContact(id, fname, lname, groupby, phone, email, adrs, pic))
                {
                    MessageBox.Show("da cap nhat", "add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("error", "add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("empty fieds", "add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bool verif()
            {
                if ((TextBoxFname.Text.Trim() == "")
                    || (TextBoxlname.Text.Trim() == "")
                    || (Group.Text.Trim() == "")
                    || (TextBoxPhone.Text.Trim() == "")
                    || (textBoxEmail.Text.Trim() == "")
                    || (TextBoxAdress.Text.Trim() == "")
                    || (PictureBoxStudentImage.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
