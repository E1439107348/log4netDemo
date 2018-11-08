using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web; 
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace WebApplication8
{
    public class LogHelper
    {
        public static readonly ILog Log = LogManager.GetLogger("RollingLogFileAppender");
 

        //        log4j定义了8个级别的log（除去OFF和ALL，可以说分为6个级别），优先级从高到低依次为：OFF、FATAL、ERROR、WARN、INFO、DEBUG、TRACE、 ALL。 
        //ALL 最低等级的，用于打开所有日志记录。
        //DEBUG 指出细粒度信息事件对调试应用程序是非常有帮助的，主要用于开发过程中打印一些运行信息。 
        //INFO 消息在粗粒度级别上突出强调应用程序的运行过程。打印一些你感兴趣的或者重要的信息，这个可以用于生产环境中输出程序运行的一些重要信息，
        //WARN 表明会出现潜在错误的情形，有些信息不是错误信息，但是也要给程序员的一些提示。
        //ERROR 指出虽然发生错误事件，但仍然不影响系统的继续运行。打印错误和异常信息，如果不想输出太多的日志，可以使用这个级别。
        //FATAL 指出每个严重的错误事件将会导致应用程序的退出。这个级别比较高了。重大错误，这种级别你可以直接停止程序了。

        //TRACE designates finer-grained informational events than the DEBUG.Since:1.2.12，很低的日志级别，一般不会使用。  
        //OFF 最高等级的，用于关闭所有日志记录。
        //如果将log level设置在某一个级别上，那么比此级别优先级高的log都能打印出来。例如，如果设置优先级为WARN，那么OFF、FATAL、ERROR、WARN 4个级别的log能正常输出，而INFO、DEBUG、TRACE、 ALL级别的log则会被忽略。Log4j建议只使用四个级别，优先级从高到低分别是ERROR、WARN、INFO、DEBUG。

        #region DEBUG 指出细粒度信息事件对调试应用程序是非常有帮助的，主要用于开发过程中打印一些运行信息。 
        public static void debug(string write)
        {

            Log.Debug("日志记录:" + write);
        }
        public static void debug(string write, Exception ex)
        {
            Log.Debug("日志记录:" + write + "。错误记载：" + ex.ToString());
        }
        #endregion
        #region INFO 消息在粗粒度级别上突出强调应用程序的运行过程。打印一些你感兴趣的或者重要的信息，这个可以用于生产环境中输出程序运行的一些重要信息，
        /// <summary>
        /// 1
        /// </summary>
        /// <param name="write"></param>
        public static void Info(string write)
        {
            Log.Info("日志记录:" + write);
        }
        public static void Info(string write, Exception ex)
        {
            Log.Info("日志记录:" + write + "。错误记载：" + ex.ToString());
        }
        #endregion
        #region WARN 表明会出现潜在错误的情形，有些信息不是错误信息，但是也要给程序员的一些提示。，可以使用这个级别。
        public static void warn(string write)
        {
            Log.Warn("日志记录:" + write);
        }
        public static void warn(string write, Exception ex)
        {
            Log.Warn("日志记录:" + write + "。错误记载：" + ex.ToString());
        }
        #endregion

        #region ERROR 指出虽然发生错误事件，但仍然不影响系统的继续运行。打印错误和异常信息，如果不想输出太多的日志，可以使用这个级别。
        public static void error(string write)
        {
            Log.Error("日志记录:" + write);
        }
        public static void error(string write, Exception ex)
        {
            Log.Error("日志记录:" + write + "。错误记载：" + ex.ToString());
        }
        #endregion
        #region FATAL 指出每个严重的错误事件将会导致应用程序的退出。这个级别比较高了。重大错误，这种级别你可以直接停止程序了。
        public static void fatal(string write)
        {
            Log.Fatal("日志记录:" + write);
        }
        public static void fatal(string write, Exception ex)
        {
            Log.Fatal("日志记录:" + write + "。错误记载：" + ex.ToString());
        }
        //#endregion


        #endregion



        //定义输出的日志内容
        public static string logMessage(SysLogMsg logMessage)
        {
            StringBuilder strInfo = new StringBuilder();
            strInfo.Append("\r\n1. 错误: >> 操作时间: " + logMessage.OperationTime + "   操作人: " + logMessage.UserName + " \r\n");
            strInfo.Append("2. 类名: " + logMessage.Class + " \r\n");
            strInfo.Append("3. 内容: " + logMessage.Content + "\r\n");
            strInfo.Append("-----------------------------------------------------------------------------------------------------------------------------\r\n");
            return strInfo.ToString();
        }
    }
}