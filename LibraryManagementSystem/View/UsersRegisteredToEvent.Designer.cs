﻿namespace LibraryManagementSystem.View
{
    partial class UsersRegisteredToEvent
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
            this.memberBorrowedReturnButton = new System.Windows.Forms.Button();
            this.memberBorrowedListView = new System.Windows.Forms.ListView();
            this.memberBorrowedTitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberBorrowedAuthorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberBorrowedDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberBorrowedDueDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.memberBorrowedDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.memberBorrowedEditionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.memberBorrowedCategoryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.memberBorrowedIsbnTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.memberBorrowedYearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memberBorrowedAuthorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memberBorrowedTitleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // memberBorrowedReturnButton
            // 
            this.memberBorrowedReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberBorrowedReturnButton.Location = new System.Drawing.Point(555, 376);
            this.memberBorrowedReturnButton.Name = "memberBorrowedReturnButton";
            this.memberBorrowedReturnButton.Size = new System.Drawing.Size(110, 42);
            this.memberBorrowedReturnButton.TabIndex = 51;
            this.memberBorrowedReturnButton.Text = "Return";
            this.memberBorrowedReturnButton.UseVisualStyleBackColor = true;
            // 
            // memberBorrowedListView
            // 
            this.memberBorrowedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.memberBorrowedTitleColumn,
            this.memberBorrowedAuthorColumn,
            this.memberBorrowedDateColumn,
            this.memberBorrowedDueDateColumn});
            this.memberBorrowedListView.HideSelection = false;
            this.memberBorrowedListView.Location = new System.Drawing.Point(20, 32);
            this.memberBorrowedListView.Name = "memberBorrowedListView";
            this.memberBorrowedListView.Size = new System.Drawing.Size(347, 386);
            this.memberBorrowedListView.TabIndex = 50;
            this.memberBorrowedListView.UseCompatibleStateImageBehavior = false;
            this.memberBorrowedListView.View = System.Windows.Forms.View.Details;
            // 
            // memberBorrowedTitleColumn
            // 
            this.memberBorrowedTitleColumn.Text = "Title";
            this.memberBorrowedTitleColumn.Width = 105;
            // 
            // memberBorrowedAuthorColumn
            // 
            this.memberBorrowedAuthorColumn.Text = "Author";
            this.memberBorrowedAuthorColumn.Width = 83;
            // 
            // memberBorrowedDateColumn
            // 
            this.memberBorrowedDateColumn.Text = "Borrowed";
            this.memberBorrowedDateColumn.Width = 84;
            // 
            // memberBorrowedDueDateColumn
            // 
            this.memberBorrowedDueDateColumn.Text = "Due";
            this.memberBorrowedDueDateColumn.Width = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "Description";
            // 
            // memberBorrowedDescriptionTextBox
            // 
            this.memberBorrowedDescriptionTextBox.Location = new System.Drawing.Point(446, 224);
            this.memberBorrowedDescriptionTextBox.Multiline = true;
            this.memberBorrowedDescriptionTextBox.Name = "memberBorrowedDescriptionTextBox";
            this.memberBorrowedDescriptionTextBox.Size = new System.Drawing.Size(334, 126);
            this.memberBorrowedDescriptionTextBox.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Edition:";
            // 
            // memberBorrowedEditionTextBox
            // 
            this.memberBorrowedEditionTextBox.Location = new System.Drawing.Point(446, 168);
            this.memberBorrowedEditionTextBox.Name = "memberBorrowedEditionTextBox";
            this.memberBorrowedEditionTextBox.Size = new System.Drawing.Size(334, 20);
            this.memberBorrowedEditionTextBox.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 45;
            this.label8.Text = "Category:";
            // 
            // memberBorrowedCategoryTextBox
            // 
            this.memberBorrowedCategoryTextBox.Location = new System.Drawing.Point(446, 140);
            this.memberBorrowedCategoryTextBox.Name = "memberBorrowedCategoryTextBox";
            this.memberBorrowedCategoryTextBox.Size = new System.Drawing.Size(334, 20);
            this.memberBorrowedCategoryTextBox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "ISBN:";
            // 
            // memberBorrowedIsbnTextBox
            // 
            this.memberBorrowedIsbnTextBox.Location = new System.Drawing.Point(446, 114);
            this.memberBorrowedIsbnTextBox.Name = "memberBorrowedIsbnTextBox";
            this.memberBorrowedIsbnTextBox.Size = new System.Drawing.Size(334, 20);
            this.memberBorrowedIsbnTextBox.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Year:";
            // 
            // memberBorrowedYearTextBox
            // 
            this.memberBorrowedYearTextBox.Location = new System.Drawing.Point(446, 88);
            this.memberBorrowedYearTextBox.Name = "memberBorrowedYearTextBox";
            this.memberBorrowedYearTextBox.Size = new System.Drawing.Size(334, 20);
            this.memberBorrowedYearTextBox.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Author:";
            // 
            // memberBorrowedAuthorTextBox
            // 
            this.memberBorrowedAuthorTextBox.Location = new System.Drawing.Point(446, 60);
            this.memberBorrowedAuthorTextBox.Name = "memberBorrowedAuthorTextBox";
            this.memberBorrowedAuthorTextBox.Size = new System.Drawing.Size(334, 20);
            this.memberBorrowedAuthorTextBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Title:";
            // 
            // memberBorrowedTitleTextBox
            // 
            this.memberBorrowedTitleTextBox.Location = new System.Drawing.Point(446, 32);
            this.memberBorrowedTitleTextBox.Name = "memberBorrowedTitleTextBox";
            this.memberBorrowedTitleTextBox.Size = new System.Drawing.Size(334, 20);
            this.memberBorrowedTitleTextBox.TabIndex = 36;
            // 
            // UsersRegisteredToEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memberBorrowedReturnButton);
            this.Controls.Add(this.memberBorrowedListView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.memberBorrowedDescriptionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.memberBorrowedEditionTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.memberBorrowedCategoryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.memberBorrowedIsbnTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memberBorrowedYearTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberBorrowedAuthorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberBorrowedTitleTextBox);
            this.Name = "UsersRegisteredToEvent";
            this.Text = "UsersRegisteredToEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memberBorrowedReturnButton;
        private System.Windows.Forms.ListView memberBorrowedListView;
        private System.Windows.Forms.ColumnHeader memberBorrowedTitleColumn;
        private System.Windows.Forms.ColumnHeader memberBorrowedAuthorColumn;
        private System.Windows.Forms.ColumnHeader memberBorrowedDateColumn;
        private System.Windows.Forms.ColumnHeader memberBorrowedDueDateColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox memberBorrowedDescriptionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox memberBorrowedEditionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox memberBorrowedCategoryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox memberBorrowedIsbnTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox memberBorrowedYearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox memberBorrowedAuthorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberBorrowedTitleTextBox;
    }
}