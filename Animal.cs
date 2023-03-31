using System;

namespace Zoologico
{
    public class Animal
    {
        public Animal()
        {
            Nome = "";
            Idade = 0;
            Cor = "";
        }
        public Animal(string nome, int idade, string cor)
        {
            Nome = nome;
            Idade = idade;
            Cor = cor;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cor { get; set; }
    }
}