using System;
using System.Collections.Generic;
using System.Text;

namespace Malveen.Dominio.Repository.Interface.InterfaceGenerica.v1
{
    public interface IConsultaRepositorio<TEntity> where TEntity : class
    {
        TEntity ObterPorId(object id);
    }
}
