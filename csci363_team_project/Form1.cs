﻿using System;
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
        public Form1()
        {
            Thread consoleThread = new Thread(ListenForConsoleCommands)
            {
                IsBackground = true
            };
            consoleThread.Start();

            InitializeComponent();
        }
        private void ListenForConsoleCommands()
        {
            while (running)
            {
                Console.WriteLine("Enter command: ");
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "test")
                {
                    label1.Invoke(new Action(() => label1.Text = input[1]));
                    //label1.Text = input[1];
                }
                else if(input[0] == "alarm")
                {
                    //alarm_trigger = true
                    ;
                }
                else if (input[0] == "fuel")
                {
                    //fuel_guage = input[1]
                    ;
                }
                else if (input[0] == "battery")
                {
                    //battery_gauge = input[1]
                    ;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
