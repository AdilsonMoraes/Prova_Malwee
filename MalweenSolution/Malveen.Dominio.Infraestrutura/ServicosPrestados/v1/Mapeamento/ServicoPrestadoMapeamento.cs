using Malween.Dominio.ServicoPrestado.v1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malveen.Dominio.Infraestrutura.ServicosPrestados.v1.Mapeamento
{
    public class ServicoPrestadoMapeamento : IEntityTypeConfiguration<ServicoPrestado>
    {
        public void Configure(EntityTypeBuilder<ServicoPrestado> builder)
        {

            builder.ToTable("ServicoPrestado");

            builder.HasKey(k => k.Id);

            builder.Property(h => h.Id)
                .HasColumnName("id_ServicoPrestado")
                .IsRequired();

            builder.Property(h => h.Descricao)
                .HasColumnName("descricao");

            builder.Property(h => h.DataAtendimento)
                .HasColumnName("Data_Atendimento");

            builder.Property(h => h.ValorServico)
                .HasColumnName("Valor_Servico");

            builder.Property(h => h.Tipo)
                .HasColumnName("Tipo");
        }
    }
}
