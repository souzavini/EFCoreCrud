using MercadoEF.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoEF.Repositorio.Config
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.HasKey(v => v.Id);

            builder
                .Property(v => v.DataPedido)
                .IsRequired();

            builder
                .Property(v => v.Quantidade)
                .IsRequired();
                
        }
    }
}
