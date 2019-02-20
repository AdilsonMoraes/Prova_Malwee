using Malween.Dominio;
using Malween.Dominio.Mensagens.v1.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Malwee.Dominio.DTO.ServicoPrestadoDTO.v1
{
    public class ServicoPrestadoConsultaDTO : BaseDTO
    {
        [JsonProperty("Cliente")]
        public string Cliente { get; set; }
        [JsonProperty("Estado")]
        public string Estado{ get; set; }
        [JsonProperty("Bairro")]
        public string Bairro { get; set; }
        [JsonProperty("Tipo_Servico")]
        public string Tipo { get; set; }
        [JsonProperty("Valor_Minimo")]
        public double ValorMinimo { get; set; }
        [JsonProperty("Valor_Maximo")]
        public double ValorMaximo { get; set; }
    }
}
