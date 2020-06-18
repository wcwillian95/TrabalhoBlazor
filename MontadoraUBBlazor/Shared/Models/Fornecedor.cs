using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Numerics;
using System.Text;

namespace MontadoraUBBlazor.Shared.Models
{
   public class Fornecedor
    {
        public int ID { get; set; }

        public string NomeFornecedor { get; set; }

        public string CNPJFornecedor { get; set; }

        public string TelefoneFornecedor { get; set; }

        public string EmailFornecedor { get; set; }

        public DateTime DataCadastroFornecedor { get; set; }
    }
}
