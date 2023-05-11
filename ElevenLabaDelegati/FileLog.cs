using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ElevenLabaDelegati
{
    class FileLog
    {
        public void LogToFile(object sender, DirectionEventArgs e)
        {
            if (e.Direction == "назад")
            {
                Console.WriteLine("Робот движется назад ");
                string path = "log.txt";
                string message = $"Робот выбрал направление назад в {DateTime.Now}.";
                File.AppendAllText(path, message + Environment.NewLine);
            }
        }
    }
}
