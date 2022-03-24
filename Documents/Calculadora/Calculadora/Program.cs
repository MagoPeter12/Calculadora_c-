using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal valor1;
            decimal valor2;
            decimal resultado;
            string opção;
            int soma;
            int subtração;
            int multiplicar;
            int dividir;
            string sair;

            Console.WriteLine("Bem Vindo a calculadora");
            Console.WriteLine("Escolha soma, subtração,multiplicar,dividir");
            opção = (Console.ReadLine());
            Console.WriteLine("Digite o primeiro número");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            valor2 = int.Parse(Console.ReadLine());


            switch (opção)
            {
                case "soma":

                    resultado = valor1 + valor2;
                    Console.WriteLine("Resultado é: " + resultado);

                    break;

                case "subtração":

                    resultado = valor1 - valor2;
                    Console.WriteLine("Resultado é: " + resultado);

                    break;

                case "multiplicar":

                    resultado = valor1 * valor2;
                    Console.WriteLine("Resultado é: " + resultado);

                    break;

                case "dividir":

                    resultado = valor1 / valor2;
                    Console.WriteLine("Resultado é: " + resultado);

                    break;
            }
                    Console.WriteLine("Deseja Sair s/n ?");
                    sair = Console.ReadLine();

            while (sair == "s")

            Console.ReadKey();
        }
    }
}
