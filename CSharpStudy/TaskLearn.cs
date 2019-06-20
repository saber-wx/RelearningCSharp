using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class TaskLearn
    {
        public static void Call()
        {

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(); Task<long> t1 = new Task<long>(() =>
                //{
                //    Console.WriteLine($"第{i + 1}次：");
                //    Console.WriteLine($"Task-{Task.CurrentId}：起床啦！...." +
                //        $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                //    return DateTime.Now.Ticks;
                //});

                Task<long> getup = new Task<long>((n) =>
                {
                   
                    Console.WriteLine($"第{n}次Task-{Task.CurrentId}：起床啦！...." +
                        $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                    return DateTime.Now.Ticks;
                }, i + 1);


                getup.Start();
                Console.WriteLine("task.Result" + getup.Result);

                getup.ContinueWith((x) =>
                {
                    Console.WriteLine($"{x.Result}起床结束");
                    Console.WriteLine($"Task-{Task.CurrentId}：刷牙洗脸...." +
                        $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                });
            }

        }
       
    }
}
