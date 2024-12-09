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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLocate = new System.Windows.Forms.TabPage();
            this.tabVehicleStatus = new System.Windows.Forms.TabPage();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.FuelIndicator = new System.Windows.Forms.PictureBox();
            this.BatteryIndicator = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RemoteStartButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabVehicleStatus.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuelIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 449);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabLocate
            // 
            this.tabLocate.Location = new System.Drawing.Point(4, 104);
            this.tabLocate.Name = "tabLocate";
            this.tabLocate.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocate.Size = new System.Drawing.Size(794, 341);
            this.tabLocate.TabIndex = 0;
            this.tabLocate.Text = "Locate";
            this.tabLocate.UseVisualStyleBackColor = true;
            // 
            // tabVehicleStatus
            // 
            this.tabVehicleStatus.Controls.Add(this.RemoteStartButton);
            this.tabVehicleStatus.Controls.Add(this.FuelIndicator);
            this.tabVehicleStatus.Controls.Add(this.BatteryIndicator);
            this.tabVehicleStatus.Controls.Add(this.pictureBox1);
            this.tabVehicleStatus.Location = new System.Drawing.Point(4, 104);
            this.tabVehicleStatus.Name = "tabVehicleStatus";
            this.tabVehicleStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicleStatus.Size = new System.Drawing.Size(794, 341);
            this.tabVehicleStatus.TabIndex = 1;
            this.tabVehicleStatus.Text = "Vehicle Status";
            this.tabVehicleStatus.UseVisualStyleBackColor = true;
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.label1);
            this.tabSecurity.Controls.Add(this.button1);
            this.tabSecurity.Location = new System.Drawing.Point(4, 104);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Size = new System.Drawing.Size(794, 341);
            this.tabSecurity.TabIndex = 2;
            this.tabSecurity.Text = "Security";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.pictureBox2);
            this.tabUsers.Location = new System.Drawing.Point(4, 104);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(794, 341);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 104);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(794, 341);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // FuelIndicator
            // 
            this.FuelIndicator.Image = global::csci363_team_project.Properties.Resources.fuelIndicatorEmpty;
            this.FuelIndicator.Location = new System.Drawing.Point(149, 171);
            this.FuelIndicator.Name = "FuelIndicator";
            this.FuelIndicator.Size = new System.Drawing.Size(148, 81);
            this.FuelIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FuelIndicator.TabIndex = 4;
            this.FuelIndicator.TabStop = false;
            // 
            // BatteryIndicator
            // 
            this.BatteryIndicator.Image = global::csci363_team_project.Properties.Resources.battery0;
            this.BatteryIndicator.Location = new System.Drawing.Point(207, 17);
            this.BatteryIndicator.Name = "BatteryIndicator";
            this.BatteryIndicator.Size = new System.Drawing.Size(57, 86);
            this.BatteryIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BatteryIndicator.TabIndex = 3;
            this.BatteryIndicator.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csci363_team_project.Properties.Resources.car_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(184, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::csci363_team_project.Properties.Resources.person;
            this.pictureBox2.Location = new System.Drawing.Point(104, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // RemoteStartButton
            // 
            this.RemoteStartButton.Location = new System.Drawing.Point(591, 45);
            this.RemoteStartButton.Name = "RemoteStartButton";
            this.RemoteStartButton.Size = new System.Drawing.Size(106, 58);
            this.RemoteStartButton.TabIndex = 5;
            this.RemoteStartButton.Text = "Remote Start";
            this.RemoteStartButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 445);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Vehicle Manager Application";
            this.tabControl1.ResumeLayout(false);
            this.tabVehicleStatus.ResumeLayout(false);
            this.tabSecurity.ResumeLayout(false);
            this.tabSecurity.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FuelIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BatteryIndicator;
        private System.Windows.Forms.PictureBox FuelIndicator;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button RemoteStartButton;
    }
}

