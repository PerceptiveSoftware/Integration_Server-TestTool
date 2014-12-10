using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IS_Test
{
    static class Logger
    {
        private static string extension = ".txt";
        private static string date = string.Empty;
        private static string fileLocation = string.Empty;
        private static string directory = "log";
        private static readonly StringBuilder failedText = new StringBuilder();

        public static int LOG_LEVEL = 6;

        public static void Write(int level, string text)
        {
            try
            {
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                DateTime current = DateTime.Now;

                if (current.ToShortDateString() != date)
                {
                    date = current.ToShortDateString();
                    date = date.Replace("/", "-");
                }

                fileLocation = string.Format("{0}/{1}{2}", directory, date, extension);
            }
            catch (Exception)
            {
                failedText.Append(Environment.NewLine);
                failedText.AppendLine(text);
                return;
            }

            if (level < LOG_LEVEL)
                return;

            try
            {
                if (failedText.ToString() != "")
                {
                    System.IO.File.AppendAllText(fileLocation, failedText.ToString());
                    failedText.Clear();
                }

                text += Environment.NewLine;
                System.IO.File.AppendAllText(fileLocation, text);
            }
            catch (Exception)
            {
                //TODO: Failed to write to log, store until the next entry is written
                failedText.Append(Environment.NewLine);
                failedText.AppendLine(text);
            }
        }
    }
}
