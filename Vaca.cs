using System;

namespace Zoologico
{
    public class Vaca : Animal
    {
        public Vaca() : base()
        {
            vaca = "";
        }
        public Vaca(string nome, int idade, string cor, string especie)
        : base(nome, idade, cor)
        {
            vaca = especie;
        }

        public string vaca { get; set; }
    }
}