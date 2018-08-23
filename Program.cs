using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Movel Pessoa = new Movel("suzi", 99, 2018, 20, "teste", true, true);
            Fixa Pessoa2 = new Fixa("deborar", 00, 2017, 40, 60, 60, true);

            Pessoa.Recarregar(10);
            Pessoa.Navegar(10);
            Pessoa.EnviarSms(22, "teste1");


            Pessoa2.PagarFatura();
            Pessoa2.Ligar(10);

            Console.ReadKey();

        }
    }
}