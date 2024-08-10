using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Models
{
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
          Console.WriteLine("Database Logger: " + message);
        }
    }
}
