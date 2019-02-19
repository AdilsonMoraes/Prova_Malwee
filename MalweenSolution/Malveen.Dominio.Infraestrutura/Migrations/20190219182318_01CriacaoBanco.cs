using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Malveen.Dominio.Infraestrutura.Migrations
{
    public partial class _01CriacaoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id_cliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    bairro = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    cidade = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    estado = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    id_fornecedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.id_fornecedor);
                });

            migrationBuilder.CreateTable(
                name: "ServicoPrestado",
                columns: table => new
                {
                    id_ServicoPrestado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(nullable: true),
                    Data_Atendimento = table.Column<DateTime>(nullable: false),
                    Valor_Servico = table.Column<double>(nullable: false),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicoPrestado", x => x.id_ServicoPrestado);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id_usuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    nome = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO_LOGIN",
                columns: table => new
                {
                    NOME_USUARIO = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    SENHA = table.Column<string>(unicode: false, nullable: false),
                    IsAdministrator = table.Column<bool>(nullable: false),
                    TokenAuth = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO_LOGIN", x => x.NOME_USUARIO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "ServicoPrestado");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "USUARIO_LOGIN");
        }
    }
}
