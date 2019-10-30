using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace NUnitTestProject.AutomationLibrary.Loggers
{
    public class Logger
    {
        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public Logger()
        {
            var log4netConfig = new XmlDocument();
            log4netConfig.Load(File.OpenRead("log4net.config"));
            var repo = log4net.LogManager.CreateRepository(Assembly.GetEntryAssembly(),
                typeof(log4net.Repository.Hierarchy.Hierarchy));
            log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);
        }

        public void LogInfo(string message)
        {
            Log.Info(message);
        }

        public void LogFail(string message, Exception exception)
        {
            Log.Error(message, exception);
        }
    }
}
