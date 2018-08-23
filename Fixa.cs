using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Fixa : Linha
    {
        private int valorMensalidade;

        public int ValorMensalidade
        {
            get { return valorMensalidade; }
            set { valorMensalidade = value; }
        }

        private int franquiaMensal;

        public int FranquiaMensal
        {
            get { return franquiaMensal; }
            set { franquiaMensal = value; }
        }

        private int restanteFranquia;

        public int RestanteFranquia
        {
            get { return restanteFranquia; }
            set { restanteFranquia = value; }
        }

        private bool faturaPaga;

        public bool FaturaPaga
        {
            get { return faturaPaga; }
            set { faturaPaga = value; }
        }

        public Fixa(string nome, int n, int ano, int mensalidade, int franquia, int restante, bool fatura) : base(nome, n, ano)
        {
            valorMensalidade = mensalidade;
            franquiaMensal = franquia;
            restanteFranquia = restante;
            faturaPaga = fatura;

        }

        public void Ligar(int qtdmin)
        {
            if (restanteFranquia >= qtdmin && FaturaPaga == true)
            {
                restanteFranquia -= qtdmin;
                Console.WriteLine("Ligação efetuada");
                Console.WriteLine("VocÊ tem {0} minutos", restanteFranquia);
            }
            else
            {
                Console.WriteLine("Ligação não efetuada - Saldo insuficiente");
            }


        }

        public void PagarFatura()
        {
            restanteFranquia = franquiaMensal;
            faturaPaga = true;
            Console.WriteLine("VocÊ tem {0} minutos", restanteFranquia);
        }
    }
}
