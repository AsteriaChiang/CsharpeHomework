using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        public abstract class Shape
        {
            private string myId;

            public Shape (string s)
            {
                myId = s;
            }

            public string Id
            {
                get
                {
                    return myId;
                }

                set
                {
                    myId = value;
                }
            }

            public abstract double Area
            {
                get;
            }

            public override string ToString()
            {
                return myId + "Area = " + string.Format("{0:F2}", Area);
            }
        }
        //三角形
        public class Triangle : Shape
        {
            private float myHight;
            private float myWidth;

            public Triangle(float hight,float width, string id) : base(id)
            {
                myHight = hight;
                myWidth = width;
            }

            public override double Area
            {
                get
                {
                    return (myHight * myWidth)/2;
                }
            }
        }
        //圆形
        public class Circle : Shape
        {
            private float myRad;

            public Circle(float rad, string id) : base(id)
            {
                myRad = rad;
            }

            public override double Area
            {
                get
                {
                    return myRad * myRad * System.Math.PI;
                }
            }
        }
        //正方形
        public class Square : Shape
        {
            private float mySide;

            public Square(float side, string id) : base(id)
            {
                mySide = side;
            }

            public override double Area
            {
                get
                {
                    return mySide * mySide;
                }
            }

        }
        //长方形
        public class Rectangle : Shape
        {
            private float myHight;
            private float myWidth;

            public Rectangle(float width, float height, string id) : base(id)
            {
                myHight = height;
                myWidth = width;
            }

            public override double Area
            {
                get
                {
                    return myHight * myWidth;
                }
            }

        }
        //简单工厂
        class Factory
        {
            //静态工厂方法  
            public static Shape getShape(String Id)
            {
                Shape shape = null;
                if (Id.Equals("Triangle"))
                {
                    System.Console.WriteLine("Please input the height and width length of the triangle");
                    float triheight = float.Parse(System.Console.ReadLine());
                    float triwidth = float.Parse(System.Console.ReadLine());
                    shape = new Triangle(triheight,triwidth,"Triangle");
                }
                else if (Id.Equals("Circle"))
                {
                    System.Console.WriteLine("Please input the rad length of the circle");
                    float circlerad = float.Parse(System.Console.ReadLine());
                    shape = new Circle(circlerad,"Circle");
                }
                else if (Id.Equals("Square"))
                {
                    System.Console.WriteLine("Please input the side length of the square");
                    float seqside = float.Parse(System.Console.ReadLine());
                    shape = new Square(seqside,"Square");
                }
                else if (Id.Equals("Rectangle"))
                {
                    System.Console.WriteLine("Please input the height and width length of the rectangle");
                    float rectheight = float.Parse(System.Console.ReadLine());
                    float rectwidth = float.Parse(System.Console.ReadLine());
                    shape = new Rectangle(rectheight,rectwidth,"Rectangle");
                }
                return shape;
            }
        }
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please input the type of shape");
            string Id = System.Console.ReadLine();
            Shape shape;
            shape = Factory.getShape(Id);
            System.Console.WriteLine(shape);
        }
    } 
}
