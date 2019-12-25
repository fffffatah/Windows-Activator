using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Windows_Activator
{
    public class ActivationStuff
    {
        public ActivationStuff()
        {

           /* var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                //Console.WriteLine("output>>" + e.Data);
                //MessageBox.Show(e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                //Console.WriteLine("error>>" + e.Data);
               // MessageBox.Show(e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            //Console.WriteLine("ExitCode: {0}", process.ExitCode);
            //MessageBox.Show(process.ExitCode.ToString());
            process.Close(); */
        }
        public string ActivateMe(string command)
        {

            if (command.Equals("windows"))
            {
                if (!new OSinfo().GetKey().Equals("notcompatible"))
                {
                    var processInfo = new ProcessStartInfo("cmd.exe", "/c " + "slmgr /ipk "+ new OSinfo().GetKey());
                    processInfo.CreateNoWindow = true;
                    processInfo.UseShellExecute = false;
                    processInfo.RedirectStandardError = true;
                    processInfo.RedirectStandardOutput = true;
                    var process = Process.Start(processInfo);
                    process.WaitForExit();
                    int code = process.ExitCode;
                    process.Close();
                    


                    if (code == 0)
                    {
                        int codeSecond = 0;
                        for (int i=0; i<3; i++)
                        {
                            var processInfoSecond = new ProcessStartInfo("cmd.exe", "/c " + "slmgr /skms kms"+7+i+".msguides.com");
                            processInfoSecond.CreateNoWindow = true;
                            processInfoSecond.UseShellExecute = false;
                            processInfoSecond.RedirectStandardError = true;
                            processInfoSecond.RedirectStandardOutput = true;
                            var processSecond = Process.Start(processInfo);
                            processSecond.WaitForExit();
                            codeSecond = processSecond.ExitCode;
                            processSecond.Close();
                            if (codeSecond == 1)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (codeSecond == 0)
                        {
                            var processInfoThird = new ProcessStartInfo("cmd.exe", "/c " + "slmgr /ato");
                            processInfoThird.CreateNoWindow = true;
                            processInfoThird.UseShellExecute = false;
                            processInfoThird.RedirectStandardError = true;
                            processInfoThird.RedirectStandardOutput = true;
                            var processThird = Process.Start(processInfo);
                            processThird.WaitForExit();
                            processThird.Close();
                            if (processThird.ExitCode == 1)
                            {
                                return "failedAtAct";
                            }
                        }
                        else
                        {
                            return "failedAtCon";
                        }
                    }
                    else
                    {
                        return "failedAtInstallKey";
                    }
                }
                else
                {
                    return "notCompatible";
                }
                
            }
            else if(command.Equals("office"))
            {
                return ""; //TO-DO OFFICE PART
            }
            return "success";
        }
    }
}
