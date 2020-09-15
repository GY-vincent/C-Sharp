using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)     //代码二：计算数组中女生的平均年龄
        {
            string[] sex = { "女", "男", "女", "女", "女", "女" };
            int[] age = { 18, 17, 18, 18, 17, 19 };
            int sum = 0;
            int index = 0;
            for (int i = 0; i < 6; i++)
            {
                if (sex[i] == "女")
                {
                    sum += age[i];
                    index++;
                }
            }
            if (index == 0)
            {
                Console.WriteLine("很遗憾，这里没有女生~");
            }
            else
            {
                Console.WriteLine("女生平均年龄为：{0}", sum / index);
            }
            Console.ReadKey();
        }
    }
}