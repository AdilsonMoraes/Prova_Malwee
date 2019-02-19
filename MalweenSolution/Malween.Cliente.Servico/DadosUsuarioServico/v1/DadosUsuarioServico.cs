using Malween.Cliente.Servico.Interface.DadosUsuario;
using System.Linq;
using System.Security.Claims;

namespace Malween.Cliente.Servico.DadosUsuarioServico.v1
{
    public class DadosUsuarioServico : IDadosUsuarioServico
    {
        public string RetornaTokenAutorizacaoDe(ClaimsPrincipal user)
        {
            return user
                .Claims
                .Where(x => x.Type == "t")
                .FirstOrDefault()
                .Value
                .Split("|")[0];
        }
    }
}
