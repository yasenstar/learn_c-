using System;

namespace AgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            const int i = 18;
            const int j = 30;
            const int k = 50;
            int YourAge = 0;
            Console.WriteLine("请输入你的年龄： ");
            YourAge = int.Parse(Console.ReadLine());
            Console.WriteLine("你的年龄是：{0}", YourAge);
            if (YourAge <= i)
            {
                Console.WriteLine("您的年龄还小，要努力奋斗哦！");
            }
            else
            {
                if (i < YourAge && YourAge <= j)
                {
                    Console.WriteLine("您现在的阶段正是努力奋斗的黄金阶段！");
                }
                else
                {
                    if (j < YourAge && YourAge <= k)
                    {
                        Console.WriteLine("您现在的阶段正是人生的黄金阶段");
                    }
                    else
                    {
                        Console.WriteLine("最美不过夕阳红");
                    }
                }
            }
        }
    }
}
