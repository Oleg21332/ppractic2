using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ppractic2
{
    public class Log
    {
        public static void Logger(string text)
        {
            string path = "D:\\log.txt";
            File.AppendAllText(path, text + " " + DateTime.Now + "\n");

        }
    }

}
