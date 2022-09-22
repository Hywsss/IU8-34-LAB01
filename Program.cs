using System;


namespace ConsoleApplication
{
    class Rectangle
    {
        double side1;
        double side2;
        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }

    class Point
    {
        int x;
        int y;
        string name;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }

    class Figure
    {
        Point point1;
        Point point2;
        Point point3;
        Point point4;
        Point point5;
        public Figure(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.point5 = point5;
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        public void PerimeterCalculator()
        {
            if ((point4 != null) & (point5 != null))
            {
                Console.WriteLine($"Name of figure: {point1.Name + point2.Name + point3.Name + point4.Name + point5.Name}");
                Console.WriteLine($"perimetr = {LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point5) + LengthSide(point5, point1)}");
            }
            else if (point4 != null)
            {
                Console.WriteLine($"Name of figure: {point1.Name + point2.Name + point3.Name + point4.Name}");
                Console.WriteLine($"perimetr = {LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point1)}");
            }
            else
            {
                Console.WriteLine($"Name of figure: {point1.Name + point2.Name + point3.Name}");
                Console.WriteLine($"perimetr = {LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point1)}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //task 1
            Console.WriteLine("Task 1");
            Console.WriteLine($"Minimum size: {sizeof(bool)} Maximum size: {sizeof(decimal)}");
            //task 2
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter first side of rectangle:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second side of rectangle:");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rec1 = new Rectangle(side1, side2);
            Console.WriteLine($"rectangle area = {rec1.Area}");
            Console.WriteLine($"rectangle perimeter = {rec1.Perimeter}");
            //task 3
            Console.WriteLine("Task 3");
            Point p1 = new Point(1, 1, "p1");
            Point p2 = new Point(1, 2, "p2");
            Point p3 = new Point(2, 2, "p3");
            Point p4 = new Point(2, 1, "p4");
            Figure f = new Figure(p1, p2, p3, p4);
            f.PerimeterCalculator();
        }
    }
}