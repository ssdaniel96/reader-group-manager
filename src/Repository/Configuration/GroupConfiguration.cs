using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.GuidId);
        
        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .HasColumnType("varchar")
            .IsRequired();
    }
}