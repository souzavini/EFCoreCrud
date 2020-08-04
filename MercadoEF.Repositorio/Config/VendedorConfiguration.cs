using MercadoEF.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoEF.Repositorio.Config
{
    public class VendedorConfiguration : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.HasKey(v => v.Id);

            builder
                .Property(v => v.Nome);

            builder
                .HasMany(v => v.Vendas)
                .WithOne(ve => ve.Vendedor);
        }
    }
}
