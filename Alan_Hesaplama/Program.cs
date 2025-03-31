using System;


abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}


class Square : Shape
{
    private double Side;

    public Square(double side)
    {
        Side = side;
    }

    public override double CalculateArea() => Side * Side;
    public override double CalculatePerimeter() => 4 * Side;
}


class Rectangle : Shape
{
    private double Width, Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea() => Width * Height;
    public override double CalculatePerimeter() => 2 * (Width + Height);
}


class Circle : Shape
{
    private double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * Radius * Radius;
    public override double CalculatePerimeter() => 2 * Math.PI * Radius;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Alan ve Çevre Hesaplayıcı");
        Console.WriteLine("1 - Kare\n2 - Dikdörtgen\n3 - Daire");
        Console.Write("Lütfen bir şekil seçiniz: ");
        int choice = int.Parse(Console.ReadLine());
        
        Shape shape = null;
        
        switch (choice)
        {
            case 1:
                Console.Write("Kenar uzunluğunu giriniz: ");
                double side = double.Parse(Console.ReadLine());
                shape = new Square(side);
                break;
            case 2:
                Console.Write("Genişliği giriniz: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Yüksekliği giriniz: ");
                double height = double.Parse(Console.ReadLine());
                shape = new Rectangle(width, height);
                break;
            case 3:
                Console.Write("Yarıçapı giriniz: ");
                double radius = double.Parse(Console.ReadLine());
                shape = new Circle(radius);
                break;
            default:
                Console.WriteLine("Geçersiz seçim!");
                return;
        }
        
        Console.WriteLine("1 - Alan Hesapla\n2 - Çevre Hesapla");
        Console.Write("Seçiminiz: ");
        int calcChoice = int.Parse(Console.ReadLine());
        
        if (calcChoice == 1)
            Console.WriteLine($"Alan: {shape.CalculateArea():F2}");
        else if (calcChoice == 2)
            Console.WriteLine($"Çevre: {shape.CalculatePerimeter():F2}");
        else
            Console.WriteLine("Geçersiz seçim!");
    }
}
