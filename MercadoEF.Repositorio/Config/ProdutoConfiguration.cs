using MercadoEF.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoEF.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.NomeProduto)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.PrecoUnitario)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            builder
                .Property(p => p.Quantidade)
                .IsRequired();

            builder
                .HasMany(p => p.Vendas)
                .WithOne(v => v.Produto);
        }
    }
}
