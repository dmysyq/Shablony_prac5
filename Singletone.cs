using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac5
{
class Logger
    {
        private static Logger _instance;
        private Logger() { }
        public static Logger GetInstance()
        {
            if (_instance == null)
                _instance = new Logger();
            return _instance;
        }
        public void Log(string message, string level)
        {
            Console.WriteLine(message);
            Console.WriteLine(level);
        }
    }

    class L
    {
        static void Main(string[] args)
        {
            Logger.GetInstance().Log("message", "ERROR");
        }
    }
}
