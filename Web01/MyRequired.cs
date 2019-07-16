using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web01
{

    public class MyRequired:RequiredAttribute
    {
        //确定验证错误信息
        public override string FormatErrorMessage(string name)
        {
            //name为[Display(Name)](如果声明的话)，否则为属性名
            return $"*{name}必须填写";
        }
    }
}
