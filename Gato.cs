using System;

namespace Zoologico
{
    public class Gato : Animal
    {
        public Gato() : base()
        {
            gato = "";
        }
        public Gato(string nome, int idade, string cor, string especie)
        : base(nome, idade, cor)
        {
            gato = especie;
        }

        public string gato { get; set; }
    }
}