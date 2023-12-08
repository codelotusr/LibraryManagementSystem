namespace LibraryManagementSystem
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.registerEmailTextBox = new System.Windows.Forms.TextBox();
            this.registerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerAddressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.termsOfServiceCheckBox = new System.Windows.Forms.CheckBox();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registerConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(649, 361);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(118, 64);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(21, 361);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(108, 64);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // registerEmailTextBox
            // 
            this.registerEmailTextBox.Location = new System.Drawing.Point(285, 143);
            this.registerEmailTextBox.Name = "registerEmailTextBox";
            this.registerEmailTextBox.Size = new System.Drawing.Size(285, 20);
            this.registerEmailTextBox.TabIndex = 3;
            // 
            // registerNameTextBox
            // 
            this.registerNameTextBox.Location = new System.Drawing.Point(285, 107);
            this.registerNameTextBox.Name = "registerNameTextBox";
            this.registerNameTextBox.Size = new System.Drawing.Size(285, 20);
            this.registerNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Full name:";
            // 
            // registerPhoneNumberTextBox
            // 
            this.registerPhoneNumberTextBox.Location = new System.Drawing.Point(285, 178);
            this.registerPhoneNumberTextBox.Name = "registerPhoneNumberTextBox";
            this.registerPhoneNumberTextBox.Size = new System.Drawing.Size(285, 20);
            this.registerPhoneNumberTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone number:";
            // 
            // registerAddressTextBox
            // 
            this.registerAddressTextBox.Location = new System.Drawing.Point(286, 212);
            this.registerAddressTextBox.Name = "registerAddressTextBox";
            this.registerAddressTextBox.Size = new System.Drawing.Size(285, 20);
            this.registerAddressTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // termsOfServiceCheckBox
            // 
            this.termsOfServiceCheckBox.AutoSize = true;
            this.termsOfServiceCheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.termsOfServiceCheckBox.Location = new System.Drawing.Point(322, 333);
            this.termsOfServiceCheckBox.Name = "termsOfServiceCheckBox";
            this.termsOfServiceCheckBox.Size = new System.Drawing.Size(209, 17);
            this.termsOfServiceCheckBox.TabIndex = 10;
            this.termsOfServiceCheckBox.Text = "Do you agree to the Terms of Service?";
            this.termsOfServiceCheckBox.UseVisualStyleBackColor = false;
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(285, 245);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(285, 20);
            this.registerPasswordTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // registerConfirmPasswordTextBox
            // 
            this.registerConfirmPasswordTextBox.Location = new System.Drawing.Point(284, 279);
            this.registerConfirmPasswordTextBox.Name = "registerConfirmPasswordTextBox";
            this.registerConfirmPasswordTextBox.Size = new System.Drawing.Size(285, 20);
            this.registerConfirmPasswordTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Confirm password:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerConfirmPasswordTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.registerPasswordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.termsOfServiceCheckBox);
            this.Controls.Add(this.registerAddressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registerPhoneNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerEmailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.registerButton);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registerEmailTextBox;
        private System.Windows.Forms.TextBox registerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registerPhoneNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox registerAddressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox termsOfServiceCheckBox;
        private System.Windows.Forms.TextBox registerPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox registerConfirmPasswordTextBox;
        private System.Windows.Forms.Label label6;
    }
}