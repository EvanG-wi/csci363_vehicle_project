using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace csci363_team_project
{
    public partial class vehicleControlApp : Form
    {
        private bool running = true;
        private bool isAlarmArmed = false; // Track the alarm state
        private bool isLocked = false; // Track lock/unlock state
        private bool areDoorsAjar = false;
        private bool vehicleOn = false;
        private bool isTrunkOpen = false; // Track trunk state
        public vehicleControlApp()
        {

            InitializeComponent(); // Always call this first
            this.Load += Form1_Load; // Attach the Form Load event

            // Start the console command thread
            Thread consoleThread = new Thread(ListenForConsoleCommands)
            {
                IsBackground = true
            };
            consoleThread.Start();
        }
        private void ListenForConsoleCommands()
        {
            while (running)
            {
                Console.WriteLine("Enter command: ");
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "test")
                {
                    //alarmStatusLabel.Invoke(new Action(() => alarmStatusLabel.Text = input[1]));
                    //label1.Text = input[1];
                }
                else if(input[0] == "alarm")
                {
                    //alarm_trigger = true
                    ;
                }
                else if (input[0] == "temp")
                {
                    UpdateTempIndicator(input[1]);
                    
                }
                else if (input[0] == "fuel")
                {
                    UpdateFuelIndicator(int.Parse(input[1]));
                }
                else if (input[0] == "battery")
                {
                    UpdateBatteryIndicator(int.Parse(input[1]));
                }
                else if (input[0] == "drive")
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        int currentMileage = int.Parse(userMileage1.Text.Replace(",", "").Replace(" Miles", ""));
                        userMileage1.Text = (currentMileage + int.Parse(input[1])).ToString() + " Miles";
                    });
                    
                }

            }
        }

        private void UpdateBatteryIndicator(int percentCharged)
        {
            switch (percentCharged)
            {
                case int n when n == 0:
                    BatteryIndicator.Image = Image.FromFile("battery0.jpg");
                    break;
                case int n when n < 20:
                    BatteryIndicator.Image = Image.FromFile("battery1.jpg");
                    break;
                case int n when n < 40:
                    BatteryIndicator.Image = Image.FromFile("battery2.jpg");
                    break;
                case int n when n < 60:
                    BatteryIndicator.Image = Image.FromFile("battery3.jpg");
                    break;
                case int n when n < 80:
                    BatteryIndicator.Image = Image.FromFile("battery4.jpg");
                    break;
                default:
                    BatteryIndicator.Image = Image.FromFile("battery5.jpg");
                    break;
            }
        }
        private void UpdateTempIndicator(String temperature)
        {
            
            int temp = int.Parse(temperature);
            switch (temp)
            {
                case int n when n < 40:
                    InternalTempIndicator.ForeColor = Color.Blue;
                    break;
                case int n when n < 60:
                    InternalTempIndicator.ForeColor = Color.Green;
                    break;
                case int n when n < 80:
                    InternalTempIndicator.ForeColor = Color.Coral;
                    break;
                default:
                    InternalTempIndicator.ForeColor = Color.Red;
                    break;
            }

            bool isCelsius=true;
            tempUnitSelection.Invoke(new Action(() => { isCelsius = tempUnitSelection.SelectedIndex == 1; }));
            if (isCelsius) //if celsius
            {
                temp = (temp - 32) / 2;
            }
            InternalTempIndicator.Invoke(new Action(() => { InternalTempIndicator.Text = temp.ToString() + "°"; }));

        }
        private void UpdateFuelIndicator(int percentFull)
        {
            switch (percentFull)
            {
                case int n when n <10:
                    FuelIndicator.Image = Image.FromFile("fuelIndicatorEmpty.jpg");
                    break;
                case int n when n > 90:
                    FuelIndicator.Image = Image.FromFile("fuelIndicatorFull.jpg");
                    break;
                default:
                    FuelIndicator.Image = Image.FromFile("fuelIndicatorHalf.jpg");
                    break;
            }
        }

        private void armAlarmButton_Click(object sender, EventArgs e)
        {
            // Toggle the alarm state
            isAlarmArmed = !isAlarmArmed;

            // Update the UI based on the new state
            if (isAlarmArmed)
            {
                armAlarmButton.Text = "Disarm Alarm"; // Update button text
                
                armAlarmButton.BackColor = Color.LightCoral; // Red for armed
            }
            else
            {
                armAlarmButton.Text = "Sound Alarm"; // Update button text
                
                armAlarmButton.BackColor = Color.LightGreen; // Green for disarmed
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            isLocked = false; // Default state: Unlocked
            lockUnlockButton.Image = Properties.Resources.unlocksmall;
            lockUnlockButton.Text = "Unlocked";
            lockUnlockButton.BackColor = Color.LightGreen; // Green for unlocked
            lockUnlockButton.ForeColor = Color.Black;

            // Set default state to disarmed
            isAlarmArmed = false; 
            armAlarmButton.BackColor = Color.LightGreen;

            doorStatusPictureBox.Image = Properties.Resources.doorsAjar;
            doorStatusPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            doorStatusPictureBox.BackColor = Color.Green;

            isTrunkOpen = false; // Default state: Trunk closed
            openTrunkButton.Text = "Open Trunk";
            openTrunkButton.BackColor = Color.LightGreen; // Green for closed trunk
            openTrunkButton.ForeColor = Color.Black;

        }

        private void lockUnlockButton_Click(object sender, EventArgs e)
        {
            isLocked = !isLocked; // Toggle lock state

            if (isLocked)
            {
                // Locked state
                lockUnlockButton.Image = Properties.Resources.locksmall;
                lockUnlockButton.Text = "Locked";
                lockUnlockButton.BackColor = Color.LightCoral; // Red for locked
                lockUnlockButton.ForeColor = Color.White; // Contrast text color
            }
            else
            {
                // Unlocked state
                lockUnlockButton.Image = Properties.Resources.unlocksmall;
                lockUnlockButton.Text = "Unlocked";
                lockUnlockButton.BackColor = Color.LightGreen; // Green for unlocked
                lockUnlockButton.ForeColor = Color.Black; // Default text color
            }

            // Refresh to ensure UI updates immediately
            lockUnlockButton.Refresh();
        }


        private void UpdateDoorStatus()
        {
            if (areDoorsAjar = !areDoorsAjar)
            {
                // Set "Doors Ajar" state
                doorStatusPictureBox.BackColor = Color.Red;
                doorStatusLabel.Text = "Doors: Ajar";
                doorStatusLabel.ForeColor = Color.Red;
            }
            else
            {
                // Set "Doors Closed" state
                doorStatusPictureBox.BackColor = Color.Green;
                doorStatusLabel.Text = "Doors: Closed";
                doorStatusLabel.ForeColor = Color.Green;
            }
        }

        private void RemoteStartButton_Click(object sender, EventArgs e)
        {
            vehicleOn = !vehicleOn;
            if (vehicleOn) 
            {
                vehicleOnOffStatus.Image = Image.FromFile("vehicleOn.jpg");
            }
            else
            {
                vehicleOnOffStatus.Image = Image.FromFile("vehicleOff.jpg");
            }
        }

        private void user2Button_Click(object sender, EventArgs e)
        {
            String nameHold = userName1.Text;
            String mileageHold = userMileage1.Text;
            userName1.Text = userName2.Text;
            userMileage1.Text = userMileage2.Text;
            userName2.Text = nameHold;
            userMileage2.Text = mileageHold;

        }

        private void User3Button_Click(object sender, EventArgs e)
        {
            String nameHold = userName1.Text;
            String mileageHold = userMileage1.Text;
            userName1.Text = userName3.Text;
            userMileage1.Text = userMileage3.Text;
            userName3.Text = nameHold;
            userMileage3.Text = mileageHold;
        }

        private void doorStatusPictureBox_Click(object sender, EventArgs e)
        {
            // Toggle the door state
            areDoorsAjar = !areDoorsAjar;

            if (areDoorsAjar)
            {
                // Update to "Doors Ajar" state
                doorStatusPictureBox.BackColor = Color.Red; // Background color
                doorStatusLabel.Text = "Doors: Ajar"; // Label text
                doorStatusLabel.ForeColor = Color.Red; // Label text color
            }
            else
            {
                // Update to "Doors Closed" state
                doorStatusPictureBox.BackColor = Color.Green; // Background color
                doorStatusLabel.Text = "Doors: Closed"; // Label text
                doorStatusLabel.ForeColor = Color.Green; // Label text color
            }
        }

        private void openTrunkButton_Click(object sender, EventArgs e)
        {
            isTrunkOpen = !isTrunkOpen; // Toggle trunk state

            if (isTrunkOpen)
            {
                openTrunkButton.Text = "Close Trunk"; // Update button text
                openTrunkButton.BackColor = Color.LightCoral; // Optional: Color for open state
                
            }
            else
            {
                openTrunkButton.Text = "Open Trunk"; // Update button text
                openTrunkButton.BackColor = Color.LightGreen; // Optional: Color for closed state

            }
        }
    }
}
