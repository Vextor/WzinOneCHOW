// Name: WarZone Admin Kit Demo Uploader Module
// Date: Unknown
// Author: Vextor
// Function: To download the Demo Uploader tool and place it in a directory it created



// Haven't bothered to comment this code, do check Download2.cs for the comments

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
    public partial class Downloading : Form
    {
        public Downloading()
        {
            InitializeComponent();
}

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Unlike Download2.cs, this works 

            string InstanceOne = label1.Text;
            if (InstanceOne.Contains ("Downloading Demo Uploader.")){
                label1.Text = "Downloading Demo Uploader..";
            }
            if (InstanceOne.Contains("Downloading Demo Uploader.."))
            {
                label1.Text = "Downloading Demo Uploader...";
            }

            if (InstanceOne.Contains("Downloading Demo Uploader..."))
            {
                label1.Text = "Downloading Demo Uploader.";
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            timer1.Start();

            Directory.CreateDirectory(@"wzsoftware\");

            WebClient webClient = new WebClient();

      
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);



            webClient.DownloadFileAsync(new Uri("http://warzone-gaming.co.uk/downloads/DemoUploader2.exe"), @"wzsoftware\DemoUploader2.exe");
            
          

       

        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
          
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {

            MessageBox.Show("Download completed!");
            this.Close();

            
        }

   
        private void Downloading_Load(object sender, EventArgs e)
        {

        }
    }

}
