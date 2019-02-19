using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Dominio.ServicoPrestado.v1
{
    public class ServicoPrestado
    {
        public int id { get; set; }
        public string Descricao{ get; set; }
        public DateTime Data_Atendimento { get; set; }
        public double Valor_Servico { get; set; }
        public string Tipo { get; set; }
    }
}
