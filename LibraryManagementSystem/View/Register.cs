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
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem
{
    public partial class Register : Form
    {
        private LibraryContext _db = new LibraryContext();

        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string name = registerNameTextBox.Text;
            string email = registerEmailTextBox.Text;
            string password = registerPasswordTextBox.Text;
            string confirmPassword = registerConfirmPasswordTextBox.Text;
            string address = registerAddressTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid name format.");
                return;
            }

            if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
            {
                MessageBox.Show("Invalid password format.");
                return;
            }

            if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string userId = GenerateUniqueUserId();


        }

        private String GenerateUniqueUserId()
        {
            string year = DateTime.Now.Year.ToString();
            string randomDigits;
            string userId;

            Random random = new Random();
            do
            {
                randomDigits = random.Next(1000, 10000).ToString();
                userId = year + randomDigits;
            } while (_db.User.Any(u => u.UserIdentification == userId));

            return userId;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
