using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Malween.Cliente.Servico.Interface.DadosUsuario
{
    public interface IDadosUsuarioServico
    {
        string RetornaTokenAutorizacaoDe(ClaimsPrincipal user);
    }
}
