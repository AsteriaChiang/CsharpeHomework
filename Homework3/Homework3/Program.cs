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

            public virtual void Draw()
            {
                Console.WriteLine("Draw");
            }

            public override string ToString()
            {
                return myId + "Area=" + string.Format("{0:F2}", Area);
            }
        }

        public class Square : Shape
        {
            private int mySide;

            public Square(int side,string id):base(id)
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

            public override void Draw()
            {
                Console.WriteLine(mySide);
            }
        }

        public class Circle : Shape
        {
            private int myRad;

            public Circle(int rad, string id) : base(id)
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

            public override void Draw()
            {
                Console.WriteLine(myRad);
            }
        }

        public class Rectangle : Shape
        {
            private int myHight;
            private int myWidth;

            public Rectangle(int width,int height, string id) : base(id)
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

            public override void Draw()
            {
                Console.WriteLine("Rectangle");
            }
        }

        public static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Square(5, "Sequare #1")
            };
            System.Console.WriteLine(new Square(5, "Sequare #1"));
        }

    }
  
}
