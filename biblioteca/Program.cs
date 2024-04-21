using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma lista de livros para simular um catálogo
        List<Book> libraryCatalog = new List<Book>
        {
	    // Inicialização do catálogo com alguns livros

            new Book("O Senhor dos Anéis: A Sociedade do Anel", "J.R.R. Tolkien", Genre.Fiction, 1954),
            new Book("Harry Potter e a Pedra Filosofal", "J.K. Rowling", Genre.Fiction, 1997),
            new Book("A Guerra dos Tronos", "George R.R. Martin", Genre.Fiction, 1996),
            new Book("It: A Coisa", " Stephen King", Genre.horror, 1986),
            new Book("As Crônicas de Nárnia: O Leão, a Feiticeira e o Guarda-Roupa", "C.S. Lewis", Genre.Fiction, 1950),
            new Book("Orgulho e Preconceito", "Jane Austen", Genre.Romance, 1813),
            
        };

        Console.WriteLine("Bem-vindo à biblioteca!");

        while (true)
        {
            // Exibe o menu de opções para o usuário

            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Pesquisar por título");
            Console.WriteLine("2. Pesquisar por autor");
            Console.WriteLine("3. Pesquisar por gênero");
            Console.WriteLine("4. Pesquisar por ano de publicação");
            Console.WriteLine("5. Sair");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Digite o título do livro: ");
                    string titleQuery = Console.ReadLine();
                    SearchBooks(libraryCatalog, book => book.Title.Contains(titleQuery));
                    break;
                case "2":
                    Console.Write("Digite o nome do autor: ");
                    string authorQuery = Console.ReadLine();
                    SearchBooks(libraryCatalog, book => book.Author.Contains(authorQuery));
                    break;
                case "3":
                    Console.WriteLine("Escolha um gênero:");
                    foreach (Genre genre in Enum.GetValues(typeof(Genre)))
                    {
                        Console.WriteLine($"{(int)genre}. {genre}");
                    }
                    int genreChoice = int.Parse(Console.ReadLine());
                    SearchBooks(libraryCatalog, book => book.BookGenre == (Genre)genreChoice);
                    break;
                case "4":
                    Console.Write("Digite o ano de publicação: ");
                    int yearQuery = int.Parse(Console.ReadLine());
                    SearchBooks(libraryCatalog, book => book.YearOfPublication == yearQuery);
                    break;
                case "5":
                    Console.WriteLine("Obrigado por usar a biblioteca!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    // Método para realizar a pesquisa de livros com base em um predicado

    static void SearchBooks(List<Book> catalog, Func<Book, bool> predicate)
    {
        var result = catalog.Where(predicate);
        
        if (result.Any())
        {
	    // Exibe os resultados da pesquisa

            Console.WriteLine("\nResultados da pesquisa:");
            foreach (var book in result)
            {
                Console.WriteLine($"{book.Title} - {book.Author} ({book.YearOfPublication})");
            }
        }
        else
        {
	    // Informa ao usuário que nenhum livro foi encontrado

            Console.WriteLine("Nenhum livro encontrado com os critérios fornecidos.");
        }
    }
}

// Aqui começa a definição da classe Program. O método Main é o ponto de entrada do programa, onde é inicializado o catálogo da biblioteca e apresentado um menu para o usuário. O método SearchBooks é utilizado para realizar a pesquisa de livros com base em um predicado fornecido.

// O método SearchBooks recebe como parâmetros a lista de livros a ser pesquisada e um predicado que define as condições de busca. Utilizando LINQ, ele filtra a lista de livros com base no predicado fornecido e exibe os resultados ou uma mensagem caso nenhum livro seja encontrado.

class Book
{
    // Definição da classe Book que representa um livro

    public string Title { get; set; }
    public string Author { get; set; }
    public Genre BookGenre { get; set; }
    public int YearOfPublication { get; set; }

    public Book(string title, string author, Genre genre, int year)
    {
        Title = title;
        Author = author;
        BookGenre = genre;
        YearOfPublication = year;
    }
}

enum Genre
{
    // Definição do enum Genre para os diferentes gêneros de livros

    Fiction,
    Romance,
    horror,
    Mystery,
    ScienceFiction,
    Thriller,
}

// Aqui são definidas a classe Book, que representa um livro, e o enum Genre, que define os diferentes gêneros de livros disponíveis.
