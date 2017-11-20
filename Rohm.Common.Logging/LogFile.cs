using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Rohm.Common.Logging
{
    public class LogFile
    {
        private int c_ErrorCode;
        public int ErrorCode
        {
            get { return c_ErrorCode; }
            set
            {
                c_ErrorCode = value;
            }
        }
        private string c_FunctionName;
        public string FunctionName
        {
            get { return c_FunctionName; }
            set
            {
                c_FunctionName = value;
            }
        }
        private string c_TypeStatus;
        public string TypeStatus
        {
            get { return c_TypeStatus; }
            set
            {
                c_TypeStatus = value;
            }
        }
        private string c_From;
        public string From
        {
            get { return c_From; }
            set
            {
                c_From = value;
            }
        }
        private string c_To;
        public string To
        {
            get { return c_To; }
            set
            {
                c_To = value;
            }
        }
        private string c_Processtime;
        public string Processtime
        {
            get { return c_Processtime; }
            set
            {
                c_Processtime = value;
            }
        }
        private string c_FunctionNumber;
        public string FunctionNumber
        {
            get { return c_FunctionNumber; }
            set
            {
                c_FunctionNumber = value;
            }
        }
        private string c_Text1;
        public string Text1
        {
            get { return c_Text1; }
            set
            {
                c_Text1 = value;
            }
        }
        private string c_Text2;
        public string Text2
        {
            get { return c_Text2; }
            set
            {
                c_Text2 = value;
            }
        }
        private String c_MachineNumber;
        public String MachineNumber
        {
            get { return c_MachineNumber; }
            set
            {
                c_MachineNumber = value;
            }
        }
        private String c_LogFilePath;
        public String LogFilePath
        {
            get { return c_LogFilePath; }
            set
            {
                c_LogFilePath = value;
            }
        }
        private String c_LogFileName;
        public String LogFileName
        {
            get { return c_LogFileName; }
            set
            {
                c_LogFileName = value;
            }
        }
        public void OperationLogging(int ErrorCode, string FunctionName, string TypeStatus, string From, string To, string ProcessTime, string FunctionNumber, string Text1, string Text2, string MachineNumber, string LogFilePath, string LogFileName)
        {
            //ASSIGN FILE PATH MACHINE NUMBER AND FILE NAME
            LogFileName = LogFileName + "_Ver1.0_";
            LogFilePath = LogFilePath + "\\" + MachineNumber + "\\";
            string FullPath;
            if (!Directory.Exists(LogFilePath))
            {
                Directory.CreateDirectory(LogFilePath);
            }
            //ASSIGN AUTO INCREMENT FILE NAME
            FileInfo fi = new FileInfo(LogFilePath + "\\" + LogFileName);
            FullPath = LogFilePath + LogFileName + "{0}.txt";
            FullPath = MakeUniqueFileName(FullPath);
            using (StreamWriter w = File.AppendText(FullPath))
            {
                w.WriteLine(DateTime.Now.ToString("yyyyMMdd_HHmmss") + "|" + ErrorCode + "|" + FunctionName + "|" + TypeStatus + "|" + From + "|" + To + "|" + ProcessTime + "|" + FunctionNumber + "|" + Text1 + "|" + Text2);
                w.Close();
            }
        }
        public static string MakeUniqueFileName(string file)
        {
            string dir = Path.GetDirectoryName(file);
            string fn;
            for (int i = 0; ; ++i)
            {
                fn = Path.Combine(dir, string.Format(file, i));
                if (!File.Exists(fn))
                {
                    File.Create(fn).Dispose();
                    return fn;
                }
                else if (File.Exists(fn))
                {
                    Int64 fileSizeInBytes = new FileInfo(fn).Length;
                    if (fileSizeInBytes < 2000)
                    {
                        return fn;
                    }
                }
            }
        }
    }
}
