
using CRUDJunior.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUDJunior.Context
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable(nameof(Aluno));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

            builder.OwnsOne(x => x.NomeCompleto)
                .Property(x => x.PrimeiroNome)
                .IsRequired()
                .HasColumnName("PrimeiroNome")
                .HasMaxLength(50);

            builder.OwnsOne(x => x.NomeCompleto)
                .Property(x => x.UltimoNome)
                .IsRequired()
                .HasColumnName("UltimoNome")
                .HasMaxLength(50);

            builder.OwnsOne(x => x.CPF)
                .Property(x => x.Numero)
                .IsRequired()
                .HasColumnName("CPF")
                .HasMaxLength(50);

            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasColumnName("Telefone")
                .HasMaxLength(50);

            builder.Property(x => x.DataNascimento)
                .IsRequired()
                .HasColumnName("DataNascimento")
                .HasColumnType("DATETIME"); 

            builder.Property(x => x.Imagem)
                .IsRequired()
                .HasColumnName("Imagem")
                .HasMaxLength(50);


            //Relacionamento com Assinatura
            builder.HasMany(r => r.Assinaturas)
                .WithOne(r => r.Aluno)
                .HasForeignKey("AlunoId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
