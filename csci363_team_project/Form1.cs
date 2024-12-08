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
    public partial class Form1 : Form
    {
        private bool running = true;
        private bool isAlarmArmed = false; // Track the alarm state
        private bool isLocked = false; // Track lock/unlock state
        public Form1()
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
                    alarmStatusLabel.Invoke(new Action(() => alarmStatusLabel.Text = input[1]));
                    //label1.Text = input[1];
                }
                else if(input[0] == "alarm")
                {
                    //alarm_trigger = true
                    ;
                }
                else if (input[0] == "fuel")
                {
                    UpdateFuelIndicator(int.Parse(input[1]));
                }
                else if (input[0] == "battery")
                {
                    UpdateBatteryIndicator(int.Parse(input[1]));
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
            // Set default state to disarmed
            isAlarmArmed = false; // Alarm starts disarmed
            
            
            armAlarmButton.BackColor = Color.LightGreen; // Green indicates safe/disarmed state

           
        }

        private void lockUnlockButton_Click(object sender, EventArgs e)
        {
            isLocked = !isLocked;

            if (isLocked)
            {
                lockUnlockButton.Image = Properties.Resources.locksmall;
                lockUnlockButton.Text = "Locked"; // Optional: Update text
            }
            else
            {
                lockUnlockButton.Image = Properties.Resources.unlocksmall; // Set to unlocked image
                lockUnlockButton.Text = "Unlocked"; // Optional: Update text
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
