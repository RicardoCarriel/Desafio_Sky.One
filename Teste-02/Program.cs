using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bem-vindo ao teste 02, para iniciarmos qual é o seu nome? \n");
        string nome = Console.ReadLine();

        

        double totalNotas = 0;
        int quantidadeNotas = 0;
        string notaStr;

        while (true)
        {
            Console.Write($"\n{nome} por favor, nos informe qual foi a sua nota na prova (digite 'fim' para encerrar): \n");
            notaStr = Console.ReadLine();
            if (notaStr.ToLower() == "fim") break;
            

            if (double.TryParse(notaStr, out double nota))
            {
                totalNotas += nota;
                quantidadeNotas++;
            }
            else Console.WriteLine("Valor inválido. Tente novamente.");

            if (quantidadeNotas > 0)
            {
                double media = totalNotas / quantidadeNotas;
                
                Console.WriteLine("\nNome do Aluno: " + nome);
                Console.WriteLine("Quantidade de Provas: " + quantidadeNotas);
                Console.WriteLine("Total de Notas: " + totalNotas);
                Console.WriteLine("Média do Aluno: " + media.ToString("F2"));
            }
            else Console.WriteLine("Nenhuma nota válida foi informada.");
            
        }

        
    }
}