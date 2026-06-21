using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using System.IO;

namespace NDATapp.Models
{
    public class Logger : ILogger
    {
        private static Logger? _instance;
        private static readonly object _lock = new object();
        private readonly string _logDosyaYolu = "sistem_loglari.txt";

        private Logger() { }

        // Singleton örneği alma metodu
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }

        public Action<string>? LogEklendi;

        // Loglama metodu
        public void Logla(string mesaj)
        {
            string logSatiri = $"{DateTime.Now:HH:mm:ss}: {mesaj}";
            File.AppendAllText(_logDosyaYolu, logSatiri + Environment.NewLine);


            LogEklendi?.Invoke(logSatiri);
        }
    }
}
