using Malween.Dominio;
using Malween.Dominio.Mensagens.v1.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Malwee.Dominio.DTO.ServicoPrestadoDTO.v1
{
    public class ServicoPrestadoConsultaDTO : BaseDTO, IValidatableObject
    {
        [JsonProperty("descricao")]
        public string Descricao { get; set; }
        [JsonProperty("Data_Atendimento")]
        public DateTime DataAtendimento { get; set; }
        [JsonProperty("Valor_Servico")]
        public double ValorServico { get; set; }
        [JsonProperty("Tipo")]
        public string Tipo { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Descricao))
            {
                yield return new ValidationResult(GeralEnumException.DescricaoEmptyOrNull.ToString());
            }
            if (ValorServico == 0)
            {
                yield return new ValidationResult(GeralEnumException.ValorServicoZerado.ToString());
            }
            if (String.IsNullOrEmpty(Tipo))
            {
                yield return new ValidationResult(GeralEnumException.TipoEmptyOrNull.ToString());
            }
        }
    }
}
