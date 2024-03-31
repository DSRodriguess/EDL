using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário que digite uma palavra ou frase para verificar se é um palíndromo
        Console.WriteLine("Digite uma palavra ou frase para verificar se é um palíndromo:");
        string entrada = Console.ReadLine().ToLower(); // Converte a entrada para minúsculas

        // Remove espaços em branco e pontuação da entrada
        string entradaFormatada = "";
        foreach (char c in entrada)
        {
            if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                entradaFormatada += c;
            }
        }

        // Verifica se a entrada formatada é um palíndromo
        bool ehPalindromo = true;
        for (int i = 0; i < entradaFormatada.Length / 2; i++)
        {
            // Compara os caracteres da entradaFormatada nas posições i e entradaFormatada.Length - 1 - i
            if (entradaFormatada[i] != entradaFormatada[entradaFormatada.Length - 1 - i])
            {
                // Se os caracteres não forem iguais, a entrada não é um palíndromo
                ehPalindromo = false;
                break;
            }
        }

        // Exibe o resultado se a entrada é ou não um palíndromo
        if (ehPalindromo)
        {
            Console.WriteLine($"'{entrada}' é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"'{entrada}' não é um palíndromo.");
        }
    }
}
