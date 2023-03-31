using System;

namespace Zoologico
{
    public class Cachorro : Animal
    {
        public Cachorro() : base()
        {
            cachorro = "";
        }
        public Cachorro(string nome, int idade, string cor, string especie)
        : base(nome, idade, cor)
        {
            cachorro = especie;
        }
        public string cachorro { get; set; }
    }
}