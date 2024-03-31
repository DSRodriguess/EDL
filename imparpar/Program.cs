using System; // Importa o namespace System, que contém classes fundamentais e tipos de dados para o desenvolvimento de aplicativos.

class Program // Define uma classe chamada Program.
{
    static void Main(string[] args) // Método principal que é executado quando o programa é iniciado.
    {
        int numero = 7; // Declara e inicializa a variável 'numero' com o valor 7.

        if (numero % 2 == 0) // Verifica se o número é par, calculando o resto da divisão por 2.
        {
            Console.WriteLine($"{numero} é um número par."); // Se for par, imprime uma mensagem indicando que o número é par.
        }
        else // Caso contrário (se o resto da divisão não for zero), significa que o número é ímpar.
        {
            Console.WriteLine($"{numero} é um número ímpar."); // Imprime uma mensagem indicando que o número é ímpar.
        }
    }
}
