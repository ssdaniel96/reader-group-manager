using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class ReminderConfiguration : IEntityTypeConfiguration<Reminder>
{
    public void Configure(EntityTypeBuilder<Reminder> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.GuidId);

        builder.HasOne(p => p.KickOff)
            .WithMany()
            .HasForeignKey(p => p.KickOffId)
            .IsRequired();
        
        builder.HasOne(p => p.Responsible)
            .WithMany()
            .HasForeignKey(p => p.ResponsibleId)
            .IsRequired();
        
        builder.HasOne(p => p.Prayer)
            .WithMany()
            .HasForeignKey(p => p.PrayerId)
            .IsRequired();

        builder.OwnsOne(p => p.ReminderNote)
            .Property(p => p.Chapter)
            .HasColumnName("Chapter")
            .HasColumnType("varchar")
            .HasMaxLength(10)
            .IsRequired();
        
        builder.OwnsOne(p => p.ReminderNote)
            .Property(p => p.Page)
            .HasColumnName("Page")
            .IsRequired();
        
        builder.OwnsOne(p => p.ReminderNote)
            .Property(p => p.Paragraph)
            .HasColumnName("Paragraph")
            .IsRequired();
    }
}