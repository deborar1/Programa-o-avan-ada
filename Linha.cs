using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Linha
    {
        protected string nomeTitular;

        public string NomeTitular
        {
            get { return nomeTitular; }
            set { nomeTitular = value; }
        }

        protected int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        protected int anoContratacao;

        public int AnoContratacao
        {
            get { return anoContratacao; }
            set { anoContratacao = value; }
        }

        public Linha(string nome, int n, int ano)
        {
            nomeTitular = nome;
            numero = n;
            anoContratacao = ano;
        }

    }
}
