using System;

namespace lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            double total = 0;
            double iten;
            int codLanche;

            Console.WriteLine("Informe o código e a quantidade do item que você deseja adquirir\n");
            Console.WriteLine(" 1 - Pizza R$20,00\n 2 - Batata Frita R$10,00\n 3 - Coxinha R$5,00\n");
            codLanche = Convert.ToInt32(Console.ReadLine());
            quantidade = Convert.ToInt32(Console.ReadLine());

            switch (codLanche)
            {
                case 1:
                    Console.WriteLine("Pizza" + " Quantidade: " + quantidade);
                    iten = 20.00;
                    total = quantidade * iten;
                    break;
                case 2:
                    Console.WriteLine("Batata Frita" + " Quantidade: " + quantidade);
                    iten = 10.00;
                    total = quantidade * iten;
                    break;
                case 3:
                    Console.WriteLine("Coxinha" + " Quantidade: " + quantidade);
                    iten = 5.00;
                    total = quantidade * iten;
                    break;
            }

            Console.WriteLine("Total a ser pago: R$ " + total.ToString("C") + "\n");hshs
    }
    }
}
