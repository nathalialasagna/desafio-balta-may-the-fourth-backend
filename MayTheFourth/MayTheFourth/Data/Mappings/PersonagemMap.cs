using MayTheFourth.Entities;
using MayTheFourth.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFourth.Data.Mappings;

/// <summary>
/// PersonagemMAP
/// </summary>
public class PersonagemMap :IEntityTypeConfiguration<Personagem>
{
      /// <summary>
      /// Mapeamento da tabela
      /// </summary>
      /// <param name="builder"></param>
      public void Configure(EntityTypeBuilder<Personagem> builder)
      {
            // Tabela
            builder.ToTable("Personagem");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Altura)
                .IsRequired()
                .HasColumnName("Altura")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Peso)
                .IsRequired()
                .HasColumnName("Peso")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.CorCabelo)
                .IsRequired()
                .HasColumnName("CorCabelo")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.CorPele)
                .IsRequired()
                .HasColumnName("CorPele")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.CorOlhos)
                .IsRequired()
                .HasColumnName("CorOlhos")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.DataNascimento)
                .IsRequired()
                .HasColumnName("DataNascimento")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(60);

            builder.Property(x => x.Genero)
                .IsRequired()
                .HasColumnName("Genero")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

      }
}