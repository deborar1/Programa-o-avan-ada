using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Movel : Linha
    {
        Fixa linha;
        private float qtdAtualSaldo;

        public float QtdAtualSaldo
        {
            get { return qtdAtualSaldo; }
            set { qtdAtualSaldo = value; }
        }

        private string novaMensagem;

        public string NovaMensagem
        {
            get { return novaMensagem; }
            set { novaMensagem = value; }
        }

        private bool sms;

        public bool Sms
        {
            get { return sms; }
            set { sms = value; }
        }

        private bool planoDados;

        public bool PlanoDados
        {
            get { return planoDados; }
            set { planoDados = value; }
        }


        public Movel(string nome, int n, int ano, float saldo, string mensagem, bool s, bool Pdados) : base(nome, n, ano)
        {
            qtdAtualSaldo = saldo;
            novaMensagem = mensagem;
            sms = s;
            planoDados = Pdados;

        }
        public float Recarregar(int valorReais)
        {
            float novosaldo = qtdAtualSaldo + valorReais;

            Console.WriteLine("Seu saldo atual é {0}", novosaldo);
            return novosaldo;
        }

        public void Navegar(int qtdMb)
        {

            if (planoDados == true)
            {
                float saldodebitado = (qtdMb / 4) * 0.99f;
                qtdAtualSaldo -= saldodebitado;
                Console.WriteLine("Seu saldo atual é {0}", qtdAtualSaldo);
            }
            else
            {
                Console.WriteLine("Serviço indisponível");
            }
        }

        public void EnviarSms(int num, string msg)
        {
            if (sms == true)
            {
                Console.WriteLine("{0}  Mensagem enviada para {1}", msg, num);
                qtdAtualSaldo -= 0.10f;

            }
            else
            {
                Console.WriteLine("Serviço indisponível");
            }


        }



    }
}
