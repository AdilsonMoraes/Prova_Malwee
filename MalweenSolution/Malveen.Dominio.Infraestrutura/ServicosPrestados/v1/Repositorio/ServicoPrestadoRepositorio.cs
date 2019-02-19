using Malveen.Dominio.Infraestrutura.Contextos.v1;
using Malveen.Dominio.Infraestrutura.InterfaceGenerica.v1.Repositorio;
using Malveen.Dominio.Repository.Interface.ServicosPrestados.v1;
using Malween.Dominio.ServicoPrestado.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malveen.Dominio.Infraestrutura.ServicosPrestados.v1.Repositorio
{
    public class ServicoPrestadoRepositorio : CrudRepositorio<ServicoPrestado>, IServicoPrestado
    {
        private readonly ContextoDominio _contexto;

        public ServicoPrestadoRepositorio(ContextoDominio contexto) : base(contexto)
        {
            _contexto = contexto;
        }

    }
}
