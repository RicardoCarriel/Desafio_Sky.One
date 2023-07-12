using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a nota do primeiro semestre:");
        double notaPrimeiroSemestre = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota do segundo semestre:");
        double notaSegundoSemestre = double.Parse(Console.ReadLine());

        double media = CalcularMedia(notaPrimeiroSemestre, notaSegundoSemestre);
        Console.WriteLine("Sua média é: " + media);
    }

    static double CalcularMedia(double notaPrimeiroSemestre, double notaSegundoSemestre)
    {
        return (notaPrimeiroSemestre + notaSegundoSemestre) / 2;
    }
}