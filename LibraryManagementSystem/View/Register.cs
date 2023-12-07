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
using LibraryManagementSystem.EntityUtils;
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

        private async void registerButton_Click(object sender, EventArgs e)
        {
            string name = registerNameTextBox.Text;
            string email = registerEmailTextBox.Text;
            string password = registerPasswordTextBox.Text;
            string confirmPassword = registerConfirmPasswordTextBox.Text;
            string address = registerAddressTextBox.Text;

            string userId = GenerateUniqueUserId();
            string hashedPassword = HashPassword(password);

            User newUser = new Staff
            {
                UserIdentification = userId,
                Name = name,
                Email = email,
                PasswordHash = hashedPassword,
                Address = address,
                StaffNumber = userId,
                isAdmin = true
            };

            GenericEntity genericEntity = new GenericEntity(_db);
            await genericEntity.CreateEntityAsync(newUser);

            MessageBox.Show("Registration successful.");


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
