﻿    using System;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar },
                { "Comentários - Fundamentos", Comentarios.Executar },

            };

    }
}
