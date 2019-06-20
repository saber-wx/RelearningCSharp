using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworkLearn.CAPTCHA
{
    //创建一个自定义异常
    class ExceedWidthOrHeightException : Exception
    {
        public ExceedWidthOrHeightException()
        {
            Console.WriteLine("ExceedWidthOrHeightException:创建的验证码超过最大长度或高");
        }
    }

    class BackgroundCodeColorCoveredException: Exception
    {
        public BackgroundCodeColorCoveredException()
        {
            Console.WriteLine("BackgroundCodeColorCoveredException:验证码被背景覆盖");
        }
    }
}
