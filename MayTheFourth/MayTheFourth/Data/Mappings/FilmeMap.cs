using MayTheFourth.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFourth.Data.Mappings;

/// <summary>
/// FilmeMAP
/// </summary>
public class FilmeMap : IEntityTypeConfiguration<Filme>
{
    /// <summary>
    /// Mapeamento da tabela
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<Filme> builder)
    {
        // Tabela
        builder.ToTable("Filme");

        // Chave Primária
        builder.HasKey(x => x.Id);

        // Identity
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        
        // Propriedades
        builder.Property(x => x.Titulo)
            .IsRequired()
            .HasColumnName("Titulo")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(100);
        
        builder.Property(x => x.Episodio)
            .IsRequired()
            .HasColumnName("Episodio")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(100);
        
        builder.Property(x => x.Diretor)
            .IsRequired()
            .HasColumnName("Diretor")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(60);
        
        builder.Property(x => x.Produtor)
            .IsRequired()
            .HasColumnName("Produtor")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(60);

        builder.Property(x => x.DataLancamento)
            .IsRequired()
            .HasColumnName("DataLancamento")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(60);
        
    }
}