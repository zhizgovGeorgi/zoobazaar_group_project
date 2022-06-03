﻿namespace ZooBazzar_Group03
{
    partial class MainManu
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pContent = new System.Windows.Forms.Panel();
            this.btnScanning = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pLogo.SuspendLayout();
            this.pTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.pMenu.Controls.Add(this.btnTickets);
            this.pMenu.Controls.Add(this.btnScanning);
            this.pMenu.Controls.Add(this.btnStatistics);
            this.pMenu.Controls.Add(this.panel1);
            this.pMenu.Controls.Add(this.btnSettings);
            this.pMenu.Controls.Add(this.btnRequest);
            this.pMenu.Controls.Add(this.btnContracts);
            this.pMenu.Controls.Add(this.btnEmployees);
            this.pMenu.Controls.Add(this.btnSchedule);
            this.pMenu.Controls.Add(this.button1);
            this.pMenu.Controls.Add(this.btnHome);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(247, 734);
            this.pMenu.TabIndex = 0;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStatistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 470);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(247, 60);
            this.btnStatistics.TabIndex = 8;
            this.btnStatistics.Text = "   Statistics";
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblGreeting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 139);
            this.panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.logout_pic;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(201, 93);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 36);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(12, 109);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(110, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "10:47 o\'clock";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGreeting.Location = new System.Drawing.Point(12, 71);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(84, 20);
            this.lblGreeting.TabIndex = 2;
            this.lblGreeting.Text = "Hello, ... !";
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 410);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(247, 60);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "   Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRequest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequest.Location = new System.Drawing.Point(0, 350);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(247, 60);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "   Requests";
            this.btnRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContracts.FlatAppearance.BorderSize = 0;
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContracts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(0, 290);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(247, 60);
            this.btnContracts.TabIndex = 5;
            this.btnContracts.Text = "   Contracts";
            this.btnContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 230);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(247, 60);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "   Employees";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSchedule.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(0, 170);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(247, 60);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "   Schedule";
            this.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "   Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 110);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(247, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "   Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pLogo.Controls.Add(this.lblLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(247, 110);
            this.pLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogo.Location = new System.Drawing.Point(68, 40);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(128, 35);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ZooBazzar";
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.pTitle.Controls.Add(this.lblTitle);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(247, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(980, 110);
            this.pTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(443, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 35);
            this.lblTitle.TabIndex = 1;
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pContent.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.logo_zooBazzar;
            this.pContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(247, 110);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(980, 624);
            this.pContent.TabIndex = 2;
            // 
            // btnScanning
            // 
            this.btnScanning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScanning.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScanning.FlatAppearance.BorderSize = 0;
            this.btnScanning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanning.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScanning.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnScanning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanning.Location = new System.Drawing.Point(0, 530);
            this.btnScanning.Name = "btnScanning";
            this.btnScanning.Size = new System.Drawing.Size(247, 60);
            this.btnScanning.TabIndex = 9;
            this.btnScanning.Text = "   Scanning";
            this.btnScanning.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScanning.UseVisualStyleBackColor = true;
            this.btnScanning.Click += new System.EventHandler(this.btnScanning_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTickets.FlatAppearance.BorderSize = 0;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTickets.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTickets.Location = new System.Drawing.Point(0, 590);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(247, 60);
            this.btnTickets.TabIndex = 10;
            this.btnTickets.Text = "   Tickets";
            this.btnTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTickets.UseVisualStyleBackColor = true;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // MainManu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 734);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.pMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainManu";
            this.Text = "MainManu";
            this.pMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pMenu;
        private Panel pLogo;
        private Label lblLogo;
        private Panel pTitle;
        private Label lblTitle;
        private Panel panel1;
        private Label lblGreeting;
        private Button btnSettings;
        private Button btnRequest;
        private Button btnContracts;
        private Button btnEmployees;
        private Button btnSchedule;
        private Button button1;
        private Button btnHome;
        private Label lblTime;
        private Panel pContent;
        private Button btnLogout;
        private Button btnStatistics;
        private Button btnTickets;
        private Button btnScanning;
    }
}