﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(I => I.Id);

            builder.
                Property(I => I.ProdutoId)
                .IsRequired();
            builder
                .Property(I => I.Quantidade)
                .IsRequired();
        }
    }
}
