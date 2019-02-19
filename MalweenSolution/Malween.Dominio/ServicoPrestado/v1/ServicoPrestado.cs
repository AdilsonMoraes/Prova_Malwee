using Malween.Dominio.Mensagens.v1.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Malween.Dominio.ServicoPrestado.v1
{
    public class ServicoPrestado 
    {
        [JsonProperty("id_ServicoPrestado")]
        public int Id { get; set; }
        [JsonProperty("descricao")]
        public string Descricao { get; set; }
        [JsonProperty("Data_Atendimento")]
        public DateTime DataAtendimento { get; set; }
        [JsonProperty("Valor_Servico")]
        public double ValorServico { get; set; }
        [JsonProperty("Tipo")]
        public string Tipo { get; set; }
    }
}
