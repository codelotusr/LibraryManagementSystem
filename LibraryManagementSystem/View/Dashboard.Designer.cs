namespace LibraryManagementSystem
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.catalogButton = new System.Windows.Forms.Button();
            this.eventsButton = new System.Windows.Forms.Button();
            this.finesButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.adminPanelButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // catalogButton
            // 
            this.catalogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogButton.Location = new System.Drawing.Point(51, 303);
            this.catalogButton.Name = "catalogButton";
            this.catalogButton.Size = new System.Drawing.Size(128, 51);
            this.catalogButton.TabIndex = 1;
            this.catalogButton.Text = "Catalog";
            this.catalogButton.UseVisualStyleBackColor = true;
            this.catalogButton.Click += new System.EventHandler(this.catalogButton_Click);
            // 
            // eventsButton
            // 
            this.eventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsButton.Location = new System.Drawing.Point(239, 303);
            this.eventsButton.Name = "eventsButton";
            this.eventsButton.Size = new System.Drawing.Size(128, 51);
            this.eventsButton.TabIndex = 2;
            this.eventsButton.Text = "Events";
            this.eventsButton.UseVisualStyleBackColor = true;
            this.eventsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // finesButton
            // 
            this.finesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finesButton.Location = new System.Drawing.Point(435, 303);
            this.finesButton.Name = "finesButton";
            this.finesButton.Size = new System.Drawing.Size(128, 51);
            this.finesButton.TabIndex = 3;
            this.finesButton.Text = "Fines";
            this.finesButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(640, 303);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(128, 51);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminPanelButton
            // 
            this.adminPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelButton.Location = new System.Drawing.Point(640, 21);
            this.adminPanelButton.Name = "adminPanelButton";
            this.adminPanelButton.Size = new System.Drawing.Size(128, 62);
            this.adminPanelButton.TabIndex = 5;
            this.adminPanelButton.Text = "Admin Panel";
            this.adminPanelButton.UseVisualStyleBackColor = true;
            this.adminPanelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(51, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(128, 51);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.adminPanelButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.finesButton);
            this.Controls.Add(this.eventsButton);
            this.Controls.Add(this.catalogButton);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button catalogButton;
        private System.Windows.Forms.Button eventsButton;
        private System.Windows.Forms.Button finesButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button adminPanelButton;
        private System.Windows.Forms.Button logoutButton;
    }
}