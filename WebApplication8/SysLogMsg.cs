using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8
{
    public class SysLogMsg
    {
        public string OperationTime { get; set; }//  操作时间

        public string UserName { get; set; }//用户名
        public string Class { get; set; }//类
        public string Content { get; set; }//内容
    }
}