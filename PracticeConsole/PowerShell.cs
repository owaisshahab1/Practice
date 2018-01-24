using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeConsole
{
    class PowerShell

    { 
        //public static void Main ()
        //{
        //    ProcessStartInfo startInfo = new ProcessStartInfo ();
        //    startInfo.FileName = @"powershell.exe";
        //    //provide powershell script full path
        //    startInfo.Arguments = @"& 'E:\powershell-scripts\call-from-c-sharp.ps1'";
        //    startInfo.RedirectStandardOutput = true;
        //    startInfo.RedirectStandardError = true;
        //    startInfo.UseShellExecute = false;
        //    startInfo.CreateNoWindow = true;
        //    Process process = new Process ();
        //    process.StartInfo = startInfo;
        //    // execute script call start process
        //    process.Start ();
        //    // get output information
        //    string output = process.StandardOutput.ReadToEnd ();

        //    // catch error information
        //    string errors = process.StandardError.ReadToEnd ();
        //}


        //static void Main ()
        //{
        //    //Process.Start (@"e:\program\NodesWithImages.exe");



        //}


        //static void Main ()
        //{
        //    LaunchCommandLineApp ();
        //}

        ///// <summary>
        ///// Launch the legacy application with some options set.
        ///// </summary>
        ////static void LaunchCommandLineApp ()
        ////{
        ////    // For the example
        ////    const string ex1 = @"e:\program\NodesWithImages.exe";
        ////    //const string ex2 = "C:\\Dir";

        ////    // Use ProcessStartInfo class
        ////    ProcessStartInfo startInfo = new ProcessStartInfo ();
        ////    startInfo.CreateNoWindow = true;
        ////    startInfo.UseShellExecute = true;
        ////    startInfo.FileName = "NodesWithImages.exe";
        ////    startInfo.WindowStyle = ProcessWindowStyle.Normal;
        ////    //startInfo.Arguments = "-f j -o \"" + ex1 + "\" -z 1.0 -s y " + ex2;

        ////    try
        ////    {
        ////        // Start the process with the info we specified.
        ////        // Call WaitForExit and then the using statement will close.
        ////        using (Process exeProcess = Process.Start (startInfo))
        ////        {
        ////            exeProcess.WaitForExit ();
        ////        }
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        // Log error.
        ////    }
        ////}


        static void Main789 (string[] args)
        {
            try
            {
                foreach (Process process in Process.GetProcessesByName ("NodesWithImages"))
                {
                    process.Kill ();
                }

                    ProcessStartInfo startInfo = new ProcessStartInfo ();
                    startInfo.FileName = "NodesWithImages.exe";
                    startInfo.WorkingDirectory = @"E:\program\";
                
                 Process.Start (startInfo);


          
                //Process.Start (startInfo);
                // if (process.StartInfo.FileName == "NodesWithImages.exe")

                // Process process = Process.Start (startInfo);
                
                

  

            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }

            //Process p2 = new Process ();
            //p.Start (@"E:\engine\stockfish.exe");
            //p.Start (mspaint.exe);
        }
    }
}
