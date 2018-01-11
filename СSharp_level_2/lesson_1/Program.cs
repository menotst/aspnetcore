using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    internal class Program
    {      
        static PointS Reverse(ref PointS dot)
        {
            dot.X = -dot.X;
            dot.Y = -dot.Y;
            return dot;
        }

        static void Main(string[] args)
        {            

            /**********Structure**********/
                   

            PointS one1 = new PointS(12, 8);
            PointS two = Reverse(ref one1);
            Console.WriteLine($"one.X = {one1.X} one.Y={one1.Y}");
            Console.WriteLine($"two.X = {two.X} one.Y={two.Y}");

            PointS[] arr = new PointS[50];
            Console.WriteLine($"arr[0].X={arr[0].X} arr[0].Y={arr[0].Y} typeof(arr[0])={arr[0].X.GetType()}");
            PointS three = new PointS();
            three.Y = 2.34;
            Console.WriteLine($"three.X={three.X} three.Y={three.Y}");
            PointS four;
            four = three;
            Console.WriteLine($"four.X={four.X} four.Y={four.Y}");
            MyObject obj = new MyObject
            {
                X = 10,
                Y = 5

            };
            Console.WriteLine(obj.ToString());
            lesson2.Method1();
            
        }
    }

   
    class PointC
    {
        private double x,y;
        public PointC() {} 

        public PointC(double x, double y)
        {
            this.x = x;
            this.y = y;
        }    
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
    }

    struct PointS
    {
        //double x = 10, y = -20;
        //public PointS() { y = -5; }
        double x, y;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public PointS (double xi,double yi) { x = xi; y = yi; }
    }
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vector()
        {
            X = Y = 0;
        }
        public Vector(double x,double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"X={X} y={Y}";
        
    }
    class MyObject : Vector
    { }

    public class Animals
    {
        private string _name;
        private int _numberPawns;
        public Animals (string name,int numberPawns)
        {
            _name = name;
            _numberPawns = numberPawns;
        }
    }

    public sealed class Cat :Animals
    {
        private ushort? _lengthTail;
        public Cat(string name,int numberPawns,ushort? lengthTail) : base(name,numberPawns)
        {
            _lengthTail = lengthTail;
        }
    }
    

}
