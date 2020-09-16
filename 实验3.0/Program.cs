using System;

namespace 实验3._0
{
    #region 主函数类
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请依次输入Ax,Ay,Bx,By,A_a,A_b");  //提示用户输入基本计算条件
            string Ax = Console.ReadLine();     //输入点A的X值
            string Ay = Console.ReadLine();     //输入点A的Y值
            string Bx = Console.ReadLine();     //输入点B的X值
            string By = Console.ReadLine();     //输入点B的Y值
            string A_a = Console.ReadLine();    //输入∠A   (范围：0-360°)
            string A_b = Console.ReadLine();    //输入∠B  （范围：0-360°）
            Point a = new Point(double.Parse(Ax), double.Parse(Ay));    //创建点A对象并初始化
            Point b = new Point(double.Parse(Bx), double.Parse(By));    //创建点B对象并初始化
            Forward forward = new Forward(a, b, double.Parse(A_a), double.Parse(A_b));  //创建前方交会对象并初始化
            Console.WriteLine("P点X为：" + Math.Round(forward.result().getX(), 2) + "\tP点Y为：" + Math.Round(forward.result().getY(), 2)); //输出交会类对象的计算结果
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
        public Point result()   //返回计算结果，返回值类型为Point对象
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
        private Point P = new Point();      //创建待计算坐标值的P点对象
        private Point A = new Point();      //创建A点对象
        private Point B = new Point();      //创建B点对象


        private double a_A;     //∠A的度数值（0-360°）
        private double a_B;     //∠B的角度值（0-360°）

    }
    #endregion

    #region Point基础点类
    public class Point
    {
        public Point(double _x, double _y)  //构造函数初始化点的XY坐标
        {
            this.x = _x;
            this.y = _y;
        }
        public Point()  //空白构造
        {
        }
        public double getX()    //返回X的double值
        {
            return x;
        }
        public double getY()    //返回Y的double值
        {
            return y;
        }
        public void setX(double _x)     //设置点的X值
        {
            x = _x;
        }
        public void setY(double _y)     //设置点的Y值
        {
            y = _y;
        }
        private double x;   //点的X值
        private double y;   //点的Y值
    }
    #endregion
}
