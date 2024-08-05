using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        // This could be not thread safe, use Lazy<T> can make sure thread safe
        // private static Logger? _instance;

        // Lazy<T>
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
                //if (_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;
            }
        }

        public Logger()
        {
            
        }

        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
