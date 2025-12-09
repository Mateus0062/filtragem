using System;
using System.Collections.Generic;

class Program
{
    public class User
    {
        public string? nome {  get; set; }
        public int idade { get; set; }
    }

    static void Main(string[] args)
    {
        List<User> list = new List<User>();
        
        for (int i = 0; i < 3; i++)
        {
            User novousuario = new User();

            Console.WriteLine("Informe o nome");
            string nomeInput = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Informe a idade");
            int idadeInput = int.Parse(Console.ReadLine()!);

            novousuario.nome = nomeInput;
            novousuario.idade = idadeInput;

            list.Add(novousuario);
        }

        /* Loop para exibir todos os nomes adicionados à lista */
        foreach (var u in list)
        {
            Console.WriteLine($"\nNome: {u.nome}, \nIdade: {u.idade} anos");
        }

        /* Filtragem usando o método iterativo */
        Console.WriteLine("\nExibindo os itens da lista após o filtro (utilizando o método iterativo): ");
        foreach (var i in list)
        {
            if (i.idade == 18)
            {
                Console.WriteLine($"\nNome: {i.nome}, \nIdade: {i.idade} anos");
            }
        }

        /* Filtragem usando a sintaxe de consulta LINQ (cláusula Where (Where))*/
        var resultadoFiltrado = from l in list
                                where l.idade == 18
                                select l.nome;

        Console.WriteLine("\nExibindo os itens da lista após o filtro (utilizando o método LINQ (cláusula Where (Where)): ");
        foreach (var resultado in resultadoFiltrado)
        {
            Console.WriteLine($"\nNome: {resultado}");
        }

        /* Filtragem usando a sintaxe do método LINQ (cláusula where)*/
        List<User> listaFiltrada = list.Where(f => f.idade == 18).ToList();

        Console.WriteLine("\nExibindo os itens da lista após o filtro: ");
        foreach (var f in listaFiltrada)
        {
            Console.WriteLine($"\nNome: {f.nome}, \nIdade: {f.idade} anos");
        }
    }
}
