using Malween.Dominio.Mensagens.v1;
using Malween.Dominio.Servico.Interface.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malween.Dominio.Servico.Mappers
{
    public class ErrosMapper: IErrosMapper
    {
        public IEnumerable<Erro> Mapeia(List<string> errors)
        {
            List<Erro> erros = new List<Erro>();

            errors.ForEach(e =>
            {
                var errosSplit = e.Split('|');

                Erro erro = new Erro(errosSplit[0],
                    errosSplit[1]);

                erros.Add(erro);
            });

            return erros;
        }
    }
}
