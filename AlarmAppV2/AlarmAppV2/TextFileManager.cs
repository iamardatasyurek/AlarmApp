using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AlarmAppV2
{
    class TextFileManager
    {
        StreamWriter sW;
        string[] lines;
        string path;
        string filePath;

        public TextFileManager()
        {
            filePath = AppContext.BaseDirectory;
            filePath += @"Resources";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            path = (filePath + @"\AlarmAppDataFile.txt");
            if (!File.Exists(path))
            {
                sW = File.CreateText(path);
                sW.Close();
            }
            else
            {                
                lines = File.ReadAllLines(path);
            }
        }

        public void AddAnAlarmToFile(AlarmTime alarmTime)
        {
            try
            {
                if (!File.Exists(path))
                {
                    sW = File.CreateText(path);
                    sW.Close();
                }
                sW = File.AppendText(path);            
                sW.WriteLine(alarmTime.alarmTime + "*" + alarmTime.audioPath + "*" + alarmTime.alarmDateTime + "*" +
                             alarmTime.alarmDateTimeShort + "*" + alarmTime.Active);            
            }

            catch (Exception e)
            {
              Console.WriteLine(e.Message);
            }

            finally
            {
                sW.Close();
            }
        }

        public void DeleteAllAlarmOnTxt()
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }            
        }
        public string[] GetAllLines()
        {
            return lines;
        }
    }
}
