using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário para digitar o primeiro número
        Console.WriteLine("Digite o primeiro número:");
        // Lê o número digitado pelo usuário como uma string e o converte para double
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário para digitar o segundo número
        Console.WriteLine("Digite o segundo número:");
        // Lê o número digitado pelo usuário como uma string e o converte para double
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário para escolher a operação matemática (+, -, *, /)
        Console.WriteLine("Escolha a operação (+, -, *, /):");
        // Lê a operação digitada pelo usuário como um caractere
        char operacao = Convert.ToChar(Console.ReadLine());

        // Declaração de uma variável para armazenar o resultado da operação
        double resultado = 0;

        // Estrutura de controle switch-case para determinar a operação a ser executada
        switch (operacao)
        {
            // Caso a operação seja de adição
            case '+':
                // Executa a operação de adição
                resultado = num1 + num2;
                break;
            // Caso a operação seja de subtração
            case '-':
                // Executa a operação de subtração
                resultado = num1 - num2;
                break;
            // Caso a operação seja de multiplicação
            case '*':
                // Executa a operação de multiplicação
                resultado = num1 * num2;
                break;
            // Caso a operação seja de divisão
            case '/':
                // Executa a operação de divisão
                resultado = num1 / num2;
                break;
            // Caso a operação seja inválida
            default:
                // Exibe uma mensagem indicando que a operação é inválida
                Console.WriteLine("Operação inválida.");
                // Encerra o programa
                return;
        }

        // Exibe o resultado da operação para o usuário
        Console.WriteLine($"O resultado de {num1} {operacao} {num2} é: {resultado}");
    }
}
