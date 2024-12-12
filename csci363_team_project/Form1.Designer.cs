namespace csci363_team_project
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
            this.vehicleOnOffStatus = new System.Windows.Forms.PictureBox();
            this.InternalTempIndicator = new System.Windows.Forms.Label();
            this.RemoteStartButton = new System.Windows.Forms.Button();
            this.FuelIndicator = new System.Windows.Forms.PictureBox();
            this.BatteryIndicator = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.doorStatusLabel = new System.Windows.Forms.Label();
            this.doorStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.openTrunkButton = new System.Windows.Forms.Button();
            this.lockUnlockButton = new System.Windows.Forms.Button();
            this.armAlarmButton = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.user2Button = new System.Windows.Forms.Button();
            this.User3Button = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userMileage3 = new System.Windows.Forms.Label();
            this.userName3 = new System.Windows.Forms.Label();
            this.userMileage2 = new System.Windows.Forms.Label();
            this.userName2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.userMileage1 = new System.Windows.Forms.Label();
            this.userName1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tempDisplayTypeLabel = new System.Windows.Forms.Label();
            this.tempUnitSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.languageText = new System.Windows.Forms.Label();
            this.languageSelectBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabLocate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
            this.tabVehicleStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleOnOffStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doorStatusPictureBox)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabSettings.SuspendLayout();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 559);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabLocate
            // 
            this.tabLocate.Controls.Add(this.mapImage);
            this.tabLocate.Location = new System.Drawing.Point(4, 54);
            this.tabLocate.Margin = new System.Windows.Forms.Padding(4);
            this.tabLocate.Name = "tabLocate";
            this.tabLocate.Padding = new System.Windows.Forms.Padding(4);
            this.tabLocate.Size = new System.Drawing.Size(997, 501);
            this.tabLocate.TabIndex = 0;
            this.tabLocate.Text = "Locate";
            this.tabLocate.UseVisualStyleBackColor = true;
            // 
            // mapImage
            // 
            this.mapImage.Image = global::csci363_team_project.Properties.Resources.map;
            this.mapImage.Location = new System.Drawing.Point(11, 7);
            this.mapImage.Margin = new System.Windows.Forms.Padding(4);
            this.mapImage.Name = "mapImage";
            this.mapImage.Size = new System.Drawing.Size(973, 473);
            this.mapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mapImage.TabIndex = 0;
            this.mapImage.TabStop = false;
            // 
            // tabVehicleStatus
            // 
            this.tabVehicleStatus.Controls.Add(this.vehicleOnOffStatus);
            this.tabVehicleStatus.Controls.Add(this.InternalTempIndicator);
            this.tabVehicleStatus.Controls.Add(this.RemoteStartButton);
            this.tabVehicleStatus.Controls.Add(this.FuelIndicator);
            this.tabVehicleStatus.Controls.Add(this.BatteryIndicator);
            this.tabVehicleStatus.Controls.Add(this.pictureBox1);
            this.tabVehicleStatus.Location = new System.Drawing.Point(4, 54);
            this.tabVehicleStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tabVehicleStatus.Name = "tabVehicleStatus";
            this.tabVehicleStatus.Padding = new System.Windows.Forms.Padding(4);
            this.tabVehicleStatus.Size = new System.Drawing.Size(997, 501);
            this.tabVehicleStatus.TabIndex = 1;
            this.tabVehicleStatus.Text = "Vehicle Status";
            this.tabVehicleStatus.UseVisualStyleBackColor = true;
            // 
            // vehicleOnOffStatus
            // 
            this.vehicleOnOffStatus.Image = global::csci363_team_project.Properties.Resources.vehicleOff;
            this.vehicleOnOffStatus.Location = new System.Drawing.Point(163, 138);
            this.vehicleOnOffStatus.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleOnOffStatus.Name = "vehicleOnOffStatus";
            this.vehicleOnOffStatus.Size = new System.Drawing.Size(136, 34);
            this.vehicleOnOffStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vehicleOnOffStatus.TabIndex = 8;
            this.vehicleOnOffStatus.TabStop = false;
            // 
            // InternalTempIndicator
            // 
            this.InternalTempIndicator.AutoSize = true;
            this.InternalTempIndicator.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternalTempIndicator.ForeColor = System.Drawing.Color.Coral;
            this.InternalTempIndicator.Location = new System.Drawing.Point(647, 278);
            this.InternalTempIndicator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InternalTempIndicator.Name = "InternalTempIndicator";
            this.InternalTempIndicator.Size = new System.Drawing.Size(128, 81);
            this.InternalTempIndicator.TabIndex = 7;
            this.InternalTempIndicator.Text = "86°";
            // 
            // RemoteStartButton
            // 
            this.RemoteStartButton.Location = new System.Drawing.Point(140, 47);
            this.RemoteStartButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoteStartButton.Name = "RemoteStartButton";
            this.RemoteStartButton.Size = new System.Drawing.Size(187, 96);
            this.RemoteStartButton.TabIndex = 5;
            this.RemoteStartButton.Text = "Remote Start";
            this.RemoteStartButton.UseVisualStyleBackColor = true;
            this.RemoteStartButton.Click += new System.EventHandler(this.RemoteStartButton_Click);
            // 
            // FuelIndicator
            // 
            this.FuelIndicator.Image = global::csci363_team_project.Properties.Resources.fuelIndicatorEmpty;
            this.FuelIndicator.Location = new System.Drawing.Point(140, 266);
            this.FuelIndicator.Margin = new System.Windows.Forms.Padding(4);
            this.FuelIndicator.Name = "FuelIndicator";
            this.FuelIndicator.Size = new System.Drawing.Size(187, 122);
            this.FuelIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FuelIndicator.TabIndex = 4;
            this.FuelIndicator.TabStop = false;
            // 
            // BatteryIndicator
            // 
            this.BatteryIndicator.Image = global::csci363_team_project.Properties.Resources.battery0;
            this.BatteryIndicator.Location = new System.Drawing.Point(649, 37);
            this.BatteryIndicator.Margin = new System.Windows.Forms.Padding(4);
            this.BatteryIndicator.Name = "BatteryIndicator";
            this.BatteryIndicator.Size = new System.Drawing.Size(76, 106);
            this.BatteryIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BatteryIndicator.TabIndex = 3;
            this.BatteryIndicator.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csci363_team_project.Properties.Resources.car_jpg1;
            this.pictureBox1.Location = new System.Drawing.Point(197, -18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.doorStatusLabel);
            this.tabSecurity.Controls.Add(this.doorStatusPictureBox);
            this.tabSecurity.Controls.Add(this.openTrunkButton);
            this.tabSecurity.Controls.Add(this.lockUnlockButton);
            this.tabSecurity.Controls.Add(this.armAlarmButton);
            this.tabSecurity.Location = new System.Drawing.Point(4, 54);
            this.tabSecurity.Margin = new System.Windows.Forms.Padding(4);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tabSecurity.Size = new System.Drawing.Size(997, 501);
            this.tabSecurity.TabIndex = 2;
            this.tabSecurity.Text = "Security";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // doorStatusLabel
            // 
            this.doorStatusLabel.AutoSize = true;
            this.doorStatusLabel.Location = new System.Drawing.Point(101, 2);
            this.doorStatusLabel.Name = "doorStatusLabel";
            this.doorStatusLabel.Size = new System.Drawing.Size(173, 28);
            this.doorStatusLabel.TabIndex = 7;
            this.doorStatusLabel.Text = "Doors: All Closed";
            // 
            // doorStatusPictureBox
            // 
            this.doorStatusPictureBox.InitialImage = global::csci363_team_project.Properties.Resources.open_doorsmall;
            this.doorStatusPictureBox.Location = new System.Drawing.Point(8, 34);
            this.doorStatusPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorStatusPictureBox.Name = "doorStatusPictureBox";
            this.doorStatusPictureBox.Size = new System.Drawing.Size(368, 409);
            this.doorStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doorStatusPictureBox.TabIndex = 6;
            this.doorStatusPictureBox.TabStop = false;
            this.doorStatusPictureBox.Click += new System.EventHandler(this.doorStatusPictureBox_Click);
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
            this.openTrunkButton.Location = new System.Drawing.Point(651, 15);
            this.openTrunkButton.Margin = new System.Windows.Forms.Padding(4);
            this.openTrunkButton.Name = "openTrunkButton";
            this.openTrunkButton.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.openTrunkButton.Size = new System.Drawing.Size(120, 80);
            this.openTrunkButton.TabIndex = 5;
            this.openTrunkButton.Text = "Trunk";
            this.openTrunkButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openTrunkButton.UseVisualStyleBackColor = false;
            this.openTrunkButton.Click += new System.EventHandler(this.openTrunkButton_Click);
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
            this.lockUnlockButton.Location = new System.Drawing.Point(523, 15);
            this.lockUnlockButton.Margin = new System.Windows.Forms.Padding(4);
            this.lockUnlockButton.Name = "lockUnlockButton";
            this.lockUnlockButton.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lockUnlockButton.Size = new System.Drawing.Size(120, 80);
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
            this.armAlarmButton.Location = new System.Drawing.Point(395, 15);
            this.armAlarmButton.Margin = new System.Windows.Forms.Padding(4);
            this.armAlarmButton.Name = "armAlarmButton";
            this.armAlarmButton.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.armAlarmButton.Size = new System.Drawing.Size(120, 80);
            this.armAlarmButton.TabIndex = 0;
            this.armAlarmButton.Text = "Sound Alarm";
            this.armAlarmButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.armAlarmButton.UseVisualStyleBackColor = false;
            this.armAlarmButton.Click += new System.EventHandler(this.armAlarmButton_Click);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.user2Button);
            this.tabUsers.Controls.Add(this.User3Button);
            this.tabUsers.Controls.Add(this.pictureBox4);
            this.tabUsers.Controls.Add(this.label7);
            this.tabUsers.Controls.Add(this.userMileage3);
            this.tabUsers.Controls.Add(this.userName3);
            this.tabUsers.Controls.Add(this.userMileage2);
            this.tabUsers.Controls.Add(this.userName2);
            this.tabUsers.Controls.Add(this.pictureBox3);
            this.tabUsers.Controls.Add(this.userMileage1);
            this.tabUsers.Controls.Add(this.userName1);
            this.tabUsers.Controls.Add(this.pictureBox2);
            this.tabUsers.Location = new System.Drawing.Point(4, 54);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(4);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(997, 501);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // user2Button
            // 
            this.user2Button.Location = new System.Drawing.Point(181, 400);
            this.user2Button.Margin = new System.Windows.Forms.Padding(4);
            this.user2Button.Name = "user2Button";
            this.user2Button.Size = new System.Drawing.Size(189, 44);
            this.user2Button.TabIndex = 12;
            this.user2Button.Text = "Switch Account";
            this.user2Button.UseVisualStyleBackColor = true;
            this.user2Button.Click += new System.EventHandler(this.user2Button_Click);
            // 
            // User3Button
            // 
            this.User3Button.Location = new System.Drawing.Point(539, 400);
            this.User3Button.Margin = new System.Windows.Forms.Padding(4);
            this.User3Button.Name = "User3Button";
            this.User3Button.Size = new System.Drawing.Size(189, 44);
            this.User3Button.TabIndex = 11;
            this.User3Button.Text = "Switch Account";
            this.User3Button.UseVisualStyleBackColor = true;
            this.User3Button.Click += new System.EventHandler(this.User3Button_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::csci363_team_project.Properties.Resources.person;
            this.pictureBox4.Location = new System.Drawing.Point(385, 294);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-99, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1156, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________________________________________________________";
            // 
            // userMileage3
            // 
            this.userMileage3.AutoSize = true;
            this.userMileage3.Location = new System.Drawing.Point(533, 351);
            this.userMileage3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userMileage3.Name = "userMileage3";
            this.userMileage3.Size = new System.Drawing.Size(134, 28);
            this.userMileage3.TabIndex = 8;
            this.userMileage3.Text = "75,000 Miles";
            // 
            // userName3
            // 
            this.userName3.AutoSize = true;
            this.userName3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName3.Location = new System.Drawing.Point(532, 305);
            this.userName3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName3.Name = "userName3";
            this.userName3.Size = new System.Drawing.Size(192, 32);
            this.userName3.TabIndex = 7;
            this.userName3.Text = "HumanName#3";
            // 
            // userMileage2
            // 
            this.userMileage2.AutoSize = true;
            this.userMileage2.Location = new System.Drawing.Point(176, 351);
            this.userMileage2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userMileage2.Name = "userMileage2";
            this.userMileage2.Size = new System.Drawing.Size(122, 28);
            this.userMileage2.TabIndex = 5;
            this.userMileage2.Text = "1,443 Miles";
            // 
            // userName2
            // 
            this.userName2.AutoSize = true;
            this.userName2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName2.Location = new System.Drawing.Point(175, 305);
            this.userName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName2.Name = "userName2";
            this.userName2.Size = new System.Drawing.Size(192, 32);
            this.userName2.TabIndex = 4;
            this.userName2.Text = "HumanName#2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::csci363_team_project.Properties.Resources.person;
            this.pictureBox3.Location = new System.Drawing.Point(28, 294);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // userMileage1
            // 
            this.userMileage1.AutoSize = true;
            this.userMileage1.Location = new System.Drawing.Point(380, 90);
            this.userMileage1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userMileage1.Name = "userMileage1";
            this.userMileage1.Size = new System.Drawing.Size(146, 28);
            this.userMileage1.TabIndex = 2;
            this.userMileage1.Text = "125,000 Miles";
            // 
            // userName1
            // 
            this.userName1.AutoSize = true;
            this.userName1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName1.Location = new System.Drawing.Point(379, 43);
            this.userName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName1.Name = "userName1";
            this.userName1.Size = new System.Drawing.Size(192, 32);
            this.userName1.TabIndex = 1;
            this.userName1.Text = "HumanName#1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::csci363_team_project.Properties.Resources.person;
            this.pictureBox2.Location = new System.Drawing.Point(171, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tempDisplayTypeLabel);
            this.tabSettings.Controls.Add(this.tempUnitSelection);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Controls.Add(this.languageText);
            this.tabSettings.Controls.Add(this.languageSelectBox);
            this.tabSettings.Location = new System.Drawing.Point(4, 54);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(997, 501);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tempDisplayTypeLabel
            // 
            this.tempDisplayTypeLabel.AutoSize = true;
            this.tempDisplayTypeLabel.Location = new System.Drawing.Point(167, 128);
            this.tempDisplayTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempDisplayTypeLabel.Name = "tempDisplayTypeLabel";
            this.tempDisplayTypeLabel.Size = new System.Drawing.Size(183, 28);
            this.tempDisplayTypeLabel.TabIndex = 6;
            this.tempDisplayTypeLabel.Text = "Temperature Unit:";
            // 
            // tempUnitSelection
            // 
            this.tempUnitSelection.FormattingEnabled = true;
            this.tempUnitSelection.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius"});
            this.tempUnitSelection.Location = new System.Drawing.Point(372, 124);
            this.tempUnitSelection.Margin = new System.Windows.Forms.Padding(4);
            this.tempUnitSelection.Name = "tempUnitSelection";
            this.tempUnitSelection.Size = new System.Drawing.Size(160, 36);
            this.tempUnitSelection.TabIndex = 5;
            this.tempUnitSelection.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Placeholder Setting: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Support Line: 1-800-538-2985";
            // 
            // languageText
            // 
            this.languageText.AutoSize = true;
            this.languageText.Location = new System.Drawing.Point(167, 68);
            this.languageText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageText.Name = "languageText";
            this.languageText.Size = new System.Drawing.Size(114, 28);
            this.languageText.TabIndex = 1;
            this.languageText.Text = "Language: ";
            // 
            // languageSelectBox
            // 
            this.languageSelectBox.FormattingEnabled = true;
            this.languageSelectBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.languageSelectBox.Items.AddRange(new object[] {
            "English",
            "Español",
            "Français",
            "中国人"});
            this.languageSelectBox.Location = new System.Drawing.Point(299, 64);
            this.languageSelectBox.Margin = new System.Windows.Forms.Padding(4);
            this.languageSelectBox.Name = "languageSelectBox";
            this.languageSelectBox.Size = new System.Drawing.Size(208, 36);
            this.languageSelectBox.TabIndex = 0;
            this.languageSelectBox.Text = "English";
            // 
            // vehicleControlApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 559);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vehicleControlApp";
            this.Text = "Vehicle Manager Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLocate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).EndInit();
            this.tabVehicleStatus.ResumeLayout(false);
            this.tabVehicleStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleOnOffStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSecurity.ResumeLayout(false);
            this.tabSecurity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doorStatusPictureBox)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
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
        private System.Windows.Forms.Button RemoteStartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label InternalTempIndicator;
        private System.Windows.Forms.ComboBox languageSelectBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label languageText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tempUnitSelection;
        private System.Windows.Forms.Label tempDisplayTypeLabel;
        private System.Windows.Forms.PictureBox vehicleOnOffStatus;
        private System.Windows.Forms.Label userName1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label userMileage3;
        private System.Windows.Forms.Label userName3;
        private System.Windows.Forms.Label userMileage2;
        private System.Windows.Forms.Label userName2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label userMileage1;
        private System.Windows.Forms.Button user2Button;
        private System.Windows.Forms.Button User3Button;
    }
}

