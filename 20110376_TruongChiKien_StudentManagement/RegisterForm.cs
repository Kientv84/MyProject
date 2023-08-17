using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

       
        bool verif()
        {
            if ((textBoxUsername.Text.Trim() == "")
                || (textBoxPassword.Text.Trim() == "")
                || (textBoxConfirmPass.Text.Trim() == "")
                || (textBoxEmail.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<string> sensitiveWords = new List<string> { "root", "dcm", "d cm", "ditme", "dit me", "d c m" };
        private bool IsValidEmail(string email)
        {
            // Kiểm tra định dạng email bằng biểu thức chính quy
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxUsername.Text.Trim().ToLower();

            foreach (string sensitiveWord in sensitiveWords)
            {
                if (input.Contains(sensitiveWord))
                {
                    MessageBox.Show("The username contains a sensitive word. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Clear();
                    return;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static bool verify = false;

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            if (verify == true)
            {
                lblConfirmEmail.Text = "Email Valid!";
                buttonRegister.Enabled = true;
            }
            else
            {
                lblConfirmEmail.Text = "";
                buttonRegister.Enabled = false;
            }
        }
        string randomCode;
        public static string to;

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            Newuser user = new Newuser();
            string email = textBoxEmail.Text;
            if (textBoxEmail.Text.Trim() != "")
            {

                if (user.CheckEmailInAccount(email) && user.CheckEmailInRegister(email))
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();
                    CofirmCodeForm.confirmCode = randomCode;
                    MailMessage message = new MailMessage();
                    to = (textBoxEmail.Text).ToString();
                    from = "dinhtrieu.15062002@gmail.com";
                    pass = "lhssbxffwbcdtbqq";
                    messageBody = "Your confirmation code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Topdev's Confirmation Code!";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code Send Successfully! Please enter the received code to confirm!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CofirmCodeForm f = new CofirmCodeForm();
                        f.ShowDialog();
                        RegisterForm_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("This Email is being used! Please enter another email!", "Email Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Gmail!", "Email Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirmEmail_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    Newuser user = new Newuser();
                    string uname = textBoxUsername.Text;
                    string pass = textBoxPassword.Text;
                    string conPass = textBoxConfirmPass.Text;
                    string email = textBoxEmail.Text;
                    if (user.CheckUserName(uname) && user.CheckUserNameInRegister(uname))
                    {
                        if (String.Compare(pass, conPass) != 0)
                        {
                            MessageBox.Show("Password does not match!!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (IsValidEmail(email))
                        {
                            if (user.registerUser(uname, pass, email))
                            {
                                /*MessageBox.Show("New User Added", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                                MessageBox.Show("Request has been sent! Please wait for confirmation!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Gmail is not formatted correctly", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username already existed!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
