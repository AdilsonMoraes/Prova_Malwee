using Malveen.Dominio.Infraestrutura.Clientes.v1.Repositorio;
using Malveen.Dominio.Infraestrutura.Fornecedores.v1.Repositorio;
using Malveen.Dominio.Infraestrutura.Login.v1.Repositorio;
using Malveen.Dominio.Infraestrutura.ServicosPrestados.v1.Repositorio;
using Malveen.Dominio.Infraestrutura.Usuarios.v1.Repositorio;
using Malveen.Dominio.Repository.Interface.Clientes.v1;
using Malveen.Dominio.Repository.Interface.Fornecedores.v1;
using Malveen.Dominio.Repository.Interface.Login.v1;
using Malveen.Dominio.Repository.Interface.ServicosPrestados.v1;
using Malveen.Dominio.Repository.Interface.Usuarios.v1;
using Malween.Cliente.Autenticacao;
using Malween.Cliente.Autenticacao.Interface;
using Malween.Cliente.Servico.Atividades.v1.Servico;
using Malween.Cliente.Servico.Cliente.v1.Servico;
using Malween.Cliente.Servico.DadosUsuarioServico.v1.Servico;
using Malween.Cliente.Servico.Fornecedor.v1.Servico;
using Malween.Cliente.Servico.Interface.Cliente;
using Malween.Cliente.Servico.Interface.DadosUsuario;
using Malween.Cliente.Servico.Interface.Fornecedor;
using Malween.Cliente.Servico.Interface.ServicoPrestado;
using Malween.Cliente.Servico.Interface.Usuario;
using Malween.Cliente.Servico.Login.v1;
using Malween.Cliente.Servico.ServicosPrestados.v1.Servico;
using Malween.Cliente.Servico.Usuario.v1.Servico;
using Malween.Dominio.Servico.Interface.Atividades.v1;
using Malween.Dominio.Servico.Interface.Login.v1;
using Malween.Dominio.Servico.Interface.Mappers;
using Malween.Dominio.Servico.Mappers;
using Malween.Dominio.ValueObjects.Jwt;
using Microsoft.Extensions.DependencyInjection;

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
            ServicoPrestado(services);
            Cliente(services);
            Fornecedor(services);
            Usuario(services);
        }

        private static void Autenticacao(IServiceCollection services)
        {
            services.AddScoped<IAtividadeServico, AtividadeServico>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddSingleton<JwtTokenSettings>();
        }

        private static void Login(IServiceCollection services)
        {
            services.AddScoped<IUsuarioLoginRepositorio, UsuarioLoginRepositorio>();
            services.AddScoped<IUsuarioLoginServico, UsuarioLoginServico>();
        }

        private static void Mapper(IServiceCollection services)
        {
            services.AddTransient<IErrosMapper, ErrosMapper>();
        }

        private static void DadosUsuario(IServiceCollection services)
        {
            services.AddScoped<IDadosUsuarioServico, DadosUsuarioServico>();
        }

        private static void ServicoPrestado(IServiceCollection services)
        {
            services.AddScoped<IServicoPrestadoServico, ServicoPrestadoServico>();
            services.AddScoped<IServicoPrestadoRepositorio, ServicoPrestadoRepositorio>();
        }

        private static void Cliente(IServiceCollection services)
        {
            services.AddScoped<IClienteServico, ClienteServico>();
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
        }

        private static void Fornecedor(IServiceCollection services)
        {
            services.AddScoped<IFornecedorServico, FornecedorServico>();
            services.AddScoped<IFornecedorRepositorio, FornecedorRepositorio>();
        }

        private static void Usuario(IServiceCollection services)
        {
            services.AddScoped<IUsuarioServico, UsuarioServico>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
        }
    }
}
