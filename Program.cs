using System;

namespace Exercicio_quatorze
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco = 0.0;

            Console.WriteLine("Digite o código: ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                preco = 4.00 * quantidade;
            }
            else if (codigo == 2)
            {
                preco = 4.50 * quantidade;
            }
            else if (codigo == 3)
            {
                preco = 5.00 * quantidade;
            }
            else if (codigo == 4)
            {
                preco = 2.00 * quantidade;
            }
            else if (codigo == 5)
            {
                preco = 1.50 * quantidade;
            }

            Console.WriteLine("Total: R${0:f2}", preco);

            //Exemplo de execução
            //Entrada 
            //3 e 2
            //Saída
            //Total: R$10,00
        }
    }
}
