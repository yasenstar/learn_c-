using System;

namespace seasoncheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个月份：");
            int MyMonth = int.Parse(Console.ReadLine());
            string MySeason;
            switch (MyMonth)
            {
                case 12:
                case 1:
                case 2:
                    MySeason = "您输入的月份属于冬季";
                    break;
                case 3:
                case 4:
                case 5:
                    MySeason = "您输入的月份属于春季";
                    break;
                case 6:
                case 7:
                case 8:
                    MySeason = "您输入的月份属于夏季";
                    break;
                case 9:
                case 10:
                case 11:
                    MySeason = "您输入的月份属于秋季";
                    break;
                default:
                    MySeason = "抱歉，您输入的月份有误！";
                    break;
            }
            Console.WriteLine(MySeason);
            Console.ReadKey();
        }
    }
}
