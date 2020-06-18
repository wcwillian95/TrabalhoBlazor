using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace MontadoraUBBlazor.Shared.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string NomeFunc { get; set; }
        public string CPFFunc { get; set; }
        public string TelefoneFunc { get; set; }
        public string EmailFunc { get; set; }
        public string CEPFunc { get; set; }
        public string RuaFunc { get; set; }
        public string BairroFunc { get; set; }
        public string CidadeFunc { get; set; }
        public string EstadoFunc { get; set; }
        public DateTime NascimentoFunc { get; set; }
        public DateTime EntradaFunc { get; set; }
        public DateTime SaidaFunc { get; set; }

        public string CargoFunc { get; set; }

        public string StatusFunc { get; set; }

    }
}
