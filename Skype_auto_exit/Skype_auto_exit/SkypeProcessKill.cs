using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skype_auto_exit
{
    internal class SkypeProcessKill
    {

        public void RunApp()
        {
            Console.WriteLine("Hello, Skype Auto Exit Program!");
            while (true)
            {
                SkypeProcessKill.KillSkypeProcess();
                Thread.Sleep(5000);
            }
        }


        /*
        * skype process 를 kill 하는 명령어를 수행하는 Method
        */
        private static void KillSkypeProcess()
        {
            string cmd = @"taskkill /f /im lync.exe";

            ProcessStartInfo pri = new ProcessStartInfo();
            Process pro = new Process();
            pri.FileName = "cmd.exe";
            pri.WorkingDirectory= @"C:\";
            pri.CreateNoWindow = false;
            pri.UseShellExecute = false;
            pri.RedirectStandardInput = true;
            pri.RedirectStandardOutput = true;
            pri.RedirectStandardError = true;
           
            pro.StartInfo = pri;
            pro.Start();

            pro.StandardInput.Write(cmd+Environment.NewLine);
            pro.StandardInput.Close();
            pro.Close();
        }

    }
}
