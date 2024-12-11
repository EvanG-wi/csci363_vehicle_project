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
            this.tabVehicleStatus = new System.Windows.Forms.TabPage();
            this.InternalTempIndicator = new System.Windows.Forms.Label();
            this.RemoteStartButton = new System.Windows.Forms.Button();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.doorStatusLabel = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tempDisplayTypeLabel = new System.Windows.Forms.Label();
            this.tempUnitSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.languageText = new System.Windows.Forms.Label();
            this.languageSelectBox = new System.Windows.Forms.ComboBox();
            this.userName1 = new System.Windows.Forms.Label();
            this.mileageTracker = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userName3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mapImage = new System.Windows.Forms.PictureBox();
            this.vehicleOnOffStatus = new System.Windows.Forms.PictureBox();
            this.FuelIndicator = new System.Windows.Forms.PictureBox();
            this.BatteryIndicator = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doorStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.openTrunkButton = new System.Windows.Forms.Button();
            this.lockUnlockButton = new System.Windows.Forms.Button();
            this.armAlarmButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabLocate.SuspendLayout();
            this.tabVehicleStatus.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleOnOffStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorStatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            // tabVehicleStatus
            // 
            this.tabVehicleStatus.Controls.Add(this.vehicleOnOffStatus);
            this.tabVehicleStatus.Controls.Add(this.InternalTempIndicator);
            this.tabVehicleStatus.Controls.Add(this.RemoteStartButton);
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
            // InternalTempIndicator
            // 
            this.InternalTempIndicator.AutoSize = true;
            this.InternalTempIndicator.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternalTempIndicator.ForeColor = System.Drawing.Color.Coral;
            this.InternalTempIndicator.Location = new System.Drawing.Point(485, 226);
            this.InternalTempIndicator.Name = "InternalTempIndicator";
            this.InternalTempIndicator.Size = new System.Drawing.Size(102, 65);
            this.InternalTempIndicator.TabIndex = 7;
            this.InternalTempIndicator.Text = "86°";
            // 
            // RemoteStartButton
            // 
            this.RemoteStartButton.Location = new System.Drawing.Point(105, 38);
            this.RemoteStartButton.Name = "RemoteStartButton";
            this.RemoteStartButton.Size = new System.Drawing.Size(140, 78);
            this.RemoteStartButton.TabIndex = 5;
            this.RemoteStartButton.Text = "Remote Start";
            this.RemoteStartButton.UseVisualStyleBackColor = true;
            this.RemoteStartButton.Click += new System.EventHandler(this.RemoteStartButton_Click);
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
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.pictureBox4);
            this.tabUsers.Controls.Add(this.label7);
            this.tabUsers.Controls.Add(this.label5);
            this.tabUsers.Controls.Add(this.userName3);
            this.tabUsers.Controls.Add(this.label3);
            this.tabUsers.Controls.Add(this.userName2);
            this.tabUsers.Controls.Add(this.pictureBox3);
            this.tabUsers.Controls.Add(this.mileageTracker);
            this.tabUsers.Controls.Add(this.userName1);
            this.tabUsers.Controls.Add(this.pictureBox2);
            this.tabUsers.Location = new System.Drawing.Point(4, 54);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(746, 396);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
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
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(746, 396);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tempDisplayTypeLabel
            // 
            this.tempDisplayTypeLabel.AutoSize = true;
            this.tempDisplayTypeLabel.Location = new System.Drawing.Point(125, 104);
            this.tempDisplayTypeLabel.Name = "tempDisplayTypeLabel";
            this.tempDisplayTypeLabel.Size = new System.Drawing.Size(148, 21);
            this.tempDisplayTypeLabel.TabIndex = 6;
            this.tempDisplayTypeLabel.Text = "Temperature Unit:";
            // 
            // tempUnitSelection
            // 
            this.tempUnitSelection.FormattingEnabled = true;
            this.tempUnitSelection.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius"});
            this.tempUnitSelection.Location = new System.Drawing.Point(279, 101);
            this.tempUnitSelection.Name = "tempUnitSelection";
            this.tempUnitSelection.Size = new System.Drawing.Size(121, 29);
            this.tempUnitSelection.TabIndex = 5;
            this.tempUnitSelection.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Placeholder Setting: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Support Line: 1-800-538-2985";
            // 
            // languageText
            // 
            this.languageText.AutoSize = true;
            this.languageText.Location = new System.Drawing.Point(125, 55);
            this.languageText.Name = "languageText";
            this.languageText.Size = new System.Drawing.Size(93, 21);
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
            this.languageSelectBox.Location = new System.Drawing.Point(224, 52);
            this.languageSelectBox.Name = "languageSelectBox";
            this.languageSelectBox.Size = new System.Drawing.Size(157, 29);
            this.languageSelectBox.TabIndex = 0;
            this.languageSelectBox.Text = "English";
            // 
            // userName1
            // 
            this.userName1.AutoSize = true;
            this.userName1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName1.Location = new System.Drawing.Point(284, 35);
            this.userName1.Name = "userName1";
            this.userName1.Size = new System.Drawing.Size(152, 25);
            this.userName1.TabIndex = 1;
            this.userName1.Text = "HumanName#1";
            // 
            // mileageTracker
            // 
            this.mileageTracker.AutoSize = true;
            this.mileageTracker.Location = new System.Drawing.Point(285, 73);
            this.mileageTracker.Name = "mileageTracker";
            this.mileageTracker.Size = new System.Drawing.Size(113, 21);
            this.mileageTracker.TabIndex = 2;
            this.mileageTracker.Text = "125,000 Miles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "1,443 Miles";
            // 
            // userName2
            // 
            this.userName2.AutoSize = true;
            this.userName2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName2.Location = new System.Drawing.Point(131, 248);
            this.userName2.Name = "userName2";
            this.userName2.Size = new System.Drawing.Size(152, 25);
            this.userName2.TabIndex = 4;
            this.userName2.Text = "HumanName#2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "75,000 Miles";
            // 
            // userName3
            // 
            this.userName3.AutoSize = true;
            this.userName3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName3.Location = new System.Drawing.Point(399, 248);
            this.userName3.Name = "userName3";
            this.userName3.Size = new System.Drawing.Size(152, 25);
            this.userName3.TabIndex = 7;
            this.userName3.Text = "HumanName#3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-74, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1011, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________________________________________________________";
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
            // vehicleOnOffStatus
            // 
            this.vehicleOnOffStatus.Image = global::csci363_team_project.Properties.Resources.vehicleOff;
            this.vehicleOnOffStatus.Location = new System.Drawing.Point(122, 112);
            this.vehicleOnOffStatus.Name = "vehicleOnOffStatus";
            this.vehicleOnOffStatus.Size = new System.Drawing.Size(102, 28);
            this.vehicleOnOffStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vehicleOnOffStatus.TabIndex = 8;
            this.vehicleOnOffStatus.TabStop = false;
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
            this.BatteryIndicator.Location = new System.Drawing.Point(487, 30);
            this.BatteryIndicator.Name = "BatteryIndicator";
            this.BatteryIndicator.Size = new System.Drawing.Size(57, 86);
            this.BatteryIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BatteryIndicator.TabIndex = 3;
            this.BatteryIndicator.TabStop = false;
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
            // pictureBox4
            // 
            this.pictureBox4.Image = global::csci363_team_project.Properties.Resources.person;
            this.pictureBox4.Location = new System.Drawing.Point(289, 239);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(104, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::csci363_team_project.Properties.Resources.person;
            this.pictureBox3.Location = new System.Drawing.Point(21, 239);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::csci363_team_project.Properties.Resources.person;
            this.pictureBox2.Location = new System.Drawing.Point(128, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            this.tabVehicleStatus.ResumeLayout(false);
            this.tabVehicleStatus.PerformLayout();
            this.tabSecurity.ResumeLayout(false);
            this.tabSecurity.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleOnOffStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorStatusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label userName3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userName2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label mileageTracker;
    }
}

