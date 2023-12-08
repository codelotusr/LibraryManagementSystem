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
using LibraryManagementSystem.View;

namespace LibraryManagementSystem
{
    public partial class Register : Form
    {
        private LibraryContext _db;

        public Register()
        {
            InitializeComponent();
            _db = ServiceLocator.LibraryContext;
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = registerNameTextBox.Text;
                string email = registerEmailTextBox.Text;
                string password = registerPasswordTextBox.Text;
                string confirmPassword = registerConfirmPasswordTextBox.Text;
                string address = registerAddressTextBox.Text;
                string phoneNumber = registerPhoneNumberTextBox.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword) ||
                    string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phoneNumber))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Invalid name format.");
                    return;
                }

                if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$"))
                {
                    MessageBox.Show("Invalid email format.");
                    return;
                }

                if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
                {
                    MessageBox.Show("Invalid password format.");
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                if (termsOfServiceCheckBox.Checked == false)
                {
                    MessageBox.Show("Please agree to the terms of service.");
                    return;
                }

                string userId = GenerateUniqueUserId();
                string hashedPassword = HashPassword(password);
                string staffNumber = GenerateUniqueStaffNumber();

                Staff newStaff = new Staff
                {
                    UserIdentification = userId,
                    Name = name,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    PasswordHash = hashedPassword,
                    Address = address,
                    StaffNumber = staffNumber,
                    isAdmin = true
                };

                GenericEntity genericEntity = new GenericEntity(_db);
                await genericEntity.CreateEntityAsync(newStaff);

                MessageBox.Show("Registration successful.");
                MessageBox.Show("Your UserID is : " + userId);
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        sb.AppendLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
                MessageBox.Show(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }

            backToLoginScreen();


        }


        private String GenerateUniqueStaffNumber()
        {
            string staffNumber;

            Random random = new Random();
            do
            {
                staffNumber = random.Next(1000, 10000).ToString();
            } while (_db.Staff.Any(s => s.StaffNumber == staffNumber));
            return staffNumber;
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

        private void returnButton_Click(object sender, EventArgs e)
        {
            backToLoginScreen();
        }

        private void backToLoginScreen()
        {
            var previousForm = Application.OpenForms.OfType<Login>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }
    }
}
