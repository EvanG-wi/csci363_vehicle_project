namespace csci363_team_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLocate = new System.Windows.Forms.TabPage();
            this.tabVehicleStatus = new System.Windows.Forms.TabPage();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.FuelIndicator = new System.Windows.Forms.PictureBox();
            this.BatteryIndicator = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openTrunkButton = new System.Windows.Forms.Button();
            this.lockUnlockButton = new System.Windows.Forms.Button();
            this.armAlarmButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabVehicleStatus.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuelIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.ItemSize = new System.Drawing.Size(159, 100);
            this.tabControl1.Location = new System.Drawing.Point(-4, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1069, 553);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabLocate
            // 
            this.tabLocate.Location = new System.Drawing.Point(4, 104);
            this.tabLocate.Margin = new System.Windows.Forms.Padding(4);
            this.tabLocate.Name = "tabLocate";
            this.tabLocate.Padding = new System.Windows.Forms.Padding(4);
            this.tabLocate.Size = new System.Drawing.Size(1061, 445);
            this.tabLocate.TabIndex = 0;
            this.tabLocate.Text = "Locate";
            this.tabLocate.UseVisualStyleBackColor = true;
            // 
            // tabVehicleStatus
            // 
            this.tabVehicleStatus.Controls.Add(this.FuelIndicator);
            this.tabVehicleStatus.Controls.Add(this.BatteryIndicator);
            this.tabVehicleStatus.Controls.Add(this.pictureBox1);
            this.tabVehicleStatus.Location = new System.Drawing.Point(4, 104);
            this.tabVehicleStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tabVehicleStatus.Name = "tabVehicleStatus";
            this.tabVehicleStatus.Padding = new System.Windows.Forms.Padding(4);
            this.tabVehicleStatus.Size = new System.Drawing.Size(1061, 445);
            this.tabVehicleStatus.TabIndex = 1;
            this.tabVehicleStatus.Text = "Vehicle Status";
            this.tabVehicleStatus.UseVisualStyleBackColor = true;
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.pictureBox3);
            this.tabSecurity.Controls.Add(this.openTrunkButton);
            this.tabSecurity.Controls.Add(this.lockUnlockButton);
            this.tabSecurity.Controls.Add(this.armAlarmButton);
            this.tabSecurity.Location = new System.Drawing.Point(4, 104);
            this.tabSecurity.Margin = new System.Windows.Forms.Padding(4);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tabSecurity.Size = new System.Drawing.Size(1061, 445);
            this.tabSecurity.TabIndex = 2;
            this.tabSecurity.Text = "Security";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.pictureBox2);
            this.tabUsers.Location = new System.Drawing.Point(4, 104);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(4);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(1061, 445);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 104);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1061, 445);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // FuelIndicator
            // 
            this.FuelIndicator.Image = global::csci363_team_project.Properties.Resources.fuelIndicatorEmpty;
            this.FuelIndicator.Location = new System.Drawing.Point(526, 8);
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
            this.BatteryIndicator.Location = new System.Drawing.Point(721, 24);
            this.BatteryIndicator.Margin = new System.Windows.Forms.Padding(4);
            this.BatteryIndicator.Name = "BatteryIndicator";
            this.BatteryIndicator.Size = new System.Drawing.Size(76, 106);
            this.BatteryIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BatteryIndicator.TabIndex = 3;
            this.BatteryIndicator.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csci363_team_project.Properties.Resources.car_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.InitialImage = global::csci363_team_project.Properties.Resources.open_door;
            this.pictureBox3.Location = new System.Drawing.Point(8, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(379, 442);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
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
            this.openTrunkButton.Location = new System.Drawing.Point(394, 191);
            this.openTrunkButton.Margin = new System.Windows.Forms.Padding(4);
            this.openTrunkButton.Name = "openTrunkButton";
            this.openTrunkButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.openTrunkButton.Size = new System.Drawing.Size(120, 80);
            this.openTrunkButton.TabIndex = 5;
            this.openTrunkButton.Text = "Trunk";
            this.openTrunkButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openTrunkButton.UseVisualStyleBackColor = false;
            this.openTrunkButton.Click += new System.EventHandler(this.button1_Click);
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
            this.lockUnlockButton.Location = new System.Drawing.Point(394, 103);
            this.lockUnlockButton.Margin = new System.Windows.Forms.Padding(4);
            this.lockUnlockButton.Name = "lockUnlockButton";
            this.lockUnlockButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
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
            this.armAlarmButton.Location = new System.Drawing.Point(394, 15);
            this.armAlarmButton.Margin = new System.Windows.Forms.Padding(4);
            this.armAlarmButton.Name = "armAlarmButton";
            this.armAlarmButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.armAlarmButton.Size = new System.Drawing.Size(120, 80);
            this.armAlarmButton.TabIndex = 0;
            this.armAlarmButton.Text = "Sound Alarm";
            this.armAlarmButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.armAlarmButton.UseVisualStyleBackColor = false;
            this.armAlarmButton.Click += new System.EventHandler(this.armAlarmButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::csci363_team_project.Properties.Resources.person;
            this.pictureBox2.Location = new System.Drawing.Point(139, 162);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 559);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Vehicle Manager Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabVehicleStatus.ResumeLayout(false);
            this.tabSecurity.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FuelIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BatteryIndicator;
        private System.Windows.Forms.PictureBox FuelIndicator;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button lockUnlockButton;
        private System.Windows.Forms.Button openTrunkButton;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

