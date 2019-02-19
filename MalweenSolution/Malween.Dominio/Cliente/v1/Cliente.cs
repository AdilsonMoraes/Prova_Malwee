using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Dominio.Cliente.v1
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
