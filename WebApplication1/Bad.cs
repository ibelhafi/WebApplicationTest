using System;

namespace WebApplication1
{
    public class Bad
    {
        void DoPrint(object o)
        {
            Console.WriteLine(o.ToString());
        }
        public void M()
        {
            DoPrint("Hello");
            DoPrint(null);
            Logger.Log("Hello, World!");
        }

        static class Logger
        {
            [Obsolete("Use Log(LogLevel level, string s) instead")]
            public static void Log(string s)
            {
                // ...
            }

            public static void Log(LogLevel level, string s)
            {
                // ...
            }
        }

        enum LogLevel
        {
            Info,
            Warning,
            Error
        }
    }
}
