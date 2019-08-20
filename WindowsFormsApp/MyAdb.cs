using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
   public class MyAdb
    {
        private String adbLocation;
        public MyAdb(String adb_location) {
            adbLocation = adb_location;
        }
        public String startAdb() {
            ProcessStartInfo psi = new ProcessStartInfo("cmd");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            psi.RedirectStandardInput = true;

            var proc = Process.Start(psi);
            proc.StandardInput.WriteLine(@"cd C://Files//AndroidSDK//Sdk");
            proc.StandardInput.WriteLine(@"adb tcpip 5555");
            proc.StandardInput.WriteLine("exit");

            return proc.StandardOutput.ReadToEnd();
            
        }
        public String connectToDevice(String ip) {
            ProcessStartInfo psi = new ProcessStartInfo("cmd");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            psi.RedirectStandardInput = true;

            var proc = Process.Start(psi);
            proc.StandardInput.WriteLine(@"cd C://Files//AndroidSDK//Sdk");
            proc.StandardInput.WriteLine(@"adb connect "+ip+":5555");
            proc.StandardInput.WriteLine("exit");

            return proc.StandardOutput.ReadToEnd();
        }

    }
}
