using DbUp.Engine.Output;
using System;

namespace DbUp.Cli
{
    public class ConsoleLogger: IUpgradeLog
    {
        public void LogDebug(string format, params object[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            try
            {
                Console.WriteLine($"[DBG] {string.Format(format, args)}");
            }
            finally
            {
                Console.ResetColor();
            }
        }

        public void LogError(string format, params object[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            try
            {
                Console.WriteLine($"[ERR] {string.Format(format, args)}");
            }
            finally
            {
                Console.ResetColor();
            }
        }

        public void LogError(Exception ex, string format, params object[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            try
            {
                Console.WriteLine($"[ERR] {ex.GetType()} '{ex.Message}': {string.Format(format, args)}");
            }
            finally
            {
                Console.ResetColor();
            }
        }

        public void LogInformation(string format, params object[] args)
        {
            Console.WriteLine(string.Format(format, args));
        }

        public void LogTrace(string format, params object[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            try
            {
                Console.WriteLine($"[TRA] {string.Format(format, args)}");
            }
            finally
            {
                Console.ResetColor();
            }
        }

        public void LogWarning(string format, params object[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                Console.WriteLine($"[WRN] {string.Format(format, args)}");
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
}
