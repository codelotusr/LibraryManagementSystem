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
            this.adminPanelManageEventsButton = new System.Windows.Forms.Button();
            this.adminPanelReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminPanelManageCatalogButton
            // 
            this.adminPanelManageCatalogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelManageCatalogButton.Location = new System.Drawing.Point(102, 179);
            this.adminPanelManageCatalogButton.Name = "adminPanelManageCatalogButton";
            this.adminPanelManageCatalogButton.Size = new System.Drawing.Size(151, 78);
            this.adminPanelManageCatalogButton.TabIndex = 0;
            this.adminPanelManageCatalogButton.Text = "Manage Catalog";
            this.adminPanelManageCatalogButton.UseVisualStyleBackColor = true;
            this.adminPanelManageCatalogButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminPanelManageEventsButton
            // 
            this.adminPanelManageEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelManageEventsButton.Location = new System.Drawing.Point(583, 179);
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
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminPanelReturnButton);
            this.Controls.Add(this.adminPanelManageEventsButton);
            this.Controls.Add(this.adminPanelManageCatalogButton);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminPanelManageCatalogButton;
        private System.Windows.Forms.Button adminPanelManageEventsButton;
        private System.Windows.Forms.Button adminPanelReturnButton;
    }
}