using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement.HumanResource
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        Contact contact = new Contact();
        GROUP group = new GROUP();
        public void getImageAndUsername()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM [User] where Id=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                this.pictureBoxUser.Image = Image.FromStream(picture);

                this.labelTitle.Text = "Welcome (" + table.Rows[0]["uname"].ToString().Trim() + ")";
                this.labelName.Text = "(" + table.Rows[0]["f_name"].ToString().Trim() + " " + table.Rows[0]["l_name"].ToString().Trim() + ")";
            }
        }
        private void ContactForm_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            GROUP group = new GROUP();
            comboBoxEdit.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            comboBoxEdit.DisplayMember = "name";
            comboBoxEdit.ValueMember = "Id";
            comboBoxRemove.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            comboBoxRemove.DisplayMember = "name";
            comboBoxRemove.ValueMember = "Id";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if ((MessageBox.Show("Do you want to delete this contact", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (contact.deleteContact(id))
                    {
                        MessageBox.Show("Delete Contact Successfully", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Contact Not Delete", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter Valid ID", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();
            try
            {
                int contactId = Convert.ToInt32(SelectContactF.dataGridView2.CurrentRow.Cells[0].Value.ToString());

                Contact contact = new Contact();
                System.Data.DataTable table = contact.getContactById(contactId);

                textBoxID.Text = table.Rows[0]["Id"].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.Show(this);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddContactForm addcontact = new AddContactForm();
            addcontact.Show(this);
        }
        public void loadCombobox()
        {
            this.comboBoxEdit.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            this.comboBoxEdit.DisplayMember = "name";
            this.comboBoxEdit.ValueMember = "Id";

            this.comboBoxRemove.DataSource = group.getGroups(GLOBAL.GlobalUserId);
            this.comboBoxRemove.DisplayMember = "name";
            this.comboBoxRemove.ValueMember = "Id";
        }

        private void buttonGAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxGAdd.Text.Trim() != "" && this.textBoxIDGroup.Text.Trim() != "")
                {
                    int id = Convert.ToInt32(this.textBoxIDGroup.Text);
                    string name = this.textBoxGAdd.Text;
                    int userid = GLOBAL.GlobalUserId;

                    if (group.checkID(id) && group.groupExist(name, "add", GLOBAL.GlobalUserId, 0))
                    {
                        if (group.insertGroup(id, name, userid))
                        {
                            this.loadCombobox();
                            MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("One Or More Fields Are Empty", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        bool verif()
        {
            if ((textBoxGAdd.Text == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void buttonGEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxEdit.SelectedValue != null && this.textBoxGEdit.Text.Trim() != "")
                {
                    int groupID = Convert.ToInt32(this.comboBoxEdit.SelectedValue.ToString().Trim());
                    string name = this.textBoxGEdit.Text;
                    int userid = GLOBAL.GlobalUserId;
                    if (group.groupExist(name, "edit", GLOBAL.GlobalUserId, groupID))
                    {
                        if (group.updateGroup(groupID, name, userid))
                        {
                            this.loadCombobox();
                            MessageBox.Show("Update Successfully", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exist Name", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("empty fieds", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonGRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int groupID = Convert.ToInt32(this.comboBoxRemove.SelectedValue.ToString().Trim());
                if (MessageBox.Show("Are you sure about that ? ", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (group.deleteGroup(groupID))
                    {
                        this.loadCombobox();
                        MessageBox.Show("Delete Successfully", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Not done", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You cancel it success", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Empty Fieds", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void labelEditHuman_Click(object sender, EventArgs e)
        {
            EditHumanForm edit = new EditHumanForm();
            edit.Show();
            this.getImageAndUsername();
        }

        private void label16_Click(object sender, EventArgs e)
        {

            loginform fm = new loginform();
            this.Hide();
            fm.ShowDialog();
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonShowfull_Click(object sender, EventArgs e)
        {
            ContactShowFullList r = new ContactShowFullList();
            r.Show(this);
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            AddContactForm addcontact = new AddContactForm();
            addcontact.Show(this);
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.Show(this);
        }

        private void buttonSelect_Click_1(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();
            try
            {
                int contactId = Convert.ToInt32(SelectContactF.dataGridView2.CurrentRow.Cells[0].Value.ToString());

                Contact contact = new Contact();
                System.Data.DataTable table = contact.getContactById(contactId);

                textBoxID.Text = table.Rows[0]["Id"].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void buttonRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if ((MessageBox.Show("Do you want to delete this contact", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (contact.deleteContact(id))
                    {
                        MessageBox.Show("Delete Contact Successfully", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Contact Not Delete", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter Valid ID", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonShowfull_Click_1(object sender, EventArgs e)
        {
            ContactShowFullList r = new ContactShowFullList();
            r.Show(this);
        }

        private void buttonGAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxGAdd.Text.Trim() != "" && this.textBoxIDGroup.Text.Trim() != "")
                {
                    int id = Convert.ToInt32(this.textBoxIDGroup.Text);
                    string name = this.textBoxGAdd.Text;
                    int userid = GLOBAL.GlobalUserId;

                    if (group.checkID(id) && group.groupExist(name, "add", GLOBAL.GlobalUserId, 0))
                    {
                        if (group.insertGroup(id, name, userid))
                        {
                            this.loadCombobox();
                            MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("One Or More Fields Are Empty", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxEdit.SelectedValue != null && this.textBoxGEdit.Text.Trim() != "")
                {
                    int groupID = Convert.ToInt32(this.comboBoxEdit.SelectedValue.ToString().Trim());
                    string name = this.textBoxGEdit.Text;
                    int userid = GLOBAL.GlobalUserId;
                    if (group.groupExist(name, "edit", GLOBAL.GlobalUserId, groupID))
                    {
                        if (group.updateGroup(groupID, name, userid))
                        {
                            this.loadCombobox();
                            MessageBox.Show("Update Successfully", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exist Name", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("empty fieds", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonGRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                int groupID = Convert.ToInt32(this.comboBoxRemove.SelectedValue.ToString().Trim());
                if (MessageBox.Show("Are you sure about that ? ", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (group.deleteGroup(groupID))
                    {
                        this.loadCombobox();
                        MessageBox.Show("Delete Successfully", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Not done", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You cancel it success", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Empty Fieds", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label16_Click_1(object sender, EventArgs e)
        {
            loginform fm = new loginform();
            this.Hide();
            fm.ShowDialog();
        }

        private void labelEditHuman_Click_1(object sender, EventArgs e)
        {
            EditHumanForm edit = new EditHumanForm();
            edit.Show();
            this.getImageAndUsername();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
