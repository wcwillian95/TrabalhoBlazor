using System;
using System.Collections.Generic;
using System.Text;

namespace MontadoraUBBlazor.Shared.Models
{
   public class Compra
    {
        public int ID { get; set; }

        public string NomePecaCompra { get; set; }

        public int IDPecaCompra { get; set; }

        public string CodigoPecaCompra { get; set; }

        public decimal ValorUnitPecaCompra { get; set; }

        public int QtdPecaCompra { get; set; }

        public decimal ValorTotalCompra { get; set; }

        public int IDFornecedorCompra { get; set; }

        public string NomeFornecedorCompra { get; set; }

        public int IDFuncionarioCompra { get; set; }

        public string NomeFuncionarioCompra { get; set; }

        public DateTime DataCompra { get; set; }

    }
}
