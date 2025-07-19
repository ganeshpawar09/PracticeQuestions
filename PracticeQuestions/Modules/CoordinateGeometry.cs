using System;

namespace PracticeQuestions.Modules
{
    internal class Point
    {
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        internal double GetXCoordinate()
        {
            return x;
        }

        internal double GetYCoordinate()
        {
            return y; 
        }

        internal void SetXCoordinate(double x)
        {
            this.x = x;
        }

        internal void SetYCoordinate(double y)
        {
            this.y = y;
        }
    }

    internal class Point3D : Point
    {
        private double z;

        public Point3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        internal double GetZCoordinate()
        {
            return z;
        }

        internal void SetZCoordinate(double z)
        {
            this.z = z;
        }
    }

    internal class CoordinateGeometry
    {
        private double CalculateDistance2D(Point p1, Point p2)
        {
            return Math.Sqrt(
                Math.Pow(p2.GetXCoordinate() - p1.GetXCoordinate(), 2) +
                Math.Pow(p2.GetYCoordinate() - p1.GetYCoordinate(), 2)
            );
        }
        internal void CalculateDistance2D()
        {
            Point p1 = GetCoordinate("Enter x1 y1 of point A: ");
            Point p2 = GetCoordinate("Enter x2 y2 of point B: ");

            double distance = CalculateDistance2D(p1, p2);
            Console.WriteLine($"Distance between points: {distance:F2}");
        }

        private double CalculateAreaOfTriangle(Point p1, Point p2, Point p3)
        {
            double a = CalculateDistance2D(p1, p2);
            double b = CalculateDistance2D(p2, p3);
            double c = CalculateDistance2D(p3, p1);
            double s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        internal void CalculateAreaOfTriangle()
        {
            Point p1 = GetCoordinate("Enter x1 y1 of point A: ");
            Point p2 = GetCoordinate("Enter x2 y2 of point B: ");
            Point p3 = GetCoordinate("Enter x3 y3 of point C: ");

            double area = CalculateAreaOfTriangle(p1, p2, p3);
            Console.WriteLine($"Area of triangle: {area:F2}");
        }


        private Point GetCoordinate(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine()?.Trim().Split();
                if (input?.Length == 2 &&
                    double.TryParse(input[0], out double x) &&
                    double.TryParse(input[1], out double y))
                {
                    return new Point(x, y);
                }

                Console.WriteLine("Invalid input. Please enter two numeric values.");
            }
        }


        private double CalculateDistanceIn3D(Point3D[] points)
        {

            Point3D p1 = points[0];
            Point3D p2 = points[1];

            double dx = p2.GetXCoordinate() - p1.GetXCoordinate();
            double dy = p2.GetYCoordinate() - p1.GetYCoordinate();
            double dz = p2.GetZCoordinate() - p1.GetZCoordinate();

            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
        internal void CalculateDistanceIn3D()
        {
            Point3D[] points = new Point3D[2];
            points[0] = GetCoordinate3D("Enter x1 y1 z1 of point A: ");
            points[1] = GetCoordinate3D("Enter x2 y2 z2 of point B: ");

            double distance = CalculateDistanceIn3D(points);
            Console.WriteLine($"Distance between points: {distance:F2}");
        }

        private Point3D GetCoordinate3D(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine()?.Trim().Split();
                if (input?.Length == 3 &&
                    double.TryParse(input[0], out double x) &&
                    double.TryParse(input[1], out double y) &&
                    double.TryParse(input[2], out double z))
                {
                    return new Point3D(x, y, z);
                }

                Console.WriteLine("Invalid input. Please enter three numeric values.");
            }
        }
    }
    
}
