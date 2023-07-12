using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao teste 03");
        

        while (true)
        {
            Console.WriteLine("\nInforme o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Qual foi a nota do primeiro Semestre do aluno {nome}:");
            double notaPrimeiroSemestre = double.Parse(Console.ReadLine());

            Console.WriteLine($"Qual foi a nota do segundo Semestre do aluno {nome}:");
            double notaSegundoSemestre = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nome do aluno: {nome}");
            double media = CalcularMedia(notaPrimeiroSemestre, notaSegundoSemestre);
            Console.WriteLine($"Média: {media.ToString("F2")}");
            if (media > 6.5) Console.WriteLine("O aluno foi: Aprovado");
            else Console.WriteLine("O aluno foi: Reprovado");

        }
    }

    static double CalcularMedia(double notaPrimeiroSemestre, double notaSegundoSemestre)
    {
        return (notaPrimeiroSemestre + notaSegundoSemestre) / 2;
    }
}



