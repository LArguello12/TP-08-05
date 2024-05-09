using System;

abstract class Figura
{
    public abstract double CalcularArea();
}

class Circulo : Figura
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

class Program
{
    static void Main(string[] args)
    {
        Circulo circulo = new Circulo(5);

        Console.WriteLine("El area del circulo es: " + circulo.CalcularArea());
    }
}