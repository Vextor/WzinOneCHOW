// Name: WarZone Admin Kit Main Module
// Created: Date Unknown
// Author: Vextor
// Function(s): Loads various forms, and launches applications 




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace WzinOneCHOW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

        }

  
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

     

        private void downloadToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adomToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rCONToolToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            // Makes a new instance of the form
            Downloading2 myNewForm = new Downloading2();

            // Loads the form
            myNewForm.Show();
        }

        private void demoUploaderToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            // Same function as above
            Downloading myNewForm = new Downloading();

            myNewForm.Show();

        }

        private void legacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Same function as above
            MW2LegacyBanList myNewForm = new MW2LegacyBanList();

            myNewForm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Same function as above
            MW2ModernBanList myNewForm = new MW2ModernBanList();

            myNewForm.Show();
        }

        private void callOfDuty4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Same function as above
            COD4BanList myNewForm = new COD4BanList();

            myNewForm.Show();
        }

        private void demoUploaderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Try Catch code - basicially 'tries' to start the DemoUploader in the directory it should be in
           
            try
            {
                Process.Start(@"wzsoftware\DemoUploader2.exe");
            }

            // If it isn't there, it usually throws an exception
            // Here, we catch the exception, and instead of crashing the application, we make it display a nice error message
            catch
            {
                MessageBox.Show("The WarZone Admin Kit has detected you do not have the Demo Uploader installed. Starting download...");
                Downloading myNewForm = new Downloading();

                myNewForm.Show();

            }


        }

        private void rCONToolToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Same function as above
            try
            {
                Process.Start(@"wzsoftware\wz_rcon_v2.1.exe");
            }
            catch
            {
                MessageBox.Show("The WarZone Admin Kit has detected you do not have the RCON Tool installed. Starting download...");
                
                Downloading2 RCONDownloader = new Downloading2();

                RCONDownloader.Show();
            }
        }

        private void remoteDesktopApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try Catch - Basicially opens up Remote Desktop (mstsc.exe)
            try
            {
                Process.Start("mstsc.exe");
            }
                // However, older OS'es (XP and below) lack Remote Desktop (mstsc.exe)
                // Since the file isn't there, it would usually crash
                // Here, we catch the crash (exception), and make it display a nice error message
            catch
            {
                MessageBox.Show("You have an outdated operating system. As a result, Remote Desktop cannot launch.");
            }
            
        }

        private void remoteDesktopAccessThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Simply navigates the web browser to the RCON thread 
            webBrowser1.Navigate("http://warzone-gaming.co.uk/forums/index.php?/topic/4715-rcon-firewall-access-v20/");
            MessageBox.Show("The Forum Tab has navigated to the thread...");
        }

        private void everythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CompleteDownloader DownloadForm = new CompleteDownloader();

            DownloadForm.Show();

        }

        private void splashToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
    }
}
