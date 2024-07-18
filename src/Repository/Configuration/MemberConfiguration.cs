using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class MemberConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.GuidId);

        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .HasColumnType("varchar")
            .IsRequired();
        
        builder.Property(p => p.Enabled)
            .IsRequired();

        builder.HasOne(p => p.Group)
            .WithMany(p => p.Members)
            .HasForeignKey(p => p.GroupId)
            .IsRequired();
    }
}