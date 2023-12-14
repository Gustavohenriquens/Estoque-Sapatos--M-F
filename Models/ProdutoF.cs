using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_3.Models
{
    public class ProdutoF
    {
        public string Nome {get; set;}
        public int Identificador {get; set;}
        public int Quantidade {get; set; }
        public string Descricao  { get; set;}

        public ProdutoF(string nome, int identificador, int quantidade, string descricao)
        {
            Nome = nome;
            Identificador = identificador;
            Quantidade = quantidade;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"ID :{Identificador} - Nome :{Nome} - Quantidade :{Quantidade} - Descrição : {Descricao}";
        }
    }
}