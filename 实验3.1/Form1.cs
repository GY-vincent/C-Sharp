using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验3._1
{
    public partial class 前方交会 : Form
    {
        public 前方交会()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("请依次输入Ax,Ay,Bx,By,A_a,A_b");
            string Ax = Xaa.Text;
            string Ay = Yaa.Text;
            string Bx = Xbb.Text;
            string By = Ybb.Text;
            string A_a = aaa.Text;
            string A_b = bbb.Text;
            Point a = new Point(double.Parse(Ax), double.Parse(Ay));
            Point b = new Point(double.Parse(Bx), double.Parse(By));
            Forward forward = new Forward(a, b, double.Parse(A_a), double.Parse(A_b));
            Xpp.Text = Convert.ToString(forward.result().getX());
            Ypp.Text = Convert.ToString(forward.result().getY());
        }
    }
    #region 前方交会类
    public class Forward
    {
        public Forward(Point a, Point b, double a_a, double a_b)
        {
            A = a;
            B = b;
            a_A = a_a;
            a_B = a_b;
        }
        public Point result()
        {
            double temp1 = (A.getX() / Math.Tan(a_B / 180 * Math.PI) + B.getX() / Math.Tan(a_A / 180 * Math.PI) - A.getY() + B.getY()) / (1 / Math.Tan(a_A / 180 * Math.PI) + 1 / Math.Tan(a_B / 180 * Math.PI));
            P.setX(temp1);
            double temp2 = (A.getY() / Math.Tan(a_B / 180 * Math.PI) + B.getY() / Math.Tan(a_A / 180 * Math.PI) - A.getX() + B.getX()) / (1 / Math.Tan(a_A / 180 * Math.PI) + 1 / Math.Tan(a_B / 180 * Math.PI));
            P.setY(temp2);
            return P;
        }


        //private Point P;
        //private Point A;
        //private Point B;
        private Point P = new Point();
        private Point A = new Point();
        private Point B = new Point();
        private double a_A;
        private double a_B;

    }
    #endregion

    #region Point类
    public class Point
    {
        public Point(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public Point()
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
