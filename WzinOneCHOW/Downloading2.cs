// Name: WarZone Admin Kit RCON Downloader Module
// Date: Unknown
// Author: Vextor
// Function: To download the RCON tool and place it in a directory it created


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace WzinOneCHOW
{
    public partial class Downloading2 : Form
    {
        public Downloading2()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            // Timer code
            // Basicially, at each tick (starts below), it does a nice text animation.
            
            // string instance one contains label1.text
            string InstanceOne = label1.Text;

            // if statements changing the text
            if (InstanceOne.Contains("Downloading WarZone Admin Tools."))
            {
                label1.Text = "Downloading WarZone Admin Tools..";
            }
            if (InstanceOne.Contains("Downloading WarZone Admin Tools.."))
            {
                label1.Text = "Downloading WarZone Admin Tools...";
            }

            if (InstanceOne.Contains("Downloading WarZone Admin Tools..."))
            {
                label1.Text = "Downloading WarZone Admin Tools.";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button click code 

            // Hides the button to show the label
            button1.Hide();
            // Starts timer to do text animation
            timer1.Start();
            // Creates directory
            Directory.CreateDirectory(@"wzsoftware\");
            // Creates an instance of the 'WebClient' in System.Net
            WebClient webClient = new WebClient();

            // Creates Async stuff and class linkers - Async doesn't disturb anything else
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);


            // Starts an Async download
            webClient.DownloadFileAsync(new Uri("http://warzone-gaming.co.uk/downloads/wz_rcon_v2.1.exe"), @"wzsoftware\wz_rcon_v2.1.exe");





        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // ProgressBar of Download
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // Box informing DL has completed.
            MessageBox.Show("Download completed!");
            // Closes form
            this.Close();


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Downloading2_Load(object sender, EventArgs e)
        {

        }
    }
}
