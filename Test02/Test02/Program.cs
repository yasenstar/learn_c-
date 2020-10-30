﻿using System;
using N1;       //使用using命令引入命名空间N1

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            A oa = new A();     //实例化N1中的类A
            oa.MyIs();          //调用类A中的MyIs方法
        }
    }
}

namespace N1                    //建立命名空间N1
{
    class A                     //在命名空间N1中声明一个类A
    {
        public void MyIs()
        {
            Console.WriteLine("竹影扫阶尘不动\n");     //输出字符串
            Console.WriteLine("月穿潭底水无痕\n");
            Console.ReadLine();
        }
    }
}