﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Malveen.Dominio.Repository.Interface.InterfaceGenerica.v1
{
    public interface ICrudRepositorio<TEntity> where TEntity : class
    {
        void Cadastra(TEntity item);
        void Altera(TEntity item);
        void Deleta(TEntity item);
    }
}
