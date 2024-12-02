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
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 452);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabLocate
            // 
            this.tabLocate.Location = new System.Drawing.Point(4, 104);
            this.tabLocate.Name = "tabLocate";
            this.tabLocate.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocate.Size = new System.Drawing.Size(796, 344);
            this.tabLocate.TabIndex = 0;
            this.tabLocate.Text = "Locate";
            this.tabLocate.UseVisualStyleBackColor = true;
            // 
            // tabVehicleStatus
            // 
            this.tabVehicleStatus.Location = new System.Drawing.Point(4, 104);
            this.tabVehicleStatus.Name = "tabVehicleStatus";
            this.tabVehicleStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicleStatus.Size = new System.Drawing.Size(796, 344);
            this.tabVehicleStatus.TabIndex = 1;
            this.tabVehicleStatus.Text = "Vehicle Status";
            this.tabVehicleStatus.UseVisualStyleBackColor = true;
            // 
            // tabSecurity
            // 
            this.tabSecurity.Location = new System.Drawing.Point(4, 104);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Size = new System.Drawing.Size(796, 344);
            this.tabSecurity.TabIndex = 2;
            this.tabSecurity.Text = "Security";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // tabUsers
            // 
            this.tabUsers.Location = new System.Drawing.Point(4, 104);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(796, 344);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 104);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(796, 344);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Vehicle Manager Application";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLocate;
        private System.Windows.Forms.TabPage tabVehicleStatus;
        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabSettings;
    }
}

