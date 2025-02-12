using System;


class  Rectangle
{
    public int Wight;
    public int Height;
    public int Area;

    public Rectangle()
    {
        Wight = 25;
        Height = 465;
        Area = Wight * Height;
        Console.WriteLine("Конструктор по умолчанию вызван. Площадь прямоугольника: " + Area);
    }
    
    public Rectangle(int Wight, int Height)
    {
        this.Wight = Wight;
        this.Height = Height;
        Area = Wight * Height;
        Console.WriteLine("Конструктор с параметрами вызван. Площадь прямоугольника: " + Area);
    }

    public Rectangle(Rectangle other)
    {
        Wight = other.Wight;
        Height = other.Height;
        Area = other.Wight * other.Height;
        Console.WriteLine("Конструктор копирования вызван. Площадь прямоугольника: " + Area);
    }

    ~Rectangle() 
    {
        Console.WriteLine($"Деструктор вызван. Wight: {Wight}, Height: {Height}");
        GC.SuppressFinalize(this);
    }



}


class Program
{

    static void Main(string[] args)
    {
        Rectangle a1 = new Rectangle();
        Rectangle a2 = new Rectangle(25,13);
        Rectangle a3 = new Rectangle(a2);

        a1 = null;
        a2 = null;
        a3 = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
