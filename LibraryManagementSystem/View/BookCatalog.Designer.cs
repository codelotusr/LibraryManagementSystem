namespace LibraryManagementSystem.View
{
    partial class BookCatalog
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
            this.catalogListView = new System.Windows.Forms.ListView();
            this.rentABookButton = new System.Windows.Forms.Button();
            this.catalogTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.catalogAuthorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.catalogIsbnTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.catalogYearTextBox = new System.Windows.Forms.TextBox();
            this.catalogReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catalogListView
            // 
            this.catalogListView.HideSelection = false;
            this.catalogListView.Location = new System.Drawing.Point(12, 35);
            this.catalogListView.Name = "catalogListView";
            this.catalogListView.Size = new System.Drawing.Size(347, 386);
            this.catalogListView.TabIndex = 0;
            this.catalogListView.UseCompatibleStateImageBehavior = false;
            this.catalogListView.SelectedIndexChanged += new System.EventHandler(this.catalogListView_SelectedIndexChanged);
            // 
            // rentABookButton
            // 
            this.rentABookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentABookButton.Location = new System.Drawing.Point(523, 169);
            this.rentABookButton.Name = "rentABookButton";
            this.rentABookButton.Size = new System.Drawing.Size(110, 42);
            this.rentABookButton.TabIndex = 3;
            this.rentABookButton.Text = "Rent";
            this.rentABookButton.UseVisualStyleBackColor = true;
            this.rentABookButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // catalogTitleTextBox
            // 
            this.catalogTitleTextBox.Location = new System.Drawing.Point(434, 34);
            this.catalogTitleTextBox.Name = "catalogTitleTextBox";
            this.catalogTitleTextBox.Size = new System.Drawing.Size(334, 20);
            this.catalogTitleTextBox.TabIndex = 4;
            this.catalogTitleTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Author:";
            // 
            // catalogAuthorTextBox
            // 
            this.catalogAuthorTextBox.Location = new System.Drawing.Point(434, 62);
            this.catalogAuthorTextBox.Name = "catalogAuthorTextBox";
            this.catalogAuthorTextBox.Size = new System.Drawing.Size(334, 20);
            this.catalogAuthorTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "ISBN:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // catalogIsbnTextBox
            // 
            this.catalogIsbnTextBox.Location = new System.Drawing.Point(434, 116);
            this.catalogIsbnTextBox.Name = "catalogIsbnTextBox";
            this.catalogIsbnTextBox.Size = new System.Drawing.Size(334, 20);
            this.catalogIsbnTextBox.TabIndex = 11;
            this.catalogIsbnTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // catalogYearTextBox
            // 
            this.catalogYearTextBox.Location = new System.Drawing.Point(434, 90);
            this.catalogYearTextBox.Name = "catalogYearTextBox";
            this.catalogYearTextBox.Size = new System.Drawing.Size(334, 20);
            this.catalogYearTextBox.TabIndex = 9;
            this.catalogYearTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // catalogReturnButton
            // 
            this.catalogReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogReturnButton.Location = new System.Drawing.Point(658, 379);
            this.catalogReturnButton.Name = "catalogReturnButton";
            this.catalogReturnButton.Size = new System.Drawing.Size(110, 42);
            this.catalogReturnButton.TabIndex = 13;
            this.catalogReturnButton.Text = "Back";
            this.catalogReturnButton.UseVisualStyleBackColor = true;
            this.catalogReturnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catalogReturnButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.catalogIsbnTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.catalogYearTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catalogAuthorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catalogTitleTextBox);
            this.Controls.Add(this.rentABookButton);
            this.Controls.Add(this.catalogListView);
            this.Name = "BookCatalog";
            this.Text = "BookCatalog";
            this.Load += new System.EventHandler(this.BookCatalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView catalogListView;
        private System.Windows.Forms.Button rentABookButton;
        private System.Windows.Forms.TextBox catalogTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox catalogAuthorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox catalogIsbnTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox catalogYearTextBox;
        private System.Windows.Forms.Button catalogReturnButton;
    }
}