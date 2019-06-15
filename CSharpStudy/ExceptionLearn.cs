using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpStudy
{
    class ExceptionLearn
    {
        public static void Call()
        {
                try
                {
                    InputMonth();
                }
                catch (FormatException e)
                {
                    Console.WriteLine("你输入的不是一个月份，请重新输入");
                    Console.WriteLine();
                    File.AppendAllText("D:\\17bang\\wxgo-error.log", e.ToString() + Environment.NewLine);
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("你输入的数值不能转换成地图，请重新输入");
                    Console.WriteLine();
                    File.AppendAllText("D:\\17bang\\wxgo-error.log", e.ToString() + Environment.NewLine);
                }
                catch (Exception e)
                {
                    File.AppendAllText("D:\\17bang\\wxgo-error.log", e.ToString() + Environment.NewLine);
                    Console.WriteLine("程序遇到了未处理的异常情况，请稍后重试或者联系我们……");
                    Console.WriteLine();
                }

        }

        static Season GetSeason(int month,string credendum)
        {

            if (month > 12 || month < 1)
            {
                throw new ArgumentOutOfRangeException("输入月份有误");
            }

            ////后期彩蛋
            //if (credendum == "飞哥最帅")
            //{
            //    return Season.paradise;
            //}

            else if (month > 2 && month <= 5)
            {
                return Season.spring;

            }
            else if (month > 5 && month <= 8)
            {
                return Season.summer;
            }
            else if (month > 8 && month <= 11)
            {
                return Season.autumn;
            }
            else
            {
                return Season.winter;
            }
        }

        public static void GetMaP(int month,string credendum)
        {
            try {
                Season season = GetSeason(month, credendum);
                switch (season)
                {
                    ////后期加入彩蛋:
                    //case Season.paradise:
                    //    Console.WriteLine("欢迎来到<仙境之旅>,获得所有地图");
                    //    break;
                    case Season.spring:
                        Console.WriteLine("欢迎来到<草长莺飞>的世界");
                        break;
                    case Season.summer:
                        Console.WriteLine("欢迎来到<赤地千里>的世界");
                        break;
                    case Season.autumn:
                        Console.WriteLine("欢迎来到<层林尽染>的世界");
                        break;
                    case Season.winter:
                        Console.WriteLine("欢迎来到<傲雪凌霜>的世界");
                        break;
                    default:
                        throw new NotImplementedException($"输入了{season}的未处理的地图");
                }

            }
            catch(Exception e)
            {
                File.AppendAllText("D:\\17bang\\wx-error.log", $"{DateTime.Now}：输入的{credendum}未能成功转换" 
                    + e.ToString() + Environment.NewLine);
                throw new InvalidCastException($"score（${credendum}）未能成功转换成等级", e);
            }
            
        }

        //输入数字转为月份
        public static void InputMonth()
        {
            Console.WriteLine("你喜欢几月?");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("你的信条?");
            string credendum = Console.ReadLine();
            GetMaP(month,credendum);
        }


    }

    //地图依据
    enum Season
    {
        ////后期加入彩蛋
        //paradise,
        spring,
        summer,
        autumn,
        winter
    }
}
