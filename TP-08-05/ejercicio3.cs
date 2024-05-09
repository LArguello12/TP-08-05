using System;

class Rectangulo : Figura
{
    private double baseRectangulo;
    private double alturaRectangulo;

    public Rectangulo(double baseRectangulo, double alturaRectangulo)
    {
        this.baseRectangulo = baseRectangulo;
        this.alturaRectangulo = alturaRectangulo;
    }

    public override double CalcularArea()
    {
        return baseRectangulo * alturaRectangulo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangulo rectangulo = new Rectangulo(4, 6);

        Console.WriteLine("El area del rectangulo es: " + rectangulo.CalcularArea());
    }
}