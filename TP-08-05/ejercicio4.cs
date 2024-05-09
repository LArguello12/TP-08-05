using System;

abstract class Figura
{
    public abstract double CalcularArea();
}

class Circulo : Figur
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * radio * radio;
    }
}

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
        Circulo circulo = new Circulo(5);

        Console.WriteLine("El area del circulo es: " + circulo.CalcularArea());

        Rectangulo rectangulo = new Rectangulo(4, 6);

        Console.WriteLine("El area del rectangulo es: " + rectangulo.CalcularArea());
    }
}
