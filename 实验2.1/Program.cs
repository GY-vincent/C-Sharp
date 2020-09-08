using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string index = "no";
            for (; ; )
            {
                Console.Write("请输入你的邮箱：");
                string email = Console.ReadLine();
                int ID = email.IndexOf("@");
                string userName = email.Substring(0, ID + 1);
                Console.WriteLine("您的邮箱为：{0}\t您的用户名为：{1}", email, userName);
                Console.WriteLine("是否继续输入邮箱？输入YES或者NO");
                index = Console.ReadLine().ToLower();
                if (index == "yes")
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("程序终止，按任意键继续。");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}