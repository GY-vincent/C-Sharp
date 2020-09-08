using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.hello world
            Console.WriteLine("hello,world!");


            //2.隐式类型转换
            double a = 0;
            int b = 2;
            a = b * 1.0;
            Console.WriteLine("a隐式转换后的值为{0}", a);


            //3.显式类型转换
            double a1 = 0;
            int b1 = 2;
            a1 = (double)b1;
            Console.WriteLine("a1显式转换后的值为{0}", a1);


            //4.Convert类型转换
            string a2 = "123";
            int b2 = Convert.ToInt32(a2);
            Console.WriteLine("a2Convert转化后的值为{0}", b2);


            //5.Parse类型转换
            string a3 = "123";
            int b3 = int.Parse(a3);
            Console.WriteLine("a3Parse转化后的值为{0}", b3);


            //6.tryParse
            string a4 = "123";
            int c4 = 0;
            bool b4 = int.TryParse(a4, out c4);


            //7.字符串格式化输出
            Console.WriteLine("{0:C}", 368);    //货币格式
            Console.WriteLine("{0:E}", 368);    //科学计数法
            Console.WriteLine("{0:N}", 368111111111);   //逗号分隔数字
            Console.WriteLine("{0:F2}", Math.PI);   //圆周率取两位显示
            Console.WriteLine("{0:X4}", 368);   //4位数字16进制显示
            Console.WriteLine("{0:P}", 0.99);   //百分比显示
            Console.ReadKey();
        }
    }
}
