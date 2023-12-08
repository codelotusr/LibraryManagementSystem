namespace LibraryManagementSystem.View
{
    partial class AdminPanel
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
            this.adminPanelManageCatalogButton = new System.Windows.Forms.Button();
            this.adminPanelManageFinesButton = new System.Windows.Forms.Button();
            this.adminPanelManageEventsButton = new System.Windows.Forms.Button();
            this.adminPanelReturnButton = new System.Windows.Forms.Button();
            this.adminPanelManageReservationsButton = new System.Windows.Forms.Button();
            this.adminPanelManageUsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminPanelManageCatalogButton
            // 
            this.adminPanelManageCatalogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelManageCatalogButton.Location = new System.Drawing.Point(319, 179);
            this.adminPanelManageCatalogButton.Name = "adminPanelManageCatalogButton";
            this.adminPanelManageCatalogButton.Size = new System.Drawing.Size(151, 78);
            this.adminPanelManageCatalogButton.TabIndex = 0;
            this.adminPanelManageCatalogButton.Text = "Manage Catalog";
            this.adminPanelManageCatalogButton.UseVisualStyleBackColor = true;
            this.adminPanelManageCatalogButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminPanelManageFinesButton
            // 
            this.adminPanelManageFinesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelManageFinesButton.Location = new System.Drawing.Point(594, 351);
            this.adminPanelManageFinesButton.Name = "adminPanelManageFinesButton";
            this.adminPanelManageFinesButton.Size = new System.Drawing.Size(151, 78);
            this.adminPanelManageFinesButton.TabIndex = 1;
            this.adminPanelManageFinesButton.Text = "Manage Fines";
            this.adminPanelManageFinesButton.UseVisualStyleBackColor = true;
            this.adminPanelManageFinesButton.Click += new System.EventHandler(this.adminPanelManageFinesButton_Click);
            // 
            // adminPanelManageEventsButton
            // 
            this.adminPanelManageEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelManageEventsButton.Location = new System.Drawing.Point(594, 31);
            this.adminPanelManageEventsButton.Name = "adminPanelManageEventsButton";
            this.adminPanelManageEventsButton.Size = new System.Drawing.Size(151, 78);
            this.adminPanelManageEventsButton.TabIndex = 2;
            this.adminPanelManageEventsButton.Text = "Manage Events";
            this.adminPanelManageEventsButton.UseVisualStyleBackColor = true;
            this.adminPanelManageEventsButton.Click += new System.EventHandler(this.adminPanelManageEventsButton_Click);
            // 
            // adminPanelReturnButton
            // 
            this.adminPanelReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelReturnButton.Location = new System.Drawing.Point(319, 351);
            this.adminPanelReturnButton.Name = "adminPanelReturnButton";
            this.adminPanelReturnButton.Size = new System.Drawing.Size(151, 78);
            this.adminPanelReturnButton.TabIndex = 3;
            this.adminPanelReturnButton.Text = "Return";
            this.adminPanelReturnButton.UseVisualStyleBackColor = true;
            this.adminPanelReturnButton.Click += new System.EventHandler(this.adminPanelReturnButton_Click);
            // 
            // adminPanelManageReservationsButton
            // 
            this.adminPanelManageReservationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelManageReservationsButton.Location = new System.Drawing.Point(41, 31);
            this.adminPanelManageReservationsButton.Name = "adminPanelManageReservationsButton";
            this.adminPanelManageReservationsButton.Size = new System.Drawing.Size(151, 78);
            this.adminPanelManageReservationsButton.TabIndex = 4;
            this.adminPanelManageReservationsButton.Text = "Manage Reservations";
            this.adminPanelManageReservationsButton.UseVisualStyleBackColor = true;
            // 
            // adminPanelManageUsersButton
            // 
            this.adminPanelManageUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelManageUsersButton.Location = new System.Drawing.Point(41, 351);
            this.adminPanelManageUsersButton.Name = "adminPanelManageUsersButton";
            this.adminPanelManageUsersButton.Size = new System.Drawing.Size(151, 78);
            this.adminPanelManageUsersButton.TabIndex = 5;
            this.adminPanelManageUsersButton.Text = "Manage Users";
            this.adminPanelManageUsersButton.UseVisualStyleBackColor = true;
            this.adminPanelManageUsersButton.Click += new System.EventHandler(this.adminPanelManageUsersButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminPanelManageUsersButton);
            this.Controls.Add(this.adminPanelManageReservationsButton);
            this.Controls.Add(this.adminPanelReturnButton);
            this.Controls.Add(this.adminPanelManageEventsButton);
            this.Controls.Add(this.adminPanelManageFinesButton);
            this.Controls.Add(this.adminPanelManageCatalogButton);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminPanelManageCatalogButton;
        private System.Windows.Forms.Button adminPanelManageFinesButton;
        private System.Windows.Forms.Button adminPanelManageEventsButton;
        private System.Windows.Forms.Button adminPanelReturnButton;
        private System.Windows.Forms.Button adminPanelManageReservationsButton;
        private System.Windows.Forms.Button adminPanelManageUsersButton;
    }
}