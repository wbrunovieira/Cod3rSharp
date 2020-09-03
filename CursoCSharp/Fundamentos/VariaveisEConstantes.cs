using System;
namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public VariaveisEConstantes()
        {

            public static void Executar()
            {
                //area da circunferencia
                double raio = 4.5;
                const double pi = 3.14;

                raio = 5;
                // pi = 3.1415;

                double area = pi * raio * raio;
                Console.WriteLine(area);
                Console.WriteLine($"A Area e{area}");

                byte idade = 45;
                sbyte saldoDeGols = sbyte.MaxValue;

                short salario = short.MaxValue;

                int menorValor = int.MinValue;

                uint populacaoBrasileira = 207_600_890; // int only positive

                long menorValorLong = long.MinValue;

                ulong populacaoMundial = 7_000_000_000;

                float precoComputador = 1299.56f;

                double valorApple = 100_000_000_000.00;

                decimal distanciaEntreEstrelas = decimal.MaxValue;

                char b = 'd';

                string texto = "Curso C#";


            }
        }
    }
}
