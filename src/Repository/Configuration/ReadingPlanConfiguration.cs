using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class ReadingPlanConfiguration : IEntityTypeConfiguration<ReadingPlan>
{
    public void Configure(EntityTypeBuilder<ReadingPlan> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.GuidId);

        builder.HasOne(p => p.Book)
            .WithMany(p => p.ReadingPlans)
            .HasForeignKey(p => p.BookId)
            .IsRequired();
    }
}