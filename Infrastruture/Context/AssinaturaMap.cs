using CRUDJunior.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUDJunior.Context
{
    public class AssinaturaMap : IEntityTypeConfiguration<Assinatura>
    {
        public void Configure(EntityTypeBuilder<Assinatura> builder)
        {
            builder.ToTable(nameof(Assinatura));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

            builder
                .Property(x => x.DataCriacao)
                .IsRequired()
                .HasColumnName("DataCriacao")
                .HasColumnType("DATETIME");

            builder
                .Property(x => x.Inicio)
                .IsRequired()
                .HasColumnName("Inicio")
                .HasColumnType("DATETIME");

            builder
                .Property(x => x.Termino)
                .IsRequired()
                .HasColumnName("Termino")
                .HasColumnType("DATETIME");

            builder.Property(x => x.Expirada)
                .IsRequired()
                .HasColumnName("Expirada")
                .HasColumnType("BIT"); 
        }
    }
}
