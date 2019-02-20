using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Dominio.Mensagens.v1.Enum
{
    public class GeralEnumException : BaseEnum<GeralEnumException, string>
    {
        protected GeralEnumException(int codigo, string valor) : base(codigo, valor)
        {
        }

        public static GeralEnumException ProblemaParaAlterarSenha = new GeralEnumException(1, "Houve um problema na hora de alterar a senha, Verifique se o Usuário é Válido.");
        public static GeralEnumException LoginJaCadastrado = new GeralEnumException(2, "Login Já Cadastrado.");
        public static GeralEnumException DescricaoEmptyOrNull = new GeralEnumException(3, "Campo descrição em branco ou null.");
        public static GeralEnumException ValorServicoZerado = new GeralEnumException(4, "Valor do Serviço Prestado está Zero(0).");
        public static GeralEnumException TipoEmptyOrNull = new GeralEnumException(5, "Campo Tipo esta em branco ou null.");
        public static GeralEnumException EstadoEmptyOrNull = new GeralEnumException(6, "Campo Estado esta em branco ou null.");
        public static GeralEnumException CidadeEmptyOrNull = new GeralEnumException(7, "Campo Cidade esta em branco ou null.");
        public static GeralEnumException BairroEmptyOrNull = new GeralEnumException(8, "Campo Bairro esta em branco ou null.");
        public static GeralEnumException ValorMinimoEmptyOrNull = new GeralEnumException(9, "Campo Valor Minimo esta em branco ou null.");
        public static GeralEnumException ValorMaximoEmptyOrNull = new GeralEnumException(10, "Campo Maximo esta em branco ou null.");
        public static GeralEnumException ClienteEmptyOrNull = new GeralEnumException(11, "Campo Cliente esta em branco ou null.");
    }
}
