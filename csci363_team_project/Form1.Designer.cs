﻿namespace csci363_team_project
{
    partial class vehicleControlApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehicleControlApp));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLocate = new System.Windows.Forms.TabPage();
            this.mapImage = new System.Windows.Forms.PictureBox();
            this.tabVehicleStatus = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.remoteStartButton = new System.Windows.Forms.Button();
            this.FuelIndicator = new System.Windows.Forms.PictureBox();
            this.BatteryIndicator = new System.Windows.Forms.PictureBox();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.doorStatusLabel = new System.Windows.Forms.Label();
            this.doorStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.openTrunkButton = new System.Windows.Forms.Button();
            this.lockUnlockButton = new System.Windows.Forms.Button();
            this.armAlarmButton = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.internalTempIndicator = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLocate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
            this.tabVehicleStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIndicator)).BeginInit();
            this.tabSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doorStatusPictureBox)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLocate);
            this.tabControl1.Controls.Add(this.tabVehicleStatus);
            this.tabControl1.Controls.Add(this.tabSecurity);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 454);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabLocate
            // 
            this.tabLocate.Controls.Add(this.mapImage);
            this.tabLocate.Location = new System.Drawing.Point(4, 54);
            this.tabLocate.Name = "tabLocate";
            this.tabLocate.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocate.Size = new System.Drawing.Size(746, 396);
            this.tabLocate.TabIndex = 0;
            this.tabLocate.Text = "Locate";
            this.tabLocate.UseVisualStyleBackColor = true;
            // 
            // mapImage
            // 
            this.mapImage.Image = global::csci363_team_project.Properties.Resources.map;
            this.mapImage.Location = new System.Drawing.Point(8, 6);
            this.mapImage.Name = "mapImage";
            this.mapImage.Size = new System.Drawing.Size(730, 384);
            this.mapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mapImage.TabIndex = 0;
            this.mapImage.TabStop = false;
            // 
            // tabVehicleStatus
            // 
            this.tabVehicleStatus.Controls.Add(this.internalTempIndicator);
            this.tabVehicleStatus.Controls.Add(this.remoteStartButton);
            this.tabVehicleStatus.Controls.Add(this.FuelIndicator);
            this.tabVehicleStatus.Controls.Add(this.BatteryIndicator);
            this.tabVehicleStatus.Controls.Add(this.pictureBox1);
            this.tabVehicleStatus.Location = new System.Drawing.Point(4, 54);
            this.tabVehicleStatus.Name = "tabVehicleStatus";
            this.tabVehicleStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicleStatus.Size = new System.Drawing.Size(746, 396);
            this.tabVehicleStatus.TabIndex = 1;
            this.tabVehicleStatus.Text = "Vehicle Status";
            this.tabVehicleStatus.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csci363_team_project.Properties.Resources.car_jpg1;
            this.pictureBox1.Location = new System.Drawing.Point(148, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // remoteStartButton
            // 
            this.remoteStartButton.Location = new System.Drawing.Point(105, 38);
            this.remoteStartButton.Name = "remoteStartButton";
            this.remoteStartButton.Size = new System.Drawing.Size(140, 78);
            this.remoteStartButton.TabIndex = 5;
            this.remoteStartButton.Text = "Remote Start";
            this.remoteStartButton.UseVisualStyleBackColor = true;
            // 
            // FuelIndicator
            // 
            this.FuelIndicator.Image = global::csci363_team_project.Properties.Resources.fuelIndicatorEmpty;
            this.FuelIndicator.Location = new System.Drawing.Point(105, 216);
            this.FuelIndicator.Name = "FuelIndicator";
            this.FuelIndicator.Size = new System.Drawing.Size(140, 99);
            this.FuelIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FuelIndicator.TabIndex = 4;
            this.FuelIndicator.TabStop = false;
            // 
            // BatteryIndicator
            // 
            this.BatteryIndicator.Image = global::csci363_team_project.Properties.Resources.battery0;
            this.BatteryIndicator.Location = new System.Drawing.Point(479, 6);
            this.BatteryIndicator.Name = "BatteryIndicator";
            this.BatteryIndicator.Size = new System.Drawing.Size(57, 86);
            this.BatteryIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BatteryIndicator.TabIndex = 3;
            this.BatteryIndicator.TabStop = false;
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.doorStatusLabel);
            this.tabSecurity.Controls.Add(this.doorStatusPictureBox);
            this.tabSecurity.Controls.Add(this.openTrunkButton);
            this.tabSecurity.Controls.Add(this.lockUnlockButton);
            this.tabSecurity.Controls.Add(this.armAlarmButton);
            this.tabSecurity.Location = new System.Drawing.Point(4, 54);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tabSecurity.Size = new System.Drawing.Size(746, 396);
            this.tabSecurity.TabIndex = 2;
            this.tabSecurity.Text = "Security";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // doorStatusLabel
            // 
            this.doorStatusLabel.AutoSize = true;
            this.doorStatusLabel.Location = new System.Drawing.Point(76, 2);
            this.doorStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doorStatusLabel.Name = "doorStatusLabel";
            this.doorStatusLabel.Size = new System.Drawing.Size(139, 21);
            this.doorStatusLabel.TabIndex = 7;
            this.doorStatusLabel.Text = "Doors: All Closed";
            // 
            // doorStatusPictureBox
            // 
            this.doorStatusPictureBox.InitialImage = global::csci363_team_project.Properties.Resources.open_doorsmall;
            this.doorStatusPictureBox.Location = new System.Drawing.Point(6, 28);
            this.doorStatusPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.doorStatusPictureBox.Name = "doorStatusPictureBox";
            this.doorStatusPictureBox.Size = new System.Drawing.Size(276, 332);
            this.doorStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doorStatusPictureBox.TabIndex = 6;
            this.doorStatusPictureBox.TabStop = false;
            // 
            // openTrunkButton
            // 
            this.openTrunkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.openTrunkButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.openTrunkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.openTrunkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTrunkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTrunkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openTrunkButton.Image = global::csci363_team_project.Properties.Resources.trunksmall;
            this.openTrunkButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openTrunkButton.Location = new System.Drawing.Point(488, 12);
            this.openTrunkButton.Name = "openTrunkButton";
            this.openTrunkButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.openTrunkButton.Size = new System.Drawing.Size(90, 65);
            this.openTrunkButton.TabIndex = 5;
            this.openTrunkButton.Text = "Trunk";
            this.openTrunkButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openTrunkButton.UseVisualStyleBackColor = false;
            // 
            // lockUnlockButton
            // 
            this.lockUnlockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lockUnlockButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.lockUnlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.lockUnlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lockUnlockButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockUnlockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lockUnlockButton.Image = ((System.Drawing.Image)(resources.GetObject("lockUnlockButton.Image")));
            this.lockUnlockButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lockUnlockButton.Location = new System.Drawing.Point(392, 12);
            this.lockUnlockButton.Name = "lockUnlockButton";
            this.lockUnlockButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lockUnlockButton.Size = new System.Drawing.Size(90, 65);
            this.lockUnlockButton.TabIndex = 4;
            this.lockUnlockButton.Text = "Locked";
            this.lockUnlockButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lockUnlockButton.UseVisualStyleBackColor = false;
            this.lockUnlockButton.Click += new System.EventHandler(this.lockUnlockButton_Click);
            // 
            // armAlarmButton
            // 
            this.armAlarmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.armAlarmButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.armAlarmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.armAlarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.armAlarmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armAlarmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.armAlarmButton.Image = ((System.Drawing.Image)(resources.GetObject("armAlarmButton.Image")));
            this.armAlarmButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.armAlarmButton.Location = new System.Drawing.Point(296, 12);
            this.armAlarmButton.Name = "armAlarmButton";
            this.armAlarmButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.armAlarmButton.Size = new System.Drawing.Size(90, 65);
            this.armAlarmButton.TabIndex = 0;
            this.armAlarmButton.Text = "Sound Alarm";
            this.armAlarmButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.armAlarmButton.UseVisualStyleBackColor = false;
            this.armAlarmButton.Click += new System.EventHandler(this.armAlarmButton_Click);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.pictureBox2);
            this.tabUsers.Location = new System.Drawing.Point(4, 54);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(746, 396);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::csci363_team_project.Properties.Resources.person;
            this.pictureBox2.Location = new System.Drawing.Point(10, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 54);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(746, 396);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // internalTempIndicator
            // 
            this.internalTempIndicator.AutoSize = true;
            this.internalTempIndicator.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internalTempIndicator.ForeColor = System.Drawing.Color.Coral;
            this.internalTempIndicator.Location = new System.Drawing.Point(486, 216);
            this.internalTempIndicator.Name = "internalTempIndicator";
            this.internalTempIndicator.Size = new System.Drawing.Size(102, 65);
            this.internalTempIndicator.TabIndex = 7;
            this.internalTempIndicator.Text = "86°";
            // 
            // vehicleControlApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "vehicleControlApp";
            this.Text = "Vehicle Manager Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLocate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).EndInit();
            this.tabVehicleStatus.ResumeLayout(false);
            this.tabVehicleStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIndicator)).EndInit();
            this.tabSecurity.ResumeLayout(false);
            this.tabSecurity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doorStatusPictureBox)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLocate;
        private System.Windows.Forms.TabPage tabVehicleStatus;
        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button armAlarmButton;
        private System.Windows.Forms.PictureBox BatteryIndicator;
        private System.Windows.Forms.PictureBox FuelIndicator;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button lockUnlockButton;
        private System.Windows.Forms.Button openTrunkButton;
        private System.Windows.Forms.PictureBox doorStatusPictureBox;
        private System.Windows.Forms.Label doorStatusLabel;
        private System.Windows.Forms.PictureBox mapImage;
        private System.Windows.Forms.Button remoteStartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label internalTempIndicator;
    }
}

