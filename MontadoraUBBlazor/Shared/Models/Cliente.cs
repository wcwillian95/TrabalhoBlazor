using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MontadoraUBBlazor.Shared.Models
{
   public class Cliente
    {
        public int ID { get; set; }

        public string NomeCliente { get; set; }

        public string CPFCliente { get; set; }

        public DateTime NascimentoCliente { get; set; }

        public string TelefoneCliente { get; set; }

        public string EmailCliente { get; set; }

        public string CEPCliente { get; set; }

        public string RuaCliente { get; set; }

        public string BairroCliente { get; set; }

        public string CidadeCliente { get; set; }

        public string EstadoCliente { get; set; }

        public DateTime DataCadastroCliente { get; set; }
    }
}
