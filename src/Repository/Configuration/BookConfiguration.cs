using System.Runtime.CompilerServices;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.GuidId);
        
        builder.Property(p => p.Author)
            .HasMaxLength(100)
            .HasColumnType("varchar");

        builder.Property(p => p.Title)
            .HasMaxLength(100)
            .HasColumnType("varchar")
            .IsRequired();
        
        builder.Property(p => p.Pages)
            .IsRequired();

        builder.HasOne(p => p.Group)
            .WithMany(p => p.Books)
            .HasForeignKey(p => p.GroupId)
            .IsRequired();

    }
}