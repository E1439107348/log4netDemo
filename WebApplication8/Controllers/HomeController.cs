using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Lognet();
            return View();
        }

        //日志
        private void Lognet()
        {

            //配置文件中格式
            LogHelper.Info("-配置文件中格式-");
            LogHelper.error("-配置文件中格式-");
            LogHelper.fatal("-配置文件中格式-");
            LogHelper.warn("-配置文件中格式-");
            LogHelper.debug("-配置文件中格式-");
            //自己定义格式
            SysLogMsg logMessage = new SysLogMsg();
            logMessage.UserName = "小王";
            logMessage.OperationTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            logMessage.Content = "测试小酱油";
            logMessage.Class = "Home";
            string Retunr = LogHelper.logMessage(logMessage);
            LogHelper.Info(Retunr);
            LogHelper.error(Retunr);
            LogHelper.fatal(Retunr);
            LogHelper.warn(Retunr);
            LogHelper.debug(Retunr);
        }
    }
}