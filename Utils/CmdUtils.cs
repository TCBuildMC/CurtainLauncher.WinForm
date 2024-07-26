using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurtainLauncher.WinForm.Utils
{
    public class CmdUtils
    {
        public static string RunCommand(string command)
        {
            using (Process process = new Process())
            {
                command = command.Trim().TrimEnd('&') + "&exit";
                process.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\cmd.exe"; ;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.StandardInput.WriteLine(command);
                process.StandardInput.AutoFlush = true;
                string output = process.StandardOutput.ReadToEnd();//读取结果
                process.WaitForExit();
                process.Close();

                return output;
            }
        }
    }
}
