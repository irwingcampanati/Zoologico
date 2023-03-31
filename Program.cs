// - Precisamos criar um software que tenha 3 animais. Todos tem Nome, idade e cor. 
// O cachorro é o único que tem machas e a vaca é a unica doente.

// # O cachorro emite um som "Au Au Au" 
// # O gato emite um som "Miauuuuuu"
// # A vaca emite um som "Muuuuuuuuuu"

// O sofware deve possibilitar cadastrar um animal com suas propriedades. É interessante perguntar antes qual raça de animal o usuário quer cadastrar.
// Após cadastro o usuário pode cadastrar mais de um animal. 
// Ao fim caso o usuário não queira mais digitar. Basta exibir todos animais cadastrados.

// Desejável que trate o que o usuário digitar. Por exemplo. Caso o usuário digite uma raça que não existe, ele deve receber a mensagem que essa raça não está disponível para cadastro.

using System;

namespace Zoologico
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            do
            {
                var Animal = new Animal();
                Console.WriteLine("Qual especie de animal voce deseja cadastrar?");
                var especie = Console.ReadLine();
                if (especie == "Gato" | especie == "Cachorro" | especie == "Vaca")
                {
                    Console.Write("Nome: ");
                    Animal.Nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    Animal.Idade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Cor: ");
                    Animal.Cor = Console.ReadLine();
                    Console.WriteLine("Enter para continuar cadastrando. ESC para sair");
                }
                else
                {
                    Console.WriteLine("Voce digitou um animal inválido! Tecle enter e tente novamente");
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
