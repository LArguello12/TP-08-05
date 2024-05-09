using System;

abstract class Figura
{
    public abstract double CalcularArea();
}

class Triangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }
r
    public Triangulo(double _base, double altura)
    {
        Base = _base;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Triangulo triangulo = new Triangulo(5, 3);

        Console.WriteLine("Area del triangulo: " + triangulo.CalcularArea());
    }
}
