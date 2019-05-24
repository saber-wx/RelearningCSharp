using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class OperationPractise
    {
        static void call()
        {
            //58天是几周零几天?
            int days = 58;
            int weeks = days / 7;
            int day = days % 7;
            Console.WriteLine("{0}天是{1}周零{2}天", days, weeks, day);
            Console.ReadKey();
            Console.WriteLine("----------------------------");

            //107653秒是几天几小时几分钟几秒?
            //一分钟:60 秒,一小时:60*60 = 3600 秒,一天: 3600 * 24 = 86400

            int seconds = 107653;
            int days1 = seconds / 86400; //求得天数
            int secs = seconds % 86400; //求得求完天数后剩余的秒数
            int hours = secs / 3600; //求得小时数
            secs = secs % 3600; //求得小时数后剩余的秒数
            int mins = secs / 60; //求得分钟数
            secs = secs % 60; //求得分钟数后剩余的秒数

            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", seconds, days1, hours, mins, secs);
            Console.ReadKey();

        }
    }
}


