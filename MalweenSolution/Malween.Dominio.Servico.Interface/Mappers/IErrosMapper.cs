using Malween.Dominio.Mensagens.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Dominio.Servico.Interface.Mappers
{
    public interface IErrosMapper
    {
        IEnumerable<Erro> Mapeia(List<string> errors);
    }
}
