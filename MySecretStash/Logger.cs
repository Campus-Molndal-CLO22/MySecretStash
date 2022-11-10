namespace MySecretStash
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Logger
    {
        public static string DateFormat { get; set; }
        public static string FileName { get; set; } = "log {0}.log";

        public static void Log(string message)
        {
            string logMessage = string.Format("{0} - {1}", DateTime.Now.ToString(DateFormat), message);
            File.AppendAllText(string.Format(FileName, DateTime.Now.ToString("yyyy-MM-dd")), logMessage);
        }
    }
}
