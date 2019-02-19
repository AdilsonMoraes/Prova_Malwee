using Malveen.Dominio.Repository.Interface.Login.v1;
using Malween.Cliente.Autenticacao;
using Malween.Cliente.Autenticacao.Interface;
using Malween.Cliente.Servico.Atividades.v1.Servico;
using Malween.Cliente.Servico.Login.v1;
using Malween.Dominio.Servico.Interface.Atividades.v1;
using Malween.Dominio.Servico.Interface.Login.v1;
using Malween.Dominio.Servico.Interface.Mappers;
using Malween.Dominio.Servico.Mappers;
using Malween.Dominio.ValueObjects.Jwt;
using Microsoft.Extensions.DependencyInjection;
using Malveen.Dominio.Infraestrutura.Login.Repositorio;
using Malween.Cliente.Servico.Interface.DadosUsuario;
using Malween.Cliente.Servico.DadosUsuarioServico.v1;

namespace Malween.Cliente.IoC
{
    public class BootStrap
    {

        public static void RegistrarServico(IServiceCollection services)
        {
            Autenticacao(services);
            Login(services);
            Mapper(services);
            DadosUsuario(services);
        }

        private static void Autenticacao(IServiceCollection services)
        {
            services.AddTransient<IAtividadeServico, AtividadeServico>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddSingleton<JwtTokenSettings>();
        }

        private static void Login(IServiceCollection services)
        {
            services.AddTransient<IUsuarioLoginRepositorio, UsuarioLoginRepositorio>();
            services.AddTransient<IUsuarioLoginServico, UsuarioLoginServico>();
        }

        private static void Mapper(IServiceCollection services)
        {
            services.AddTransient<IErrosMapper, ErrosMapper>();
        }

        private static void DadosUsuario(IServiceCollection services)
        {
            services.AddScoped<IDadosUsuarioServico, DadosUsuarioServico>();
        }




    }
}
