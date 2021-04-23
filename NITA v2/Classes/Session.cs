using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System;

namespace NITA_v2.Classes
{
    public static class Session
    {
        public static string logPath { get; } = $"{DateTime.Now.ToString().Replace('/', '-').Replace(':', '-')}.txt";
        public static List<string> logList { get; } = new List<string>();
        public static decimal CashierMoney { get; set; }
        public static bool IsCashierOpen { get; set; }
        public static User CurrentUser { get; set; }

        public static void Log(string message)
        {
            logList.Add($"[{DateTime.Now.Hour}:{DateTime.Now.Minute}] {CurrentUser.Username} > {message}\n");
            retry:
            try
            {
                using (var streamWriter = new StreamWriter(logPath))
                {
                    foreach (var line in logList)
                        streamWriter.Write(line);
                    streamWriter.Close();
                }
            }
            catch { Task.Delay(1000); goto retry; }
        }

        public static void ExportJson()//Criptografa isso mulher
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(Path.GetTempPath(), "NITA_Settings.txt")))
                sw.WriteLine($"{{\"host\":\"{DatabaseHook.DBHOST}\", \"name\":\"{DatabaseHook.DBNAME}\", \"username\":\"{DatabaseHook.DBUSER}\", \"password\":\"{DatabaseHook.DBPASS}\", \"darkesttone\":\"{ColorTranslator.ToHtml(Config.DarkestTone)}\", \"darktone\":\"{ColorTranslator.ToHtml(Config.DarkTone)}\", \"lighttone\":\"{ColorTranslator.ToHtml(Config.LightTone)}\", \"lightesttone\":\"{ColorTranslator.ToHtml(Config.LightestTone)}\"}}");
        }
    }
}
