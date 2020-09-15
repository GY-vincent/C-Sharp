using System;

namespace 实验3._0
{
    #region 主函数类
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请依次输入Ax,Ay,Bx,By,A_a,A_b");  //提示用户输入基本计算条件
            string Ax = Console.ReadLine();
            string Ay = Console.ReadLine();
            string Bx = Console.ReadLine();
            string By = Console.ReadLine();
            string A_a = Console.ReadLine();
            string A_b = Console.ReadLine();
            Point a = new Point(double.Parse(Ax), double.Parse(Ay));    //创建点A
            Point b = new Point(double.Parse(Bx), double.Parse(By));    //创建点B
            Forward forward = new Forward(a, b, double.Parse(A_a), double.Parse(A_b));  //创建前方交会类
            Console.WriteLine("P点X为：" + forward.result().getX() + "\tP点Y为：" + forward.result().getY()); //通过交会类计算结果
        }
    }
    #endregion

    #region 前方交会类
    public class Forward
    {
        public Forward(Point a, Point b, double a_a, double a_b)    //初始化类的成员变量
        {
            A = a;
            B = b;
            a_A = a_a;
            a_B = a_b;
        }
        public Point result()   //返回前方交会计算结果
        {
            double temp1 = (A.getX() / Math.Tan(a_B / 180 * Math.PI) + B.getX() / Math.Tan(a_A / 180 * Math.PI) - A.getY() + B.getY()) /
                (1 / Math.Tan(a_A / 180 * Math.PI) + 1 / Math.Tan(a_B / 180 * Math.PI));
            P.setX(temp1);
            double temp2 = (A.getY() / Math.Tan(a_B / 180 * Math.PI) + B.getY() / Math.Tan(a_A / 180 * Math.PI) - A.getX() + B.getX()) /
                (1 / Math.Tan(a_A / 180 * Math.PI) + 1 / Math.Tan(a_B / 180 * Math.PI));
            P.setY(temp2);
            return P;
        }
        //private Point P;
        //private Point A;
        //private Point B;
        //这里抛异常，提示“C#未将对象引用设置到对象的实例”，改为下面的代码解决问题
        private Point P = new Point();
        private Point A = new Point();
        private Point B = new Point();


        private double a_A; 
        private double a_B;

    }
    #endregion

    #region Point基础点类
    public class Point
    {
        public Point(double _x, double _y)  //构造函数初始化点的坐标
        {
            this.x = _x;
            this.y = _y;
        }
        public Point()  //空白构造
        {
        }
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public void setX(double _x)
        {
            x = _x;
        }
        public void setY(double _y)
        {
            y = _y;
        }
        private double x;
        private double y;
    }
    #endregion
}
