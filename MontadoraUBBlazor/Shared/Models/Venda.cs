using System;
using System.Collections.Generic;
using System.Text;

namespace MontadoraUBBlazor.Shared.Models
{
    public class Venda
    {
        public int ID { get; set; }

        public string CodPecaVenda { get; set; }
        public decimal QtdPecaVenda { get; set; }
        public decimal ValorUnitPecaVenda { get; set; }
        public decimal ValorTotalVenda { get; set; }
        public int IDClienteVenda { get; set; }
        public string NomeClienteVenda { get; set; }

        public int IDFuncVenda { get; set; }
        public string NomeFuncVenda { get; set; }

        public DateTime DataVenda { get; set; }
    }
}