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
    public partial class CompleteDownloader : Form
    {
        public CompleteDownloader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hides the button so the label can show
            button1.Hide();
     
            // Creates the directory wzsoftware
            Directory.CreateDirectory(@"wzsoftware\");
            // create new instance of webclient from systen.net
            WebClient webClient = new WebClient();
            // changes label1.text to 
            label1.Text = "Downloading Demo Uploader...";

            // async download stuff
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);


            // new async dl

            webClient.DownloadFileAsync(new Uri("http://warzone-gaming.co.uk/downloads/DemoUploader2.exe"), @"wzsoftware\DemoUploader2.exe");

        }
        
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // progress bar code
            progressBar1.Value = e.ProgressPercentage;

        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {

           // now, when the first dl completes, this starts the second one
            WebClient webClient = new WebClient();

            label1.Text = "Downloading RCON Tool...";

            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed2);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("http://warzone-gaming.co.uk/downloads/wz_rcon_v2.1.exe"), @"wzsoftware\wz_rcon_v2.1.exe");


        }
        
        private void Completed2(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Downloads completed!");
            this.Close();

        }

        private void CompleteDownloader_Load(object sender, EventArgs e)
        {

        }
    }
}
