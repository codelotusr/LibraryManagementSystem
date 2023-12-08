using System.Windows.Forms;

namespace LibraryManagementSystem.View
{
    partial class AdminManageCatalog
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
            this.adminManageCatalogCreateButton = new System.Windows.Forms.Button();
            this.adminManageCatalogDeleteButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adminManageCatalogListView = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderYearPublished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.adminManageCatalogTitleTextBox = new System.Windows.Forms.TextBox();
            this.adminManageCatalogAuthorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminManageCatalogIsbnTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminManageCatalogYearTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminManageCatalogCategoryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adminManageCatalogEditionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adminManageCatalogPriceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adminManageCatalogQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adminManageCatalogLocationTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.adminManageCatalogDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.adminManageCatalogUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminManageCatalogCreateButton
            // 
            this.adminManageCatalogCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminManageCatalogCreateButton.Location = new System.Drawing.Point(469, 371);
            this.adminManageCatalogCreateButton.Name = "adminManageCatalogCreateButton";
            this.adminManageCatalogCreateButton.Size = new System.Drawing.Size(98, 67);
            this.adminManageCatalogCreateButton.TabIndex = 0;
            this.adminManageCatalogCreateButton.Text = "Add";
            this.adminManageCatalogCreateButton.UseVisualStyleBackColor = true;
            this.adminManageCatalogCreateButton.Click += new System.EventHandler(this.adminManageCatalogCreateButton_Click);
            // 
            // adminManageCatalogDeleteButton
            // 
            this.adminManageCatalogDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminManageCatalogDeleteButton.Location = new System.Drawing.Point(683, 371);
            this.adminManageCatalogDeleteButton.Name = "adminManageCatalogDeleteButton";
            this.adminManageCatalogDeleteButton.Size = new System.Drawing.Size(105, 66);
            this.adminManageCatalogDeleteButton.TabIndex = 1;
            this.adminManageCatalogDeleteButton.Text = "Delete";
            this.adminManageCatalogDeleteButton.UseVisualStyleBackColor = true;
            this.adminManageCatalogDeleteButton.Click += new System.EventHandler(this.adminManageCatalogDeleteButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminManageCatalogListView
            // 
            this.adminManageCatalogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderAuthor,
            this.columnHeaderYearPublished});
            this.adminManageCatalogListView.HideSelection = false;
            this.adminManageCatalogListView.Location = new System.Drawing.Point(13, 11);
            this.adminManageCatalogListView.Name = "adminManageCatalogListView";
            this.adminManageCatalogListView.Size = new System.Drawing.Size(348, 298);
            this.adminManageCatalogListView.TabIndex = 3;
            this.adminManageCatalogListView.UseCompatibleStateImageBehavior = false;
            this.adminManageCatalogListView.View = System.Windows.Forms.View.Details;
            this.adminManageCatalogListView.SelectedIndexChanged += new System.EventHandler(this.adminManageCatalogListView_SelectedIndexChanged);
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 128;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 128;
            // 
            // columnHeaderYearPublished
            // 
            this.columnHeaderYearPublished.Text = "Year Published";
            this.columnHeaderYearPublished.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title:";
            // 
            // adminManageCatalogTitleTextBox
            // 
            this.adminManageCatalogTitleTextBox.Location = new System.Drawing.Point(92, 317);
            this.adminManageCatalogTitleTextBox.Name = "adminManageCatalogTitleTextBox";
            this.adminManageCatalogTitleTextBox.Size = new System.Drawing.Size(269, 20);
            this.adminManageCatalogTitleTextBox.TabIndex = 5;
            // 
            // adminManageCatalogAuthorTextBox
            // 
            this.adminManageCatalogAuthorTextBox.Location = new System.Drawing.Point(92, 343);
            this.adminManageCatalogAuthorTextBox.Name = "adminManageCatalogAuthorTextBox";
            this.adminManageCatalogAuthorTextBox.Size = new System.Drawing.Size(269, 20);
            this.adminManageCatalogAuthorTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author:";
            // 
            // adminManageCatalogIsbnTextBox
            // 
            this.adminManageCatalogIsbnTextBox.Location = new System.Drawing.Point(92, 369);
            this.adminManageCatalogIsbnTextBox.Name = "adminManageCatalogIsbnTextBox";
            this.adminManageCatalogIsbnTextBox.Size = new System.Drawing.Size(269, 20);
            this.adminManageCatalogIsbnTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ISBN:";
            // 
            // adminManageCatalogYearTextBox
            // 
            this.adminManageCatalogYearTextBox.Location = new System.Drawing.Point(469, 13);
            this.adminManageCatalogYearTextBox.Name = "adminManageCatalogYearTextBox";
            this.adminManageCatalogYearTextBox.Size = new System.Drawing.Size(319, 20);
            this.adminManageCatalogYearTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year:";
            // 
            // adminManageCatalogCategoryTextBox
            // 
            this.adminManageCatalogCategoryTextBox.Location = new System.Drawing.Point(469, 39);
            this.adminManageCatalogCategoryTextBox.Name = "adminManageCatalogCategoryTextBox";
            this.adminManageCatalogCategoryTextBox.Size = new System.Drawing.Size(319, 20);
            this.adminManageCatalogCategoryTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Category:";
            // 
            // adminManageCatalogEditionTextBox
            // 
            this.adminManageCatalogEditionTextBox.Location = new System.Drawing.Point(469, 65);
            this.adminManageCatalogEditionTextBox.Name = "adminManageCatalogEditionTextBox";
            this.adminManageCatalogEditionTextBox.Size = new System.Drawing.Size(319, 20);
            this.adminManageCatalogEditionTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Edition:";
            // 
            // adminManageCatalogPriceTextBox
            // 
            this.adminManageCatalogPriceTextBox.Location = new System.Drawing.Point(469, 91);
            this.adminManageCatalogPriceTextBox.Name = "adminManageCatalogPriceTextBox";
            this.adminManageCatalogPriceTextBox.Size = new System.Drawing.Size(319, 20);
            this.adminManageCatalogPriceTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Price:";
            // 
            // adminManageCatalogQuantityTextBox
            // 
            this.adminManageCatalogQuantityTextBox.Location = new System.Drawing.Point(469, 117);
            this.adminManageCatalogQuantityTextBox.Name = "adminManageCatalogQuantityTextBox";
            this.adminManageCatalogQuantityTextBox.Size = new System.Drawing.Size(319, 20);
            this.adminManageCatalogQuantityTextBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quantity:";
            // 
            // adminManageCatalogLocationTextBox
            // 
            this.adminManageCatalogLocationTextBox.Location = new System.Drawing.Point(469, 143);
            this.adminManageCatalogLocationTextBox.Name = "adminManageCatalogLocationTextBox";
            this.adminManageCatalogLocationTextBox.Size = new System.Drawing.Size(319, 20);
            this.adminManageCatalogLocationTextBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Location:";
            // 
            // adminManageCatalogDescriptionTextBox
            // 
            this.adminManageCatalogDescriptionTextBox.Location = new System.Drawing.Point(469, 200);
            this.adminManageCatalogDescriptionTextBox.Multiline = true;
            this.adminManageCatalogDescriptionTextBox.Name = "adminManageCatalogDescriptionTextBox";
            this.adminManageCatalogDescriptionTextBox.Size = new System.Drawing.Size(319, 155);
            this.adminManageCatalogDescriptionTextBox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(575, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Description";
            // 
            // adminManageCatalogUpdate
            // 
            this.adminManageCatalogUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminManageCatalogUpdate.Location = new System.Drawing.Point(573, 371);
            this.adminManageCatalogUpdate.Name = "adminManageCatalogUpdate";
            this.adminManageCatalogUpdate.Size = new System.Drawing.Size(104, 66);
            this.adminManageCatalogUpdate.TabIndex = 24;
            this.adminManageCatalogUpdate.Text = "Update";
            this.adminManageCatalogUpdate.UseVisualStyleBackColor = true;
            this.adminManageCatalogUpdate.Click += new System.EventHandler(this.adminManageCatalogUpdate_Click);
            // 
            // AdminManageCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminManageCatalogUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.adminManageCatalogDescriptionTextBox);
            this.Controls.Add(this.adminManageCatalogLocationTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.adminManageCatalogQuantityTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adminManageCatalogPriceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adminManageCatalogEditionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adminManageCatalogCategoryTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adminManageCatalogYearTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adminManageCatalogIsbnTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminManageCatalogAuthorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminManageCatalogTitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminManageCatalogListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.adminManageCatalogDeleteButton);
            this.Controls.Add(this.adminManageCatalogCreateButton);
            this.Name = "AdminManageCatalog";
            this.Text = "AdminManageCatalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminManageCatalogCreateButton;
        private System.Windows.Forms.Button adminManageCatalogDeleteButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView adminManageCatalogListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminManageCatalogTitleTextBox;
        private System.Windows.Forms.TextBox adminManageCatalogAuthorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminManageCatalogIsbnTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminManageCatalogYearTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminManageCatalogCategoryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adminManageCatalogEditionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminManageCatalogPriceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adminManageCatalogQuantityTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adminManageCatalogLocationTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox adminManageCatalogDescriptionTextBox;
        private System.Windows.Forms.Label label10;
        private ColumnHeader columnHeaderTitle;
        private ColumnHeader columnHeaderAuthor;
        private ColumnHeader columnHeaderYearPublished;
        private Button adminManageCatalogUpdate;
    }
}