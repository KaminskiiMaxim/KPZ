using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_KPZ
{
    public class FileLoggerAdapter : ILogger
    {
        private readonly FileWriter fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }

        public void Log(string message)
        {
            fileWriter.WriteLine("[INFO] " + message);
        }

        public void Error(string message)
        {
            fileWriter.WriteLine("[ERROR] " + message);
        }

        public void Warn(string message)
        {
            fileWriter.WriteLine("[WARN] " + message);
        }
    }
}
