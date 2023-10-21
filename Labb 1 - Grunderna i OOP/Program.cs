using System;

namespace Labb_1___Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle.Run();
        }
        class Circle
        {
            public float _pi = 3.14159265359f;
            public int _radius;

            public Circle(int Radius)
            {
                _radius = Radius;
            }
            public void getArea()
            {
                float result = _radius * _radius * _pi;
                Console.WriteLine($"Arean för cirkeln med en radius på 5cm är: {result}cm2");
            }
            public static void Run()
            {
                Circle circle1 = new Circle(5);
                Circle circle2 = new Circle(6);
                circle1.getArea();
                circle2.getArea();
            }
        }
    }
}