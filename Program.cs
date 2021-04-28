using System;

namespace trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é seu nome?");
            string NomePessoa = Console.ReadLine();

            // var estadoSemáforo = Qual é a cor do semáforo? //

            Console.WriteLine("Bom Dia" + NomePessoa + "!!!");

            Console.WriteLine("Digite primeiro o seu número: ");
            int primeirosNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu segundo número ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu teceiro número ");
            int terceiroNumero = int.Parse(Console.ReadLine());
            int soma = (primeirosNumero + segundoNumero + terceiroNumero)/3;

            Console.WriteLine("A Média dos três números é: " + soma);

            
            
        }
    }
}
