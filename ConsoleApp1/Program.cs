using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Box
    {
        public int H { get; set; }
        public int W { get; set; }

        public Box(int h, int w)
        {
            H = h;
            W = w;
        }
        public override string ToString()
        {
            return $"{H},{W}";
        }
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;   
        }
        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            //Class is a reference type point1 is a pointer in the heap
            //points to the place where data is stored (address).
            var point1 = new Point(1,1);

            var point2 = point1;

            point2.X=2; 
            point2.Y=3;
            Console.WriteLine($"Is value type:  { point1 is ValueType}");
            Console.WriteLine("Class ex:\n" + point1 + "\n" + point2);

            /* 
             ===========================================================
            Struct is a value type and its modifier is the name of the place
            in the stack where data is stored.   
             */

            Console.WriteLine("=================================");

            var box1 = new Box(1, 1);

            var box2 = box1;

            box2.H = 2; 
            
            box2.W = 3;
            Console.WriteLine($"Is value type {box1 is ValueType}");
            Console.WriteLine("Struct ex:\n" + box1 + "\n" + box2);
            Console.ReadKey();

        }
    }
}
