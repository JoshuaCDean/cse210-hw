using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 10));
        shapes.Add(new Rectangle("orange", 10,23));
        shapes.Add(new Circle("purple", 19));

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"The Color of your shape is {color} and the area is {area}.");
        }
    }
}