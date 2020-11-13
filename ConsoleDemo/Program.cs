using System;
using System.IO;
using System.Reflection;

using log4net;
using log4net.Config;

namespace ConsoleDemo
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            Console.WriteLine("Hello World!");
            
            // Log some things
            log.Info("Hello logging world!");
            log.Error("Error!");
            log.Warn("Warn!");

            Console.ReadLine();
        }
    }
}
/*
https://www.michalbialecki.com/2018/12/21/adding-a-log4net-provider-in-net-core-console-app/
https://www.michalbialecki.com/2018/12/21/adding-a-log4net-provider-in-net-core-console-app/
https://jakubwajs.wordpress.com/2019/11/28/logging-with-log4net-in-net-core-3-0-console-app/*/