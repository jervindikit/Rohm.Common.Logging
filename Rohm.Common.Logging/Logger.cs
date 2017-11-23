using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace Rohm.Common.Logging
{
    public class Logger
    {
        public static Logger SqlLogger { get; private set; }
        public static Logger OperationLogger { get; private set; }
        public static Logger ConnectionLogger { get; private set; }
        public static Logger DisplayLogger { get; private set; }
        public string FileName { get; private set; }
        public string DirectoryName { get; private set; }
        static Logger ()
        {
            SqlLogger = new Logger("SQL_Ver1.0_{0}.txt");
            OperationLogger = new Logger("Operation_Ver1.0_{0}.txt");
            ConnectionLogger = new Logger("Connection_Ver1.0_{0}.txt");
            DisplayLogger = new Logger("Display_Ver1.0_{0}.txt");
        }
        private Logger (string fileName)
        {
            string val = ConfigurationManager.AppSettings["LoggerDirectory"];
            if(val==null)
            {
                throw new Exception("Directory for log is not set; Key:LogDirectory");
            }
            this.DirectoryName = val;
            this.FileName = fileName;
        }
        public void Write(int ErrorCode, string FunctionName, string TypeStatus, string From, string To, string ProcessTime, string FunctionNumber, string Text1, string Text2)
        {
            string fullPath = Path.Combine(this.DirectoryName, FileName);
            fullPath = MakeUniqueFileName(fullPath);
            lock (this)
            {
                using (StreamWriter writer = new StreamWriter(fullPath, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyyMMdd_HHmmss") + "|" + ErrorCode + "|" + FunctionName + "|" + TypeStatus + "|" + From + "|" + To + "|" + ProcessTime + "|" + FunctionNumber + "|" + Text1 + "|" + Text2);
                }
            }
        }
        public static string MakeUniqueFileName(string file)
        {
            //string dir = Path.GetDirectoryName(file);
            string fn;
            for (int i = 0; ; ++i)
            {
                fn = string.Format(file, i);
                if (!File.Exists(fn))
                {
                    File.Create(fn).Dispose();
                    return fn;
                }
                else if (File.Exists(fn))
                {
                    string LogFileSize;
                    LogFileSize = Convert.ToString(ConfigurationManager.AppSettings["LogFileSize"]);
                    if (LogFileSize == null)
                    {
                        throw new Exception("Log file size not define; Key:LogFileSize");
                    }
                    Int64 fileSizeInBytes = new FileInfo(fn).Length;
                    if (fileSizeInBytes < Convert.ToUInt32(LogFileSize))
                    {
                        return fn;
                    }
                }
            }
        }
    }
}
