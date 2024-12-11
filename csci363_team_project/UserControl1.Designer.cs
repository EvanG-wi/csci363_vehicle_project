namespace csci363_team_project
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mileageTracker = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mileageTracker
            // 
            this.mileageTracker.AutoSize = true;
            this.mileageTracker.Location = new System.Drawing.Point(157, 60);
            this.mileageTracker.Name = "mileageTracker";
            this.mileageTracker.Size = new System.Drawing.Size(73, 13);
            this.mileageTracker.TabIndex = 5;
            this.mileageTracker.Text = "125,000 Miles";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(156, 22);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(152, 25);
            this.userName.TabIndex = 4;
            this.userName.Text = "HumanName#1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::csci363_team_project.Properties.Resources.person;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mileageTracker);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(313, 155);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mileageTracker;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
