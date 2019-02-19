﻿// <auto-generated />
using System;
using Malveen.Dominio.Infraestrutura.Contextos.v1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Malveen.Dominio.Infraestrutura.Migrations
{
    [DbContext(typeof(ContextoDominio))]
    [Migration("20190219182318_01CriacaoBanco")]
    partial class _01CriacaoBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Malween.Dominio.Cliente.v1.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_cliente")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnName("bairro")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Cidade")
                        .HasColumnName("cidade")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Estado")
                        .HasColumnName("estado")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Nome")
                        .HasColumnName("nome")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Malween.Dominio.Fornecedor.v1.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_fornecedor")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnName("nome")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("Malween.Dominio.Login.v1.UsuarioLogin", b =>
                {
                    b.Property<string>("Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NOME_USUARIO")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<bool>("IsAdministrator");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("SENHA")
                        .IsUnicode(false);

                    b.Property<string>("TokenAuth")
                        .HasColumnName("TokenAuth")
                        .IsUnicode(false);

                    b.HasKey("Usuario");

                    b.ToTable("USUARIO_LOGIN");
                });

            modelBuilder.Entity("Malween.Dominio.ServicoPrestado.v1.ServicoPrestado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_ServicoPrestado")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnName("Data_Atendimento");

                    b.Property<string>("Descricao")
                        .HasColumnName("descricao");

                    b.Property<string>("Tipo")
                        .HasColumnName("Tipo");

                    b.Property<double>("ValorServico")
                        .HasColumnName("Valor_Servico");

                    b.HasKey("Id");

                    b.ToTable("ServicoPrestado");
                });

            modelBuilder.Entity("Malween.Dominio.Usuario.v1.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_usuario")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Nome")
                        .HasColumnName("nome")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
