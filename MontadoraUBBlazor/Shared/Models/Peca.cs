using System;
using System.Collections.Generic;
using System.Text;

namespace MontadoraUBBlazor.Shared.Models
{
   public class Peca
    {
        public int ID { get; set; }

        public string NomePeca { get; set; }

        public decimal ValorUnitPeca { get; set; }

        public int IDFornecedorPeca { get; set; }

        public string NomeFornecedorPeca { get; set; }

        public string CodigoPeca { get; set; }
    }
}
