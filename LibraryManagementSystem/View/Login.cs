﻿using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        private LibraryContext _db = new LibraryContext();
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userId = userIdTextBox.Text;
            string password = passwordTextBox.Text;

            if (!Regex.IsMatch(userId, @"^\d{8}$") || !Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
            {
                MessageBox.Show("Invalid UserID or Password format.");
                return;
            }

            var user = _db.User.FirstOrDefault(u => u.Email == userId && u.PasswordHash == password);
            if (user != null)
            {
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


        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
