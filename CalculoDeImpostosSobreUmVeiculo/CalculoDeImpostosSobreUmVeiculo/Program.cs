using System;

namespace CalculoDeImpostosSobreUmVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 - O custo ao consumidor de um carro novo é a soma do custo de fábrica com a percentagem do distribuidor e dos impostos(aplicados ao custo de fábrica).Supondo que a percentagem do distribuidor seja de 28 % e os impostos de 45 %, escrever um algoritmo que leia o custo de fábrica de um carro e escreva o custo ao consumidor.

            double valor_carro;
            double porcentagem_carro_impostos;
            double porcentagem_carro_revendedora;
            double operacao1;
            double operacao2;
            double valor_do_carro_para_o_consumidor;


            Console.Write("Entre com o valor do carro desejado : ");
            valor_carro = double.Parse(Console.ReadLine());

            Console.Write("Entre com valor do imposta da revendedora : ");
            porcentagem_carro_revendedora = double.Parse(Console.ReadLine());


            Console.Write("Entre com o valor do imposto : ");
            porcentagem_carro_impostos = double.Parse(Console.ReadLine());

            operacao1 = valor_carro + (porcentagem_carro_impostos * valor_carro / 100);
            operacao2 = (porcentagem_carro_revendedora * valor_carro / 100);

            valor_do_carro_para_o_consumidor = operacao1 + operacao2;


            Console.WriteLine("O valor do carro é : " + valor_do_carro_para_o_consumidor);

            Console.ReadKey();

        }
    }
}
