using LibraryManagementSystem.EntityUtils;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Core;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        private readonly LibraryContext _db;
        public Login()
        {
            InitializeComponent();
            _db = ServiceLocator.LibraryContext;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userId = userIdTextBox.Text;
            string password = passwordTextBox.Text;
            string hashedPassword = HashPassword(password);

            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("The UserID field cannot be left empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("The Password field cannot be left empty");
                return;
            }

            var user = _db.User.FirstOrDefault(u => u.UserIdentification == userId && u.PasswordHash == hashedPassword);
            if (user != null)
            {
                GlobalUserState.CurrentUserId = user.Id;
                if (user is Staff)
                {
                    MessageBox.Show("Welcome, Staff Member!");
                }
                else if (user is Member)
                {
                    MessageBox.Show("Welcome, Library Member!");
                }

                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("UserID or Password is incorrect.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginRegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringBuilder.Append(bytes[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // TODO: Implement a way to recover UserID with email
        }
    }
}
