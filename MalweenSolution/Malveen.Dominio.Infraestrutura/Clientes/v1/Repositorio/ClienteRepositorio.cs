﻿using Malveen.Dominio.Infraestrutura.Contextos.v1;
using Malveen.Dominio.Infraestrutura.InterfaceGenerica.v1.Repositorio;
using Malveen.Dominio.Repository.Interface.Clientes.v1;
using Malween.Dominio.Clientes.v1;

namespace Malveen.Dominio.Infraestrutura.Clientes.v1.Repositorio
{
    public class ClienteRepositorio : CrudRepositorio<Cliente>, IClienteRepositorio
    {
        private readonly ContextoDominio _contexto;

        public ClienteRepositorio(ContextoDominio contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
